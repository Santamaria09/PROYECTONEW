using PROYECTONEW.CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    internal class RolDAL
    {
        public static List<Rol> ListarRol()
        {
            List<Rol> rl = new List<Rol>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Rol";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            rl.Add(new Rol
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),

                            });
                        }
                    }
                }
            }
            return rl;
        }
    }
}
