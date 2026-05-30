using SistemaRedVialGuatemala.UI.Entidades;

namespace SistemaRedVialGuatemala.UI.Nodos
{
    public class NodoAdyacencia
    {
        // Guarda la informacion de la ruta conectada
        public Ruta Informacion { get; set; }

        // Apunta a la siguiente conexion del vertice
        public NodoAdyacencia Siguiente { get; set; }

        public NodoAdyacencia()
        {
            Informacion = null;
            Siguiente = null;
        }

        public NodoAdyacencia(Ruta informacion)
        {
            Informacion = informacion;
            Siguiente = null;
        }
    }
}