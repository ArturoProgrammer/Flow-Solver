namespace Flow_Solver
{
    partial class login_form
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
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            flCustomLabel1 = new FlowControls.flCustomLabel();
            txtUsuario = new FlowControls.flTextBoxLabelJoint();
            txtContraseña = new FlowControls.flTextBoxLabelJoint();
            btnIngresar = new FlowControls.flCustomButton();
            btnSalir = new FlowControls.flCustomButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flCustomLabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(468, 100);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(85, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(181, 15);
            label2.TabIndex = 2;
            label2.Text = "Copyright Adare Systems 2025 ©";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(307, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Beta";
            // 
            // flCustomLabel1
            // 
            flCustomLabel1.AutoSize = true;
            flCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Italic);
            flCustomLabel1.ImagePadding = 5;
            flCustomLabel1.LeftImage = Properties.Resources.Flow_Solver_OldLogo_64;
            flCustomLabel1.Location = new System.Drawing.Point(12, 9);
            flCustomLabel1.Name = "flCustomLabel1";
            flCustomLabel1.Size = new System.Drawing.Size(303, 64);
            flCustomLabel1.TabIndex = 0;
            flCustomLabel1.Text = "Flow Solver";
            flCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.EntryFont = new System.Drawing.Font("Consolas", 9F);
            txtUsuario.InputContentType = FlowControls.InputMode.GENERAL;
            txtUsuario.Label = "Usuario:";
            txtUsuario.Location = new System.Drawing.Point(55, 119);
            txtUsuario.MinimumSize = new System.Drawing.Size(100, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Placeholder = "<Ingresa el usuario existente>";
            txtUsuario.RootLineColor = System.Drawing.Color.Gray;
            txtUsuario.Size = new System.Drawing.Size(345, 30);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtUsuario.TextBoxWidth = 200;
            txtUsuario.Value = "";
            // 
            // txtContraseña
            // 
            txtContraseña.EntryFont = new System.Drawing.Font("Consolas", 9F);
            txtContraseña.InputContentType = FlowControls.InputMode.PASSWORD;
            txtContraseña.Label = "Contraseña:";
            txtContraseña.Location = new System.Drawing.Point(55, 155);
            txtContraseña.MinimumSize = new System.Drawing.Size(100, 30);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Placeholder = "<Ingresa la contraseña del usuario>";
            txtContraseña.RootLineColor = System.Drawing.Color.Gray;
            txtContraseña.Size = new System.Drawing.Size(345, 30);
            txtContraseña.TabIndex = 2;
            txtContraseña.TextBoxBackColor = System.Drawing.SystemColors.Window;
            txtContraseña.TextBoxWidth = 200;
            txtContraseña.Value = "";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnIngresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnIngresar.Image = Properties.Resources.check_16;
            btnIngresar.Location = new System.Drawing.Point(237, 251);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(104, 28);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = " Ingresar";
            btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSalir.Image = Properties.Resources.close_161;
            btnSalir.Location = new System.Drawing.Point(352, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(104, 28);
            btnSalir.TabIndex = 4;
            btnSalir.Text = " Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(468, 291);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "login_form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Flow Solver - Login";
            Load += login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlowControls.flCustomLabel flCustomLabel1;
        private FlowControls.flTextBoxLabelJoint txtUsuario;
        private FlowControls.flTextBoxLabelJoint txtContraseña;
        private System.Windows.Forms.Label label1;
        private FlowControls.flCustomButton btnIngresar;
        private System.Windows.Forms.Label label2;
        private FlowControls.flCustomButton btnSalir;
    }
}