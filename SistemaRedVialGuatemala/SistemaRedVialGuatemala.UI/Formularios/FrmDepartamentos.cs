using System;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Datos;
using SistemaRedVialGuatemala.UI.Entidades;

namespace SistemaRedVialGuatemala.UI.Formularios
{
    public partial class FrmDepartamentos : Form
    {
        private CargadorDatos datosSistema;

        public FrmDepartamentos()
        {
            InitializeComponent();
            PrepararFormulario();
            CargarDatos();
        }

        private void PrepararFormulario()
        {
            // Prepara el cuadro donde se muestran los resultados
            txtResultadoDepartamentos.Multiline = true;
            txtResultadoDepartamentos.ScrollBars = ScrollBars.Vertical;
            txtResultadoDepartamentos.ReadOnly = true;
            txtResultadoDepartamentos.Height = 160;
        }

        private void CargarDatos()
        {
            try
            {
                // Carga los departamentos desde la base hacia el arbol
                datosSistema = new CargadorDatos();
                datosSistema.CargarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar departamentos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarDepartamento.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            // Busca el departamento dentro del arbol
            Departamento departamento = datosSistema.ArbolDepartamentos.Buscar(nombre);

            if (departamento != null)
            {
                txtResultadoDepartamentos.Text =
                    "Departamento encontrado:\r\n\r\n" +
                    "ID: " + departamento.IdDepartamento + "\r\n" +
                    "Nombre: " + departamento.Nombre + "\r\n" +
                    "Distancia desde Capital: " + departamento.DistanciaCapital + " km\r\n" +
                    "Cantidad de municipios: " + departamento.CantidadMunicipios + "\r\n" +
                    "Region: " + departamento.Region;
            }
            else
            {
                txtResultadoDepartamentos.Text = "Departamento no encontrado.";
            }
        }

        private void btnDistanciaCapital_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarDepartamento.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            // Busca solo la distancia guardada para ese departamento
            decimal distancia = datosSistema.ArbolDepartamentos.ObtenerDistanciaCapital(nombre);

            if (distancia >= 0)
            {
                txtResultadoDepartamentos.Text =
                    "Distancia desde Ciudad Capital:\r\n\r\n" +
                    nombre + " esta a " + distancia + " km aproximadamente.";
            }
            else
            {
                txtResultadoDepartamentos.Text = "Departamento no encontrado.";
            }
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            // Muestra los departamentos ordenados alfabeticamente
            txtResultadoDepartamentos.Text = datosSistema.ArbolDepartamentos.RecorridoInOrden();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            // Muestra el recorrido empezando desde la raiz
            txtResultadoDepartamentos.Text = datosSistema.ArbolDepartamentos.RecorridoPreOrden();
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            // Muestra el recorrido dejando la raiz al final
            txtResultadoDepartamentos.Text = datosSistema.ArbolDepartamentos.RecorridoPostOrden();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // Evento del titulo, no necesita accion
        }

            private void groupBox1_Enter(object sender, EventArgs e)
        {
                // Evento del grupo de busqueda, no necesita accion
        }

        private void lblTituloDepartamentos_Load(object sender, EventArgs e)
        {
            // Carga los datos cuando abre el formulario
            CargarDatos();
        }
    }
}