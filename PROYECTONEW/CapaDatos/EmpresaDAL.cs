using PROYECTONEW.CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaDatos
{
    public class EmpresaDAL
    {
        public DataTable Listar()
        {
            DataTable lt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre, TelefonoEmpresa, Direccion FROM Empresa";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(lt);
                }
            }
            return lt;
        }

        public int Insertar(Empresa e)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "INSERT INTO Empresa (Nombre, TelefonoEmpresa, Direccion) values (@nombre, @telefonoempresa, @direccion); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", e.Nombre);
                    cmd.Parameters.AddWithValue("@telefonoEmpresa", e.TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("@direccion", e.Direccion);
                    
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }


        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Empresa WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public bool Actualizar(Empresa e)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Empresa SET Nombre=@nombre, TelefonoEmpresa= @telefonoempresa, Direccion=@direccion WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", e.Id);
                    cmd.Parameters.AddWithValue("@nombre", e.Nombre);
                    cmd.Parameters.AddWithValue("@telefonoEmpresa", e.TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("@direccion", e.Direccion);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public DataTable Buscar(string Filtro)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, TelefonoEmpresa, Direccion FROM Empresa WHERE Nombre LIKE @Filtro";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + Filtro + "%");
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(data);
                    return data;
                }
            }

        }
        public static List<Empresa> Contactos()
        {
            List<Empresa> lista = new List<Empresa>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre From Empresa";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empresa
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),

                            });

                        }
                    }

                }
                return lista;

            }
        }

    }
}
