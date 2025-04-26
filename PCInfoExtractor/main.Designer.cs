namespace PCInfoExtractor
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioAsignado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAbrirDirectorio = new System.Windows.Forms.Button();
            this.chckboxExtraerInfoYGuardar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxFormatoSalida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreSalida = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtDirectorioSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnExtraerInfo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboxTipoDeEquipo = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(400, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion a extraer";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 79);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUbicacion);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(9, 19);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(172, 20);
            this.txtUbicacion.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUsuarioAsignado);
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario asignado";
            // 
            // txtUsuarioAsignado
            // 
            this.txtUsuarioAsignado.Location = new System.Drawing.Point(6, 19);
            this.txtUsuarioAsignado.Name = "txtUsuarioAsignado";
            this.txtUsuarioAsignado.Size = new System.Drawing.Size(175, 20);
            this.txtUsuarioAsignado.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAbrirDirectorio);
            this.groupBox4.Controls.Add(this.chckboxExtraerInfoYGuardar);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cboxFormatoSalida);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtNombreSalida);
            this.groupBox4.Controls.Add(this.btnExaminar);
            this.groupBox4.Controls.Add(this.txtDirectorioSalida);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuracion de exportacion";
            // 
            // btnAbrirDirectorio
            // 
            this.btnAbrirDirectorio.Location = new System.Drawing.Point(347, 32);
            this.btnAbrirDirectorio.Name = "btnAbrirDirectorio";
            this.btnAbrirDirectorio.Size = new System.Drawing.Size(52, 23);
            this.btnAbrirDirectorio.TabIndex = 10;
            this.btnAbrirDirectorio.Text = "Abrir";
            this.btnAbrirDirectorio.UseVisualStyleBackColor = true;
            this.btnAbrirDirectorio.Click += new System.EventHandler(this.btnAbrirDirectorio_Click);
            // 
            // chckboxExtraerInfoYGuardar
            // 
            this.chckboxExtraerInfoYGuardar.AutoSize = true;
            this.chckboxExtraerInfoYGuardar.Location = new System.Drawing.Point(360, 12);
            this.chckboxExtraerInfoYGuardar.Name = "chckboxExtraerInfoYGuardar";
            this.chckboxExtraerInfoYGuardar.Size = new System.Drawing.Size(163, 17);
            this.chckboxExtraerInfoYGuardar.TabIndex = 9;
            this.chckboxExtraerInfoYGuardar.Text = "Extraer y guardar informacion";
            this.chckboxExtraerInfoYGuardar.UseVisualStyleBackColor = true;
            this.chckboxExtraerInfoYGuardar.CheckedChanged += new System.EventHandler(this.chckboxExtraerInfoYGuardar_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Formato";
            // 
            // cboxFormatoSalida
            // 
            this.cboxFormatoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFormatoSalida.FormattingEnabled = true;
            this.cboxFormatoSalida.Items.AddRange(new object[] {
            "JSON",
            "Texto"});
            this.cboxFormatoSalida.Location = new System.Drawing.Point(311, 71);
            this.cboxFormatoSalida.Name = "cboxFormatoSalida";
            this.cboxFormatoSalida.Size = new System.Drawing.Size(111, 21);
            this.cboxFormatoSalida.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de salida";
            // 
            // txtNombreSalida
            // 
            this.txtNombreSalida.Location = new System.Drawing.Point(6, 71);
            this.txtNombreSalida.Name = "txtNombreSalida";
            this.txtNombreSalida.Size = new System.Drawing.Size(299, 20);
            this.txtNombreSalida.TabIndex = 4;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(311, 32);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(34, 23);
            this.btnExaminar.TabIndex = 3;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDirectorioSalida
            // 
            this.txtDirectorioSalida.Location = new System.Drawing.Point(9, 32);
            this.txtDirectorioSalida.Name = "txtDirectorioSalida";
            this.txtDirectorioSalida.ReadOnly = true;
            this.txtDirectorioSalida.Size = new System.Drawing.Size(296, 20);
            this.txtDirectorioSalida.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directorio de Salida";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtIdentificador);
            this.groupBox5.Location = new System.Drawing.Point(206, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 49);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Identificador";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(6, 19);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(176, 20);
            this.txtIdentificador.TabIndex = 0;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // btnExtraerInfo
            // 
            this.btnExtraerInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExtraerInfo.Location = new System.Drawing.Point(417, 288);
            this.btnExtraerInfo.Name = "btnExtraerInfo";
            this.btnExtraerInfo.Size = new System.Drawing.Size(124, 41);
            this.btnExtraerInfo.TabIndex = 6;
            this.btnExtraerInfo.Text = "EXTRAER INFORMACION";
            this.btnExtraerInfo.UseVisualStyleBackColor = true;
            this.btnExtraerInfo.Click += new System.EventHandler(this.btnExtraerInfo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.ForeColor = System.Drawing.Color.Green;
            this.richTextBox1.Location = new System.Drawing.Point(12, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(399, 86);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboxTipoDeEquipo);
            this.groupBox6.Location = new System.Drawing.Point(206, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 49);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Equipo";
            // 
            // cboxTipoDeEquipo
            // 
            this.cboxTipoDeEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoDeEquipo.FormattingEnabled = true;
            this.cboxTipoDeEquipo.Items.AddRange(new object[] {
            "PC",
            "LAPTOP"});
            this.cboxTipoDeEquipo.Location = new System.Drawing.Point(6, 18);
            this.cboxTipoDeEquipo.Name = "cboxTipoDeEquipo";
            this.cboxTipoDeEquipo.Size = new System.Drawing.Size(176, 21);
            this.cboxTipoDeEquipo.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 335);
            this.progressBar1.Maximum = 9;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(529, 16);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "** NOTA ** Los datos se obtienen de la BIOS. Es posible que algunos datos no sean" +
    " correctos como el modelo";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // main
            // 
            this.AcceptButton = this.btnExtraerInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExtraerInfo;
            this.ClientSize = new System.Drawing.Size(552, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnExtraerInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "PC Info Extractor Tool - PCIET";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUsuarioAsignado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDirectorioSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxFormatoSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreSalida;
        private System.Windows.Forms.Button btnExtraerInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cboxTipoDeEquipo;
        private System.Windows.Forms.CheckBox chckboxExtraerInfoYGuardar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbrirDirectorio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

