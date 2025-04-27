using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

using CustomMessageBox;


namespace Flow_Solver
{
    internal class Beta_Updates
    {
        public static string BetaVersion { get; set; }                                 // Version a instalar
        public static string ServerRoute = Properties.Settings.Default.SERVER_ROUTE;   // Ruta del servidor
        public static string InstallerRoute = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RIT_BETA_UpdaterUtility.exe";
        public static bool DownloadCompleted = false;

        // REVISAMOS LA CONECTIVIDAD A INTERNET
        public static bool connectivity ()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return true;
            } else
            {
                return false;
            }
        }


        // BUSCA LA ULTIMA ACTUALIZACION

        public static string LastBetaVersionOnServer ()
        {
            // DEVUELVE LA ULTIMA VERSION DISPONIBLE QUE TIENE EL SERVIDOR
            if (connectivity() == true)
            {
                try
                {
                    string ser_ver = "";
                    string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\BETA_VERSION.txt";

                    WebClient wc = new WebClient();
                    wc.DownloadFile(new Uri($@"\\{ServerRoute}\Publico\Flow_Solver_server\BETA_VERSION.txt"), path);

                    StreamReader sr = new StreamReader(path);
                    ser_ver = File.ReadLines(path).Last();
                    sr.Close();

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    BetaVersion = ser_ver;
                    return ser_ver;

                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Ha ocurrido un error inesperado en la descarga." + Environment.NewLine + Environment.NewLine + "El programa dice:" + Environment.NewLine + ex.Message, "Beta Updates - Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // retornamos a version actual de ensamblado para evitar errores a la hora de comparacion
            return Properties.Settings.Default.SYS_ASSEMBLY;
        }

        public static bool SearchBETAUpdate ()
        {
            bool NEW_UPDATE = false;

            #region DESCOMPOSICION DE DATOS DEL SERVIDOR
            string SERVER_VERSION = LastBetaVersionOnServer();
            
            /** VERSION DE SERVIDOR **/
            // DIA DE VERSION
            string DIA_server = SERVER_VERSION.Remove(2);
            string MES_server = (SERVER_VERSION.Substring(SERVER_VERSION.IndexOf(DIA_server) + DIA_server.Length) + 2).Remove(2);
            string AÑO_server = (SERVER_VERSION.Substring(SERVER_VERSION.IndexOf(MES_server) + MES_server.Length) + 4).Remove(4);
            string TIPO_server = SERVER_VERSION.Substring(SERVER_VERSION.IndexOf(AÑO_server) + AÑO_server.Length);
            #endregion

            #region DESCOMPOSICION DE DATOS LOCALES
            string LOCAL_VERSION = Properties.Settings.Default.SYS_ASSEMBLY;

            /** VERSION DE SERVIDOR **/
            // DIA DE VERSION
            string DIA_local = LOCAL_VERSION.Remove(2);
            string MES_local = (LOCAL_VERSION.Substring(LOCAL_VERSION.IndexOf(DIA_local) + DIA_local.Length) + 2).Remove(2);
            string AÑO_local = (LOCAL_VERSION.Substring(LOCAL_VERSION.IndexOf(MES_local) + MES_local.Length) + 4).Remove(4);
            string TIPO_local = LOCAL_VERSION.Substring(LOCAL_VERSION.IndexOf(AÑO_local) + AÑO_local.Length);
            #endregion


            #region PROCESO DE EVALUACION
            /*
            if (Int32.Parse(AÑO_server) > Int32.Parse(AÑO_local))
            {
                Console.WriteLine("año mayor");
                NEW_UPDATE = true;
                if (Int32.Parse(MES_server) > Int32.Parse(MES_local))
                {
                    Console.WriteLine("mes mayor");
                    NEW_UPDATE = true;
                    if (Int32.Parse(DIA_local) > Int32.Parse(DIA_local))
                    {
                        Console.WriteLine("dia mayor");
                        NEW_UPDATE = true;
                    }
                }
            }*/

            DateTime ASSEMBLY_SERVER_DATE = new DateTime(Int32.Parse(AÑO_server), Int32.Parse(MES_server), Int32.Parse(DIA_server));
            DateTime ASSEMBLY_LOCAL_DATE = new DateTime(Int32.Parse(AÑO_local), Int32.Parse(MES_local), Int32.Parse(DIA_local));

            int COMPARATION = DateTime.Compare(ASSEMBLY_SERVER_DATE, ASSEMBLY_LOCAL_DATE);

            if (COMPARATION < 0)
            {
                NEW_UPDATE = false;
            }
            else if (COMPARATION > 0)
            {
                NEW_UPDATE = true;
            } else
            {
                NEW_UPDATE = false;
            }

            #endregion

            if (NEW_UPDATE)
            {
                CommonMethodsLibrary.OutMessage("out", "Beta_Updates.cs", $"SE ENCONTRO LA ACTUALIZACION BETA '{SERVER_VERSION}' // ACTUAL: '{LOCAL_VERSION}'", "inf");
            }
            else
            {
                CommonMethodsLibrary.OutMessage("out", "Beta_Updates.cs", $"NO SE ENCONTRARON ACTUALIZACIONES BETA. CUENTAS CON LA ULTIMA VERSION; EN SERVIDOR: '{SERVER_VERSION}' // ACTUAL: '{LOCAL_VERSION}' ", "inf");
            }

            return NEW_UPDATE;
        } 


        // DESCARGA EL ARCHIVO INSTALADOR
        public static void DownloadBetaUpdate()
        {
            // Comprobamos la conexion con el servidor
            if (connectivity() == true)
            {
                /* Descargamos el instalador */
                try
                {
                    WebClient client = new WebClient ();

                    client.DownloadFileCompleted += client_DownloadFileCompleted;
                    client.DownloadFileAsync(new Uri($@"\\{ServerRoute}\Publico\Flow_Solver_server\SETUP_BETA_UPDATER.exe"), InstallerRoute);
                
                } catch (Exception ex)
                {
                    RJMessageBox.Show("Ha ocurrido un error inesperado en la descarga." + Environment.NewLine + Environment.NewLine + "El programa dice:" + Environment.NewLine + ex, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DownloadCompleted = true;
            //progressDescarga.IsIndeterminate = true;
            if (DownloadCompleted == true)
            {
                Process.Start(InstallerRoute);
            }

            // -> CERRAMOS LA APLICACION PARA QUE EL INSTALADOR FUNCIONE ADECUADAMENTE
            Application.Exit();
        }
    }
}
