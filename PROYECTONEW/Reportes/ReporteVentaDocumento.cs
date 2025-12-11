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
   
    
        public class ReporteVentaDocumento : IDocument
        {
            private readonly ReporteVentasModel Modelo;
            private readonly string RutaLogo = @"C:\Users\MINEDUCYT\Downloads\ChatGPT Image 8 dic 2025, 10_25_54 a.m..png";

            public ReporteVentaDocumento(ReporteVentasModel modelo)
            {
                Modelo = modelo;
            }

            public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
            public DocumentSettings GetSettings() => new DocumentSettings();

            public void Compose(IDocumentContainer container)
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A3);
                    page.Margin(5);

                    // ENCABEZADO
                    page.Header().Row(row =>
                    {
                        row.ConstantColumn(80).Image(RutaLogo, ImageScaling.FitHeight);
                        row.RelativeColumn().Column(col =>
                        {
                            col.Item().Text("Punto de Distribución Emanuel").Bold().FontSize(10);
                            col.Item().Text("Reporte de Ventas por Período").FontSize(10);
                            col.Item().Text($"Desde {Modelo.Inicio:dd/MM/yyyy} — Hasta {Modelo.Fin:dd/MM/yyyy}").FontSize(11);
                        });
                    });

                    // TABLA
                    page.Content().PaddingTop(5).Element(GenerarTabla);

                    // PIE
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
                    // Columnas: Producto | Cantidad | Precio | Subtotal
                    table.ColumnsDefinition(cols =>
                    {
                        cols.RelativeColumn(3); // Producto
                        cols.RelativeColumn(1); // Cantidad
                        cols.RelativeColumn(1); // Precio
                        cols.RelativeColumn(1); // SubTotal
                    });

                    // Encabezado
                    table.Header(header =>
                    {
                        header.Cell().Background("#EAEAEA").Padding(5).Text("Producto").SemiBold();
                        header.Cell().Background("#EAEAEA").Padding(5).Text("Cantidad").SemiBold();
                        header.Cell().Background("#EAEAEA").Padding(5).Text("Precio").SemiBold();
                        header.Cell().Background("#EAEAEA").Padding(5).Text("Subtotal").SemiBold();
                    });

                    decimal totalGeneral = 0;

                    foreach (DataRow row in Modelo.Tabla.Rows)
                    {
                        string producto = row["NombreProducto"].ToString();
                        decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
                        decimal precio = Convert.ToDecimal(row["PrecioUnitario"]);
                        decimal subtotal = Convert.ToDecimal(row["SubTotal"]);

                        totalGeneral += subtotal;

                        table.Cell().Padding(4).Text(producto);
                        table.Cell().Padding(4).Text(cantidad.ToString());
                        table.Cell().Padding(4).Text(precio.ToString("C2"));
                        table.Cell().Padding(4).Text(subtotal.ToString("C2"));
                    }

                    // TOTAL GENERAL
                    table.Cell().ColumnSpan(4).AlignRight().Padding(10)
                        .Text($"TOTAL GENERAL: {totalGeneral:C2}")
                        .Bold().FontSize(14);
                });
            }
        }
    




}

