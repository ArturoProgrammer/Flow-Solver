namespace RIT_Solver
{
    partial class exViewSyncModel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exViewSyncModel));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreClave = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.numericSSD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericHDD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxAlmacenamientoTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericRam = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LABELFRECUENCIA = new System.Windows.Forms.Label();
            this.txtFrecuenciaProcesador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.chckboxUnidadOptica = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPathImagen = new System.Windows.Forms.TextBox();
            this.btnExaminarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nombre Clave";
            // 
            // txtNombreClave
            // 
            this.txtNombreClave.Location = new System.Drawing.Point(20, 31);
            this.txtNombreClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreClave.Name = "txtNombreClave";
            this.txtNombreClave.Size = new System.Drawing.Size(259, 22);
            this.txtNombreClave.TabIndex = 1;
            this.txtNombreClave.TextChanged += new System.EventHandler(this.txtNombreClave_TextChanged);
            this.txtNombreClave.Enter += new System.EventHandler(this.txtNombreClave_Enter);
            this.txtNombreClave.Leave += new System.EventHandler(this.txtNombreClave_Leave);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(20, 79);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(259, 22);
            this.txtNombreComercial.TabIndex = 3;
            this.txtNombreComercial.TextChanged += new System.EventHandler(this.txtNombreComercial_TextChanged);
            this.txtNombreComercial.Enter += new System.EventHandler(this.txtNombreComercial_Enter);
            this.txtNombreComercial.Leave += new System.EventHandler(this.txtNombreComercial_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Nombre Comercial";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(20, 127);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(259, 22);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "* Nombre Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "* Tipo";
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "LAPTOP",
            "PC"});
            this.cboxTipo.Location = new System.Drawing.Point(20, 175);
            this.cboxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(160, 24);
            this.cboxTipo.TabIndex = 7;
            this.cboxTipo.SelectedIndexChanged += new System.EventHandler(this.cboxTipo_SelectedIndexChanged);
            this.cboxTipo.Enter += new System.EventHandler(this.cboxTipo_Enter);
            this.cboxTipo.Leave += new System.EventHandler(this.cboxTipo_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(538, 209);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(538, 244);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "GHz";
            // 
            // numericSSD
            // 
            this.numericSSD.Enabled = false;
            this.numericSSD.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericSSD.Location = new System.Drawing.Point(426, 177);
            this.numericSSD.Margin = new System.Windows.Forms.Padding(4);
            this.numericSSD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericSSD.Name = "numericSSD";
            this.numericSSD.Size = new System.Drawing.Size(95, 22);
            this.numericSSD.TabIndex = 24;
            this.numericSSD.ValueChanged += new System.EventHandler(this.numericSSD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "* SSD (GB)";
            // 
            // numericHDD
            // 
            this.numericHDD.Enabled = false;
            this.numericHDD.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericHDD.Location = new System.Drawing.Point(306, 177);
            this.numericHDD.Margin = new System.Windows.Forms.Padding(4);
            this.numericHDD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericHDD.Name = "numericHDD";
            this.numericHDD.Size = new System.Drawing.Size(95, 22);
            this.numericHDD.TabIndex = 22;
            this.numericHDD.ValueChanged += new System.EventHandler(this.numericHDD_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "* HDD (GB)";
            // 
            // cboxAlmacenamientoTipo
            // 
            this.cboxAlmacenamientoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAlmacenamientoTipo.FormattingEnabled = true;
            this.cboxAlmacenamientoTipo.Items.AddRange(new object[] {
            "HDD",
            "SSD",
            "Ambos"});
            this.cboxAlmacenamientoTipo.Location = new System.Drawing.Point(306, 127);
            this.cboxAlmacenamientoTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAlmacenamientoTipo.Name = "cboxAlmacenamientoTipo";
            this.cboxAlmacenamientoTipo.Size = new System.Drawing.Size(213, 24);
            this.cboxAlmacenamientoTipo.TabIndex = 20;
            this.cboxAlmacenamientoTipo.SelectedIndexChanged += new System.EventHandler(this.cboxAlmacenamientoTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "* Almacenamiento";
            // 
            // numericRam
            // 
            this.numericRam.Location = new System.Drawing.Point(306, 79);
            this.numericRam.Margin = new System.Windows.Forms.Padding(4);
            this.numericRam.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRam.Name = "numericRam";
            this.numericRam.Size = new System.Drawing.Size(95, 22);
            this.numericRam.TabIndex = 18;
            this.numericRam.ValueChanged += new System.EventHandler(this.numericRam_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "* Memoria RAM (GB)";
            // 
            // LABELFRECUENCIA
            // 
            this.LABELFRECUENCIA.AutoSize = true;
            this.LABELFRECUENCIA.Location = new System.Drawing.Point(523, 12);
            this.LABELFRECUENCIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABELFRECUENCIA.Name = "LABELFRECUENCIA";
            this.LABELFRECUENCIA.Size = new System.Drawing.Size(82, 16);
            this.LABELFRECUENCIA.TabIndex = 16;
            this.LABELFRECUENCIA.Text = "* Frecuencia";
            // 
            // txtFrecuenciaProcesador
            // 
            this.txtFrecuenciaProcesador.Location = new System.Drawing.Point(526, 31);
            this.txtFrecuenciaProcesador.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrecuenciaProcesador.Name = "txtFrecuenciaProcesador";
            this.txtFrecuenciaProcesador.Size = new System.Drawing.Size(70, 22);
            this.txtFrecuenciaProcesador.TabIndex = 14;
            this.txtFrecuenciaProcesador.TextChanged += new System.EventHandler(this.txtFrecuenciaProcesador_TextChanged);
            this.txtFrecuenciaProcesador.Enter += new System.EventHandler(this.txtFrecuenciaProcesador_Enter);
            this.txtFrecuenciaProcesador.Leave += new System.EventHandler(this.txtFrecuenciaProcesador_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "* Procesador";
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(306, 31);
            this.txtProcesador.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(213, 22);
            this.txtProcesador.TabIndex = 13;
            this.txtProcesador.TextChanged += new System.EventHandler(this.txtProcesador_TextChanged);
            this.txtProcesador.Enter += new System.EventHandler(this.txtProcesador_Enter);
            this.txtProcesador.Leave += new System.EventHandler(this.txtProcesador_Leave);
            // 
            // chckboxUnidadOptica
            // 
            this.chckboxUnidadOptica.AutoSize = true;
            this.chckboxUnidadOptica.Location = new System.Drawing.Point(444, 81);
            this.chckboxUnidadOptica.Margin = new System.Windows.Forms.Padding(4);
            this.chckboxUnidadOptica.Name = "chckboxUnidadOptica";
            this.chckboxUnidadOptica.Size = new System.Drawing.Size(194, 20);
            this.chckboxUnidadOptica.TabIndex = 25;
            this.chckboxUnidadOptica.Text = "¿Cuenta con unidad optica?";
            this.chckboxUnidadOptica.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Imagen de perfil:";
            // 
            // txtPathImagen
            // 
            this.txtPathImagen.Location = new System.Drawing.Point(20, 224);
            this.txtPathImagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathImagen.Name = "txtPathImagen";
            this.txtPathImagen.ReadOnly = true;
            this.txtPathImagen.Size = new System.Drawing.Size(342, 22);
            this.txtPathImagen.TabIndex = 27;
            // 
            // btnExaminarFoto
            // 
            this.btnExaminarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnExaminarFoto.Image")));
            this.btnExaminarFoto.Location = new System.Drawing.Point(369, 222);
            this.btnExaminarFoto.Name = "btnExaminarFoto";
            this.btnExaminarFoto.Size = new System.Drawing.Size(40, 28);
            this.btnExaminarFoto.TabIndex = 28;
            this.btnExaminarFoto.UseVisualStyleBackColor = true;
            this.btnExaminarFoto.Click += new System.EventHandler(this.btnExaminarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // exViewSyncModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(665, 285);
            this.Controls.Add(this.btnExaminarFoto);
            this.Controls.Add(this.txtPathImagen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chckboxUnidadOptica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericSSD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericHDD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxAlmacenamientoTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericRam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LABELFRECUENCIA);
            this.Controls.Add(this.txtFrecuenciaProcesador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreClave);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "exViewSyncModel";
            this.Text = "exViewSyncModel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exViewSyncModel_FormClosing);
            this.Load += new System.EventHandler(this.exViewSyncModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreClave;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericSSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericHDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxAlmacenamientoTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericRam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LABELFRECUENCIA;
        private System.Windows.Forms.TextBox txtFrecuenciaProcesador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.CheckBox chckboxUnidadOptica;
        private System.Windows.Forms.TextBox txtPathImagen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExaminarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}