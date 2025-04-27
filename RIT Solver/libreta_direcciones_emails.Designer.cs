namespace Flow_Solver
{
    partial class libreta_direcciones_emails
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Direcciones Registradas", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libreta_direcciones_emails));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaDireccion = new System.Windows.Forms.Button();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadirDireccion = new System.Windows.Forms.Button();
            this.lviewDirecciones = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Seleccione la direccion con doble click";
            // 
            // btnNuevaDireccion
            // 
            this.btnNuevaDireccion.Image = global::Flow_Solver.Properties.Resources.add_16;
            this.btnNuevaDireccion.Location = new System.Drawing.Point(16, 367);
            this.btnNuevaDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaDireccion.Name = "btnNuevaDireccion";
            this.btnNuevaDireccion.Size = new System.Drawing.Size(168, 28);
            this.btnNuevaDireccion.TabIndex = 3;
            this.btnNuevaDireccion.Text = " Nueva direccion";
            this.btnNuevaDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaDireccion.UseVisualStyleBackColor = true;
            this.btnNuevaDireccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.Image = global::Flow_Solver.Properties.Resources.delete_16;
            this.btnEliminarDireccion.Location = new System.Drawing.Point(16, 402);
            this.btnEliminarDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(168, 28);
            this.btnEliminarDireccion.TabIndex = 4;
            this.btnEliminarDireccion.Text = " Eliminar direccion";
            this.btnEliminarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnNuevaDireccion);
            this.panel1.Controls.Add(this.btnEliminarDireccion);
            this.panel1.Controls.Add(this.btnAñadirDireccion);
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 437);
            this.panel1.TabIndex = 6;
            // 
            // btnAñadirDireccion
            // 
            this.btnAñadirDireccion.Image = global::Flow_Solver.Properties.Resources.exportar_16;
            this.btnAñadirDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirDireccion.Location = new System.Drawing.Point(244, 367);
            this.btnAñadirDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirDireccion.Name = "btnAñadirDireccion";
            this.btnAñadirDireccion.Size = new System.Drawing.Size(168, 31);
            this.btnAñadirDireccion.TabIndex = 1;
            this.btnAñadirDireccion.Text = " Cargar";
            this.btnAñadirDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirDireccion.UseVisualStyleBackColor = true;
            this.btnAñadirDireccion.Click += new System.EventHandler(this.btnAñadirDireccion_Click);
            // 
            // lviewDirecciones
            // 
            listViewGroup1.Header = "Direcciones Registradas";
            listViewGroup1.Name = "groupDireccionesRegistradas";
            this.lviewDirecciones.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lviewDirecciones.HideSelection = false;
            this.lviewDirecciones.LargeImageList = this.imageList1;
            this.lviewDirecciones.Location = new System.Drawing.Point(16, 48);
            this.lviewDirecciones.Name = "lviewDirecciones";
            this.lviewDirecciones.Size = new System.Drawing.Size(396, 450);
            this.lviewDirecciones.SmallImageList = this.imageList1;
            this.lviewDirecciones.TabIndex = 7;
            this.lviewDirecciones.UseCompatibleStateImageBehavior = false;
            this.lviewDirecciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviewDirecciones_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "client-default-photo.png");
            // 
            // libreta_direcciones_emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 574);
            this.Controls.Add(this.lviewDirecciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "libreta_direcciones_emails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreta de Direcciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.libreta_direcciones_emails_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadirDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lviewDirecciones;
        private System.Windows.Forms.ImageList imageList1;
    }
}