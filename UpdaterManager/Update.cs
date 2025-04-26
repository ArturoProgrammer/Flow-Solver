using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows;


namespace UpdaterManager
{
    public class Update
    {
        public static string NewVersion { get; set; }
        public static string ServerRoute { get; set; }

        public static string ruta_instalador;
        public static WebClient client = new WebClient();

        public static void DownloadLastvesion()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                /* DESCARGA LA ULTIMA VERSION PUBLICADA DEL SERVIDOR */
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RIT_UpdaterUtility.exe";
                ruta_instalador = ruta;

                //WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri($@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"), ruta);

            }
        }


       /*
        private void DownloadLastvesion()
        {<
            client.DownloadProgressChanged +=client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;

            // DESCARGA LA ULTIMA VERSION PUBLICADA DEL SERVIDOR
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RIT_UpdaterUtility.exe";
            ruta_instalador = ruta;

            //WebClient client = new WebClient();
            client.DownloadFile(new Uri($@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"), ruta);

        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbStatus.IsIndeterminate = false;
            pbStatus.Value = (double)e.ProgressPercentage;
        }

        void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            pbStatus.IsIndeterminate = true;
        }
       */
        

        // FUNCION LISTA
        /// <summary>
        /// Obtiene la ultima version del software registrado en la base de datos
        /// </summary>
        /// <returns></returns>
        public static string GetServerVersion()
        {
            /* 
            * VALIDAMOS LA EXISTENCIA DE UNA NUEVA VERSION EN EL SERVIDOR
            */
            string ser_ver = "";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VERSION.txt";

            //WebClient client = new WebClient();
            client.DownloadFile(new Uri($@"\\{ServerRoute}\Publico\rit_solver_server\VERSION.txt"), path);

            StreamReader sr = new StreamReader(path);
            ser_ver = File.ReadLines(path).Last();
            sr.Close();

            File.Delete(path);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            NewVersion = ser_ver;
            return ser_ver;
        }

        /// <summary>
        /// Eliminamos el instalador descargado
        /// </summary>
        public static void DeleteUpdater()
        {
            /* ELIMINAMOS LA INSTANCIA DEL ACTUALIZADOR */
            // -> ESTA FUNCION SE EJECUTA TRAS EL INICIO DEL EQUIPO
            if (File.Exists(ruta_instalador))
            {
                File.Delete(ruta_instalador);
            }
        }

        /// <summary>
        /// Busca actualizaciones en el servidor
        /// </summary>
        /// <param name="ServerPath">Ruta en red del servidor</param>
        /// <param name="UpdatesActivateFlag"></param>
        /// <param name="LocalMachineVersion">Version local instalada</param>
        /// <returns>En caso de encontrarse una version mas nueva a la instalada localmente, devuelve True y False en caso contrario.</returns>
        public static bool SearchUpdates(string ServerPath, bool UpdatesActivateFlag, string LocalMachineVersion)
        {
            bool NEW_VERSION_AVAILABLE = false;
            try
            {
                UpdaterManager.Update.ServerRoute =  ServerPath; //Properties.Settings.Default.SERVER_ROUTE;

                if (UpdatesActivateFlag == true)
                {
                    /* REVISAMOS SI EXISTEN ACTUALIZACIONES POR APLICAR
                     * 
                     * Esta labor se realiza de inmediato al iniciar la aplicacion *
                     * 
                     */

                    string SERVER_VERSION = UpdaterManager.Update.GetServerVersion();
                    string LOCAL_VERSION = LocalMachineVersion; //Properties.Settings.Default.SYS_VERSION;

                    #region METODO DE DATOS ACTUALIZADO
                    /** PROCESOD DE ADICION A LISTAS **/
                    int[] local_version = new int[4];
                    int[] version_server = new int[4];
                    int x = 0;

                    for (int i = 0; i < LOCAL_VERSION.Length; i++) 
                    {
                        string character = LOCAL_VERSION.Substring(i, 1);
                        if (character != ".")
                        {
                            //Console.WriteLine(character);
                            local_version[x] = Int32.Parse(character);
                            x++;
                        }
                    }

                    x = 0;
                    
                    for (int i = 0; i < SERVER_VERSION.Length; i++)
                    {
                        string character = SERVER_VERSION.Substring(i, 1);
                        if (character != ".")
                        {
                            //Console.WriteLine(character);
                            version_server[x] = Int32.Parse(character);
                            x++;
                        }
                    }

                    string STRING_SERVIDOR = "";
                    string STRING_LOCAL = "";
                    /* EVALUACION DE LOS DATOS */
                    for (int i = 0; i < local_version.Length; i++)
                    {
                        //Console.WriteLine($"INDEX: {i}; DATO_U: {local_version[i]}; DATO_D: {version_server[i]}");
                        int VALOR_LOCAL = local_version[i];
                        int VALOR_SERVIDOR = version_server[i];

                        STRING_SERVIDOR = STRING_SERVIDOR + $"{VALOR_SERVIDOR}";
                        STRING_LOCAL = STRING_LOCAL + $"{VALOR_LOCAL}";
                    }

                    int L_SUMA = Int32.Parse(STRING_LOCAL);
                    int S_SUMA = Int32.Parse(STRING_SERVIDOR);

                    if (L_SUMA < S_SUMA)
                    {
                        //Console.WriteLine("VERSION DISPONIBLE");
                        NEW_VERSION_AVAILABLE = true;
                    } else if (L_SUMA > S_SUMA)
                    {
                        //Console.WriteLine("ESTAS DESARROLLANDO UNA VERSION NUEVA?");
                        NEW_VERSION_AVAILABLE = false;
                    } else if (L_SUMA == S_SUMA)
                    {
                        //Console.WriteLine("TIENES LA VERSION MAS ACTUAL");
                        NEW_VERSION_AVAILABLE = false;
                    }

                    //Console.WriteLine(STRING_SERVIDOR);
                    //Console.WriteLine(STRING_LOCAL);

                    return NEW_VERSION_AVAILABLE;
                    #endregion
                }
                else
                {
                    return false;
                }
            } catch
            {
                return false;
            }
        }
    }
}
