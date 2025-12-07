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
    public class ClientesDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre, Telefono, Direccion, Estado FROM Cliente";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        public int Insertar(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "INSERT INTO Cliente (Nombre, Telefono, Direccion, Estado) values (@nombre, @telefono, @direccion, @estado); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }


        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Cliente WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public bool Actualizar(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Cliente SET Nombre=@nombre, Telefono= @telefono, Direccion=@direccion, Estado=@estado WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public DataTable Buscar(string Filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, Telefono, Direccion, Estado FROM Cliente WHERE Nombre LIKE @Filtro or Telefono LIKE @Filtro";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + Filtro + "%");
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }

        }

        public static List<Cliente> PanelDeContactos()
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Cliente WHERE Estado = 1;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Cliente
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),

                            });
                        }
                    }
                }
                return Lista;
            }


        }

       
        
    }
}
