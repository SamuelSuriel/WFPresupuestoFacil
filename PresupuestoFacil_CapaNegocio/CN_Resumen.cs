using PresupuestoFacil_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoFacil_CapaNegocio
{
    public class CN_Resumen
    {
        private CD_Resumen objetoCD = new CD_Resumen();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTotales();
            return tabla;
        }
    }
}
