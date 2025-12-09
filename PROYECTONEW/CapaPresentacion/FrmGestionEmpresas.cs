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
    public partial class FrmGestionEmpresas : Form
    {
        EmpresaBLL bll = new EmpresaBLL();
        int Id = 0;
        string modo = "Nuevo";

        public FrmGestionEmpresas()
        {
            InitializeComponent();
        }

        private void FrmGestionEmpresas_Load(object sender, EventArgs e)
        {
            HabilitarBotones();

            CargarDatos();
        }

        void HabilitarBotones()
        {
            btnAE.Enabled = true;
            btnEE.Enabled = false;
            btnEM.Enabled = true;
            dvgEmpresa.ClearSelection();
            dvgEmpresa.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgEmpresa.SelectedRows.Count > 0;
                btnEE.Enabled = filaSeleccionada;
                btnEM.Enabled = filaSeleccionada;
            };
        }

        void CargarDatos()
        {
            dvgEmpresa.DataSource = bll.Listar();
            dvgEmpresa.ClearSelection();
            Id = 0;
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            FrmEpresaAE frm = new FrmEpresaAE();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();
        }

        private void dvgEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dvgEmpresa.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnEE_Click(object sender, EventArgs e)
        {

            if (Id == 0)
            {
                MessageBox.Show("Seleccionar una Empresa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmEpresaAE frm = new FrmEpresaAE();
            frm.Modo = "Editar";
            frm.Id = Id;

            frm.Nombre = dvgEmpresa.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.TelefonoEmpresa = dvgEmpresa.CurrentRow.Cells["TelefonoEmpresa"].Value.ToString();
            frm.Direccion = dvgEmpresa.CurrentRow.Cells["Direccion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void txtBE_TextChanged(object sender, EventArgs e)
        {
            dvgEmpresa.DataSource = bll.Buscar(txtBE.Text);
        }

        private void btnVC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEM_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Seleccione un proveedor a eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmEmpresaE frm = new FrmEmpresaE();

            frm.Id = Id;

            frm.Nombre = dvgEmpresa.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.TelefonoEmpresa = dvgEmpresa.CurrentRow.Cells["TelefonoEmpresa"].Value.ToString();
            frm.Direccion = dvgEmpresa.CurrentRow.Cells["Direccion"].Value.ToString();
           

            frm.ShowDialog();
            CargarDatos();


        }
    }
}
