using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string NumeroSerie { get; set; }
        public int Stock { get; set; }
        public int Id_Marca { get; set; }
        public string Id_EstadoActual { get; set; }
        public int Id_UnidadPeso { get; set; }

    }
}
