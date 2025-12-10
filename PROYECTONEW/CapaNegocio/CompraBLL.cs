using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONEW.CapaNegocio
{
    public class CompraBLL
    {
        public static Operaciones ValidarCompra(Compra compra, List<CompraItem> detalles)
        {
            // Validar existencia
            if (compra == null)
                return new Operaciones { Exito = false, Mensaje = "Compra no válida" };

            // Empresa
            if (compra.Id_Empresa <= 0)
                return new Operaciones { Exito = false, Mensaje = "Debe seleccionar una empresa" };


            // Validar detalles
            if (detalles == null || detalles.Count == 0)
                return new Operaciones { Exito = false, Mensaje = "La compra debe contener al menos un producto" };

            // Montos
            if (compra.TotalCompra <= 0)
                return new Operaciones { Exito = false, Mensaje = "El total de la compra debe ser mayor a cero" };

            // Validaciones por cada item
            foreach (var d in detalles)
            {
                // Cantidad
                if (d.Cantidad <= 0)
                    return new Operaciones { Exito = false, Mensaje = $"Cantidad inválida para el Producto ID {d.Id_Producto}" };

                // Precio Compra
                if (d.PrecioCompra <= 0)
                    return new Operaciones { Exito = false, Mensaje = $"Precio de compra inválido para el Producto ID {d.Id_Producto}" };

                // SubTotal
                decimal subTotalCalculado = d.Cantidad * d.PrecioCompra;

                if (subTotalCalculado != d.SubTotal)
                    return new Operaciones { Exito = false, Mensaje = $"SubTotal incorrecto para el Producto ID {d.Id_Producto}" };
            }
           
            return new Operaciones
            {
                Exito = true,
                Mensaje = "Validación correcta"
            };
        }
    }
}
