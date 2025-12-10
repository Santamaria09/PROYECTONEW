using PROYECTONEW.CapaNegocio;
using PROYECTONEW.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW.CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            {
                DateTime inicio = dtpInicio.Value.Date;
                DateTime fin = dtpFin.Value.Date;

                // Validación
                if (fin < inicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor a la inicial.",
                        "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1) Consultar datos en BLL
                DataTable tabla = ReporteVentaBLL.ObtenerVentasPorPeriodo(inicio, fin);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existen ventas registradas en ese período.",
                        "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2) Guardar PDF
                saveFileDialog1.Title = "Guardar Reporte de Ventas";
                saveFileDialog1.Filter = "Archivo PDF (.pdf)|.pdf";
                saveFileDialog1.FileName = $"ReporteVentas_{inicio:dd-MM-yyyy}a{fin:dd-MM-yyyy}.pdf";

                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                string ruta = saveFileDialog1.FileName;

                try
                {
                    // 3) Generar PDF
                    ReporteVentaPDF.GenerarPDF(tabla, inicio, fin, ruta);

                    MessageBox.Show("Reporte generado exitosamente.\n\nUbicación:\n" + ruta,
                        "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
