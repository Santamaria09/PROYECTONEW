using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class ReporteCompraDAL
    {
        /// Obtiene un DataTable con las ventas entre dos fechas.
        public DataTable ReporteCompra(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();

            // Usamos using para asegurar el Dispose de la conexión y el comando
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_reporte_compras_periodo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametrizamos las fechas
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);

                    con.Open();

                    // Ejecutamos el lector y cargamos el DataTable
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
            }

            return tabla;
        }

        public static DataTable ObtenerCompraPorPeriodo(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_reporte_compras_periodo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaInicio", inicio);
                cmd.Parameters.AddWithValue("@FechaFin", fin);

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
