
using SistemaRedVialGuatemala.UI.Entidades;

namespace SistemaRedVialGuatemala.UI.Nodos
{
    public class NodoMunicipio
    {
        // Guarda la informacion del municipio
        public Municipio Informacion { get; set; }

        // Apunta al siguiente nodo de la lista
        public NodoMunicipio Siguiente { get; set; }

        public NodoMunicipio()
        {
            Informacion = null;
            Siguiente = null;
        }

        public NodoMunicipio(Municipio informacion)
        {
            Informacion = informacion;
            Siguiente = null;
        }
    }
}
