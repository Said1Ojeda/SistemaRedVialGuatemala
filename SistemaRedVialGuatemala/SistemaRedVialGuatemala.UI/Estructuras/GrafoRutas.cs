using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Estructuras
{
    public class GrafoRutas
    {
        // Primer vertice del grafo
        public NodoVertice Inicio { get; set; }

        public GrafoRutas()
        {
            Inicio = null;
        }

        public void AgregarVertice(string nombre)
        {
            // Solo se agrega si el vertice no existe
            if (BuscarVertice(nombre) == null)
            {
                NodoVertice nuevo = new NodoVertice(nombre);

                if (Inicio == null)
                {
                    Inicio = nuevo;
                }
                else
                {
                    NodoVertice auxiliar = Inicio;

                    // Se recorre hasta el ultimo vertice
                    while (auxiliar.Siguiente != null)
                    {
                        auxiliar = auxiliar.Siguiente;
                    }

                    auxiliar.Siguiente = nuevo;
                }
            }
        }

        public NodoVertice BuscarVertice(string nombre)
        {
            NodoVertice auxiliar = Inicio;

            // Recorre los vertices hasta encontrar el nombre
            while (auxiliar != null)
            {
                if (auxiliar.Nombre.ToLower() == nombre.ToLower())
                {
                    return auxiliar;
                }

                auxiliar = auxiliar.Siguiente;
            }

            return null;
        }

        public void AgregarRuta(Ruta ruta)
        {
            // Primero se asegura que existan los dos puntos
            AgregarVertice(ruta.Origen);
            AgregarVertice(ruta.Destino);

            NodoVertice origen = BuscarVertice(ruta.Origen);
            NodoVertice destino = BuscarVertice(ruta.Destino);

            if (origen != null && destino != null)
            {
                // Se agrega la conexion desde origen hacia destino
                AgregarAdyacencia(origen, ruta);

                // Se crea la ruta de regreso para que el grafo sea no dirigido
                Ruta rutaRegreso = new Ruta(
                    ruta.IdRuta,
                    ruta.Destino,
                    ruta.Origen,
                    ruta.Distancia,
                    ruta.TipoRuta,
                    ruta.Fuente,
                    ruta.FechaConsulta
                );

                AgregarAdyacencia(destino, rutaRegreso);
            }
        }

        private void AgregarAdyacencia(NodoVertice vertice, Ruta ruta)
        {
            NodoAdyacencia nuevo = new NodoAdyacencia(ruta);

            if (vertice.Adyacencias == null)
            {
                vertice.Adyacencias = nuevo;
            }
            else
            {
                NodoAdyacencia auxiliar = vertice.Adyacencias;

                // Se busca el final de la lista de conexiones
                while (auxiliar.Siguiente != null)
                {
                    auxiliar = auxiliar.Siguiente;
                }

                auxiliar.Siguiente = nuevo;
            }
        }

        public bool ExisteConexion(string origen, string destino)
        {
            NodoVertice vertice = BuscarVertice(origen);

            if (vertice == null)
            {
                return false;
            }

            NodoAdyacencia auxiliar = vertice.Adyacencias;

            // Revisa las conexiones del origen
            while (auxiliar != null)
            {
                if (auxiliar.Informacion.Destino.ToLower() == destino.ToLower())
                {
                    return true;
                }

                auxiliar = auxiliar.Siguiente;
            }

            return false;
        }

        public decimal ObtenerDistanciaDirecta(string origen, string destino)
        {
            NodoVertice vertice = BuscarVertice(origen);

            if (vertice == null)
            {
                return -1;
            }

            NodoAdyacencia auxiliar = vertice.Adyacencias;

            // Busca una ruta directa entre origen y destino
            while (auxiliar != null)
            {
                if (auxiliar.Informacion.Destino.ToLower() == destino.ToLower())
                {
                    return auxiliar.Informacion.Distancia;
                }

                auxiliar = auxiliar.Siguiente;
            }

            return -1;
        }

        public string MostrarConexiones(string origen)
        {
            NodoVertice vertice = BuscarVertice(origen);

            if (vertice == null)
            {
                return "No se encontro el punto de origen.";
            }

            string resultado = "Conexiones desde " + origen + ":\r\n";
            NodoAdyacencia auxiliar = vertice.Adyacencias;

            // Muestra todas las rutas que salen del vertice
            while (auxiliar != null)
            {
                resultado += "- " + auxiliar.Informacion.Destino +
                             " | " + auxiliar.Informacion.Distancia.ToString() +
                             " km | " + auxiliar.Informacion.TipoRuta + "\r\n";

                auxiliar = auxiliar.Siguiente;
            }

            return resultado;
        }

        public string MostrarTodo()
        {
            string resultado = "";
            NodoVertice vertice = Inicio;

            // Recorre todos los vertices del grafo
            while (vertice != null)
            {
                resultado += MostrarConexiones(vertice.Nombre) + "\r\n";
                vertice = vertice.Siguiente;
            }

            return resultado;
        }

        public int ContarVertices()
        {
            int contador = 0;
            NodoVertice auxiliar = Inicio;

            // Cuenta todos los puntos registrados en el grafo
            while (auxiliar != null)
            {
                contador++;
                auxiliar = auxiliar.Siguiente;
            }

            return contador;
        }
    }
}