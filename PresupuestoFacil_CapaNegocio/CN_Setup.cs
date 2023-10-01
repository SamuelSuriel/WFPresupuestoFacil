﻿using PresupuestoFacil_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Setup
    {
        private CD_Setup objetoCD = new CD_Setup();

        #region Articulos
        public DataTable MostrarArticulosProc()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarArticulos();
            return tabla;
        }
        public void InsertarArticuloPRod(string articulo, bool activo, bool esIngreso)
        {

            objetoCD.InsertarArticulo(articulo, activo, esIngreso);
        }

        public void EditarArticuloProd(int id, string articulo, bool activo, bool esIngreso)
        {
            objetoCD.EditarArticulo(Convert.ToInt32(id), articulo, activo, esIngreso);
        }

        public void EliminarArticuloPRod(string id)
        {

            objetoCD.EliminarArticulo(Convert.ToInt32(id));
        }
        #endregion

        #region Categorias
        public DataTable MostrarCategoriasProc()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCategoria();
            return tabla;
        }
        public void InsertarCategoriaPRod(string categoria, bool activo)
        {

            objetoCD.InsertarCategoria(categoria, activo);
        }

        public void EditarCategoriaProd(int id, string categoria, bool activo)
        {
            objetoCD.EditarCategoria(Convert.ToInt32(id), categoria, activo);
        }

        public void EliminarCategoriaPRod(string id)
        {

            objetoCD.EliminarCategoria(Convert.ToInt32(id));
        }
        #endregion

        #region Estatus
        public DataTable MostrarEstatusProc()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEstatus();
            return tabla;
        }
        public void InsertarEstatusPRod(string Estatus, bool activo)
        {

            objetoCD.InsertarEstatus(Estatus, activo);
        }

        public void EditarEstatusProd(int id, string Estatus, bool activo)
        {
            objetoCD.EditarEstatus(Convert.ToInt32(id), Estatus, activo);
        }

        public void EliminarEstatusPRod(string id)
        {

            objetoCD.EliminarEstatus(Convert.ToInt32(id));
        }
        #endregion
    }
}
