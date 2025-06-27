using System.Windows.Forms;

namespace Flow_Solver
{
    partial class lista_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lista_usuarios));
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblUsuarioDeRed = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblNumeroDeEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportarUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnGuardarModificaciones = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtUsuarioDeRed = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtNumeroDeEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblUsuariosCargados = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxFiltroDeVista = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar_PlaceHolder = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardaModifiacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_WaitScreen = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialogEx1 = new FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.Location = new System.Drawing.Point(12, 77);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(170, 381);
            this.listUsuarios.Sorted = true;
            this.listUsuarios.TabIndex = 0;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            this.listUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listUsuarios_KeyDown);
            this.listUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUsuarios_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblLocalidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblUsuarioDeRed);
            this.groupBox1.Controls.Add(this.lblExtension);
            this.groupBox1.Controls.Add(this.lblNumeroDeEmpleado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del usuario";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLocalidad.Location = new System.Drawing.Point(68, 129);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(0, 13);
            this.lblLocalidad.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Localidad:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDepartamento.Location = new System.Drawing.Point(82, 108);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(0, 13);
            this.lblDepartamento.TabIndex = 11;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(101, 89);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblCorreoElectronico.TabIndex = 10;
            // 
            // lblUsuarioDeRed
            // 
            this.lblUsuarioDeRed.AutoSize = true;
            this.lblUsuarioDeRed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsuarioDeRed.Location = new System.Drawing.Point(83, 71);
            this.lblUsuarioDeRed.Name = "lblUsuarioDeRed";
            this.lblUsuarioDeRed.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioDeRed.TabIndex = 9;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblExtension.Location = new System.Drawing.Point(33, 53);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(0, 13);
            this.lblExtension.TabIndex = 8;
            // 
            // lblNumeroDeEmpleado
            // 
            this.lblNumeroDeEmpleado.AutoSize = true;
            this.lblNumeroDeEmpleado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumeroDeEmpleado.Location = new System.Drawing.Point(82, 34);
            this.lblNumeroDeEmpleado.Name = "lblNumeroDeEmpleado";
            this.lblNumeroDeEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroDeEmpleado.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombre.Location = new System.Drawing.Point(52, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario de red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ext.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num. de Emp.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnImportarUsuario
            // 
            this.btnImportarUsuario.Image = global::Flow_Solver.Properties.Resources.exportar_16;
            this.btnImportarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarUsuario.Location = new System.Drawing.Point(304, 289);
            this.btnImportarUsuario.Name = "btnImportarUsuario";
            this.btnImportarUsuario.Size = new System.Drawing.Size(110, 34);
            this.btnImportarUsuario.TabIndex = 2;
            this.btnImportarUsuario.Text = " Cargar Usuario";
            this.btnImportarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarUsuario.UseVisualStyleBackColor = true;
            this.btnImportarUsuario.Click += new System.EventHandler(this.btnImportarUsuario_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Image = global::Flow_Solver.Properties.Resources.plus_16;
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUsuario.Location = new System.Drawing.Point(188, 289);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(110, 34);
            this.btnCrearUsuario.TabIndex = 3;
            this.btnCrearUsuario.Text = " Crear Usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click_1);
            // 
            // btnGuardarModificaciones
            // 
            this.btnGuardarModificaciones.Image = global::Flow_Solver.Properties.Resources.save_16;
            this.btnGuardarModificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarModificaciones.Location = new System.Drawing.Point(190, 249);
            this.btnGuardarModificaciones.Name = "btnGuardarModificaciones";
            this.btnGuardarModificaciones.Size = new System.Drawing.Size(224, 34);
            this.btnGuardarModificaciones.TabIndex = 4;
            this.btnGuardarModificaciones.Text = " Guardar Modificaciones";
            this.btnGuardarModificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarModificaciones.UseVisualStyleBackColor = true;
            this.btnGuardarModificaciones.Click += new System.EventHandler(this.btnGuardarModificaciones_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtLocalidad);
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Controls.Add(this.txtCorreoElectronico);
            this.groupBox2.Controls.Add(this.txtUsuarioDeRed);
            this.groupBox2.Controls.Add(this.txtExtension);
            this.groupBox2.Controls.Add(this.txtNumeroDeEmpleado);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(188, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar usuario";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(6, 175);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(212, 20);
            this.txtLocalidad.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtLocalidad, "Para cambiar este dato, acceda a la Tabla de Vinculacion en Configuracion");
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDepartamento.Location = new System.Drawing.Point(6, 149);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(212, 20);
            this.txtDepartamento.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDepartamento, "Cambia el departamento del usuario");
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(6, 123);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(212, 20);
            this.txtCorreoElectronico.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtCorreoElectronico, "Cambia el Email del usuario");
            // 
            // txtUsuarioDeRed
            // 
            this.txtUsuarioDeRed.Location = new System.Drawing.Point(6, 97);
            this.txtUsuarioDeRed.Name = "txtUsuarioDeRed";
            this.txtUsuarioDeRed.Size = new System.Drawing.Size(212, 20);
            this.txtUsuarioDeRed.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUsuarioDeRed, "Cambia el usuario de red");
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(6, 71);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(212, 20);
            this.txtExtension.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtExtension, "Cambia la extension telefonica del usuario");
            // 
            // txtNumeroDeEmpleado
            // 
            this.txtNumeroDeEmpleado.Location = new System.Drawing.Point(6, 45);
            this.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado";
            this.txtNumeroDeEmpleado.Size = new System.Drawing.Size(212, 20);
            this.txtNumeroDeEmpleado.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumeroDeEmpleado, "Cambia el numero del empleado");
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Cambia el nombre del usuario");
            // 
            // button1
            // 
            this.button1.Image = global::Flow_Solver.Properties.Resources.reload_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(14, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = " Recargar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Image = global::Flow_Solver.Properties.Resources.delete_16;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(104, 351);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(80, 28);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = " Eliminar";
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblUsuariosCargados
            // 
            this.lblUsuariosCargados.AutoSize = true;
            this.lblUsuariosCargados.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuariosCargados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuariosCargados.Location = new System.Drawing.Point(14, 325);
            this.lblUsuariosCargados.Name = "lblUsuariosCargados";
            this.lblUsuariosCargados.Size = new System.Drawing.Size(110, 13);
            this.lblUsuariosCargados.TabIndex = 8;
            this.lblUsuariosCargados.Text = "00 Usuarios cargados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::Flow_Solver.Properties.Resources.cancel_16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(334, 351);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 28);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cboxFiltroDeVista
            // 
            this.cboxFiltroDeVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFiltroDeVista.FormattingEnabled = true;
            this.cboxFiltroDeVista.Items.AddRange(new object[] {
            "Todos"});
            this.cboxFiltroDeVista.Location = new System.Drawing.Point(12, 20);
            this.cboxFiltroDeVista.Name = "cboxFiltroDeVista";
            this.cboxFiltroDeVista.Size = new System.Drawing.Size(170, 21);
            this.cboxFiltroDeVista.TabIndex = 10;
            this.cboxFiltroDeVista.SelectedIndexChanged += new System.EventHandler(this.cboxFiltroDeVista_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblUsuariosCargados);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.btnGuardarModificaciones);
            this.panel1.Controls.Add(this.btnCrearUsuario);
            this.panel1.Controls.Add(this.btnImportarUsuario);
            this.panel1.Location = new System.Drawing.Point(-2, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 391);
            this.panel1.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.Location = new System.Drawing.Point(12, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // lblBuscar_PlaceHolder
            // 
            this.lblBuscar_PlaceHolder.AutoSize = true;
            this.lblBuscar_PlaceHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuscar_PlaceHolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBuscar_PlaceHolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBuscar_PlaceHolder.Location = new System.Drawing.Point(15, 50);
            this.lblBuscar_PlaceHolder.Name = "lblBuscar_PlaceHolder";
            this.lblBuscar_PlaceHolder.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar_PlaceHolder.TabIndex = 14;
            this.lblBuscar_PlaceHolder.Text = "Buscar";
            this.lblBuscar_PlaceHolder.Click += new System.EventHandler(this.lblBuscar_PlaceHolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardaModifiacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // guardaModifiacionesToolStripMenuItem
            // 
            this.guardaModifiacionesToolStripMenuItem.Name = "guardaModifiacionesToolStripMenuItem";
            this.guardaModifiacionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardaModifiacionesToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.guardaModifiacionesToolStripMenuItem.Text = "Guarda modifiaciones";
            this.guardaModifiacionesToolStripMenuItem.Click += new System.EventHandler(this.btnGuardarModificaciones_Click);
            // 
            // backgroundWorker_WaitScreen
            // 
            this.backgroundWorker_WaitScreen.WorkerSupportsCancellation = true;
            this.backgroundWorker_WaitScreen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_WaitScreen_DoWork);
            // 
            // folderBrowserDialogEx1
            // 
            this.folderBrowserDialogEx1.Description = "";
            this.folderBrowserDialogEx1.RootFolder = System.Environment.SpecialFolder.Desktop;
            this.folderBrowserDialogEx1.SelectedPath = "";
            this.folderBrowserDialogEx1.ShowNewFolderButton = true;
            // 
            // lista_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(424, 522);
            this.Controls.Add(this.lblBuscar_PlaceHolder);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboxFiltroDeVista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "lista_usuarios";
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.lista_usuarios_Load);
            this.Shown += new System.EventHandler(this.lista_usuarios_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lista_usuarios_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuarioDeRed;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblNumeroDeEmpleado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Button btnImportarUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnGuardarModificaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtUsuarioDeRed;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtNumeroDeEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblUsuariosCargados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboxFiltroDeVista;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuscar_PlaceHolder;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardaModifiacionesToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_WaitScreen;
        private FolderBrowserDialog folderBrowserDialogEx1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}