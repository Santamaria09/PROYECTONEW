using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class VentaDAL
    {
        public static (bool Exito, string Mensaje) RegistrarVenta(Venta venta, List<VentaItem> detalles)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    string sqlVenta = @"INSERT INTO Venta(Fecha, Total, Id_MetodoPago, Id_Cliente, Id_Usuario) Values (@fecha, @total, @id_metodopago, @Id_Cliente, @Id_Usuario); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(sqlVenta, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                        cmd.Parameters.AddWithValue("@Total", venta.MontoTotal);
                        cmd.Parameters.AddWithValue("@id_metodopago", venta.Id_MetodoPago);
                        cmd.Parameters.AddWithValue("@Id_Cliente", venta.Id_Cliente);
                        cmd.Parameters.AddWithValue("@Id_Usuario", venta.Id_Usuario);


                        //recuperar ID
                        venta.Id = Convert.ToInt32(cmd.ExecuteScalar());

                        string sqlDetalle = @"INSERT INTO VentaItem(Cantidad, PrecioUnitario, EsSubsidio, SubTotal, Id_Venta, Id_Producto) VALUES (@cantidad, @precioUnitario, @essubsidio, @subTotal, @id_Venta, @id_Producto);";

                        var acumulador = new Dictionary<int, int>();

                        foreach (var d in detalles)
                        {
                            using (SqlCommand cmdDet = new SqlCommand(sqlDetalle, con, tx))
                            {
                                cmdDet.Parameters.AddWithValue("@cantidad", d.Cantidad);
                                cmdDet.Parameters.AddWithValue("@precioUnitario", d.PrecioUnitario);
                                cmdDet.Parameters.AddWithValue("@essubsidio", d.EsSubsidio);
                                cmdDet.Parameters.AddWithValue("@subTotal", d.SubTotal);
                                cmdDet.Parameters.AddWithValue("@id_Venta", venta.Id);
                                cmdDet.Parameters.AddWithValue("@id_Producto", d.Id_Producto);

                                cmdDet.ExecuteNonQuery();
                            }

                            if (!acumulador.ContainsKey(d.Id_Producto))
                                acumulador[d.Id_Producto] = 0;
                            acumulador[d.Id_Producto] += d.Cantidad;


                        }
                        //Descontar Stock
                        string sqlStock = @"UPDATE Producto SET Stock = Stock-@Cant WHERE Id= @IdProducto AND Stock >= @Cant;";

                        foreach (var item in acumulador)
                        {
                            using (SqlCommand cmdStock = new SqlCommand(sqlStock, con, tx))
                            {
                                cmdStock.Parameters.AddWithValue("@Cant", item.Value);
                                cmdStock.Parameters.AddWithValue("@IdProducto", item.Key);

                                int filas = cmdStock.ExecuteNonQuery();

                                if (filas == 0)
                                    throw new Exception("Stock insuficiente para el Producto ID: " + item.Key);
                            }
                        }
                        //Confirma Transaccion
                        tx.Commit();
                        return (true, "Venta registrada con exito. ID generado:" + venta.Id);

                    }

                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return (false, "Error al registrar la Venta:" + ex.Message);
                }

            }
        }
    }
}
