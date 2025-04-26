namespace RIT_Solver
{
    partial class solicitar_toner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solicitar_toner));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAsuntoPt_UNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAsuntoPt_DOS = new System.Windows.Forms.TextBox();
            this.rtBoxMensaje = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAñadirAdjunto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxImpresora = new System.Windows.Forms.ComboBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.chckBoxCyan = new System.Windows.Forms.CheckBox();
            this.chckBoxMagenta = new System.Windows.Forms.CheckBox();
            this.chckBoxAmarillo = new System.Windows.Forms.CheckBox();
            this.chckBoxNegro = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericCantidadCyan = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericCantidadMagenta = new System.Windows.Forms.NumericUpDown();
            this.numericCantidadAmarillo = new System.Windows.Forms.NumericUpDown();
            this.numericCantidadNegro = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listAdjuntos = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chckboxTodos = new System.Windows.Forms.CheckBox();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadCyan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadNegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(130, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(449, 38);
            label1.TabIndex = 4;
            label1.Text = "Preparando solicitud de toner";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::RIT_Solver.Properties.Resources.send_mail_16;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(470, 274);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 28);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(556, 275);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 28);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RIT_Solver.Properties.Resources.toners;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Las solicitudes en ocasiones pueden demorar al momento de enviar";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(12, 145);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(181, 20);
            this.txtProveedor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email del Proveedor";
            // 
            // txtAsuntoPt_UNO
            // 
            this.txtAsuntoPt_UNO.Location = new System.Drawing.Point(12, 184);
            this.txtAsuntoPt_UNO.Name = "txtAsuntoPt_UNO";
            this.txtAsuntoPt_UNO.ReadOnly = true;
            this.txtAsuntoPt_UNO.Size = new System.Drawing.Size(335, 20);
            this.txtAsuntoPt_UNO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Asunto";
            // 
            // txtAsuntoPt_DOS
            // 
            this.txtAsuntoPt_DOS.Location = new System.Drawing.Point(345, 184);
            this.txtAsuntoPt_DOS.Name = "txtAsuntoPt_DOS";
            this.txtAsuntoPt_DOS.Size = new System.Drawing.Size(291, 20);
            this.txtAsuntoPt_DOS.TabIndex = 6;
            // 
            // rtBoxMensaje
            // 
            this.rtBoxMensaje.Location = new System.Drawing.Point(12, 100);
            this.rtBoxMensaje.Name = "rtBoxMensaje";
            this.rtBoxMensaje.Size = new System.Drawing.Size(335, 173);
            this.rtBoxMensaje.TabIndex = 7;
            this.rtBoxMensaje.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mensaje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(504, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Archivos Adjuntos";
            // 
            // btnAñadirAdjunto
            // 
            this.btnAñadirAdjunto.Location = new System.Drawing.Point(604, 81);
            this.btnAñadirAdjunto.Name = "btnAñadirAdjunto";
            this.btnAñadirAdjunto.Size = new System.Drawing.Size(33, 23);
            this.btnAñadirAdjunto.TabIndex = 16;
            this.btnAñadirAdjunto.Text = "+";
            this.btnAñadirAdjunto.UseVisualStyleBackColor = true;
            this.btnAñadirAdjunto.Click += new System.EventHandler(this.btnAñadirAdjunto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(196, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Impresora";
            // 
            // cBoxImpresora
            // 
            this.cBoxImpresora.FormattingEnabled = true;
            this.cBoxImpresora.Location = new System.Drawing.Point(199, 145);
            this.cBoxImpresora.Name = "cBoxImpresora";
            this.cBoxImpresora.Size = new System.Drawing.Size(127, 21);
            this.cBoxImpresora.TabIndex = 2;
            this.cBoxImpresora.SelectedIndexChanged += new System.EventHandler(this.cBoxImpresora_SelectedIndexChanged);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(470, 146);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(166, 20);
            this.txtLocalidad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(467, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Localidad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(352, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tintas";
            // 
            // chckBoxCyan
            // 
            this.chckBoxCyan.AutoSize = true;
            this.chckBoxCyan.BackColor = System.Drawing.Color.Transparent;
            this.chckBoxCyan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckBoxCyan.Location = new System.Drawing.Point(3, 0);
            this.chckBoxCyan.Name = "chckBoxCyan";
            this.chckBoxCyan.Size = new System.Drawing.Size(50, 17);
            this.chckBoxCyan.TabIndex = 8;
            this.chckBoxCyan.Text = "Cyan";
            this.chckBoxCyan.UseVisualStyleBackColor = false;
            this.chckBoxCyan.CheckedChanged += new System.EventHandler(this.chckBoxCyan_CheckedChanged);
            // 
            // chckBoxMagenta
            // 
            this.chckBoxMagenta.AutoSize = true;
            this.chckBoxMagenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chckBoxMagenta.Location = new System.Drawing.Point(3, 0);
            this.chckBoxMagenta.Name = "chckBoxMagenta";
            this.chckBoxMagenta.Size = new System.Drawing.Size(68, 17);
            this.chckBoxMagenta.TabIndex = 10;
            this.chckBoxMagenta.Text = "Magenta";
            this.chckBoxMagenta.UseVisualStyleBackColor = true;
            this.chckBoxMagenta.CheckedChanged += new System.EventHandler(this.chckBoxMagenta_CheckedChanged);
            // 
            // chckBoxAmarillo
            // 
            this.chckBoxAmarillo.AutoSize = true;
            this.chckBoxAmarillo.Location = new System.Drawing.Point(3, 0);
            this.chckBoxAmarillo.Name = "chckBoxAmarillo";
            this.chckBoxAmarillo.Size = new System.Drawing.Size(62, 17);
            this.chckBoxAmarillo.TabIndex = 12;
            this.chckBoxAmarillo.Text = "Amarillo";
            this.chckBoxAmarillo.UseVisualStyleBackColor = true;
            this.chckBoxAmarillo.CheckedChanged += new System.EventHandler(this.chckBoxAmarillo_CheckedChanged);
            // 
            // chckBoxNegro
            // 
            this.chckBoxNegro.AutoSize = true;
            this.chckBoxNegro.ForeColor = System.Drawing.Color.Snow;
            this.chckBoxNegro.Location = new System.Drawing.Point(2, 0);
            this.chckBoxNegro.Name = "chckBoxNegro";
            this.chckBoxNegro.Size = new System.Drawing.Size(55, 17);
            this.chckBoxNegro.TabIndex = 14;
            this.chckBoxNegro.Text = "Negro";
            this.chckBoxNegro.UseVisualStyleBackColor = true;
            this.chckBoxNegro.CheckedChanged += new System.EventHandler(this.chckBoxNegro_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(425, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cantidad";
            // 
            // numericCantidadCyan
            // 
            this.numericCantidadCyan.Enabled = false;
            this.numericCantidadCyan.Location = new System.Drawing.Point(430, 132);
            this.numericCantidadCyan.Name = "numericCantidadCyan";
            this.numericCantidadCyan.Size = new System.Drawing.Size(69, 20);
            this.numericCantidadCyan.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.chckBoxCyan);
            this.panel1.Location = new System.Drawing.Point(352, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 17);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Controls.Add(this.chckBoxMagenta);
            this.panel2.Location = new System.Drawing.Point(352, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 17);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.chckBoxAmarillo);
            this.panel3.Location = new System.Drawing.Point(352, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 17);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.chckBoxNegro);
            this.panel4.Location = new System.Drawing.Point(352, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(71, 17);
            this.panel4.TabIndex = 32;
            // 
            // numericCantidadMagenta
            // 
            this.numericCantidadMagenta.Enabled = false;
            this.numericCantidadMagenta.Location = new System.Drawing.Point(429, 155);
            this.numericCantidadMagenta.Name = "numericCantidadMagenta";
            this.numericCantidadMagenta.Size = new System.Drawing.Size(69, 20);
            this.numericCantidadMagenta.TabIndex = 11;
            // 
            // numericCantidadAmarillo
            // 
            this.numericCantidadAmarillo.Enabled = false;
            this.numericCantidadAmarillo.Location = new System.Drawing.Point(429, 178);
            this.numericCantidadAmarillo.Name = "numericCantidadAmarillo";
            this.numericCantidadAmarillo.Size = new System.Drawing.Size(69, 20);
            this.numericCantidadAmarillo.TabIndex = 13;
            // 
            // numericCantidadNegro
            // 
            this.numericCantidadNegro.Enabled = false;
            this.numericCantidadNegro.Location = new System.Drawing.Point(429, 202);
            this.numericCantidadNegro.Name = "numericCantidadNegro";
            this.numericCantidadNegro.Size = new System.Drawing.Size(69, 20);
            this.numericCantidadNegro.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(329, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(332, 146);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(134, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, -31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // listAdjuntos
            // 
            this.listAdjuntos.FormattingEnabled = true;
            this.listAdjuntos.Location = new System.Drawing.Point(506, 106);
            this.listAdjuntos.Name = "listAdjuntos";
            this.listAdjuntos.Size = new System.Drawing.Size(131, 147);
            this.listAdjuntos.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.listAdjuntos);
            this.panel5.Controls.Add(this.chckboxTodos);
            this.panel5.Controls.Add(this.btnReduce);
            this.panel5.Controls.Add(this.btnPlus);
            this.panel5.Controls.Add(this.btnCerrar);
            this.panel5.Controls.Add(this.btnEnviar);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.numericCantidadCyan);
            this.panel5.Controls.Add(this.numericCantidadMagenta);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.numericCantidadAmarillo);
            this.panel5.Controls.Add(this.numericCantidadNegro);
            this.panel5.Controls.Add(this.btnAñadirAdjunto);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.rtBoxMensaje);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(0, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(651, 315);
            this.panel5.TabIndex = 36;
            // 
            // chckboxTodos
            // 
            this.chckboxTodos.AutoSize = true;
            this.chckboxTodos.BackColor = System.Drawing.Color.Transparent;
            this.chckboxTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckboxTodos.Location = new System.Drawing.Point(354, 110);
            this.chckboxTodos.Name = "chckboxTodos";
            this.chckboxTodos.Size = new System.Drawing.Size(56, 17);
            this.chckboxTodos.TabIndex = 9;
            this.chckboxTodos.Text = "Todos";
            this.chckboxTodos.UseVisualStyleBackColor = false;
            this.chckboxTodos.CheckedChanged += new System.EventHandler(this.chckboxTodos_CheckedChanged);
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(465, 103);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(33, 23);
            this.btnReduce.TabIndex = 29;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(430, 103);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 23);
            this.btnPlus.TabIndex = 28;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // solicitar_toner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBoxImpresora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAsuntoPt_DOS);
            this.Controls.Add(this.txtAsuntoPt_UNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(663, 478);
            this.Name = "solicitar_toner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar de Toner";
            this.Load += new System.EventHandler(this.solicitar_toner_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.solicitar_toner_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadCyan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadNegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtAsuntoPt_UNO;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAsuntoPt_DOS;
        private System.Windows.Forms.RichTextBox rtBoxMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAñadirAdjunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxImpresora;
        public System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chckBoxCyan;
        private System.Windows.Forms.CheckBox chckBoxMagenta;
        private System.Windows.Forms.CheckBox chckBoxAmarillo;
        private System.Windows.Forms.CheckBox chckBoxNegro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericCantidadCyan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericCantidadMagenta;
        private System.Windows.Forms.NumericUpDown numericCantidadAmarillo;
        private System.Windows.Forms.NumericUpDown numericCantidadNegro;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listAdjuntos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.CheckBox chckboxTodos;
    }
}