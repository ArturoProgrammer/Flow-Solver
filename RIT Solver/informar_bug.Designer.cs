namespace Flow_Solver
{
    partial class informar_bug
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informar_bug));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richtbMensaje = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreAsunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(103, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 38);
            label2.TabIndex = 2;
            label2.Text = "¡Lo siento! :(";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            label3.Location = new System.Drawing.Point(106, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(414, 20);
            label3.TabIndex = 3;
            label3.Text = "Trabajaremos cuanto antes para resolver nuestro error";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFalla);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.richtbMensaje);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPreAsunto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 313);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Muchas gracias por reportar nuestras fallas, cuanta mas informacion nos proporcio" +
    "nes sera mejor para nosotros!";
            // 
            // txtFalla
            // 
            this.txtFalla.Location = new System.Drawing.Point(281, 25);
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.Size = new System.Drawing.Size(243, 20);
            this.txtFalla.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Falla *";
            // 
            // richtbMensaje
            // 
            this.richtbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtbMensaje.Location = new System.Drawing.Point(6, 68);
            this.richtbMensaje.Name = "richtbMensaje";
            this.richtbMensaje.Size = new System.Drawing.Size(518, 206);
            this.richtbMensaje.TabIndex = 2;
            this.richtbMensaje.Text = "";
            this.richtbMensaje.TextChanged += new System.EventHandler(this.richtbMensaje_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mensaje *";
            // 
            // txtPreAsunto
            // 
            this.txtPreAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreAsunto.Enabled = false;
            this.txtPreAsunto.Location = new System.Drawing.Point(6, 25);
            this.txtPreAsunto.Name = "txtPreAsunto";
            this.txtPreAsunto.ReadOnly = true;
            this.txtPreAsunto.Size = new System.Drawing.Size(264, 20);
            this.txtPreAsunto.TabIndex = 1;
            this.txtPreAsunto.Text = "Informe de falla en sistema // RIT Solver for IDC 2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asunto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Flow_Solver.Properties.Resources.cancel_16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(384, 287);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Location = new System.Drawing.Point(-3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 335);
            this.panel3.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::Flow_Solver.Properties.Resources.send_mail_16;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(465, 287);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 30);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = " Enviar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flow_Solver.Properties.Resources.bug_report;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // informar_bug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informar_bug";
            this.Text = "Informar de Bug";
            this.Load += new System.EventHandler(this.informar_bug_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.informar_bug_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richtbMensaje;
        private System.Windows.Forms.Panel panel3;
    }
}