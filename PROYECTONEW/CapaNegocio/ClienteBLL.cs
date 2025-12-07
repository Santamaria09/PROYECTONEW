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
    public class ClienteBLL
    {
        ClientesDAL dal = new ClientesDAL();

        public DataTable Listar()
        {
            return dal.Listar();

        }

        public int Guardar(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                throw new Exception("El Nombre del Cliente es obligatorio");

            if (string.IsNullOrWhiteSpace(c.Telefono) || c.Telefono.Length != 8)
                throw new Exception("El teléfono debe contener exactamente 8 dígitos.");



            if (c.Id == 0)
            {


                MessageBox.Show("Cliente registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dal.Insertar(c);
            }
            else
            {
                dal.Actualizar(c);
                MessageBox.Show("El registro ha sido actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return c.Id;

            }
        }

        public bool Eliminar(int Id)
        {
            return dal.Eliminar(Id);

            MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        public DataTable Buscar(string Filtro)
        {
            return dal.Buscar(Filtro);

        }

      
    }

}
