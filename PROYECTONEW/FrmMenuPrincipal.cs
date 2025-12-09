using PROYECTONEW.CapaEntidades;
using PROYECTONEW.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGCLIENTES_Click(object sender, EventArgs e)
        {
            FrmGestionClientes frm = new FrmGestionClientes();
            frm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmGestonProductos frm = new FrmGestonProductos();
            frm.ShowDialog();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            FrmGestionEmpresas frm = new FrmGestionEmpresas();
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta frm = new FrmRegistrarVenta();
            frm.ShowDialog();
        }

        // private void Form1_Load(object sender, EventArgs e)
        // {
        //lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

        /// Control básico por rol
        //Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
        //switch (SesionActual.Rol)
        //  {
        // case "Admin":
        // todo habilitado
        //  break;
        // case "Cajero":
        // button9.Enabled = false;
        //  btnUsuarios.Enabled = false;
        //   break;
        // default:
        // button9.Enabled = false;
        // btnUsuarios.Enabled = false;
        // break;
    }
        }
            


       // private void btnUsuarios_Click(object sender, EventArgs e)
       // {

       // }

      //  private void btnCambiarContraseña_Click(object sender, EventArgs e)
       // {
        //    FrmCambiarContraseña frm = new FrmCambiarContraseña();
          //  frm.ShowDialog();
       // }
 //   }
//}
