using System.Configuration;
using System.Data.SqlClient;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class ConexionBD
    {
        // Cadena por si no se encuentra la del App.config
        private const string CadenaPorDefecto = @"Data Source=.\SQLEXPRESS02;Initial Catalog=BDRedVialGuatemala;Integrated Security=True;";

        private string cadenaConexion;

        public ConexionBD()
        {
            // La cadena se cambia en el App.config sin tocar el codigo
            ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings["RedVial"];

            if (configuracion != null && !string.IsNullOrWhiteSpace(configuracion.ConnectionString))
            {
                cadenaConexion = configuracion.ConnectionString;
            }
            else
            {
                cadenaConexion = CadenaPorDefecto;
            }
        }

        public SqlConnection ObtenerConexion()
        {
            // Regresa una conexion lista para usar
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }
    }
}