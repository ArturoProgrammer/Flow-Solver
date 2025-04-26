namespace RIT_Solver
{
    partial class inventario_lista_usuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario_lista_usuarios));
            this.lblUsuariosCargados = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtUsuarioDeRed = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtNumeroDeEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarModificaciones = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblUsuarioDeRed = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblNumeroDeEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.btnImportarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuariosCargados
            // 
            this.lblUsuariosCargados.AutoSize = true;
            this.lblUsuariosCargados.Location = new System.Drawing.Point(14, 341);
            this.lblUsuariosCargados.Name = "lblUsuariosCargados";
            this.lblUsuariosCargados.Size = new System.Drawing.Size(0, 13);
            this.lblUsuariosCargados.TabIndex = 25;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Image = global::RIT_Solver.Properties.Resources.delete_16;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(104, 366);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarUsuario.TabIndex = 24;
            this.btnEliminarUsuario.Text = " Eliminar";
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // button1
            // 
            this.button1.Image = global::RIT_Solver.Properties.Resources.reload_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(14, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = " Recargar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtLocalidad);
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Controls.Add(this.txtCorreoElectronico);
            this.groupBox2.Controls.Add(this.txtUsuarioDeRed);
            this.groupBox2.Controls.Add(this.txtExtension);
            this.groupBox2.Controls.Add(this.txtNumeroDeEmpleado);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(188, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 203);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar usuario";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(6, 175);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(212, 20);
            this.txtLocalidad.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtLocalidad, "Para cambiar este dato, acceda a la Tabla de Vinculacion en Configuracion");
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDepartamento.Location = new System.Drawing.Point(6, 149);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(212, 20);
            this.txtDepartamento.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDepartamento, "Cambia el departamento del usuario");
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(6, 123);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(212, 20);
            this.txtCorreoElectronico.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtCorreoElectronico, "Cambia el email del usuario");
            // 
            // txtUsuarioDeRed
            // 
            this.txtUsuarioDeRed.Location = new System.Drawing.Point(6, 97);
            this.txtUsuarioDeRed.Name = "txtUsuarioDeRed";
            this.txtUsuarioDeRed.Size = new System.Drawing.Size(212, 20);
            this.txtUsuarioDeRed.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUsuarioDeRed, "Cambia el usuario de red");
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(6, 71);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(212, 20);
            this.txtExtension.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtExtension, "Cambia la extension telefonica del usuario");
            // 
            // txtNumeroDeEmpleado
            // 
            this.txtNumeroDeEmpleado.Location = new System.Drawing.Point(6, 45);
            this.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado";
            this.txtNumeroDeEmpleado.Size = new System.Drawing.Size(212, 20);
            this.txtNumeroDeEmpleado.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumeroDeEmpleado, "Cambia el numero del empleado");
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Cambia el nombre de la localidad");
            // 
            // btnGuardarModificaciones
            // 
            this.btnGuardarModificaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarModificaciones.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGuardarModificaciones.Image = global::RIT_Solver.Properties.Resources.save_16;
            this.btnGuardarModificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarModificaciones.Location = new System.Drawing.Point(190, 266);
            this.btnGuardarModificaciones.Name = "btnGuardarModificaciones";
            this.btnGuardarModificaciones.Size = new System.Drawing.Size(224, 34);
            this.btnGuardarModificaciones.TabIndex = 21;
            this.btnGuardarModificaciones.Text = " Guardar Modificaciones";
            this.btnGuardarModificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarModificaciones.UseVisualStyleBackColor = false;
            this.btnGuardarModificaciones.Click += new System.EventHandler(this.btnGuardarModificaciones_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Image = global::RIT_Solver.Properties.Resources.plus_16;
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUsuario.Location = new System.Drawing.Point(188, 306);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(110, 34);
            this.btnCrearUsuario.TabIndex = 20;
            this.btnCrearUsuario.Text = " Crear Usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblLocalidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblUsuarioDeRed);
            this.groupBox1.Controls.Add(this.lblExtension);
            this.groupBox1.Controls.Add(this.lblNumeroDeEmpleado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 159);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del usuario";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(68, 128);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(0, 13);
            this.lblLocalidad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Localidad:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(82, 108);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(0, 13);
            this.lblDepartamento.TabIndex = 11;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(101, 89);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblCorreoElectronico.TabIndex = 10;
            // 
            // lblUsuarioDeRed
            // 
            this.lblUsuarioDeRed.AutoSize = true;
            this.lblUsuarioDeRed.Location = new System.Drawing.Point(83, 71);
            this.lblUsuarioDeRed.Name = "lblUsuarioDeRed";
            this.lblUsuarioDeRed.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioDeRed.TabIndex = 9;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(33, 53);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(0, 13);
            this.lblExtension.TabIndex = 8;
            // 
            // lblNumeroDeEmpleado
            // 
            this.lblNumeroDeEmpleado.AutoSize = true;
            this.lblNumeroDeEmpleado.Location = new System.Drawing.Point(82, 34);
            this.lblNumeroDeEmpleado.Name = "lblNumeroDeEmpleado";
            this.lblNumeroDeEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroDeEmpleado.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario de red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ext.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num. de Emp.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.Location = new System.Drawing.Point(12, 12);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(170, 446);
            this.listUsuarios.Sorted = true;
            this.listUsuarios.TabIndex = 17;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            this.listUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listUsuarios_KeyDown);
            // 
            // btnImportarUsuario
            // 
            this.btnImportarUsuario.Enabled = false;
            this.btnImportarUsuario.Image = global::RIT_Solver.Properties.Resources.importar_16;
            this.btnImportarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarUsuario.Location = new System.Drawing.Point(304, 306);
            this.btnImportarUsuario.Name = "btnImportarUsuario";
            this.btnImportarUsuario.Size = new System.Drawing.Size(110, 34);
            this.btnImportarUsuario.TabIndex = 19;
            this.btnImportarUsuario.Text = " Cargar Usuario";
            this.btnImportarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarUsuario.UseVisualStyleBackColor = true;
            this.btnImportarUsuario.Click += new System.EventHandler(this.btnImportarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::RIT_Solver.Properties.Resources.cancel_16;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(324, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Importa los datos del usuario seleccionado al formulario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblUsuariosCargados);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGuardarModificaciones);
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.btnImportarUsuario);
            this.panel1.Controls.Add(this.btnCrearUsuario);
            this.panel1.Location = new System.Drawing.Point(-2, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 404);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // inventario_lista_usuarios
            // 
            this.AcceptButton = this.btnGuardarModificaciones;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(424, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inventario_lista_usuarios";
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.inventario_lista_usuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inventario_lista_usuarios_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuariosCargados;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtUsuarioDeRed;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtNumeroDeEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardarModificaciones;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblUsuarioDeRed;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblNumeroDeEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUsuarios;
        private System.Windows.Forms.Button btnImportarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Panel panel1;
    }
}