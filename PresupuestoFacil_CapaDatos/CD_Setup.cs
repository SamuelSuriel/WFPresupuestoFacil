using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Setup
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        #region Artículos

        public DataTable MostrarArticulos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcMostrarArticulos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarArticulo(string articulo, bool activo, bool esIngreso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcInsertarArticulos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Articulo", articulo);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@esIngreso", esIngreso);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarArticulo(int id, string articulo, bool activo, bool esIngreso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEditarArticulo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Articulo", articulo);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@esIngreso", esIngreso);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarArticulo(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEliminarArticulo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        #endregion

        #region Categorias
        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcMostrarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarCategoria(string categoria, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcInsertarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarCategoria(int id, string categoria, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEditarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarCategoria(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        #endregion

        #region Estatus
        public DataTable MostrarEstatus()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcMostrarEstatuss";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarEstatus(string Estatu, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcInsertarEstatus";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Estatus", Estatu);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarEstatus(int id, string Estatus, bool activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEditarEstatus";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarEstatus(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEliminarEstatus";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        #endregion

    }
}
