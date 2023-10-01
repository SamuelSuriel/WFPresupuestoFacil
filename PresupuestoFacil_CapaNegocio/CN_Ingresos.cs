using PresupuestoFacil_CapaDatos;
using System.Data;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Ingresos
    {
        private CD_Ingresos objetoCD = new CD_Ingresos();

        public DataTable MostrarProd(int id)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(id);
            return tabla;
        }
        public void InsertarPRod(int Articulo_Id, decimal Ingreso_Importe, bool activo, int Usuario_Id)
        {

            objetoCD.Insertar(Convert.ToInt32(Articulo_Id),Convert.ToDecimal(Ingreso_Importe), activo, Convert.ToInt32(Usuario_Id));
        }

        public void EditarProd(int idIngreso, int Articulo_Id, decimal Ingreso_Importe, bool activo, int Usuario_Id)
        {
            objetoCD.Editar(Convert.ToInt32(idIngreso), Convert.ToInt32(Articulo_Id), Convert.ToDecimal(Ingreso_Importe), activo, Convert.ToInt32(Usuario_Id));
        }

        public void EliminarPRod(string id, int Usuario_Id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id), Convert.ToInt32(Usuario_Id));
        }

    }
}
