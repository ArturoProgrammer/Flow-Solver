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
            flTextBoxLabelJoint1 = new FlowControls.flTextBoxLabelJoint();
            flTextBoxLabelJoint2 = new FlowControls.flTextBoxLabelJoint();
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
            // flTextBoxLabelJoint1
            // 
            flTextBoxLabelJoint1.EntryFont = new System.Drawing.Font("Consolas", 9F);
            flTextBoxLabelJoint1.InputContentType = FlowControls.InputMode.GENERAL;
            flTextBoxLabelJoint1.Label = "Usuario:";
            flTextBoxLabelJoint1.Location = new System.Drawing.Point(55, 119);
            flTextBoxLabelJoint1.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint1.Name = "flTextBoxLabelJoint1";
            flTextBoxLabelJoint1.Placeholder = "<Ingresa el usuario existente>";
            flTextBoxLabelJoint1.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint1.Size = new System.Drawing.Size(345, 30);
            flTextBoxLabelJoint1.TabIndex = 1;
            flTextBoxLabelJoint1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint1.TextBoxWidth = 200;
            flTextBoxLabelJoint1.Value = "";
            // 
            // flTextBoxLabelJoint2
            // 
            flTextBoxLabelJoint2.EntryFont = new System.Drawing.Font("Consolas", 9F);
            flTextBoxLabelJoint2.InputContentType = FlowControls.InputMode.PASSWORD;
            flTextBoxLabelJoint2.Label = "Contraseña:";
            flTextBoxLabelJoint2.Location = new System.Drawing.Point(55, 155);
            flTextBoxLabelJoint2.MinimumSize = new System.Drawing.Size(100, 30);
            flTextBoxLabelJoint2.Name = "flTextBoxLabelJoint2";
            flTextBoxLabelJoint2.Placeholder = "<Ingresa la contraseña del usuario>";
            flTextBoxLabelJoint2.RootLineColor = System.Drawing.Color.Gray;
            flTextBoxLabelJoint2.Size = new System.Drawing.Size(345, 30);
            flTextBoxLabelJoint2.TabIndex = 2;
            flTextBoxLabelJoint2.TextBoxBackColor = System.Drawing.SystemColors.Window;
            flTextBoxLabelJoint2.TextBoxWidth = 200;
            flTextBoxLabelJoint2.Value = "";
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
            ClientSize = new System.Drawing.Size(468, 291);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(flTextBoxLabelJoint2);
            Controls.Add(flTextBoxLabelJoint1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "login_form";
            Text = "Flow Solver - Login";
            Load += login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlowControls.flCustomLabel flCustomLabel1;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint1;
        private FlowControls.flTextBoxLabelJoint flTextBoxLabelJoint2;
        private System.Windows.Forms.Label label1;
        private FlowControls.flCustomButton btnIngresar;
        private System.Windows.Forms.Label label2;
        private FlowControls.flCustomButton btnSalir;
    }
}