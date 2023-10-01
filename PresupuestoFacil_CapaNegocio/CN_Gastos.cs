using PresupuestoFacil_CapaDatos;
using System.Data;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Gastos
    {
        private CD_Gastos objetoCD = new CD_Gastos();

        public DataTable MostrarProd(int id)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(Convert.ToInt32(id));
            return tabla;
        }
        public void InsertarPRod(int Gasto_Importe, int Estatus_Id, int Categoria_id, bool activo, int Articulo_Id, int Usuario_Id)
        {

            objetoCD.Insertar(Convert.ToDecimal(Gasto_Importe), Convert.ToInt32(Estatus_Id), Convert.ToInt32(Categoria_id), activo, Convert.ToInt32(Articulo_Id), Convert.ToInt32(Usuario_Id));
        }

        public void EditarProd(int idGasto, decimal Gasto_Importe, int Estatus_Id, int Categoria_id, bool activo, int Articulo_Id, int Usuario_Id)
        {
            objetoCD.Editar(Convert.ToInt32(idGasto), Gasto_Importe, Convert.ToInt32(Estatus_Id), Convert.ToInt32(Categoria_id), activo, Convert.ToInt32(Articulo_Id), Convert.ToInt32(Usuario_Id));
        }

        public void EliminarPRod(string id, int Usuario_Id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id), Convert.ToInt32(Usuario_Id));
        }

    }
}
