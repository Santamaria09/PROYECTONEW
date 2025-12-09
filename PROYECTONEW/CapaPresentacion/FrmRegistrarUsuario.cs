using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaNegocio;
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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cmbrol.DataSource = RolDAL.ListarRol();
            cmbrol.DisplayMember = "Nombre";
            cmbrol.ValueMember = "Id";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
              //  int id = UsuarioBLL.Insertar(txtUsuario.Text.Trim(), txtClave.Text.Trim(), cmbrol.Text);
               // MessageBox.Show("Usuario creado ID: " + id);
               // Limpiar();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
