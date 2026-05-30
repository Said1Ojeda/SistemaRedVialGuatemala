namespace SistemaRedVialGuatemala.UI.Formularios
{
    partial class FrmDepartamentos
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
            this.lblTituloDepartamento = new System.Windows.Forms.Label();
            this.txtBuscarDepartamento = new System.Windows.Forms.TextBox();
            this.btnBuscarDepartamento = new System.Windows.Forms.Button();
            this.btnDistanciaCapital = new System.Windows.Forms.Button();
            this.lblBuscarDepartamento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbRecorridosArbol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultadoDepartamentos = new System.Windows.Forms.TextBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbRecorridosArbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloDepartamento
            // 
            this.lblTituloDepartamento.AutoSize = true;
            this.lblTituloDepartamento.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloDepartamento.Location = new System.Drawing.Point(341, 140);
            this.lblTituloDepartamento.Name = "lblTituloDepartamento";
            this.lblTituloDepartamento.Size = new System.Drawing.Size(421, 45);
            this.lblTituloDepartamento.TabIndex = 1;
            this.lblTituloDepartamento.Text = "Gestión de Departamentos";
            this.lblTituloDepartamento.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscarDepartamento
            // 
            this.txtBuscarDepartamento.Location = new System.Drawing.Point(46, 71);
            this.txtBuscarDepartamento.Name = "txtBuscarDepartamento";
            this.txtBuscarDepartamento.Size = new System.Drawing.Size(367, 26);
            this.txtBuscarDepartamento.TabIndex = 2;
            // 
            // btnBuscarDepartamento
            // 
            this.btnBuscarDepartamento.Location = new System.Drawing.Point(579, 63);
            this.btnBuscarDepartamento.Name = "btnBuscarDepartamento";
            this.btnBuscarDepartamento.Size = new System.Drawing.Size(195, 34);
            this.btnBuscarDepartamento.TabIndex = 3;
            this.btnBuscarDepartamento.Text = "Buscar";
            this.btnBuscarDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamento.Click += new System.EventHandler(this.btnBuscarDepartamento_Click);
            // 
            // btnDistanciaCapital
            // 
            this.btnDistanciaCapital.Location = new System.Drawing.Point(579, 103);
            this.btnDistanciaCapital.Name = "btnDistanciaCapital";
            this.btnDistanciaCapital.Size = new System.Drawing.Size(195, 34);
            this.btnDistanciaCapital.TabIndex = 4;
            this.btnDistanciaCapital.Text = "Distancia desde Capital";
            this.btnDistanciaCapital.UseVisualStyleBackColor = true;
            this.btnDistanciaCapital.Click += new System.EventHandler(this.btnDistanciaCapital_Click);
            // 
            // lblBuscarDepartamento
            // 
            this.lblBuscarDepartamento.AutoSize = true;
            this.lblBuscarDepartamento.Location = new System.Drawing.Point(46, 48);
            this.lblBuscarDepartamento.Name = "lblBuscarDepartamento";
            this.lblBuscarDepartamento.Size = new System.Drawing.Size(194, 20);
            this.lblBuscarDepartamento.TabIndex = 5;
            this.lblBuscarDepartamento.Text = "Nombre del departamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBuscarDepartamento);
            this.groupBox1.Controls.Add(this.btnDistanciaCapital);
            this.groupBox1.Controls.Add(this.txtBuscarDepartamento);
            this.groupBox1.Controls.Add(this.btnBuscarDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(45, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar departamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbRecorridosArbol
            // 
            this.gbRecorridosArbol.Controls.Add(this.label2);
            this.gbRecorridosArbol.Controls.Add(this.txtResultadoDepartamentos);
            this.gbRecorridosArbol.Controls.Add(this.btnPostOrden);
            this.gbRecorridosArbol.Controls.Add(this.btnPreOrden);
            this.gbRecorridosArbol.Controls.Add(this.label1);
            this.gbRecorridosArbol.Controls.Add(this.btnInOrden);
            this.gbRecorridosArbol.Location = new System.Drawing.Point(45, 424);
            this.gbRecorridosArbol.Name = "gbRecorridosArbol";
            this.gbRecorridosArbol.Size = new System.Drawing.Size(929, 411);
            this.gbRecorridosArbol.TabIndex = 7;
            this.gbRecorridosArbol.TabStop = false;
            this.gbRecorridosArbol.Text = "Recorridos del árbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado:";
            // 
            // txtResultadoDepartamentos
            // 
            this.txtResultadoDepartamentos.Location = new System.Drawing.Point(468, 59);
            this.txtResultadoDepartamentos.Name = "txtResultadoDepartamentos";
            this.txtResultadoDepartamentos.Size = new System.Drawing.Size(342, 26);
            this.txtResultadoDepartamentos.TabIndex = 8;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(46, 287);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(99, 50);
            this.btnPostOrden.TabIndex = 7;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(46, 209);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(99, 50);
            this.btnPreOrden.TabIndex = 6;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipos de Recorridos:";
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(46, 128);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(99, 50);
            this.btnInOrden.TabIndex = 3;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 1046);
            this.Controls.Add(this.gbRecorridosArbol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTituloDepartamento);
            this.Name = "FrmDepartamentos";
            this.Text = "lblTituloDepartamentos";
            this.Load += new System.EventHandler(this.lblTituloDepartamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRecorridosArbol.ResumeLayout(false);
            this.gbRecorridosArbol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDepartamento;
        private System.Windows.Forms.TextBox txtBuscarDepartamento;
        private System.Windows.Forms.Button btnBuscarDepartamento;
        private System.Windows.Forms.Button btnDistanciaCapital;
        private System.Windows.Forms.Label lblBuscarDepartamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbRecorridosArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.TextBox txtResultadoDepartamentos;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Label label2;
    }
}