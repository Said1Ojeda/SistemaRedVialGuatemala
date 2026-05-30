using SistemaRedVialGuatemala.UI.Estructuras;

namespace SistemaRedVialGuatemala.UI.Datos
{
    public class CargadorDatos
    {
        public ArbolDepartamentos ArbolDepartamentos { get; set; }
        public ListaRutas ListaRutas { get; set; }
        public GrafoRutas GrafoRutas { get; set; }

        private DepartamentoDAL departamentoDAL;
        private RutaDAL rutaDAL;

        public CargadorDatos()
        {
            ArbolDepartamentos = new ArbolDepartamentos();
            ListaRutas = new ListaRutas();
            GrafoRutas = new GrafoRutas();

            departamentoDAL = new DepartamentoDAL();
            rutaDAL = new RutaDAL();
        }

        public void CargarTodo()
        {
            // Carga los departamentos dentro del arbol
            departamentoDAL.CargarDepartamentos(ArbolDepartamentos);

            // Carga las rutas en lista y grafo
            rutaDAL.CargarRutas(ListaRutas, GrafoRutas);
        }
    }
}           