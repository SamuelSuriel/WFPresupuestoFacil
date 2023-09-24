using PresupuestoFacil_CapaDatos;
using System.Data;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Gastos
    {
        private CD_Gastos objetoCD = new CD_Gastos();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(int Gasto_Importe, int Estatus_Id, int Categoria_id, int Articulo_Id, bool activo)
        {

            objetoCD.Insertar(Convert.ToDecimal(Gasto_Importe), Convert.ToInt32(Estatus_Id), Convert.ToInt32(Categoria_id), Convert.ToInt32(Articulo_Id), activo);
        }

        public void EditarProd(int idGasto, decimal Gasto_Importe, int Estatus_Id, int Categoria_id, bool activo, int Articulo_Id)
        {
            objetoCD.Editar(Convert.ToInt32(idGasto), Gasto_Importe, Convert.ToInt32(Estatus_Id), Convert.ToInt32(Categoria_id), activo, Convert.ToInt32(Articulo_Id));
        }

        public void EliminarPRod(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
