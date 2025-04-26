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
using System.Text.Json;
using System.Text.Json.Serialization;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CefSharp.DevTools.Debugger;

namespace RIT_Solver
{
    public partial class tabla_vinculacion : Form
    {
        configuracion_usuario BaseForm;

        internal void StatusMessage(string ErrorText, string Color)
        {
            switch (Color.ToLower())
            {
                case "green":
                    this.lblStatus.ForeColor = System.Drawing.Color.Green;
                    break;
                case "red":
                    this.lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
            }

            this.lblStatus.Text = ErrorText;
        }


        public tabla_vinculacion(configuracion_usuario LegacyForm)
        {
            InitializeComponent();
            BaseForm = LegacyForm;
        }

        public string POBLACION_SELECCIONADA = "";

        void _LoadAllData()
        {
            #region Carga las localidades guardadas en Addresses/localidades
            string ADDRESSES_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(ADDRESSES_PATH))
            {
                if (Directory.EnumerateFileSystemEntries($@"{ADDRESSES_PATH}\").Any())
                {
                    // Carga los datos
                    DirectoryInfo di = new DirectoryInfo(ADDRESSES_PATH);
                    FileInfo[] files = di.GetFiles("*.json");

                    foreach (FileInfo file in files)
                    {
                        string jfile = File.ReadAllText(file.FullName);
                        JObject json = JObject.Parse(jfile);

                        this.listboxLocalidades.Items.Add($"{json["nombre"].ToString()}: {json["poblacion"].ToString()}");
                    }

                    StatusMessage("Informacion cargada con exito!", "green");
                }
                else
                {
                    StatusMessage("No existe informacion que cargar!", "red");
                }
            }
            else
            {
                StatusMessage("No existe la ruta de localidades!", "red");
            }
            #endregion

            #region Cargamos los usuarios no asignados a una localidad
            string USERS_CARD_PATH = $@"{Application.StartupPath}\UsersCard";

            if (Directory.Exists(USERS_CARD_PATH))
            {
                DirectoryInfo di = new DirectoryInfo(USERS_CARD_PATH);
                FileInfo[] files = di.GetFiles("*.card");

                foreach (FileInfo file in files)
                {
                    string jfile = File.ReadAllText(file.FullName);
                    JObject json = JObject.Parse(jfile);

                    if (json["localidad_asignada"].ToString() == "No asignada")
                    {
                        int s_len = file.Name.Length;

                        this.listboxTodosLosUsuarios.Items.Add(file.Name.Remove(s_len - 13, 13));
                    }
                    else if (json["localidad_asignada"].ToString() == "Direccion default")
                    {
                        int s_len = file.Name.Length;

                        this.listboxTodosLosUsuarios.Items.Add(file.Name.Remove(s_len - 13, 13));
                    }
                    else if (json["localidad_asignada"].ToString() == "Direccion_default")
                    {
                        int s_len = file.Name.Length;

                        this.listboxTodosLosUsuarios.Items.Add(file.Name.Remove(s_len - 13, 13));
                    }
                }
            }
            #endregion

            if (this.listboxTodosLosUsuarios.Items.Count == 0)
            {
                this.btnTodosLosUsuariosAUsuarios.Enabled = false;
            }

            if (this.listboxUsuariosEnLocalidad.Items.Count == 0)
            {
                this.btnUsuarioATodosLosUsuarios.Enabled = false;
            }

            this.listboxLocalidades.SelectedIndex = 0;
        }


        private void tabla_vinculacion_Load(object sender, EventArgs e)
        {
            _LoadAllData();
        }

        public string LIST_USUARIO_EN_LOCALIDAD_SELECCIONADO = "";
        public string LIST_TODOS_USUARIOS_SELECCIONADO = "";
        public string LIST_LOCALIDAD_SELECCIONADA = "";

        private void listboxLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filtramos los usuarios de esa localidad
            this.listboxUsuariosEnLocalidad.Items.Clear();

            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {
                DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                FileInfo[] files = di.GetFiles("*.json");

                string a = this.listboxLocalidades.Text;

                string OBJECT_POBLATION = a.Remove(0, a.IndexOf(":") + 2);
                string OBJECT_FILE = "";

                POBLACION_SELECCIONADA = OBJECT_POBLATION;

                foreach (FileInfo file in files)
                {
                    string jfile = File.ReadAllText(file.FullName);
                    JObject json = JObject.Parse(jfile);

                    if (json["poblacion"].ToString() == OBJECT_POBLATION)
                    {
                        OBJECT_FILE = file.FullName;
                    }
                }
            }

            #region Cargamos los usuarios asignados a esa localidad
            string CARDS_PATH = $@"{Application.StartupPath}\UsersCard";

            DirectoryInfo dir = new DirectoryInfo(CARDS_PATH);
            FileInfo[] files_cards = dir.GetFiles("*.card");

            foreach (FileInfo file in files_cards)
            {
                string jfile = File.ReadAllText(file.FullName);
                JObject json = JObject.Parse(jfile);

                if (json["localidad_asignada"].ToString() == POBLACION_SELECCIONADA)
                {
                    this.listboxUsuariosEnLocalidad.Items.Add(file.Name.Remove(file.Name.Length - 13, 13));
                }
            }
            #endregion

            if (this.listboxUsuariosEnLocalidad.Items.Count > 0)
            {
                this.btnUsuarioATodosLosUsuarios.Enabled = true;
            } else
            {
                this.btnUsuarioATodosLosUsuarios.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardamos los cambios hechos
            this.Close();
        }

        private void btnPasarTodos_UsuarioATodosLosUsuarios_Click(object sender, EventArgs e)
        {
            List<string> listaUsuarios = new List<string>();
            foreach (string i in this.listboxUsuariosEnLocalidad.Items)
            {
                listaUsuarios.Add(i);
            }

            foreach (string i in listaUsuarios)
            {
                #region ESTABLECEMOS QUE UN USUARIO NO TIENE UNA LOCALIDAD
                // Accion de pasar de 'Usuarios en la Localidad' => 'Todos los Usuarios no Asignados'
                string Usuario_Seleccionado;

                // Constructor de datos de la tarjeta de usuario
                string Nombre;
                string NoEmpleado;
                string Extension;
                string UsuarioRed;
                string Mail;
                string Departamento;


                if (!String.IsNullOrEmpty(i))
                {
                    Usuario_Seleccionado = i;

                    this.listboxUsuariosEnLocalidad.Items.Remove(Usuario_Seleccionado);
                    this.listboxTodosLosUsuarios.Items.Add(Usuario_Seleccionado);

                    // Modificamos el dato de la tarjeta del usuario
                    string USERCARD_PATH = $@"{Application.StartupPath}\UsersCard";

                    if (Directory.Exists(USERCARD_PATH))
                    {
                        string CARD_FILE = $@"{USERCARD_PATH}\{Usuario_Seleccionado}_Profile.card";

                        if (File.Exists(CARD_FILE))
                        {
                            // Leemos y parseamos el archivo
                            string json_file = File.ReadAllText(CARD_FILE);
                            JObject json = JObject.Parse(json_file);

                            Nombre = json["nombre"].ToString();
                            NoEmpleado = json["no_empleado"].ToString();
                            Extension = json["extension"].ToString();
                            UsuarioRed = json["red_user"].ToString();
                            Mail = json["mail"].ToString();
                            Departamento = json["departamento"].ToString();

                            // Creamos la tarjeta de usuario actualizada
                            inventarios.UserJsonFileMaker(Nombre, NoEmpleado, Extension, UsuarioRed, Mail, Departamento, "No asginada");
                        }
                    }
                }
                #endregion

                /* Conteo de items en lista para bloquear el pase de usuarios */
                if (this.listboxUsuariosEnLocalidad.Items.Count == 0)
                {
                    this.btnUsuarioATodosLosUsuarios.Enabled = false;
                    this.btnPasarTodos_UsuarioATodosLosUsuarios.Enabled = false;
                }
                if (this.listboxTodosLosUsuarios.Items.Count > 0)
                {
                    this.btnTodosLosUsuariosAUsuarios.Enabled = true;
                    this.btnPasarTodos_UsuarioATodosLosUsuarios.Enabled = true;
                }

                if (this.listboxUsuariosEnLocalidad.Items.Count > 0)
                {
                    this.listboxUsuariosEnLocalidad.SelectedIndex = 0;
                }
            }
        }

        private void btnUsuarioATodosLosUsuarios_Click(object sender, EventArgs e)
        {
            #region ESTABLECEMOS QUE UN USUARIO NO TIENE UNA LOCALIDAD
            // Accion de pasar de 'Usuarios en la Localidad' => 'Todos los Usuarios no Asignados'
            string Usuario_Seleccionado;

            // Constructor de datos de la tarjeta de usuario
            string Nombre;
            string NoEmpleado;
            string Extension;
            string UsuarioRed;
            string Mail;
            string Departamento;


            if (!String.IsNullOrEmpty(this.listboxUsuariosEnLocalidad.Text))
            {
                Usuario_Seleccionado = this.listboxUsuariosEnLocalidad.Text;

                this.listboxUsuariosEnLocalidad.Items.Remove(Usuario_Seleccionado);
                this.listboxTodosLosUsuarios.Items.Add(Usuario_Seleccionado);

                // Modificamos el dato de la tarjeta del usuario
                string USERCARD_PATH = $@"{Application.StartupPath}\UsersCard";

                if (Directory.Exists(USERCARD_PATH))
                {
                    string CARD_FILE = $@"{USERCARD_PATH}\{Usuario_Seleccionado}_Profile.card";

                    if (File.Exists(CARD_FILE))
                    {
                        // Leemos y parseamos el archivo
                        string json_file = File.ReadAllText(CARD_FILE);
                        JObject json = JObject.Parse(json_file);

                        Nombre = json["nombre"].ToString();
                        NoEmpleado = json["no_empleado"].ToString();
                        Extension = json["extension"].ToString();
                        UsuarioRed = json["red_user"].ToString();
                        Mail = json["mail"].ToString();
                        Departamento = json["departamento"].ToString();

                        // Creamos la tarjeta de usuario actualizada
                        inventarios.UserJsonFileMaker(Nombre, NoEmpleado, Extension, UsuarioRed, Mail, Departamento, "No asignada");
                    }
                }
            }
            #endregion

            /* Conteo de items en lista para bloquear el pase de usuarios */
            if (this.listboxUsuariosEnLocalidad.Items.Count == 0)
            {
                this.btnUsuarioATodosLosUsuarios.Enabled = false;
                this.btnPasarTodos_UsuarioATodosLosUsuarios.Enabled = false;
            }
            if (this.listboxTodosLosUsuarios.Items.Count > 0)
            {
                this.btnTodosLosUsuariosAUsuarios.Enabled = true;
                this.btnPasarTodos_TodosLosUsuariosAUsuarios.Enabled = true;
            }

            if (this.listboxUsuariosEnLocalidad.Items.Count > 0)
            {
                this.listboxUsuariosEnLocalidad.SelectedIndex = 0;
            }
        }

        private void btnPasarTodos_TodosLosUsuariosAUsuarios_Click(object sender, EventArgs e)
        {
            List<string> listaUsuarios = new List<string>();
            foreach (string i in this.listboxTodosLosUsuarios.Items)
            {
                listaUsuarios.Add(i);
            }

            foreach (string i in listaUsuarios)
            {
                #region CAMBIAMOS LA LOCALIDAD DE UN USUARIO
                // Accion de pasar de 'Todos los Usuarios no Asignados' => 'Usuarios en la Localidad'
                string Usuario_Seleccionado;

                // Constructor de datos de la tarjeta de usuario
                string Nombre;
                string NoEmpleado;
                string Extension;
                string UsuarioRed;
                string Mail;
                string Departamento;

                if (!String.IsNullOrEmpty(i) & !String.IsNullOrEmpty(i))
                {
                    Usuario_Seleccionado = i;

                    this.listboxTodosLosUsuarios.Items.Remove(Usuario_Seleccionado);    // Quitamos
                    this.listboxUsuariosEnLocalidad.Items.Add(Usuario_Seleccionado);    // Añadimos

                    // Modificamos el dato de la tarjeta del usuario
                    string USERCARD_PATH = $@"{Application.StartupPath}\UsersCard";

                    if (Directory.Exists(USERCARD_PATH))
                    {
                        string CARD_FILE = $@"{USERCARD_PATH}\{Usuario_Seleccionado}_Profile.card";

                        if (File.Exists(CARD_FILE))
                        {
                            // Leemos y parseamos el archivo
                            string json_file = File.ReadAllText(CARD_FILE);
                            JObject json = JObject.Parse(json_file);

                            Nombre = json["nombre"].ToString();
                            NoEmpleado = json["no_empleado"].ToString();
                            Extension = json["extension"].ToString();
                            UsuarioRed = json["red_user"].ToString();
                            Mail = json["mail"].ToString();
                            Departamento = json["departamento"].ToString();


                            // Creamos la tarjeta de usuario actualizada
                            inventarios.UserJsonFileMaker(Nombre, NoEmpleado, Extension, UsuarioRed, Mail, Departamento, POBLACION_SELECCIONADA);
                        }
                    }
                }
                #endregion

                /* Conteo de items en lista para bloquear el pase de usuarios */
                if (this.listboxTodosLosUsuarios.Items.Count == 0)
                {
                    this.btnTodosLosUsuariosAUsuarios.Enabled = false;
                    this.btnPasarTodos_TodosLosUsuariosAUsuarios.Enabled = true;
                }
                if (this.listboxUsuariosEnLocalidad.Items.Count > 0)
                {
                    this.btnUsuarioATodosLosUsuarios.Enabled = true;
                    this.btnPasarTodos_UsuarioATodosLosUsuarios.Enabled = false;
                }

                if (this.listboxTodosLosUsuarios.Items.Count > 0)
                {
                    this.listboxTodosLosUsuarios.SelectedIndex = 0;
                }
            }
        }

        private void btnTodosLosUsuariosAUsuarios_Click(object sender, EventArgs e)
        {
            #region CAMBIAMOS LA LOCALIDAD DE UN USUARIO
            // Accion de pasar de 'Todos los Usuarios no Asignados' => 'Usuarios en la Localidad'
            string Usuario_Seleccionado;

            // Constructor de datos de la tarjeta de usuario
            string Nombre;
            string NoEmpleado;
            string Extension;
            string UsuarioRed;
            string Mail;
            string Departamento;

            if (!String.IsNullOrEmpty(this.listboxTodosLosUsuarios.Text) & !String.IsNullOrEmpty(this.listboxLocalidades.Text))
            {
                Usuario_Seleccionado = this.listboxTodosLosUsuarios.Text;

                this.listboxTodosLosUsuarios.Items.Remove(Usuario_Seleccionado);    // Quitamos
                this.listboxUsuariosEnLocalidad.Items.Add(Usuario_Seleccionado);    // Añadimos

                // Modificamos el dato de la tarjeta del usuario
                string USERCARD_PATH = $@"{Application.StartupPath}\UsersCard";

                if (Directory.Exists(USERCARD_PATH))
                {
                    string CARD_FILE = $@"{USERCARD_PATH}\{Usuario_Seleccionado}_Profile.card";
                        
                    if (File.Exists(CARD_FILE))
                    {
                        // Leemos y parseamos el archivo
                        string json_file = File.ReadAllText(CARD_FILE);
                        JObject json = JObject.Parse(json_file);

                        Nombre = json["nombre"].ToString();
                        NoEmpleado = json["no_empleado"].ToString();
                        Extension = json["extension"].ToString();
                        UsuarioRed = json["red_user"].ToString();
                        Mail = json["mail"].ToString();
                        Departamento = json["departamento"].ToString();


                        // Creamos la tarjeta de usuario actualizada
                        inventarios.UserJsonFileMaker(Nombre, NoEmpleado, Extension, UsuarioRed, Mail, Departamento, POBLACION_SELECCIONADA);
                    }
                }
            }
            #endregion

            /* Conteo de items en lista para bloquear el pase de usuarios */
            if (this.listboxTodosLosUsuarios.Items.Count == 0)
            {
                this.btnTodosLosUsuariosAUsuarios.Enabled = false;
                this.btnPasarTodos_TodosLosUsuariosAUsuarios.Enabled = true;
            }
            if (this.listboxUsuariosEnLocalidad.Items.Count > 0)
            {
                this.btnUsuarioATodosLosUsuarios.Enabled = true;
                this.btnPasarTodos_UsuarioATodosLosUsuarios.Enabled = false;
            }

            if (this.listboxTodosLosUsuarios.Items.Count > 0)
            {
                this.listboxTodosLosUsuarios.SelectedIndex = 0;
            }
        }

        private void btnAñadirLocalidad_Click(object sender, EventArgs e)
        {
            nueva_localidad frm = new nueva_localidad(BaseForm);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                /*
                 * Añadimos el valor a la lista
                 */
                this.listboxLocalidades.Items.Clear();
                this.listboxUsuariosEnLocalidad.Items.Clear();
                this.listboxTodosLosUsuarios.Items.Clear();
                _LoadAllData();
            }
        }
    }
}
