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
    public partial class FrmGesUsuario : Form
    {
        UsuarioBLL bll= new UsuarioBLL();

        int Id = 0;
       
        

        public FrmGesUsuario()
        {
            InitializeComponent();
        }

        private void FrmGesUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            HabilitarBotones();
        }

        void HabilitarBotones()
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dvgUsuarios.ClearSelection();
            dvgUsuarios.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgUsuarios.SelectedRows.Count > 0;
                btnActualizar.Enabled = filaSeleccionada;
                btnEliminar.Enabled = filaSeleccionada;
            };
        }




        private void CargarUsuarios()
        {

            dvgUsuarios.DataSource = UsuarioBLL.Listar()
                .Select(u => new
                {
                    u.Id,
                    u.NombreUsuario,
                    Rol = u.Id_Rol, // Mostrar el ID del rol
                    Estado = u.Estado ? "Activo" : "Inactivo"
                })
                .ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frm = new FrmRegistrarUsuario();
            frm.modo = "Nuevo";
            Id = 0;
            frm.ShowDialog();
            CargarUsuarios();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }
            FrmRegistrarUsuario frm = new FrmRegistrarUsuario();
            frm.modo = "Editar";
            

            // Obtener usuario seleccionado
            frm.Id = Convert.ToInt32(dvgUsuarios.SelectedRows[0].Cells["Id"].Value);
            frm.NombreUsuario = dvgUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
            frm.Id_Rol = Convert.ToInt32(dvgUsuarios.SelectedRows[0].Cells["Rol"].Value);
            frm.Estado = dvgUsuarios.SelectedRows[0].Cells["Estado"].Value.ToString() == "Activo";
            frm.ShowDialog();
            CargarUsuarios();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = Convert.ToInt32(dvgUsuarios.SelectedRows[0].Cells["Id"].Value);

            var r = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                bool ok = UsuarioBLL.Eliminar(id);
                MessageBox.Show(ok ? "Eliminado" : "No eliminado");
                CargarUsuarios();
            }
        }

        private void btnCancear_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
