using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class SesionActual
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static int Id_Rol { get; set; }

        //método para cuando cerremos sesión, borra los datos guardados.
        public static void Cerrar()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            Id_Rol = 0;

        }
    }
}
