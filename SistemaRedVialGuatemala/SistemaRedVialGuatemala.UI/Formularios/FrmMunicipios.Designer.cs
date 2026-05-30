namespace SistemaRedVialGuatemala.UI.Formularios
{
    partial class FrmMunicipios
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
            this.lblTituloMunicipios = new System.Windows.Forms.Label();
            this.lblDepartamentoMunicipio = new System.Windows.Forms.Label();
            this.gbBuscarMunicipio = new System.Windows.Forms.GroupBox();
            this.btnBuscarMunicipio = new System.Windows.Forms.Button();
            this.txtBuscarMunicipio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartamentoMunicipio = new System.Windows.Forms.TextBox();
            this.txtResultadoMunicipios = new System.Windows.Forms.TextBox();
            this.gbMunicipiosDepartamento = new System.Windows.Forms.GroupBox();
            this.btnMostrarMunicipios = new System.Windows.Forms.Button();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.btnLimpiarMunicipio = new System.Windows.Forms.Button();
            this.gbBuscarMunicipio.SuspendLayout();
            this.gbMunicipiosDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMunicipios
            // 
            this.lblTituloMunicipios.AutoSize = true;
            this.lblTituloMunicipios.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMunicipios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloMunicipios.Location = new System.Drawing.Point(374, 151);
            this.lblTituloMunicipios.Name = "lblTituloMunicipios";
            this.lblTituloMunicipios.Size = new System.Drawing.Size(354, 45);
            this.lblTituloMunicipios.TabIndex = 1;
            this.lblTituloMunicipios.Text = "Gestión de Municipios";
            // 
            // lblDepartamentoMunicipio
            // 
            this.lblDepartamentoMunicipio.AutoSize = true;
            this.lblDepartamentoMunicipio.Location = new System.Drawing.Point(11, 50);
            this.lblDepartamentoMunicipio.Name = "lblDepartamentoMunicipio";
            this.lblDepartamentoMunicipio.Size = new System.Drawing.Size(198, 20);
            this.lblDepartamentoMunicipio.TabIndex = 2;
            this.lblDepartamentoMunicipio.Text = "Nombre del departamento:";
            this.lblDepartamentoMunicipio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbBuscarMunicipio
            // 
            this.gbBuscarMunicipio.Controls.Add(this.btnLimpiarMunicipio);
            this.gbBuscarMunicipio.Controls.Add(this.btnBuscarMunicipio);
            this.gbBuscarMunicipio.Controls.Add(this.txtResultadoMunicipios);
            this.gbBuscarMunicipio.Controls.Add(this.txtBuscarMunicipio);
            this.gbBuscarMunicipio.Controls.Add(this.label1);
            this.gbBuscarMunicipio.Location = new System.Drawing.Point(41, 258);
            this.gbBuscarMunicipio.Name = "gbBuscarMunicipio";
            this.gbBuscarMunicipio.Size = new System.Drawing.Size(908, 329);
            this.gbBuscarMunicipio.TabIndex = 3;
            this.gbBuscarMunicipio.TabStop = false;
            this.gbBuscarMunicipio.Text = "Buscar municipio";
            // 
            // btnBuscarMunicipio
            // 
            this.btnBuscarMunicipio.Location = new System.Drawing.Point(574, 74);
            this.btnBuscarMunicipio.Name = "btnBuscarMunicipio";
            this.btnBuscarMunicipio.Size = new System.Drawing.Size(215, 46);
            this.btnBuscarMunicipio.TabIndex = 9;
            this.btnBuscarMunicipio.Text = "Buscar municipio";
            this.btnBuscarMunicipio.UseVisualStyleBackColor = true;
            this.btnBuscarMunicipio.Click += new System.EventHandler(this.btnBuscarMunicipio_Click);
            // 
            // txtBuscarMunicipio
            // 
            this.txtBuscarMunicipio.Location = new System.Drawing.Point(236, 87);
            this.txtBuscarMunicipio.Name = "txtBuscarMunicipio";
            this.txtBuscarMunicipio.Size = new System.Drawing.Size(311, 26);
            this.txtBuscarMunicipio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del municipio:";
            // 
            // txtDepartamentoMunicipio
            // 
            this.txtDepartamentoMunicipio.Location = new System.Drawing.Point(241, 50);
            this.txtDepartamentoMunicipio.Name = "txtDepartamentoMunicipio";
            this.txtDepartamentoMunicipio.Size = new System.Drawing.Size(311, 26);
            this.txtDepartamentoMunicipio.TabIndex = 6;
            // 
            // txtResultadoMunicipios
            // 
            this.txtResultadoMunicipios.Location = new System.Drawing.Point(236, 149);
            this.txtResultadoMunicipios.Multiline = true;
            this.txtResultadoMunicipios.Name = "txtResultadoMunicipios";
            this.txtResultadoMunicipios.ReadOnly = true;
            this.txtResultadoMunicipios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoMunicipios.Size = new System.Drawing.Size(311, 159);
            this.txtResultadoMunicipios.TabIndex = 7;
            this.txtResultadoMunicipios.TextChanged += new System.EventHandler(this.txtResultadoMunicipios_TextChanged);
            // 
            // gbMunicipiosDepartamento
            // 
            this.gbMunicipiosDepartamento.Controls.Add(this.dgvMunicipios);
            this.gbMunicipiosDepartamento.Controls.Add(this.btnMostrarMunicipios);
            this.gbMunicipiosDepartamento.Controls.Add(this.lblDepartamentoMunicipio);
            this.gbMunicipiosDepartamento.Controls.Add(this.txtDepartamentoMunicipio);
            this.gbMunicipiosDepartamento.Location = new System.Drawing.Point(41, 629);
            this.gbMunicipiosDepartamento.Name = "gbMunicipiosDepartamento";
            this.gbMunicipiosDepartamento.Size = new System.Drawing.Size(908, 358);
            this.gbMunicipiosDepartamento.TabIndex = 8;
            this.gbMunicipiosDepartamento.TabStop = false;
            this.gbMunicipiosDepartamento.Text = "Municipios por departamento";
            // 
            // btnMostrarMunicipios
            // 
            this.btnMostrarMunicipios.Location = new System.Drawing.Point(579, 40);
            this.btnMostrarMunicipios.Name = "btnMostrarMunicipios";
            this.btnMostrarMunicipios.Size = new System.Drawing.Size(215, 46);
            this.btnMostrarMunicipios.TabIndex = 10;
            this.btnMostrarMunicipios.Text = "Mostrar municipios";
            this.btnMostrarMunicipios.UseVisualStyleBackColor = true;
            this.btnMostrarMunicipios.Click += new System.EventHandler(this.btnMostrarMunicipios_Click);
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.AllowUserToAddRows = false;
            this.dgvMunicipios.AllowUserToDeleteRows = false;
            this.dgvMunicipios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Location = new System.Drawing.Point(47, 113);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.ReadOnly = true;
            this.dgvMunicipios.RowHeadersVisible = false;
            this.dgvMunicipios.RowHeadersWidth = 62;
            this.dgvMunicipios.RowTemplate.Height = 28;
            this.dgvMunicipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMunicipios.Size = new System.Drawing.Size(828, 229);
            this.dgvMunicipios.TabIndex = 11;
            // 
            // btnLimpiarMunicipio
            // 
            this.btnLimpiarMunicipio.Location = new System.Drawing.Point(574, 193);
            this.btnLimpiarMunicipio.Name = "btnLimpiarMunicipio";
            this.btnLimpiarMunicipio.Size = new System.Drawing.Size(215, 46);
            this.btnLimpiarMunicipio.TabIndex = 10;
            this.btnLimpiarMunicipio.Text = "Limpiar";
            this.btnLimpiarMunicipio.UseVisualStyleBackColor = true;
            this.btnLimpiarMunicipio.Click += new System.EventHandler(this.btnLimpiarMunicipio_Click);
            // 
            // FrmMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 1026);
            this.Controls.Add(this.gbMunicipiosDepartamento);
            this.Controls.Add(this.gbBuscarMunicipio);
            this.Controls.Add(this.lblTituloMunicipios);
            this.Name = "FrmMunicipios";
            this.Text = "FrmMunicipios";
            this.Load += new System.EventHandler(this.FrmMunicipios_Load);
            this.gbBuscarMunicipio.ResumeLayout(false);
            this.gbBuscarMunicipio.PerformLayout();
            this.gbMunicipiosDepartamento.ResumeLayout(false);
            this.gbMunicipiosDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMunicipios;
        private System.Windows.Forms.Label lblDepartamentoMunicipio;
        private System.Windows.Forms.GroupBox gbBuscarMunicipio;
        private System.Windows.Forms.Button btnBuscarMunicipio;
        private System.Windows.Forms.TextBox txtBuscarMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartamentoMunicipio;
        private System.Windows.Forms.TextBox txtResultadoMunicipios;
        private System.Windows.Forms.GroupBox gbMunicipiosDepartamento;
        private System.Windows.Forms.Button btnMostrarMunicipios;
        private System.Windows.Forms.DataGridView dgvMunicipios;
        private System.Windows.Forms.Button btnLimpiarMunicipio;
    }
}