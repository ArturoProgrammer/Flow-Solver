namespace RIT_Solver
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaDireccion = new System.Windows.Forms.Button();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.listDirecciones = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadirDireccion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Seleccione la direccion con doble click";
            // 
            // btnNuevaDireccion
            // 
            this.btnNuevaDireccion.Location = new System.Drawing.Point(12, 298);
            this.btnNuevaDireccion.Name = "btnNuevaDireccion";
            this.btnNuevaDireccion.Size = new System.Drawing.Size(126, 23);
            this.btnNuevaDireccion.TabIndex = 3;
            this.btnNuevaDireccion.Text = "Añadir nueva direccion";
            this.btnNuevaDireccion.UseVisualStyleBackColor = true;
            this.btnNuevaDireccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.Location = new System.Drawing.Point(12, 327);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(126, 23);
            this.btnEliminarDireccion.TabIndex = 4;
            this.btnEliminarDireccion.Text = "Eliminar direccion";
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // listDirecciones
            // 
            this.listDirecciones.FormattingEnabled = true;
            this.listDirecciones.Location = new System.Drawing.Point(12, 34);
            this.listDirecciones.Name = "listDirecciones";
            this.listDirecciones.Size = new System.Drawing.Size(297, 368);
            this.listDirecciones.TabIndex = 5;
            this.listDirecciones.SelectedIndexChanged += new System.EventHandler(this.listDirecciones_SelectedIndexChanged);
            this.listDirecciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDirecciones_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnNuevaDireccion);
            this.panel1.Controls.Add(this.btnEliminarDireccion);
            this.panel1.Controls.Add(this.btnAñadirDireccion);
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 355);
            this.panel1.TabIndex = 6;
            // 
            // btnAñadirDireccion
            // 
            this.btnAñadirDireccion.Image = global::RIT_Solver.Properties.Resources.exportar_16;
            this.btnAñadirDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirDireccion.Location = new System.Drawing.Point(183, 298);
            this.btnAñadirDireccion.Name = "btnAñadirDireccion";
            this.btnAñadirDireccion.Size = new System.Drawing.Size(126, 25);
            this.btnAñadirDireccion.TabIndex = 1;
            this.btnAñadirDireccion.Text = " Cargar";
            this.btnAñadirDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirDireccion.UseVisualStyleBackColor = true;
            this.btnAñadirDireccion.Click += new System.EventHandler(this.btnAñadirDireccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 466);
            this.Controls.Add(this.listDirecciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreta de Direcciones";
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
        private System.Windows.Forms.ListBox listDirecciones;
        private System.Windows.Forms.Panel panel1;
    }
}