using System;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Datos;

namespace SistemaRedVialGuatemala.UI.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public CargadorDatos DatosSistema { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // Carga los datos principales al iniciar
                DatosSistema = new CargadorDatos();
                DatosSistema.CargarTodo();

                MessageBox.Show(
                    "Datos cargados correctamente.",
                    "Carga inicial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                // Muestra el error si la conexion falla
                MessageBox.Show(
                    "Error al cargar los datos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Panel BuscarPanelContenido()
        {
            Control[] controles = this.Controls.Find("pnlContenido", true);

            if (controles.Length > 0)
            {
                return controles[0] as Panel;
            }

            controles = this.Controls.Find("panel5", true);

            if (controles.Length > 0)
            {
                return controles[0] as Panel;
            }

            return null;
        }

        private void AbrirFormulario(Form formulario)
        {
            Panel panelContenido = BuscarPanelContenido();

            if (panelContenido == null)
            {
                MessageBox.Show(
                    "No se encontro el panel de contenido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Limpia el centro antes de mostrar otra pantalla
            panelContenido.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void MostrarInicio()
        {
            Panel panelContenido = BuscarPanelContenido();

            if (panelContenido != null)
            {
                // Regresa al inicio limpiando el panel central
                panelContenido.Controls.Clear();
            }
        }

        private void SalirDelSistema()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmDepartamentos());
        }

        private void btnDepartamentos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmDepartamentos());
        }

        private void btnMunicipios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMunicipios());
        }

        private void btnMunicipios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMunicipios());
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRutas());
        }

        private void btnRutas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRutas());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultas());
        }

        private void btnConsultas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Si este era el boton consultas viejo, tambien abre consultas
            AbrirFormulario(new FrmConsultas());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAcercaDe());
        }

        private void btnAcercaDe_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAcercaDe());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SalirDelSistema();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            SalirDelSistema();
        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            SalirDelSistema();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloSistema_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMunicipios_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMunicipios());

        }
    }
}