using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Estructuras
{
    public class ArbolDepartamentos
    {
        // Raiz principal del arbol
        public NodoDepartamento Raiz { get; set; }

        public ArbolDepartamentos()
        {
            Raiz = null;
        }

        public void Insertar(Departamento departamento)
        {
            // La insercion inicia desde la raiz
            Raiz = InsertarRecursivo(Raiz, departamento);
        }

        private NodoDepartamento InsertarRecursivo(NodoDepartamento actual, Departamento departamento)
        {
            // Si el espacio esta vacio, aqui se crea el nuevo nodo
            if (actual == null)
            {
                return new NodoDepartamento(departamento);
            }

            // Se compara por nombre para mantener el arbol ordenado alfabeticamente
            int comparacion = string.Compare(departamento.Nombre, actual.Informacion.Nombre, true);

            if (comparacion < 0)
            {
                // Si el nombre es menor, se va hacia la izquierda
                actual.Izquierdo = InsertarRecursivo(actual.Izquierdo, departamento);
            }
            else if (comparacion > 0)
            {
                // Si el nombre es mayor, se va hacia la derecha
                actual.Derecho = InsertarRecursivo(actual.Derecho, departamento);
            }
            else
            {
                // Si ya existe, se actualiza la informacion
                actual.Informacion = departamento;
            }

            return actual;
        }

        public Departamento Buscar(string nombre)
        {
            // La busqueda tambien inicia desde la raiz
            return BuscarRecursivo(Raiz, nombre);
        }

        private Departamento BuscarRecursivo(NodoDepartamento actual, string nombre)
        {
            // Si llega a null, el departamento no existe en el arbol
            if (actual == null)
            {
                return null;
            }

            int comparacion = string.Compare(nombre, actual.Informacion.Nombre, true);

            if (comparacion == 0)
            {
                // Si la comparacion da cero, encontro el departamento
                return actual.Informacion;
            }
            else if (comparacion < 0)
            {
                // Si el nombre buscado es menor, continua por la izquierda
                return BuscarRecursivo(actual.Izquierdo, nombre);
            }
            else
            {
                // Si el nombre buscado es mayor, continua por la derecha
                return BuscarRecursivo(actual.Derecho, nombre);
            }
        }

        public decimal ObtenerDistanciaCapital(string nombre)
        {
            Departamento departamento = Buscar(nombre);

            if (departamento != null)
            {
                return departamento.DistanciaCapital;
            }

            // Se devuelve -1 para indicar que no se encontro
            return -1;
        }

        public string RecorridoInOrden()
        {
            string resultado = "";
            RecorridoInOrdenRecursivo(Raiz, ref resultado);
            return resultado;
        }

        private void RecorridoInOrdenRecursivo(NodoDepartamento actual, ref string resultado)
        {
            if (actual != null)
            {
                // InOrden: izquierda, raiz, derecha
                RecorridoInOrdenRecursivo(actual.Izquierdo, ref resultado);

                resultado += actual.Informacion.Nombre + " - " +
                             actual.Informacion.DistanciaCapital.ToString() + " km\r\n";

                RecorridoInOrdenRecursivo(actual.Derecho, ref resultado);
            }
        }

        public string RecorridoPreOrden()
        {
            string resultado = "";
            RecorridoPreOrdenRecursivo(Raiz, ref resultado);
            return resultado;
        }

        private void RecorridoPreOrdenRecursivo(NodoDepartamento actual, ref string resultado)
        {
            if (actual != null)
            {
                // PreOrden: raiz, izquierda, derecha
                resultado += actual.Informacion.Nombre + "\r\n";

                RecorridoPreOrdenRecursivo(actual.Izquierdo, ref resultado);
                RecorridoPreOrdenRecursivo(actual.Derecho, ref resultado);
            }
        }

        public string RecorridoPostOrden()
        {
            string resultado = "";
            RecorridoPostOrdenRecursivo(Raiz, ref resultado);
            return resultado;
        }

        private void RecorridoPostOrdenRecursivo(NodoDepartamento actual, ref string resultado)
        {
            if (actual != null)
            {
                // PostOrden: izquierda, derecha, raiz
                RecorridoPostOrdenRecursivo(actual.Izquierdo, ref resultado);
                RecorridoPostOrdenRecursivo(actual.Derecho, ref resultado);

                resultado += actual.Informacion.Nombre + "\r\n";
            }
        }

        public string ObtenerCaminoBusqueda(string nombre)
        {
            string camino = "";
            bool encontrado = CrearCaminoBusqueda(Raiz, nombre, ref camino);

            if (encontrado == true)
            {
                return camino;
            }

            return "Departamento no encontrado.";
        }

        private bool CrearCaminoBusqueda(NodoDepartamento actual, string nombre, ref string camino)
        {
            if (actual == null)
            {
                return false;
            }

            // Se agrega el departamento visitado durante la busqueda
            camino += actual.Informacion.Nombre + "\r\n";

            int comparacion = string.Compare(nombre, actual.Informacion.Nombre, true);

            if (comparacion == 0)
            {
                return true;
            }
            else if (comparacion < 0)
            {
                // La busqueda sigue por la rama izquierda
                return CrearCaminoBusqueda(actual.Izquierdo, nombre, ref camino);
            }
            else
            {
                // La busqueda sigue por la rama derecha
                return CrearCaminoBusqueda(actual.Derecho, nombre, ref camino);
            }
        }

        public int ContarDepartamentos()
        {
            return ContarRecursivo(Raiz);
        }

        private int ContarRecursivo(NodoDepartamento actual)
        {
            if (actual == null)
            {
                return 0;
            }

            // Cuenta el nodo actual y luego suma ambas ramas
            return 1 + ContarRecursivo(actual.Izquierdo) + ContarRecursivo(actual.Derecho);
        }




        public Departamento BuscarPorId(int idDepartamento)
        {
            // Busca un departamento usando su ID
            return BuscarPorIdRecursivo(Raiz, idDepartamento);
        }

        private Departamento BuscarPorIdRecursivo(NodoDepartamento actual, int idDepartamento)
        {
            if (actual == null)
            {
                return null;
            }

            if (actual.Informacion.IdDepartamento == idDepartamento)
            {
                return actual.Informacion;
            }

            // Primero busca en la rama izquierda
            Departamento encontrado = BuscarPorIdRecursivo(actual.Izquierdo, idDepartamento);

            if (encontrado != null)
            {
                return encontrado;
            }

            // Si no estaba a la izquierda, busca a la derecha
            return BuscarPorIdRecursivo(actual.Derecho, idDepartamento);
        }








    }
}