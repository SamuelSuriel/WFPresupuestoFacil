using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Ingresos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarIngresos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(int Articulo_Id, decimal Ingreso_Importe, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Articulo_Id", Articulo_Id);
            comando.Parameters.AddWithValue("@Ingreso_Importe", Ingreso_Importe);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Editar(int idIngreso, int Articulo_Id, decimal Ingreso_Importe, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idIngreso", idIngreso);
            comando.Parameters.AddWithValue("@Articulo_Id", Articulo_Id);
            comando.Parameters.AddWithValue("@Ingreso_Importe", Ingreso_Importe);
            comando.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idIngreso", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
