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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cboECompra.DataSource = CapaDatos.EmpresaDAL.Contactos();
            cboECompra.DisplayMember = "Nombre";
            cboECompra.ValueMember = "Id";
            cboECompra.SelectedIndex = -1;

            //Fecha
            dtpCompra.Value = DateTime.Now;
            CargarProductos();

            ConfigurarTablaDetalle();
        }

        private void CargarProductos()
        {
            dvgCompra.DataSource = CapaDatos.ProductoDAL.Listar();
            dvgCompra.ClearSelection();

        }

        private void ConfigurarTablaDetalle()
        {
            dvgComprad.Columns.Clear();

            //Id producto
            DataGridViewTextBoxColumn colldProd = new DataGridViewTextBoxColumn();

            colldProd.Name = "Id_Producto";
            colldProd.HeaderText = "Id";
            colldProd.Visible = false;
            dvgComprad.Columns.Add(colldProd);


            //Nombre producto
            dvgComprad.Columns.Add("NombreProducto", "Producto");

            //Cantidad
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cantidad";
            dvgComprad.Columns.Add(colCant);

            //Precio U
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "Precio";
            colPrecio.HeaderText = "Precio";
            dvgComprad.Columns.Add(colPrecio);


            //Sub total
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "SubTotal";
            colSub.HeaderText = "SubTotal";
            colSub.ReadOnly = true;
            dvgComprad.Columns.Add(colSub);
            dvgComprad.ReadOnly = false;


            //No editable
            dvgComprad.Columns["SubTotal"].ReadOnly = true;
            dvgComprad.Columns["Precio"].ReadOnly = true;
            dvgComprad.Columns["NombreProducto"].ReadOnly = true;
            dvgComprad.Columns["Id_Producto"].ReadOnly = true;
            

            dvgComprad.Columns["Cantidad"].ReadOnly = false;
        }

        private void btnACompra_Click(object sender, EventArgs e)
        {
            if (dvgCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DataGridViewRow row = dvgCompra.SelectedRows[0];

            int IdProducto = Convert.ToInt32(row.Cells["Id"].Value);
            string Nombre = row.Cells["Nombre"].Value.ToString();
            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            int Cantidad = 1;
            decimal SubTotal = Precio * Cantidad;

            dvgComprad.Rows.Add(
                IdProducto, Nombre, Cantidad, Precio, SubTotal);

            RecalcularTotal();
        }

        private void RecalcularTotal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dvgComprad.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            label1.Text = "TotalCompra:$" + Total.ToString("0.00");
        }

        private void dvgCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnACompra_Click(sender, e);
        }

        private void dvgComprad_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgComprad.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dvgComprad.Rows[e.RowIndex];

                int Cantidad;
                bool ok = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out Cantidad);
                if (!ok || Cantidad <= 0)
                {
                    MessageBox.Show("Cantidad invalida");
                    row.Cells["Cantidad"].Value = 1;
                    Cantidad = 1;
                }

                decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                decimal SubTotal = Cantidad * Precio;

                row.Cells["SubTotal"].Value = SubTotal;

                RecalcularTotal();
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (dvgComprad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
                return;
            }

            dvgComprad.Rows.RemoveAt(dvgComprad.SelectedRows[0].Index);
            RecalcularTotal();
        }

        private decimal ObtenerTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dvgComprad.Rows)
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);

            return total;
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            try
            {               
                //Crear la Compra
                Compra compra = new Compra
                {
                    Fecha = dtpCompra.Value,
                    TotalCompra = ObtenerTotalVenta(),
                    Id_Empresa = Convert.ToInt32(cboECompra.SelectedValue),
                    

                };

                //Lista de detalles
                List<CompraItem> detalles = new List<CompraItem>();
                foreach (DataGridViewRow row in dvgComprad.Rows)
                {
                    detalles.Add(new CompraItem()
                    {
                        Id_Producto = Convert.ToInt32(row.Cells["Id_Producto"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        PrecioCompra = Convert.ToDecimal(row.Cells["Precio"].Value),
                        SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    });
                }

                //Validar BLL
                var validacion = CompraBLL.ValidarCompra(compra, detalles);
                if (!validacion.Exito)
                {
                    MessageBox.Show(validacion.Mensaje, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                //Guardar
                var resultado = CompraDAL.RegistrarCompra(compra, detalles);
                if (resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();

                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado:" + ex.Message);
            }


        }

        private void LimpiarFormulario()
        {
            dvgComprad.Rows.Clear();
            label1.Text = "TotalCompra: $0.00";
            
            CargarProductos();
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            dvgComprad.Rows.Clear();
            RecalcularTotal();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
