namespace Flow_Solver_Server
{
    partial class login
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
            panel1 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 85);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(56, 116, 164);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.GradientInactiveCaption;
            btnCancelar.Image = Properties.Resources.close_16;
            btnCancelar.Location = new Point(469, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = " Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(56, 116, 164);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Tahoma", 10F);
            btnAceptar.ForeColor = SystemColors.GradientInactiveCaption;
            btnAceptar.Image = Properties.Resources.check_16;
            btnAceptar.Location = new Point(359, 310);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = " Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 351);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10F);
            Name = "login";
            Text = "%APP_NAME% - Login";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}