using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class VentaItem
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool EsSubsidio { get; set; }
        public decimal SubTotal { get; set; }

        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
    }
}
