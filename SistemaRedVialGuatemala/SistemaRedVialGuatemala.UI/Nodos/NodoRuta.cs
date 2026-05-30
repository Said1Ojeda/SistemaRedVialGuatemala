using SistemaRedVialGuatemala.UI.Entidades;

namespace SistemaRedVialGuatemala.UI.Nodos
{
    public class NodoRuta
    {
        // Guarda la informacion de la ruta
        public Ruta Informacion { get; set; }

        // Apunta a la siguiente ruta
        public NodoRuta Siguiente { get; set; }

        public NodoRuta()
        {
            Informacion = null;
            Siguiente = null;
        }

        public NodoRuta(Ruta informacion)
        {
            Informacion = informacion;
            Siguiente = null;
        }
    }
}