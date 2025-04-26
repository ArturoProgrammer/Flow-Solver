namespace RIT_Solver.Centro_de_Control
{
    partial class equipo_completado
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
            this.msktxtNoTicket = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRITPath = new System.Windows.Forms.TextBox();
            this.btnExaminarRIT = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckboxEquipoCompletado = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExaminarEvidncia = new System.Windows.Forms.Button();
            this.txtEvidenciaPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. de Ticket :";
            // 
            // msktxtNoTicket
            // 
            this.msktxtNoTicket.Location = new System.Drawing.Point(4, 35);
            this.msktxtNoTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktxtNoTicket.Mask = "000000";
            this.msktxtNoTicket.Name = "msktxtNoTicket";
            this.msktxtNoTicket.Size = new System.Drawing.Size(71, 20);
            this.msktxtNoTicket.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Path del RIT PDF (firmado):";
            // 
            // txtRITPath
            // 
            this.txtRITPath.Enabled = false;
            this.txtRITPath.Location = new System.Drawing.Point(7, 74);
            this.txtRITPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRITPath.Name = "txtRITPath";
            this.txtRITPath.ReadOnly = true;
            this.txtRITPath.Size = new System.Drawing.Size(287, 20);
            this.txtRITPath.TabIndex = 3;
            // 
            // btnExaminarRIT
            // 
            this.btnExaminarRIT.Image = global::RIT_Solver.Properties.Resources.buscar_16;
            this.btnExaminarRIT.Location = new System.Drawing.Point(297, 74);
            this.btnExaminarRIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExaminarRIT.Name = "btnExaminarRIT";
            this.btnExaminarRIT.Size = new System.Drawing.Size(30, 20);
            this.btnExaminarRIT.TabIndex = 4;
            this.btnExaminarRIT.UseVisualStyleBackColor = true;
            this.btnExaminarRIT.Click += new System.EventHandler(this.btnExaminarRIT_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Image = global::RIT_Solver.Properties.Resources.check_3_16;
            this.btnCompletar.Location = new System.Drawing.Point(202, 160);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(86, 27);
            this.btnCompletar.TabIndex = 6;
            this.btnCompletar.Text = " Completar";
            this.btnCompletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.Location = new System.Drawing.Point(294, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExaminarEvidncia);
            this.groupBox1.Controls.Add(this.txtEvidenciaPath);
            this.groupBox1.Controls.Add(this.chckboxEquipoCompletado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msktxtNoTicket);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExaminarRIT);
            this.groupBox1.Controls.Add(this.txtRITPath);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(371, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos faltantes";
            // 
            // chckboxEquipoCompletado
            // 
            this.chckboxEquipoCompletado.AutoSize = true;
            this.chckboxEquipoCompletado.Checked = true;
            this.chckboxEquipoCompletado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckboxEquipoCompletado.Enabled = false;
            this.chckboxEquipoCompletado.Location = new System.Drawing.Point(247, 16);
            this.chckboxEquipoCompletado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chckboxEquipoCompletado.Name = "chckboxEquipoCompletado";
            this.chckboxEquipoCompletado.Size = new System.Drawing.Size(117, 17);
            this.chckboxEquipoCompletado.TabIndex = 5;
            this.chckboxEquipoCompletado.Text = "Equipo completado";
            this.chckboxEquipoCompletado.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path de la evidencia:";
            // 
            // btnExaminarEvidncia
            // 
            this.btnExaminarEvidncia.Image = global::RIT_Solver.Properties.Resources.buscar_16;
            this.btnExaminarEvidncia.Location = new System.Drawing.Point(297, 115);
            this.btnExaminarEvidncia.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminarEvidncia.Name = "btnExaminarEvidncia";
            this.btnExaminarEvidncia.Size = new System.Drawing.Size(30, 20);
            this.btnExaminarEvidncia.TabIndex = 8;
            this.btnExaminarEvidncia.UseVisualStyleBackColor = true;
            this.btnExaminarEvidncia.Click += new System.EventHandler(this.btnExaminarEvidncia_Click);
            // 
            // txtEvidenciaPath
            // 
            this.txtEvidenciaPath.Enabled = false;
            this.txtEvidenciaPath.Location = new System.Drawing.Point(7, 115);
            this.txtEvidenciaPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvidenciaPath.Name = "txtEvidenciaPath";
            this.txtEvidenciaPath.ReadOnly = true;
            this.txtEvidenciaPath.Size = new System.Drawing.Size(287, 20);
            this.txtEvidenciaPath.TabIndex = 7;
            // 
            // equipo_completado
            // 
            this.AcceptButton = this.btnCompletar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(390, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "equipo_completado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marcar equipo completado";
            this.Load += new System.EventHandler(this.equipo_completado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtNoTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRITPath;
        private System.Windows.Forms.Button btnExaminarRIT;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chckboxEquipoCompletado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExaminarEvidncia;
        private System.Windows.Forms.TextBox txtEvidenciaPath;
    }
}