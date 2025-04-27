using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomMessageBox;

using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Flow_Solver
{
    public partial class nueva_localidad : Form
    {
        public string PATH_NAME = "";
        public bool EDIT_LOCALIDAD = false;
        configuracion_usuario LegacyForm;
        string OLD_File;
        public AddressSite Response;

        public nueva_localidad (configuracion_usuario ConstructorForm)
        {
            InitializeComponent();
            LegacyForm = ConstructorForm;

            this.btnGuardar.Text = "Crear Localidad";
        }

        public nueva_localidad (configuracion_usuario ConstructorForm, string JsonPath)
        {
            /* Sobrecarga para la edicion de localidades existentes */
            InitializeComponent();
            LegacyForm = ConstructorForm;
            OLD_File = JsonPath;
            EDIT_LOCALIDAD = true;

            JObject json = JObject.Parse(File.ReadAllText(JsonPath));

            int count = 0;
            foreach (string item in this.cboxLugarReferencial.Items)
            {
                if (json["estacion"].ToString() == item)
                {
                    this.cboxLugarReferencial.SelectedIndex = count;
                }
                count++;
            }
            this.txtNombre.Text = json["nombre"].ToString();
            this.txtDireccion.Text = json["direccion"].ToString();
            this.txtSucursal.Text = json["sucursal"].ToString();
            this.txtNoDeSucursal.Text = json["no_de_sucursal"].ToString();
            this.txtPoblacion.Text = json["poblacion"].ToString();
            this.txtCentroDeServicios.Text = json["centro_servicios"].ToString();

            this.chckboxDireccionDefault.Checked = bool.Parse(json["isDefaultDir"].ToString());

            this.btnGuardar.Text = "Guardar Cambios";
            this.Text = "Editar localidad";

            this.txtNombre.Enabled = false;
            this.cboxLugarReferencial.Enabled = false;

            this.CenterToScreen();
        }


        string ERR_MSG = "Debes llenar este campo!";

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!EDIT_LOCALIDAD)
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, ERR_MSG);
                }
                else
                {
                    // Validar si la poblacion ya existe
                    string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
                    int COINC = 0;

                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");

                    foreach (FileInfo file in files)
                    {
                        string jfile = File.ReadAllText(file.FullName);
                        JObject json = JObject.Parse(jfile);

                        if (json["nombre"].ToString().ToLower() == this.txtNombre.Text.ToLower())
                        {
                            COINC++;
                        }
                    }

                    if (COINC > 0)
                    {
                        errorProvider1.SetError(txtNombre, "Nombre ya existente!");
                    }
                    else
                    {
                        errorProvider1.SetError(txtNombre, "");
                    }
                }
            }
        }

        private void txtPoblacion_Validating(object sender, CancelEventArgs e)
        {
            if (!EDIT_LOCALIDAD)
            {
                if (string.IsNullOrEmpty(this.txtPoblacion.Text))
                {
                    errorProvider1.SetError(txtPoblacion, ERR_MSG);
                }
                else
                {
                    // Validar si la poblacion ya existe
                    string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
                    int COINC = 0;

                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");

                    foreach (FileInfo file in files)
                    {
                        string jfile = File.ReadAllText(file.FullName);
                        JObject json = JObject.Parse(jfile);

                        if (json["poblacion"].ToString().ToLower() == this.txtPoblacion.Text.ToLower())
                        {
                            COINC++;
                        }
                    }

                    if (COINC > 0)
                    {
                        errorProvider1.SetError(txtPoblacion, "Poblacion ya existente!");
                    }
                    else
                    {
                        errorProvider1.SetError(txtPoblacion, "");
                    }
                }
            }
        }

        bool isCreated = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) & !string.IsNullOrEmpty(this.txtPoblacion.Text))
            {
                try
                {
                    // Guardamos los datos
                    /*
                     * Nombre de la localidad se usara como nombre del archivo
                     * '{nombre}.json'
                     */
                    string ADDRESES_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
                    string SET_DEFAULT = this.chckboxDireccionDefault.Checked.ToString().ToLower();

                    PATH_NAME = $@"{this.cboxLugarReferencial.Text}_{this.txtNombre.Text}"; // Solo establecemos el nombre, no la extension

                    AddressSite site = new AddressSite()
                    {
                        Nombre = txtNombre.Text,
                        Direccion = txtDireccion.Text,
                        Sucursal = txtSucursal.Text,
                        isDefaultDirection = chckboxDireccionDefault.Checked,
                        NoDeSucursal = txtNoDeSucursal.Text,
                        Poblacion = txtPoblacion.Text,
                        CentroServicios = txtCentroDeServicios.Text,
                        Estacion = cboxLugarReferencial.Text,
                    };

                    string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

                    if (this.chckboxDireccionDefault.Checked)
                    {
                        // Cambiamos la clave 'isDefaultDir' a false
                        #region Buscamos el archivo anteriormente con el parametro en true para cambiarlo
                        string TARGET_FILE = "";
                        string TARGET_NAME = "";

                        DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                        FileInfo[] files = di.GetFiles("*.json");

                        foreach (FileInfo file in files)
                        {
                            string jfile = File.ReadAllText(file.FullName);
                            JObject json = JObject.Parse(jfile);

                            //MessageBox.Show(file.Name);
                            if (file.Name == $"{Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT}.json")
                            {
                                TARGET_FILE = file.FullName;
                                TARGET_NAME = file.Name;
                                break;
                            }
                        }
                        #endregion

                        #region Reescribimos el archivo con la informacion nueva (setDefaultDir = False)
                        /*
                        JObject old_json = JObject.Parse(File.ReadAllText(TARGET_FILE));

                        Dictionary<string, string> new_json = new Dictionary<string, string>();
                        new_json.Add("nombre", old_json["nombre"].ToString());
                        new_json.Add("direccion", old_json["direccion"].ToString());
                        new_json.Add("sucursal", old_json["sucursal"].ToString());
                        new_json.Add("isDefaultDir", "false");
                        new_json.Add("no_de_sucursal", old_json["no_de_sucursal"].ToString());
                        new_json.Add("poblacion", old_json["poblacion"].ToString());
                        new_json.Add("centro_servicios", old_json["centro_servicios"].ToString());
                        new_json.Add("estacion", old_json["estacion"].ToString());

                        //MessageBox.Show(TARGET_NAME + Environment.NewLine + Environment.NewLine + TARGET_FILE);
                        File.WriteAllText(TARGET_FILE, System.Text.Json.JsonSerializer.Serialize(new_json));
                        */

                        AddressSite s = AddressSite.Build(TARGET_FILE);
                        s.isDefaultDirection = false;
                        s.Save();
                        #endregion

                        // Escribimos el nuevo valor
                        Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT = PATH_NAME;
                        Properties.Settings.Default.Save();

                        LegacyForm.txtActualLocalidadDefault.Text = PATH_NAME;
                    }

                    this.lblStatus.ForeColor = Color.Green;
                    this.lblStatus.Text = "Localidad guardada!";

                    // Borramos el archivo viejo
                    if (!string.IsNullOrEmpty(OLD_File))
                    {
                        File.Delete(OLD_File);
                    }
                    // Dejamos solamente el nuevo
                    site.Save();
                    isCreated = true;
                    Response = site;

                    // Recargar valores de la lista de las localidades
                    #region CARGA DE DIRECCIONES DE LAS LOCALIDADES GUARDADAS

                    if (Directory.Exists(LOCALS_PATH))
                    {
                        try
                        {
                            LegacyForm.cboxListaDeLocalidades.Items.Clear();

                            DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                            FileInfo[] files = di.GetFiles("*.json");
                            foreach (FileInfo file in files)
                            {
                                string jfile = File.ReadAllText(file.FullName);
                                JObject json = JObject.Parse(jfile);

                                if (file.Name != "Direccion_default.json")
                                {
                                    LegacyForm.cboxListaDeLocalidades.Items.Add(json["nombre"].ToString());
                                }
                            }

                            LegacyForm.cboxListaDeLocalidades.SelectedIndex = 0;
                            //this.cboxLocalidadDefault.SelectedText = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;

                            //this.lblUsuariosCargados.Text = $"{usuariosCount} usuarios cargados con exito!";
                        }
                        catch (Exception ex)
                        {
                            RJMessageBox.Show(ex.Message, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    #endregion

                    // Salimos
                    this.Close();
                }
                catch (Exception ex)
                {
                    isCreated = false;
                    this.lblStatus.ForeColor = Color.Red;
                    this.lblStatus.Text = "Error al crear";
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void nueva_locadidad_Load(object sender, EventArgs e)
        {
            this.cboxLugarReferencial.SelectedIndex = 0;
            this.lblStatus.Text = String.Empty;
        }

        private void nueva_localidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isCreated)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
