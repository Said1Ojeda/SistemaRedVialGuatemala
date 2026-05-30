using System;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Datos;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Formularios
{
    public partial class FrmRutas : Form
    {
        private CargadorDatos datosSistema;

        public FrmRutas()
        {
            InitializeComponent();
            PrepararFormulario();
            CargarDatos();
        }

        private void PrepararFormulario()
        {
            // Prepara la caja donde se muestra el resultado de la busqueda
            txtResultadoRutas.Multiline = true;
            txtResultadoRutas.ScrollBars = ScrollBars.Vertical;
            txtResultadoRutas.ReadOnly = true;

            // Prepara la tabla para mostrar rutas
            dgvRutas.Columns.Clear();
            dgvRutas.Columns.Add("Origen", "Origen");
            dgvRutas.Columns.Add("Destino", "Destino");
            dgvRutas.Columns.Add("Distancia", "Distancia");
            dgvRutas.Columns.Add("TipoRuta", "Tipo de ruta");
            dgvRutas.Columns.Add("Fuente", "Fuente");

            dgvRutas.ReadOnly = true;
            dgvRutas.AllowUserToAddRows = false;
            dgvRutas.AllowUserToDeleteRows = false;
            dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutas.RowHeadersVisible = false;
        }

        private void CargarDatos()
        {
            try
            {
                // Carga las rutas desde SQL y las mete al grafo
                datosSistema = new CargadorDatos();
                datosSistema.CargarTodo();

                MostrarTodasLasRutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar rutas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MostrarTodasLasRutas()
        {
            dgvRutas.Rows.Clear();

            NodoRuta auxiliar = datosSistema.ListaRutas.Inicio;

            // Recorre la lista enlazada de rutas y llena la tabla
            while (auxiliar != null)
            {
                dgvRutas.Rows.Add(
                    auxiliar.Informacion.Origen,
                    auxiliar.Informacion.Destino,
                    auxiliar.Informacion.Distancia.ToString("N2") + " km",
                    auxiliar.Informacion.TipoRuta,
                    auxiliar.Informacion.Fuente
                );

                auxiliar = auxiliar.Siguiente;
            }
        }

        private Ruta BuscarRutaEnGrafo(string origen, string destino)
        {
            NodoVertice vertice = datosSistema.GrafoRutas.BuscarVertice(origen);

            if (vertice == null)
            {
                return null;
            }

            NodoAdyacencia auxiliar = vertice.Adyacencias;

            // Busca si desde ese origen existe una conexion hacia el destino
            while (auxiliar != null)
            {
                if (auxiliar.Informacion.Destino.ToLower() == destino.ToLower())
                {
                    return auxiliar.Informacion;
                }

                auxiliar = auxiliar.Siguiente;
            }

            return null;
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            string origen = txtOrigenRuta.Text.Trim();
            string destino = txtDestinoRuta.Text.Trim();

            if (origen == "" || destino == "")
            {
                MessageBox.Show("Ingrese origen y destino.");
                return;
            }

            // Busca una conexion directa dentro del grafo
            Ruta ruta = BuscarRutaEnGrafo(origen, destino);

            if (ruta != null)
            {
                txtResultadoRutas.Text =
                    "Ruta encontrada:\r\n\r\n" +
                    "Origen: " + ruta.Origen + "\r\n" +
                    "Destino: " + ruta.Destino + "\r\n" +
                    "Distancia: " + ruta.Distancia.ToString("N2") + " km\r\n" +
                    "Tipo: " + ruta.TipoRuta + "\r\n" +
                    "Fuente: " + ruta.Fuente + "\r\n" +
                    "Fecha consulta: " + ruta.FechaConsulta.ToShortDateString();

                dgvRutas.Rows.Clear();

                dgvRutas.Rows.Add(
                    ruta.Origen,
                    ruta.Destino,
                    ruta.Distancia.ToString("N2") + " km",
                    ruta.TipoRuta,
                    ruta.Fuente
                );
            }
            else
            {
                txtResultadoRutas.Text = "No existe una ruta directa entre esos puntos.";
                dgvRutas.Rows.Clear();
            }
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            string origen = txtOrigenConexiones.Text.Trim();

            if (origen == "")
            {
                MessageBox.Show("Ingrese el origen.");
                return;
            }

            NodoVertice vertice = datosSistema.GrafoRutas.BuscarVertice(origen);

            if (vertice == null)
            {
                txtResultadoRutas.Text = "No se encontro el origen.";
                dgvRutas.Rows.Clear();
                return;
            }

            dgvRutas.Rows.Clear();

            NodoAdyacencia auxiliar = vertice.Adyacencias;
            int contador = 0;

            // Muestra todas las conexiones que salen del origen
            while (auxiliar != null)
            {
                dgvRutas.Rows.Add(
                    auxiliar.Informacion.Origen,
                    auxiliar.Informacion.Destino,
                    auxiliar.Informacion.Distancia.ToString("N2") + " km",
                    auxiliar.Informacion.TipoRuta,
                    auxiliar.Informacion.Fuente
                );

                contador++;
                auxiliar = auxiliar.Siguiente;
            }

            txtResultadoRutas.Text =
                "Conexiones desde " + origen + ":\r\n\r\n" +
                "Total de conexiones encontradas: " + contador;
        }

        private void btnLimpiarRuta_Click(object sender, EventArgs e)
        {
            // Limpia los campos de busqueda y vuelve a mostrar todas las rutas
            txtOrigenRuta.Clear();
            txtDestinoRuta.Clear();
            txtOrigenConexiones.Clear();
            txtResultadoRutas.Clear();

            MostrarTodasLasRutas();

            txtOrigenRuta.Focus();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            // Evento creado por el disenador, se usa como boton limpiar si aplica
            btnLimpiarRuta_Click(sender, e);
        }

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            // Evento creado por el disenador, no necesita accion
        }



    }
}