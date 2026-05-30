namespace SistemaRedVialGuatemala.UI.Formularios
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosConsulta = new System.Windows.Forms.GroupBox();
            this.txtMunicipioConsulta = new System.Windows.Forms.TextBox();
            this.lblMunicipioConsulta = new System.Windows.Forms.Label();
            this.btnCapitalMunicipio = new System.Windows.Forms.Button();
            this.btnCapitalDepartamento = new System.Windows.Forms.Button();
            this.txtDepartamentoConsulta = new System.Windows.Forms.TextBox();
            this.lblDepartamentoConsulta = new System.Windows.Forms.Label();
            this.lblTituloRutas = new System.Windows.Forms.Label();
            this.txtOrigenConsulta = new System.Windows.Forms.TextBox();
            this.lblOrigenConsulta = new System.Windows.Forms.Label();
            this.txtDestinoConsulta = new System.Windows.Forms.TextBox();
            this.lblDestinoConsulta = new System.Windows.Forms.Label();
            this.btnDepartamentoMunicipio = new System.Windows.Forms.Button();
            this.btnCaminoDepartamento = new System.Windows.Forms.Button();
            this.txtResultadoConsultas = new System.Windows.Forms.TextBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnLimpiarConsultas = new System.Windows.Forms.Button();
            this.btnConexiones = new System.Windows.Forms.Button();
            this.btnDistanciaDepartamentos = new System.Windows.Forms.Button();
            this.gbDatosConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosConsulta
            // 
            this.gbDatosConsulta.Controls.Add(this.btnDistanciaDepartamentos);
            this.gbDatosConsulta.Controls.Add(this.btnConexiones);
            this.gbDatosConsulta.Controls.Add(this.btnLimpiarConsultas);
            this.gbDatosConsulta.Controls.Add(this.dgvConsultas);
            this.gbDatosConsulta.Controls.Add(this.txtResultadoConsultas);
            this.gbDatosConsulta.Controls.Add(this.btnCaminoDepartamento);
            this.gbDatosConsulta.Controls.Add(this.btnDepartamentoMunicipio);
            this.gbDatosConsulta.Controls.Add(this.txtDestinoConsulta);
            this.gbDatosConsulta.Controls.Add(this.lblDestinoConsulta);
            this.gbDatosConsulta.Controls.Add(this.txtOrigenConsulta);
            this.gbDatosConsulta.Controls.Add(this.lblOrigenConsulta);
            this.gbDatosConsulta.Controls.Add(this.txtMunicipioConsulta);
            this.gbDatosConsulta.Controls.Add(this.lblMunicipioConsulta);
            this.gbDatosConsulta.Controls.Add(this.btnCapitalMunicipio);
            this.gbDatosConsulta.Controls.Add(this.btnCapitalDepartamento);
            this.gbDatosConsulta.Controls.Add(this.txtDepartamentoConsulta);
            this.gbDatosConsulta.Controls.Add(this.lblDepartamentoConsulta);
            this.gbDatosConsulta.Location = new System.Drawing.Point(44, 205);
            this.gbDatosConsulta.Name = "gbDatosConsulta";
            this.gbDatosConsulta.Size = new System.Drawing.Size(917, 736);
            this.gbDatosConsulta.TabIndex = 5;
            this.gbDatosConsulta.TabStop = false;
            this.gbDatosConsulta.Text = "consulta";
            // 
            // txtMunicipioConsulta
            // 
            this.txtMunicipioConsulta.AcceptsReturn = true;
            this.txtMunicipioConsulta.Location = new System.Drawing.Point(231, 93);
            this.txtMunicipioConsulta.Name = "txtMunicipioConsulta";
            this.txtMunicipioConsulta.Size = new System.Drawing.Size(311, 26);
            this.txtMunicipioConsulta.TabIndex = 12;
            // 
            // lblMunicipioConsulta
            // 
            this.lblMunicipioConsulta.AutoSize = true;
            this.lblMunicipioConsulta.Location = new System.Drawing.Point(93, 99);
            this.lblMunicipioConsulta.Name = "lblMunicipioConsulta";
            this.lblMunicipioConsulta.Size = new System.Drawing.Size(79, 20);
            this.lblMunicipioConsulta.TabIndex = 11;
            this.lblMunicipioConsulta.Text = "Municipio:";
            // 
            // btnCapitalMunicipio
            // 
            this.btnCapitalMunicipio.Location = new System.Drawing.Point(569, 90);
            this.btnCapitalMunicipio.Name = "btnCapitalMunicipio";
            this.btnCapitalMunicipio.Size = new System.Drawing.Size(215, 38);
            this.btnCapitalMunicipio.TabIndex = 10;
            this.btnCapitalMunicipio.Text = "Capital a Municipio";
            this.btnCapitalMunicipio.UseVisualStyleBackColor = true;
            this.btnCapitalMunicipio.Click += new System.EventHandler(this.btnCapitalMunicipio_Click);
            // 
            // btnCapitalDepartamento
            // 
            this.btnCapitalDepartamento.Location = new System.Drawing.Point(569, 29);
            this.btnCapitalDepartamento.Name = "btnCapitalDepartamento";
            this.btnCapitalDepartamento.Size = new System.Drawing.Size(215, 38);
            this.btnCapitalDepartamento.TabIndex = 9;
            this.btnCapitalDepartamento.Text = "Capital a Departamento";
            this.btnCapitalDepartamento.UseVisualStyleBackColor = true;
            this.btnCapitalDepartamento.Click += new System.EventHandler(this.btnCapitalDepartamento_Click);
            // 
            // txtDepartamentoConsulta
            // 
            this.txtDepartamentoConsulta.AcceptsReturn = true;
            this.txtDepartamentoConsulta.Location = new System.Drawing.Point(231, 42);
            this.txtDepartamentoConsulta.Name = "txtDepartamentoConsulta";
            this.txtDepartamentoConsulta.Size = new System.Drawing.Size(311, 26);
            this.txtDepartamentoConsulta.TabIndex = 8;
            // 
            // lblDepartamentoConsulta
            // 
            this.lblDepartamentoConsulta.AutoSize = true;
            this.lblDepartamentoConsulta.Location = new System.Drawing.Point(93, 42);
            this.lblDepartamentoConsulta.Name = "lblDepartamentoConsulta";
            this.lblDepartamentoConsulta.Size = new System.Drawing.Size(120, 20);
            this.lblDepartamentoConsulta.TabIndex = 4;
            this.lblDepartamentoConsulta.Text = "Departamento :";
            // 
            // lblTituloRutas
            // 
            this.lblTituloRutas.AutoSize = true;
            this.lblTituloRutas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloRutas.Location = new System.Drawing.Point(374, 126);
            this.lblTituloRutas.Name = "lblTituloRutas";
            this.lblTituloRutas.Size = new System.Drawing.Size(319, 45);
            this.lblTituloRutas.TabIndex = 6;
            this.lblTituloRutas.Text = "Consultas Generales";
            // 
            // txtOrigenConsulta
            // 
            this.txtOrigenConsulta.AcceptsReturn = true;
            this.txtOrigenConsulta.Location = new System.Drawing.Point(231, 149);
            this.txtOrigenConsulta.Name = "txtOrigenConsulta";
            this.txtOrigenConsulta.Size = new System.Drawing.Size(311, 26);
            this.txtOrigenConsulta.TabIndex = 14;
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(93, 155);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(60, 20);
            this.lblOrigenConsulta.TabIndex = 13;
            this.lblOrigenConsulta.Text = "Origen:";
            // 
            // txtDestinoConsulta
            // 
            this.txtDestinoConsulta.AcceptsReturn = true;
            this.txtDestinoConsulta.Location = new System.Drawing.Point(231, 215);
            this.txtDestinoConsulta.Name = "txtDestinoConsulta";
            this.txtDestinoConsulta.Size = new System.Drawing.Size(311, 26);
            this.txtDestinoConsulta.TabIndex = 16;
            // 
            // lblDestinoConsulta
            // 
            this.lblDestinoConsulta.AutoSize = true;
            this.lblDestinoConsulta.Location = new System.Drawing.Point(93, 221);
            this.lblDestinoConsulta.Name = "lblDestinoConsulta";
            this.lblDestinoConsulta.Size = new System.Drawing.Size(68, 20);
            this.lblDestinoConsulta.TabIndex = 15;
            this.lblDestinoConsulta.Text = "Destino:";
            // 
            // btnDepartamentoMunicipio
            // 
            this.btnDepartamentoMunicipio.Location = new System.Drawing.Point(569, 143);
            this.btnDepartamentoMunicipio.Name = "btnDepartamentoMunicipio";
            this.btnDepartamentoMunicipio.Size = new System.Drawing.Size(215, 38);
            this.btnDepartamentoMunicipio.TabIndex = 17;
            this.btnDepartamentoMunicipio.Text = "Departamento a Municipio";
            this.btnDepartamentoMunicipio.UseVisualStyleBackColor = true;
            this.btnDepartamentoMunicipio.Click += new System.EventHandler(this.btnDepartamentoMunicipio_Click);
            // 
            // btnCaminoDepartamento
            // 
            this.btnCaminoDepartamento.Location = new System.Drawing.Point(569, 203);
            this.btnCaminoDepartamento.Name = "btnCaminoDepartamento";
            this.btnCaminoDepartamento.Size = new System.Drawing.Size(215, 38);
            this.btnCaminoDepartamento.TabIndex = 18;
            this.btnCaminoDepartamento.Text = "Camino en Árbol";
            this.btnCaminoDepartamento.UseVisualStyleBackColor = true;
            this.btnCaminoDepartamento.Click += new System.EventHandler(this.btnCaminoDepartamento_Click);
            // 
            // txtResultadoConsultas
            // 
            this.txtResultadoConsultas.AcceptsReturn = true;
            this.txtResultadoConsultas.Location = new System.Drawing.Point(231, 271);
            this.txtResultadoConsultas.Multiline = true;
            this.txtResultadoConsultas.Name = "txtResultadoConsultas";
            this.txtResultadoConsultas.ReadOnly = true;
            this.txtResultadoConsultas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoConsultas.Size = new System.Drawing.Size(311, 152);
            this.txtResultadoConsultas.TabIndex = 19;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(16, 429);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 62;
            this.dgvConsultas.RowTemplate.Height = 28;
            this.dgvConsultas.Size = new System.Drawing.Size(883, 268);
            this.dgvConsultas.TabIndex = 20;
            // 
            // btnLimpiarConsultas
            // 
            this.btnLimpiarConsultas.Location = new System.Drawing.Point(817, 29);
            this.btnLimpiarConsultas.Name = "btnLimpiarConsultas";
            this.btnLimpiarConsultas.Size = new System.Drawing.Size(82, 212);
            this.btnLimpiarConsultas.TabIndex = 21;
            this.btnLimpiarConsultas.Text = "Limpiar";
            this.btnLimpiarConsultas.UseVisualStyleBackColor = true;
            this.btnLimpiarConsultas.Click += new System.EventHandler(this.btnLimpiarConsultas_Click);
            // 
            // btnConexiones
            // 
            this.btnConexiones.Location = new System.Drawing.Point(569, 354);
            this.btnConexiones.Name = "btnConexiones";
            this.btnConexiones.Size = new System.Drawing.Size(215, 38);
            this.btnConexiones.TabIndex = 22;
            this.btnConexiones.Text = "Ver conexiones";
            this.btnConexiones.UseVisualStyleBackColor = true;
            this.btnConexiones.Click += new System.EventHandler(this.btnConexiones_Click_1);
            // 
            // btnDistanciaDepartamentos
            // 
            this.btnDistanciaDepartamentos.Location = new System.Drawing.Point(569, 298);
            this.btnDistanciaDepartamentos.Name = "btnDistanciaDepartamentos";
            this.btnDistanciaDepartamentos.Size = new System.Drawing.Size(215, 38);
            this.btnDistanciaDepartamentos.TabIndex = 23;
            this.btnDistanciaDepartamentos.Text = "Distancia entre puntos";
            this.btnDistanciaDepartamentos.UseVisualStyleBackColor = true;
            this.btnDistanciaDepartamentos.Click += new System.EventHandler(this.btnDistanciaDepartamentos_Click_1);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 965);
            this.Controls.Add(this.lblTituloRutas);
            this.Controls.Add(this.gbDatosConsulta);
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.gbDatosConsulta.ResumeLayout(false);
            this.gbDatosConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosConsulta;
        private System.Windows.Forms.TextBox txtMunicipioConsulta;
        private System.Windows.Forms.Label lblMunicipioConsulta;
        private System.Windows.Forms.Button btnCapitalMunicipio;
        private System.Windows.Forms.Button btnCapitalDepartamento;
        private System.Windows.Forms.TextBox txtDepartamentoConsulta;
        private System.Windows.Forms.Label lblDepartamentoConsulta;
        private System.Windows.Forms.Label lblTituloRutas;
        private System.Windows.Forms.TextBox txtDestinoConsulta;
        private System.Windows.Forms.Label lblDestinoConsulta;
        private System.Windows.Forms.TextBox txtOrigenConsulta;
        private System.Windows.Forms.Label lblOrigenConsulta;
        private System.Windows.Forms.TextBox txtResultadoConsultas;
        private System.Windows.Forms.Button btnCaminoDepartamento;
        private System.Windows.Forms.Button btnDepartamentoMunicipio;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnLimpiarConsultas;
        private System.Windows.Forms.Button btnDistanciaDepartamentos;
        private System.Windows.Forms.Button btnConexiones;
    }
}