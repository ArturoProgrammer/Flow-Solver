namespace Flow_Solver
{
    partial class exHistorialDeCambios
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Eventos Registrados", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exHistorialDeCambios));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarHistorial = new System.Windows.Forms.Button();
            this.btnExportarHistorial = new System.Windows.Forms.Button();
            this.btnFusionarHistoriales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHASH = new System.Windows.Forms.Label();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.rtxtMensaje = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lviewHistorialDeEventos = new System.Windows.Forms.ListView();
            this.imageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog_Historial = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Historial = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            lblTitle = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(105, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(264, 33);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Historial del equipo";
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.BackColor = System.Drawing.SystemColors.Control;
            this.panelFondo.Controls.Add(this.groupBox2);
            this.panelFondo.Controls.Add(this.groupBox1);
            this.panelFondo.Controls.Add(this.lviewHistorialDeEventos);
            this.panelFondo.Controls.Add(this.btnCerrar);
            this.panelFondo.Location = new System.Drawing.Point(0, 105);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(487, 462);
            this.panelFondo.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarHistorial);
            this.groupBox2.Controls.Add(this.btnExportarHistorial);
            this.groupBox2.Controls.Add(this.btnFusionarHistoriales);
            this.groupBox2.Location = new System.Drawing.Point(232, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 133);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnEliminarHistorial
            // 
            this.btnEliminarHistorial.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarHistorial.Image = global::Flow_Solver.Properties.Resources.delete_16;
            this.btnEliminarHistorial.Location = new System.Drawing.Point(9, 93);
            this.btnEliminarHistorial.Name = "btnEliminarHistorial";
            this.btnEliminarHistorial.Size = new System.Drawing.Size(228, 31);
            this.btnEliminarHistorial.TabIndex = 37;
            this.btnEliminarHistorial.Text = " Eliminar Historial actual";
            this.btnEliminarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarHistorial.UseVisualStyleBackColor = true;
            this.btnEliminarHistorial.Click += new System.EventHandler(this.btnEliminarHistorial_Click);
            // 
            // btnExportarHistorial
            // 
            this.btnExportarHistorial.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExportarHistorial.Image = global::Flow_Solver.Properties.Resources.exportar_16;
            this.btnExportarHistorial.Location = new System.Drawing.Point(9, 56);
            this.btnExportarHistorial.Name = "btnExportarHistorial";
            this.btnExportarHistorial.Size = new System.Drawing.Size(228, 31);
            this.btnExportarHistorial.TabIndex = 36;
            this.btnExportarHistorial.Text = " Exportar Historial actual";
            this.btnExportarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarHistorial.UseVisualStyleBackColor = true;
            this.btnExportarHistorial.Click += new System.EventHandler(this.btnExportarHistorial_Click);
            // 
            // btnFusionarHistoriales
            // 
            this.btnFusionarHistoriales.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFusionarHistoriales.Image = global::Flow_Solver.Properties.Resources.merger_16;
            this.btnFusionarHistoriales.Location = new System.Drawing.Point(9, 19);
            this.btnFusionarHistoriales.Name = "btnFusionarHistoriales";
            this.btnFusionarHistoriales.Size = new System.Drawing.Size(228, 31);
            this.btnFusionarHistoriales.TabIndex = 35;
            this.btnFusionarHistoriales.Text = " Fusionar con un Historial existente";
            this.btnFusionarHistoriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFusionarHistoriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFusionarHistoriales.UseVisualStyleBackColor = true;
            this.btnFusionarHistoriales.Click += new System.EventHandler(this.btnFusionarHistoriales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHASH);
            this.groupBox1.Controls.Add(this.lblCreacion);
            this.groupBox1.Controls.Add(this.rtxtMensaje);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(232, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 272);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HASH:";
            // 
            // lblHASH
            // 
            this.lblHASH.AutoSize = true;
            this.lblHASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHASH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHASH.Location = new System.Drawing.Point(53, 192);
            this.lblHASH.Name = "lblHASH";
            this.lblHASH.Size = new System.Drawing.Size(53, 13);
            this.lblHASH.TabIndex = 3;
            this.lblHASH.Text = "%HASH%";
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Location = new System.Drawing.Point(7, 256);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(78, 13);
            this.lblCreacion.TabIndex = 2;
            this.lblCreacion.Text = "%CREACION%";
            // 
            // rtxtMensaje
            // 
            this.rtxtMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtMensaje.Location = new System.Drawing.Point(6, 73);
            this.rtxtMensaje.Name = "rtxtMensaje";
            this.rtxtMensaje.ReadOnly = true;
            this.rtxtMensaje.Size = new System.Drawing.Size(231, 116);
            this.rtxtMensaje.TabIndex = 1;
            this.rtxtMensaje.Text = "%MENSAJE%";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "%Titulo%";
            // 
            // lviewHistorialDeEventos
            // 
            this.lviewHistorialDeEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listViewGroup1.Header = "Eventos Registrados";
            listViewGroup1.Name = "lvgroupEventosRegistrados";
            this.lviewHistorialDeEventos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lviewHistorialDeEventos.HideSelection = false;
            this.lviewHistorialDeEventos.LargeImageList = this.imageList_Icons;
            this.lviewHistorialDeEventos.Location = new System.Drawing.Point(3, 3);
            this.lviewHistorialDeEventos.Name = "lviewHistorialDeEventos";
            this.lviewHistorialDeEventos.Size = new System.Drawing.Size(223, 456);
            this.lviewHistorialDeEventos.SmallImageList = this.imageList_Icons;
            this.lviewHistorialDeEventos.TabIndex = 32;
            this.lviewHistorialDeEventos.TileSize = new System.Drawing.Size(192, 32);
            this.lviewHistorialDeEventos.UseCompatibleStateImageBehavior = false;
            this.lviewHistorialDeEventos.View = System.Windows.Forms.View.Tile;
            this.lviewHistorialDeEventos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList_Icons
            // 
            this.imageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icons.ImageStream")));
            this.imageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icons.Images.SetKeyName(0, "neutral_object-64.png");
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::Flow_Solver.Properties.Resources.cancel_16;
            this.btnCerrar.Location = new System.Drawing.Point(378, 420);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 30);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(109, 54);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(230, 15);
            this.lblCaption.TabIndex = 39;
            this.lblCaption.Text = "Revisar el historial de eventos del equipo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flow_Solver.Properties.Resources.computer_historial;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog_Historial
            // 
            this.openFileDialog_Historial.Filter = "Archivos de Historial de Eventos (*.historial)|*.historial";
            this.openFileDialog_Historial.Multiselect = true;
            this.openFileDialog_Historial.Title = "Selecciona el historial de evento a fusionar";
            // 
            // saveFileDialog_Historial
            // 
            this.saveFileDialog_Historial.Filter = "Archivos de Historial de Eventos (*.historial)|*.historial";
            this.saveFileDialog_Historial.Title = "Selecciona el directorio donde se guardara el historial...";
            // 
            // exHistorialDeCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(487, 567);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "exHistorialDeCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Cambios - %HOSTNAME%";
            this.Load += new System.EventHandler(this.exHistorialDeCambios_Load);
            this.panelFondo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ListView lviewHistorialDeEventos;
        private System.Windows.Forms.ImageList imageList_Icons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.Label lblHASH;
        private System.Windows.Forms.Label lblCreacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFusionarHistoriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Historial;
        private System.Windows.Forms.Button btnEliminarHistorial;
        private System.Windows.Forms.Button btnExportarHistorial;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Historial;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}