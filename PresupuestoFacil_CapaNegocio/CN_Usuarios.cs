using PresupuestoFacil_CapaDatos;
using System.Data;

namespace PresupuestoFacil_CapaNegocio
{

    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string nombre, string clave, bool activo, int idPerfil)
        {

            objetoCD.Insertar(nombre, clave, activo, Convert.ToInt32(idPerfil));
        }

        public void EditarProd(string nombre, bool activo, string id, string passw, int idPerfil)
        {
            objetoCD.Editar(nombre, activo, Convert.ToInt32(id), passw, Convert.ToInt32(idPerfil));
        }

        public void EliminarPRod(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
