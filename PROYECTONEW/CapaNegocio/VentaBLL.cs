using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    public class VentaBLL
    {
        public static Operaciones ValidarVenta(Venta venta, List<VentaItem> detalles)
        {
            //Validar existencia
            if (venta == null)
                return new Operaciones { Exito = false, Mensaje = "Venta no valida" };

            //Cliente
            if (venta.Id_Cliente <= 0)
                return new Operaciones { Exito = false, Mensaje = "Debe de seleccionar un cliente" };

            //validar detalles
            if (detalles == null || detalles.Count == 0)
            {
                return new Operaciones
                { Exito = false, Mensaje = "La venta debe de obtener al menos un producto" };
            }
            //Montos
            if (venta.MontoTotal <= 0)
                return new Operaciones { Exito = false, Mensaje = "El total de la venda debe de ser mayor a cero" };

            //Cada detalle
            foreach (var d in detalles)
            {
                //Cantidad
                if (d.Cantidad <= 0)
                    return new Operaciones { Exito = false, Mensaje = $"La cantidad del Producto ID{d.Id_Producto} es invalida" };
                //Precio
                if (d.PrecioUnitario <= 0)
                    return new Operaciones { Exito = false, Mensaje = $"El precio unitario invalido para el Producto ID{d.Id_Producto}" };


                //Subtotal
                if (d.SubTotal != d.Cantidad * d.PrecioUnitario)
                    return new Operaciones { Exito = false, Mensaje = $"SubTotal incorrecto para el produto ID{d.Id_Producto}" };

                //Validar stock
                int StockActual = ProductoDAL.ObtenerStock(d.Id_Producto);
                if (StockActual < d.Cantidad)
                {
                    return new Operaciones { Exito = false, Mensaje = $"Stock insuficiente del Producto ID{d.Id_Producto}(Stock Actual:{StockActual})" };

                }



            }
            return new Operaciones
            { Exito = true, Mensaje = "Validacion correcta" };
        }
    }
    
}
