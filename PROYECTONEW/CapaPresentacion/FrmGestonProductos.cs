using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
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
    public partial class FrmGestonProductos : Form
    {
        int Id;
        public FrmGestonProductos()
        {
            InitializeComponent();
        }

        private void FrmGestonProductos_Load(object sender, EventArgs e)
        {
            txtNproducto.Text = "Cilindro";

            //Carga datos de Peso
            cboPeso.DataSource = CapaDatos.PesoDAL.Listar();
            cboPeso.DisplayMember = "Nombre";
            cboPeso.ValueMember = "Id";
            cboPeso.SelectedIndex = -1;

            //Carga datos de la empresa
            cboEmpresa.DataSource = CapaDatos.EmpresaDAL.Contactos();
            cboEmpresa.DisplayMember = "Nombre";
            cboEmpresa.ValueMember = "Id";
            cboEmpresa.SelectedIndex = -1;

            //Carga datos de Estado Actual
            cboEstado.DataSource = CapaDatos.EstadoDAL.Listar();
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "Id";
            cboEstado.SelectedIndex = -1;

            CargarEstadofiltro();
            CargarProducto();
            
        }

        private void CargarEstadofiltro()
        {
            cboEA.DataSource = CapaDatos.EstadoDAL.Listar();
            cboEA.DisplayMember = "Nombre";
            cboEA.ValueMember = "Id";
            cboEA.SelectedIndex = -1;
        }

        private void CargarProducto()
        {
            if (cboEstado.SelectedValue == null) return;

            Id = Convert.ToInt32(cboEstado.SelectedValue);
            dvgGestionp.DataSource = ProductoDAL.ListarPorEstado(Id);
            dvgGestionp.ClearSelection();
        }
    

        private void dvgGestionp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(dvgGestionp.Rows[e.RowIndex].Cells["Id"].Value);
                txtNproducto.Text = dvgGestionp.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtPproducto.Text = dvgGestionp.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
               // txtSproducto.Text = dvgGestionp.Rows[e.RowIndex].Cells["NumeroSerie"].Value.ToString();
                txtstock.Text = dvgGestionp.Rows[e.RowIndex].Cells["Stock"].Value.ToString();

                cboPeso.SelectedValue = dvgGestionp.Rows[e.RowIndex].Cells["UnidadPeso"].Value;
                cboEmpresa.SelectedValue = dvgGestionp.Rows[e.RowIndex].Cells["Empresa"].Value;
                cboEstado.SelectedValue = dvgGestionp.Rows[e.RowIndex].Cells["EstadoActual"].Value;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEA.SelectedValue == null) return;
            if (!(cboEA.SelectedValue is int)) return;

            Id = Convert.ToInt32(cboEA.SelectedValue);

            dvgGestionp.DataSource = ProductoDAL.ListarPorEstado(Id);
            dvgGestionp.ClearSelection();
            CargarProducto();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (!Validaciones.EsDecimal(txtPproducto.Text))
            {
                MessageBox.Show("El precio debe de ser un valor decimal", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsEntero(txtstock.Text))
            {
                MessageBox.Show("Stock invalio", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto p = new Producto
            {
                Id = Id,
                Nombre = txtNproducto.Text.Trim(),
                Precio = Convert.ToDecimal(txtPproducto.Text.Trim()),
                NumeroSerie = txtSproducto.Text.Trim(),
                Stock = Convert.ToInt32(txtstock.Text.Trim()),
                Id_UnidadPeso = Convert.ToInt32(cboPeso.SelectedValue),
                Id_Empresa = Convert.ToInt32(cboEmpresa.SelectedValue),
                Id_EstadoActual = Convert.ToInt32(cboEstado.SelectedValue),
            };
            
           
            ProductoDAL.Insertar(p);

            MessageBox.Show("Producto agregado correctamente", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarProducto();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            
            txtSproducto.Clear();
            txtPproducto.Clear();
            txtstock.Clear();
            cboEstado.SelectedIndex = -1;
            cboEmpresa.SelectedIndex = -1;
            cboPeso.SelectedIndex = -1;

        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVv_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dvgGestionp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
