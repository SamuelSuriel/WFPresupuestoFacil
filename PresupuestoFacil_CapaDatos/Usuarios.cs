using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoFacil_CapaDatos
{
    public class Usuarios
    {
        //public int UsuarioID { get; set; }
        //public string Nombre { get; set; }
        //public string Clave { get; set; }
        //public int? IdPerfil { get; set; }
        //public string Perfil { get; set; }
        public int Usuario_Id { get; set; }
        public string? Usuario_Nombre { get; set; }
        public string? Usuario_Apellidos { get; set; }
        public string? Usuario_Correo { get; set; }
        public string? Usuario_Telefono { get; set; }
        public string? Usuario_Posicion { get; set; }
        public string? Clave { get; set; }
        public int? IdPerfil { get; set; }
        public int? Usuario_Edad { get; set; }
        public string? Perfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }
    }
}
