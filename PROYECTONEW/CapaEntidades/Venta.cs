using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class Venta
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int Id_MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Usuario { get; set; }
    }
}
