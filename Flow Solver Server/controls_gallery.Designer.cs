namespace Flow_Solver_Server
{
    partial class controls_gallery
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
            txtUsername = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(75, 155, 219);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Consolas", 10F);
            txtUsername.Location = new Point(33, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 23);
            txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Usuario:";
            // 
            // controls_gallery
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 136, 192);
            ClientSize = new Size(610, 388);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10F);
            Name = "controls_gallery";
            Text = "controls_gallery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
    }
}