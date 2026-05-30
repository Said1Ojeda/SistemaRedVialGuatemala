namespace SistemaRedVialGuatemala.UI.Nodos
{
    public class NodoVertice
    {
        // Nombre del punto dentro del grafo
        public string Nombre { get; set; }

        // Lista de conexiones que salen de este vertice
        public NodoAdyacencia Adyacencias { get; set; }

        // Apunta al siguiente vertice del grafo
        public NodoVertice Siguiente { get; set; }

        public NodoVertice()
        {
            Nombre = "";
            Adyacencias = null;
            Siguiente = null;
        }

        public NodoVertice(string nombre)
        {
            Nombre = nombre;
            Adyacencias = null;
            Siguiente = null;
        }
    }
}