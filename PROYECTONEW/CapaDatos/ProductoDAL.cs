using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class ProductoDAL
    {
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

        public static DataTable Buscar (string texto)
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"Select p.Id, p.Nombre, p.Precio, p.Stock, m.Modelo As Marca, e.Nombre as EtadoActual FROM Producto p INNER JOIN Marca m ON p.Id_Marca = m.Id 
                    inner join EstadoActual e on p.Id_EstadoActual = e.Id
                    WHERE m.Empresa LIKE @texto + '%';";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@texto", texto);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Tabla.Load(dr);
                    }
                }
            }
            return Tabla;
        }

        public static DataTable Listar()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"Select p.Id, p.Nombre, p.Precio, p.Stock, m.Modelo As Marca, e.Nombre as EtadoActual FROM Producto p INNER JOIN Marca m ON p.Id_Marca = m.Id 
                    inner join EstadoActual e on p.Id_EstadoActual = e.Id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Tabla.Load(dr);
                    }
                }

            }
            return Tabla;
        }

        public static DataTable General()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"Select p.Id, p.Nombre, p.Precio, p.Stock, m.Modelo As Marca, e.Nombre as EtadoActual FROM Producto p INNER JOIN Marca m ON p.Id_Marca = m.Id 
                    inner join EstadoActual e on p.Id_EstadoActual = e.Id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Tabla.Load(dr);
                    }
                }

            }
            return Tabla;



        }
    }
}
