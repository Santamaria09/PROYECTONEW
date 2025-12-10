using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using PROYECTONEW.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW.CapaPresentacion
{

    public partial class FrmClienteAE : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }


        ClienteBLL bll = new ClienteBLL();
        public FrmClienteAE()
        {
            InitializeComponent();
         
        }

        private void FrmClienteAE_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                label.Text = "AGREGAR CLIENTE";

            }
            else
            {
                label.Text = "MODIFICAR ClIENTE";
                txtNC.Text = Nombre;
                txtTC.Text = Telefono;
                txtDC.Text = Direccion;
                chkC.Checked = Estado;
            }

        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNC.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Cliente c = new Cliente
                {
                    Id = Id,
                    Nombre = txtNC.Text.Trim(),
                    Telefono = txtTC.Text.Trim(),
                    Direccion = txtDC.Text.Trim(),
                    Estado = chkC.Checked,

                };
                bll.Guardar(c);
                MessageBox.Show(Modo == "Nuevo" ? "El cliente ha sido registrado correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al interactuar con la base de datos.\n\nDetalles tecnicos:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado:\n" + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
