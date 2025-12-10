using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;        // Extensiones para Page(), Table(), Text(), etc.
using QuestPDF.Helpers;       // Acceso a colores, tamaños y herramientas
using System.Data;


namespace PROYECTONEW.Reportes
{
    public class ReporteCompraDocumento : IDocument
    {
        private readonly ReportesCompraModel Modelo;
        private readonly string RutaLogo = "\"C:\\Users\\MINEDUCYT\\Downloads\\ChatGPT Image 8 dic 2025, 10_25_54 a.m..png\""; // Cambiar ruta si quieres

        public ReporteCompraDocumento(ReportesCompraModel modelo)
        {
            Modelo = modelo;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => new DocumentSettings();

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);

                page.Header().Row(row =>
                {
                    row.ConstantColumn(80).Image(RutaLogo, ImageScaling.FitHeight);
                    row.RelativeColumn().Column(col =>
                    {
                        col.Item().Text("Punto de Distribución Emanuel").Bold().FontSize(20);
                        col.Item().Text("Reporte de Compras por Período").FontSize(14);
                        col.Item().Text($"Desde {Modelo.Inicio:dd/MM/yyyy} — Hasta {Modelo.Fin:dd/MM/yyyy}").FontSize(11);
                    });
                });

                page.Content().PaddingTop(20).Element(GenerarTabla);

                page.Footer().AlignCenter().Text(txt =>
                {
                    txt.Span("Generado el ").SemiBold();
                    txt.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    txt.Line(" — Sistema POS Punto de Distribución Emanuel");
                });
            });
        }
        private void GenerarTabla(IContainer container)
        {
            container.Table(table =>
            {
                // Columnas: Producto | Cantidad | PrecioCompra | Subtotal
                table.ColumnsDefinition(cols =>
                {
                    cols.RelativeColumn(3);
                    cols.RelativeColumn(1);
                    cols.RelativeColumn(1);
                    cols.RelativeColumn(1);
                });

                table.Header(header =>
                {
                    header.Cell().Background("#EAEAEA").Padding(5).Text("Producto").SemiBold();
                    header.Cell().Background("#EAEAEA").Padding(5).Text("Cantidad").SemiBold();
                    header.Cell().Background("#EAEAEA").Padding(5).Text("Precio Compra").SemiBold();
                    header.Cell().Background("#EAEAEA").Padding(5).Text("Subtotal").SemiBold();
                });

                decimal totalGeneral = 0;

                foreach (DataRow row in Modelo.Tabla.Rows)
                {
                    string producto = row["Nombre"].ToString();
                    decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
                    decimal precio = Convert.ToDecimal(row["PrecioCompra"]);
                    decimal subtotal = cantidad * precio;

                    totalGeneral += subtotal;

                    table.Cell().Padding(4).Text(producto);
                    table.Cell().Padding(4).Text(cantidad.ToString());
                    table.Cell().Padding(4).Text(precio.ToString("C2"));
                    table.Cell().Padding(4).Text(subtotal.ToString("C2"));
                }

                table.Cell().ColumnSpan(4).AlignRight().Padding(10)
                    .Text($"TOTAL GENERAL: {totalGeneral:C2}")
                    .Bold().FontSize(14);
            });
        }
    }
}




    

