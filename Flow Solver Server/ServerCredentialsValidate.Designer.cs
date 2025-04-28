namespace Flow_Solver_Server
{
    partial class ServerCredentialsValidate
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
            pictureBox1 = new PictureBox();
            txtHostname = new TextBox();
            label3 = new Label();
            btnVer = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 97, 137);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtHostname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnVer);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 31);
            panel1.Margin = new Padding(20, 21, 20, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 183);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cloud_server_64;
            pictureBox1.Location = new Point(326, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtHostname
            // 
            txtHostname.BackColor = Color.FromArgb(75, 155, 219);
            txtHostname.BorderStyle = BorderStyle.FixedSingle;
            txtHostname.Font = new Font("Consolas", 10F);
            txtHostname.Location = new Point(21, 143);
            txtHostname.Name = "txtHostname";
            txtHostname.Size = new Size(232, 23);
            txtHostname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(21, 123);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 6;
            label3.Text = "Hostname:";
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVer.BackColor = Color.FromArgb(56, 116, 164);
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Tahoma", 10F);
            btnVer.ForeColor = SystemColors.GradientInactiveCaption;
            btnVer.Image = Properties.Resources.view_16;
            btnVer.Location = new Point(206, 87);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(47, 23);
            btnVer.TabIndex = 5;
            btnVer.TextAlign = ContentAlignment.MiddleRight;
            btnVer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(75, 155, 219);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Consolas", 10F);
            txtPassword.Location = new Point(21, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(179, 23);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(75, 155, 219);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Consolas", 10F);
            txtUsername.Location = new Point(21, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(56, 116, 164);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Tahoma", 10F);
            btnAceptar.ForeColor = SystemColors.GradientInactiveCaption;
            btnAceptar.Image = Properties.Resources.test_connection_16;
            btnAceptar.Location = new Point(246, 226);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = " Validar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(56, 116, 164);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.GradientInactiveCaption;
            btnCancelar.Image = Properties.Resources.close_16;
            btnCancelar.Location = new Point(356, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = " Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ServerCredentialsValidate
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 136, 192);
            ClientSize = new Size(472, 267);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServerCredentialsValidate";
            Text = "%APP_NAME% - Credenciales del Servidor";
            FormClosing += ServerCredentialsValidate_FormClosing;
            Load += ServerCredentialsValidate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnVer;
        private TextBox txtHostname;
        private Label label3;
        private PictureBox pictureBox1;
    }
}