namespace RIT_Solver
{
    partial class tabla_historiales
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Historiales", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabla_historiales));
            this.lviewTablaDeHistoriales = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.jobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrpBtnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnRecargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviewTablaDeHistoriales
            // 
            listViewGroup1.Header = "Historiales";
            listViewGroup1.Name = "lviewGroupHistoriales";
            this.lviewTablaDeHistoriales.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lviewTablaDeHistoriales.HideSelection = false;
            this.lviewTablaDeHistoriales.LargeImageList = this.imageList1;
            this.lviewTablaDeHistoriales.Location = new System.Drawing.Point(0, 51);
            this.lviewTablaDeHistoriales.Margin = new System.Windows.Forms.Padding(4);
            this.lviewTablaDeHistoriales.Name = "lviewTablaDeHistoriales";
            this.lviewTablaDeHistoriales.Size = new System.Drawing.Size(854, 373);
            this.lviewTablaDeHistoriales.SmallImageList = this.imageList1;
            this.lviewTablaDeHistoriales.TabIndex = 2;
            this.lviewTablaDeHistoriales.UseCompatibleStateImageBehavior = false;
            this.lviewTablaDeHistoriales.View = System.Windows.Forms.View.Tile;
            this.lviewTablaDeHistoriales.SelectedIndexChanged += new System.EventHandler(this.lviewTablaDeHistoriales_SelectedIndexChanged);
            this.lviewTablaDeHistoriales.DoubleClick += new System.EventHandler(this.lviewTablaDeHistoriales_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // jobStatus
            // 
            this.jobStatus.Name = "jobStatus";
            this.jobStatus.Size = new System.Drawing.Size(44, 20);
            this.jobStatus.Text = "Listo!";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "historial_icon.ico");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpBtnVisualizar,
            this.toolStrpBtnEliminar,
            this.toolStripSeparator1,
            this.toolStrpBtnRecargar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(854, 47);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrpBtnVisualizar
            // 
            this.toolStrpBtnVisualizar.Enabled = false;
            this.toolStrpBtnVisualizar.Image = global::RIT_Solver.Properties.Resources.check1_64;
            this.toolStrpBtnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnVisualizar.Name = "toolStrpBtnVisualizar";
            this.toolStrpBtnVisualizar.Size = new System.Drawing.Size(76, 44);
            this.toolStrpBtnVisualizar.Text = "Visualizar";
            this.toolStrpBtnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrpBtnEliminar
            // 
            this.toolStrpBtnEliminar.Enabled = false;
            this.toolStrpBtnEliminar.Image = global::RIT_Solver.Properties.Resources.delete2;
            this.toolStrpBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnEliminar.Name = "toolStrpBtnEliminar";
            this.toolStrpBtnEliminar.Size = new System.Drawing.Size(67, 44);
            this.toolStrpBtnEliminar.Text = "Eliminar";
            this.toolStrpBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrpBtnRecargar
            // 
            this.toolStrpBtnRecargar.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolStrpBtnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnRecargar.Name = "toolStrpBtnRecargar";
            this.toolStrpBtnRecargar.Size = new System.Drawing.Size(72, 44);
            this.toolStrpBtnRecargar.Text = "Recargar";
            this.toolStrpBtnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrpBtnRecargar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tabla_historiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lviewTablaDeHistoriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tabla_historiales";
            this.Text = "Tabla de Historiales";
            this.Load += new System.EventHandler(this.tabla_historiales_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviewTablaDeHistoriales;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel jobStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrpBtnVisualizar;
        private System.Windows.Forms.ToolStripButton toolStrpBtnEliminar;
        private System.Windows.Forms.ToolStripButton toolStrpBtnRecargar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}