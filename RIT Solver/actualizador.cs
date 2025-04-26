using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdaterManager;
using System.Diagnostics;
using System.Net;
using System.IO;

using CustomMessageBox;

namespace RIT_Solver
{
    public partial class actualizador : Form
    {
        public string ruta_instalador;
        public bool DownloadReady = false;
        public actualizador()
        {
            InitializeComponent();
        }
 
        private void actualizador_Load(object sender, EventArgs e)
        {
            /* PROCESO DE ACTUALIZADOR */
            this.lvlVersionActual.Text = "v" + Properties.Settings.Default.SYS_VERSION;
            this.lvlVersion.Text = "v" + UpdaterManager.Update.NewVersion;

            // -> DESCARGAMOS EL INSTALADOR ACTUALIZADO
            DownloadLastvesion();

        }

        WebClient client = new WebClient();
        private void DownloadLastvesion()
        {
            try
            {
                string ServerRoute = Properties.Settings.Default.SERVER_ROUTE;

                NotifyIcon notifyIcon_AlreadyIsUptoDate = new NotifyIcon();
                notifyIcon_AlreadyIsUptoDate.Visible = true;
                notifyIcon_AlreadyIsUptoDate.Icon = SystemIcons.Application;
                notifyIcon_AlreadyIsUptoDate.BalloonTipTitle = "Asiste de Actualizaciones";
                notifyIcon_AlreadyIsUptoDate.BalloonTipText = $"Actualizando el software v{lvlVersionActual.Text} a la ultima version v{lvlVersion.Text}!";


                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadFileCompleted += client_DownloadFileCompleted;

                // DESCARGA LA ULTIMA VERSION PUBLICADA DEL SERVIDOR
                string ruta = Application.StartupPath + @"\RIT_UpdaterUtility.exe";
                ruta_instalador = ruta;

                CommonMethodsLibrary.OutMessage("out", this.Name, $"COMIENZA LA DESCARGA DE LA VERSION: '{UpdaterManager.Update.NewVersion}'", "inf");
                //WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri($@"\\{ServerRoute}\Publico\rit_solver_server\SETUP_UPDATER.exe"), ruta);
            } catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"ERROR INESPERADO EN EL PROCESO DE DESCARGA. EL PROGRAMA DICE: '{ex.ToString()}'", "EXC");

                RJMessageBox.Show(ex.Message, "Gestor de actualizaciones - descarga", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //progressDescarga.IsIndeterminate = false;
            progressDescarga.Value = (int)e.ProgressPercentage;
            this.lblPorcentaje.Text = e.ProgressPercentage.ToString() + "%";
        }

        void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if (!e.Cancelled)
                {
                    DownloadReady = true;
                    //progressDescarga.IsIndeterminate = true;
                    if (DownloadReady == true)
                    {
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"PROCESO DE DESCARGA REALIZADA CON EXITO!", "oka");
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"INICIANDO PROCESO DE INSTALACION!", "INF");
                        CommonMethodsLibrary.OutMessage("out", this.Name, $"EJECUTANDO INSTALADOR '{ruta_instalador}'", "inf");

                        Process.Start(ruta_instalador); // Iniciamos el archivo de instalacion
                    }

                    // -> CERRAMOS LA APLICACION PARA QUE EL INSTALADOR FUNCIONE ADECUADAMENTE
                    CommonMethodsLibrary.OutMessage("out", this.Name, $"CERRANDO LA APLICACION", "INF");

                    Application.Exit();
                }
            } catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"ERROR INESPERADO EN EL PROCESO DE DESCARGA. EL PROGRAMA DICE: '{ex.ToString()}'", "EXC");

                RJMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void actualizador_KeyDown(object sender, KeyEventArgs e)
        {
            /* INGORAR */
        }


        private void actualizador_FormClosing(object sender, FormClosingEventArgs e)
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
