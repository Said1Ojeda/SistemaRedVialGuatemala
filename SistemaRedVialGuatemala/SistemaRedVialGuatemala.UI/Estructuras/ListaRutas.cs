using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Estructuras
{
    public class ListaRutas
    {
        // Primer nodo de la lista de rutas
        public NodoRuta Inicio { get; set; }

        public ListaRutas()
        {
            Inicio = null;
        }

        public void AgregarFinal(Ruta ruta)
        {
            NodoRuta nuevo = new NodoRuta(ruta);

            if (Inicio == null)
            {
                Inicio = nuevo;
            }
            else
            {
                NodoRuta auxiliar = Inicio;

                while (auxiliar.Siguiente != null)
                {
                    auxiliar = auxiliar.Siguiente;
                }

                auxiliar.Siguiente = nuevo;
            }
        }

        public Ruta BuscarRuta(string origen, string destino)
        {
            NodoRuta auxiliar = Inicio;

            while (auxiliar != null)
            {
                if (auxiliar.Informacion.Origen.ToLower() == origen.ToLower() &&
                    auxiliar.Informacion.Destino.ToLower() == destino.ToLower())
                {
                    return auxiliar.Informacion;
                }

                auxiliar = auxiliar.Siguiente;
            }

            return null;
        }

        public int Contar()
        {
            int contador = 0;
            NodoRuta auxiliar = Inicio;

            while (auxiliar != null)
            {
                contador++;
                auxiliar = auxiliar.Siguiente;
            }

            return contador;
        }

        public string ObtenerTexto()
        {
            string resultado = "";
            NodoRuta auxiliar = Inicio;

            while (auxiliar != null)
            {
                resultado += auxiliar.Informacion.Origen + " -> " +
                             auxiliar.Informacion.Destino + " | " +
                             auxiliar.Informacion.Distancia.ToString() + " km\r\n";

                auxiliar = auxiliar.Siguiente;
            }

            return resultado;
        }
    }
}