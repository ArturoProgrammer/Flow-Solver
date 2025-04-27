namespace Flow_Solver
{
    partial class añadir_equipo
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
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadir_equipo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCentroCostos = new System.Windows.Forms.TextBox();
            this.btnSeleccionarModeloVinculado = new System.Windows.Forms.Button();
            this.btnVincularModelo = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblNumeroDeEmpleado = new System.Windows.Forms.Label();
            this.txtTipoDeEquipo = new System.Windows.Forms.ComboBox();
            this.lblCentroDeCostos = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnRecargarInventario = new System.Windows.Forms.Button();
            this.btnGenerarResguardo = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHOSTNAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroDeSerie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxPuestoDelUsuario = new System.Windows.Forms.ComboBox();
            this.cboxDGA = new System.Windows.Forms.ComboBox();
            this.lblSubdireccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.ComboBox();
            this.lblDireccionAdjunta = new System.Windows.Forms.Label();
            this.cboxSubdireccion = new System.Windows.Forms.ComboBox();
            this.cboxDireccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUsuarioDelArchivo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargarDesdeArchivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(175, 43);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(250, 42);
            lblTitle.TabIndex = 36;
            lblTitle.Text = "Nuevo equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtCentroCostos);
            this.groupBox1.Controls.Add(this.btnSeleccionarModeloVinculado);
            this.groupBox1.Controls.Add(this.btnVincularModelo);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.lblNumeroDeEmpleado);
            this.groupBox1.Controls.Add(this.txtTipoDeEquipo);
            this.groupBox1.Controls.Add(this.lblCentroDeCostos);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.btnNuevoUsuario);
            this.groupBox1.Controls.Add(this.btnRecargarInventario);
            this.groupBox1.Controls.Add(this.btnGenerarResguardo);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHOSTNAME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumeroDeSerie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(636, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Equipo";
            // 
            // txtCentroCostos
            // 
            this.txtCentroCostos.ForeColor = System.Drawing.Color.Brown;
            this.txtCentroCostos.Location = new System.Drawing.Point(460, 63);
            this.txtCentroCostos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCentroCostos.Name = "txtCentroCostos";
            this.txtCentroCostos.Size = new System.Drawing.Size(155, 22);
            this.txtCentroCostos.TabIndex = 36;
            this.txtCentroCostos.TextChanged += new System.EventHandler(this.txtCentroCostos_TextChanged);
            // 
            // btnSeleccionarModeloVinculado
            // 
            this.btnSeleccionarModeloVinculado.BackgroundImage = global::Flow_Solver.Properties.Resources.selection;
            this.btnSeleccionarModeloVinculado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarModeloVinculado.Location = new System.Drawing.Point(248, 169);
            this.btnSeleccionarModeloVinculado.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarModeloVinculado.Name = "btnSeleccionarModeloVinculado";
            this.btnSeleccionarModeloVinculado.Size = new System.Drawing.Size(36, 31);
            this.btnSeleccionarModeloVinculado.TabIndex = 35;
            this.btnSeleccionarModeloVinculado.UseVisualStyleBackColor = true;
            this.btnSeleccionarModeloVinculado.Click += new System.EventHandler(this.btnSeleccionarModeloVinculado_Click);
            // 
            // btnVincularModelo
            // 
            this.btnVincularModelo.Image = global::Flow_Solver.Properties.Resources.database_16;
            this.btnVincularModelo.Location = new System.Drawing.Point(204, 169);
            this.btnVincularModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVincularModelo.Name = "btnVincularModelo";
            this.btnVincularModelo.Size = new System.Drawing.Size(36, 31);
            this.btnVincularModelo.TabIndex = 34;
            this.btnVincularModelo.UseVisualStyleBackColor = true;
            this.btnVincularModelo.Click += new System.EventHandler(this.btnVincularModelo_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(12, 319);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(271, 22);
            this.txtUbicacion.TabIndex = 33;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged_1);
            // 
            // lblNumeroDeEmpleado
            // 
            this.lblNumeroDeEmpleado.AutoSize = true;
            this.lblNumeroDeEmpleado.Location = new System.Drawing.Point(331, 43);
            this.lblNumeroDeEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDeEmpleado.Name = "lblNumeroDeEmpleado";
            this.lblNumeroDeEmpleado.Size = new System.Drawing.Size(75, 16);
            this.lblNumeroDeEmpleado.TabIndex = 32;
            this.lblNumeroDeEmpleado.Text = "Num. Emp: ";
            // 
            // txtTipoDeEquipo
            // 
            this.txtTipoDeEquipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTipoDeEquipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTipoDeEquipo.FormattingEnabled = true;
            this.txtTipoDeEquipo.Items.AddRange(new object[] {
            "LAPTOP",
            "PC",
            "IMPRESORA",
            "IPAD",
            "UPS"});
            this.txtTipoDeEquipo.Location = new System.Drawing.Point(12, 218);
            this.txtTipoDeEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoDeEquipo.Name = "txtTipoDeEquipo";
            this.txtTipoDeEquipo.Size = new System.Drawing.Size(271, 24);
            this.txtTipoDeEquipo.TabIndex = 9;
            this.txtTipoDeEquipo.TextChanged += new System.EventHandler(this.txtTipoDeEquipo_TextChanged);
            this.txtTipoDeEquipo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipoDeEquipo_Validating);
            // 
            // lblCentroDeCostos
            // 
            this.lblCentroDeCostos.AutoSize = true;
            this.lblCentroDeCostos.Location = new System.Drawing.Point(331, 68);
            this.lblCentroDeCostos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentroDeCostos.Name = "lblCentroDeCostos";
            this.lblCentroDeCostos.Size = new System.Drawing.Size(113, 16);
            this.lblCentroDeCostos.TabIndex = 18;
            this.lblCentroDeCostos.Text = "Centro de Costos:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(331, 20);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(96, 16);
            this.lblDepartamento.TabIndex = 17;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Image = global::Flow_Solver.Properties.Resources.plus_16;
            this.btnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(12, 71);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(145, 31);
            this.btnNuevoUsuario.TabIndex = 2;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnRecargarInventario
            // 
            this.btnRecargarInventario.Image = global::Flow_Solver.Properties.Resources.reload_16;
            this.btnRecargarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargarInventario.Location = new System.Drawing.Point(169, 71);
            this.btnRecargarInventario.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecargarInventario.Name = "btnRecargarInventario";
            this.btnRecargarInventario.Size = new System.Drawing.Size(115, 31);
            this.btnRecargarInventario.TabIndex = 3;
            this.btnRecargarInventario.Text = "Recargar";
            this.btnRecargarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecargarInventario.UseVisualStyleBackColor = true;
            this.btnRecargarInventario.Click += new System.EventHandler(this.btnRecargarInventario_Click);
            // 
            // btnGenerarResguardo
            // 
            this.btnGenerarResguardo.Image = global::Flow_Solver.Properties.Resources.pencil_16;
            this.btnGenerarResguardo.Location = new System.Drawing.Point(296, 416);
            this.btnGenerarResguardo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarResguardo.Name = "btnGenerarResguardo";
            this.btnGenerarResguardo.Size = new System.Drawing.Size(332, 62);
            this.btnGenerarResguardo.TabIndex = 30;
            this.btnGenerarResguardo.Text = " Asignar Datos de Accesorios y/o Generar Resguardo";
            this.btnGenerarResguardo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarResguardo.UseVisualStyleBackColor = true;
            this.btnGenerarResguardo.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(12, 416);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(271, 22);
            this.txtComentario.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Comentario";
            // 
            // txtHOSTNAME
            // 
            this.txtHOSTNAME.Location = new System.Drawing.Point(12, 367);
            this.txtHOSTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.txtHOSTNAME.Name = "txtHOSTNAME";
            this.txtHOSTNAME.Size = new System.Drawing.Size(271, 22);
            this.txtHOSTNAME.TabIndex = 15;
            this.txtHOSTNAME.TextChanged += new System.EventHandler(this.txtHOSTNAME_TextChanged);
            this.txtHOSTNAME.Validating += new System.ComponentModel.CancelEventHandler(this.txtHOSTNAME_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "HOSTNAME *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ubicacion";
            // 
            // txtNumeroDeSerie
            // 
            this.txtNumeroDeSerie.Location = new System.Drawing.Point(12, 266);
            this.txtNumeroDeSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDeSerie.Name = "txtNumeroDeSerie";
            this.txtNumeroDeSerie.Size = new System.Drawing.Size(271, 22);
            this.txtNumeroDeSerie.TabIndex = 11;
            this.txtNumeroDeSerie.TextChanged += new System.EventHandler(this.txtNumeroDeSerie_TextChanged);
            this.txtNumeroDeSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroDeSerie_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de serie *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de equipo *";
            // 
            // txtModelo
            // 
            this.txtModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtModelo.Location = new System.Drawing.Point(12, 172);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(183, 22);
            this.txtModelo.TabIndex = 7;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            this.txtModelo.Validating += new System.ComponentModel.CancelEventHandler(this.txtModelo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo *";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 124);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(271, 22);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarca_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca *";
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxUsuario.FormattingEnabled = true;
            this.cboxUsuario.Location = new System.Drawing.Point(12, 39);
            this.cboxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(271, 24);
            this.cboxUsuario.TabIndex = 1;
            this.cboxUsuario.SelectedIndexChanged += new System.EventHandler(this.cboxUsuario_SelectedIndexChanged);
            this.cboxUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.cboxUsuario_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario asignado *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxPuestoDelUsuario);
            this.groupBox2.Controls.Add(this.cboxDGA);
            this.groupBox2.Controls.Add(this.lblSubdireccion);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDivision);
            this.groupBox2.Controls.Add(this.lblDireccionAdjunta);
            this.groupBox2.Controls.Add(this.cboxSubdireccion);
            this.groupBox2.Controls.Add(this.cboxDireccion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(296, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(332, 284);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llenar en caso de generar resguardo";
            // 
            // cboxPuestoDelUsuario
            // 
            this.cboxPuestoDelUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxPuestoDelUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPuestoDelUsuario.FormattingEnabled = true;
            this.cboxPuestoDelUsuario.Location = new System.Drawing.Point(19, 48);
            this.cboxPuestoDelUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPuestoDelUsuario.Name = "cboxPuestoDelUsuario";
            this.cboxPuestoDelUsuario.Size = new System.Drawing.Size(300, 24);
            this.cboxPuestoDelUsuario.Sorted = true;
            this.cboxPuestoDelUsuario.TabIndex = 18;
            this.cboxPuestoDelUsuario.SelectedIndexChanged += new System.EventHandler(this.cboxPuestoDelUsuario_SelectedIndexChanged);
            // 
            // cboxDGA
            // 
            this.cboxDGA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxDGA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxDGA.FormattingEnabled = true;
            this.cboxDGA.Items.AddRange(new object[] {
            "Dir. General de Operacion",
            "Dir. General de Administracion",
            "Dir. General Comercial",
            "Dir. General Planeacion y Proyectos",
            "Presidencia Ejecutiva",
            "Dir. General"});
            this.cboxDGA.Location = new System.Drawing.Point(19, 190);
            this.cboxDGA.Margin = new System.Windows.Forms.Padding(4);
            this.cboxDGA.Name = "cboxDGA";
            this.cboxDGA.Size = new System.Drawing.Size(300, 24);
            this.cboxDGA.TabIndex = 27;
            this.cboxDGA.TextUpdate += new System.EventHandler(this.cboxDGA_TextChanged);
            // 
            // lblSubdireccion
            // 
            this.lblSubdireccion.AutoSize = true;
            this.lblSubdireccion.Location = new System.Drawing.Point(15, 75);
            this.lblSubdireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubdireccion.Name = "lblSubdireccion";
            this.lblSubdireccion.Size = new System.Drawing.Size(86, 16);
            this.lblSubdireccion.TabIndex = 22;
            this.lblSubdireccion.Text = "Subdireccion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 122);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Puesto del usuario";
            // 
            // txtDivision
            // 
            this.txtDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDivision.FormattingEnabled = true;
            this.txtDivision.Items.AddRange(new object[] {
            "Guadalajara",
            "Centro Mexico",
            "Monterrey",
            "Chihuahua",
            "Hermosillo",
            "Corporativo",
            "Veracruz"});
            this.txtDivision.Location = new System.Drawing.Point(19, 241);
            this.txtDivision.Margin = new System.Windows.Forms.Padding(4);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(300, 24);
            this.txtDivision.TabIndex = 29;
            this.txtDivision.SelectedIndexChanged += new System.EventHandler(this.txtDivision_SelectedIndexChanged);
            // 
            // lblDireccionAdjunta
            // 
            this.lblDireccionAdjunta.AutoSize = true;
            this.lblDireccionAdjunta.Location = new System.Drawing.Point(16, 170);
            this.lblDireccionAdjunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionAdjunta.Name = "lblDireccionAdjunta";
            this.lblDireccionAdjunta.Size = new System.Drawing.Size(112, 16);
            this.lblDireccionAdjunta.TabIndex = 26;
            this.lblDireccionAdjunta.Text = "Direccion Adjunta";
            // 
            // cboxSubdireccion
            // 
            this.cboxSubdireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxSubdireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSubdireccion.FormattingEnabled = true;
            this.cboxSubdireccion.Items.AddRange(new object[] {
            "Subdir. Centro Control de Operaciones",
            "Subdir. Infraestructura Reg. Centro-Sur",
            "Subdir. Operaciones Reg. Norte",
            "Dir. Mantenimiento de Via",
            "Subdir. Rels. Laborales y Capacitacion",
            "Subdir. Operaciones Reg. Centro-Sur",
            "Subdir. Infraestructura Reg. Norte",
            "Subdir. Digital Infraestructura",
            "Supint. FM y EA Reg. Pacifico",
            "Subdir. Operaciones Reg. Pacifico",
            "Dir. Recursos Humanos",
            "Dir. Servicio a Clientes",
            "Subdir. Contraloria",
            "Dir. Fza. Motriz Y Eqpo. Arr.",
            "Subdir. Almacen e Inventarios",
            "Subdir. Tesoreria",
            "Subdir. Proteccion Ferroviaria",
            "Subdir. Infraestructura Reg. Pacifico",
            "Subdir. Diseño de Servicio y Red",
            "Subdir. Digital Transporte y Oper. FXE",
            "Subdir. Compras Infraestructura y TI",
            "Subdir. Admon. Personal",
            "Subdir. Logistica de Carros",
            "Subdir. Juridico Asuntos Penales FXE",
            "Supint. FM y EA Reg. Norte",
            "Subdir. Digital Aplicaciones",
            "Subdir. Seguridad y Sustentabilidad",
            "Supint. FM y EA Reg. Centro-Sur",
            "Auditoria General",
            "Subdir. Turismo",
            "Dir. Planeacion",
            "Dir. Transporte",
            "Dir. General Operacion",
            "Subdir. Comercial Agricola",
            "Subdir. Vias Particulares",
            "Subdir. Proyectos Estructurales",
            "Subdir. Juridica Contencioso Y Reg.",
            "Dir. Proyectos",
            "Subdir. Compras Eq. Rodante y Serv. Op.",
            "Dir. Abastecimientos",
            "Subdir. Juridica Corporativa",
            "Subdir. Construccion",
            "Dir. Finanzas",
            "Presidencia Ejecutiva",
            "Dir. Comercial Autom. / Industrial",
            "Subdir. Planeacion y Presupuesto",
            "Subdir. Planeacion de Mtto. de Via",
            "Dir. General",
            "Dir. Juridica",
            "Subdir. C. Met. y Min. Cmto. Ferrobuque",
            "Subdir. Digital Seguridad",
            "Dir. Digital",
            "Dir. General Planeacion y Proyectos",
            "Dir. Inteligencia de Mercados",
            "Dir. Relaciones con Gobierno y Com.",
            "Subdir. Comercial Industrial",
            "Dir. General Administracion",
            "Subdir. Gestion Publica",
            "Subdir. Comercial Intermodal",
            "Subdir. Comercial Automotriz",
            "Dir. Proteccion Ferroviaria",
            "Dir. Comercial Agricola Met. Min. Ener.",
            "Subdir. Atraccion y Dllo. de Talento",
            "Subdir. Relaciones con Gobierno",
            "Subdir. C. Quim. Fert. y Energ.",
            "Dir. General Comercial",
            "Subdir. Gobierno",
            "Subdir. Operacion TMS"});
            this.cboxSubdireccion.Location = new System.Drawing.Point(19, 92);
            this.cboxSubdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSubdireccion.Name = "cboxSubdireccion";
            this.cboxSubdireccion.Size = new System.Drawing.Size(300, 24);
            this.cboxSubdireccion.TabIndex = 23;
            this.cboxSubdireccion.TextUpdate += new System.EventHandler(this.cboxSubdireccion_TextChanged);
            // 
            // cboxDireccion
            // 
            this.cboxDireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxDireccion.FormattingEnabled = true;
            this.cboxDireccion.Items.AddRange(new object[] {
            "Dir. Transporte",
            "Dir. Mantenimiento de Via",
            "Dir. Recursos Humanos",
            "Dir. Digital",
            "Dir. Fza. Motriz Y Eqpo. Arr.",
            "Dir. Servicio a Clientes",
            "Dir. Finanzas",
            "Dir. Abastecimientos",
            "Dir. Proteccion Ferroviaria",
            "Dir. Planeacion",
            "Dir. General Comercial",
            "Dir. Juridica",
            "Dir. General Planeacion y Proyectos",
            "Auditoria General",
            "Dir. General Operacion",
            "Dir. Comercial Agricola Met. Min. Ener.",
            "Dir. Proyectos",
            "Presidencia Ejecutiva",
            "Dir. Comercial Autom. / Industrial",
            "Dir. General",
            "Dir. Inteligencia de Mercados",
            "Dir. Relaciones con Gobierno y Com.",
            "Dir. General Administracion"});
            this.cboxDireccion.Location = new System.Drawing.Point(19, 142);
            this.cboxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.cboxDireccion.Name = "cboxDireccion";
            this.cboxDireccion.Size = new System.Drawing.Size(300, 24);
            this.cboxDireccion.TabIndex = 25;
            this.cboxDireccion.TextUpdate += new System.EventHandler(this.cboxDireccion_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Division";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(181, 90);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(128, 18);
            this.lblCaption.TabIndex = 11;
            this.lblCaption.Text = "Añadir a inventario";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 615);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(272, 81);
            this.dataGridView1.TabIndex = 16;
            // 
            // lblUsuarioDelArchivo
            // 
            this.lblUsuarioDelArchivo.Location = new System.Drawing.Point(181, 122);
            this.lblUsuarioDelArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioDelArchivo.Name = "lblUsuarioDelArchivo";
            this.lblUsuarioDelArchivo.Size = new System.Drawing.Size(279, 31);
            this.lblUsuarioDelArchivo.TabIndex = 34;
            this.lblUsuarioDelArchivo.Text = "Usuario del Archivo: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.errorProvider1.SetIconAlignment(this.btnGuardar, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.btnGuardar.Image = global::Flow_Solver.Properties.Resources.save_16;
            this.btnGuardar.Location = new System.Drawing.Point(485, 470);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 48);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = " Guardar Equipo y Accesorios";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Control;
            this.panelFondo.Controls.Add(this.btnCancelar);
            this.panelFondo.Controls.Add(this.btnGuardar);
            this.panelFondo.Location = new System.Drawing.Point(0, 176);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(4);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(679, 538);
            this.panelFondo.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Flow_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.Location = new System.Drawing.Point(312, 470);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 48);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargarDesdeArchivo
            // 
            this.btnCargarDesdeArchivo.Image = global::Flow_Solver.Properties.Resources.importar_16;
            this.btnCargarDesdeArchivo.Location = new System.Drawing.Point(476, 14);
            this.btnCargarDesdeArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarDesdeArchivo.Name = "btnCargarDesdeArchivo";
            this.btnCargarDesdeArchivo.Size = new System.Drawing.Size(184, 48);
            this.btnCargarDesdeArchivo.TabIndex = 33;
            this.btnCargarDesdeArchivo.Text = "Cargar desde archivo";
            this.btnCargarDesdeArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDesdeArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarDesdeArchivo.UseVisualStyleBackColor = true;
            this.btnCargarDesdeArchivo.Click += new System.EventHandler(this.btnCargarDesdeArchivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flow_Solver.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // añadir_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(675, 709);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.lblUsuarioDelArchivo);
            this.Controls.Add(this.btnCargarDesdeArchivo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "añadir_equipo";
            this.Text = "Añadir Equipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.añadir_equipo_FormClosing);
            this.Load += new System.EventHandler(this.añadir_equipo_Load);
            this.Shown += new System.EventHandler(this.añadir_equipo_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.añadir_equipo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerarResguardo;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cboxUsuario;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumeroDeSerie;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtHOSTNAME;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtComentario;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnRecargarInventario;
        public System.Windows.Forms.Button btnNuevoUsuario;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cboxPuestoDelUsuario;
        public System.Windows.Forms.Label lblDepartamento;
        public System.Windows.Forms.Label lblCentroDeCostos;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.Label lblDireccionAdjunta;
        public System.Windows.Forms.Label lblSubdireccion;
        private System.Windows.Forms.ComboBox txtDivision;
        public System.Windows.Forms.ComboBox txtTipoDeEquipo;
        private System.Windows.Forms.ComboBox cboxSubdireccion;
        private System.Windows.Forms.ComboBox cboxDGA;
        private System.Windows.Forms.ComboBox cboxDireccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumeroDeEmpleado;
        private System.Windows.Forms.Button btnCargarDesdeArchivo;
        private System.Windows.Forms.Label lblUsuarioDelArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnVincularModelo;
        private System.Windows.Forms.Button btnSeleccionarModeloVinculado;
        private System.Windows.Forms.TextBox txtCentroCostos;
    }
}