using PresupuestoFacil_CapaDatos;
using System.Data;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Ingresos
    {
        private CD_Ingresos objetoCD = new CD_Ingresos();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(int Articulo_Id, decimal Ingreso_Importe, bool activo)
        {

            objetoCD.Insertar(Convert.ToInt32(Articulo_Id),Convert.ToDecimal(Ingreso_Importe), activo);
        }

        public void EditarProd(int idIngreso, int Articulo_Id, decimal Ingreso_Importe, bool activo)
        {
            objetoCD.Editar(Convert.ToInt32(idIngreso), Convert.ToInt32(Articulo_Id), Convert.ToDecimal(Ingreso_Importe), activo);
        }

        public void EliminarPRod(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
