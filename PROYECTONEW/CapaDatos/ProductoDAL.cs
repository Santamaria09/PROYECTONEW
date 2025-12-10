using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTONEW.CapaDatos
{
    public class ProductoDAL
    {
        public static DataTable Listar()
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, Precio, NumeroSerie, Stock, Id_EstadoActual FROM Producto where Id_EstadoActual =1";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(data);
                }
            }
            return data;
        }
        public static int Insertar(Producto p)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "INSERT INTO Producto (Nombre, Precio, NumeroSerie, Stock, Id_Empresa, Id_EstadoActual, Id_UnidadPeso) VALUES (@nombre, @precio, @numeroserie, @stock, @id_empresa, @id_estadoactual, @id_unidadpeso); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@numeroserie", p.NumeroSerie);
                    cmd.Parameters.AddWithValue("@Stock", p.Stock);
                    cmd.Parameters.AddWithValue("@id_empresa", p.Id_Empresa);
                    cmd.Parameters.AddWithValue("@id_estadoactual", p.Id_EstadoActual);
                    cmd.Parameters.AddWithValue("@id_unidadpeso", p.Id_UnidadPeso);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Producto WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public bool Actualizar(Producto p)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Producto SET Nombre=@nombre, Precio= @precio, NumeroSerie=@numeroserie, Stock=@stock, Id_Empresa=@id_empresa, EstadoActual=@estadoactual, UnidadPeso=@unidadpeso WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@precio", p.Precio);
                    cmd.Parameters.AddWithValue("@numeroserie", p.NumeroSerie);
                    cmd.Parameters.AddWithValue("@Stock", p.Stock);
                    cmd.Parameters.AddWithValue("@id_empresa", p.Id_Empresa);
                    cmd.Parameters.AddWithValue("@id_estadoactual", p.Id_EstadoActual);
                    cmd.Parameters.AddWithValue("@id_unidadpeso", p.Id_UnidadPeso);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }


        public static int ObtenerStock(int IdProducto)
        {
            int Stock = 0;

            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "Select Stock FROM Producto WHERE ID=@id";
                //Los datos registrados en la base de datos
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@id", IdProducto);
                    cn.Open();// Abrir la conexion
                    object result = cmd.ExecuteScalar();
                    if (result != null)

                        Stock = Convert.ToInt32(result);

                }

            }
            return Stock;

        }

        public static DataTable ListarPorEstado(int Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT p.Id, p.Nombre, p.Precio, p.Stock, e.Nombre as Empresa, u.Nombre as UnidadPeso, a.Nombre as EstadoActual
              FROM Producto p INNER JOIN Empresa e on p.Id_Empresa = e.Id 
                    INNER JOIN UnidadPeso u on p.Id_UnidadPeso= u.Id
                  INNER JOIN EstadoActual a on p.Id_EstadoActual= a.Id
                          where a.Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
                return dt;
            }
        }

    }
}
