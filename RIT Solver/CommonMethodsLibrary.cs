using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

using System.Xml;
using System.Windows.Forms;


using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using CustomMessageBox;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.WinForms;
using System.DirectoryServices.ActiveDirectory;
using CefSharp.DevTools.Page;


namespace RIT_Solver
{
    internal class CommonMethodsLibrary
    {
        static StringBuilder LogMessageLines = new StringBuilder();

        static string ExecutionStatus = "OK";

        public static void OutMessage(string aOperationType, string aConstructor, string aMessage, string aStatus)
        {
            // RUTINA PARA MENSAJES DE PROMPT PERSONALIZADOS

            /* ESTATUS PERMITIDOS
             * - INF // INFO
             * - ERR // ERROR EN LA APLICACION
             * - EXC // EXCEPCION PRODUCIDA POR LA APLICACION
             * - WAR // ADVERTENCIA POR ALGUN PROCESO
             * - OKA // ACCION REALIZADA CON EXITO
             */

            #region CODIGO
            StringBuilder MSG = new StringBuilder();
            
            if (aOperationType.ToLower() == "in")
            {
                MSG.Append($" <= [IN] {aStatus.ToUpper()}");
            } else if (aOperationType.ToLower() == "out")
            {
                MSG.Append($" => [OUT] {aStatus.ToUpper()}");
            }

            DateTime hora_actual = DateTime.Now;

            string hora_mili = hora_actual.ToString("hh:mm:ss fff ms");

            MSG.Append($" <{hora_mili}>");
            MSG.Append($" ('{aConstructor}')_:: {aMessage}");

            LogMessageLines.Append(MSG.ToString() + Environment.NewLine);

            Console.WriteLine(MSG);
            #endregion
        }

        public enum WebEngine
        {
            CEF_SHARP,
            WEB_VIEW_2
        }

        /// <summary>
        /// Eliminamos las Cookies y Cache de los navegadores CefSharp
        /// </summary>
        /// <param name="_WebEngine"></param>
        public static void DeleteCacheAndCookies (WebEngine _WebEngine)
        {
            // ELIMINA LA CACHE, LAS COOKIES Y DATOS DE NAVEGACION DE CEFSHARP
            try
            {


                if (_WebEngine == WebEngine.CEF_SHARP)
                {
                    #region CODIGO
                    if (Directory.Exists(main.CEF_CACHE_PATH))
                    {
                        Directory.Delete(main.CEF_CACHE_PATH, true);
                        OutMessage("out", "main", $"ARCHIVOS DE CACHE EN RUTA '{main.CEF_CACHE_PATH}' BORRADOS CON EXITO!", "oka");

                        RJMessageBox.Show($"Datos de navegacion de '{_WebEngine}' borrados con exito!\n\nReinicie el navegador manualmente para aplicar los cambios correctamente", "Panel de Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar borrar las cookies del navegador CefSharp! {ex.Message}\n{ex}", "Cookies y Cache Admin. - CefSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("OUT", "CommonMethodsLibrary", $"OCURRIO UN ERROR AL INTENTAR BORRAR LAS COOKIES Y CACHE DE LOS NAVEGADORES {_WebEngine}. {ex.Message}\n{ex}", "ERR");
            }
        }

        /// <summary>
        /// Eliminamos las Cookies y Cache de los navegadores WebView2
        /// </summary>
        /// <param name="_WebEngine"></param>
        /// <param name="_WebViewObject"></param>
        public static async void DeleteCacheAndCookies(WebEngine _WebEngine, WebView2 _WebViewObject)
        {
            try
            {
                // ELIMINA LA CACHE, LAS COOKIES Y DATOS DE NAVEGACION DE WEBVIEW2
                if (_WebEngine == WebEngine.WEB_VIEW_2 && _WebViewObject != null)
                {
                    #region CODIGO
                    var env = _WebViewObject.CoreWebView2.Environment;

                    // Limpiamos las Cookies
                    var cookieManager = _WebViewObject.CoreWebView2.CookieManager;
                    cookieManager.DeleteAllCookies();

                    // Limpiamos la cache
                    var dataFolder = env.UserDataFolder;
                    if (Directory.Exists(dataFolder))
                    {
                        Directory.Delete(dataFolder, true);
                        OutMessage("out", "main", $"ARCHIVOS DE CACHE EN RUTA '{dataFolder}' BORRADOS CON EXITO!", "oka");
                        RJMessageBox.Show($"Datos de navegacion de '{_WebEngine}' borrados con exito!", "Panel de Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    await _WebViewObject.EnsureCoreWebView2Async(env);
                    #endregion
                }
            } catch (WebException ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar borrar las cookies del navegador CefSharp! {ex.Message}\n{ex}", "Cookies y Cache Admin. - CefSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("OUT", "CommonMethodsLibrary", $"OCURRIO UN ERROR AL INTENTAR BORRAR LAS COOKIES Y CACHE DE LOS NAVEGADORES {_WebEngine}. {ex.Message}\n{ex}", "ERR");
            }
        }


        public static void CreateLogFile ()
        {
            /* ARCHIVO LOG DE SALIDA */
            #region CODIGO
            string LOG_PATH = $@"{Application.StartupPath}\LastExecutionLogFile.log";

            StreamWriter sw = new StreamWriter(LOG_PATH);
            sw.WriteLine($"ARCHIVO LOG GENERADO EL DIA: {DateTime.Now}" 
                + Environment.NewLine + 
                $"SOFTWARE: RIT Solver" 
                + Environment.NewLine +
                $"VERSION: {Properties.Settings.Default.SYS_VERSION}" +
                 Environment.NewLine +
                $"COMPILACION: {Properties.Settings.Default.SYS_ASSEMBLY}" +
                Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine);
            sw.WriteLine(LogMessageLines);

            sw.WriteLine(Environment.NewLine + $"STATUS DE EJECUCION: {ExecutionStatus}");

            sw.Close();
            #endregion
        }

        public static bool TestServerConnection(string aServerIp)
        {
            #region CODIGO
            string[] SHA_Keys = new string[7]
            {
                "904691eadc6366f536f9eabc5e9a90a1f699b5cb90e7a928cb613b504f8e02f6",
                "c399ebb9f44be71b7f0d317aacfbd108e6f63a8093ec4c0826cb3eb9ad0201a0",
                "5d2263167a02c34bd4f955f2d903dcfcf80a024b172d504c489390c6e0fd343b",
                "bc6b440e9e80c6a17601ad44027340e0dd8c777ba81d82b03c627293a156bd6f",
                "05b17510b0af46027506f08ed842f666d891cf686f8303eaf5a27a419328f9b9",
                "1fb58a330cf7a1a1e6be60b3f535da43644ddc8c9a05fcedc310863f66115cc1",
                "9836c57f03032e17b5b169a521b446738e1ccea9feb3f2f36fa154935e6d4651"
            };

            bool CONNECT_STATUS = false;
            
            string Manifest_Path = $@"\\{aServerIp}\Publico\rit_solver_server\credentials\ServerCredentialsManifest.pfx";

            OutMessage("out", "CommonMethodsLibrary.cs", $"TESTEANDO CONEXION CON SERVIDOR '{aServerIp}'...", "inf");

            // VALIDAMOS CONEXION A LA WEB
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                OutMessage("out", "CommonMethodsLibrary.cs", $"CONEXION CON SERVIDOR ESTABLE...", "OKA");

                string Server_Name;
                string Server_ID;
                string Server_MachineName;
                string Server_RootKey;
                string Server_Port;

                try
                {
                    int coinc = 0;
                    // VALIDAMOS CONEXION CON SERVIDOR
                    /** POSIBLEMENTE AÑADIR VALIDACION DE ARCHIVO DE CREDENCIALES **/
                    OutMessage("out", "CommonMethodsLibrary.cs", $"BUSCANDO ARCHIVO 'ServerCredentialsManifest.pfx'", "OKA");

                    if (File.Exists(Manifest_Path))
                    {
                        OutMessage("out", "CommonMethodsLibrary.cs", $"VALIDANDO CLAVES...", "OKA");

                        XmlDocument doc = new XmlDocument();
                        doc.Load($@"{Manifest_Path}");

                        XmlNodeList nodeServer = doc.GetElementsByTagName("server");

                        Server_Name = nodeServer[0].Attributes["Name"].InnerText;
                        Server_ID = nodeServer[0].Attributes["ID"].InnerText;
                        Server_MachineName = nodeServer[0].Attributes["MachineName"].InnerText;
                        Server_RootKey = nodeServer[0].Attributes["RootKey"].InnerText;
                        Server_Port = nodeServer[0].Attributes["Port"].InnerText;

                        main.SERVER_NAME= Server_Name;
                        main.SERVER_ID= Server_ID;
                        main.SERVER_MACHINENAME= Server_MachineName;
                        main.SERVER_ROOTKEY = Server_RootKey;
                        main.SERVER_PORT = Server_Port;


                        XmlNodeList elemList = doc.GetElementsByTagName("access");
                        foreach (XmlNode elem in elemList)
                        {
                            string code = elem.InnerText.Trim();

                            /* VALIDA LA RELACION DE CONFIANZA CON EL SERVIDOR */
                            if (SHA_Keys.Contains(code))
                            {
                                coinc++;
                            }
                        }

                        // Genera el veredicto final de conexion
                        if (coinc == 7) { CONNECT_STATUS = true; }

                        return CONNECT_STATUS;
                    }
                    else
                    {
                        RJMessageBox.Show($"Servidor no valido! no cuenta con las credenciales suficientes. Asegurese de introducir una direccion IP de un servidor valido otorgado por el programador", "Test de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        OutMessage("out", "CommonMethodsLibrary.cs", $"NO SE ENCONTRO EL ARCHIVO 'ServerCredentialsManifest.pfx' EN RUTA '{Manifest_Path}'", "OKA");
                    }
                }
                catch (Exception ex)
                {
                    // REGRESAMOS FALSE POR PROBLEMAS CON LA CONEXION AL SERVIDOR
                    OutMessage("in", "CommonMethodsLibrary.cs", $"HA OCURRIDO UN ERROR INESPERADO CON LA CONEXION AL SERVIDOR. EL PROGRAMA INDICA: '{ex.Message}'", "EXC");

                    RJMessageBox.Show($"HA OCURRIDO UN ERROR INESPERADO CON LA CONEXION AL SERVIDOR. EL PROGRAMA INDICA: '{ex.Message}'", "Test de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    CONNECT_STATUS = false;
                }
            }
            else
            {
                // REGRESAMOS FALSE POR NO TENER ACCESO A LA RED
                CONNECT_STATUS = false;

                RJMessageBox.Show("No hay conexion disponible al servidor! asegurese de estar conectado a la red", "Test de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            return CONNECT_STATUS;
            #endregion
        }


        static List<int> numerosGenerados = new List<int>();
        public static int IdentifierGenerator()
        {
            // Crear una instancia del generador de números aleatorios
            Random rnd = new Random();

            MAKENUM:
            int num = rnd.Next(100000, 1000000);

            if (numerosGenerados.Contains(num))
            {
                goto MAKENUM;
            }
            numerosGenerados.Add(num);  // Registramos el valor en la lista

            return num;
        }

        /// <summary>
        /// Extrae los datos de la localidad indicada en los controles del Form 'rit_mdi_form'.
        /// </summary>
        /// <param name="JsonFilePath">Archivo json de la localidad seleccionada.</param>
        /// <param name="Constructor">Formulario MDI Heredado</param>
        internal static void ExtractAllData (string JsonFilePath, rit_mdi_form Constructor)
        {
            var form = Constructor;

            #region EXTRAEMOS LOS DATOS DEL JSON
            //MessageBox.Show(JsonFilePath);

            string json_path = File.ReadAllText(JsonFilePath);
            JObject json = JObject.Parse(json_path);

            form.txtDireccion.Text = json["direccion"].ToString();
            form.txtSucursal.Text = json["sucursal"].ToString();
            form.txtNoDeSucursal.Text = json["no_de_sucursal"].ToString();
            form.cboxPoblacion.Text = json["poblacion"].ToString();
            form.txtCentroDeServicios.Text = json["centro_servicios"].ToString();

            //MessageBox.Show(json["estacion"].ToString());

            if (json.ContainsKey("estacion"))
            {
                switch (json["estacion"].ToString())
                {
                    case "FXE":
                        form.txtCliente.Text = "Ferromex";
                        break;
                    case "FSRR":
                        form.txtCliente.Text = "Ferrosur";
                        break;
                    case "IMEX":
                        form.txtCliente.Text = "IMEX";
                        break;
                    default:
                        form.txtCliente.Text = "N/a";
                        break;
                }
                
                //MessageBox.Show(json["estacion"].ToString());
            }
            #endregion
        }

        /// <summary>
        /// Carga la direccion pertinente
        /// </summary>
        /// <param name="NombreLocalidad">Nombre de la localidad a cargar</param>
        /// <param name="ConstructorForm">Form constructor</param>
        public static void LoadDirection (string NombreLocalidad, rit_mdi_form ConstructorForm)
        {
            // Con nombre de la localidad se refiere a nombre del archivo

            // CARGA LOS DATOS DE LA LOCALIDAD SELECCIONAD
            //MessageBox.Show($"Cargando los datos de la localidad {NombreLocalidad}");

            string ROOT_ADD_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (NombreLocalidad == "Direccion default")
            {
                ExtractAllData($@"{ROOT_ADD_PATH}\FXE_Direccion default.json", ConstructorForm);
            } else
            {
                ExtractAllData($@"{ROOT_ADD_PATH}\{NombreLocalidad}.json", ConstructorForm);
            }
        }


        public static decimal StringBetweenMatches (string StrA, string StrB)
        {
            decimal PERCENTUAL_MATCH = 0;
            int Len_Coinc = 0;

            #region CODIGO
            // Creamos y añadimos los caracteres de lista A
            List<char> CharsA = new List<char>();
            foreach (char i in StrA)
            {
                CharsA.Add(i);
            }
            int LEN_A = CharsA.Count;

            // Creamos y añadimos los caracteres de lista B
            List<char> CharsB = new List<char>();
            foreach (char i in StrB)
            {
                CharsB.Add(i);
            }
            int LEN_B = CharsB.Count;

            foreach (char i in CharsA)
            {
            }

            #endregion

            return PERCENTUAL_MATCH;
        }

        /// <summary>
        /// Valida la existencia de los directorios de inventarios, al menos el de equipos y usuarios
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ValidateInventoryExists(InventoryClass invType)
        {
            bool response = false;
            string targetPath = $@"{Application.StartupPath}\Inventories";

            switch (invType)
            {
                case InventoryClass.UsuariosYEquipos:
                    targetPath = Path.Combine(targetPath, "USUARIOS Y EQUIPOS.xlsx");
                    break;
            }

            // Evaluamos si el directorio indicado existe o no
            if (File.Exists(targetPath))
            {
                response = true;
            }

            return response;
        }

        public static InventoryClass ParseInventoryClass (string value)
        {
            InventoryClass response = InventoryClass.UsuariosYEquipos;

            switch (value)
            {
                case "UsuariosYEquipos":
                    response = InventoryClass.UsuariosYEquipos;
                    break;
                case "Impresoras":
                    response = InventoryClass.Impresoras;
                    break;
                case "Refacciones":
                    response = InventoryClass.Refacciones;
                    break;
                case "Toners":
                    response = InventoryClass.Toners;
                    break;
            }

            return response;
        }
    }
}
