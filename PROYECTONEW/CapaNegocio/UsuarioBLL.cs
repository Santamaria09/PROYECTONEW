using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    internal class UsuarioBLL
    {
        public static List<Usuario> Listar()
        {
            return UsuarioDAL.Listar();
        }
        public static Usuario Obtener(int id)
        {
            // Busca el usuario en la lista de todos los usuarios
            return UsuarioDAL.Listar().FirstOrDefault(u => u.IdUsuario == id);
        }

        public static bool Eliminar(int id)
        {
            return UsuarioDAL.Eliminar(id);
        }

        public static Usuario Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("Debe ingresar usuario y contraseña.");

            string hash = Seguridad.Hash_SHA256(clave);
            return UsuarioDAL.Login(usuario, hash);
        }

       // public static int Insertar(string nombreUsuario, string clave, string rol)
       // {
           // if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave))
               // throw new ArgumentException("Usuario y contraseña requeridos.");

          //  string hash = Seguridad.Hash_SHA256(clave);
           // return UsuarioDAL.Insertar(nombreUsuario.Trim(), hash, rol);
       // }

        public static bool Actualizar(int id, string nombreUsuario, string rol, bool estado)
        {
            return UsuarioDAL.Actualizar(id, nombreUsuario.Trim(), rol, estado);
        }

        public static bool CambiarClave(int id, string claveNueva)
        {
            if (string.IsNullOrWhiteSpace(claveNueva))
                throw new ArgumentException("La nueva contraseña no puede estar vacía.");

            string hash = Seguridad.Hash_SHA256(claveNueva);
            return UsuarioDAL.CambiarClave(id, hash);
        }


    }
}
