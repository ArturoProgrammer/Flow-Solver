namespace RIT_Solver
{
    partial class select_machine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_Machine = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipoDeEquipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_Machine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona el equipo del usuario";
            // 
            // listView_Machine
            // 
            this.listView_Machine.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView_Machine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnHostname,
            this.columnTipoDeEquipo,
            this.columnSN,
            this.columnMarca,
            this.columnModelo,
            this.columnDepartamento});
            this.listView_Machine.FullRowSelect = true;
            this.listView_Machine.HideSelection = false;
            this.listView_Machine.Location = new System.Drawing.Point(6, 19);
            this.listView_Machine.Name = "listView_Machine";
            this.listView_Machine.Size = new System.Drawing.Size(713, 189);
            this.listView_Machine.TabIndex = 0;
            this.listView_Machine.UseCompatibleStateImageBehavior = false;
            this.listView_Machine.View = System.Windows.Forms.View.Details;
            this.listView_Machine.SelectedIndexChanged += new System.EventHandler(this.listView_Machine_SelectedIndexChanged);
            this.listView_Machine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Machine_MouseDoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 30;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 180;
            // 
            // columnHostname
            // 
            this.columnHostname.Text = "Hostname";
            this.columnHostname.Width = 120;
            // 
            // columnTipoDeEquipo
            // 
            this.columnTipoDeEquipo.Text = "Tipo de Equipo";
            this.columnTipoDeEquipo.Width = 80;
            // 
            // columnSN
            // 
            this.columnSN.Text = "No. Serie";
            this.columnSN.Width = 100;
            // 
            // columnMarca
            // 
            this.columnMarca.Text = "Marca";
            // 
            // columnModelo
            // 
            this.columnModelo.Text = "Modelo";
            // 
            // columnDepartamento
            // 
            this.columnDepartamento.Text = "Departamento";
            this.columnDepartamento.Width = 100;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Image = global::RIT_Solver.Properties.Resources.check_3_16;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(564, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 26);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = " Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(654, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 26);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // select_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(749, 271);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "select_machine";
            this.Text = "Selecciona la maquina del usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.select_machine_FormClosed);
            this.Load += new System.EventHandler(this.select_machine_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnHostname;
        private System.Windows.Forms.ColumnHeader columnTipoDeEquipo;
        private System.Windows.Forms.ColumnHeader columnSN;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnModelo;
        private System.Windows.Forms.ColumnHeader columnDepartamento;
        public System.Windows.Forms.ListView listView_Machine;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader columnID;
    }
}