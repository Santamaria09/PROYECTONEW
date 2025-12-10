using PROYECTONEW.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    public class ReporteCompraBLL
    {
        public ReporteCompraDAL dal = new ReporteCompraDAL();
        public DataTable ObtenerReporteCompra(DateTime fechaInicio, DateTime fechaFin)
        {
            // Validaciones simples: fecha inicio no mayor a fecha fin
            if (fechaInicio > fechaFin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha fin.");

            // Llamada a la capa de datos
            return dal.ReporteCompra(fechaInicio, fechaFin);
        }
        public static DataTable ObtenerCompraPorPeriodo(DateTime inicio, DateTime fin)
        {
            return ReporteCompraDAL.ObtenerCompraPorPeriodo(inicio, fin);
        }
    }
}
