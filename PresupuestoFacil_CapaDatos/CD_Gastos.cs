using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Gastos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarGastos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(decimal Gasto_Importe, int Estatus_Id, int Categoria_id, int Articulo_Id, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarGasto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Gasto_Importe", Gasto_Importe);
            comando.Parameters.AddWithValue("@Estatus_Id", Estatus_Id);
            comando.Parameters.AddWithValue("@Categoria_id", Categoria_id);
            comando.Parameters.AddWithValue("@Articulo_Id", Articulo_Id);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@fechacreacion", DateTime.Now);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Editar(int idGasto, decimal Gasto_Importe, int Estatus_Id,int Categoria_id, bool activo, int Articulo_Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarGasto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGasto", idGasto);
            comando.Parameters.AddWithValue("@Gasto_Importe", Gasto_Importe);
            comando.Parameters.AddWithValue("@Estatus_Id", Estatus_Id);
            comando.Parameters.AddWithValue("@Categoria_id", Categoria_id);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@Articulo_Id", Articulo_Id);
            comando.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarGasto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idGasto", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
