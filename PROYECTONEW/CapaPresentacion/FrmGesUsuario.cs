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
        public FrmGesUsuario()
        {
            InitializeComponent();
        }

        private void FrmGesUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }




        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = UsuarioBLL.Listar().Select(u => new
            {
                u.IdUsuario,
                u.NombreUsuario,
               // u.Idrol,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).ToList();
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
    }
}
    
