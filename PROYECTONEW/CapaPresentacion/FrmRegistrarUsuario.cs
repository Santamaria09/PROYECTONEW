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
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveHash { get; set; }
        public int Id_Rol { get; set; }
        public bool Estado { get; set; }

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {

            cmbrol.DataSource = RolDAL.Listar();
            cmbrol.DisplayMember = "Nombre";
            cmbrol.ValueMember = "Id";

            txtUsuario.Text = NombreUsuario;
            txtClave.Text = ClaveHash;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("¿Esta seguro que desea eliminar al usuario", "Confirmar eliminacion",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.No)
                return;

            UsuarioDAL.Eliminar(Id);
            MessageBox.Show("El Usuario ha sido eliminada correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
