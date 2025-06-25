namespace Flow_Solver
{
    partial class configuracion_inicial
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuracion_inicial));
            btnContinuar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            warningProvider = new System.Windows.Forms.ErrorProvider(components);
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            checkProvider = new System.Windows.Forms.ErrorProvider(components);
            menuConfiguraciones = new FlowControls.flTabMenuControl();
            tabPage_Servidor = new System.Windows.Forms.TabPage();
            flTextBoxLabelJoint3 = new FlowControls.flTextBoxLabelJoint();
            flTextBoxLabelJoint2 = new FlowControls.flTextBoxLabelJoint();
            btnProbarConexion = new System.Windows.Forms.Button();
            txtUsuarioServidor = new FlowControls.flTextBoxLabelJoint();
            flComboBoxLabelJoint1 = new FlowControls.flComboBoxLabelJoint();
            flSeparatorLine2 = new FlowControls.flSeparatorLine();
            flCustomLabel1 = new FlowControls.flCustomLabel();
            txtDireccionDelServidor = new FlowControls.flTextBoxLabelJoint();
            tabPage_Usuario = new System.Windows.Forms.TabPage();
            txtDomicilio = new FlowControls.flTextBoxLabelJoint();
            txtTelefono = new FlowControls.flTextBoxLabelJoint();
            txtEmail = new FlowControls.flTextBoxLabelJoint();
            txtSalarioPorPeriodo = new FlowControls.flTextBoxLabelJoint();
            cboxDepartamentoOrganizacional = new FlowControls.flComboBoxLabelJoint();
            txtPuestoOrganizacional = new FlowControls.flComboBoxLabelJoint();
            flTextBoxLabelJoint4 = new FlowControls.flTextBoxLabelJoint();
            txtFechaIngreso = new FlowControls.flTextBoxLabelJoint();
            txtEdad = new FlowControls.flTextBoxLabelJoint();
            flSeparatorLine1 = new FlowControls.flSeparatorLine();
            flCustomLabel2 = new FlowControls.flCustomLabel();
            flTextBoxLabelJoint1 = new FlowControls.flTextBoxLabelJoint();
            txtApellidos = new FlowControls.flTextBoxLabelJoint();
            txtNombre = new FlowControls.flTextBoxLabelJoint();
            tabPage_General = new System.Windows.Forms.TabPage();
            flSeparatorLine3 = new FlowControls.flSeparatorLine();
            flCustomLabel3 = new FlowControls.flCustomLabel();
            tabPage_Plantillas = new System.Windows.Forms.TabPage();
            imageList1 = new System.Windows.Forms.ImageList(components);
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)warningProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkProvider).BeginInit();
            menuConfiguraciones.SuspendLayout();
            tabPage_Servidor.SuspendLayout();
            tabPage_Usuario.SuspendLayout();
            tabPage_General.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(127, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(408, 38);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido a Flow Solver! ";
            // 
            // btnContinuar
            // 
            btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnContinuar.Image = Properties.Resources.save_16;
            btnContinuar.Location = new System.Drawing.Point(788, 509);
            btnContinuar.Margin = new System.Windows.Forms.Padding(4);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new System.Drawing.Size(94, 35);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = " Continuar";
            btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Image = Properties.Resources.cancel_16;
            btnCancelar.Location = new System.Drawing.Point(687, 509);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(94, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = " Cerrar";
            btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // warningProvider
            // 
            warningProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            warningProvider.ContainerControl = this;
            warningProvider.Icon = (System.Drawing.Icon)resources.GetObject("warningProvider.Icon");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (System.Drawing.Icon)resources.GetObject("errorProvider.Icon");
            // 
            // checkProvider
            // 
            checkProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            checkProvider.ContainerControl = this;
            checkProvider.Icon = (System.Drawing.Icon)resources.GetObject("checkProvider.Icon");
            // 
            // menuConfiguraciones
            // 
            menuConfiguraciones.Alignment = System.Windows.Forms.TabAlignment.Right;
            menuConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            menuConfiguraciones.ControlBackColor = System.Drawing.Color.Transparent;
            menuConfiguraciones.Controls.Add(tabPage_Servidor);
            menuConfiguraciones.Controls.Add(tabPage_Usuario);
            menuConfiguraciones.Controls.Add(tabPage_General);
            menuConfiguraciones.Controls.Add(tabPage_Plantillas);
            menuConfiguraciones.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            menuConfiguraciones.ForeSelectionColor = System.Drawing.Color.White;
            menuConfiguraciones.ForeUnselectedColor = System.Drawing.Color.DimGray;
            menuConfiguraciones.HoverColor = System.Drawing.Color.FromArgb(50, 200, 200, 200);
            menuConfiguraciones.ImageList = imageList1;
            menuConfiguraciones.ItemSize = new System.Drawing.Size(40, 150);
            menuConfiguraciones.Location = new System.Drawing.Point(12, 116);
            menuConfiguraciones.Multiline = true;
            menuConfiguraciones.Name = "menuConfiguraciones";
            menuConfiguraciones.SelectedIndex = 0;
            menuConfiguraciones.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            menuConfiguraciones.Size = new System.Drawing.Size(870, 386);
            menuConfiguraciones.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            menuConfiguraciones.TabIndex = 3;
            menuConfiguraciones.UnselectionColor = System.Drawing.Color.LightGray;
            // 
            // tabPage_Servidor
            // 
            tabPage_Servidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPage_Servidor.Controls.Add(flTextBoxLabelJoint3);
            tabPage_Servidor.Controls.Add(flTextBoxLabelJoint2);
            tabPage_Servidor.Controls.Add(btnProbarConexion);
            tabPage_Servidor.Controls.Add(txtUsuarioServidor);
            tabPage_Servidor.Controls.Add(flComboBoxLabelJoint1);
            tabPage_Servidor.Controls.Add(flSeparatorLine2);
            tabPage_Servidor.Controls.Add(flCustomLabel1);
            tabPage_Servidor.Controls.Add(txtDireccionDelServidor);
            tabPage_Servidor.ImageIndex = 0;
            tabPage_Servidor.Location = new System.Drawing.Point(4, 4);
            tabPage_Servidor.Name = "tabPage_Servidor";
            tabPage_Servidor.Padding = new System.Windows.Forms.Padding(3);
            tabPage_Servidor.Size = new System.Drawing.Size(712, 378);
            tabPage_Servidor.TabIndex = 3;
            tabPage_Servidor.Text = "Servidor";
            tabPage_Servidor.UseVisualStyleBackColor = true;
            // 
            // flTextBoxLabelJoint3
            // 
            flTextBoxLabelJoint3.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            flTextBoxLabelJoint3.InputContentType = FlowControls.InputMode.GENERAL;
            flTextBoxLabelJoint3.Label = "* Puerto:";
            flTextBoxLabelJoint3.Location = new System.Drawing.Point(456, 121);
            flTextBoxLabelJoint3.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint3.Name = "flTextBoxLabelJoint3";
            flTextBoxLabelJoint3.PasswordChar = '●';
            flTextBoxLabelJoint3.Placeholder = "";
            flTextBoxLabelJoint3.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint3.Size = new System.Drawing.Size(185, 30);
            flTextBoxLabelJoint3.TabIndex = 72;
            flTextBoxLabelJoint3.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint3.TextBoxWidth = 60;
            flTextBoxLabelJoint3.Value = "3306";
            // 
            // flTextBoxLabelJoint2
            // 
            flTextBoxLabelJoint2.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            flTextBoxLabelJoint2.InputContentType = FlowControls.InputMode.GENERAL;
            flTextBoxLabelJoint2.Label = "* Contraseña:";
            flTextBoxLabelJoint2.Location = new System.Drawing.Point(23, 193);
            flTextBoxLabelJoint2.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint2.Name = "flTextBoxLabelJoint2";
            flTextBoxLabelJoint2.PasswordChar = '●';
            flTextBoxLabelJoint2.Placeholder = "Contraseña del usuario del servidor";
            flTextBoxLabelJoint2.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint2.Size = new System.Drawing.Size(427, 30);
            flTextBoxLabelJoint2.TabIndex = 71;
            flTextBoxLabelJoint2.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint2.TextBoxWidth = 200;
            flTextBoxLabelJoint2.Value = "";
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProbarConexion.Image = Properties.Resources.save_16;
            btnProbarConexion.Location = new System.Drawing.Point(532, 334);
            btnProbarConexion.Margin = new System.Windows.Forms.Padding(4);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new System.Drawing.Size(171, 35);
            btnProbarConexion.TabIndex = 7;
            btnProbarConexion.Text = " Probar Conexion";
            btnProbarConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnProbarConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioServidor
            // 
            txtUsuarioServidor.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtUsuarioServidor.InputContentType = FlowControls.InputMode.GENERAL;
            txtUsuarioServidor.Label = "* Usuario:";
            txtUsuarioServidor.Location = new System.Drawing.Point(24, 157);
            txtUsuarioServidor.MinimumSize = new System.Drawing.Size(100, 30);
            txtUsuarioServidor.Name = "txtUsuarioServidor";
            txtUsuarioServidor.PasswordChar = '●';
            txtUsuarioServidor.Placeholder = "Usuario del servidor";
            txtUsuarioServidor.RootLineColor = System.Drawing.Color.Gray;
            txtUsuarioServidor.Size = new System.Drawing.Size(426, 30);
            txtUsuarioServidor.TabIndex = 70;
            txtUsuarioServidor.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtUsuarioServidor.TextBoxWidth = 200;
            txtUsuarioServidor.Value = "";
            // 
            // flComboBoxLabelJoint1
            // 
            flComboBoxLabelJoint1.ComboBoxBackColor = System.Drawing.SystemColors.Window;
            flComboBoxLabelJoint1.ComboBoxWidth = 200;
            flComboBoxLabelJoint1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            flComboBoxLabelJoint1.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            flComboBoxLabelJoint1.Items.AddRange(new object[] { "(Seleccione un elemento...)", "Base de datos de Access", "MySQL Database" });
            flComboBoxLabelJoint1.Label = "* Tipo de Servidor:";
            flComboBoxLabelJoint1.Location = new System.Drawing.Point(297, 79);
            flComboBoxLabelJoint1.MinimumSize = new System.Drawing.Size(150, 30);
            flComboBoxLabelJoint1.Name = "flComboBoxLabelJoint1";
            flComboBoxLabelJoint1.RootLineColor = System.Drawing.Color.Gray;
            flComboBoxLabelJoint1.Size = new System.Drawing.Size(379, 30);
            flComboBoxLabelJoint1.TabIndex = 68;
            flComboBoxLabelJoint1.Value = "(Seleccione un elemento...)";
            // 
            // flSeparatorLine2
            // 
            flSeparatorLine2.BackColor = System.Drawing.Color.White;
            flSeparatorLine2.LineColor = System.Drawing.Color.Gray;
            flSeparatorLine2.LineOrientation = System.Windows.Forms.Orientation.Horizontal;
            flSeparatorLine2.LineThickness = 1;
            flSeparatorLine2.Location = new System.Drawing.Point(23, 63);
            flSeparatorLine2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            flSeparatorLine2.MinimumSize = new System.Drawing.Size(0, 6);
            flSeparatorLine2.Name = "flSeparatorLine2";
            flSeparatorLine2.Size = new System.Drawing.Size(664, 10);
            flSeparatorLine2.TabIndex = 67;
            flSeparatorLine2.Text = "flSeparatorLine2";
            // 
            // flCustomLabel1
            // 
            flCustomLabel1.AutoSize = true;
            flCustomLabel1.BackColor = System.Drawing.Color.White;
            flCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            flCustomLabel1.ImagePadding = 5;
            flCustomLabel1.LeftImage = Properties.Resources.database2_32;
            flCustomLabel1.Location = new System.Drawing.Point(24, 19);
            flCustomLabel1.Name = "flCustomLabel1";
            flCustomLabel1.Size = new System.Drawing.Size(374, 32);
            flCustomLabel1.TabIndex = 1;
            flCustomLabel1.Text = "Datos de Conexion al Servidor";
            // 
            // txtDireccionDelServidor
            // 
            txtDireccionDelServidor.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtDireccionDelServidor.InputContentType = FlowControls.InputMode.GENERAL;
            txtDireccionDelServidor.Label = "* Direccion del Servidor:";
            txtDireccionDelServidor.Location = new System.Drawing.Point(23, 121);
            txtDireccionDelServidor.MinimumSize = new System.Drawing.Size(100, 30);
            txtDireccionDelServidor.Name = "txtDireccionDelServidor";
            txtDireccionDelServidor.PasswordChar = '●';
            txtDireccionDelServidor.Placeholder = "";
            txtDireccionDelServidor.RootLineColor = System.Drawing.Color.Gray;
            txtDireccionDelServidor.Size = new System.Drawing.Size(427, 30);
            txtDireccionDelServidor.TabIndex = 0;
            txtDireccionDelServidor.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtDireccionDelServidor.TextBoxWidth = 200;
            txtDireccionDelServidor.Value = "129.0.0.1";
            // 
            // tabPage_Usuario
            // 
            tabPage_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPage_Usuario.Controls.Add(txtDomicilio);
            tabPage_Usuario.Controls.Add(txtTelefono);
            tabPage_Usuario.Controls.Add(txtEmail);
            tabPage_Usuario.Controls.Add(txtSalarioPorPeriodo);
            tabPage_Usuario.Controls.Add(cboxDepartamentoOrganizacional);
            tabPage_Usuario.Controls.Add(txtPuestoOrganizacional);
            tabPage_Usuario.Controls.Add(flTextBoxLabelJoint4);
            tabPage_Usuario.Controls.Add(txtFechaIngreso);
            tabPage_Usuario.Controls.Add(txtEdad);
            tabPage_Usuario.Controls.Add(flSeparatorLine1);
            tabPage_Usuario.Controls.Add(flCustomLabel2);
            tabPage_Usuario.Controls.Add(flTextBoxLabelJoint1);
            tabPage_Usuario.Controls.Add(txtApellidos);
            tabPage_Usuario.Controls.Add(txtNombre);
            tabPage_Usuario.ImageIndex = 1;
            tabPage_Usuario.Location = new System.Drawing.Point(4, 4);
            tabPage_Usuario.Name = "tabPage_Usuario";
            tabPage_Usuario.Padding = new System.Windows.Forms.Padding(3);
            tabPage_Usuario.Size = new System.Drawing.Size(712, 378);
            tabPage_Usuario.TabIndex = 1;
            tabPage_Usuario.Text = "Usuario";
            tabPage_Usuario.UseVisualStyleBackColor = true;
            // 
            // txtDomicilio
            // 
            txtDomicilio.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtDomicilio.InputContentType = FlowControls.InputMode.GENERAL;
            txtDomicilio.Label = "* Domicilio:";
            txtDomicilio.Location = new System.Drawing.Point(399, 280);
            txtDomicilio.MinimumSize = new System.Drawing.Size(100, 30);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.PasswordChar = '●';
            txtDomicilio.Placeholder = "Domicilio particular";
            txtDomicilio.RootLineColor = System.Drawing.Color.Gray;
            txtDomicilio.Size = new System.Drawing.Size(288, 30);
            txtDomicilio.TabIndex = 83;
            txtDomicilio.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtDomicilio.TextBoxWidth = 200;
            txtDomicilio.Value = "";
            // 
            // txtTelefono
            // 
            txtTelefono.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtTelefono.InputContentType = FlowControls.InputMode.NUMBERS;
            txtTelefono.Label = "* Telefono:";
            txtTelefono.Location = new System.Drawing.Point(399, 244);
            txtTelefono.MinimumSize = new System.Drawing.Size(100, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '●';
            txtTelefono.Placeholder = "Telefono de contacto";
            txtTelefono.RootLineColor = System.Drawing.Color.Gray;
            txtTelefono.Size = new System.Drawing.Size(288, 30);
            txtTelefono.TabIndex = 82;
            txtTelefono.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtTelefono.TextBoxWidth = 200;
            txtTelefono.Value = "";
            // 
            // txtEmail
            // 
            txtEmail.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtEmail.InputContentType = FlowControls.InputMode.ALPHABETIC;
            txtEmail.Label = "* Email:";
            txtEmail.Location = new System.Drawing.Point(399, 208);
            txtEmail.MinimumSize = new System.Drawing.Size(100, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '●';
            txtEmail.Placeholder = "Correo electronico";
            txtEmail.RootLineColor = System.Drawing.Color.Gray;
            txtEmail.Size = new System.Drawing.Size(288, 30);
            txtEmail.TabIndex = 81;
            txtEmail.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtEmail.TextBoxWidth = 200;
            txtEmail.Value = "";
            // 
            // txtSalarioPorPeriodo
            // 
            txtSalarioPorPeriodo.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtSalarioPorPeriodo.InputContentType = FlowControls.InputMode.GENERAL;
            txtSalarioPorPeriodo.Label = "* Salario:";
            txtSalarioPorPeriodo.Location = new System.Drawing.Point(399, 172);
            txtSalarioPorPeriodo.MinimumSize = new System.Drawing.Size(100, 30);
            txtSalarioPorPeriodo.Name = "txtSalarioPorPeriodo";
            txtSalarioPorPeriodo.PasswordChar = '●';
            txtSalarioPorPeriodo.Placeholder = "Salario por periodo";
            txtSalarioPorPeriodo.RootLineColor = System.Drawing.Color.Gray;
            txtSalarioPorPeriodo.Size = new System.Drawing.Size(288, 30);
            txtSalarioPorPeriodo.TabIndex = 80;
            txtSalarioPorPeriodo.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtSalarioPorPeriodo.TextBoxWidth = 200;
            txtSalarioPorPeriodo.Value = "";
            // 
            // cboxDepartamentoOrganizacional
            // 
            cboxDepartamentoOrganizacional.ComboBoxBackColor = System.Drawing.SystemColors.Window;
            cboxDepartamentoOrganizacional.ComboBoxWidth = 200;
            cboxDepartamentoOrganizacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxDepartamentoOrganizacional.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            cboxDepartamentoOrganizacional.Items.AddRange(new object[] { "(Seleccione un elemento...)" });
            cboxDepartamentoOrganizacional.Label = "* Dpto.:";
            cboxDepartamentoOrganizacional.Location = new System.Drawing.Point(399, 127);
            cboxDepartamentoOrganizacional.MinimumSize = new System.Drawing.Size(150, 30);
            cboxDepartamentoOrganizacional.Name = "cboxDepartamentoOrganizacional";
            cboxDepartamentoOrganizacional.RootLineColor = System.Drawing.Color.Gray;
            cboxDepartamentoOrganizacional.Size = new System.Drawing.Size(288, 30);
            cboxDepartamentoOrganizacional.TabIndex = 79;
            cboxDepartamentoOrganizacional.Value = "(Seleccione un elemento...)";
            // 
            // txtPuestoOrganizacional
            // 
            txtPuestoOrganizacional.ComboBoxBackColor = System.Drawing.SystemColors.Window;
            txtPuestoOrganizacional.ComboBoxWidth = 200;
            txtPuestoOrganizacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtPuestoOrganizacional.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtPuestoOrganizacional.Items.AddRange(new object[] { "(Seleccione un elemento...)" });
            txtPuestoOrganizacional.Label = "* Puesto:";
            txtPuestoOrganizacional.Location = new System.Drawing.Point(24, 316);
            txtPuestoOrganizacional.MinimumSize = new System.Drawing.Size(150, 30);
            txtPuestoOrganizacional.Name = "txtPuestoOrganizacional";
            txtPuestoOrganizacional.RootLineColor = System.Drawing.Color.Gray;
            txtPuestoOrganizacional.Size = new System.Drawing.Size(369, 30);
            txtPuestoOrganizacional.TabIndex = 78;
            txtPuestoOrganizacional.Value = "(Seleccione un elemento...)";
            // 
            // flTextBoxLabelJoint4
            // 
            flTextBoxLabelJoint4.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            flTextBoxLabelJoint4.InputContentType = FlowControls.InputMode.GENERAL;
            flTextBoxLabelJoint4.Label = "* Fecha de Nacimiento:";
            flTextBoxLabelJoint4.Location = new System.Drawing.Point(23, 280);
            flTextBoxLabelJoint4.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint4.Name = "flTextBoxLabelJoint4";
            flTextBoxLabelJoint4.PasswordChar = '●';
            flTextBoxLabelJoint4.Placeholder = "Fecha de nacimiento";
            flTextBoxLabelJoint4.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint4.Size = new System.Drawing.Size(370, 30);
            flTextBoxLabelJoint4.TabIndex = 77;
            flTextBoxLabelJoint4.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint4.TextBoxWidth = 200;
            flTextBoxLabelJoint4.Value = "";
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtFechaIngreso.InputContentType = FlowControls.InputMode.GENERAL;
            txtFechaIngreso.Label = "* Fecha de Ingreso:";
            txtFechaIngreso.Location = new System.Drawing.Point(24, 244);
            txtFechaIngreso.MinimumSize = new System.Drawing.Size(100, 30);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.PasswordChar = '●';
            txtFechaIngreso.Placeholder = "Fecha de ingreso";
            txtFechaIngreso.RootLineColor = System.Drawing.Color.Gray;
            txtFechaIngreso.Size = new System.Drawing.Size(370, 30);
            txtFechaIngreso.TabIndex = 76;
            txtFechaIngreso.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtFechaIngreso.TextBoxWidth = 200;
            txtFechaIngreso.Value = "";
            // 
            // txtEdad
            // 
            txtEdad.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtEdad.InputContentType = FlowControls.InputMode.GENERAL;
            txtEdad.Label = "* Edad:";
            txtEdad.Location = new System.Drawing.Point(23, 208);
            txtEdad.MinimumSize = new System.Drawing.Size(100, 30);
            txtEdad.Name = "txtEdad";
            txtEdad.PasswordChar = '●';
            txtEdad.Placeholder = "Edad";
            txtEdad.RootLineColor = System.Drawing.Color.Gray;
            txtEdad.Size = new System.Drawing.Size(370, 30);
            txtEdad.TabIndex = 75;
            txtEdad.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtEdad.TextBoxWidth = 75;
            txtEdad.Value = "";
            // 
            // flSeparatorLine1
            // 
            flSeparatorLine1.BackColor = System.Drawing.Color.White;
            flSeparatorLine1.LineColor = System.Drawing.Color.Gray;
            flSeparatorLine1.LineOrientation = System.Windows.Forms.Orientation.Horizontal;
            flSeparatorLine1.LineThickness = 1;
            flSeparatorLine1.Location = new System.Drawing.Point(23, 63);
            flSeparatorLine1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            flSeparatorLine1.MinimumSize = new System.Drawing.Size(0, 6);
            flSeparatorLine1.Name = "flSeparatorLine1";
            flSeparatorLine1.Size = new System.Drawing.Size(664, 10);
            flSeparatorLine1.TabIndex = 74;
            flSeparatorLine1.Text = "flSeparatorLine1";
            // 
            // flCustomLabel2
            // 
            flCustomLabel2.AutoSize = true;
            flCustomLabel2.BackColor = System.Drawing.Color.White;
            flCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 18F);
            flCustomLabel2.ImagePadding = 5;
            flCustomLabel2.LeftImage = Properties.Resources.user_32;
            flCustomLabel2.Location = new System.Drawing.Point(24, 19);
            flCustomLabel2.Name = "flCustomLabel2";
            flCustomLabel2.Size = new System.Drawing.Size(389, 32);
            flCustomLabel2.TabIndex = 73;
            flCustomLabel2.Text = "Datos del Usuario en el Sistema";
            // 
            // flTextBoxLabelJoint1
            // 
            flTextBoxLabelJoint1.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            flTextBoxLabelJoint1.InputContentType = FlowControls.InputMode.GENERAL;
            flTextBoxLabelJoint1.Label = "Usuario existente:";
            flTextBoxLabelJoint1.Location = new System.Drawing.Point(298, 79);
            flTextBoxLabelJoint1.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint1.Name = "flTextBoxLabelJoint1";
            flTextBoxLabelJoint1.PasswordChar = '●';
            flTextBoxLabelJoint1.Placeholder = "En caso de contar con un usuario...";
            flTextBoxLabelJoint1.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint1.Size = new System.Drawing.Size(335, 30);
            flTextBoxLabelJoint1.TabIndex = 72;
            flTextBoxLabelJoint1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint1.TextBoxWidth = 200;
            flTextBoxLabelJoint1.Value = "";
            // 
            // txtApellidos
            // 
            txtApellidos.EntryFont = new System.Drawing.Font("Segoe UI", 9F);
            txtApellidos.InputContentType = FlowControls.InputMode.GENERAL;
            txtApellidos.Label = "* Apellidos:";
            txtApellidos.Location = new System.Drawing.Point(23, 172);
            txtApellidos.MinimumSize = new System.Drawing.Size(100, 30);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PasswordChar = '●';
            txtApellidos.Placeholder = "Apellidos del empleado";
            txtApellidos.RootLineColor = System.Drawing.Color.Gray;
            txtApellidos.Size = new System.Drawing.Size(370, 30);
            txtApellidos.TabIndex = 71;
            txtApellidos.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtApellidos.TextBoxWidth = 250;
            txtApellidos.Value = "";
            // 
            // txtNombre
            // 
            txtNombre.EntryFont = new System.Drawing.Font("Consolas", 9F);
            txtNombre.InputContentType = FlowControls.InputMode.GENERAL;
            txtNombre.Label = "* Nombres:";
            txtNombre.Location = new System.Drawing.Point(23, 127);
            txtNombre.MinimumSize = new System.Drawing.Size(100, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '●';
            txtNombre.Placeholder = "Nombres del empleado";
            txtNombre.RootLineColor = System.Drawing.Color.Gray;
            txtNombre.Size = new System.Drawing.Size(370, 30);
            txtNombre.TabIndex = 69;
            txtNombre.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtNombre.TextBoxWidth = 250;
            txtNombre.Value = "";
            // 
            // tabPage_General
            // 
            tabPage_General.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPage_General.Controls.Add(flSeparatorLine3);
            tabPage_General.Controls.Add(flCustomLabel3);
            tabPage_General.Location = new System.Drawing.Point(4, 4);
            tabPage_General.Name = "tabPage_General";
            tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            tabPage_General.Size = new System.Drawing.Size(712, 378);
            tabPage_General.TabIndex = 0;
            tabPage_General.Text = "General";
            tabPage_General.UseVisualStyleBackColor = true;
            // 
            // flSeparatorLine3
            // 
            flSeparatorLine3.BackColor = System.Drawing.Color.White;
            flSeparatorLine3.LineColor = System.Drawing.Color.Gray;
            flSeparatorLine3.LineOrientation = System.Windows.Forms.Orientation.Horizontal;
            flSeparatorLine3.LineThickness = 1;
            flSeparatorLine3.Location = new System.Drawing.Point(23, 63);
            flSeparatorLine3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            flSeparatorLine3.MinimumSize = new System.Drawing.Size(0, 6);
            flSeparatorLine3.Name = "flSeparatorLine3";
            flSeparatorLine3.Size = new System.Drawing.Size(664, 10);
            flSeparatorLine3.TabIndex = 76;
            flSeparatorLine3.Text = "flSeparatorLine3";
            // 
            // flCustomLabel3
            // 
            flCustomLabel3.AutoSize = true;
            flCustomLabel3.BackColor = System.Drawing.Color.White;
            flCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 18F);
            flCustomLabel3.ImagePadding = 5;
            flCustomLabel3.LeftImage = Properties.Resources.user_32;
            flCustomLabel3.Location = new System.Drawing.Point(24, 19);
            flCustomLabel3.Name = "flCustomLabel3";
            flCustomLabel3.Size = new System.Drawing.Size(268, 32);
            flCustomLabel3.TabIndex = 75;
            flCustomLabel3.Text = "Informacion General";
            // 
            // tabPage_Plantillas
            // 
            tabPage_Plantillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPage_Plantillas.Location = new System.Drawing.Point(4, 4);
            tabPage_Plantillas.Name = "tabPage_Plantillas";
            tabPage_Plantillas.Padding = new System.Windows.Forms.Padding(3);
            tabPage_Plantillas.Size = new System.Drawing.Size(712, 378);
            tabPage_Plantillas.TabIndex = 2;
            tabPage_Plantillas.Text = "Plantillas";
            tabPage_Plantillas.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "database2-32.png");
            imageList1.Images.SetKeyName(1, "user-32.png");
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(895, 113);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(4, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(123, 98);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(132, 74);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(336, 15);
            label2.TabIndex = 1;
            label2.Text = "Debemos preprar la configuracion antes de iniciar el programa";
            // 
            // configuracion_inicial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(895, 557);
            Controls.Add(panel2);
            Controls.Add(btnCancelar);
            Controls.Add(menuConfiguraciones);
            Controls.Add(btnContinuar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "configuracion_inicial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Flow Solver - Configuracion Inicial";
            TopMost = true;
            FormClosed += configuracion_inicial_FormClosed;
            Load += configuracion_inicial_Load;
            ((System.ComponentModel.ISupportInitialize)warningProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkProvider).EndInit();
            menuConfiguraciones.ResumeLayout(false);
            tabPage_Servidor.ResumeLayout(false);
            tabPage_Servidor.PerformLayout();
            tabPage_Usuario.ResumeLayout(false);
            tabPage_Usuario.PerformLayout();
            tabPage_General.ResumeLayout(false);
            tabPage_General.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider warningProvider;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider checkProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private FlowControls.flTabMenuControl menuConfiguraciones;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_Usuario;
        private System.Windows.Forms.TabPage tabPage_Plantillas;
        private System.Windows.Forms.TabPage tabPage_Servidor;
        private FlowControls.flCustomLabel flCustomLabel1;
        private FlowControls.flTextBoxLabelJoint txtDireccionDelServidor;
        private FlowControls.flComboBoxLabelJoint flComboBoxLabelJoint1;
        private FlowControls.flSeparatorLine flSeparatorLine2;
        private FlowControls.flTextBoxLabelJoint txtUsuarioServidor;
        private System.Windows.Forms.Button btnProbarConexion;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint3;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint2;
        private FlowControls.flTextBoxLabelJoint txtFechaIngreso;
        private FlowControls.flTextBoxLabelJoint txtEdad;
        private FlowControls.flSeparatorLine flSeparatorLine1;
        private FlowControls.flCustomLabel flCustomLabel2;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint1;
        private FlowControls.flTextBoxLabelJoint txtApellidos;
        private FlowControls.flTextBoxLabelJoint txtNombre;
        private FlowControls.flComboBoxLabelJoint txtPuestoOrganizacional;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint4;
        private FlowControls.flComboBoxLabelJoint cboxDepartamentoOrganizacional;
        private FlowControls.flTextBoxLabelJoint txtSalarioPorPeriodo;
        private FlowControls.flTextBoxLabelJoint txtEmail;
        private FlowControls.flTextBoxLabelJoint txtTelefono;
        private FlowControls.flTextBoxLabelJoint txtDomicilio;
        private System.Windows.Forms.ImageList imageList1;
        private FlowControls.flSeparatorLine flSeparatorLine3;
        private FlowControls.flCustomLabel flCustomLabel3;
    }
}