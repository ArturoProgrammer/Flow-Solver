namespace Flow_Solver.MachineProfiles
{
    partial class machine_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(machine_profile));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Eventos Registrados", System.Windows.Forms.HorizontalAlignment.Left);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrpBtnActualizarPerfil = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flCustomTabControl1 = new FlowControls.flCustomTabControl();
            this.tabPage_Perfil = new System.Windows.Forms.TabPage();
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlmacenamientoHDD = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAlmacenamientoSSD = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProcesador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            this.lblFechaDeFabricacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblUsuarioDeRed = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblNoEmp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linklblNombre = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreModelo = new System.Windows.Forms.Label();
            this.pboxImageModel = new System.Windows.Forms.PictureBox();
            this.tabPage_DetallesTecnicos = new System.Windows.Forms.TabPage();
            this.tabPage_ReportesAtendidos = new System.Windows.Forms.TabPage();
            this.lviewReportesAtendidos = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFallaReportada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNoFolio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNoTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaAtencion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.tabPage_HistorialEventos = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lviewHistorialDeEventos = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblHASH = new System.Windows.Forms.Label();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.rtxtMensaje = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bgworkerLoadReportes = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flCustomTabControl1.SuspendLayout();
            this.tabPage_Perfil.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImageModel)).BeginInit();
            this.tabPage_ReportesAtendidos.SuspendLayout();
            this.tabPage_HistorialEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpBtnActualizarPerfil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrpBtnActualizarPerfil
            // 
            this.toolStrpBtnActualizarPerfil.Image = global::Flow_Solver.Properties.Resources.refresh;
            this.toolStrpBtnActualizarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnActualizarPerfil.Name = "toolStrpBtnActualizarPerfil";
            this.toolStrpBtnActualizarPerfil.Size = new System.Drawing.Size(79, 44);
            this.toolStrpBtnActualizarPerfil.Text = "Actualizar";
            this.toolStrpBtnActualizarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(931, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Image = global::Flow_Solver.Properties.Resources.check;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.Text = "Listo";
            // 
            // flCustomTabControl1
            // 
            this.flCustomTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flCustomTabControl1.Controls.Add(this.tabPage_Perfil);
            this.flCustomTabControl1.Controls.Add(this.tabPage_DetallesTecnicos);
            this.flCustomTabControl1.Controls.Add(this.tabPage_ReportesAtendidos);
            this.flCustomTabControl1.Controls.Add(this.tabPage_HistorialEventos);
            this.flCustomTabControl1.DisplayStyle = FlowControls.TabStyle.Rounded;
            // 
            // 
            // 
            this.flCustomTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.flCustomTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.flCustomTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.flCustomTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.flCustomTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.flCustomTabControl1.DisplayStyleProvider.HotTrack = true;
            this.flCustomTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flCustomTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.flCustomTabControl1.DisplayStyleProvider.Overlap = 0;
            this.flCustomTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.flCustomTabControl1.DisplayStyleProvider.Radius = 10;
            this.flCustomTabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.flCustomTabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.flCustomTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.flCustomTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.flCustomTabControl1.HotTrack = true;
            this.flCustomTabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.flCustomTabControl1.Location = new System.Drawing.Point(9, 54);
            this.flCustomTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flCustomTabControl1.Name = "flCustomTabControl1";
            this.flCustomTabControl1.SelectedIndex = 0;
            this.flCustomTabControl1.Size = new System.Drawing.Size(907, 463);
            this.flCustomTabControl1.TabIndex = 0;
            // 
            // tabPage_Perfil
            // 
            this.tabPage_Perfil.AutoScroll = true;
            this.tabPage_Perfil.Controls.Add(this.btnCambiarFoto);
            this.tabPage_Perfil.Controls.Add(this.lblMarca);
            this.tabPage_Perfil.Controls.Add(this.label20);
            this.tabPage_Perfil.Controls.Add(this.groupBox2);
            this.tabPage_Perfil.Controls.Add(this.lblFechaAsignacion);
            this.tabPage_Perfil.Controls.Add(this.lblFechaDeFabricacion);
            this.tabPage_Perfil.Controls.Add(this.groupBox1);
            this.tabPage_Perfil.Controls.Add(this.label3);
            this.tabPage_Perfil.Controls.Add(this.label2);
            this.tabPage_Perfil.Controls.Add(this.lblNombreModelo);
            this.tabPage_Perfil.Controls.Add(this.pboxImageModel);
            this.tabPage_Perfil.Location = new System.Drawing.Point(4, 45);
            this.tabPage_Perfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Perfil.Name = "tabPage_Perfil";
            this.tabPage_Perfil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Perfil.Size = new System.Drawing.Size(899, 414);
            this.tabPage_Perfil.TabIndex = 0;
            this.tabPage_Perfil.Text = "Perfil";
            this.tabPage_Perfil.UseVisualStyleBackColor = true;
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFoto.Image = global::Flow_Solver.Properties.Resources.add_161;
            this.btnCambiarFoto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarFoto.Location = new System.Drawing.Point(256, 246);
            this.btnCambiarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(33, 31);
            this.btnCambiarFoto.TabIndex = 11;
            this.btnCambiarFoto.UseVisualStyleBackColor = true;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMarca.Location = new System.Drawing.Point(73, 292);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(11, 16);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 292);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Marca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlmacenamientoHDD);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblAlmacenamientoSSD);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblMemoria);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblProcesador);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(340, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(535, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Tecnicos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblAlmacenamientoHDD
            // 
            this.lblAlmacenamientoHDD.AutoSize = true;
            this.lblAlmacenamientoHDD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAlmacenamientoHDD.Location = new System.Drawing.Point(176, 97);
            this.lblAlmacenamientoHDD.Name = "lblAlmacenamientoHDD";
            this.lblAlmacenamientoHDD.Size = new System.Drawing.Size(11, 16);
            this.lblAlmacenamientoHDD.TabIndex = 18;
            this.lblAlmacenamientoHDD.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 97);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Almacenamiento HDD:";
            // 
            // lblAlmacenamientoSSD
            // 
            this.lblAlmacenamientoSSD.AutoSize = true;
            this.lblAlmacenamientoSSD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAlmacenamientoSSD.Location = new System.Drawing.Point(176, 74);
            this.lblAlmacenamientoSSD.Name = "lblAlmacenamientoSSD";
            this.lblAlmacenamientoSSD.Size = new System.Drawing.Size(11, 16);
            this.lblAlmacenamientoSSD.TabIndex = 16;
            this.lblAlmacenamientoSSD.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 74);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Almacenamiento SSD:";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMemoria.Location = new System.Drawing.Point(92, 50);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(11, 16);
            this.lblMemoria.TabIndex = 14;
            this.lblMemoria.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Memoria:";
            // 
            // lblProcesador
            // 
            this.lblProcesador.AutoSize = true;
            this.lblProcesador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProcesador.Location = new System.Drawing.Point(111, 27);
            this.lblProcesador.Name = "lblProcesador";
            this.lblProcesador.Size = new System.Drawing.Size(11, 16);
            this.lblProcesador.TabIndex = 12;
            this.lblProcesador.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Procesador:";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFechaAsignacion.Location = new System.Drawing.Point(101, 340);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(11, 16);
            this.lblFechaAsignacion.TabIndex = 7;
            this.lblFechaAsignacion.Text = "-";
            // 
            // lblFechaDeFabricacion
            // 
            this.lblFechaDeFabricacion.AutoSize = true;
            this.lblFechaDeFabricacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFechaDeFabricacion.Location = new System.Drawing.Point(107, 316);
            this.lblFechaDeFabricacion.Name = "lblFechaDeFabricacion";
            this.lblFechaDeFabricacion.Size = new System.Drawing.Size(11, 16);
            this.lblFechaDeFabricacion.TabIndex = 5;
            this.lblFechaDeFabricacion.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblUsuarioDeRed);
            this.groupBox1.Controls.Add(this.lblLocalidad);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblExtension);
            this.groupBox1.Controls.Add(this.lblNoEmp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linklblNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(340, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDepartamento.Location = new System.Drawing.Point(357, 75);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(11, 16);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "-";
            // 
            // lblUsuarioDeRed
            // 
            this.lblUsuarioDeRed.AutoSize = true;
            this.lblUsuarioDeRed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUsuarioDeRed.Location = new System.Drawing.Point(360, 50);
            this.lblUsuarioDeRed.Name = "lblUsuarioDeRed";
            this.lblUsuarioDeRed.Size = new System.Drawing.Size(11, 16);
            this.lblUsuarioDeRed.TabIndex = 18;
            this.lblUsuarioDeRed.Text = "-";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLocalidad.Location = new System.Drawing.Point(96, 123);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(11, 16);
            this.lblLocalidad.TabIndex = 17;
            this.lblLocalidad.Text = "-";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCorreo.Location = new System.Drawing.Point(77, 98);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(11, 16);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "-";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExtension.Location = new System.Drawing.Point(93, 75);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(11, 16);
            this.lblExtension.TabIndex = 15;
            this.lblExtension.Text = "-";
            // 
            // lblNoEmp
            // 
            this.lblNoEmp.AutoSize = true;
            this.lblNoEmp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNoEmp.Location = new System.Drawing.Point(109, 50);
            this.lblNoEmp.Name = "lblNoEmp";
            this.lblNoEmp.Size = new System.Drawing.Size(11, 16);
            this.lblNoEmp.TabIndex = 14;
            this.lblNoEmp.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Localidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Correo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Departamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Usuario de Red:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Extension:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. de Emp.:";
            // 
            // linklblNombre
            // 
            this.linklblNombre.AutoSize = true;
            this.linklblNombre.Location = new System.Drawing.Point(85, 27);
            this.linklblNombre.Name = "linklblNombre";
            this.linklblNombre.Size = new System.Drawing.Size(11, 16);
            this.linklblNombre.TabIndex = 7;
            this.linklblNombre.TabStop = true;
            this.linklblNombre.Text = "-";
            this.linklblNombre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblNombre_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asignacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fabricacion:";
            // 
            // lblNombreModelo
            // 
            this.lblNombreModelo.AutoSize = true;
            this.lblNombreModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreModelo.Location = new System.Drawing.Point(19, 25);
            this.lblNombreModelo.Name = "lblNombreModelo";
            this.lblNombreModelo.Size = new System.Drawing.Size(179, 24);
            this.lblNombreModelo.TabIndex = 1;
            this.lblNombreModelo.Text = "%ModelNameTitle%";
            // 
            // pboxImageModel
            // 
            this.pboxImageModel.BackgroundImage = global::Flow_Solver.Properties.Resources.error_file;
            this.pboxImageModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxImageModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxImageModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.pboxImageModel.Location = new System.Drawing.Point(21, 62);
            this.pboxImageModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxImageModel.Name = "pboxImageModel";
            this.pboxImageModel.Size = new System.Drawing.Size(278, 225);
            this.pboxImageModel.TabIndex = 0;
            this.pboxImageModel.TabStop = false;
            // 
            // tabPage_DetallesTecnicos
            // 
            this.tabPage_DetallesTecnicos.Location = new System.Drawing.Point(4, 45);
            this.tabPage_DetallesTecnicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DetallesTecnicos.Name = "tabPage_DetallesTecnicos";
            this.tabPage_DetallesTecnicos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DetallesTecnicos.Size = new System.Drawing.Size(899, 414);
            this.tabPage_DetallesTecnicos.TabIndex = 3;
            this.tabPage_DetallesTecnicos.Text = "Detalles Tecnicos";
            this.tabPage_DetallesTecnicos.UseVisualStyleBackColor = true;
            // 
            // tabPage_ReportesAtendidos
            // 
            this.tabPage_ReportesAtendidos.Controls.Add(this.lviewReportesAtendidos);
            this.tabPage_ReportesAtendidos.Location = new System.Drawing.Point(4, 45);
            this.tabPage_ReportesAtendidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_ReportesAtendidos.Name = "tabPage_ReportesAtendidos";
            this.tabPage_ReportesAtendidos.Size = new System.Drawing.Size(899, 414);
            this.tabPage_ReportesAtendidos.TabIndex = 1;
            this.tabPage_ReportesAtendidos.Text = "Reportes Atendidos";
            this.tabPage_ReportesAtendidos.UseVisualStyleBackColor = true;
            // 
            // lviewReportesAtendidos
            // 
            this.lviewReportesAtendidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviewReportesAtendidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colFallaReportada,
            this.colNoFolio,
            this.colNoTicket,
            this.colFechaAtencion,
            this.colPath});
            this.lviewReportesAtendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewReportesAtendidos.FullRowSelect = true;
            this.lviewReportesAtendidos.HideSelection = false;
            this.lviewReportesAtendidos.LargeImageList = this.imageList_Icons;
            this.lviewReportesAtendidos.Location = new System.Drawing.Point(0, 0);
            this.lviewReportesAtendidos.Margin = new System.Windows.Forms.Padding(0);
            this.lviewReportesAtendidos.Name = "lviewReportesAtendidos";
            this.lviewReportesAtendidos.Size = new System.Drawing.Size(899, 414);
            this.lviewReportesAtendidos.SmallImageList = this.imageList_Icons;
            this.lviewReportesAtendidos.TabIndex = 1;
            this.lviewReportesAtendidos.UseCompatibleStateImageBehavior = false;
            this.lviewReportesAtendidos.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No.";
            // 
            // colFallaReportada
            // 
            this.colFallaReportada.Text = "Falla Reportada";
            this.colFallaReportada.Width = 254;
            // 
            // colNoFolio
            // 
            this.colNoFolio.Text = "No. Folio";
            this.colNoFolio.Width = 119;
            // 
            // colNoTicket
            // 
            this.colNoTicket.Text = "No. de Ticket";
            this.colNoTicket.Width = 106;
            // 
            // colFechaAtencion
            // 
            this.colFechaAtencion.Text = "Fecha de Atencion";
            this.colFechaAtencion.Width = 141;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 596;
            // 
            // imageList_Icons
            // 
            this.imageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icons.ImageStream")));
            this.imageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icons.Images.SetKeyName(0, "neutral_object-64.png");
            this.imageList_Icons.Images.SetKeyName(1, "rit_project_file.png");
            // 
            // tabPage_HistorialEventos
            // 
            this.tabPage_HistorialEventos.Controls.Add(this.splitContainer1);
            this.tabPage_HistorialEventos.Location = new System.Drawing.Point(4, 45);
            this.tabPage_HistorialEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_HistorialEventos.Name = "tabPage_HistorialEventos";
            this.tabPage_HistorialEventos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_HistorialEventos.Size = new System.Drawing.Size(899, 414);
            this.tabPage_HistorialEventos.TabIndex = 2;
            this.tabPage_HistorialEventos.Text = "Historial de Eventos";
            this.tabPage_HistorialEventos.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lviewHistorialDeEventos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(893, 410);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 0;
            // 
            // lviewHistorialDeEventos
            // 
            this.lviewHistorialDeEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewHistorialDeEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Eventos Registrados";
            listViewGroup1.Name = "lvgroupEventosRegistrados";
            this.lviewHistorialDeEventos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lviewHistorialDeEventos.HideSelection = false;
            this.lviewHistorialDeEventos.LargeImageList = this.imageList_Icons;
            this.lviewHistorialDeEventos.Location = new System.Drawing.Point(0, 0);
            this.lviewHistorialDeEventos.Margin = new System.Windows.Forms.Padding(4);
            this.lviewHistorialDeEventos.Name = "lviewHistorialDeEventos";
            this.lviewHistorialDeEventos.Size = new System.Drawing.Size(516, 410);
            this.lviewHistorialDeEventos.SmallImageList = this.imageList_Icons;
            this.lviewHistorialDeEventos.TabIndex = 33;
            this.lviewHistorialDeEventos.TileSize = new System.Drawing.Size(192, 32);
            this.lviewHistorialDeEventos.UseCompatibleStateImageBehavior = false;
            this.lviewHistorialDeEventos.View = System.Windows.Forms.View.Tile;
            this.lviewHistorialDeEventos.SelectedIndexChanged += new System.EventHandler(this.lviewHistorialDeEventos_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblHASH);
            this.groupBox3.Controls.Add(this.lblCreacion);
            this.groupBox3.Controls.Add(this.rtxtMensaje);
            this.groupBox3.Controls.Add(this.lblTitulo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(373, 410);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propiedades";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 236);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "HASH:";
            // 
            // lblHASH
            // 
            this.lblHASH.AutoSize = true;
            this.lblHASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHASH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHASH.Location = new System.Drawing.Point(71, 236);
            this.lblHASH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHASH.Name = "lblHASH";
            this.lblHASH.Size = new System.Drawing.Size(70, 17);
            this.lblHASH.TabIndex = 3;
            this.lblHASH.Text = "%HASH%";
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Location = new System.Drawing.Point(9, 315);
            this.lblCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(100, 16);
            this.lblCreacion.TabIndex = 2;
            this.lblCreacion.Text = "%CREACION%";
            // 
            // rtxtMensaje
            // 
            this.rtxtMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtMensaje.Location = new System.Drawing.Point(8, 90);
            this.rtxtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtMensaje.Name = "rtxtMensaje";
            this.rtxtMensaje.ReadOnly = true;
            this.rtxtMensaje.Size = new System.Drawing.Size(307, 142);
            this.rtxtMensaje.TabIndex = 1;
            this.rtxtMensaje.Text = "%MENSAJE%";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "%Titulo%";
            // 
            // bgworkerLoadReportes
            // 
            this.bgworkerLoadReportes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworkerLoadReportes_DoWork);
            this.bgworkerLoadReportes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworkerLoadReportes_RunWorkerCompleted);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // machine_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flCustomTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(949, 597);
            this.Name = "machine_profile";
            this.Text = "Perfil del Equipo - %HOSTNAME%";
            this.Load += new System.EventHandler(this.machine_profile_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flCustomTabControl1.ResumeLayout(false);
            this.tabPage_Perfil.ResumeLayout(false);
            this.tabPage_Perfil.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImageModel)).EndInit();
            this.tabPage_ReportesAtendidos.ResumeLayout(false);
            this.tabPage_HistorialEventos.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowControls.flCustomTabControl flCustomTabControl1;
        private System.Windows.Forms.TabPage tabPage_Perfil;
        private System.Windows.Forms.TabPage tabPage_ReportesAtendidos;
        private System.Windows.Forms.TabPage tabPage_HistorialEventos;
        private System.Windows.Forms.PictureBox pboxImageModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.Label lblFechaDeFabricacion;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblUsuarioDeRed;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblNoEmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linklblNombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrpBtnActualizarPerfil;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabPage tabPage_DetallesTecnicos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblHASH;
        private System.Windows.Forms.Label lblCreacion;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListView lviewHistorialDeEventos;
        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList_Icons;
        private System.Windows.Forms.Label lblProcesador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAlmacenamientoHDD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAlmacenamientoSSD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lviewReportesAtendidos;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colFallaReportada;
        private System.Windows.Forms.ColumnHeader colNoFolio;
        private System.Windows.Forms.ColumnHeader colNoTicket;
        private System.Windows.Forms.ColumnHeader colFechaAtencion;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.ComponentModel.BackgroundWorker bgworkerLoadReportes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}