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
        public static List<Rol> ListarRol()
        {
            return RolDAL.ListarRol();

        }
    }
}
