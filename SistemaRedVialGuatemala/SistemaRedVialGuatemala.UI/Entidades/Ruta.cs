using System;

namespace SistemaRedVialGuatemala.UI.Entidades
{
    public class Ruta
    {
        // Datos principales de la ruta
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Distancia { get; set; }
        public string TipoRuta { get; set; }

        // Datos de respaldo de la informacion
        public string Fuente { get; set; }
        public DateTime FechaConsulta { get; set; }

        public Ruta()
        {
        }

        public Ruta(int idRuta, string origen, string destino, decimal distancia, string tipoRuta, string fuente, DateTime fechaConsulta)
        {
            IdRuta = idRuta;
            Origen = origen;
            Destino = destino;
            Distancia = distancia;
            TipoRuta = tipoRuta;
            Fuente = fuente;
            FechaConsulta = fechaConsulta;
        }
    }
}   