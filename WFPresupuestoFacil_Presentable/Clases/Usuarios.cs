using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPresupuestoFacil_Presentable.Clases
{
    public class Usuarios
    {
        
        public int Usuario_Id { get; set; }
        public string? Usuario_Nombre { get; set; }
        public string? Usuario_Apellidos { get; set; }
        public string? Usuario_Correo { get; set; }
        public string? Usuario_Telefono { get; set; }
        public int? Usuario_Edad { get; set; }
        public string? Usuario_Posicion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }
        public string? Clave { get; set; }
        public int? IdPerfil { get; set; }
        public string? Perfil { get; set; }
    }
}
