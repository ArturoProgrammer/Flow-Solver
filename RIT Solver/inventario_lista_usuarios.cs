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

using SpreadsheetLight;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using CustomMessageBox;



namespace RIT_Solver
{
    public partial class inventario_lista_usuarios : Form
    {
        string cards_path = $@"{Application.StartupPath}\UsersCard\";
        private string UsuarioSeleccionado;
        private inventarios padre;
        public Usuario user = new Usuario();


        public inventario_lista_usuarios(inventarios aLegacyForm, string aUsuarioSeleccionado, bool aValidador)
        {
            InitializeComponent();

            if (aValidador)
            {
                UsuarioSeleccionado = aUsuarioSeleccionado;
            }
            padre = aLegacyForm;
        }


        private void CardsLoad(string LocalidadToLoad)
        {
            listUsuarios.Items.Clear();

            int usuariosCount = 0;
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
                        }
                        else
                        {
                            // Carga los usuarios de una localidad en especifico
                            JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                            if (json["localidad_asignada"].ToString() == LocalidadToLoad)
                            {
                                this.listUsuarios.Items.Add(file.Name.Remove(s_len - 13, 13));
                                usuariosCount++;
                            }
                        }
                    }

                    if (this.listUsuarios.Items.Count > 0)
                    {
                        #region CODIGO DE BORRADO
                        lblNombre.Text = String.Empty;
                        lblNumeroDeEmpleado.Text = String.Empty;
                        lblExtension.Text = String.Empty;
                        lblUsuarioDeRed.Text = String.Empty;
                        lblCorreoElectronico.Text = String.Empty;
                        lblDepartamento.Text = String.Empty;

                        txtNombre.Text = String.Empty;
                        txtNumeroDeEmpleado.Text = String.Empty;
                        txtExtension.Text = String.Empty;
                        txtUsuarioDeRed.Text = String.Empty;
                        txtCorreoElectronico.Text = String.Empty;
                        txtDepartamento.Text = String.Empty;
                        #endregion

                        this.lblUsuariosCargados.Text = $"{usuariosCount} usuarios cargados con exito!";
                        this.lblUsuariosCargados.ForeColor = Color.Green;

                        this.listUsuarios.SelectedIndex = 0;
                    }
                    else
                    {
                        #region CODIGO DE BORRADO
                        lblNombre.Text = String.Empty;
                        lblNumeroDeEmpleado.Text = String.Empty;
                        lblExtension.Text = String.Empty;
                        lblUsuarioDeRed.Text = String.Empty;
                        lblCorreoElectronico.Text = String.Empty;
                        lblDepartamento.Text = String.Empty;

                        txtNombre.Text = String.Empty;
                        txtNumeroDeEmpleado.Text = String.Empty;
                        txtExtension.Text = String.Empty;
                        txtUsuarioDeRed.Text = String.Empty;
                        txtCorreoElectronico.Text = String.Empty;
                        txtDepartamento.Text = String.Empty;
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

        private void EliminarUsusario()
        {
            string usuario = this.listUsuarios.Text;

            if (RJMessageBox.Show($"¿Seguro que deseas eliminar el usuario {usuario}?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists($@"{cards_path}\{usuario}_Profile.card"))
                {
                    File.Delete($@"{cards_path}\{usuario}_Profile.card");
                    RJMessageBox.Show($"Se ha eliminado el usuario {usuario} con exito!", "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CardsLoad("Todos");
                }
            }
        }

        private void ReloadFatherGrid()
        {
            SLDocument sl;
            string INVENTORIES_DIR_PATH = $@"{Application.StartupPath}\Inventories";
            string SheetBook = "USUARIOS Y EQUIPOS";
            var grilla = padre.dataGridView1;

            try {

                int iRow = 2;

                if (File.Exists($@"{INVENTORIES_DIR_PATH}\{SheetBook}.xlsx"))
                {
                    // Cargamos el archivo que se creo en base al molde con anterioridad
                    sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{SheetBook}.xlsx");

                    List<InventarioViewModel> lst = new List<InventarioViewModel>();

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        InventarioViewModel oUsuario = new InventarioViewModel();

                        oUsuario.NOMBRE = sl.GetCellValueAsString(iRow, 1);
                        oUsuario.NumDeEmpleado = sl.GetCellValueAsString(iRow, 2);
                        oUsuario.EXT = sl.GetCellValueAsString(iRow, 3);
                        oUsuario.USER = sl.GetCellValueAsString(iRow, 4);
                        oUsuario.MAIL = sl.GetCellValueAsString(iRow, 5);
                        oUsuario.HOSTNAME = sl.GetCellValueAsString(iRow, 6);
                        oUsuario.TipoDeEquipo = sl.GetCellValueAsString(iRow, 7);
                        oUsuario.SN = sl.GetCellValueAsString(iRow, 8);
                        oUsuario.Marca = sl.GetCellValueAsString(iRow, 9);
                        oUsuario.Modelo = sl.GetCellValueAsString(iRow, 10);
                        oUsuario.Ubicacion = sl.GetCellValueAsString(iRow, 11);
                        oUsuario.Departamento = sl.GetCellValueAsString(iRow, 12);
                        oUsuario.Comentarios = sl.GetCellValueAsString(iRow, 13);

                        #region PROCESO DE SINCRONIZACION DE USUARIOS
                        if (!Properties.Settings.Default.FIRST_INITIALIZE_INVENTORY)
                        {
                            if (File.Exists($@"{Application.StartupPath}\UsersCard\{oUsuario.NOMBRE.Trim()}_Profile.card"))
                            {
                                //RJMessageBox.Show($"Existe: {oUsuario.NOMBRE}");

                                string json_card = File.ReadAllText($@"{Application.StartupPath}\UsersCard\{oUsuario.NOMBRE.Trim()}_Profile.card");
                                JObject json_parsed = JObject.Parse(json_card);
                                Usuario user = new Usuario();   // Objeto del usuario

                                user.Nombre = json_parsed["nombre"].ToString();
                                user.NoEmpleado = json_parsed["no_empleado"].ToString();
                                user.Extension = json_parsed["extension"].ToString();
                                user.Red = json_parsed["red_user"].ToString();
                                user.Email = json_parsed["mail"].ToString();
                                user.Departamento = json_parsed["departamento"].ToString();

                                oUsuario.NumDeEmpleado = user.NoEmpleado;
                                oUsuario.EXT = user.Extension;
                                oUsuario.USER = user.Red;
                                oUsuario.MAIL = user.Email;
                                oUsuario.Departamento = user.Departamento;
                            }
                        }
                        #endregion

                        lst.Add(oUsuario);
                        iRow++;
                    }
                    grilla.DataSource = lst;
                }
            } 
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, this.Text);
            }

        }

        private void inventario_lista_usuarios_Load(object sender, EventArgs e)
        {
            CardsLoad("Todos");

            if (!string.IsNullOrEmpty(UsuarioSeleccionado))
            {
                this.listUsuarios.SelectedIndex = this.listUsuarios.FindString(UsuarioSeleccionado);
            }

            this.txtDepartamento.AutoCompleteCustomSource = new Departamentos().Lista;
        }


        internal void LoadActualIndexInfo()
        {
            try
            {
                string json_card = File.ReadAllText($@"{cards_path}\{this.listUsuarios.Text}_Profile.card");
                JObject json_parsed = JObject.Parse(json_card);

                user.Nombre= json_parsed["nombre"].ToString();
                user.NoEmpleado = json_parsed["no_empleado"].ToString();
                user.Extension = json_parsed["extension"].ToString();
                user.Red = json_parsed["red_user"].ToString();
                user.Email = json_parsed["mail"].ToString();
                user.Departamento = json_parsed["departamento"].ToString();
                user.Localidad = json_parsed["localidad_asignada"].ToString();

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
                RJMessageBox.Show(ex.Message);
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            añadir_usuario frm = new añadir_usuario(this.Name);
            frm.ShowDialog();
        }

        private void btnGuardarModificaciones_Click(object sender, EventArgs e)
        {
            inventarios.UserJsonFileMaker(txtNombre.Text.Trim(), txtNumeroDeEmpleado.Text.Trim(), txtExtension.Text.Trim(), txtUsuarioDeRed.Text.Trim(), txtCorreoElectronico.Text.Trim(), txtDepartamento.Text.Trim(), txtLocalidad.Text.Trim());
            LoadActualIndexInfo();
            this.listUsuarios.Select();

            RJMessageBox.Show($"Usuario < {user.Nombre} > modificado con exito!", "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReloadFatherGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardsLoad("Todos");
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

        private void inventario_lista_usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImportarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
