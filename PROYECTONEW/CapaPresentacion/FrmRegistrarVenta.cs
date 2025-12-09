using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
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
    public partial class FrmRegistrarVenta : Form
    {
        int Id = 0;
        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cboC.DataSource = ClientesDAL.PanelDeContactos();
            cboC.DisplayMember = "Nombre";
            cboC.ValueMember = "Id";

            //TipoPago
            cboT.DataSource = MetodoPagoDAL.Listar();
            cboT.DisplayMember = "Nombre";
            cboT.ValueMember = "Id";

          
            //Fecha
            dtpT.Value = DateTime.Now;
            CargarEstadofiltro();
            CargarProductos(0);

            //Columnas
            ConfigurarTablaDetalle();
        }
        private void CargarEstadofiltro()
        {
            cboActualiza.DataSource = CapaDatos.EstadoDAL.Listar();
            cboActualiza.DisplayMember = "Nombre";
            cboActualiza.ValueMember = "Id";
            cboActualiza.SelectedIndex = -1;
        }

        private void CargarProductos(int Id)
        {
            dvgBP.DataSource = ProductoDAL.ListarPorEstado(Id);
            dvgBP.ClearSelection();
            
        }

        private void ConfigurarTablaDetalle()
        {
            dvgDp.Columns.Clear();

            //Id producto
            DataGridViewTextBoxColumn colldProd = new DataGridViewTextBoxColumn();

            colldProd.Name = "Id_Producto";
            colldProd.HeaderText = "Id";
            colldProd.Visible = false;
            dvgDp.Columns.Add(colldProd);


            //Nombre producto
            dvgDp.Columns.Add("NombreProducto", "Producto");

            //Cantidad
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cant";
            dvgDp.Columns.Add(colCant);

            //Precio U
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            dvgDp.Columns.Add(colPrecio);

            DataGridViewCheckBoxColumn colSubsidio = new DataGridViewCheckBoxColumn();
            colSubsidio.Name = "EsSubsidio";
            colSubsidio.HeaderText = "Subsidio";
            dvgDp.Columns.Add(colSubsidio);

            //Sub total
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "SubTotal";
            colSub.HeaderText = "SubTotal";
            colSub.ReadOnly = true;
            dvgDp.Columns.Add(colSub);
            dvgDp.ReadOnly = false;


            //No editable
            dvgDp.Columns["SubTotal"].ReadOnly = true;
            dvgDp.Columns["PrecioUnitario"].ReadOnly = true;
            dvgDp.Columns["NombreProducto"].ReadOnly = true;
            dvgDp.Columns["Id_Producto"].ReadOnly = true;
            dvgDp.Columns["EsSubsidio"].ReadOnly = true;

            dvgDp.Columns["Cantidad"].ReadOnly = false;
        }

        private void dvgBP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            btnAgregarP_Click(sender, e);
        }

        private void RecalcularTotal()
        {
            decimal MontoTotal = 0;
            foreach (DataGridViewRow row in dvgDp.Rows)
            {
                MontoTotal += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            label5.Text = "Total:$" + MontoTotal.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvgDp.Rows.Clear();
            RecalcularTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dvgDp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
                return;
            }

            dvgDp.Rows.RemoveAt(dvgDp.SelectedRows[0].Index);
            RecalcularTotal();
        }

        private void dvgDp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgDp.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dvgDp.Rows[e.RowIndex];

                int Cantidad;
                bool ok = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out Cantidad);
                if (!ok || Cantidad <= 0)
                {
                    MessageBox.Show("Cantidad invalida");
                    row.Cells["Cantidad"].Value = 1;
                    Cantidad = 1;
                }

                decimal Precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                decimal SubTotal = Cantidad * Precio;

                row.Cells["SubTotal"].Value = SubTotal;

                RecalcularTotal();
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (dvgBP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DataGridViewRow row = dvgBP.SelectedRows[0];

            int Id_Producto = Convert.ToInt32(row.Cells["Id"].Value);
            string Nombre = row.Cells["Nombre"].Value.ToString();
            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            int Cantidad = 1;
            bool Subsidio = chkAplica.Checked;
            decimal SubTotal = (Precio * Cantidad) - (Subsidio ? 12 : 0);

           
            if (Subsidio)
            {
                SubTotal = Precio - 12;
                if (SubTotal < 0) SubTotal = 0;
            }

            dvgDp.Rows.Add(
                     Id_Producto, Nombre, Cantidad, Precio, Subsidio, SubTotal);

            RecalcularTotal();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgDp.Rows.Count == 0)
                {
                    MessageBox.Show("La venta no tiene productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Crear la venta
                Venta venta = new Venta
                {
                    Fecha = dtpT.Value,
                    MontoTotal = ObtenerTotalVenta(),
                    Id_MetodoPago = Convert.ToInt32(cboT.SelectedValue),
                    Id_Cliente = Convert.ToInt32(cboC.SelectedValue),
                    Id_Usuario = SesionActual.IdUsuario


                };

                //Lista de detalles
                List<VentaItem> detalles = new List<VentaItem>();
                foreach (DataGridViewRow row in dvgDp.Rows)
                {
                    detalles.Add(new VentaItem()
                    {
                        Id_Producto = Convert.ToInt32(row.Cells["Id_Producto"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                        EsSubsidio = Convert.ToBoolean(row.Cells["EsSubsidio"].Value),
                        SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    });
                }

                //Validar BLL
                var validacion = VentaBLL.ValidarVenta(venta, detalles);
                if (!validacion.Exito)
                {
                    MessageBox.Show(validacion.Mensaje, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                //Guardar
                var resultado = VentaDAL.RegistrarVenta(venta, detalles);
                if (resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

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
        private decimal ObtenerTotalVenta()
        {
            decimal Total = 0;

            foreach (DataGridViewRow row in dvgDp.Rows)
                Total += Convert.ToDecimal(row.Cells["SubTotal"].Value);

            return Total;
        }

        private void LimpiarCampos()
        {
            dvgDp.Rows.Clear();
            label5.Text = "Total: $0.00";
            CargarProductos(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
    
    
}
