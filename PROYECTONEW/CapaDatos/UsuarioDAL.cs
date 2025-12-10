using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class UsuarioDAL
    {
        //Metodo que valida nombre de usuario, clave y estado para logearnos
        public static Usuario Login(string nombreUsuario, string claveHash)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, NombreUsuario, Estado, Id_Rol FROM Usuario WHERE NombreUsuario=@u AND ClaveHash=@h AND Estado=1", con))
                {
                    cmd.Parameters.AddWithValue("@u", nombreUsuario);
                    cmd.Parameters.AddWithValue("@h", claveHash);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                Id_Rol = Convert.ToInt32(dr["Id_Rol"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Listar todos los usuarios
        public static List<Usuario> Listar()
        {
            var lista = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, NombreUsuario, Estado, Id_Rol FROM Usuario", con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Usuario
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            NombreUsuario = dr["NombreUsuario"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"]),
                            Id_Rol = Convert.ToInt32(dr["Id_Rol"])
                        });
                    }
                }
            }
            return lista;
        }

        // Insertar usuario (recibe hash ya calculado)
        public static int Insertar(string nombreUsuario, string claveHash, int idRol)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Usuario (NombreUsuario, ClaveHash, Estado, Fecha, Id_Rol) VALUES (@u, @h, 1, GETDATE(), @r); SELECT SCOPE_IDENTITY();", con))
                {
                    cmd.Parameters.AddWithValue("@u", nombreUsuario);
                    cmd.Parameters.AddWithValue("@h", claveHash);
                    cmd.Parameters.AddWithValue("@r", idRol);

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        // Actualizar (no actualiza clave)
        public static bool Actualizar(int Id, string nombreUsuario, int idRol, bool estado)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Usuario SET NombreUsuario=@u, Id_Rol=@r, Estado=@e WHERE Id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@u", nombreUsuario);
                    cmd.Parameters.AddWithValue("@r", idRol);
                    cmd.Parameters.AddWithValue("@e", estado);
                    cmd.Parameters.AddWithValue("@id", Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        //Eliminar Usuario
        public static bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cambiar clave (recibe hash nuevo)
        public static bool CambiarClave(int id, string claveHashNueva)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Usuario SET ClaveHash=@h WHERE Id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@h", claveHashNueva);
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
