namespace RIT_Solver
{
    partial class respaldo_de_programa
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
            System.Windows.Forms.Label lblTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(respaldo_de_programa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SeleccionDeDatos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Config2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Config1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescripcionInventarios = new System.Windows.Forms.Label();
            this.checkedListBox_Inventarios = new System.Windows.Forms.CheckedListBox();
            this.tabPage_Guardado = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chckBoxEncriptarRespaldo = new System.Windows.Forms.CheckBox();
            this.chckBoxEstablecerContraseña = new System.Windows.Forms.CheckBox();
            this.lblVersionMinimaCompatible = new System.Windows.Forms.Label();
            this.btnExportarBackup = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDirectorioDeSalida = new System.Windows.Forms.Button();
            this.txtDirectorioDeSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreArchivoBackUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_SeleccionDeDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Guardado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(136, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(346, 38);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Exportar configuracion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 315);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_SeleccionDeDatos);
            this.tabControl1.Controls.Add(this.tabPage_Guardado);
            this.tabControl1.ItemSize = new System.Drawing.Size(107, 22);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 1);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_SeleccionDeDatos
            // 
            this.tabPage_SeleccionDeDatos.AutoScroll = true;
            this.tabPage_SeleccionDeDatos.Controls.Add(this.label2);
            this.tabPage_SeleccionDeDatos.Controls.Add(this.groupBox2);
            this.tabPage_SeleccionDeDatos.Controls.Add(this.label1);
            this.tabPage_SeleccionDeDatos.Controls.Add(this.groupBox1);
            this.tabPage_SeleccionDeDatos.Location = new System.Drawing.Point(4, 26);
            this.tabPage_SeleccionDeDatos.Name = "tabPage_SeleccionDeDatos";
            this.tabPage_SeleccionDeDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SeleccionDeDatos.Size = new System.Drawing.Size(622, 259);
            this.tabPage_SeleccionDeDatos.TabIndex = 0;
            this.tabPage_SeleccionDeDatos.Text = "Seleccion de Datos";
            this.tabPage_SeleccionDeDatos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RIT Solver for IDC (c) Arturo Venegas IDC  2022";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox_Config2);
            this.groupBox2.Controls.Add(this.checkedListBox_Config1);
            this.groupBox2.Location = new System.Drawing.Point(9, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion del sistema";
            // 
            // checkedListBox_Config2
            // 
            this.checkedListBox_Config2.ColumnWidth = 250;
            this.checkedListBox_Config2.FormattingEnabled = true;
            this.checkedListBox_Config2.Items.AddRange(new object[] {
            "Guardar PDF de resguardo",
            "Abrir inventario siempre maximizado",
            "Contador de RIT actual",
            "Crear proyecto en blanco siempre al abrir",
            "Localidad default"});
            this.checkedListBox_Config2.Location = new System.Drawing.Point(239, 19);
            this.checkedListBox_Config2.MultiColumn = true;
            this.checkedListBox_Config2.Name = "checkedListBox_Config2";
            this.checkedListBox_Config2.Size = new System.Drawing.Size(227, 229);
            this.checkedListBox_Config2.TabIndex = 1;
            // 
            // checkedListBox_Config1
            // 
            this.checkedListBox_Config1.ColumnWidth = 250;
            this.checkedListBox_Config1.FormattingEnabled = true;
            this.checkedListBox_Config1.Items.AddRange(new object[] {
            "Email del IDC",
            "Password de red",
            "Nombre del IDC",
            "Localidad del IDC",
            "Proyecto del IDC",
            "Cliente",
            "Direccion de la localidad default",
            "Centro de servicios de localidad default",
            "Email de lider de soporte",
            "Nombre del lider de proyecto",
            "Usuario de Red del IDC",
            "Email de distribuidor de toner",
            "Tema actual seleccionado",
            "Detecion de actualizaciones automaticas",
            "Deteccion de actualizaciones BETA"});
            this.checkedListBox_Config1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox_Config1.MultiColumn = true;
            this.checkedListBox_Config1.Name = "checkedListBox_Config1";
            this.checkedListBox_Config1.Size = new System.Drawing.Size(227, 229);
            this.checkedListBox_Config1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona Los componentes que deseas guardar en el respaldo.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescripcionInventarios);
            this.groupBox1.Controls.Add(this.checkedListBox_Inventarios);
            this.groupBox1.Location = new System.Drawing.Point(9, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            // 
            // lblDescripcionInventarios
            // 
            this.lblDescripcionInventarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcionInventarios.Location = new System.Drawing.Point(287, 19);
            this.lblDescripcionInventarios.Name = "lblDescripcionInventarios";
            this.lblDescripcionInventarios.Size = new System.Drawing.Size(179, 109);
            this.lblDescripcionInventarios.TabIndex = 1;
            this.lblDescripcionInventarios.Text = "Descripcion del inventario seleccionado actualmente.";
            // 
            // checkedListBox_Inventarios
            // 
            this.checkedListBox_Inventarios.FormattingEnabled = true;
            this.checkedListBox_Inventarios.Items.AddRange(new object[] {
            "Equipos de computo",
            "Impresoras",
            "Toners",
            "Refacciones",
            "Direcciones de Correo",
            "Localidades guardadas",
            "Inventario de usuarios"});
            this.checkedListBox_Inventarios.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox_Inventarios.Name = "checkedListBox_Inventarios";
            this.checkedListBox_Inventarios.Size = new System.Drawing.Size(227, 109);
            this.checkedListBox_Inventarios.TabIndex = 0;
            this.checkedListBox_Inventarios.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Inventarios_SelectedIndexChanged);
            // 
            // tabPage_Guardado
            // 
            this.tabPage_Guardado.Controls.Add(this.groupBox4);
            this.tabPage_Guardado.Controls.Add(this.btnExportarBackup);
            this.tabPage_Guardado.Controls.Add(this.btnCancelar);
            this.tabPage_Guardado.Controls.Add(this.groupBox3);
            this.tabPage_Guardado.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Guardado.Name = "tabPage_Guardado";
            this.tabPage_Guardado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Guardado.Size = new System.Drawing.Size(622, 259);
            this.tabPage_Guardado.TabIndex = 1;
            this.tabPage_Guardado.Text = "Guardado";
            this.tabPage_Guardado.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chckBoxEncriptarRespaldo);
            this.groupBox4.Controls.Add(this.chckBoxEstablecerContraseña);
            this.groupBox4.Controls.Add(this.lblVersionMinimaCompatible);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(6, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 111);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Avanzado";
            // 
            // chckBoxEncriptarRespaldo
            // 
            this.chckBoxEncriptarRespaldo.AutoSize = true;
            this.chckBoxEncriptarRespaldo.Location = new System.Drawing.Point(6, 75);
            this.chckBoxEncriptarRespaldo.Name = "chckBoxEncriptarRespaldo";
            this.chckBoxEncriptarRespaldo.Size = new System.Drawing.Size(111, 17);
            this.chckBoxEncriptarRespaldo.TabIndex = 7;
            this.chckBoxEncriptarRespaldo.Text = "Encriptar respaldo";
            this.chckBoxEncriptarRespaldo.UseVisualStyleBackColor = true;
            // 
            // chckBoxEstablecerContraseña
            // 
            this.chckBoxEstablecerContraseña.AutoSize = true;
            this.chckBoxEstablecerContraseña.Location = new System.Drawing.Point(6, 52);
            this.chckBoxEstablecerContraseña.Name = "chckBoxEstablecerContraseña";
            this.chckBoxEstablecerContraseña.Size = new System.Drawing.Size(186, 17);
            this.chckBoxEstablecerContraseña.TabIndex = 8;
            this.chckBoxEstablecerContraseña.Text = "Establecer contraseña al respaldo";
            this.chckBoxEstablecerContraseña.UseVisualStyleBackColor = true;
            // 
            // lblVersionMinimaCompatible
            // 
            this.lblVersionMinimaCompatible.AutoSize = true;
            this.lblVersionMinimaCompatible.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersionMinimaCompatible.Location = new System.Drawing.Point(6, 30);
            this.lblVersionMinimaCompatible.Name = "lblVersionMinimaCompatible";
            this.lblVersionMinimaCompatible.Size = new System.Drawing.Size(316, 13);
            this.lblVersionMinimaCompatible.TabIndex = 7;
            this.lblVersionMinimaCompatible.Text = "Compatible para versiones: %SYS_MIN_VERSION% y posteriores";
            // 
            // btnExportarBackup
            // 
            this.btnExportarBackup.Image = global::RIT_Solver.Properties.Resources.exportar_16;
            this.btnExportarBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarBackup.Location = new System.Drawing.Point(377, 225);
            this.btnExportarBackup.Name = "btnExportarBackup";
            this.btnExportarBackup.Size = new System.Drawing.Size(133, 28);
            this.btnExportarBackup.TabIndex = 2;
            this.btnExportarBackup.Text = "Exportar Backup";
            this.btnExportarBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarBackup.UseVisualStyleBackColor = true;
            this.btnExportarBackup.Click += new System.EventHandler(this.btnExportarBackup_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(516, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDirectorioDeSalida);
            this.groupBox3.Controls.Add(this.txtDirectorioDeSalida);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNombreArchivoBackUp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuracion de exportado";
            // 
            // btnDirectorioDeSalida
            // 
            this.btnDirectorioDeSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectorioDeSalida.Image")));
            this.btnDirectorioDeSalida.Location = new System.Drawing.Point(564, 45);
            this.btnDirectorioDeSalida.Name = "btnDirectorioDeSalida";
            this.btnDirectorioDeSalida.Size = new System.Drawing.Size(40, 23);
            this.btnDirectorioDeSalida.TabIndex = 6;
            this.btnDirectorioDeSalida.UseVisualStyleBackColor = true;
            this.btnDirectorioDeSalida.Click += new System.EventHandler(this.btnDirectorioDeSalida_Click);
            // 
            // txtDirectorioDeSalida
            // 
            this.txtDirectorioDeSalida.Enabled = false;
            this.txtDirectorioDeSalida.Location = new System.Drawing.Point(284, 46);
            this.txtDirectorioDeSalida.Name = "txtDirectorioDeSalida";
            this.txtDirectorioDeSalida.Size = new System.Drawing.Size(274, 20);
            this.txtDirectorioDeSalida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Directorio de salida";
            // 
            // txtNombreArchivoBackUp
            // 
            this.txtNombreArchivoBackUp.Location = new System.Drawing.Point(9, 46);
            this.txtNombreArchivoBackUp.Name = "txtNombreArchivoBackUp";
            this.txtNombreArchivoBackUp.Size = new System.Drawing.Size(238, 20);
            this.txtNombreArchivoBackUp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del archivo";
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(141, 76);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(302, 46);
            this.lblCaption.TabIndex = 38;
            this.lblCaption.Text = "Respalda la informacion de usuario en el programa para usarse en una instalacion " +
    "futura.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RIT_Solver.Properties.Resources.data_recovery;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // respaldo_de_programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(654, 449);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "respaldo_de_programa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RIT Solver Backup Assistant";
            this.Load += new System.EventHandler(this.respaldo_de_programa_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_SeleccionDeDatos.ResumeLayout(false);
            this.tabPage_SeleccionDeDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage_Guardado.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SeleccionDeDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_Inventarios;
        private System.Windows.Forms.TabPage tabPage_Guardado;
        private System.Windows.Forms.Label lblDescripcionInventarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Config1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Config2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreArchivoBackUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDirectorioDeSalida;
        private System.Windows.Forms.TextBox txtDirectorioDeSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportarBackup;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chckBoxEncriptarRespaldo;
        private System.Windows.Forms.CheckBox chckBoxEstablecerContraseña;
        private System.Windows.Forms.Label lblVersionMinimaCompatible;
    }
}