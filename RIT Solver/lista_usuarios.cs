using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using CustomMessageBox;
using Windows.Media.Core;


namespace RIT_Solver
{
    public partial class lista_usuarios : Form
    {
        private rit_mdi_form padre;
        private reasignacion_de_equipo padre_reasignacion_equipo;
        private main padre_main;
        string cards_path = $@"{Application.StartupPath}\UsersCard\";
        public Usuario user = new Usuario(); // Declaracion de objeto usuario actual seleccionado


        /// <summary>
        /// Sobrecarga para seleccion de usuario en RIT Form MDI
        /// </summary>
        /// <param name="LegacyForm"></param>
        public lista_usuarios(rit_mdi_form LegacyForm)
        {
            InitializeComponent();
            padre = LegacyForm;
            _InitialLoadProceds();
        }

        /// <summary>
        /// Sobrecarga para seleccion de usuario en RIT Form MDI que desean visualizar el usuario actualmente seleccionado
        /// </summary>
        /// <param name="LegacyForm"></param>
        public lista_usuarios(rit_mdi_form LegacyForm, string SelectedUser)
        {
            InitializeComponent();
            padre = LegacyForm;
            _InitialLoadProceds();

            if (this.listUsuarios.Items.Contains(SelectedUser))
            {
                this.listUsuarios.SelectedItem = SelectedUser;
            } else
            {
                MessageBox.Show($"No se encontro al usuario < {SelectedUser} > en el listado de usuario!", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sobrecarga en blanco
        /// </summary>
        /// <param name="LegacyForm"></param>
        public lista_usuarios(main LegacyForm)
        {
            InitializeComponent();
            padre_main = LegacyForm;
            this.btnImportarUsuario.Enabled = false;
            _InitialLoadProceds();
        }

        /// <summary>
        /// Sobrecarga para reasignacion de equipo
        /// </summary>
        /// <param name="LegacyForm"></param>
        public lista_usuarios (reasignacion_de_equipo LegacyForm)
        {
            InitializeComponent();

            padre_reasignacion_equipo = LegacyForm;

            this.btnImportarUsuario.Text = " Seleccionar Usuario";
            _InitialLoadProceds();
        }

        public lista_usuarios(string SelectedUser)
        {
            InitializeComponent();
            this.btnImportarUsuario.Enabled = false;
            _InitialLoadProceds();

            if (this.listUsuarios.Items.Contains(SelectedUser))
            {
                this.listUsuarios.SelectedItem = SelectedUser;
            }
            else
            {
                MessageBox.Show($"No se encontro al usuario < {SelectedUser} > en el listado de usuario!", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ¿Agrego sobrecarga de metodo sin parametros para cargar todos los usuarios?
        private void CardsLoad(string LocalidadToLoad)
        {
            listUsuarios.Items.Clear();

            int usuariosCount = 0;
            AutoCompleteStringCollection listaUsuarios = new AutoCompleteStringCollection();


            if (Directory.Exists(cards_path))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(cards_path);
                    FileInfo[] files = di.GetFiles("*.card");

                    foreach (FileInfo file in files)
                    {
                        int s_len = file.Name.Length;

                        if (LocalidadToLoad == "Todos")
                        {
                            // Carga todos los usuarios
                            this.listUsuarios.Items.Add(file.Name.Remove(s_len - 13, 13));
                            usuariosCount++;
                        } else
                        {
                            // Carga los usuarios de una localidad en especifico
                            JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                            if (json["localidad_asignada"].ToString() == LocalidadToLoad)
                            {
                                string Nombre_Usuario = file.Name.Remove(s_len - 13, 13);
                                this.listUsuarios.Items.Add(Nombre_Usuario);

                                usuariosCount++;
                            }
                        }
                    }

                    foreach (string usuario in this.listUsuarios.Items)
                    {
                        listaUsuarios.Add(usuario);
                    }

                    this.txtBuscar.AutoCompleteCustomSource = listaUsuarios;


                    if (this.listUsuarios.Items.Count > 0)
                    {
                        #region CODIGO DE BORRADO
                        lblNombre.Text = String.Empty;
                        lblNumeroDeEmpleado.Text = String.Empty;
                        lblExtension.Text = String.Empty;
                        lblUsuarioDeRed.Text = String.Empty;
                        lblCorreoElectronico.Text = String.Empty;
                        lblDepartamento.Text = String.Empty;
                        lblLocalidad.Text = String.Empty;

                        txtNombre.Text = String.Empty;
                        txtNumeroDeEmpleado.Text = String.Empty;
                        txtExtension.Text = String.Empty;
                        txtUsuarioDeRed.Text = String.Empty;
                        txtCorreoElectronico.Text = String.Empty;
                        txtDepartamento.Text = String.Empty;
                        txtLocalidad.Text = String.Empty;
                        #endregion

                        this.lblUsuariosCargados.Text = $"{usuariosCount} usuarios cargados con exito!";
                        this.lblUsuariosCargados.ForeColor = Color.Green;

                        this.listUsuarios.SelectedIndex = 0;
                    } else
                    {
                        #region CODIGO DE BORRADO
                        lblNombre.Text = String.Empty;
                        lblNumeroDeEmpleado.Text = String.Empty;
                        lblExtension.Text = String.Empty;
                        lblUsuarioDeRed.Text = String.Empty;
                        lblCorreoElectronico.Text = String.Empty;
                        lblDepartamento.Text = String.Empty;
                        lblLocalidad.Text = String.Empty;

                        txtNombre.Text = String.Empty;
                        txtNumeroDeEmpleado.Text = String.Empty;
                        txtExtension.Text = String.Empty;
                        txtUsuarioDeRed.Text = String.Empty;
                        txtCorreoElectronico.Text = String.Empty;
                        txtDepartamento.Text = String.Empty;
                        txtLocalidad.Text = String.Empty;
                        #endregion

                        this.lblUsuariosCargados.Text = $"No hay usuarios que cargar!";
                        this.lblUsuariosCargados.ForeColor = Color.Red;
                    }

                    
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void EliminarUsusario ()
        {
            string usuario = this.listUsuarios.Text;

            if (RJMessageBox.Show($"¿Seguro que deseas eliminar el usuario {usuario}?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists($@"{cards_path}\{usuario}_Profile.card"))
                {
                    File.Delete($@"{cards_path}\{usuario}_Profile.card");
                    RJMessageBox.Show($"Se ha eliminado el usuario {usuario} con exito!", "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CardsLoad(this.cboxFiltroDeVista.Text);
                }
            }
        }

        void _InitialLoadProceds()
        {
            this.lblUsuariosCargados.Text = String.Empty;

            // Lo comento por posible bucle que ocasionara
            this.cboxFiltroDeVista.SelectedIndex = 0;

            CardsLoad(this.cboxFiltroDeVista.Text);

            #region CARGAMOS LA LISTA DE LOCALIDADES REGISTRADAS
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {
                DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                FileInfo[] files = di.GetFiles("*.json");
                foreach (FileInfo file in files)
                {
                    string jfile = File.ReadAllText(file.FullName);
                    JObject json = JObject.Parse(jfile);

                    this.cboxFiltroDeVista.Items.Add(json["poblacion"]);
                }
            }

            #endregion

            /* 
             * *** NOTA: En un inicio mostrara todos los usuarios registrados
             * */

            this.txtDepartamento.AutoCompleteCustomSource = new Departamentos().Lista;
        }

        private void lista_usuarios_Load(object sender, EventArgs e)
        {
            

        }


        /// <summary>
        /// Metodo de ejecucion de la funcion correspondiente al boton 'Ok' del Form.
        /// </summary>
        private void MetodoDeCargaDeUsuarios ()
        {
            // Padre 1 : Formulario RIT MDI
            if (padre != null)
            {
                padre.cboxUsuariofinal.Text = user.Nombre;
                padre.txtDepartamento.Text = user.Departamento;
                padre.txtTelefono.Text = user.Extension;
                padre.txtNoDeEmpleado.Text = user.NoEmpleado;
            }

            // Padre 2: Reasignacion de Equipo
            if (padre_reasignacion_equipo != null)
            {
                padre_reasignacion_equipo.Nombre = user.Nombre;
                padre_reasignacion_equipo.NumDeEmp = user.NoEmpleado;
                padre_reasignacion_equipo.Ext = user.Extension;
                padre_reasignacion_equipo.UsuarioRed = user.Red;
                padre_reasignacion_equipo.Correo = user.Email;
                padre_reasignacion_equipo.Departamento = user.Departamento;
                padre_reasignacion_equipo.Localidad = user.Localidad;

                padre_reasignacion_equipo.lblNuevoUsuario.Text = user.Nombre;
                padre_reasignacion_equipo.lblNuevoNumDeEmpleado.Text = user.NoEmpleado;
                padre_reasignacion_equipo.lblNuevoExt.Text = user.Extension;
                padre_reasignacion_equipo.lblNuevoUsuarioRed.Text = user.Red;
                padre_reasignacion_equipo.lblNuevoCorreo.Text = user.Email;
                padre_reasignacion_equipo.lblNuevoDepartamento.Text = user.Departamento;
            }

            this.Close();
        }

        private void btnImportarUsuario_Click(object sender, EventArgs e)
        {
            MetodoDeCargaDeUsuarios();   
        }

        internal void LoadActualIndexInfo()
        {
            try
            {
                string json_cardPath = ($@"{cards_path}\{this.listUsuarios.Text}_Profile.card");

                // Borramos los datos anteriores
                user = Usuario.GetFromCard(json_cardPath);

                lblNombre.Text = user.Nombre;
                lblNumeroDeEmpleado.Text = user.NoEmpleado;
                lblExtension.Text = user.Extension;
                lblUsuarioDeRed.Text = user.Red;
                lblCorreoElectronico.Text = user.Email;
                lblDepartamento.Text = user.Departamento;
                lblLocalidad.Text = user.Localidad;

                txtNombre.Text = user.Nombre;
                txtNumeroDeEmpleado.Text = user.NoEmpleado;
                txtExtension.Text = user.Extension;
                txtUsuarioDeRed.Text = user.Red;
                txtCorreoElectronico.Text = user.Email;
                txtDepartamento.Text = user.Departamento;
                txtLocalidad.Text = user.Localidad;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!File.Exists($@"{cards_path}\{this.listUsuarios.Text}_Profile.card"))
                {
                    this.listUsuarios.Items.Remove(this.listUsuarios.Text);
                }
            }
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadActualIndexInfo();
        }

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {
            añadir_usuario frm = new añadir_usuario(this.Name);
            frm.ShowDialog();
        }

        private void btnGuardarModificaciones_Click(object sender, EventArgs e)
        {
            inventarios.UserJsonFileMaker(txtNombre.Text.Trim(), txtNumeroDeEmpleado.Text.Trim(), txtExtension.Text.Trim(), txtUsuarioDeRed.Text.Trim(), txtCorreoElectronico.Text.Trim(), txtDepartamento.Text.Trim(), txtLocalidad.Text.Trim());

            // Cargamos los nuevos datos del usuario actualizado
            LoadActualIndexInfo();
            this.listUsuarios.Select();

            RJMessageBox.Show($"Usuario < {user.Nombre} > modificado con exito!", "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardsLoad(this.cboxFiltroDeVista.Text);
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsusario();
        }

        private void listUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Delete)
            {
                // Eliminamos al usuario
                EliminarUsusario();
            }
        }

        private void lista_usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxFiltroDeVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al seleccionar una localidad filtrar
            // Hacer al terminar tabla de vinculacion

            CardsLoad(this.cboxFiltroDeVista.Text);
            
        }

        private void listUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoDeCargaDeUsuarios();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.lblBuscar_PlaceHolder.Visible = false;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBuscar.Text))
            {
                this.lblBuscar_PlaceHolder.Visible = true;
            }
        }

        private void lblBuscar_PlaceHolder_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Focus();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter & !string.IsNullOrEmpty(this.txtBuscar.Text))
            {

                string usuario = this.txtBuscar.Text;

                if (this.listUsuarios.Items.Contains(usuario))
                {
                    this.listUsuarios.SelectedItem = usuario;
                    this.Focus();
                }
                else
                {
                    RJMessageBox.Show("No existe el usuario que desea buscar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string TEXT = this.txtBuscar.Text;
            
            AutoCompleteStringCollection coincidencias = new AutoCompleteStringCollection();

            foreach (string usuario in this.listUsuarios.Items)
            {
                if (usuario.Contains(TEXT))
                {
                    coincidencias.Add(usuario);
                }
            }

            //this.txtBuscar.AutoCompleteCustomSource = coincidencias;
            //this.txtBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        TaskLoadingForm loadingForm;
        private void backgroundWorker_WaitScreen_DoWork(object sender, DoWorkEventArgs e)
        {
            loadingForm = new TaskLoadingForm(this, "Leyendo tarjetas de usuario y extrayendo los datos", "Cargando", false);
            loadingForm.Show();
        }

        private void lista_usuarios_Shown(object sender, EventArgs e)
        {
            if (padre_main != null)
            {
                padre_main.loadingForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialogEx1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
