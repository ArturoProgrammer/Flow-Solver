namespace RIT_Solver.Centro_de_Control
{
    partial class pendientes_mdi_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pendientes_mdi_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElPendienteSelecciondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPendienteSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.marcarPendienteTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrpBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoPendiente = new System.Windows.Forms.ToolStripButton();
            this.eliminarPendienteSeleccionado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportarComoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporarComoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblJobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHASH = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lviewPendientes = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMensaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTerminado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.panelMDI = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtNotas = new System.Windows.Forms.RichTextBox();
            this.chckboxPendienteTerminado = new System.Windows.Forms.CheckBox();
            this.rtxtMensaje = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMinimizarReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTituloDeLista = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.toolStripSeparator5,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.save2;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.cerrar;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPendienteToolStripMenuItem,
            this.eliminarElPendienteSelecciondoToolStripMenuItem,
            this.editarPendienteSeleccionadoToolStripMenuItem,
            this.toolStripSeparator6,
            this.marcarPendienteTerminadoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // añadirPendienteToolStripMenuItem
            // 
            this.añadirPendienteToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.add;
            this.añadirPendienteToolStripMenuItem.Name = "añadirPendienteToolStripMenuItem";
            this.añadirPendienteToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.añadirPendienteToolStripMenuItem.Text = "Añadir nuevo pendiente";
            this.añadirPendienteToolStripMenuItem.Click += new System.EventHandler(this.añadirPendienteToolStripMenuItem_Click);
            // 
            // eliminarElPendienteSelecciondoToolStripMenuItem
            // 
            this.eliminarElPendienteSelecciondoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.eliminate_64;
            this.eliminarElPendienteSelecciondoToolStripMenuItem.Name = "eliminarElPendienteSelecciondoToolStripMenuItem";
            this.eliminarElPendienteSelecciondoToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.eliminarElPendienteSelecciondoToolStripMenuItem.Text = "Eliminar el pendiente seleccionado";
            this.eliminarElPendienteSelecciondoToolStripMenuItem.Click += new System.EventHandler(this.eliminarElPendienteSelecciondoToolStripMenuItem_Click);
            // 
            // editarPendienteSeleccionadoToolStripMenuItem
            // 
            this.editarPendienteSeleccionadoToolStripMenuItem.Enabled = false;
            this.editarPendienteSeleccionadoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.edit3;
            this.editarPendienteSeleccionadoToolStripMenuItem.Name = "editarPendienteSeleccionadoToolStripMenuItem";
            this.editarPendienteSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.editarPendienteSeleccionadoToolStripMenuItem.Text = "Editar pendiente seleccionado";
            this.editarPendienteSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.editarPendienteSeleccionadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(321, 6);
            // 
            // marcarPendienteTerminadoToolStripMenuItem
            // 
            this.marcarPendienteTerminadoToolStripMenuItem.Enabled = false;
            this.marcarPendienteTerminadoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.check;
            this.marcarPendienteTerminadoToolStripMenuItem.Name = "marcarPendienteTerminadoToolStripMenuItem";
            this.marcarPendienteTerminadoToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.marcarPendienteTerminadoToolStripMenuItem.Text = "Marcar pendiente terminado";
            this.marcarPendienteTerminadoToolStripMenuItem.Click += new System.EventHandler(this.marcarPendienteTerminadoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMinimizarReporte,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStrpBtnGuardar,
            this.toolStripSeparator1,
            this.nuevoPendiente,
            this.eliminarPendienteSeleccionado,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.txtTituloDeLista,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1089, 47);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrpBtnGuardar
            // 
            this.toolStrpBtnGuardar.Image = global::RIT_Solver.Properties.Resources.save2;
            this.toolStrpBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnGuardar.Name = "toolStrpBtnGuardar";
            this.toolStrpBtnGuardar.Size = new System.Drawing.Size(66, 44);
            this.toolStrpBtnGuardar.Text = "Guardar";
            this.toolStrpBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // nuevoPendiente
            // 
            this.nuevoPendiente.Enabled = false;
            this.nuevoPendiente.Image = global::RIT_Solver.Properties.Resources.add;
            this.nuevoPendiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoPendiente.Name = "nuevoPendiente";
            this.nuevoPendiente.Size = new System.Drawing.Size(57, 44);
            this.nuevoPendiente.Text = "Añadir";
            this.nuevoPendiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoPendiente.Click += new System.EventHandler(this.añadirPendienteToolStripMenuItem_Click);
            // 
            // eliminarPendienteSeleccionado
            // 
            this.eliminarPendienteSeleccionado.Enabled = false;
            this.eliminarPendienteSeleccionado.Image = global::RIT_Solver.Properties.Resources.eliminate_64;
            this.eliminarPendienteSeleccionado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarPendienteSeleccionado.Name = "eliminarPendienteSeleccionado";
            this.eliminarPendienteSeleccionado.Size = new System.Drawing.Size(67, 44);
            this.eliminarPendienteSeleccionado.Text = "Eliminar";
            this.eliminarPendienteSeleccionado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eliminarPendienteSeleccionado.Click += new System.EventHandler(this.eliminarElPendienteSelecciondoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = global::RIT_Solver.Properties.Resources.check;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton6.Text = "Listo";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.marcarPendienteTerminadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarComoExcelToolStripMenuItem,
            this.exporarComoPDFToolStripMenuItem});
            this.toolStripSplitButton1.Enabled = false;
            this.toolStripSplitButton1.Image = global::RIT_Solver.Properties.Resources.exportar_16;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(79, 44);
            this.toolStripSplitButton1.Text = "Exportar";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exportarComoExcelToolStripMenuItem
            // 
            this.exportarComoExcelToolStripMenuItem.Enabled = false;
            this.exportarComoExcelToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.xls_file_16;
            this.exportarComoExcelToolStripMenuItem.Name = "exportarComoExcelToolStripMenuItem";
            this.exportarComoExcelToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exportarComoExcelToolStripMenuItem.Text = "Exportar como Excel";
            // 
            // exporarComoPDFToolStripMenuItem
            // 
            this.exporarComoPDFToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.pdf_16;
            this.exporarComoPDFToolStripMenuItem.Name = "exporarComoPDFToolStripMenuItem";
            this.exporarComoPDFToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exporarComoPDFToolStripMenuItem.Text = "Exporar como PDF";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblJobStatus,
            this.lblHASH});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 25, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1089, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(44, 20);
            this.lblJobStatus.Text = "Listo!";
            // 
            // lblHASH
            // 
            this.lblHASH.Name = "lblHASH";
            this.lblHASH.Size = new System.Drawing.Size(1006, 20);
            this.lblHASH.Spring = true;
            this.lblHASH.Text = "toolStripStatusLabel2";
            this.lblHASH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lviewPendientes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMDI);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 464);
            this.splitContainer1.SplitterDistance = 657;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // lviewPendientes
            // 
            this.lviewPendientes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lviewPendientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colTitulo,
            this.colMensaje,
            this.colNotas,
            this.colTerminado});
            this.lviewPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewPendientes.FullRowSelect = true;
            this.lviewPendientes.HideSelection = false;
            this.lviewPendientes.LargeImageList = this.imageList_Icons;
            this.lviewPendientes.Location = new System.Drawing.Point(0, 0);
            this.lviewPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.lviewPendientes.Name = "lviewPendientes";
            this.lviewPendientes.Size = new System.Drawing.Size(657, 464);
            this.lviewPendientes.SmallImageList = this.imageList_Icons;
            this.lviewPendientes.TabIndex = 0;
            this.lviewPendientes.UseCompatibleStateImageBehavior = false;
            this.lviewPendientes.View = System.Windows.Forms.View.Details;
            this.lviewPendientes.SelectedIndexChanged += new System.EventHandler(this.lviewPendientes_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 40;
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Titulo";
            this.colTitulo.Width = 200;
            // 
            // colMensaje
            // 
            this.colMensaje.Text = "Mensaje";
            this.colMensaje.Width = 200;
            // 
            // colNotas
            // 
            this.colNotas.Text = "Notas";
            this.colNotas.Width = 200;
            // 
            // colTerminado
            // 
            this.colTerminado.Text = "Terminado";
            this.colTerminado.Width = 85;
            // 
            // imageList_Icons
            // 
            this.imageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icons.ImageStream")));
            this.imageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icons.Images.SetKeyName(0, "check-24.png");
            // 
            // panelMDI
            // 
            this.panelMDI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMDI.Controls.Add(this.lblID);
            this.panelMDI.Controls.Add(this.label1);
            this.panelMDI.Controls.Add(this.rtxtNotas);
            this.panelMDI.Controls.Add(this.chckboxPendienteTerminado);
            this.panelMDI.Controls.Add(this.rtxtMensaje);
            this.panelMDI.Controls.Add(this.lblTitulo);
            this.panelMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMDI.Location = new System.Drawing.Point(0, 0);
            this.panelMDI.Margin = new System.Windows.Forms.Padding(4);
            this.panelMDI.Name = "panelMDI";
            this.panelMDI.Size = new System.Drawing.Size(427, 464);
            this.panelMDI.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(333, 434);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 27);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notas:";
            // 
            // rtxtNotas
            // 
            this.rtxtNotas.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtNotas.Location = new System.Drawing.Point(9, 263);
            this.rtxtNotas.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotas.Name = "rtxtNotas";
            this.rtxtNotas.Size = new System.Drawing.Size(400, 98);
            this.rtxtNotas.TabIndex = 4;
            this.rtxtNotas.Text = "%MENSAJE%";
            this.rtxtNotas.TextChanged += new System.EventHandler(this.rtxtNotas_TextChanged);
            // 
            // chckboxPendienteTerminado
            // 
            this.chckboxPendienteTerminado.AutoSize = true;
            this.chckboxPendienteTerminado.Location = new System.Drawing.Point(9, 414);
            this.chckboxPendienteTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.chckboxPendienteTerminado.Name = "chckboxPendienteTerminado";
            this.chckboxPendienteTerminado.Size = new System.Drawing.Size(237, 20);
            this.chckboxPendienteTerminado.TabIndex = 3;
            this.chckboxPendienteTerminado.Text = "Marcar como pendiente terminado!";
            this.chckboxPendienteTerminado.UseVisualStyleBackColor = true;
            this.chckboxPendienteTerminado.CheckedChanged += new System.EventHandler(this.chckboxPendienteTerminado_CheckedChanged);
            // 
            // rtxtMensaje
            // 
            this.rtxtMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtMensaje.Location = new System.Drawing.Point(9, 84);
            this.rtxtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtMensaje.Name = "rtxtMensaje";
            this.rtxtMensaje.ReadOnly = true;
            this.rtxtMensaje.Size = new System.Drawing.Size(400, 142);
            this.rtxtMensaje.TabIndex = 2;
            this.rtxtMensaje.Text = "%MENSAJE%";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(4, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(419, 68);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "%Titulo%";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 44);
            this.toolStripButton1.Text = "Cerrar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // toolMinimizarReporte
            // 
            this.toolMinimizarReporte.Image = global::RIT_Solver.Properties.Resources.minimize_window_32;
            this.toolMinimizarReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMinimizarReporte.Name = "toolMinimizarReporte";
            this.toolMinimizarReporte.Size = new System.Drawing.Size(79, 44);
            this.toolMinimizarReporte.Text = "Minimizar";
            this.toolMinimizarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolMinimizarReporte.Click += new System.EventHandler(this.toolMinimizarReporte_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 44);
            this.toolStripLabel1.Text = "Titulo de la Lista:";
            // 
            // txtTituloDeLista
            // 
            this.txtTituloDeLista.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTituloDeLista.AutoSize = false;
            this.txtTituloDeLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloDeLista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTituloDeLista.Name = "txtTituloDeLista";
            this.txtTituloDeLista.Size = new System.Drawing.Size(200, 24);
            this.txtTituloDeLista.TextChanged += new System.EventHandler(this.txtTituloDeLista_TextChanged);
            // 
            // pendientes_mdi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 565);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pendientes_mdi_form";
            this.Text = "pendientes_mdi_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pendientes_mdi_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelMDI.ResumeLayout(false);
            this.panelMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElPendienteSelecciondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPendienteSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem marcarPendienteTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrpBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton nuevoPendiente;
        private System.Windows.Forms.ToolStripButton eliminarPendienteSeleccionado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem exportarComoExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporarComoPDFToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblJobStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelMDI;
        private System.Windows.Forms.ImageList imageList_Icons;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colTitulo;
        private System.Windows.Forms.ColumnHeader colMensaje;
        private System.Windows.Forms.ColumnHeader colNotas;
        private System.Windows.Forms.ColumnHeader colTerminado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.CheckBox chckboxPendienteTerminado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtNotas;
        private System.Windows.Forms.ToolStripStatusLabel lblHASH;
        public System.Windows.Forms.ListView lviewPendientes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton toolMinimizarReporte;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTituloDeLista;
    }
}