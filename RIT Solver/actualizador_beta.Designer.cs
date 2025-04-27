namespace Flow_Solver
{
    partial class actualizador_beta
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualizador_beta));
            this.lvlVersionActual = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lvlVersionNueva = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressDescarga = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(161, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(611, 47);
            label1.TabIndex = 64;
            label1.Text = "¡Estamos actualizando el sistema!";
            // 
            // lvlVersionActual
            // 
            this.lvlVersionActual.AutoSize = true;
            this.lvlVersionActual.Location = new System.Drawing.Point(537, 137);
            this.lvlVersionActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlVersionActual.Name = "lvlVersionActual";
            this.lvlVersionActual.Size = new System.Drawing.Size(123, 16);
            this.lvlVersionActual.TabIndex = 71;
            this.lvlVersionActual.Text = "DDMMYYYYxXXXX";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(144, 137);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(29, 18);
            this.lblPorcentaje.TabIndex = 70;
            this.lblPorcentaje.Text = "0%";
            // 
            // lvlVersionNueva
            // 
            this.lvlVersionNueva.AutoSize = true;
            this.lvlVersionNueva.Location = new System.Drawing.Point(727, 137);
            this.lvlVersionNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlVersionNueva.Name = "lvlVersionNueva";
            this.lvlVersionNueva.Size = new System.Drawing.Size(115, 16);
            this.lvlVersionNueva.TabIndex = 69;
            this.lvlVersionNueva.Text = "DDMMYYYYxXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Descargando ...";
            // 
            // progressDescarga
            // 
            this.progressDescarga.Location = new System.Drawing.Point(16, 166);
            this.progressDescarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressDescarga.Name = "progressDescarga";
            this.progressDescarga.Size = new System.Drawing.Size(837, 24);
            this.progressDescarga.Step = 100;
            this.progressDescarga.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Recuerda que al ser una actualizacion BETA, puede tener algunos errores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Flow_Solver.Properties.Resources.right_arrow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Flow_Solver.Properties.Resources.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(681, 130);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 28);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flow_Solver.Properties.Resources.download_beta1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "¡Agradeceriamos mucho que nos informaras los errores encuentres!";
            // 
            // actualizador_beta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 209);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lvlVersionActual);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lvlVersionNueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressDescarga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "actualizador_beta";
            this.Text = "RIT Solver for IDC 2024";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.actualizador_beta_FormClosing);
            this.Load += new System.EventHandler(this.actualizador_beta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lvlVersionActual;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lvlVersionNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressDescarga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}