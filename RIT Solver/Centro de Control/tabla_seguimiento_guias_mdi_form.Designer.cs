namespace RIT_Solver.Centro_de_Control
{
    partial class tabla_seguimiento_guias_mdi_form
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Laptops Vinculadas", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("PCs de Escritorio Vinculados", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabla_seguimiento_guias_mdi_form));
            this.lviewTablaGuias = new System.Windows.Forms.ListView();
            this.colNombreComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_PaqueteriasLogos = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEditarModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.btnAñadirModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpBtnActualizarArchivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpBtnCerrarVisor = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnMarcarGuiaActualComoRecibida = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnVerMasInformacion = new System.Windows.Forms.ToolStripButton();
            this.PANEL_MDI = new System.Windows.Forms.Panel();
            this.toolMinimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.PANEL_MDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviewTablaGuias
            // 
            this.lviewTablaGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombreComercial,
            this.colNombreClave,
            this.colMarca,
            this.colTipo});
            this.lviewTablaGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Laptops Vinculadas";
            listViewGroup1.Name = "lvgroupLaptops";
            listViewGroup2.Header = "PCs de Escritorio Vinculados";
            listViewGroup2.Name = "lviewDesktopPCs";
            this.lviewTablaGuias.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lviewTablaGuias.HideSelection = false;
            this.lviewTablaGuias.LargeImageList = this.imageList_PaqueteriasLogos;
            this.lviewTablaGuias.Location = new System.Drawing.Point(0, 0);
            this.lviewTablaGuias.Margin = new System.Windows.Forms.Padding(4);
            this.lviewTablaGuias.Name = "lviewTablaGuias";
            this.lviewTablaGuias.Size = new System.Drawing.Size(1067, 505);
            this.lviewTablaGuias.SmallImageList = this.imageList_PaqueteriasLogos;
            this.lviewTablaGuias.TabIndex = 2;
            this.lviewTablaGuias.TileSize = new System.Drawing.Size(260, 52);
            this.lviewTablaGuias.UseCompatibleStateImageBehavior = false;
            this.lviewTablaGuias.View = System.Windows.Forms.View.Tile;
            this.lviewTablaGuias.SelectedIndexChanged += new System.EventHandler(this.lviewTablaDeModelosVinculados_SelectedIndexChanged);
            this.lviewTablaGuias.DoubleClick += new System.EventHandler(this.lviewTablaGuias_DoubleClick);
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Text = "Nombre Comercial";
            this.colNombreComercial.Width = 150;
            // 
            // colNombreClave
            // 
            this.colNombreClave.Text = "Nombre Clave";
            this.colNombreClave.Width = 150;
            // 
            // colMarca
            // 
            this.colMarca.Text = "Marca";
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            // 
            // imageList_PaqueteriasLogos
            // 
            this.imageList_PaqueteriasLogos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_PaqueteriasLogos.ImageStream")));
            this.imageList_PaqueteriasLogos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_PaqueteriasLogos.Images.SetKeyName(0, "fast-delivery.png");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(1, "dhl-logo.png");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(2, "fedex-logo.jpg");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(3, "paquete-express-logo.png");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(4, "dhl-logo-entregado.png");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(5, "fedex-logo-entregado.png");
            this.imageList_PaqueteriasLogos.Images.SetKeyName(6, "paquete-express-logo-entregado.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolMinimizar,
            this.btnCerrar,
            this.toolStripSeparator3,
            this.btnVisualizar,
            this.btnEditarModeloVinculado,
            this.btnAñadirModeloVinculado,
            this.btnEliminarModeloVinculado,
            this.toolStripSeparator1,
            this.toolStrpBtnActualizarArchivo,
            this.toolStripSeparator2,
            this.toolStrpBtnCerrarVisor,
            this.toolStrpBtnMarcarGuiaActualComoRecibida,
            this.toolStrpBtnVerMasInformacion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 49);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 46);
            this.toolStripLabel3.Text = " ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(53, 46);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.Click += new System.EventHandler(this.toolStrpBtnCerrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Image = global::RIT_Solver.Properties.Resources.check1_64;
            this.btnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(76, 44);
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVerModeloVinculado_Click);
            // 
            // btnEditarModeloVinculado
            // 
            this.btnEditarModeloVinculado.Enabled = false;
            this.btnEditarModeloVinculado.Image = global::RIT_Solver.Properties.Resources.edit1_64;
            this.btnEditarModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarModeloVinculado.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnEditarModeloVinculado.Name = "btnEditarModeloVinculado";
            this.btnEditarModeloVinculado.Size = new System.Drawing.Size(52, 44);
            this.btnEditarModeloVinculado.Text = "Editar";
            this.btnEditarModeloVinculado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAñadirModeloVinculado
            // 
            this.btnAñadirModeloVinculado.Image = global::RIT_Solver.Properties.Resources.add_64;
            this.btnAñadirModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAñadirModeloVinculado.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnAñadirModeloVinculado.Name = "btnAñadirModeloVinculado";
            this.btnAñadirModeloVinculado.Size = new System.Drawing.Size(57, 44);
            this.btnAñadirModeloVinculado.Text = "Añadir";
            this.btnAñadirModeloVinculado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAñadirModeloVinculado.Click += new System.EventHandler(this.btnAñadirModeloVinculado_Click);
            // 
            // btnEliminarModeloVinculado
            // 
            this.btnEliminarModeloVinculado.Enabled = false;
            this.btnEliminarModeloVinculado.Image = global::RIT_Solver.Properties.Resources.delete2;
            this.btnEliminarModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarModeloVinculado.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnEliminarModeloVinculado.Name = "btnEliminarModeloVinculado";
            this.btnEliminarModeloVinculado.Size = new System.Drawing.Size(67, 44);
            this.btnEliminarModeloVinculado.Text = "Eliminar";
            this.btnEliminarModeloVinculado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarModeloVinculado.Click += new System.EventHandler(this.btnEliminarModeloVinculado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStrpBtnActualizarArchivo
            // 
            this.toolStrpBtnActualizarArchivo.Image = global::RIT_Solver.Properties.Resources.save2;
            this.toolStrpBtnActualizarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnActualizarArchivo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStrpBtnActualizarArchivo.Name = "toolStrpBtnActualizarArchivo";
            this.toolStrpBtnActualizarArchivo.Size = new System.Drawing.Size(79, 44);
            this.toolStrpBtnActualizarArchivo.Text = "Actualizar";
            this.toolStrpBtnActualizarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnActualizarArchivo.Click += new System.EventHandler(this.toolStrpBtnActualizarArchivo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStrpBtnCerrarVisor
            // 
            this.toolStrpBtnCerrarVisor.Enabled = false;
            this.toolStrpBtnCerrarVisor.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.toolStrpBtnCerrarVisor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnCerrarVisor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStrpBtnCerrarVisor.Name = "toolStrpBtnCerrarVisor";
            this.toolStrpBtnCerrarVisor.Size = new System.Drawing.Size(88, 44);
            this.toolStrpBtnCerrarVisor.Text = "Cerrar visor";
            this.toolStrpBtnCerrarVisor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnCerrarVisor.Click += new System.EventHandler(this.toolStrpBtnCerrarVisor_Click);
            // 
            // toolStrpBtnMarcarGuiaActualComoRecibida
            // 
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Enabled = false;
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Image = global::RIT_Solver.Properties.Resources.check_64;
            this.toolStrpBtnMarcarGuiaActualComoRecibida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Name = "toolStrpBtnMarcarGuiaActualComoRecibida";
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Size = new System.Drawing.Size(117, 44);
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Text = "Marcar recibida";
            this.toolStrpBtnMarcarGuiaActualComoRecibida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Click += new System.EventHandler(this.toolStrpBtnMarcarGuiaActualComoRecibida_Click);
            // 
            // toolStrpBtnVerMasInformacion
            // 
            this.toolStrpBtnVerMasInformacion.Enabled = false;
            this.toolStrpBtnVerMasInformacion.Image = global::RIT_Solver.Properties.Resources.more_64;
            this.toolStrpBtnVerMasInformacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnVerMasInformacion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStrpBtnVerMasInformacion.Name = "toolStrpBtnVerMasInformacion";
            this.toolStrpBtnVerMasInformacion.Size = new System.Drawing.Size(76, 44);
            this.toolStrpBtnVerMasInformacion.Text = "Detalles...";
            this.toolStrpBtnVerMasInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnVerMasInformacion.Click += new System.EventHandler(this.toolStrpBtnVerMasInformacion_Click);
            // 
            // PANEL_MDI
            // 
            this.PANEL_MDI.Controls.Add(this.lviewTablaGuias);
            this.PANEL_MDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_MDI.Location = new System.Drawing.Point(0, 49);
            this.PANEL_MDI.Margin = new System.Windows.Forms.Padding(4);
            this.PANEL_MDI.Name = "PANEL_MDI";
            this.PANEL_MDI.Size = new System.Drawing.Size(1067, 505);
            this.PANEL_MDI.TabIndex = 4;
            // 
            // toolMinimizar
            // 
            this.toolMinimizar.Image = global::RIT_Solver.Properties.Resources.minimize_window_32;
            this.toolMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMinimizar.Name = "toolMinimizar";
            this.toolMinimizar.Size = new System.Drawing.Size(79, 46);
            this.toolMinimizar.Text = "Minimizar";
            this.toolMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolMinimizar.Click += new System.EventHandler(this.toolMinimizar_Click);
            // 
            // tabla_seguimiento_guias_mdi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PANEL_MDI);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabla_seguimiento_guias_mdi_form";
            this.Text = "Tabla de Seguimiento de Guias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tabla_seguimiento_guias_mdi_form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PANEL_MDI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviewTablaGuias;
        private System.Windows.Forms.ColumnHeader colNombreComercial;
        private System.Windows.Forms.ColumnHeader colNombreClave;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ImageList imageList_PaqueteriasLogos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnVisualizar;
        private System.Windows.Forms.ToolStripButton btnEditarModeloVinculado;
        private System.Windows.Forms.ToolStripButton btnAñadirModeloVinculado;
        private System.Windows.Forms.ToolStripButton btnEliminarModeloVinculado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStrpBtnActualizarArchivo;
        private System.Windows.Forms.Panel PANEL_MDI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrpBtnMarcarGuiaActualComoRecibida;
        private System.Windows.Forms.ToolStripButton toolStrpBtnVerMasInformacion;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStrpBtnCerrarVisor;
        public System.Windows.Forms.ToolStripButton toolMinimizar;
    }
}