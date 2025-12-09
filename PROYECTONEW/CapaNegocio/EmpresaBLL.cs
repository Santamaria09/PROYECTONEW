using PROYECTONEW.CapaDatos;
using PROYECTONEW.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONEW.CapaNegocio
{
    public class EmpresaBLL
    {
        EmpresaDAL dall = new EmpresaDAL();
        public DataTable Listar()
        {
            return dall.Listar();

        }
        public int Guardar( Empresa e)
        {
            if (string.IsNullOrWhiteSpace(e.Nombre))
                throw new Exception("El nombre del Empresa es obligatorio");

            if (string.IsNullOrWhiteSpace(e.TelefonoEmpresa) || e.TelefonoEmpresa.Length != 8)
                throw new Exception("El teléfono debe contener exactamente 8 dígitos.");

            if (e.Id == 0)
            {
                MessageBox.Show("La empresa ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dall.Insertar(e);
            }
            else
            {
                dall.Actualizar(e);
                MessageBox.Show("El registro ha sido actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return e.Id;

            }

        }
        public bool Eliminar(int id)
        {
            return dall.Eliminar(id);

            MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        public DataTable Buscar(string filtro)
        {
            return dall.Buscar(filtro);

        }
    }
}

