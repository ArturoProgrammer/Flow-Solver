namespace Flow_Solver
{
    partial class search_on_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_on_inventory));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chckboxCoincidirCeldaCompleta = new System.Windows.Forms.CheckBox();
            this.chckboxIgnorarMayusculasMinusculas = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.fatherDataGridViewEmulate = new System.Windows.Forms.DataGridView();
            this.btnBuscarInfo = new System.Windows.Forms.Button();
            this.cboxColumnaDondeBuscar = new System.Windows.Forms.ComboBox();
            this.cboxInventarioABuscar = new System.Windows.Forms.ComboBox();
            this.txtDatoBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripJobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCoincidencias = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatherDataGridViewEmulate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41837F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.58163F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chckboxCoincidirCeldaCompleta);
            this.panel1.Controls.Add(this.chckboxIgnorarMayusculasMinusculas);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnBuscarInfo);
            this.panel1.Controls.Add(this.cboxColumnaDondeBuscar);
            this.panel1.Controls.Add(this.cboxInventarioABuscar);
            this.panel1.Controls.Add(this.txtDatoBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fatherDataGridViewEmulate);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 128);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "En columna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "En inventario:";
            // 
            // chckboxCoincidirCeldaCompleta
            // 
            this.chckboxCoincidirCeldaCompleta.AutoSize = true;
            this.chckboxCoincidirCeldaCompleta.Location = new System.Drawing.Point(195, 104);
            this.chckboxCoincidirCeldaCompleta.Name = "chckboxCoincidirCeldaCompleta";
            this.chckboxCoincidirCeldaCompleta.Size = new System.Drawing.Size(227, 17);
            this.chckboxCoincidirCeldaCompleta.TabIndex = 8;
            this.chckboxCoincidirCeldaCompleta.Text = "Coincidir con todo el contenido de la celda";
            this.chckboxCoincidirCeldaCompleta.UseVisualStyleBackColor = true;
            // 
            // chckboxIgnorarMayusculasMinusculas
            // 
            this.chckboxIgnorarMayusculasMinusculas.AutoSize = true;
            this.chckboxIgnorarMayusculasMinusculas.Location = new System.Drawing.Point(9, 104);
            this.chckboxIgnorarMayusculasMinusculas.Name = "chckboxIgnorarMayusculasMinusculas";
            this.chckboxIgnorarMayusculasMinusculas.Size = new System.Drawing.Size(180, 17);
            this.chckboxIgnorarMayusculasMinusculas.TabIndex = 7;
            this.chckboxIgnorarMayusculasMinusculas.Text = "Ignorar mayusculas y minusculas";
            this.chckboxIgnorarMayusculasMinusculas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Flow_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(426, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fatherDataGridViewEmulate
            // 
            this.fatherDataGridViewEmulate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fatherDataGridViewEmulate.Location = new System.Drawing.Point(296, -59);
            this.fatherDataGridViewEmulate.Name = "fatherDataGridViewEmulate";
            this.fatherDataGridViewEmulate.Size = new System.Drawing.Size(240, 150);
            this.fatherDataGridViewEmulate.TabIndex = 5;
            this.fatherDataGridViewEmulate.Visible = false;
            // 
            // btnBuscarInfo
            // 
            this.btnBuscarInfo.Image = global::Flow_Solver.Properties.Resources.search_16;
            this.btnBuscarInfo.Location = new System.Drawing.Point(426, 21);
            this.btnBuscarInfo.Name = "btnBuscarInfo";
            this.btnBuscarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarInfo.TabIndex = 4;
            this.btnBuscarInfo.Text = "Buscar";
            this.btnBuscarInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarInfo.UseVisualStyleBackColor = true;
            this.btnBuscarInfo.Click += new System.EventHandler(this.btnBuscarInfo_Click);
            // 
            // cboxColumnaDondeBuscar
            // 
            this.cboxColumnaDondeBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxColumnaDondeBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxColumnaDondeBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColumnaDondeBuscar.FormattingEnabled = true;
            this.cboxColumnaDondeBuscar.Location = new System.Drawing.Point(169, 69);
            this.cboxColumnaDondeBuscar.Name = "cboxColumnaDondeBuscar";
            this.cboxColumnaDondeBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboxColumnaDondeBuscar.TabIndex = 3;
            // 
            // cboxInventarioABuscar
            // 
            this.cboxInventarioABuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxInventarioABuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxInventarioABuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInventarioABuscar.FormattingEnabled = true;
            this.cboxInventarioABuscar.Location = new System.Drawing.Point(7, 70);
            this.cboxInventarioABuscar.Name = "cboxInventarioABuscar";
            this.cboxInventarioABuscar.Size = new System.Drawing.Size(156, 21);
            this.cboxInventarioABuscar.TabIndex = 2;
            this.cboxInventarioABuscar.SelectedIndexChanged += new System.EventHandler(this.cboxInventarioABuscar_SelectedIndexChanged);
            // 
            // txtDatoBuscar
            // 
            this.txtDatoBuscar.Location = new System.Drawing.Point(9, 23);
            this.txtDatoBuscar.Name = "txtDatoBuscar";
            this.txtDatoBuscar.Size = new System.Drawing.Size(413, 20);
            this.txtDatoBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripJobStatus,
            this.toolStripStatusLabel2,
            this.toolStripCoincidencias});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripJobStatus
            // 
            this.toolStripJobStatus.Name = "toolStripJobStatus";
            this.toolStripJobStatus.Size = new System.Drawing.Size(35, 17);
            this.toolStripJobStatus.Text = "Listo!";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripCoincidencias
            // 
            this.toolStripCoincidencias.Name = "toolStripCoincidencias";
            this.toolStripCoincidencias.Size = new System.Drawing.Size(484, 17);
            this.toolStripCoincidencias.Spring = true;
            this.toolStripCoincidencias.Text = "%NO. ENCONT.% Coincidencias encontradas";
            // 
            // search_on_inventory
            // 
            this.AcceptButton = this.btnBuscarInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(544, 438);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "search_on_inventory";
            this.Text = "Buscar en inventario";
            this.Load += new System.EventHandler(this.search_on_inventory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatherDataGridViewEmulate)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtDatoBuscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboxColumnaDondeBuscar;
        public System.Windows.Forms.ComboBox cboxInventarioABuscar;
        private System.Windows.Forms.Button btnBuscarInfo;
        public System.Windows.Forms.DataGridView fatherDataGridViewEmulate;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox chckboxIgnorarMayusculasMinusculas;
        public System.Windows.Forms.CheckBox chckboxCoincidirCeldaCompleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripJobStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCoincidencias;
    }
}