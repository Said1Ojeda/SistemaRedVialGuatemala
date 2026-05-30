using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Datos;
using SistemaRedVialGuatemala.UI.Nodos;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Estructuras;

namespace SistemaRedVialGuatemala.UI.Formularios
{
    public partial class FrmMunicipios : Form
    {
        private CargadorDatos datosSistema;
        private MunicipioDAL municipioDAL;

        public FrmMunicipios()
        {
            InitializeComponent();
            PrepararFormulario();
            CargarDatos();
        }

        private void PrepararFormulario()
        {
            // Prepara la caja donde se muestra la informacion del municipio
            txtResultadoMunicipios.Multiline = true;
            txtResultadoMunicipios.ScrollBars = ScrollBars.Vertical;
            txtResultadoMunicipios.ReadOnly = true;

            // Prepara la tabla para mostrar uno o varios municipios
            dgvMunicipios.Columns.Clear();
            dgvMunicipios.Columns.Add("IdMunicipio", "ID");
            dgvMunicipios.Columns.Add("Nombre", "Municipio");
            dgvMunicipios.Columns.Add("Poblacion", "Poblacion");
            dgvMunicipios.Columns.Add("Distancia", "Distancia a cabecera");

            dgvMunicipios.RowHeadersVisible = false;

            dgvMunicipios.ReadOnly = true;
            dgvMunicipios.AllowUserToAddRows = false;
            dgvMunicipios.AllowUserToDeleteRows = false;
            dgvMunicipios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDatos()
        {
            try
            {
                // Carga el arbol y las estructuras principales
                datosSistema = new CargadorDatos();
                datosSistema.CargarTodo();

                // DAL significa Capa de Acceso a Datos
                municipioDAL = new MunicipioDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar municipios: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBuscarMunicipio_Click(object sender, EventArgs e)
        {
            string nombreMunicipio = txtBuscarMunicipio.Text.Trim();

            if (nombreMunicipio == "")
            {
                MessageBox.Show("Ingrese el nombre del municipio.");
                return;
            }

            // Busca el municipio en la base de datos
            Municipio municipio = municipioDAL.BuscarMunicipioPorNombre(nombreMunicipio);

            if (municipio != null)
            {
                // Busca el departamento al que pertenece
                Departamento departamento = datosSistema.ArbolDepartamentos.BuscarPorId(municipio.IdDepartamento);

                string nombreDepartamento = "No encontrado";

                if (departamento != null)
                {
                    nombreDepartamento = departamento.Nombre;
                }

                txtResultadoMunicipios.Text =
                    "Municipio encontrado:\r\n\r\n" +
                    "ID: " + municipio.IdMunicipio + "\r\n" +
                    "Nombre: " + municipio.Nombre + "\r\n" +
                    "Departamento: " + nombreDepartamento + "\r\n" +
                    "Poblacion: " + municipio.Poblacion.ToString("N0", CultureInfo.InvariantCulture) + "\r\n" +
                    "Distancia a cabecera: " + municipio.DistanciaCabecera.ToString("N2") + " km";

                // Muestra tambien el municipio buscado en la tabla
                dgvMunicipios.Rows.Clear();

                dgvMunicipios.Rows.Add(
    municipio.IdMunicipio,
    municipio.Nombre,
    municipio.Poblacion.ToString("N0", CultureInfo.InvariantCulture),
    municipio.DistanciaCabecera.ToString("N2") + " km"
);
            }
            else
            {
                txtResultadoMunicipios.Text = "Municipio no encontrado.";
                dgvMunicipios.Rows.Clear();
            }
        }

        private void btnMostrarMunicipios_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = txtDepartamentoMunicipio.Text.Trim();

            if (nombreDepartamento == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            // Busca el departamento dentro del arbol
            Departamento departamento = datosSistema.ArbolDepartamentos.Buscar(nombreDepartamento);

            if (departamento == null)
            {
                MessageBox.Show("Departamento no encontrado.");
                dgvMunicipios.Rows.Clear();
                return;
            }

            // Carga los municipios en una lista enlazada manual
            ListaMunicipios lista = municipioDAL.CargarMunicipiosPorDepartamento(departamento.IdDepartamento);

            // Solo llena la tabla, no toca la informacion del municipio buscado
            MostrarMunicipiosEnGrid(lista);
        }

        private void MostrarMunicipiosEnGrid(ListaMunicipios lista)
        {
            dgvMunicipios.Rows.Clear();

            NodoMunicipio auxiliar = lista.Inicio;

            // Recorre la lista enlazada y llena la tabla visual
            while (auxiliar != null)
            {
                dgvMunicipios.Rows.Add(
    auxiliar.Informacion.IdMunicipio,
    auxiliar.Informacion.Nombre,
    auxiliar.Informacion.Poblacion.ToString("N0", CultureInfo.InvariantCulture),
    auxiliar.Informacion.DistanciaCabecera.ToString("N2") + " km"
);

                auxiliar = auxiliar.Siguiente;
            }
        }

        private void btnLimpiarMunicipio_Click(object sender, EventArgs e)
        {
            // Limpia solo la seccion de buscar municipio
            txtBuscarMunicipio.Clear();
            txtResultadoMunicipios.Clear();

            // Tambien limpia la tabla si estaba mostrando el municipio buscado
            dgvMunicipios.Rows.Clear();

            txtBuscarMunicipio.Focus();
        }

        private void txtResultadoMunicipios_TextChanged(object sender, EventArgs e)
        {
            // Evento creado por el disenador, no necesita accion
        }

        private void FrmMunicipios_Load(object sender, EventArgs e)
        {
            // Evento creado por el disenador, no necesita accion
        }
    }
}