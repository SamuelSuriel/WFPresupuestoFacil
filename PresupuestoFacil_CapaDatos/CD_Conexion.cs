using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection(@"server=LEVHDLL; Database=PresupuestoFacilDb; integrated security =True; TrustServerCertificate=True");
     
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public string query(string clave)
        {
            string query = "";
            if (!clave.IsNullOrEmpty())
                //Query que trae los datos desde la base de datos
                query = "SELECT u.Usuario_Id, u.Usuario_Nombre, u.Clave, u.IdPerfil, p.Perfil FROM Usuarios u INNER JOIN Perfiles p on u.IdPerfil = p.IdPerfil WHERE Clave = " + clave;
            return query;
        }
    }
}
