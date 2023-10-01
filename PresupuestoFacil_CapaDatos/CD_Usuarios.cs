using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string nombre, string clave, bool activo, int idPerfil)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@idPerfil", idPerfil);
            
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Editar(string nombre, bool activo, int id, string passw, int idPerfil)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);     
            comando.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@clave", passw);
            comando.Parameters.AddWithValue("@idPerfil", idPerfil);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioId", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
