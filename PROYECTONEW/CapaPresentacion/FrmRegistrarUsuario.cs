using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using PROYECTONEW.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW.CapaPresentacion
{
    public partial class FrmRegistrarUsuario : Form
    {
        public string modo {  get; set; }
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public int Id_Rol { get; set; }
        public bool Estado { get; set; }

        UsuarioBLL bll = new UsuarioBLL();

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
          
            
            CargarRoles();
            

        }
        private void CargarRoles()
        {

            cmbrol.DataSource = RolDAL.Listar();
            cmbrol.DisplayMember = "Nombre";
            cmbrol.ValueMember = "Id";
        }

        
        

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            if (modo == "Nuevo")
            {
                label6.Text = "AGREGAR USUARIO";
                check.Checked = true;

            }
            else
            {
                label6.Text = "MODIFICAR USUARIO";
                txtUsuario.Text = NombreUsuario;
                cmbrol.SelectedValue = Id_Rol;
                check.Checked = Estado;
                txtClave.Enabled = false;
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    return;
                }

                if (cmbrol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol");
                    return;
                }

                NombreUsuario = txtUsuario.Text.Trim();
                Id_Rol = Convert.ToInt32(cmbrol.SelectedValue);
                Estado = check.Checked;

                if (modo == "Nuevo")
                {
                    if (String.IsNullOrWhiteSpace(txtClave.Text))
                    {
                        MessageBox.Show("Debe ingresar una contraseña");
                        return;
                    }

                    UsuarioBLL.Insertar(NombreUsuario, txtClave.Text.Trim(), Id_Rol);
                    MessageBox.Show("Usuario creado correctamente");
                }
                else
                {
                    
                    bool ok = UsuarioBLL.Actualizar(Id, NombreUsuario,Id_Rol, Estado);
                    MessageBox.Show("Usuario actualizado correctamente");
                }
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
