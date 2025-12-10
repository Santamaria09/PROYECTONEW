using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    public class RolBLL
    {
        // LISTAR
        // LISTAR ROLES
        public static List<Rol> Listar()
        {
            return RolDAL.Listar(); // Usar la capa de datos de roles
        }

        // INSERTAR ROL
        public static int Insertar(string nombreRol)
        {
            return RolDAL.Insertar(nombreRol);
        }

        // ACTUALIZAR ROL
        public static bool Actualizar(int id, string nombreRol)
        {
            return RolDAL.Actualizar(id, nombreRol);
        }

        // ELIMINAR ROL
        public static bool Eliminar(int id)
        {
            return RolDAL.Eliminar(id);
        }
    }
}
