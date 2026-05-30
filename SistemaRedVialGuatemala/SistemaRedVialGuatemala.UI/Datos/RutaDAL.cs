using System;
using System.Data.SqlClient;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Estructuras;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class RutaDAL
    {
        private ConexionBD conexionBD;

        public RutaDAL()
        {
            conexionBD = new ConexionBD();
        }

        public void CargarRutas(ListaRutas listaRutas, GrafoRutas grafoRutas)
        {
            SqlConnection conexion = conexionBD.ObtenerConexion();

            string consulta = "SELECT IdRuta, Origen, Destino, Distancia, TipoRuta, Fuente, FechaConsulta FROM Rutas";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            // Lee cada ruta guardada en la base
            while (lector.Read())
            {
                Ruta ruta = new Ruta();

                ruta.IdRuta = int.Parse(lector["IdRuta"].ToString());
                ruta.Origen = lector["Origen"].ToString();
                ruta.Destino = lector["Destino"].ToString();
                ruta.Distancia = decimal.Parse(lector["Distancia"].ToString());
                ruta.TipoRuta = lector["TipoRuta"].ToString();
                ruta.Fuente = lector["Fuente"].ToString();
                ruta.FechaConsulta = DateTime.Parse(lector["FechaConsulta"].ToString());

                // Guarda la ruta en la lista normal de rutas
                listaRutas.AgregarFinal(ruta);

                // Tambien la mete al grafo para manejar conexiones
                grafoRutas.AgregarRuta(ruta);
            }

            lector.Close();
            conexion.Close();
        }
    }
}