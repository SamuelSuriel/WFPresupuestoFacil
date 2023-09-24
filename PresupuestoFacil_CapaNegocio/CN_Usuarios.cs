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
        public void InsertarPRod(string nombre, string apellido, string correo, string telefono, string edad, string posicion, bool activo)
        {

            objetoCD.Insertar(nombre, apellido, correo, telefono, Convert.ToInt32(edad), posicion, activo);
        }

        public void EditarProd(string nombre, string apellido, string correo, string telefono, string edad, string posicion, bool activo, string id, string passw, int idPerfil)
        {
            objetoCD.Editar(nombre, apellido, correo, telefono, Convert.ToInt32(edad), posicion, activo, Convert.ToInt32(id), passw, Convert.ToInt32(idPerfil));
        }

        public void EliminarPRod(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
