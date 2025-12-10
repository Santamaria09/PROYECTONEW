using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveHash { get; set; }
        public int Id_Rol { get; set; }
        public bool Estado { get; set; }

        //método para cuando cerremos sesión, borra los datos guardados.
        public void Cerrar()
        {
            this.Id = 0;
            this.NombreUsuario = null;
            this.Id_Rol = 0;
            this.ClaveHash = null;
            this.Estado = false;
        }

    }
}
