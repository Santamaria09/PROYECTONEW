using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaEntidades
{
    public class Validaciones
    {
        public static bool EsDecimal(String s)
        {
            decimal d;
            return decimal.TryParse(s, out d);
        }
        public static bool EsEntero(String s)
        {
            int i;
            return int.TryParse(s, out i);
        }
    }
}
