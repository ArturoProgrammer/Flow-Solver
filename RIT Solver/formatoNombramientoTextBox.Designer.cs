namespace Flow_Solver
{
    partial class formatoNombramientoTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionarTag = new System.Windows.Forms.Button();
            this.btnVincularModelo = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionarTag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVincularModelo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtValue, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSeleccionarTag
            // 
            this.btnSeleccionarTag.BackgroundImage = global::Flow_Solver.Properties.Resources.selection;
            this.btnSeleccionarTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarTag.Location = new System.Drawing.Point(302, 3);
            this.btnSeleccionarTag.Name = "btnSeleccionarTag";
            this.btnSeleccionarTag.Size = new System.Drawing.Size(27, 22);
            this.btnSeleccionarTag.TabIndex = 38;
            this.btnSeleccionarTag.UseVisualStyleBackColor = true;
            this.btnSeleccionarTag.Click += new System.EventHandler(this.btnSeleccionarTag_Click);
            // 
            // btnVincularModelo
            // 
            this.btnVincularModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVincularModelo.Enabled = false;
            this.btnVincularModelo.Image = global::Flow_Solver.Properties.Resources.database_16;
            this.btnVincularModelo.Location = new System.Drawing.Point(266, 3);
            this.btnVincularModelo.Name = "btnVincularModelo";
            this.btnVincularModelo.Size = new System.Drawing.Size(30, 22);
            this.btnVincularModelo.TabIndex = 37;
            this.btnVincularModelo.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(3, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(257, 20);
            this.txtValue.TabIndex = 14;
            this.txtValue.Text = "[Usuario de Red] [Falla Reportada] [Fecha]";
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // formatoNombramientoTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formatoNombramientoTextBox";
            this.Size = new System.Drawing.Size(332, 28);
            this.Load += new System.EventHandler(this.formatoNombramientoTextBox_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnVincularModelo;
        private System.Windows.Forms.Button btnSeleccionarTag;
    }
}
