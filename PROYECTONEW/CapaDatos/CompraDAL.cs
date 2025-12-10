using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class CompraDAL
    {
        public static (bool Exito, string Mensaje) RegistrarCompra(Compra compra, List<CompraItem> detalles)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // INSERT COMPRA
                    string sqlCompra = @"INSERT INTO Compra(Fecha, TotalCompra, Id_Empresa)
                                     VALUES (@fecha, @totalCompra, @id_empresa);
                                     SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlCompra, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@fecha", compra.Fecha);
                        cmd.Parameters.AddWithValue("@totalCompra", compra.TotalCompra);
                        cmd.Parameters.AddWithValue("@id_empresa", compra.Id_Empresa);
                        

                        compra.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string sqlDetalle = @"INSERT INTO CompraItem(Cantidad, PrecioCompra, SubTotal, Id_Compra, Id_Producto)
                                     VALUES (@cantidad, @precioCompra, @subTotal, @id_compra, @id_producto);";

                    // Acumulador para actualizar stock
                    var acumulador = new Dictionary<int, int>();
                    foreach (var d in detalles)
                    {
                        using (SqlCommand cmdDet = new SqlCommand(sqlDetalle, con, tx))
                        {
                            cmdDet.Parameters.AddWithValue("@cantidad", d.Cantidad);
                            cmdDet.Parameters.AddWithValue("@precioCompra", d.PrecioCompra);
                            cmdDet.Parameters.AddWithValue("@subTotal", d.SubTotal);
                            cmdDet.Parameters.AddWithValue("@id_compra", compra.Id);
                            cmdDet.Parameters.AddWithValue("@id_producto", d.Id_Producto);

                            cmdDet.ExecuteNonQuery();
                        }

                        if (!acumulador.ContainsKey(d.Id_Producto))
                            acumulador[d.Id_Producto] = 0;
                        acumulador[d.Id_Producto] += d.Cantidad;

                    }
                    string sqlStock = @"UPDATE Producto SET Stock = Stock + @Cant WHERE Id = @IdProducto;";

                    foreach (var item in acumulador)
                    {
                        using (SqlCommand cmdStock = new SqlCommand(sqlStock, con, tx))
                        {
                            cmdStock.Parameters.AddWithValue("@Cant", item.Value);
                            cmdStock.Parameters.AddWithValue("@IdProducto", item.Key);
                            cmdStock.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return (true, "Compra registrada con éxito. ID generado: " + compra.Id);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return (false, "Error al registrar la compra: " + ex.Message);
                }
            }
        }
    }
}