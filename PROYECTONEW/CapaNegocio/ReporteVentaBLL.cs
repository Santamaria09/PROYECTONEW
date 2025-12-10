using PROYECTONEW.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    public class ReporteVentaBLL
    {
        public ReporteVentaDAL dal = new ReporteVentaDAL();
        public DataTable ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            // Validaciones simples: fecha inicio no mayor a fecha fin
            if (fechaInicio > fechaFin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha fin.");

            // Llamada a la capa de datos
            return dal.ReporteVentas(fechaInicio, fechaFin);
        }
        public static DataTable ObtenerVentasPorPeriodo(DateTime inicio, DateTime fin)
        {
            return ReporteVentaDAL.ObtenerVentaPorPeriodo(inicio, fin);
        }
    }
}
