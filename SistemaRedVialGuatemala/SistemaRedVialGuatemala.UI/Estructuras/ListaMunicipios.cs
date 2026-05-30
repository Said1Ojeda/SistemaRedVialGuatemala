using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Estructuras
{
    public class ListaMunicipios
    {
        // Primer nodo de la lista
        public NodoMunicipio Inicio { get; set; }

        public ListaMunicipios()
        {
            Inicio = null;
        }

        public void AgregarFinal(Municipio municipio)
        {
            NodoMunicipio nuevo = new NodoMunicipio(municipio);

            if (Inicio == null)
            {
                Inicio = nuevo;
            }
            else
            {
                NodoMunicipio auxiliar = Inicio;

                while (auxiliar.Siguiente != null)
                {
                    auxiliar = auxiliar.Siguiente;
                }

                auxiliar.Siguiente = nuevo;
            }
        }

        public Municipio BuscarPorNombre(string nombre)
        {
            NodoMunicipio auxiliar = Inicio;

            while (auxiliar != null)
            {
                if (auxiliar.Informacion.Nombre.ToLower() == nombre.ToLower())
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
            NodoMunicipio auxiliar = Inicio;

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
            NodoMunicipio auxiliar = Inicio;

            while (auxiliar != null)
            {
                resultado += auxiliar.Informacion.Nombre + " - Poblacion: " +
             auxiliar.Informacion.Poblacion.ToString("N0") + "\r\n";

                auxiliar = auxiliar.Siguiente;
            }

            return resultado;
        }
    }
}