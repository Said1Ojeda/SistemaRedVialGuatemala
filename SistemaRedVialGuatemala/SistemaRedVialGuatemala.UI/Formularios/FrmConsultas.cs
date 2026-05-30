using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Datos;
using SistemaRedVialGuatemala.UI.Entidades;
using SistemaRedVialGuatemala.UI.Estructuras;
using SistemaRedVialGuatemala.UI.Nodos;

namespace SistemaRedVialGuatemala.UI.Formularios
{
    public partial class FrmConsultas : Form
    {
        private CargadorDatos datosSistema;
        private MunicipioDAL municipioDAL;

        public FrmConsultas()
        {
            InitializeComponent();
            PrepararFormulario();
            CargarDatos();
        }

        private void PrepararFormulario()
        {
            // Prepara la caja donde se muestran respuestas generales
            txtResultadoConsultas.Multiline = true;
            txtResultadoConsultas.ScrollBars = ScrollBars.Vertical;
            txtResultadoConsultas.ReadOnly = true;

            // Prepara la tabla para resultados variados
            dgvConsultas.ReadOnly = true;
            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.AllowUserToDeleteRows = false;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.RowHeadersVisible = false;

            PrepararGridGeneral();
        }

        private void CargarDatos()
        {
            try
            {
                // Carga el arbol, rutas y grafo desde la base
                datosSistema = new CargadorDatos();
                datosSistema.CargarTodo();

                // DAL significa Capa de Acceso a Datos
                municipioDAL = new MunicipioDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar consultas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void PrepararGridGeneral()
        {
            dgvConsultas.Columns.Clear();
            dgvConsultas.Columns.Add("Concepto", "Concepto");
            dgvConsultas.Columns.Add("Dato", "Dato");
            dgvConsultas.Rows.Clear();
        }

        private void PrepararGridMunicipios()
        {
            dgvConsultas.Columns.Clear();
            dgvConsultas.Columns.Add("IdMunicipio", "ID");
            dgvConsultas.Columns.Add("Nombre", "Municipio");
            dgvConsultas.Columns.Add("Poblacion", "Poblacion");
            dgvConsultas.Columns.Add("Distancia", "Distancia a cabecera");
            dgvConsultas.Rows.Clear();
        }

        private void PrepararGridRutas()
        {
            dgvConsultas.Columns.Clear();
            dgvConsultas.Columns.Add("Origen", "Origen");
            dgvConsultas.Columns.Add("Destino", "Destino");
            dgvConsultas.Columns.Add("Distancia", "Distancia");
            dgvConsultas.Columns.Add("Tipo", "Tipo");
            dgvConsultas.Rows.Clear();
        }

        private void AgregarDato(string concepto, string dato)
        {
            dgvConsultas.Rows.Add(concepto, dato);
        }

        private void btnCapitalDepartamento_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = txtDepartamentoConsulta.Text.Trim();

            if (nombreDepartamento == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            // Busca el departamento dentro del arbol
            Departamento departamento = datosSistema.ArbolDepartamentos.Buscar(nombreDepartamento);

            PrepararGridGeneral();

            if (departamento != null)
            {
                txtResultadoConsultas.Text =
                    "Distancia de Capital a Departamento:\r\n\r\n" +
                    "Departamento: " + departamento.Nombre + "\r\n" +
                    "Distancia: " + departamento.DistanciaCapital.ToString("N2") + " km";

                AgregarDato("Departamento", departamento.Nombre);
                AgregarDato("Distancia desde Capital", departamento.DistanciaCapital.ToString("N2") + " km");
                AgregarDato("Region", departamento.Region);
            }
            else
            {
                txtResultadoConsultas.Text = "Departamento no encontrado.";
            }
        }

        private void btnCapitalMunicipio_Click(object sender, EventArgs e)
        {
            string nombreMunicipio = txtMunicipioConsulta.Text.Trim();

            if (nombreMunicipio == "")
            {
                MessageBox.Show("Ingrese el nombre del municipio.");
                return;
            }

            // Busca el municipio en la base
            Municipio municipio = municipioDAL.BuscarMunicipioPorNombre(nombreMunicipio);

            PrepararGridGeneral();

            if (municipio != null)
            {
                Departamento departamento = datosSistema.ArbolDepartamentos.BuscarPorId(municipio.IdDepartamento);

                if (departamento != null)
                {
                    decimal distanciaTotal = departamento.DistanciaCapital + municipio.DistanciaCabecera;

                    txtResultadoConsultas.Text =
                        "Distancia de Capital a Municipio:\r\n\r\n" +
                        "Municipio: " + municipio.Nombre + "\r\n" +
                        "Departamento: " + departamento.Nombre + "\r\n" +
                        "Distancia aproximada: " + distanciaTotal.ToString("N2") + " km";

                    AgregarDato("Municipio", municipio.Nombre);
                    AgregarDato("Departamento", departamento.Nombre);
                    AgregarDato("Capital a departamento", departamento.DistanciaCapital.ToString("N2") + " km");
                    AgregarDato("Departamento a municipio", municipio.DistanciaCabecera.ToString("N2") + " km");
                    AgregarDato("Total aproximado", distanciaTotal.ToString("N2") + " km");
                }
            }
            else
            {
                txtResultadoConsultas.Text = "Municipio no encontrado.";
            }
        }

        private void btnDepartamentoMunicipio_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = txtDepartamentoConsulta.Text.Trim();
            string nombreMunicipio = txtMunicipioConsulta.Text.Trim();

            if (nombreDepartamento == "" || nombreMunicipio == "")
            {
                MessageBox.Show("Ingrese departamento y municipio.");
                return;
            }

            Departamento departamento = datosSistema.ArbolDepartamentos.Buscar(nombreDepartamento);
            Municipio municipio = municipioDAL.BuscarMunicipioPorNombre(nombreMunicipio);

            PrepararGridGeneral();

            if (departamento == null || municipio == null)
            {
                txtResultadoConsultas.Text = "Departamento o municipio no encontrado.";
                return;
            }

            // Verifica que el municipio pertenezca al departamento escrito
            if (departamento.IdDepartamento == municipio.IdDepartamento)
            {
                txtResultadoConsultas.Text =
                    "Distancia de Departamento a Municipio:\r\n\r\n" +
                    "Departamento: " + departamento.Nombre + "\r\n" +
                    "Municipio: " + municipio.Nombre + "\r\n" +
                    "Distancia: " + municipio.DistanciaCabecera.ToString("N2") + " km";

                AgregarDato("Departamento", departamento.Nombre);
                AgregarDato("Municipio", municipio.Nombre);
                AgregarDato("Distancia a cabecera", municipio.DistanciaCabecera.ToString("N2") + " km");
            }
            else
            {
                txtResultadoConsultas.Text = "El municipio no pertenece al departamento ingresado.";
            }
        }

        private void btnCaminoDepartamento_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = txtDepartamentoConsulta.Text.Trim();

            if (nombreDepartamento == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            // Muestra los nodos visitados durante la busqueda
            string camino = datosSistema.ArbolDepartamentos.ObtenerCaminoBusqueda(nombreDepartamento);

            txtResultadoConsultas.Text =
                "Camino de busqueda en el arbol:\r\n\r\n" + camino;

            PrepararGridGeneral();
            AgregarDato("Departamento buscado", nombreDepartamento);
            AgregarDato("Resultado", "Ver camino en el cuadro de texto");
        }

        private void btnMunicipiosDepartamento_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = txtDepartamentoConsulta.Text.Trim();

            if (nombreDepartamento == "")
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            Departamento departamento = datosSistema.ArbolDepartamentos.Buscar(nombreDepartamento);

            if (departamento == null)
            {
                txtResultadoConsultas.Text = "Departamento no encontrado.";
                return;
            }

            ListaMunicipios lista = municipioDAL.CargarMunicipiosPorDepartamento(departamento.IdDepartamento);

            PrepararGridMunicipios();

            NodoMunicipio auxiliar = lista.Inicio;

            // Recorre la lista enlazada y muestra los municipios
            while (auxiliar != null)
            {
                dgvConsultas.Rows.Add(
                    auxiliar.Informacion.IdMunicipio,
                    auxiliar.Informacion.Nombre,
                    auxiliar.Informacion.Poblacion.ToString("N0", CultureInfo.InvariantCulture),
                    auxiliar.Informacion.DistanciaCabecera.ToString("N2") + " km"
                );

                auxiliar = auxiliar.Siguiente;
            }

            txtResultadoConsultas.Text =
                "Municipios del departamento:\r\n\r\n" +
                "Departamento: " + departamento.Nombre + "\r\n" +
                "Cantidad: " + lista.Contar();
        }

        private void btnDistanciaDepartamentos_Click(object sender, EventArgs e)
        {
            string origen = txtOrigenConsulta.Text.Trim();
            string destino = txtDestinoConsulta.Text.Trim();

            if (origen == "" || destino == "")
            {
                MessageBox.Show("Ingrese origen y destino.");
                return;
            }

            // Busca distancia directa en el grafo
            decimal distancia = datosSistema.GrafoRutas.ObtenerDistanciaDirecta(origen, destino);

            PrepararGridGeneral();

            if (distancia >= 0)
            {
                txtResultadoConsultas.Text =
                    "Distancia directa entre puntos:\r\n\r\n" +
                    "Origen: " + origen + "\r\n" +
                    "Destino: " + destino + "\r\n" +
                    "Distancia: " + distancia.ToString("N2") + " km";

                AgregarDato("Origen", origen);
                AgregarDato("Destino", destino);
                AgregarDato("Distancia directa", distancia.ToString("N2") + " km");
            }
            else
            {
                txtResultadoConsultas.Text = "No existe una ruta directa entre esos puntos.";
            }
        }

        private void btnDepartamentoDeMunicipio_Click(object sender, EventArgs e)
        {
            string nombreMunicipio = txtMunicipioConsulta.Text.Trim();

            if (nombreMunicipio == "")
            {
                MessageBox.Show("Ingrese el nombre del municipio.");
                return;
            }

            Municipio municipio = municipioDAL.BuscarMunicipioPorNombre(nombreMunicipio);

            PrepararGridGeneral();

            if (municipio != null)
            {
                Departamento departamento = datosSistema.ArbolDepartamentos.BuscarPorId(municipio.IdDepartamento);

                if (departamento != null)
                {
                    txtResultadoConsultas.Text =
                        "Departamento al que pertenece el municipio:\r\n\r\n" +
                        "Municipio: " + municipio.Nombre + "\r\n" +
                        "Departamento: " + departamento.Nombre;

                    AgregarDato("Municipio", municipio.Nombre);
                    AgregarDato("Departamento", departamento.Nombre);
                    AgregarDato("Region", departamento.Region);
                }
            }
            else
            {
                txtResultadoConsultas.Text = "Municipio no encontrado.";
            }
        }

        private void btnConexiones_Click(object sender, EventArgs e)
        {
            string origen = txtOrigenConsulta.Text.Trim();

            if (origen == "")
            {
                MessageBox.Show("Ingrese el origen.");
                return;
            }

            NodoVertice vertice = datosSistema.GrafoRutas.BuscarVertice(origen);

            if (vertice == null)
            {
                txtResultadoConsultas.Text = "No se encontro el origen.";
                dgvConsultas.Rows.Clear();
                return;
            }

            PrepararGridRutas();

            NodoAdyacencia auxiliar = vertice.Adyacencias;
            int contador = 0;

            // Muestra las conexiones directas del origen
            while (auxiliar != null)
            {
                dgvConsultas.Rows.Add(
                    auxiliar.Informacion.Origen,
                    auxiliar.Informacion.Destino,
                    auxiliar.Informacion.Distancia.ToString("N2") + " km",
                    auxiliar.Informacion.TipoRuta
                );

                contador++;
                auxiliar = auxiliar.Siguiente;
            }

            txtResultadoConsultas.Text =
                "Conexiones encontradas:\r\n\r\n" +
                "Origen: " + origen + "\r\n" +
                "Cantidad de conexiones: " + contador;
        }

       


        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            // Evento creado por el disenador, no necesita accion
        }

        private void btnLimpiarConsultas_Click(object sender, EventArgs e)
       
        {
            // Limpia todos los campos de consulta
            txtDepartamentoConsulta.Clear();
            txtMunicipioConsulta.Clear();
            txtOrigenConsulta.Clear();
            txtDestinoConsulta.Clear();
            txtResultadoConsultas.Clear();

            PrepararGridGeneral();

            txtDepartamentoConsulta.Focus();
        }

        private void btnDistanciaDepartamentos_Click_1(object sender, EventArgs e)
        {
            string origen = txtOrigenConsulta.Text.Trim();
            string destino = txtDestinoConsulta.Text.Trim();

            if (origen == "" || destino == "")
            {
                MessageBox.Show("Ingrese origen y destino.");
                return;
            }

            // Busca si existe una ruta directa entre los dos puntos
            decimal distancia = datosSistema.GrafoRutas.ObtenerDistanciaDirecta(origen, destino);

            PrepararGridGeneral();

            if (distancia >= 0)
            {
                txtResultadoConsultas.Text =
                    "Distancia directa entre puntos:\r\n\r\n" +
                    "Origen: " + origen + "\r\n" +
                    "Destino: " + destino + "\r\n" +
                    "Distancia: " + distancia.ToString("N2") + " km";

                AgregarDato("Origen", origen);
                AgregarDato("Destino", destino);
                AgregarDato("Distancia directa", distancia.ToString("N2") + " km");
            }
            else
            {
                txtResultadoConsultas.Text = "No existe una ruta directa entre esos puntos.";
            }
        }

        private void btnConexiones_Click_1(object sender, EventArgs e)
        {
            string origen = txtOrigenConsulta.Text.Trim();

            if (origen == "")
            {
                MessageBox.Show("Ingrese el origen.");
                return;
            }

            NodoVertice vertice = datosSistema.GrafoRutas.BuscarVertice(origen);

            if (vertice == null)
            {
                txtResultadoConsultas.Text = "No se encontro el origen.";
                dgvConsultas.Rows.Clear();
                return;
            }

            PrepararGridRutas();

            NodoAdyacencia auxiliar = vertice.Adyacencias;
            int contador = 0;

            // Recorre las conexiones que salen desde el origen
            while (auxiliar != null)
            {
                dgvConsultas.Rows.Add(
                    auxiliar.Informacion.Origen,
                    auxiliar.Informacion.Destino,
                    auxiliar.Informacion.Distancia.ToString("N2") + " km",
                    auxiliar.Informacion.TipoRuta
                );

                contador++;
                auxiliar = auxiliar.Siguiente;
            }

            txtResultadoConsultas.Text =
                "Conexiones encontradas:\r\n\r\n" +
                "Origen: " + origen + "\r\n" +
                "Cantidad de conexiones: " + contador;
        }
    }
    


}