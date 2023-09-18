using Microsoft.Data.SqlClient;
using System.Data;

namespace PresupuestoFacil_CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection(@"server=LEVHDLL; Database=PresupuestoFacilDb; integrated security =True; TrustServerCertificate=True");

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
    }
}
