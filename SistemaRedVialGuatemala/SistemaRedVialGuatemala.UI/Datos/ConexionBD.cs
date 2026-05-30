using System.Data.SqlClient;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class ConexionBD
    {
        // Cadena para conectarse a SQL Server
        private string cadenaConexion = @"Data Source=.\SQLEXPRESS02;Initial Catalog=BDRedVialGuatemala;Integrated Security=True;";

        public SqlConnection ObtenerConexion()
        {
            // Regresa una conexion lista para usar
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }
    }
}