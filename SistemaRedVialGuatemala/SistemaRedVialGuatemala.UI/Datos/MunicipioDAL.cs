using System.Data.SqlClient;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Estructuras;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class MunicipioDAL
    {
        private ConexionBD conexionBD;

        public MunicipioDAL()
        {
            conexionBD = new ConexionBD();
        }

        public ListaMunicipios CargarMunicipiosPorDepartamento(int idDepartamento)
        {
            ListaMunicipios lista = new ListaMunicipios();

            SqlConnection conexion = conexionBD.ObtenerConexion();

            string consulta = "SELECT IdMunicipio, IdDepartamento, Nombre, Poblacion, DistanciaCabecera " +
                              "FROM Municipios WHERE IdDepartamento = @IdDepartamento";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdDepartamento", idDepartamento);

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            // Recorre los municipios encontrados para ese departamento
            while (lector.Read())
            {
                Municipio municipio = new Municipio();

                municipio.IdMunicipio = int.Parse(lector["IdMunicipio"].ToString());
                municipio.IdDepartamento = int.Parse(lector["IdDepartamento"].ToString());
                municipio.Nombre = lector["Nombre"].ToString();
                municipio.Poblacion = int.Parse(lector["Poblacion"].ToString());
                municipio.DistanciaCabecera = decimal.Parse(lector["DistanciaCabecera"].ToString());

                // Mete cada municipio al final de la lista enlazada
                lista.AgregarFinal(municipio);
            }

            lector.Close();
            conexion.Close();

            return lista;
        }

        public Municipio BuscarMunicipioPorNombre(string nombre)
        {
            Municipio municipio = null;

            SqlConnection conexion = conexionBD.ObtenerConexion();

            string consulta = "SELECT IdMunicipio, IdDepartamento, Nombre, Poblacion, DistanciaCabecera " +
                              "FROM Municipios WHERE Nombre = @Nombre";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@Nombre", nombre);

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            // Si encuentra el municipio, lo guarda en el objeto
            if (lector.Read())
            {
                municipio = new Municipio();

                municipio.IdMunicipio = int.Parse(lector["IdMunicipio"].ToString());
                municipio.IdDepartamento = int.Parse(lector["IdDepartamento"].ToString());
                municipio.Nombre = lector["Nombre"].ToString();
                municipio.Poblacion = int.Parse(lector["Poblacion"].ToString());
                municipio.DistanciaCabecera = decimal.Parse(lector["DistanciaCabecera"].ToString());
            }

            lector.Close();
            conexion.Close();

            return municipio;
        }
    }
}