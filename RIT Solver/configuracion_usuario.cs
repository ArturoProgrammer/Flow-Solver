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

using CustomMessageBox;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DocumentFormat.OpenXml.Drawing;
using iTextSharp.text;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Threading;


namespace Flow_Solver
{
    public partial class configuracion_usuario : Form
    {
        bool char_password_flag = false;

        string URL_FORMS_DEFAULT = "https://forms.office.com/Pages/ResponsePage.aspx?id=dNF36JwJkUSX2NZVp8az1BdNDZCBAPJHq77MIGUA38VUN0JXNUxNNkNSNVQxNlZHUDU3MkxHQUJQRS4u";
        string URL_GMXT_SAS_DEFAULT = "https://gmxtsas.mx:8080/HomePage.do?view_type=my_view";
        string URL_COMPUSOF_SAS_DEFAULT = "https://accounts.zoho.com/signin?servicename=SDPOnDemand&hide_title=true&hideyahoosignin=true&hidefbconnect=true&hide_secure=true&serviceurl=https%3A%2F%2Fsd.compusofmexico.com%2Fapp%2Fitdesk%2FHomePage.do&signupurl=https://sd.compusofmexico.com/AccountCreation.do&portal_id=142098036&hide_signup=true";
        string URL_ENDPOINT_DEFAULT = "https://endpointcentral.manageengine.com/webclient#/uems/home/smart-advisor";

        main LegacyForm;
        private MachinesModelsSync modelsVinculated = MachinesModelsSync.Load();

        public configuracion_usuario(main FormPadre)
        {
            InitializeComponent();

            /* 
             * SE CARGAN LOS VALORES INICIALES
             * */

            #region ASIGNACION DE VALORES
            this.chckboxAlertasDeToner.Visible = false;
            //this.chckboxFirmarAutomaticamente.Visible = false;

            /* PESTAÑA DE USUARIO */
            this.txtNombreIDC.Text = Properties.Settings.Default.NombreIDC;
            this.txtLocalidadIDC.Text = Properties.Settings.Default.LocalidadIDC;
            this.txtProyectoIDC.Text = Properties.Settings.Default.ProyectoIDC;
            this.txtUsuarioDeRed.Text = Properties.Settings.Default.UsuarioDeRedIDC;

            this.txtEmailIDC.Text = Properties.Settings.Default.EmailUsuarioIDC;
            this.txtContraseñaIDC.Text = Properties.Settings.Default.EmailPasswordIDC;

            this.txtServidor.Text = Properties.Settings.Default.SERVER_ROUTE.Replace(".", "  .  ");

            /* PESTAÑA DE RIT */
            this.txtDireccion.Text = Properties.Settings.Default.Direccion;
            this.txtCentroDeServicios.Text = Properties.Settings.Default.CentroDeServicios;
            this.cboxCliente.Text = Properties.Settings.Default.Cliente;
            this.txtEmailDestinoDefault.Text = Properties.Settings.Default.EmailDestinoRefaccionesDefault;
            this.txtLider.Text = Properties.Settings.Default.LiderDeProyecto;
            //this.chckboxFirmarAutomaticamente.Checked = Properties.Settings.Default.SYSDATA_FIRMA_HABILITADA;
            this.txtRITPath.Text = Properties.Settings.Default.RITFormPath;
            this.txtPathDesino.Text = Properties.Settings.Default.RITFormPathDestiny;
            this.txtOrigenActaResponsiva.Text = Properties.Settings.Default.ActaResponsivaPath;
            this.numericContadorRit.Value = Properties.Settings.Default.RITCounter;

            /* PESTAÑA DE AVANZADO */
            /** Guardado **/
            this.chckboxGuardarRitEnPDF.Checked = Properties.Settings.Default.SYSDATA_GUARDARRITENPDF;
            this.chckboxGuardarReguardoEnPDF.Checked = Properties.Settings.Default.SYSDATA_GUARDARRESGUARDOPDF;
            /** Actualizaciones **/
            this.chckboxVerificarActualizaciones.Checked = Properties.Settings.Default.SYSDATA_UPDATES_ACTIVATE;
            this.chckboxCanalBeta.Checked = Properties.Settings.Default.SYSDATA_BETA_UPDATES;
            /** Propiedades de Impresion **/
            this.cboxMetodoDeImpresionPorDefecto.Text = Properties.Settings.Default.SYSDATA_MetodoDeImpresionPorDefecto;
            this.chckboxHabilitarMetodoDeImpresionSecundarioAuto.Checked = Properties.Settings.Default.SYSDATA_HabilitarMetodoDeImpresionSecundarioAutomaticamente;
            /** Inventarios **/
            this.txtRutaInventario.Text = Properties.Settings.Default.SYSDATA_INVENTORY_PATH;
            this.chckboxAlertasDeToner.Checked = Properties.Settings.Default.SYSDATA_EXAMINAR_TONER_AUTOMATICO;
            this.chckboxGuardarSiempreCambiosDeInventario.Checked = Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO;
            this.chckboxAbrirInventarioSiemprePantallaCompleta.Checked = Properties.Settings.Default.SYSDATA_OPEN_INVENTORY_ALWAYS_MAXIMIZE;
            this.chckboxDescargarEInstalarAutomaticamente.Checked = Properties.Settings.Default.SYSDATA_DESCARGAR_E_INSTALAR_AUTOMATICAMENTE;
            /** Personalizacion **/
            this.cboxTemas.Text = Properties.Settings.Default.SYSDATA_TEMA_APLICADO;
            /** Al abrir la aplicacion **/
            this.chckBoxCrearProyectoEnBlanco.Checked = Properties.Settings.Default.SYSDATA_CREAR_PROYECTO_BLANCO_AL_INICIAR;
            this.chckBoxAbrirUltimaSesion.Checked = Properties.Settings.Default.SYSDATA_RECORDAR_ULTIMA_SESION;

            /* PESTAÑA DE NAVEGADOR WEB */
            /** Configuracion **/
            // CONFIGURACION DE LENGUAJE SE CARGA EN OTRA SECCION (LOAD)
            this.txtURL_Forms.Text = Properties.Settings.Default.SYSDATA_URL_FORMS;
            this.txtURL_ServiceDeskGMXT.Text = Properties.Settings.Default.SYSDATA_URL_SERVICEDESK;
            this.txtURL_ServiceDeskCompusof.Text = Properties.Settings.Default.SYSDATA_URL_COMPUSOF;
            this.txtURL_EndpointCentral.Text = Properties.Settings.Default.SYSDATA_URL_ENDPOINT;

            /* Direcciones fisicas */
            /** Localidades guardadas **/
            this.txtActualLocalidadDefault.Text = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;
            // Lo cargamos en otra seccion
            LoadAreas();

            /* Modelos Vinculados */
            LoadModelosVinculados();
            this.chckboxSeleccionarAutomaticamenteElModeloCreadoRecientemente.Checked = Properties.Settings.Default.SYSDATA_AutoSelectRecentSincModel;
            #endregion

            LegacyForm = FormPadre;
        }

        bool LOCK_REESTABLECER_ENLACES = false;

        private void configuracion_usuario_Load(object sender, EventArgs e)
        {
            /* CARGAMOS LAS IMAGENES INICIALES */
            string foto_path = Properties.Settings.Default.FotoIDCPath;
            string firma_path = Properties.Settings.Default.FirmaIDCPath;
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            if (File.Exists(foto_path) == true)
            {
                // Cargamos la foto de firma
                this.picboxFotoIDC.Image = System.Drawing.Image.FromFile(foto_path); // Cargamos la foto de perfil
            }

            if (File.Exists(firma_path) == true)
            {
                // Cargamos la foto de firma
                //this.picboxFirma.Image = Image.FromFile(firma_path);
            }

            if (chckboxVerificarActualizaciones.Checked == false)
            {
                chckboxCanalBeta.Enabled = false;
            }

            // Cargamos listado de cboxTemas
            this.cboxTemas.Items.Add("RIT Solver Theme (Default)");
            this.cboxTemas.Items.Add("GMXT Theme (High Contrast)");
            this.cboxTemas.Items.Add("GMXT Theme");
            this.cboxTemas.Items.Add("Dark");
            this.cboxTemas.Items.Add("Light");
            this.cboxTemas.Items.Add("Dark Blue");
            this.cboxTemas.Items.Add("Light Blue");

            this.cboxTemas.Text = Properties.Settings.Default.SYSDATA_TEMA_APLICADO;    // Indicamos cual es el tema usado actualmente

            #region  CARGAMOS EN LA LISTA LOS LENGUAJES DISPONIBLES PARA USAR EN EL NAVEGADOR
            // PARA CEFSHARP...
            switch (WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE)
            {
                case "es":
                    this.cboxLenguajeSeleccionado_CefSharp.Text = "Español Latinoamerica (es)";
                    break;
                case "ca":
                    this.cboxLenguajeSeleccionado_CefSharp.Text = "Catalan (ca)";
                    break;
                case "en-GB":
                    this.cboxLenguajeSeleccionado_CefSharp.Text = "Ingles Gran Bretaña (en-GB)";
                    break;
                case "en-US":
                    this.cboxLenguajeSeleccionado_CefSharp.Text = "Ingles EE.UU (en-US)";
                    break;
                case "es-419":
                    this.cboxLenguajeSeleccionado_CefSharp.Text = "Español Auxiliar (es-419)";
                    break;
            }

            // PARA WEBVIEW2
            switch (WebCEFSharp_Config.Default.WEBVIEW2_DEFAULT_LANGUAGE)
            {
                case "en-US":
                    this.cboxLenguajeSeleccionado_WebView2.Text = "Ingles EE.UU (en-US)";
                    break;
                case "es-ES":
                    this.cboxLenguajeSeleccionado_WebView2.Text = "Español Latinoamericano (es-ES)";
                    break;
                case "fr-FR":
                    this.cboxLenguajeSeleccionado_WebView2.Text = "Frances (fr-FR)";
                    break;
            }
            #endregion

            #region CARGA DE DIRECCIONES DE LAS LOCALIDADES GUARDADAS
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");
                    foreach (FileInfo file in files)
                    {
                        string jfile = File.ReadAllText(file.FullName);
                        JObject json = JObject.Parse(jfile);

                        if (file.Name != "Direccion_default.json")
                        {
                            this.cboxListaDeLocalidades.Items.Add(json["nombre"].ToString());
                        }
                    }

                    if (this.cboxListaDeLocalidades.Items.Count > 0)
                    {
                        this.cboxListaDeLocalidades.SelectedIndex = 0;
                    }
                    //this.cboxLocalidadDefault.SelectedText = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;

                    //this.lblUsuariosCargados.Text = $"{usuariosCount} usuarios cargados con exito!";
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion


            /* Bloqueo de controles de enlaces web */
            // CefSharp
            this.groupBoxReestablecerEnlaces_CefSharp.Enabled = false;
            this.txtURL_ServiceDeskCompusof.Enabled = false;
            this.txtURL_ServiceDeskGMXT.Enabled = false;
            this.label26.Enabled = false;
            this.label27.Enabled = false;

            // WebView2
            this.groupBoxReestablecerEnlaces_WebView2.Enabled = false;
            this.txtURL_EndpointCentral.Enabled = false;
            this.txtURL_Forms.Enabled = false;
            this.label49.Enabled = false;
            this.label38.Enabled = false;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    Properties.Settings.Default.FotoIDCPath = imagen;   // Se guarda Path de Foto

                    picboxFotoIDC.Image = System.Drawing.Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }
        //477310 - Impresora de FM / en impresora comun
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (char_password_flag == false)
            {
                this.txtContraseñaIDC.UseSystemPasswordChar = false;
                char_password_flag = true;
                this.btnVerContraseña.Image = Properties.Resources.hidden;
            }
            else
            {
                this.txtContraseñaIDC.UseSystemPasswordChar = true;
                char_password_flag = false;
                this.btnVerContraseña.Image = Properties.Resources.view;
            }
        }


        /// <summary>
        /// Cargamos los modelos vinculados del archivo correspondiente
        /// </summary>
        private void LoadModelosVinculados()
        {
            foreach (MachineModelSyncItem m in modelsVinculated.Items)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.NombreComercial;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "subitemNombreClave",
                    Text = $"{m.NombreClave}",
                });

                switch (m.Tipo)
                {
                    case "LAPTOP":
                        item.ImageIndex = 0;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                        break;
                    case "PC":
                        item.ImageIndex = 1;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                        break;
                }
                item.Tag = m;

                this.lviewTablaDeModelosVinculados.Items.Add(item);
            }
        }

        /// <summary>
        /// Cargamos las areas registradas en el control
        /// </summary>
        private void LoadAreas()
        {
            this.lboxAreasRegistradas.Items.Clear();
            foreach (string i in new Departamentos().Lista)
            {
                this.lboxAreasRegistradas.Items.Add(i);
            }
        }

        private void SaveDataProperties()
        {
            /* 
             * ASIGNA LOS DATOS A LAS PROPIEDADES Y GUARDA LOS DATOS
             * */

            #region ASIGNACION DE VALORES
            /* PESTAÑA DE USUARIO */
            Properties.Settings.Default.NombreIDC = this.txtNombreIDC.Text.Trim();
            Properties.Settings.Default.ProyectoIDC = this.txtProyectoIDC.Text.Trim();
            Properties.Settings.Default.LocalidadIDC = this.txtLocalidadIDC.Text.Trim();
            Properties.Settings.Default.UsuarioDeRedIDC = this.txtUsuarioDeRed.Text.Trim();

            Properties.Settings.Default.EmailUsuarioIDC = this.txtEmailIDC.Text.Trim();
            Properties.Settings.Default.EmailPasswordIDC = this.txtContraseñaIDC.Text.Trim();

            Properties.Settings.Default.SERVER_ROUTE = this.txtServidor.Text.Replace(" ", String.Empty).Trim();

            /* PESTAÑA DE FORMULARIO */
            Properties.Settings.Default.Direccion = this.txtDireccion.Text.Trim();
            Properties.Settings.Default.CentroDeServicios = this.txtCentroDeServicios.Text.Trim();
            Properties.Settings.Default.Cliente = this.cboxCliente.Text.Trim();
            Properties.Settings.Default.EmailDestinoRefaccionesDefault = this.txtEmailDestinoDefault.Text.Trim();
            Properties.Settings.Default.LiderDeProyecto = this.txtLider.Text.Trim();
            //Properties.Settings.Default.SYSDATA_FIRMA_HABILITADA = this.chckboxFirmarAutomaticamente.Checked;
            Properties.Settings.Default.RITCounter = this.numericContadorRit.Value;

            // -> PROPIEDAD DE ORIGEN DE RIT EN OTRA SECCION
            // -> PROPIEDAD DE DESTINO DE RIT EN OTRA SECCION
            // -> PROPIEDAD DE ORIGEN DE ACTA RESPONSIVA EN OTRA SECCION

            /* PESTAÑA DE AVANZADO */
            Properties.Settings.Default.SYSDATA_GUARDARRITENPDF = this.chckboxGuardarRitEnPDF.Checked;
            Properties.Settings.Default.SYSDATA_GUARDARRESGUARDOPDF = this.chckboxGuardarReguardoEnPDF.Checked;

            Properties.Settings.Default.SYSDATA_UPDATES_ACTIVATE = this.chckboxVerificarActualizaciones.Checked;
            Properties.Settings.Default.SYSDATA_BETA_UPDATES = this.chckboxCanalBeta.Checked;
            Properties.Settings.Default.SYSDATA_DESCARGAR_E_INSTALAR_AUTOMATICAMENTE = this.chckboxDescargarEInstalarAutomaticamente.Checked;

            Properties.Settings.Default.SYSDATA_MetodoDeImpresionPorDefecto = this.cboxMetodoDeImpresionPorDefecto.Text;
            Properties.Settings.Default.SYSDATA_HabilitarMetodoDeImpresionSecundarioAutomaticamente = this.chckboxHabilitarMetodoDeImpresionSecundarioAuto.Checked;

            Properties.Settings.Default.SYSDATA_INVENTORY_PATH = this.txtRutaInventario.Text.Trim();
            Properties.Settings.Default.SYSDATA_EXAMINAR_TONER_AUTOMATICO = this.chckboxAlertasDeToner.Checked;
            Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO = this.chckboxGuardarSiempreCambiosDeInventario.Checked;
            Properties.Settings.Default.SYSDATA_OPEN_INVENTORY_ALWAYS_MAXIMIZE = this.chckboxAbrirInventarioSiemprePantallaCompleta.Checked;

            Properties.Settings.Default.SYSDATA_TEMA_APLICADO = this.cboxTemas.Text;

            Properties.Settings.Default.SYSDATA_CREAR_PROYECTO_BLANCO_AL_INICIAR = this.chckBoxCrearProyectoEnBlanco.Checked;
            Properties.Settings.Default.SYSDATA_RECORDAR_ULTIMA_SESION = this.chckBoxAbrirUltimaSesion.Checked;



            /* PESTAÑA DE NAVEGADOR WEB */
            // CefSharp
            switch (this.cboxLenguajeSeleccionado_CefSharp.Text)
            {
                case "Español Latinoamerica (es)":
                    WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE = "es";
                    break;
                case "Catalan (ca)":
                    WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE = "ca";
                    break;
                case "Ingles Gran Bretaña (en-GB)":
                    WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE = "en-GB";
                    break;
                case "Ingles EE.UU (en-US)":
                    WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE = "en-US";
                    break;
                case "Español Auxiliar (es-419)":
                    WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE = "es-419";
                    break;
            }
            // WebView2
            switch (this.cboxLenguajeSeleccionado_WebView2.Text)
            {
                case "Ingles EE.UU (en-US)":
                    WebCEFSharp_Config.Default.WEBVIEW2_DEFAULT_LANGUAGE = "en-US";
                    break;
                case "Español Latinoamericano (es-ES)":
                    WebCEFSharp_Config.Default.WEBVIEW2_DEFAULT_LANGUAGE = "es-ES";
                    break;
                case "Frances (fr-FR)":
                    WebCEFSharp_Config.Default.WEBVIEW2_DEFAULT_LANGUAGE = "fr-FR";
                    break;
            }
            Properties.Settings.Default.SYSDATA_URL_SERVICEDESK = this.txtURL_ServiceDeskGMXT.Text.Trim();
            Properties.Settings.Default.SYSDATA_URL_COMPUSOF = this.txtURL_ServiceDeskCompusof.Text.Trim();
            // WebView2
            Properties.Settings.Default.SYSDATA_URL_FORMS = this.txtURL_Forms.Text.Trim();
            Properties.Settings.Default.SYSDATA_URL_ENDPOINT = this.txtURL_EndpointCentral.Text.Trim();

            /* PESTAÑA DE MODELOS VINCULADOS */
            // Se guarda la lista de vinculados en la siguiente seccion
            Properties.Settings.Default.SYSDATA_AutoSelectRecentSincModel = this.chckboxSeleccionarAutomaticamenteElModeloCreadoRecientemente.Checked;
            #endregion

            Properties.Settings.Default.Save(); // Guardamos configuracion del programa
            WebCEFSharp_Config.Default.Save();  // Guardamos configuracion del navegador

            modelsVinculated.Items.Clear();
            foreach (ListViewItem i in this.lviewTablaDeModelosVinculados.Items)
            {
                modelsVinculated.Items.Add((MachineModelSyncItem)i.Tag);
            }
            modelsVinculated.Save();            // Guardamos la configuracion de los modelos vinculados

            // Aplicamos el cambio de temas
            try
            {
                LegacyForm.themeLoad();
                //LegacyForm.Update();
            }
            catch { }

            CommonMethodsLibrary.OutMessage("out", this.Name, $"NUEVA TIEMPO DE BORRADO ESTABLECIDO: '{WebCEFSharp_Config.Default.CEFDATA_SEMANAS_PARA_BORRAR}'", "oka");
            CommonMethodsLibrary.OutMessage("out", this.Name, $"SIGUIENTE BORRADO EL DIA: '{WebCEFSharp_Config.Default.CEFDATA_SEMANAS_PARA_BORRAR}'", "inf");
        }


        private void UpdateDireccionDefault()
        {
            /* Actualiza los datos de la 'Direccion_default' */

            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            try
            {
                if (Directory.Exists(LOCALS_PATH))
                {
                    string DEF_PATH = $@"{LOCALS_PATH}\Direccion_default.json";

                    if (File.Exists(DEF_PATH))
                    {
                        JObject old_json = JObject.Parse(File.ReadAllText(DEF_PATH));

                        Dictionary<string, string> direction = new Dictionary<string, string>();

                        direction.Add("nombre", "Direccion default");
                        direction.Add("direccion", this.txtDireccion.Text);
                        direction.Add("sucursal", "");
                        direction.Add("isDefaultDir", old_json["isDefaultDir"].ToString());
                        direction.Add("no_de_sucursal", "");
                        direction.Add("poblacion", this.txtLocalidadIDC.Text);
                        direction.Add("centro_servicios", this.txtCentroDeServicios.Text);
                        direction.Add("estacion", "FXE");

                        string finaljson = System.Text.Json.JsonSerializer.Serialize(direction);
                        File.WriteAllText($@"{DEF_PATH}", finaljson);
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.ToString());
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Guardamos y aplicamos los cambios
            SaveDataProperties();

            // Añadimos funcion para la actualizacion de 'Direccion_default'
            UpdateDireccionDefault();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cerrar Formulario
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Guardamos y cerramos
            SaveDataProperties();

            // Añadimos funcion para la actualizacion de 'Direccion_default'
            UpdateDireccionDefault();

            this.Close();   // Cerramos
        }

        private void btnCargarFirma_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    Properties.Settings.Default.FirmaIDCPath = imagen;  // Se guarda el Path de Firma

                    //picboxFirma.Image = System.Drawing.Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Cargar RIT...";
                openFileDialog1.Filter = "Archivos PDF | *.pdf";
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    this.txtRITPath.Text = path;
                    Properties.Settings.Default.RITFormPath = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("El archivo seleccionado no es un PDF. Por favor seleccione un documento del formato indicado. " + ex);
            }
        }

        private void btnPathDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;

                    this.txtPathDesino.Text = path;
                    Properties.Settings.Default.RITFormPathDestiny = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error en escoger la ruta destino. " + ex);
            }
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Show("¿Seguro que desea borrar todos los datos de la app?", "Restauracion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                // Restaura la app a estado de fabrica
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();

                if (RJMessageBox.Show("Datos borrados y app restaurada con exito! favor de reiniciar la app para aplicar cambios", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        private void btnExaminarRutaInventario_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Seleccione un archivo de inventario...";
                openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx;*.xls;*.xlsm|Todos los Archivos(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    this.txtRutaInventario.Text = path;
                    Properties.Settings.Default.SYSDATA_INVENTORY_PATH = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error en escoger la ruta destino. " + ex);
            }
        }

        private void btnBuscarActualizaciones_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (UpdaterManager.Update.SearchUpdates(Properties.Settings.Default.SERVER_ROUTE, true, Properties.Settings.Default.SYS_VERSION) == true)
                {
                    if (RJMessageBox.Show("¡Se han encontrado nuevas actualizaciones disponibles! ¿Desea instalar la actualizacion?", "Gestor de actualizaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /* INICIAR PROCESO DE DESCARGA */
                        actualizador frm_actualizador = new actualizador();
                        frm_actualizador.ShowDialog();
                    }
                }
                else
                {
                    RJMessageBox.Show("¡No se han encontrado nuevas actualizaciones disponibles! ya cuentas con la ultima version disponible", "Gestor de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("No se ha podido establecer conexion con el servidor! intente mas tarde." + Environment.NewLine + Environment.NewLine + "El programa dice:" + Environment.NewLine + ex.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckboxVerificarActualizaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxVerificarActualizaciones.Checked != true)
            {
                this.chckboxCanalBeta.Enabled = false;
            }
            else
            {
                this.chckboxCanalBeta.Enabled = true;
            }
        }

        private void chckboxCanalBeta_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if(this.chckboxCanalBeta.Checked)
            {
                if (RJMessageBox.Show("Al habilitar las actualizaciones del canal BETA podras probar funciones antes que salgan en la version final, y esto implica que se podran presentar algunos bugs y mal funcionamiento del programa. ¿Seguro deseas continuar con la activacion del canal BETA?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    this.chckboxCanalBeta.Checked = true;
                } else
                {
                    this.chckboxCanalBeta.Checked = false;
                }
            }
            */
        }

        private void btnExaminarActaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Escoger archivo de origen...";
                openFileDialog1.Filter = "Archivos PDF | *.pdf";
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    this.txtOrigenActaResponsiva.Text = path;
                    Properties.Settings.Default.ActaResponsivaPath = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error en escoger la ruta destino. " + ex);
            }
        }

        private void configuracion_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }


        private void btnEliminarCookies_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Show("¿Seguro que deseas borrar los datos de navegacion? Incluyendo contraseñas, cache, cookies, etc.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommonMethodsLibrary.DeleteCacheAndCookies(CommonMethodsLibrary.WebEngine.CEF_SHARP);
            }
        }

        private void txtServidor_Enter_1(object sender, EventArgs e)
        {
            RJMessageBox.Show("** ADVERTENCIA ** cambiar la direccion del servidor puede causar mal funcionamiento en el programa si se ingresa una direccion incorrecta", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTESTConexion_Click(object sender, EventArgs e)
        {
            if (CommonMethodsLibrary.TestServerConnection(this.txtServidor.Text.Replace(" ", string.Empty)))
            {
                RJMessageBox.Show($"Servidor disponible con correcto funcionamiento. Conexion exitosa! {Environment.NewLine}-SERVER NAME: {main.SERVER_NAME + Environment.NewLine}-HOSTNAME: {main.SERVER_MACHINENAME + Environment.NewLine}-PORT: {main.SERVER_PORT + Environment.NewLine}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboxLenguajeSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonMethodsLibrary.OutMessage("in", this.Name, $"SE HA CAMBIADO EL IDIOMA POR DEFECTO DEL NAVEGADOR A '{this.cboxLenguajeSeleccionado_CefSharp.Text}'", "oka");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string PATH = $@"{Application.StartupPath}\UsersCard";

            if (Directory.Exists(PATH))
            {
                tabla_vinculacion frm = new tabla_vinculacion(this);
                frm.ShowDialog();
            }
            else
            {
                RJMessageBox.Show("No hay usuarios que cargar! primero creer un usuario para poder vincularlo a una localidad");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nueva_localidad frm = new nueva_localidad(this);
            frm.ShowDialog();
        }

        private void btnEditarLocalidad_Click(object sender, EventArgs e)
        {
            #region EDITAMOS LA LOCALIDAD SELECCIONADA
            // Buscamos el archivo de la localidad seleccionada
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
            string OBJECT_FILE = "";

            if (!string.IsNullOrEmpty(LOCALIDAD_SELECCIONADA))
            {
                if (Directory.Exists(LOCALS_PATH))
                {
                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");

                    foreach (FileInfo file in files)
                    {
                        JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                        if (json["nombre"].ToString() == LOCALIDAD_SELECCIONADA)
                        {
                            OBJECT_FILE = file.FullName;
                        }
                    }
                    // Construimos el formulario
                    nueva_localidad frm = new nueva_localidad(this, OBJECT_FILE);
                    frm.ShowDialog();
                }
            }
            #endregion
        }

        public string LOCALIDAD_SELECCIONADA = "";
        private void cboxListaDeLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOCALIDAD_SELECCIONADA = this.cboxListaDeLocalidades.SelectedItem.ToString();

            #region ACTUALIZAMOS LA PREVISUALIZACION DE DATOS DE LA LOCALIDAD SELECCIONADA
            // Buscamos el archivo de la localidad seleccionada
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
            string OBJECT_FILE = "";

            if (!string.IsNullOrEmpty(LOCALIDAD_SELECCIONADA))
            {
                if (Directory.Exists(LOCALS_PATH))
                {
                    JObject json;

                    #region LOCALIZACION DE ARCHIVO
                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");

                    foreach (FileInfo file in files)
                    {
                        json = JObject.Parse(File.ReadAllText(file.FullName));

                        if (json["nombre"].ToString() == LOCALIDAD_SELECCIONADA)
                        {
                            OBJECT_FILE = file.FullName;

                            #region OBETENEMOS LOS DATOS
                            this.lblNombreLocalidad.Text = $"{json["nombre"].ToString()}";
                            this.lblDireccionLocalidad.Text = $"{json["direccion"].ToString()}";
                            this.lblSucursalLocalidad.Text = $"{json["sucursal"].ToString()}";
                            this.lblNoDeSucursalLocalidad.Text = $"{json["no_de_sucursal"].ToString()}";
                            this.lblPoblacionLocalidad.Text = $"{json["poblacion"].ToString()}";
                            this.lblCentroDeServiciosLocalidad.Text = $"{json["centro_servicios"].ToString()}";
                            #endregion
                        }
                    }
                    #endregion
                }
            }
            #endregion
        }

        private void btnReestablecer_Forms_Click(object sender, EventArgs e)
        {
            this.txtURL_Forms.Text = URL_FORMS_DEFAULT;
        }

        private void btnReestablecer_ServiceDeskGMXT_Click(object sender, EventArgs e)
        {
            this.txtURL_ServiceDeskGMXT.Text = URL_GMXT_SAS_DEFAULT;
        }

        private void btnReestablecer_ServiceDeskCompusof_Click(object sender, EventArgs e)
        {
            this.txtURL_ServiceDeskCompusof.Text = URL_COMPUSOF_SAS_DEFAULT;
        }

        private void btnReestablecer_EndpointCentral_Click(object sender, EventArgs e)
        {
            this.txtURL_EndpointCentral.Text = URL_ENDPOINT_DEFAULT;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LOCK_REESTABLECER_ENLACES = !LOCK_REESTABLECER_ENLACES;

            if (LOCK_REESTABLECER_ENLACES)
            {
                //this.btnBloqDbloq.Text = "Bloq";
                this.btnUnblockCefSharpPanel.Image = Properties.Resources.unlock_16;

                this.txtURL_ServiceDeskCompusof.Enabled = true;
                this.txtURL_ServiceDeskGMXT.Enabled = true;

                this.label26.Enabled = true;
                this.label27.Enabled = true;

            }
            else
            {
                //this.btnBloqDbloq.Text = "Dbloq";
                this.btnUnblockCefSharpPanel.Image = Properties.Resources.lock_16;

                this.txtURL_ServiceDeskCompusof.Enabled = false;
                this.txtURL_ServiceDeskGMXT.Enabled = false;

                this.label26.Enabled = false;
                this.label27.Enabled = false;

            }
            this.groupBoxReestablecerEnlaces_CefSharp.Enabled = LOCK_REESTABLECER_ENLACES;
        }

        private void btnReestablecerDireccionDefault_Click(object sender, EventArgs e)
        {
            // Seleccionamos la direccion por default de la aplicacion
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            string DEF_LOCAL_PATH = $@"{LOCALS_PATH}\Direccion_default.json";

            if (!File.Exists(DEF_LOCAL_PATH))
            {
                /* Si no existe la Localidad Default */
                MessageBox.Show($"No existe la direccion default, la crearemos \n{DEF_LOCAL_PATH}");

                AddressesManager.ValidateDefaultAddressExists();
            }

            #region PROCEDIMIENTO DE CAMBIADO
            try
            {
                // Guardamos los datos
                /*
                 * Nombre de la localidad se usara como nombre del archivo
                 * '{nombre}.json'
                 */
                string ADDRESES_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

                string PATH_NAME = $@"Direccion_default"; // Solo establecemos el nombre, no la extension

                JObject json_default = JObject.Parse(File.ReadAllText(DEF_LOCAL_PATH));


                Dictionary<string, string> direction = new Dictionary<string, string>();

                direction.Add("nombre", json_default["nombre"].ToString());
                direction.Add("direccion", json_default["direccion"].ToString());
                direction.Add("sucursal", json_default["sucursal"].ToString());
                direction.Add("isDefaultDir", "true");
                direction.Add("no_de_sucursal", json_default["no_de_sucursal"].ToString());
                direction.Add("poblacion", json_default["poblacion"].ToString());
                direction.Add("centro_servicios", json_default["centro_servicios"].ToString());
                direction.Add("estacion", json_default["estacion"].ToString());


                // Cambiamos la clave 'isDefaultDir' a false
                #region Buscamos el archivo anteriormente con el parametro en true para cambiarlo
                string TARGET_FILE = "";
                string TARGET_NAME = "";

                DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                FileInfo[] files = di.GetFiles("*.json");

                foreach (FileInfo file in files)
                {
                    //MessageBox.Show(file.Name);

                    if (file.Name == $"{Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT}.json")
                    {
                        TARGET_FILE = file.FullName;
                        TARGET_NAME = file.Name;
                    }
                }
                #endregion

                #region Reescribimos el archivo con la informacion nueva (setDefaultDir = False)
                if (!string.IsNullOrEmpty(TARGET_FILE))
                {
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

                    //MessageBox.Show("Archivo viejo: " + TARGET_NAME + Environment.NewLine + Environment.NewLine + TARGET_FILE);

                    // Escribimos el archivo anterior como default con el parametro en 'false'
                    File.WriteAllText(TARGET_FILE, System.Text.Json.JsonSerializer.Serialize(new_json));
                }
                #endregion

                // Escribimos el nuevo valor
                Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT = PATH_NAME;
                Properties.Settings.Default.Save();

                this.txtActualLocalidadDefault.Text = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;

                // Escribimos el arcvhivo 'Direccion_default' con el parametro en 'true'
                string finaljson = System.Text.Json.JsonSerializer.Serialize(direction);
                File.WriteAllText($@"{ADDRESES_PATH}\{PATH_NAME}.json", finaljson);

            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"{ex.Message} {Environment.NewLine + Environment.NewLine}El programa dice: '{ex.ToString()}'", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }


        private void btnEliminarLocalidad_Click(object sender, EventArgs e)
        {
            #region PROCEDIMIENTO PARA ELIMINAR UNA LOCALIDAD SELECCIONADA
            if (this.cboxListaDeLocalidades.Items.Count > 0)
            {
                if (RJMessageBox.Show($"¿Seguro que deseas eliminar la localidad {this.cboxListaDeLocalidades.Text}?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Eliminamos la localidad tras la confirmacion

                    // Buscamos el archivo de la localidad seleccionada
                    string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";
                    string OBJECT_FILE = "";

                    if (!string.IsNullOrEmpty(LOCALIDAD_SELECCIONADA))
                    {
                        if (Directory.Exists(LOCALS_PATH))
                        {
                            DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                            FileInfo[] files = di.GetFiles("*.json");

                            foreach (FileInfo file in files)
                            {
                                JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                                if (json["nombre"].ToString() == LOCALIDAD_SELECCIONADA)
                                {
                                    OBJECT_FILE = file.FullName;
                                }
                            }

                            // Eliminamos
                            File.Delete(OBJECT_FILE);

                            // Borramos toda la lista para que se carga de cero
                            this.cboxListaDeLocalidades.Items.Clear();

                            // Recargamos las localidades
                            if (Directory.Exists(LOCALS_PATH))
                            {
                                DirectoryInfo dir = new DirectoryInfo(LOCALS_PATH);
                                FileInfo[] filesr = dir.GetFiles("*.json");
                                foreach (FileInfo file in filesr)
                                {
                                    JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                                    if (file.Name != "Direccion_default.json")
                                    {
                                        this.cboxListaDeLocalidades.Items.Add(json["nombre"].ToString());
                                    }
                                }

                                this.cboxListaDeLocalidades.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            #endregion
        }

        private void btnBloquearNombreDeLocalidad_Click(object sender, EventArgs e)
        {
            if (this.txtLocalidadIDC.Enabled == false)
            {
                this.txtLocalidadIDC.Enabled = true;
                this.btnBloquearNombreDeLocalidad.Image = Properties.Resources.unlock_16;
            }
            else
            {
                this.txtLocalidadIDC.Enabled = false;
                this.btnBloquearNombreDeLocalidad.Image = Properties.Resources.lock_16;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            configuracion_inicial frm = new configuracion_inicial();
            frm.Show();
        }

        private void btnExportarBackup_Click(object sender, EventArgs e)
        {
            respaldo_de_programa frm = new respaldo_de_programa();
            frm.Show();
        }

        private void btnUnlockWebViewPanel_Click(object sender, EventArgs e)
        {
            LOCK_REESTABLECER_ENLACES = !LOCK_REESTABLECER_ENLACES;

            if (LOCK_REESTABLECER_ENLACES)
            {
                //this.btnBloqDbloq.Text = "Bloq";
                this.btnUnlockWebViewPanel.Image = Properties.Resources.unlock_16;

                this.txtURL_EndpointCentral.Enabled = true;
                this.txtURL_Forms.Enabled = true;

                this.label49.Enabled = false;
                this.label38.Enabled = false;

            }
            else
            {
                //this.btnBloqDbloq.Text = "Dbloq";
                this.btnUnlockWebViewPanel.Image = Properties.Resources.lock_16;

                this.txtURL_EndpointCentral.Enabled = false;
                this.txtURL_Forms.Enabled = false;

                this.label49.Enabled = false;
                this.label38.Enabled = false;

            }
            this.groupBoxReestablecerEnlaces_WebView2.Enabled = LOCK_REESTABLECER_ENLACES;
        }

        private void btnEliminarCookies_WebView2_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Show("¿Seguro que deseas borrar los datos de navegacion? Incluyendo contraseñas, cache, cookies, etc.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommonMethodsLibrary.DeleteCacheAndCookies(CommonMethodsLibrary.WebEngine.WEB_VIEW_2, LegacyForm.webView_CompusofForms);
                CommonMethodsLibrary.DeleteCacheAndCookies(CommonMethodsLibrary.WebEngine.WEB_VIEW_2, LegacyForm.webView_ServiceDeskCompusof);
            }
        }

        private void btnAbrirLbretaDeDirecciones_Click(object sender, EventArgs e)
        {
            libreta_direcciones_emails form = new libreta_direcciones_emails(libreta_direcciones_emails.Mandant.CONFIG_PANEL);
            form.ShowDialog();
        }

        private void btnVerModeloVinculado_Click(object sender, EventArgs e)
        {
            // Abrimos el modelo vinculado para visualizacion
            if (actualModelSyncSelected != null)
            {
                exViewSyncModel frm = new exViewSyncModel(actualModelSyncSelected, exViewSyncModel.StartOption.READ);
                frm.ShowDialog();
            }
        }

        private void btnEditarModeloVinculado_Click(object sender, EventArgs e)
        {
            // Editamos el modelo vinculado
            if (actualModelSyncSelected != null)
            {
                MachineModelSyncItem previousModel = actualModelSyncSelected;

                exViewSyncModel frm = new exViewSyncModel(actualModelSyncSelected, exViewSyncModel.StartOption.UPDATE);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Encontramos el indice del objeto anterior
                    ListViewItem targetItemToReplace = this.lviewTablaDeModelosVinculados.Items
                        .Cast<ListViewItem>()
                        .Where(g => g.Text.Trim() == previousModel.NombreComercial.Trim())
                        .FirstOrDefault();

                    int _targetIndex = this.lviewTablaDeModelosVinculados.Items.IndexOf(targetItemToReplace);

                    MachineModelSyncItem m = frm.RESPONSE;
                    ListViewItem item = new ListViewItem()
                    {
                        Text = m.NombreComercial,
                        Tag = m,
                    };
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Name = "subitemNombreClave",
                        Text = $"{m.NombreClave}",
                    });

                    switch (m.Tipo)
                    {
                        case "LAPTOP":
                            item.ImageIndex = 0;
                            item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                            break;
                        case "PC":
                            item.ImageIndex = 1;
                            item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                            break;
                    }

                    modelsVinculated.Items.Remove(previousModel);   // Eliminamos el objeto viejo del listado
                    modelsVinculated.Items.Add(m);  // Añadimos al listado del objeto

                    this.lviewTablaDeModelosVinculados.Items.Remove(targetItemToReplace); // Eliminamos el objeto anterior
                    this.lviewTablaDeModelosVinculados.Items.Insert(_targetIndex, item);     // Insertamos el nuevo objeto en el indice indicado
                }
            }
        }

        private void btnAñadirNuevoModeloVinculado_Click(object sender, EventArgs e)
        {
            // Añadimos un modelo vinculado nuevo
            exViewSyncModel frm = new exViewSyncModel(exViewSyncModel.StartOption.CREATE);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MachineModelSyncItem m = frm.RESPONSE;
                ListViewItem item = new ListViewItem()
                {
                    Text = m.NombreComercial,
                    Tag = m,
                };
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "subitemNombreClave",
                    Text = $"{m.NombreClave}",
                });

                switch (m.Tipo)
                {
                    case "LAPTOP":
                        item.ImageIndex = 0;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                        break;
                    case "PC":
                        item.ImageIndex = 1;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                        break;
                }

                modelsVinculated.Items.Add(m); // Añadimos al listado del objeto
                this.lviewTablaDeModelosVinculados.Items.Add(item); // Añadimos a la visualizacion
            }
        }

        private void btnEliminarModeloVinculado_Click(object sender, EventArgs e)
        {
            // Eliminamos el modelo vinculado seleccionado
            if (actualModelSyncSelected != null)
            {
                if (MessageBox.Show($"¿Seguro que deseas eliminar la vinculacion de '{actualModelSyncSelected.NombreComercial} -> {actualModelSyncSelected.NombreClave}'?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MachineModelSyncItem previousModel = actualModelSyncSelected;

                    // Encontramos el indice del objeto anterior
                    ListViewItem targetItemToReplace = this.lviewTablaDeModelosVinculados.Items
                        .Cast<ListViewItem>()
                        .Where(g => g.Text.Trim() == previousModel.NombreComercial.Trim())
                        .FirstOrDefault();

                    modelsVinculated.Items.Remove(previousModel);   // Eliminamos el objeto viejo del listado
                    this.lviewTablaDeModelosVinculados.Items.Remove(targetItemToReplace); // Eliminamos el objeto anterior

                    if (this.lviewTablaDeModelosVinculados.Items.Count >= 1)
                    {
                        this.lviewTablaDeModelosVinculados.Items[0].Selected = true;
                    }
                }
            }
        }

        MachineModelSyncItem actualModelSyncSelected = null;
        private void lviewTablaDeModelosVinculados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lviewTablaDeModelosVinculados.SelectedItems.Count == 1)
                {
                    actualModelSyncSelected = (MachineModelSyncItem)this.lviewTablaDeModelosVinculados.SelectedItems[0].Tag;
                }

                if (actualModelSyncSelected != null)
                {
                    this.btnEditarModeloVinculado.Enabled = true;
                    this.btnEliminarModeloVinculado.Enabled = true;
                }
                else
                {
                    this.btnEditarModeloVinculado.Enabled = false;
                    this.btnEliminarModeloVinculado.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado! {ex.Message}\n\n{ex}", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lviewTablaDeModelosVinculados_DoubleClick(object sender, EventArgs e)
        {
            if (actualModelSyncSelected != null && this.lviewTablaDeModelosVinculados.SelectedItems.Count == 1)
            {
                this.btnVerModeloVinculado.PerformClick();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAñadirArea_Click(object sender, EventArgs e)
        {
            /* 
             * Añadimos una nueva area
             * */
            new Departamentos().Add(txtNombreNuevaArea.Text.Trim());
            LoadAreas();    // Recargamos la lista de visualizacion
            this.txtNombreNuevaArea.Text = "";
        }

        private void txtNombreNuevaArea_TextChanged(object sender, EventArgs e)
        {
            bool flagEnable = false;

            if (!String.IsNullOrEmpty(this.txtNombreNuevaArea.Text.Trim()))
            {
                string[] nombresToLower = new string[lboxAreasRegistradas.Items.Count];

                int c = 0;
                foreach (string i in lboxAreasRegistradas.Items)
                {
                    nombresToLower[c] = i.ToLower().Trim();
                    c++;
                }

                if (nombresToLower.Contains(txtNombreNuevaArea.Text.ToLower().Trim()) == false)
                {
                    // En caso de que se quiera ingresar una nueva area
                    flagEnable = true;
                }
                else
                {
                    // En caso de que se intente ingresar una area actualmente ya ingresada
                    flagEnable = false;
                }
            }

            this.btnAñadirArea.Enabled = flagEnable;
        }

        private void btnExportarArchivoJson_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog1.Title = "Selecciona la ruta de guardado del arcvhivo...";
                this.saveFileDialog1.Filter = "Archivo JSON (*.json)| *.json";
                this.saveFileDialog1.FileName = "Organization Areas Copy";

                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    new Departamentos().SaveJsonCopy(path: saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lboxAreasRegistradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabledFlag = false;

            if (this.lboxAreasRegistradas.SelectedItem != null)
            {
                enabledFlag = true;
            }

            this.btnEliminarArea.Enabled = enabledFlag;
        }

        private void btnEliminarArea_Click(object sender, EventArgs e)
        {
            /* 
             * Eliminamos el area seleccionada
             * */
            string selectedItem = this.lboxAreasRegistradas.SelectedItem.ToString();

            if (MessageBox.Show($"¿Estas seguro que deseas eliminar el area '{selectedItem}' del listado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new Departamentos().Delete(selectedItem);
                LoadAreas();
                this.btnEliminarArea.Enabled = false;
            }
        }

        private void btnImportarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Selecciona el archivo...";
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    new Departamentos().ImportConfig(this.openFileDialog1.FileName);
                    LoadAreas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTESTConexion_Click_1(object sender, EventArgs e)
        {

        }
    }
}
