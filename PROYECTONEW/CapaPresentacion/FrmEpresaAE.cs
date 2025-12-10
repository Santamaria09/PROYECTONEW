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
    public partial class FrmEpresaAE : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Direccion { get; set; }


        EmpresaBLL bll = new EmpresaBLL();
        public FrmEpresaAE()
        {
            InitializeComponent();
        }

        private void FrmEpresaAE_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                label.Text = "AGREGAR EMPRESA";

            }
            else
            {
                label.Text = "MODIFICAR EMPRESA";
                txtNE.Text = Nombre;
                txtTE.Text = TelefonoEmpresa;
                txtDE.Text = Direccion;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGE_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNE.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Empresa empresa = new Empresa
                {
                    Id = Id,
                    Nombre = txtNE.Text.Trim(),
                    TelefonoEmpresa = txtTE.Text.Trim(),
                    Direccion = txtDE.Text.Trim(),
                };

                if (String.IsNullOrWhiteSpace(txtDE.Text))
                {
                    MessageBox.Show("Debe ingresar una dirección", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bll.Guardar(empresa);
                MessageBox.Show(Modo == "Nuevo" ? "La Empresa se ha registrado correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
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

        private void btnVC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
