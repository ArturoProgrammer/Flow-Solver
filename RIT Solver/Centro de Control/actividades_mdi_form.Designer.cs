using FlowControls;

namespace Flow_Solver
{
    partial class actividades_mdi_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actividades_mdi_form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpBtn_Completar = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtn_Desmarcar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportarComoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporarComoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.lblNombre = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblHostname = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblModelo = new System.Windows.Forms.ToolStripLabel();
            this.lblTipoDeEquipo = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblJobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new FlowControls.flCustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPreviewSelection = new System.Windows.Forms.DataGridView();
            this.Completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Hostname = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PDFRitName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Evidencia = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEquipoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquipoSeleccionadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarEquipoComoCompletadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.generarRITParaElEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartAvances = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensajeDePrivacidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pboxSelloDeActividad = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResponsableDeActividad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAutorDeActividad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaDeTerminoPrevista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaDeInicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.rbtnReporteCerrado_No = new System.Windows.Forms.RadioButton();
            this.rbtnReporteCerrado_Si = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFallaReportada = new System.Windows.Forms.TextBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.txtCentroDeServicio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtLinea7 = new System.Windows.Forms.TextBox();
            this.txtLinea6 = new System.Windows.Forms.TextBox();
            this.txtLinea5 = new System.Windows.Forms.TextBox();
            this.txtLinea4 = new System.Windows.Forms.TextBox();
            this.txtLinea3 = new System.Windows.Forms.TextBox();
            this.txtLinea2 = new System.Windows.Forms.TextBox();
            this.txtLinea1 = new System.Windows.Forms.TextBox();
            this.pboxPlantillaRIT = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirOtroEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElEquipoSelecciondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquipoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarLoteDeImpresionDeRITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.enviarCorreoDeAvancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDuplicadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarActividadComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.generarInformeDeActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bgworkerRitMakerProcess = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSelection)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvances)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSelloDeActividad)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlantillaRIT)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator11,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStrpBtn_Eliminar,
            this.toolStrpBtn_Modificar,
            this.toolStripSeparator2,
            this.toolStrpBtn_Completar,
            this.toolStrpBtn_Desmarcar,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton7,
            this.lblNombre,
            this.toolStripLabel2,
            this.lblHostname,
            this.toolStripLabel1,
            this.lblModelo,
            this.lblTipoDeEquipo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(833, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Flow_Solver.Properties.Resources.close1_32;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(43, 39);
            this.toolStripButton4.Text = "Cerrar";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Flow_Solver.Properties.Resources.save2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 39);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Flow_Solver.Properties.Resources.add;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 39);
            this.toolStripButton3.Text = "Añadir";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrpBtn_Eliminar
            // 
            this.toolStrpBtn_Eliminar.Image = global::Flow_Solver.Properties.Resources.eliminate_64;
            this.toolStrpBtn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_Eliminar.Name = "toolStrpBtn_Eliminar";
            this.toolStrpBtn_Eliminar.Size = new System.Drawing.Size(54, 39);
            this.toolStrpBtn_Eliminar.Text = "Eliminar";
            this.toolStrpBtn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtn_Eliminar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStrpBtn_Modificar
            // 
            this.toolStrpBtn_Modificar.Enabled = false;
            this.toolStrpBtn_Modificar.Image = global::Flow_Solver.Properties.Resources.edit3;
            this.toolStrpBtn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_Modificar.Name = "toolStrpBtn_Modificar";
            this.toolStrpBtn_Modificar.Size = new System.Drawing.Size(62, 39);
            this.toolStrpBtn_Modificar.Text = "Modificar";
            this.toolStrpBtn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtn_Modificar.Click += new System.EventHandler(this.editarEquipoSeleccionadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStrpBtn_Completar
            // 
            this.toolStrpBtn_Completar.Enabled = false;
            this.toolStrpBtn_Completar.Image = global::Flow_Solver.Properties.Resources._checked;
            this.toolStrpBtn_Completar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_Completar.Name = "toolStrpBtn_Completar";
            this.toolStrpBtn_Completar.Size = new System.Drawing.Size(67, 39);
            this.toolStrpBtn_Completar.Text = "Completar";
            this.toolStrpBtn_Completar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtn_Completar.Click += new System.EventHandler(this.completarEquipoToolStripMenuItem_Click);
            // 
            // toolStrpBtn_Desmarcar
            // 
            this.toolStrpBtn_Desmarcar.Enabled = false;
            this.toolStrpBtn_Desmarcar.Image = global::Flow_Solver.Properties.Resources._unchecked;
            this.toolStrpBtn_Desmarcar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_Desmarcar.Name = "toolStrpBtn_Desmarcar";
            this.toolStrpBtn_Desmarcar.Size = new System.Drawing.Size(67, 39);
            this.toolStrpBtn_Desmarcar.Text = "Desmarcar";
            this.toolStrpBtn_Desmarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtn_Desmarcar.Click += new System.EventHandler(this.toolStrpBtn_Desmarcar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarComoExcelToolStripMenuItem,
            this.exporarComoPDFToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Flow_Solver.Properties.Resources.exportar_16;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(73, 39);
            this.toolStripSplitButton1.Text = "Exportar...";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exportarComoExcelToolStripMenuItem
            // 
            this.exportarComoExcelToolStripMenuItem.Enabled = false;
            this.exportarComoExcelToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.xls_file_16;
            this.exportarComoExcelToolStripMenuItem.Name = "exportarComoExcelToolStripMenuItem";
            this.exportarComoExcelToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exportarComoExcelToolStripMenuItem.Text = "Exportar como Excel";
            this.exportarComoExcelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // exporarComoPDFToolStripMenuItem
            // 
            this.exporarComoPDFToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.pdf_16;
            this.exporarComoPDFToolStripMenuItem.Name = "exporarComoPDFToolStripMenuItem";
            this.exporarComoPDFToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exporarComoPDFToolStripMenuItem.Text = "Exporar como PDF";
            this.exporarComoPDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = global::Flow_Solver.Properties.Resources.correo_electronico;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(43, 39);
            this.toolStripButton2.Text = "Enviar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.enviarCorreoDeAvancesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::Flow_Solver.Properties.Resources.printer_24;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(53, 39);
            this.toolStripButton7.Text = "Informe";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.generarInformeDeActividadToolStripMenuItem_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 39);
            this.lblNombre.Text = "%NOMBRE%";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 39);
            this.toolStripLabel2.Text = "de";
            // 
            // lblHostname
            // 
            this.lblHostname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblHostname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(91, 39);
            this.lblHostname.Text = "%HOSTNAME%";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 39);
            this.toolStripLabel1.Text = " ";
            // 
            // lblModelo
            // 
            this.lblModelo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(76, 15);
            this.lblModelo.Text = "%MODELO%";
            // 
            // lblTipoDeEquipo
            // 
            this.lblTipoDeEquipo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTipoDeEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTipoDeEquipo.Name = "lblTipoDeEquipo";
            this.lblTipoDeEquipo.Size = new System.Drawing.Size(52, 15);
            this.lblTipoDeEquipo.Text = "%TIPO%";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblJobStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(35, 17);
            this.lblJobStatus.Text = "Listo!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DisplayStyle = FlowControls.TabStyle.VisualStudio;
            // 
            // 
            // 
            this.tabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.tabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.tabControl1.DisplayStyleProvider.FocusTrack = false;
            this.tabControl1.DisplayStyleProvider.HotTrack = true;
            this.tabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabControl1.DisplayStyleProvider.Opacity = 1F;
            this.tabControl1.DisplayStyleProvider.Overlap = 7;
            this.tabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(14, 1);
            this.tabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.tabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.tabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 410);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPreviewSelection);
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Progreso de Actividad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPreviewSelection
            // 
            this.dgvPreviewSelection.AllowUserToAddRows = false;
            this.dgvPreviewSelection.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreviewSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreviewSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Completado,
            this.NoItem,
            this.Nombre,
            this.NumEmpleado,
            this.Ext,
            this.RedUser,
            this.Mail,
            this.Hostname,
            this.TipoEquipo,
            this.NoSerie,
            this.Marca,
            this.Modelo,
            this.Ubicacion,
            this.Departamento,
            this.Comentarios,
            this.TicketID,
            this.PDFRitName,
            this.Evidencia,
            this.Notas,
            this.HASH});
            this.dgvPreviewSelection.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreviewSelection.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreviewSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreviewSelection.Location = new System.Drawing.Point(3, 3);
            this.dgvPreviewSelection.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPreviewSelection.MultiSelect = false;
            this.dgvPreviewSelection.Name = "dgvPreviewSelection";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreviewSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPreviewSelection.RowHeadersWidth = 51;
            this.dgvPreviewSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewSelection.Size = new System.Drawing.Size(819, 355);
            this.dgvPreviewSelection.TabIndex = 1;
            this.dgvPreviewSelection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviewSelection_CellContentClick);
            this.dgvPreviewSelection.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviewSelection_CellValueChanged);
            this.dgvPreviewSelection.SelectionChanged += new System.EventHandler(this.dgvPreviewSelection_SelectionChanged);
            this.dgvPreviewSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPreviewSelection_MouseDown);
            // 
            // Completado
            // 
            this.Completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Completado.HeaderText = "Completado";
            this.Completado.MinimumWidth = 6;
            this.Completado.Name = "Completado";
            this.Completado.ReadOnly = true;
            this.Completado.Width = 69;
            // 
            // NoItem
            // 
            this.NoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NoItem.HeaderText = "No.";
            this.NoItem.MinimumWidth = 6;
            this.NoItem.Name = "NoItem";
            this.NoItem.ReadOnly = true;
            this.NoItem.Width = 49;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // NumEmpleado
            // 
            this.NumEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumEmpleado.HeaderText = "No. Emp.";
            this.NumEmpleado.MinimumWidth = 6;
            this.NumEmpleado.Name = "NumEmpleado";
            this.NumEmpleado.ReadOnly = true;
            this.NumEmpleado.Width = 70;
            // 
            // Ext
            // 
            this.Ext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ext.HeaderText = "Ext.";
            this.Ext.MinimumWidth = 6;
            this.Ext.Name = "Ext";
            this.Ext.ReadOnly = true;
            this.Ext.Width = 50;
            // 
            // RedUser
            // 
            this.RedUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RedUser.HeaderText = "Usuario";
            this.RedUser.MinimumWidth = 6;
            this.RedUser.Name = "RedUser";
            this.RedUser.ReadOnly = true;
            this.RedUser.Width = 68;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mail.HeaderText = "Email";
            this.Mail.LinkColor = System.Drawing.Color.DimGray;
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.VisitedLinkColor = System.Drawing.Color.Black;
            this.Mail.Width = 38;
            // 
            // Hostname
            // 
            this.Hostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.LinkColor = System.Drawing.Color.DimGray;
            this.Hostname.MinimumWidth = 6;
            this.Hostname.Name = "Hostname";
            this.Hostname.ReadOnly = true;
            this.Hostname.VisitedLinkColor = System.Drawing.Color.Black;
            this.Hostname.Width = 61;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoEquipo.HeaderText = "Tipo de Equipo";
            this.TipoEquipo.MinimumWidth = 6;
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.ReadOnly = true;
            this.TipoEquipo.Width = 96;
            // 
            // NoSerie
            // 
            this.NoSerie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NoSerie.HeaderText = "No. Serie";
            this.NoSerie.MinimumWidth = 6;
            this.NoSerie.Name = "NoSerie";
            this.NoSerie.ReadOnly = true;
            this.NoSerie.Width = 70;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Marca.Width = 43;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 67;
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 80;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 99;
            // 
            // Comentarios
            // 
            this.Comentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.MinimumWidth = 6;
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            this.Comentarios.Width = 90;
            // 
            // TicketID
            // 
            this.TicketID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TicketID.HeaderText = "Ticket ID";
            this.TicketID.LinkColor = System.Drawing.Color.DimGray;
            this.TicketID.MinimumWidth = 6;
            this.TicketID.Name = "TicketID";
            this.TicketID.ReadOnly = true;
            this.TicketID.VisitedLinkColor = System.Drawing.Color.Black;
            this.TicketID.Width = 51;
            // 
            // PDFRitName
            // 
            this.PDFRitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PDFRitName.HeaderText = "RIT";
            this.PDFRitName.LinkColor = System.Drawing.Color.DimGray;
            this.PDFRitName.MinimumWidth = 6;
            this.PDFRitName.Name = "PDFRitName";
            this.PDFRitName.ReadOnly = true;
            this.PDFRitName.VisitedLinkColor = System.Drawing.Color.Black;
            this.PDFRitName.Width = 31;
            // 
            // Evidencia
            // 
            this.Evidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Evidencia.HeaderText = "Evidencia";
            this.Evidencia.Name = "Evidencia";
            this.Evidencia.Width = 60;
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.MinimumWidth = 6;
            this.Notas.Name = "Notas";
            this.Notas.ReadOnly = true;
            this.Notas.Width = 125;
            // 
            // HASH
            // 
            this.HASH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HASH.HeaderText = "HASH";
            this.HASH.MinimumWidth = 6;
            this.HASH.Name = "HASH";
            this.HASH.ReadOnly = true;
            this.HASH.Width = 62;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEquipoToolStripMenuItem,
            this.eliminarEquipoSeleccionadoToolStripMenuItem,
            this.editarEquipoSeleccionadoToolStripMenuItem1,
            this.toolStripSeparator8,
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem,
            this.desmarcarEquipoComoCompletadoToolStripMenuItem,
            this.toolStripSeparator9,
            this.generarRITParaElEquipoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(276, 172);
            // 
            // añadirEquipoToolStripMenuItem
            // 
            this.añadirEquipoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.add;
            this.añadirEquipoToolStripMenuItem.Name = "añadirEquipoToolStripMenuItem";
            this.añadirEquipoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.añadirEquipoToolStripMenuItem.Text = "Añadir equipo";
            this.añadirEquipoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // eliminarEquipoSeleccionadoToolStripMenuItem
            // 
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.eliminate_64;
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Name = "eliminarEquipoSeleccionadoToolStripMenuItem";
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Text = "Eliminar equipo seleccionado";
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // editarEquipoSeleccionadoToolStripMenuItem1
            // 
            this.editarEquipoSeleccionadoToolStripMenuItem1.Enabled = false;
            this.editarEquipoSeleccionadoToolStripMenuItem1.Image = global::Flow_Solver.Properties.Resources.edit3;
            this.editarEquipoSeleccionadoToolStripMenuItem1.Name = "editarEquipoSeleccionadoToolStripMenuItem1";
            this.editarEquipoSeleccionadoToolStripMenuItem1.Size = new System.Drawing.Size(275, 26);
            this.editarEquipoSeleccionadoToolStripMenuItem1.Text = "Editar equipo seleccionado";
            this.editarEquipoSeleccionadoToolStripMenuItem1.Click += new System.EventHandler(this.editarEquipoSeleccionadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(272, 6);
            // 
            // marcarCompletadoElEquipoSeleccionadoToolStripMenuItem
            // 
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources._checked;
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Name = "marcarCompletadoElEquipoSeleccionadoToolStripMenuItem";
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Text = "Marcar equipo como completado";
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.completarEquipoToolStripMenuItem_Click);
            // 
            // desmarcarEquipoComoCompletadoToolStripMenuItem
            // 
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources._unchecked;
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Name = "desmarcarEquipoComoCompletadoToolStripMenuItem";
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Text = "Desmarcar equipo como completado";
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Click += new System.EventHandler(this.desmarcarEquipoComoCompletadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(272, 6);
            // 
            // generarRITParaElEquipoToolStripMenuItem
            // 
            this.generarRITParaElEquipoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.project;
            this.generarRITParaElEquipoToolStripMenuItem.Name = "generarRITParaElEquipoToolStripMenuItem";
            this.generarRITParaElEquipoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.generarRITParaElEquipoToolStripMenuItem.Text = "Generar RIT para el equipo";
            this.generarRITParaElEquipoToolStripMenuItem.Click += new System.EventHandler(this.generarRITParaElEquipoToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informacion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 355);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartAvances);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avances";
            // 
            // chartAvances
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAvances.ChartAreas.Add(chartArea1);
            this.chartAvances.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartAvances.Legends.Add(legend1);
            this.chartAvances.Location = new System.Drawing.Point(3, 16);
            this.chartAvances.Name = "chartAvances";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SerieAvances";
            this.chartAvances.Series.Add(series1);
            this.chartAvances.Size = new System.Drawing.Size(233, 330);
            this.chartAvances.TabIndex = 0;
            this.chartAvances.Text = "Avances";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(245, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 355);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMensajeDePrivacidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 172);
            this.panel2.TabIndex = 1;
            // 
            // lblMensajeDePrivacidad
            // 
            this.lblMensajeDePrivacidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajeDePrivacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDePrivacidad.Location = new System.Drawing.Point(0, 0);
            this.lblMensajeDePrivacidad.Name = "lblMensajeDePrivacidad";
            this.lblMensajeDePrivacidad.Size = new System.Drawing.Size(321, 172);
            this.lblMensajeDePrivacidad.TabIndex = 0;
            this.lblMensajeDePrivacidad.Text = resources.GetString("lblMensajeDePrivacidad.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 171);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtDescripcion);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 171);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripcion";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDescripcion.Location = new System.Drawing.Point(3, 16);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(315, 152);
            this.rtxtDescripcion.TabIndex = 2;
            this.rtxtDescripcion.Text = "";
            this.rtxtDescripcion.TextChanged += new System.EventHandler(this.rtxtDescripcion_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(575, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.80259F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.19741F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(241, 349);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pboxSelloDeActividad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 94);
            this.panel3.TabIndex = 0;
            // 
            // pboxSelloDeActividad
            // 
            this.pboxSelloDeActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxSelloDeActividad.Image = global::Flow_Solver.Properties.Resources.Sello_denegado;
            this.pboxSelloDeActividad.Location = new System.Drawing.Point(142, 3);
            this.pboxSelloDeActividad.Name = "pboxSelloDeActividad";
            this.pboxSelloDeActividad.Size = new System.Drawing.Size(90, 88);
            this.pboxSelloDeActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSelloDeActividad.TabIndex = 0;
            this.pboxSelloDeActividad.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblResponsableDeActividad);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblAutorDeActividad);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblFechaDeTerminoPrevista);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblFechaDeInicio);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 243);
            this.panel4.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(3, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "dd / MM / yyyy HH:mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fecha de Termino prevista:";
            // 
            // lblResponsableDeActividad
            // 
            this.lblResponsableDeActividad.AutoSize = true;
            this.lblResponsableDeActividad.ForeColor = System.Drawing.SystemColors.Info;
            this.lblResponsableDeActividad.Location = new System.Drawing.Point(3, 179);
            this.lblResponsableDeActividad.Name = "lblResponsableDeActividad";
            this.lblResponsableDeActividad.Size = new System.Drawing.Size(10, 13);
            this.lblResponsableDeActividad.TabIndex = 7;
            this.lblResponsableDeActividad.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Responsable de la actividad:";
            // 
            // lblAutorDeActividad
            // 
            this.lblAutorDeActividad.AutoSize = true;
            this.lblAutorDeActividad.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAutorDeActividad.Location = new System.Drawing.Point(3, 126);
            this.lblAutorDeActividad.Name = "lblAutorDeActividad";
            this.lblAutorDeActividad.Size = new System.Drawing.Size(10, 13);
            this.lblAutorDeActividad.TabIndex = 5;
            this.lblAutorDeActividad.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Autor de la Actividad:";
            // 
            // lblFechaDeTerminoPrevista
            // 
            this.lblFechaDeTerminoPrevista.AutoSize = true;
            this.lblFechaDeTerminoPrevista.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFechaDeTerminoPrevista.Location = new System.Drawing.Point(3, 76);
            this.lblFechaDeTerminoPrevista.Name = "lblFechaDeTerminoPrevista";
            this.lblFechaDeTerminoPrevista.Size = new System.Drawing.Size(117, 13);
            this.lblFechaDeTerminoPrevista.TabIndex = 3;
            this.lblFechaDeTerminoPrevista.Text = "dd / MM / yyyy HH:mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Termino prevista:";
            // 
            // lblFechaDeInicio
            // 
            this.lblFechaDeInicio.AutoSize = true;
            this.lblFechaDeInicio.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFechaDeInicio.Location = new System.Drawing.Point(3, 25);
            this.lblFechaDeInicio.Name = "lblFechaDeInicio";
            this.lblFechaDeInicio.Size = new System.Drawing.Size(117, 13);
            this.lblFechaDeInicio.TabIndex = 1;
            this.lblFechaDeInicio.Text = "dd / MM / yyyy HH:mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(825, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plantilla de llenado de RIT";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPoblacion);
            this.panel5.Controls.Add(this.txtSucursal);
            this.panel5.Controls.Add(this.rbtnReporteCerrado_No);
            this.panel5.Controls.Add(this.rbtnReporteCerrado_Si);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtFallaReportada);
            this.panel5.Controls.Add(this.txtTecnico);
            this.panel5.Controls.Add(this.txtCentroDeServicio);
            this.panel5.Controls.Add(this.txtDireccion);
            this.panel5.Controls.Add(this.txtCliente);
            this.panel5.Controls.Add(this.txtLinea7);
            this.panel5.Controls.Add(this.txtLinea6);
            this.panel5.Controls.Add(this.txtLinea5);
            this.panel5.Controls.Add(this.txtLinea4);
            this.panel5.Controls.Add(this.txtLinea3);
            this.panel5.Controls.Add(this.txtLinea2);
            this.panel5.Controls.Add(this.txtLinea1);
            this.panel5.Controls.Add(this.pboxPlantillaRIT);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(791, 942);
            this.panel5.TabIndex = 0;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(576, 183);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(102, 20);
            this.txtPoblacion.TabIndex = 18;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(262, 159);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(288, 20);
            this.txtSucursal.TabIndex = 17;
            // 
            // rbtnReporteCerrado_No
            // 
            this.rbtnReporteCerrado_No.AutoSize = true;
            this.rbtnReporteCerrado_No.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnReporteCerrado_No.Location = new System.Drawing.Point(213, 526);
            this.rbtnReporteCerrado_No.Name = "rbtnReporteCerrado_No";
            this.rbtnReporteCerrado_No.Size = new System.Drawing.Size(14, 13);
            this.rbtnReporteCerrado_No.TabIndex = 16;
            this.rbtnReporteCerrado_No.TabStop = true;
            this.rbtnReporteCerrado_No.UseVisualStyleBackColor = false;
            // 
            // rbtnReporteCerrado_Si
            // 
            this.rbtnReporteCerrado_Si.AutoSize = true;
            this.rbtnReporteCerrado_Si.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnReporteCerrado_Si.Location = new System.Drawing.Point(178, 526);
            this.rbtnReporteCerrado_Si.Name = "rbtnReporteCerrado_Si";
            this.rbtnReporteCerrado_Si.Size = new System.Drawing.Size(14, 13);
            this.rbtnReporteCerrado_Si.TabIndex = 15;
            this.rbtnReporteCerrado_Si.TabStop = true;
            this.rbtnReporteCerrado_Si.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(598, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "XXXXXX";
            // 
            // txtFallaReportada
            // 
            this.txtFallaReportada.Location = new System.Drawing.Point(243, 259);
            this.txtFallaReportada.Name = "txtFallaReportada";
            this.txtFallaReportada.Size = new System.Drawing.Size(423, 20);
            this.txtFallaReportada.TabIndex = 13;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(335, 228);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(190, 20);
            this.txtTecnico.TabIndex = 12;
            // 
            // txtCentroDeServicio
            // 
            this.txtCentroDeServicio.Location = new System.Drawing.Point(373, 85);
            this.txtCentroDeServicio.Name = "txtCentroDeServicio";
            this.txtCentroDeServicio.Size = new System.Drawing.Size(139, 20);
            this.txtCentroDeServicio.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(136, 182);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(395, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(125, 158);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(94, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // txtLinea7
            // 
            this.txtLinea7.Location = new System.Drawing.Point(95, 441);
            this.txtLinea7.Name = "txtLinea7";
            this.txtLinea7.Size = new System.Drawing.Size(571, 20);
            this.txtLinea7.TabIndex = 7;
            // 
            // txtLinea6
            // 
            this.txtLinea6.Location = new System.Drawing.Point(95, 420);
            this.txtLinea6.Name = "txtLinea6";
            this.txtLinea6.Size = new System.Drawing.Size(571, 20);
            this.txtLinea6.TabIndex = 6;
            // 
            // txtLinea5
            // 
            this.txtLinea5.Location = new System.Drawing.Point(95, 401);
            this.txtLinea5.Name = "txtLinea5";
            this.txtLinea5.Size = new System.Drawing.Size(571, 20);
            this.txtLinea5.TabIndex = 5;
            // 
            // txtLinea4
            // 
            this.txtLinea4.Location = new System.Drawing.Point(94, 380);
            this.txtLinea4.Name = "txtLinea4";
            this.txtLinea4.Size = new System.Drawing.Size(572, 20);
            this.txtLinea4.TabIndex = 4;
            // 
            // txtLinea3
            // 
            this.txtLinea3.Location = new System.Drawing.Point(94, 360);
            this.txtLinea3.Name = "txtLinea3";
            this.txtLinea3.Size = new System.Drawing.Size(572, 20);
            this.txtLinea3.TabIndex = 3;
            // 
            // txtLinea2
            // 
            this.txtLinea2.Location = new System.Drawing.Point(95, 339);
            this.txtLinea2.Name = "txtLinea2";
            this.txtLinea2.Size = new System.Drawing.Size(571, 20);
            this.txtLinea2.TabIndex = 2;
            // 
            // txtLinea1
            // 
            this.txtLinea1.Location = new System.Drawing.Point(169, 318);
            this.txtLinea1.Name = "txtLinea1";
            this.txtLinea1.Size = new System.Drawing.Size(497, 20);
            this.txtLinea1.TabIndex = 1;
            // 
            // pboxPlantillaRIT
            // 
            this.pboxPlantillaRIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxPlantillaRIT.Image = global::Flow_Solver.Properties.Resources.FORMULARIO_RIT_HQ_page_0001;
            this.pboxPlantillaRIT.Location = new System.Drawing.Point(0, 0);
            this.pboxPlantillaRIT.Name = "pboxPlantillaRIT";
            this.pboxPlantillaRIT.Size = new System.Drawing.Size(791, 942);
            this.pboxPlantillaRIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPlantillaRIT.TabIndex = 0;
            this.pboxPlantillaRIT.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.exportacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.save2;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(244, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.cerrar;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirOtroEquipoToolStripMenuItem,
            this.eliminarElEquipoSelecciondoToolStripMenuItem,
            this.editarEquipoSeleccionadoToolStripMenuItem,
            this.toolStripSeparator6,
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem,
            this.generarLoteDeImpresionDeRITSToolStripMenuItem,
            this.completarEquipoToolStripMenuItem,
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1,
            this.toolStripSeparator10,
            this.enviarCorreoDeAvancesToolStripMenuItem,
            this.eliminarDuplicadosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // añadirOtroEquipoToolStripMenuItem
            // 
            this.añadirOtroEquipoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.add;
            this.añadirOtroEquipoToolStripMenuItem.Name = "añadirOtroEquipoToolStripMenuItem";
            this.añadirOtroEquipoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.añadirOtroEquipoToolStripMenuItem.Text = "Añadir otro equipo";
            this.añadirOtroEquipoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // eliminarElEquipoSelecciondoToolStripMenuItem
            // 
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.eliminate_64;
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Name = "eliminarElEquipoSelecciondoToolStripMenuItem";
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Text = "Eliminar el equipo selecciondo";
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // editarEquipoSeleccionadoToolStripMenuItem
            // 
            this.editarEquipoSeleccionadoToolStripMenuItem.Enabled = false;
            this.editarEquipoSeleccionadoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.edit3;
            this.editarEquipoSeleccionadoToolStripMenuItem.Name = "editarEquipoSeleccionadoToolStripMenuItem";
            this.editarEquipoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.editarEquipoSeleccionadoToolStripMenuItem.Text = "Editar equipo seleccionado";
            this.editarEquipoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.editarEquipoSeleccionadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(281, 6);
            // 
            // generarRITParaElEquipoSeleccionadoToolStripMenuItem
            // 
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.project_128;
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Name = "generarRITParaElEquipoSeleccionadoToolStripMenuItem";
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Text = "Generar RIT para el equipo seleccionado";
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.generarRITParaElEquipoSeleccionadoToolStripMenuItem_Click);
            // 
            // generarLoteDeImpresionDeRITSToolStripMenuItem
            // 
            this.generarLoteDeImpresionDeRITSToolStripMenuItem.Enabled = false;
            this.generarLoteDeImpresionDeRITSToolStripMenuItem.Name = "generarLoteDeImpresionDeRITSToolStripMenuItem";
            this.generarLoteDeImpresionDeRITSToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.generarLoteDeImpresionDeRITSToolStripMenuItem.Text = "Generar lote de impresion de RITs";
            this.generarLoteDeImpresionDeRITSToolStripMenuItem.Click += new System.EventHandler(this.generarLoteDeImpresionDeRITSToolStripMenuItem_Click);
            // 
            // completarEquipoToolStripMenuItem
            // 
            this.completarEquipoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources._checked;
            this.completarEquipoToolStripMenuItem.Name = "completarEquipoToolStripMenuItem";
            this.completarEquipoToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.completarEquipoToolStripMenuItem.Text = "Marcar equipo como completado";
            this.completarEquipoToolStripMenuItem.Click += new System.EventHandler(this.completarEquipoToolStripMenuItem_Click);
            // 
            // desmarcarEquipoComoCompletadoToolStripMenuItem1
            // 
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Image = global::Flow_Solver.Properties.Resources._unchecked;
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Name = "desmarcarEquipoComoCompletadoToolStripMenuItem1";
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Size = new System.Drawing.Size(284, 22);
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Text = "Desmarcar equipo como completado";
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Click += new System.EventHandler(this.desmarcarEquipoComoCompletadoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(281, 6);
            // 
            // enviarCorreoDeAvancesToolStripMenuItem
            // 
            this.enviarCorreoDeAvancesToolStripMenuItem.Enabled = false;
            this.enviarCorreoDeAvancesToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.correo_electronico;
            this.enviarCorreoDeAvancesToolStripMenuItem.Name = "enviarCorreoDeAvancesToolStripMenuItem";
            this.enviarCorreoDeAvancesToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.enviarCorreoDeAvancesToolStripMenuItem.Text = "Enviar correo de avances";
            this.enviarCorreoDeAvancesToolStripMenuItem.Click += new System.EventHandler(this.enviarCorreoDeAvancesToolStripMenuItem_Click);
            // 
            // eliminarDuplicadosToolStripMenuItem
            // 
            this.eliminarDuplicadosToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.delete_duplicates;
            this.eliminarDuplicadosToolStripMenuItem.Name = "eliminarDuplicadosToolStripMenuItem";
            this.eliminarDuplicadosToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.eliminarDuplicadosToolStripMenuItem.Text = "Eliminar duplicados";
            this.eliminarDuplicadosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDuplicadosToolStripMenuItem_Click);
            // 
            // exportacionToolStripMenuItem
            // 
            this.exportacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarActividadComoToolStripMenuItem,
            this.toolStripSeparator7,
            this.generarInformeDeActividadToolStripMenuItem});
            this.exportacionToolStripMenuItem.Name = "exportacionToolStripMenuItem";
            this.exportacionToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.exportacionToolStripMenuItem.Text = "Exportacion";
            // 
            // exportarActividadComoToolStripMenuItem
            // 
            this.exportarActividadComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.pDFToolStripMenuItem,
            this.paginaHTMLToolStripMenuItem});
            this.exportarActividadComoToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.exportar_16;
            this.exportarActividadComoToolStripMenuItem.Name = "exportarActividadComoToolStripMenuItem";
            this.exportarActividadComoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.exportarActividadComoToolStripMenuItem.Text = "Exportar actividad como...";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.xls_file_16;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.pdf_16;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // paginaHTMLToolStripMenuItem
            // 
            this.paginaHTMLToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.html_file_16;
            this.paginaHTMLToolStripMenuItem.Name = "paginaHTMLToolStripMenuItem";
            this.paginaHTMLToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.paginaHTMLToolStripMenuItem.Text = "Resumen de visualizacion HTML";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(230, 6);
            // 
            // generarInformeDeActividadToolStripMenuItem
            // 
            this.generarInformeDeActividadToolStripMenuItem.Image = global::Flow_Solver.Properties.Resources.printer_24;
            this.generarInformeDeActividadToolStripMenuItem.Name = "generarInformeDeActividadToolStripMenuItem";
            this.generarInformeDeActividadToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.generarInformeDeActividadToolStripMenuItem.Text = "Generar informe de resultados";
            this.generarInformeDeActividadToolStripMenuItem.Click += new System.EventHandler(this.generarInformeDeActividadToolStripMenuItem_Click);
            // 
            // bgworkerRitMakerProcess
            // 
            this.bgworkerRitMakerProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworkerRitMakerProcess_DoWork);
            this.bgworkerRitMakerProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworkerRitMakerProcess_RunWorkerCompleted);
            // 
            // actividades_mdi_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(833, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(833, 498);
            this.Name = "actividades_mdi_form";
            this.Text = "actividades_mdi_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.actividades_mdi_form_FormClosing);
            this.Load += new System.EventHandler(this.actividades_mdi_form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewSelection)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAvances)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSelloDeActividad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlantillaRIT)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private flCustomTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvPreviewSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_Eliminar;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_Completar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirOtroEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElEquipoSelecciondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEquipoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem completarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarActividadComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem generarInformeDeActividadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem añadirEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEquipoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEquipoSeleccionadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem marcarCompletadoElEquipoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem generarRITParaElEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel lblJobStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem enviarCorreoDeAvancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginaHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblNombre;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblHostname;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblModelo;
        private System.Windows.Forms.ToolStripLabel lblTipoDeEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvances;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pboxSelloDeActividad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFechaDeTerminoPrevista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaDeInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pboxPlantillaRIT;
        private System.Windows.Forms.TextBox txtLinea2;
        private System.Windows.Forms.TextBox txtLinea1;
        private System.Windows.Forms.TextBox txtLinea7;
        private System.Windows.Forms.TextBox txtLinea6;
        private System.Windows.Forms.TextBox txtLinea5;
        private System.Windows.Forms.TextBox txtLinea4;
        private System.Windows.Forms.TextBox txtLinea3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCentroDeServicio;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.TextBox txtFallaReportada;
        private System.Windows.Forms.ToolStripMenuItem generarRITParaElEquipoSeleccionadoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgworkerRitMakerProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnReporteCerrado_No;
        private System.Windows.Forms.RadioButton rbtnReporteCerrado_Si;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.ToolStripMenuItem generarLoteDeImpresionDeRITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem exportarComoExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporarComoPDFToolStripMenuItem;
        private System.Windows.Forms.Label lblMensajeDePrivacidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResponsableDeActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAutorDeActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_Desmarcar;
        private System.Windows.Forms.ToolStripMenuItem desmarcarEquipoComoCompletadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desmarcarEquipoComoCompletadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem eliminarDuplicadosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ext;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedUser;
        private System.Windows.Forms.DataGridViewLinkColumn Mail;
        private System.Windows.Forms.DataGridViewLinkColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewLinkColumn TicketID;
        private System.Windows.Forms.DataGridViewLinkColumn PDFRitName;
        private System.Windows.Forms.DataGridViewLinkColumn Evidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASH;
    }
}