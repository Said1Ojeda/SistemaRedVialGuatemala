namespace SistemaRedVialGuatemala.UI.Formularios
{
    partial class FrmRutas
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
            this.gbBuscarRuta = new System.Windows.Forms.GroupBox();
            this.btnLimpiarRuta = new System.Windows.Forms.Button();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.txtOrigenRuta = new System.Windows.Forms.TextBox();
            this.lblOrigenRuta = new System.Windows.Forms.Label();
            this.lblTituloRutas = new System.Windows.Forms.Label();
            this.lblDestinoRuta = new System.Windows.Forms.Label();
            this.txtDestinoRuta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResultadoRutas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarConexiones = new System.Windows.Forms.Button();
            this.txtOrigenConexiones = new System.Windows.Forms.TextBox();
            this.lblOrigenConexiones = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.gbBuscarRuta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarRuta
            // 
            this.gbBuscarRuta.Controls.Add(this.txtDestinoRuta);
            this.gbBuscarRuta.Controls.Add(this.lblDestinoRuta);
            this.gbBuscarRuta.Controls.Add(this.btnLimpiarRuta);
            this.gbBuscarRuta.Controls.Add(this.btnBuscarRuta);
            this.gbBuscarRuta.Controls.Add(this.txtOrigenRuta);
            this.gbBuscarRuta.Controls.Add(this.lblOrigenRuta);
            this.gbBuscarRuta.Location = new System.Drawing.Point(39, 210);
            this.gbBuscarRuta.Name = "gbBuscarRuta";
            this.gbBuscarRuta.Size = new System.Drawing.Size(917, 146);
            this.gbBuscarRuta.TabIndex = 4;
            this.gbBuscarRuta.TabStop = false;
            this.gbBuscarRuta.Text = "Buscar conexión directa";
            // 
            // btnLimpiarRuta
            // 
            this.btnLimpiarRuta.Location = new System.Drawing.Point(569, 90);
            this.btnLimpiarRuta.Name = "btnLimpiarRuta";
            this.btnLimpiarRuta.Size = new System.Drawing.Size(215, 38);
            this.btnLimpiarRuta.TabIndex = 10;
            this.btnLimpiarRuta.Text = "Limpiar";
            this.btnLimpiarRuta.UseVisualStyleBackColor = true;
            this.btnLimpiarRuta.Click += new System.EventHandler(this.btnLimpiarRuta_Click);
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(569, 29);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(215, 38);
            this.btnBuscarRuta.TabIndex = 9;
            this.btnBuscarRuta.Text = "Buscar ruta";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // txtOrigenRuta
            // 
            this.txtOrigenRuta.AcceptsReturn = true;
            this.txtOrigenRuta.Location = new System.Drawing.Point(231, 42);
            this.txtOrigenRuta.Name = "txtOrigenRuta";
            this.txtOrigenRuta.Size = new System.Drawing.Size(311, 26);
            this.txtOrigenRuta.TabIndex = 8;
            // 
            // lblOrigenRuta
            // 
            this.lblOrigenRuta.AutoSize = true;
            this.lblOrigenRuta.Location = new System.Drawing.Point(120, 42);
            this.lblOrigenRuta.Name = "lblOrigenRuta";
            this.lblOrigenRuta.Size = new System.Drawing.Size(60, 20);
            this.lblOrigenRuta.TabIndex = 4;
            this.lblOrigenRuta.Text = "Origen:";
            // 
            // lblTituloRutas
            // 
            this.lblTituloRutas.AutoSize = true;
            this.lblTituloRutas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloRutas.Location = new System.Drawing.Point(388, 136);
            this.lblTituloRutas.Name = "lblTituloRutas";
            this.lblTituloRutas.Size = new System.Drawing.Size(272, 45);
            this.lblTituloRutas.TabIndex = 5;
            this.lblTituloRutas.Text = "Gestión de Rutas";
            // 
            // lblDestinoRuta
            // 
            this.lblDestinoRuta.AutoSize = true;
            this.lblDestinoRuta.Location = new System.Drawing.Point(120, 99);
            this.lblDestinoRuta.Name = "lblDestinoRuta";
            this.lblDestinoRuta.Size = new System.Drawing.Size(68, 20);
            this.lblDestinoRuta.TabIndex = 11;
            this.lblDestinoRuta.Text = "Destino:";
            // 
            // txtDestinoRuta
            // 
            this.txtDestinoRuta.AcceptsReturn = true;
            this.txtDestinoRuta.Location = new System.Drawing.Point(231, 93);
            this.txtDestinoRuta.Name = "txtDestinoRuta";
            this.txtDestinoRuta.Size = new System.Drawing.Size(311, 26);
            this.txtDestinoRuta.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRutas);
            this.groupBox1.Controls.Add(this.txtResultadoRutas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnMostrarConexiones);
            this.groupBox1.Controls.Add(this.txtOrigenConexiones);
            this.groupBox1.Controls.Add(this.lblOrigenConexiones);
            this.groupBox1.Location = new System.Drawing.Point(39, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 613);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexiones por origen";
            // 
            // txtResultadoRutas
            // 
            this.txtResultadoRutas.AcceptsReturn = true;
            this.txtResultadoRutas.Location = new System.Drawing.Point(247, 145);
            this.txtResultadoRutas.Multiline = true;
            this.txtResultadoRutas.Name = "txtResultadoRutas";
            this.txtResultadoRutas.ReadOnly = true;
            this.txtResultadoRutas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoRutas.Size = new System.Drawing.Size(311, 177);
            this.txtResultadoRutas.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarConexiones
            // 
            this.btnMostrarConexiones.Location = new System.Drawing.Point(574, 80);
            this.btnMostrarConexiones.Name = "btnMostrarConexiones";
            this.btnMostrarConexiones.Size = new System.Drawing.Size(215, 38);
            this.btnMostrarConexiones.TabIndex = 9;
            this.btnMostrarConexiones.Text = "Mostrar conexiones";
            this.btnMostrarConexiones.UseVisualStyleBackColor = true;
            this.btnMostrarConexiones.Click += new System.EventHandler(this.btnMostrarConexiones_Click);
            // 
            // txtOrigenConexiones
            // 
            this.txtOrigenConexiones.AcceptsReturn = true;
            this.txtOrigenConexiones.Location = new System.Drawing.Point(247, 86);
            this.txtOrigenConexiones.Name = "txtOrigenConexiones";
            this.txtOrigenConexiones.Size = new System.Drawing.Size(311, 26);
            this.txtOrigenConexiones.TabIndex = 8;
            // 
            // lblOrigenConexiones
            // 
            this.lblOrigenConexiones.AutoSize = true;
            this.lblOrigenConexiones.Location = new System.Drawing.Point(125, 86);
            this.lblOrigenConexiones.Name = "lblOrigenConexiones";
            this.lblOrigenConexiones.Size = new System.Drawing.Size(60, 20);
            this.lblOrigenConexiones.TabIndex = 4;
            this.lblOrigenConexiones.Text = "Origen:";
            // 
            // dgvRutas
            // 
            this.dgvRutas.AllowUserToAddRows = false;
            this.dgvRutas.AllowUserToDeleteRows = false;
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(16, 339);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.RowHeadersWidth = 62;
            this.dgvRutas.RowTemplate.Height = 28;
            this.dgvRutas.Size = new System.Drawing.Size(883, 268);
            this.dgvRutas.TabIndex = 13;
            // 
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 1099);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTituloRutas);
            this.Controls.Add(this.gbBuscarRuta);
            this.Name = "FrmRutas";
            this.Text = "FrmRutas";
            this.Load += new System.EventHandler(this.FrmRutas_Load);
            this.gbBuscarRuta.ResumeLayout(false);
            this.gbBuscarRuta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarRuta;
        private System.Windows.Forms.Button btnLimpiarRuta;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.TextBox txtOrigenRuta;
        private System.Windows.Forms.Label lblOrigenRuta;
        private System.Windows.Forms.Label lblTituloRutas;
        private System.Windows.Forms.TextBox txtDestinoRuta;
        private System.Windows.Forms.Label lblDestinoRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResultadoRutas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarConexiones;
        private System.Windows.Forms.TextBox txtOrigenConexiones;
        private System.Windows.Forms.Label lblOrigenConexiones;
        private System.Windows.Forms.DataGridView dgvRutas;
    }
}