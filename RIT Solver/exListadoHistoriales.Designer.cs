namespace RIT_Solver
{
    partial class exListadoHistoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exListadoHistoriales));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblJobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCrearHistorial = new System.Windows.Forms.ToolStripButton();
            this.btnVerHistorial = new System.Windows.Forms.ToolStripButton();
            this.btnEditarHistorial = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarHistorial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportarHistorial = new System.Windows.Forms.ToolStripButton();
            this.btnFusionarHistoriales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblHostnameSeleccionado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayout_Base = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lviewHistoriales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayout_Base.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotal,
            this.toolStripStatusLabel1,
            this.lblJobStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(152, 20);
            this.lblTotal.Text = "Total de Historiales: 0";
            // 
            // toolStripStatusLabel1
            // 
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearHistorial,
            this.btnVerHistorial,
            this.btnEditarHistorial,
            this.btnEliminarHistorial,
            this.toolStripSeparator1,
            this.btnExportarHistorial,
            this.btnFusionarHistoriales,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.lblHostnameSeleccionado,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCrearHistorial
            // 
            this.btnCrearHistorial.Enabled = false;
            this.btnCrearHistorial.Image = global::RIT_Solver.Properties.Resources.add_64;
            this.btnCrearHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrearHistorial.Name = "btnCrearHistorial";
            this.btnCrearHistorial.Size = new System.Drawing.Size(48, 44);
            this.btnCrearHistorial.Text = "Crear";
            this.btnCrearHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearHistorial.ToolTipText = "Crear un nuevo historial";
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Image = global::RIT_Solver.Properties.Resources.check1_16;
            this.btnVerHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(34, 44);
            this.btnVerHistorial.Text = "Ver";
            this.btnVerHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerHistorial.ToolTipText = "Ver el historial seleccionado";
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // btnEditarHistorial
            // 
            this.btnEditarHistorial.Enabled = false;
            this.btnEditarHistorial.Image = global::RIT_Solver.Properties.Resources.edit1_64;
            this.btnEditarHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarHistorial.Name = "btnEditarHistorial";
            this.btnEditarHistorial.Size = new System.Drawing.Size(52, 44);
            this.btnEditarHistorial.Text = "Editar";
            this.btnEditarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarHistorial.Click += new System.EventHandler(this.btnEditarHistorial_Click);
            // 
            // btnEliminarHistorial
            // 
            this.btnEliminarHistorial.Image = global::RIT_Solver.Properties.Resources.eliminate_64;
            this.btnEliminarHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarHistorial.Name = "btnEliminarHistorial";
            this.btnEliminarHistorial.Size = new System.Drawing.Size(67, 44);
            this.btnEliminarHistorial.Text = "Eliminar";
            this.btnEliminarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarHistorial.ToolTipText = "Eliminar historial seleccionado";
            this.btnEliminarHistorial.Click += new System.EventHandler(this.btnEliminarHistorial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnExportarHistorial
            // 
            this.btnExportarHistorial.Image = global::RIT_Solver.Properties.Resources.exportar_16;
            this.btnExportarHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarHistorial.Name = "btnExportarHistorial";
            this.btnExportarHistorial.Size = new System.Drawing.Size(69, 44);
            this.btnExportarHistorial.Text = "Exportar";
            this.btnExportarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportarHistorial.ToolTipText = "Exportar historial seleccionado";
            this.btnExportarHistorial.Click += new System.EventHandler(this.btnExportarHistorial_Click);
            // 
            // btnFusionarHistoriales
            // 
            this.btnFusionarHistoriales.Image = global::RIT_Solver.Properties.Resources.merger_16;
            this.btnFusionarHistoriales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFusionarHistoriales.Name = "btnFusionarHistoriales";
            this.btnFusionarHistoriales.Size = new System.Drawing.Size(68, 44);
            this.btnFusionarHistoriales.Text = "Fusionar";
            this.btnFusionarHistoriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFusionarHistoriales.ToolTipText = "Fusionar historiales seleccionados";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::RIT_Solver.Properties.Resources.help_64;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 44);
            this.toolStripButton2.Text = "Ayuda";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "Ayuda acerca de la herramienta";
            // 
            // lblHostnameSeleccionado
            // 
            this.lblHostnameSeleccionado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblHostnameSeleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.lblHostnameSeleccionado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHostnameSeleccionado.Name = "lblHostnameSeleccionado";
            this.lblHostnameSeleccionado.Size = new System.Drawing.Size(15, 44);
            this.lblHostnameSeleccionado.Text = "-";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 44);
            this.toolStripLabel1.Text = "Hostname:";
            // 
            // tableLayout_Base
            // 
            this.tableLayout_Base.ColumnCount = 2;
            this.tableLayout_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayout_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout_Base.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayout_Base.Controls.Add(this.panel1, 1, 0);
            this.tableLayout_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Base.Location = new System.Drawing.Point(0, 47);
            this.tableLayout_Base.Name = "tableLayout_Base";
            this.tableLayout_Base.RowCount = 1;
            this.tableLayout_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Base.Size = new System.Drawing.Size(1043, 465);
            this.tableLayout_Base.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lviewHistoriales);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historiales registrados";
            // 
            // lviewHistoriales
            // 
            this.lviewHistoriales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lviewHistoriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewHistoriales.HideSelection = false;
            this.lviewHistoriales.LargeImageList = this.imageList1;
            this.lviewHistoriales.Location = new System.Drawing.Point(3, 18);
            this.lviewHistoriales.Name = "lviewHistoriales";
            this.lviewHistoriales.Size = new System.Drawing.Size(613, 438);
            this.lviewHistoriales.SmallImageList = this.imageList1;
            this.lviewHistoriales.TabIndex = 4;
            this.lviewHistoriales.UseCompatibleStateImageBehavior = false;
            this.lviewHistoriales.View = System.Windows.Forms.View.Tile;
            this.lviewHistoriales.SelectedIndexChanged += new System.EventHandler(this.lviewHistoriales_SelectedIndexChanged);
            this.lviewHistoriales.DoubleClick += new System.EventHandler(this.lviewHistoriales_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "computer-historial.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(628, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 459);
            this.panel1.TabIndex = 1;
            // 
            // exListadoHistoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 538);
            this.Controls.Add(this.tableLayout_Base);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "exListadoHistoriales";
            this.Text = "Listado de Historiales de Equipos";
            this.Load += new System.EventHandler(this.exListadoHistoriales_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayout_Base.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVerHistorial;
        private System.Windows.Forms.ToolStripButton btnEliminarHistorial;
        private System.Windows.Forms.ToolStripButton btnEditarHistorial;
        private System.Windows.Forms.ToolStripButton btnCrearHistorial;
        private System.Windows.Forms.ToolStripButton btnFusionarHistoriales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExportarHistorial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Base;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripLabel lblHostnameSeleccionado;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ListView lviewHistoriales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel lblJobStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}