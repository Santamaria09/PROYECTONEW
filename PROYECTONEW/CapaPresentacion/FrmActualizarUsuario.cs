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
    public partial class FrmActualizarUsuario : Form
    {
        public bool ModoEdicion = false;
        public int Id = 0;
        
        public FrmActualizarUsuario(int id, string nombre, int idRol, bool estado)
        {
            InitializeComponent();
            // Llenar los controles del formulario
            ModoEdicion = true;
            Id = id;

            // Cargar roles ANTES de llenar los valores
            //CargarRoles();

            // Rellenar campos
            txtUA.Text = nombre;
            cborol.SelectedValue = //Rol;
            chckR.Checked = estado;

            // Para actualización, no cambiar clave aquí
            txtUC.Enabled = false;

        }

        private void FrmActualizarUsuario_Load(object sender, EventArgs e)
        {
           

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            string nombre = txtUA.Text.Trim();
            int idRol = Convert.ToInt32(cborol.SelectedValue);
            bool estado = chckR.Checked;

            if (!ModoEdicion)
            {
                // AGREGAR USUARIO
                UsuarioBLL.Insertar(nombre, txtUC.Text.Trim(), idRol);
                MessageBox.Show("Usuario agregado correctamente");
            }
            else
            {
                // ACTUALIZAR USUARIO
                UsuarioBLL.Actualizar(Id, nombre, idRol, estado);
                MessageBox.Show("Usuario actualizado correctamente");
            }

            this.Close();

        }
    }
}
