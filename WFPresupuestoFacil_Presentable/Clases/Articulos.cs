using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPresupuestoFacil_Presentable.Clases
{
    public class Articulos
    {
        public int Articulo_Id { get; set; }
        public string? Articulo { get; set; }
        public bool Activo { get; set; }
        public bool EsIngreso { get; set; }
    }
}
