using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class actualizador_beta : Form
    {
        static string ServerRoute = Properties.Settings.Default.SERVER_ROUTE;
        bool DownloadReady = false;
        string InstallerRoute = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RIT_BETA_UpdaterUtility.exe";

        public actualizador_beta()
        {
            InitializeComponent();
        }

        WebClient client = new WebClient();

        private void actualizador_beta_Load(object sender, EventArgs e)
        {

            this.lvlVersionActual.Text = Properties.Settings.Default.SYS_ASSEMBLY;
            this.lvlVersionNueva.Text = Beta_Updates.LastBetaVersionOnServer();
            DownloadBetaUpdate();   // INCIAMOS DESCARGA
        }

        public void DownloadBetaUpdate()
        {
            // Comprobamos la conexion con el servidor
            if (Beta_Updates.connectivity() == true)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO CONECTIVIDAD PARA REALIZAR LA DESCARGA DE '{$@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"}'", "error");

                /* Descargamos el instalador */
                try
                {
                    client.DownloadProgressChanged += client_DownloadProgressChanged;
                    client.DownloadFileCompleted += client_DownloadFileCompleted;

                    CommonMethodsLibrary.OutMessage("out", this.Name, $"COMIENZA LA DESCARGA DE LA VERSION: '{UpdaterManager.Update.NewVersion}'", "inf");

                    client.DownloadFileAsync(new Uri($@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"), InstallerRoute);
                }
                catch (Exception ex)
                {
                    CommonMethodsLibrary.OutMessage("out", this.Name, $"ERROR INESPERADO EN EL PROCESO DE DESCARGA. EL PROGRAMA DICE: '{ex.ToString()}'", "EXC");

                    RJMessageBox.Show("Ha ocurrido un error inesperado en la descarga." + Environment.NewLine + Environment.NewLine + "El programa dice:" + Environment.NewLine + ex, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO CONECTIVIDAD PARA REALIZAR LA DESCARGA DE '{$@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"}'", "err");
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // PROGRESO DE LA DESCARGA
            this.progressDescarga.Value = (int)e.ProgressPercentage;
            this.lblPorcentaje.Text = e.ProgressPercentage.ToString() + "%";
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // DESCARGA COMPLETADA
            try
            {
                if (!e.Cancelled)
                {
                    DownloadReady = true;
                    //progressDescarga.IsIndeterminate = true;
                    if (DownloadReady == true)
                    {
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"PROCESO DE DESCARGA REALIZADA CON EXITO!", "oka");
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"INICIANDO PROCESO DE INSTALACION DE ACTUALIZACION BETA!", "INF");
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"EJECUTANDO INSTALADOR '{InstallerRoute}'", "inf");
                        Process.Start(InstallerRoute);
                    }

                    // -> CERRAMOS LA APLICACION PARA QUE EL INSTALADOR FUNCIONE ADECUADAMENTE
                    CommonMethodsLibrary.OutMessage("out", this.Name, $"CERRANDO LA APLICACION", "INF");

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizador_beta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DownloadReady)
            {
                switch (RJMessageBox.Show("¿Seguro que desea cancelar la descarga de la actualizacion?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Cerramos el actualizador
                        client.CancelAsync();
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"DESCARGA DE ACTUALIZACION CANCELADA POR EL USUARIO AL '{this.lblPorcentaje.Text}'", "WAR");
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"CIERRE DE FORMULARIO '{this.Name}'", "INF");
                        break;
                    case DialogResult.No:
                        // No hacemos nada
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
