namespace RIT_Solver
{
    partial class exTablaModelosVinculados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exTablaModelosVinculados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnVerModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.btnEditarModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.btnAñadirModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarModeloVinculado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lviewTablaDeModelosVinculados = new System.Windows.Forms.ListView();
            this.colNombreComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_MachinesIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtRutaDelArchivo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrpBtn_AbrirUbicacionDelArchivo = new System.Windows.Forms.ToolStripButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnVerModeloVinculado,
            this.btnEditarModeloVinculado,
            this.btnAñadirModeloVinculado,
            this.btnEliminarModeloVinculado,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 420);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(27, 20);
            this.toolStripLabel3.Text = " ";
            // 
            // btnVerModeloVinculado
            // 
            this.btnVerModeloVinculado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVerModeloVinculado.Image = global::RIT_Solver.Properties.Resources.check1_16;
            this.btnVerModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerModeloVinculado.Name = "btnVerModeloVinculado";
            this.btnVerModeloVinculado.Size = new System.Drawing.Size(27, 20);
            this.btnVerModeloVinculado.Text = "Ver";
            this.btnVerModeloVinculado.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEditarModeloVinculado
            // 
            this.btnEditarModeloVinculado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditarModeloVinculado.Image = global::RIT_Solver.Properties.Resources.edit1_16;
            this.btnEditarModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarModeloVinculado.Name = "btnEditarModeloVinculado";
            this.btnEditarModeloVinculado.Size = new System.Drawing.Size(27, 20);
            this.btnEditarModeloVinculado.Text = "Editar";
            this.btnEditarModeloVinculado.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnAñadirModeloVinculado
            // 
            this.btnAñadirModeloVinculado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAñadirModeloVinculado.Image = global::RIT_Solver.Properties.Resources.add_16;
            this.btnAñadirModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAñadirModeloVinculado.Name = "btnAñadirModeloVinculado";
            this.btnAñadirModeloVinculado.Size = new System.Drawing.Size(27, 20);
            this.btnAñadirModeloVinculado.Text = "Añadir";
            this.btnAñadirModeloVinculado.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnEliminarModeloVinculado
            // 
            this.btnEliminarModeloVinculado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarModeloVinculado.Image = global::RIT_Solver.Properties.Resources.delete_16;
            this.btnEliminarModeloVinculado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarModeloVinculado.Name = "btnEliminarModeloVinculado";
            this.btnEliminarModeloVinculado.Size = new System.Drawing.Size(27, 20);
            this.btnEliminarModeloVinculado.Text = "Eliminar";
            this.btnEliminarModeloVinculado.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RIT_Solver.Properties.Resources.check_3_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 20);
            this.toolStripButton1.Text = "Aceptar cambios";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // lviewTablaDeModelosVinculados
            // 
            this.lviewTablaDeModelosVinculados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombreComercial,
            this.colNombreClave,
            this.colMarca,
            this.colTipo});
            listViewGroup1.Header = "Laptops Vinculadas";
            listViewGroup1.Name = "lvgroupLaptops";
            listViewGroup2.Header = "PCs de Escritorio Vinculados";
            listViewGroup2.Name = "lviewDesktopPCs";
            this.lviewTablaDeModelosVinculados.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lviewTablaDeModelosVinculados.HideSelection = false;
            this.lviewTablaDeModelosVinculados.LargeImageList = this.imageList_MachinesIcons;
            this.lviewTablaDeModelosVinculados.Location = new System.Drawing.Point(8, 23);
            this.lviewTablaDeModelosVinculados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lviewTablaDeModelosVinculados.Name = "lviewTablaDeModelosVinculados";
            this.lviewTablaDeModelosVinculados.Size = new System.Drawing.Size(737, 298);
            this.lviewTablaDeModelosVinculados.SmallImageList = this.imageList_MachinesIcons;
            this.lviewTablaDeModelosVinculados.TabIndex = 1;
            this.lviewTablaDeModelosVinculados.UseCompatibleStateImageBehavior = false;
            this.lviewTablaDeModelosVinculados.View = System.Windows.Forms.View.Tile;
            this.lviewTablaDeModelosVinculados.SelectedIndexChanged += new System.EventHandler(this.lviewTablaDeModelosVinculados_SelectedIndexChanged);
            this.lviewTablaDeModelosVinculados.DoubleClick += new System.EventHandler(this.lviewTablaDeModelosVinculados_DoubleClick);
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
            // imageList_MachinesIcons
            // 
            this.imageList_MachinesIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_MachinesIcons.ImageStream")));
            this.imageList_MachinesIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_MachinesIcons.Images.SetKeyName(0, "laptop-64.png");
            this.imageList_MachinesIcons.Images.SetKeyName(1, "desktop-pc-64.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lviewTablaDeModelosVinculados);
            this.groupBox1.Location = new System.Drawing.Point(36, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(755, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizacion de elementos";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.txtRutaDelArchivo,
            this.toolStripLabel4,
            this.toolStrpBtn_AbrirUbicacionDelArchivo});
            this.toolStrip2.Location = new System.Drawing.Point(30, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(773, 27);
            this.toolStrip2.TabIndex = 3;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 24);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 24);
            this.toolStripLabel1.Text = "Ruta de archivo:";
            // 
            // txtRutaDelArchivo
            // 
            this.txtRutaDelArchivo.Enabled = false;
            this.txtRutaDelArchivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaDelArchivo.Name = "txtRutaDelArchivo";
            this.txtRutaDelArchivo.Size = new System.Drawing.Size(465, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 24);
            this.toolStripLabel4.Text = " ";
            // 
            // toolStrpBtn_AbrirUbicacionDelArchivo
            // 
            this.toolStrpBtn_AbrirUbicacionDelArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Image = global::RIT_Solver.Properties.Resources.open;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Name = "toolStrpBtn_AbrirUbicacionDelArchivo";
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Text = "Ir a ubicacion del archivo";
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Click += new System.EventHandler(this.toolStrpBtn_AbrirUbicacionDelArchivo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Image = global::RIT_Solver.Properties.Resources.check_3_16;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(573, 377);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 34);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = " Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(685, 377);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // exTablaModelosVinculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(803, 420);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "exTablaModelosVinculados";
            this.Text = "Tabla de Vinculacion - SOLO LECTURA -";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exTablaModelosVinculados_FormClosing);
            this.Load += new System.EventHandler(this.exTablaModelosVinculados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVerModeloVinculado;
        private System.Windows.Forms.ToolStripButton btnEditarModeloVinculado;
        private System.Windows.Forms.ToolStripButton btnAñadirModeloVinculado;
        private System.Windows.Forms.ToolStripButton btnEliminarModeloVinculado;
        private System.Windows.Forms.ListView lviewTablaDeModelosVinculados;
        private System.Windows.Forms.ColumnHeader colNombreComercial;
        private System.Windows.Forms.ColumnHeader colNombreClave;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtRutaDelArchivo;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_AbrirUbicacionDelArchivo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList_MachinesIcons;
    }
}