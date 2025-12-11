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
    public partial class FrmGestionClientes : Form
    {
        ClienteBLL bll = new ClienteBLL();
        int Id = 0;
        


        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            
            HabilitarBotones();

            CargarDatos();
        }
        
        void HabilitarBotones()
        {
            btnAC.Enabled = true;
            btnEC.Enabled = false;
            btnDC.Enabled = true;
            dvgCliente.ClearSelection();
            dvgCliente.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgCliente.SelectedRows.Count > 0;
                btnEC.Enabled = filaSeleccionada;
                btnDC.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos()
        {
            dvgCliente.DataSource = bll.Listar();
            dvgCliente.ClearSelection();
            Id = 0;
        }

        private void txtBCliente_TextChanged(object sender, EventArgs e)
        {
            dvgCliente.DataSource = bll.Buscar(txtBC.Text);
        }


        private void btnEC_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Sseleccionar a un Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmClienteAE frm = new FrmClienteAE();
            frm.Modo = "Editar";
            frm.Id = Id;

            frm.Nombre = dvgCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Telefono = dvgCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            frm.Direccion = dvgCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            frm.Estado = Convert.ToBoolean(dvgCliente.CurrentRow.Cells["Estado"].Value);


            frm.ShowDialog();
            CargarDatos();
        }

        private void dvgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dvgCliente.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            FrmClienteAE frm = new FrmClienteAE();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Seleccione un Cliente");
                return;
            }
            if (MessageBox.Show("¿Esta seguro de eliminar al usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(Id);
                CargarDatos();
            }
        }

        private void btnVC_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtBC_TextChanged(object sender, EventArgs e)
        {
            dvgCliente.DataSource = bll.Buscar(txtBC.Text);
        }
    }
}
