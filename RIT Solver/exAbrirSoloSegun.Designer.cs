namespace RIT_Solver
{
    partial class exAbrirSoloSegun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exAbrirSoloSegun));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtRutaDirectorio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrpBtn_Examinar = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtn_AbrirUbicacionDelArchivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toogle_VerTodos = new System.Windows.Forms.ToolStripButton();
            this.toogle_VerGeneradosEnSAS = new System.Windows.Forms.ToolStripButton();
            this.toogle_VerImpresos = new System.Windows.Forms.ToolStripButton();
            this.toogle_VerFirmados = new System.Windows.Forms.ToolStripButton();
            this.toogle_VerComprobados = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lviewTablaDeProyectos = new System.Windows.Forms.ListView();
            this.colNombreArchivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFallaReportada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenerado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImpreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirmado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComprobado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.lblCoincidencias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSeleccionado = new System.Windows.Forms.Label();
            this.chckboxCargarSinPreguntar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chckboxSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.txtRutaDirectorio,
            this.toolStrpBtn_Examinar,
            this.toolStrpBtn_AbrirUbicacionDelArchivo,
            this.toolStripSeparator1,
            this.toogle_VerTodos,
            this.toogle_VerGeneradosEnSAS,
            this.toogle_VerImpresos,
            this.toogle_VerFirmados,
            this.toogle_VerComprobados});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1026, 47);
            this.toolStrip2.TabIndex = 4;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 44);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 44);
            this.toolStripLabel1.Text = "Path:";
            // 
            // txtRutaDirectorio
            // 
            this.txtRutaDirectorio.Enabled = false;
            this.txtRutaDirectorio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaDirectorio.Name = "txtRutaDirectorio";
            this.txtRutaDirectorio.Size = new System.Drawing.Size(465, 47);
            // 
            // toolStrpBtn_Examinar
            // 
            this.toolStrpBtn_Examinar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtn_Examinar.Image = global::RIT_Solver.Properties.Resources.buscar_16;
            this.toolStrpBtn_Examinar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_Examinar.Name = "toolStrpBtn_Examinar";
            this.toolStrpBtn_Examinar.Size = new System.Drawing.Size(29, 44);
            this.toolStrpBtn_Examinar.Text = "Examinar";
            this.toolStrpBtn_Examinar.Click += new System.EventHandler(this.toolStrpBtn_Examinar_Click);
            // 
            // toolStrpBtn_AbrirUbicacionDelArchivo
            // 
            this.toolStrpBtn_AbrirUbicacionDelArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Enabled = false;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Image = global::RIT_Solver.Properties.Resources.open;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Name = "toolStrpBtn_AbrirUbicacionDelArchivo";
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Size = new System.Drawing.Size(29, 44);
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Text = "Ir a ubicacion del archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toogle_VerTodos
            // 
            this.toogle_VerTodos.CheckOnClick = true;
            this.toogle_VerTodos.Enabled = false;
            this.toogle_VerTodos.Image = global::RIT_Solver.Properties.Resources.project;
            this.toogle_VerTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toogle_VerTodos.Name = "toogle_VerTodos";
            this.toogle_VerTodos.Size = new System.Drawing.Size(53, 44);
            this.toogle_VerTodos.Text = "Todos";
            this.toogle_VerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toogle_VerTodos.ToolTipText = "Mostrar todos los RITs del directorio";
            this.toogle_VerTodos.CheckedChanged += new System.EventHandler(this.toogle_VerTodos_CheckedChanged);
            // 
            // toogle_VerGeneradosEnSAS
            // 
            this.toogle_VerGeneradosEnSAS.CheckOnClick = true;
            this.toogle_VerGeneradosEnSAS.Enabled = false;
            this.toogle_VerGeneradosEnSAS.Image = global::RIT_Solver.Properties.Resources.project;
            this.toogle_VerGeneradosEnSAS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toogle_VerGeneradosEnSAS.Name = "toogle_VerGeneradosEnSAS";
            this.toogle_VerGeneradosEnSAS.Size = new System.Drawing.Size(84, 44);
            this.toogle_VerGeneradosEnSAS.Text = "Generados";
            this.toogle_VerGeneradosEnSAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toogle_VerGeneradosEnSAS.ToolTipText = "Aquellos que esten generados en SAS";
            this.toogle_VerGeneradosEnSAS.CheckedChanged += new System.EventHandler(this.toogle_VerGeneradosEnSAS_CheckedChanged);
            this.toogle_VerGeneradosEnSAS.Click += new System.EventHandler(this.toogle_VerGeneradosEnSAS_Click);
            // 
            // toogle_VerImpresos
            // 
            this.toogle_VerImpresos.CheckOnClick = true;
            this.toogle_VerImpresos.Enabled = false;
            this.toogle_VerImpresos.Image = global::RIT_Solver.Properties.Resources.project_printed;
            this.toogle_VerImpresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toogle_VerImpresos.Name = "toogle_VerImpresos";
            this.toogle_VerImpresos.Size = new System.Drawing.Size(73, 44);
            this.toogle_VerImpresos.Text = "Impresos";
            this.toogle_VerImpresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toogle_VerImpresos.ToolTipText = "Aquellos que esten impresos";
            this.toogle_VerImpresos.CheckedChanged += new System.EventHandler(this.toogle_VerImpresos_CheckedChanged);
            // 
            // toogle_VerFirmados
            // 
            this.toogle_VerFirmados.CheckOnClick = true;
            this.toogle_VerFirmados.Enabled = false;
            this.toogle_VerFirmados.Image = global::RIT_Solver.Properties.Resources.project_signed;
            this.toogle_VerFirmados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toogle_VerFirmados.Name = "toogle_VerFirmados";
            this.toogle_VerFirmados.Size = new System.Drawing.Size(74, 44);
            this.toogle_VerFirmados.Text = "Firmados";
            this.toogle_VerFirmados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toogle_VerFirmados.ToolTipText = "Aquellos que esten firmados";
            this.toogle_VerFirmados.CheckedChanged += new System.EventHandler(this.toogle_VerFirmados_CheckedChanged);
            // 
            // toogle_VerComprobados
            // 
            this.toogle_VerComprobados.Checked = true;
            this.toogle_VerComprobados.CheckOnClick = true;
            this.toogle_VerComprobados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toogle_VerComprobados.Enabled = false;
            this.toogle_VerComprobados.Image = global::RIT_Solver.Properties.Resources.project_comprobado;
            this.toogle_VerComprobados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toogle_VerComprobados.Name = "toogle_VerComprobados";
            this.toogle_VerComprobados.Size = new System.Drawing.Size(79, 44);
            this.toogle_VerComprobados.Text = "Comprob.";
            this.toogle_VerComprobados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toogle_VerComprobados.ToolTipText = "Aquellos que esten comprobados";
            this.toogle_VerComprobados.CheckedChanged += new System.EventHandler(this.toogle_VerComprobados_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lviewTablaDeProyectos);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(993, 293);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyectos en el directorio";
            // 
            // lviewTablaDeProyectos
            // 
            this.lviewTablaDeProyectos.CheckBoxes = true;
            this.lviewTablaDeProyectos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombreArchivo,
            this.colFallaReportada,
            this.colFecha,
            this.colGenerado,
            this.colImpreso,
            this.colFirmado,
            this.colComprobado});
            this.lviewTablaDeProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewTablaDeProyectos.FullRowSelect = true;
            this.lviewTablaDeProyectos.HideSelection = false;
            this.lviewTablaDeProyectos.LargeImageList = this.imageList1;
            this.lviewTablaDeProyectos.Location = new System.Drawing.Point(4, 19);
            this.lviewTablaDeProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.lviewTablaDeProyectos.Name = "lviewTablaDeProyectos";
            this.lviewTablaDeProyectos.Size = new System.Drawing.Size(985, 270);
            this.lviewTablaDeProyectos.SmallImageList = this.imageList1;
            this.lviewTablaDeProyectos.TabIndex = 1;
            this.lviewTablaDeProyectos.TileSize = new System.Drawing.Size(192, 34);
            this.lviewTablaDeProyectos.UseCompatibleStateImageBehavior = false;
            this.lviewTablaDeProyectos.View = System.Windows.Forms.View.Details;
            this.lviewTablaDeProyectos.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lviewTablaDeProyectos_ItemChecked);
            this.lviewTablaDeProyectos.SelectedIndexChanged += new System.EventHandler(this.lviewTablaDeProyectos_SelectedIndexChanged);
            // 
            // colNombreArchivo
            // 
            this.colNombreArchivo.Text = "Nombre";
            this.colNombreArchivo.Width = 220;
            // 
            // colFallaReportada
            // 
            this.colFallaReportada.Text = "Falla Reportada";
            this.colFallaReportada.Width = 400;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            // 
            // colGenerado
            // 
            this.colGenerado.Text = "Generado";
            this.colGenerado.Width = 76;
            // 
            // colImpreso
            // 
            this.colImpreso.Text = "Impreso";
            this.colImpreso.Width = 67;
            // 
            // colFirmado
            // 
            this.colFirmado.Text = "Firmado";
            this.colFirmado.Width = 65;
            // 
            // colComprobado
            // 
            this.colComprobado.Text = "Comprobado";
            this.colComprobado.Width = 99;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "project.png");
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::RIT_Solver.Properties.Resources.check_3_16;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(792, 386);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 34);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = " Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.Location = new System.Drawing.Point(904, 386);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label60
            // 
            this.label60.ForeColor = System.Drawing.Color.DarkRed;
            this.label60.Location = new System.Drawing.Point(16, 380);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(544, 37);
            this.label60.TabIndex = 24;
            this.label60.Text = "** NOTA: en este listado solo se cargan los archivos de Proyectos RIT (.ritproj) " +
    "del directorio establecido";
            // 
            // lblCoincidencias
            // 
            this.lblCoincidencias.AutoSize = true;
            this.lblCoincidencias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCoincidencias.Location = new System.Drawing.Point(677, 380);
            this.lblCoincidencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoincidencias.Name = "lblCoincidencias";
            this.lblCoincidencias.Size = new System.Drawing.Size(33, 16);
            this.lblCoincidencias.TabIndex = 25;
            this.lblCoincidencias.Text = "(0/0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Coincidencias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total seleccionado:";
            // 
            // lblTotalSeleccionado
            // 
            this.lblTotalSeleccionado.AutoSize = true;
            this.lblTotalSeleccionado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalSeleccionado.Location = new System.Drawing.Point(709, 405);
            this.lblTotalSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSeleccionado.Name = "lblTotalSeleccionado";
            this.lblTotalSeleccionado.Size = new System.Drawing.Size(14, 16);
            this.lblTotalSeleccionado.TabIndex = 27;
            this.lblTotalSeleccionado.Text = "0";
            // 
            // chckboxCargarSinPreguntar
            // 
            this.chckboxCargarSinPreguntar.AutoSize = true;
            this.chckboxCargarSinPreguntar.Checked = true;
            this.chckboxCargarSinPreguntar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckboxCargarSinPreguntar.Location = new System.Drawing.Point(349, 56);
            this.chckboxCargarSinPreguntar.Name = "chckboxCargarSinPreguntar";
            this.chckboxCargarSinPreguntar.Size = new System.Drawing.Size(211, 20);
            this.chckboxCargarSinPreguntar.TabIndex = 29;
            this.chckboxCargarSinPreguntar.Text = "Cargar seleccion sin preguntar";
            this.chckboxCargarSinPreguntar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Excepto aquellos...";
            // 
            // chckboxSeleccionarTodos
            // 
            this.chckboxSeleccionarTodos.AutoSize = true;
            this.chckboxSeleccionarTodos.Location = new System.Drawing.Point(20, 56);
            this.chckboxSeleccionarTodos.Name = "chckboxSeleccionarTodos";
            this.chckboxSeleccionarTodos.Size = new System.Drawing.Size(138, 20);
            this.chckboxSeleccionarTodos.TabIndex = 31;
            this.chckboxSeleccionarTodos.Text = "Seleccionar todos";
            this.chckboxSeleccionarTodos.UseVisualStyleBackColor = true;
            this.chckboxSeleccionarTodos.Click += new System.EventHandler(this.chckboxSeleccionarTodos_Click);
            // 
            // exAbrirSoloSegun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 434);
            this.Controls.Add(this.chckboxSeleccionarTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chckboxCargarSinPreguntar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCoincidencias);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "exAbrirSoloSegun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir Proyectos Selectos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exAbrirSoloSegun_FormClosed);
            this.Load += new System.EventHandler(this.exAbrirSoloSegun_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtRutaDirectorio;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_AbrirUbicacionDelArchivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lviewTablaDeProyectos;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_Examinar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toogle_VerTodos;
        private System.Windows.Forms.ToolStripButton toogle_VerGeneradosEnSAS;
        private System.Windows.Forms.ToolStripButton toogle_VerImpresos;
        private System.Windows.Forms.ToolStripButton toogle_VerFirmados;
        private System.Windows.Forms.ToolStripButton toogle_VerComprobados;
        private System.Windows.Forms.ColumnHeader colNombreArchivo;
        private System.Windows.Forms.ColumnHeader colFallaReportada;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colGenerado;
        private System.Windows.Forms.ColumnHeader colImpreso;
        private System.Windows.Forms.ColumnHeader colFirmado;
        private System.Windows.Forms.ColumnHeader colComprobado;
        private System.Windows.Forms.Label lblCoincidencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSeleccionado;
        private System.Windows.Forms.CheckBox chckboxCargarSinPreguntar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chckboxSeleccionarTodos;
    }
}