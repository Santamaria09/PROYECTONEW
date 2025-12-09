using PROYECTONEW.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW.CapaPresentacion
{
    public partial class FrmEmpresaE : Form
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Direccion { get; set; }
     
        EmpresaBLL bll = new EmpresaBLL();
        public FrmEmpresaE()
        {
            InitializeComponent();
        }

        private void FrmEmpresaE_Load(object sender, EventArgs e)
        {
            txtEN.Text = Nombre;
            txtET.Text = TelefonoEmpresa;
            txtED.Text = Direccion;
        }


        private void btnE_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Esta seguro que desea eliminar a la empresa", "Confirmar eliminacion",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
                return;

            bll.Eliminar(Id);
            MessageBox.Show("La empresa ha sido eliminada correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
