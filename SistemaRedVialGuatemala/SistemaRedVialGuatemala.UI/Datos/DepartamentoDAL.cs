using System.Data.SqlClient;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Estructuras;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class DepartamentoDAL
    {
        private ConexionBD conexionBD;

        public DepartamentoDAL()
        {
            conexionBD = new ConexionBD();
        }

        public void CargarDepartamentos(ArbolDepartamentos arbol)
        {
            SqlConnection conexion = conexionBD.ObtenerConexion();

            string consulta = "SELECT IdDepartamento, Nombre, DistanciaCapital, CantidadMunicipios, Region FROM Departamentos";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            // Lee cada departamento que viene de la base
            while (lector.Read())
            {
                Departamento departamento = new Departamento();

                departamento.IdDepartamento = int.Parse(lector["IdDepartamento"].ToString());
                departamento.Nombre = lector["Nombre"].ToString();
                departamento.DistanciaCapital = decimal.Parse(lector["DistanciaCapital"].ToString());
                departamento.CantidadMunicipios = int.Parse(lector["CantidadMunicipios"].ToString());
                departamento.Region = lector["Region"].ToString();

                // Guarda el departamento dentro del arboll
                arbol.Insertar(departamento);
            }

            lector.Close();
            conexion.Close();
        }
    }
}