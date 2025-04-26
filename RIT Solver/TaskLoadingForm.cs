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

namespace RIT_Solver
{
    public partial class TaskLoadingForm : Form
    {
        internal bool ConfirmToClose;

        #region Sobrecargas para la inicializacion

        // Exportacion de configuracion (Backup)
        internal respaldo_de_programa padre_backup;
        internal BackupConfiguration BU_CONFIG;
        public TaskLoadingForm (respaldo_de_programa LegacyForm, string Caption, string ActionTitle, bool AskToClose, BackupConfiguration Configuration)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption + " Esta ventana se cerrara en automatico al terminar.";
            padre_backup = LegacyForm;
            BU_CONFIG = Configuration;
            ConfirmToClose = AskToClose;
        }


        // Espera de apertura de formularios en inventarios
        internal inventarios padre_invent;
        public TaskLoadingForm (inventarios LegacyForm, string Caption, string ActionTitle, bool AskToClose)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption;
            padre_invent = LegacyForm;
            ConfirmToClose = AskToClose;
        }

        // Espera de carga del form añadir_equipo
        internal añadir_equipo padre_añadir_equipo;
        public TaskLoadingForm (añadir_equipo LegacyForm, string Caption, string ActionTitle, bool AskToClose)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption;
            padre_añadir_equipo = LegacyForm;
            ConfirmToClose = AskToClose;
        }

        // Espera de carga del form lista_usuarios
        internal lista_usuarios padre_lista_usuarios;
        public TaskLoadingForm (lista_usuarios LegacyForm, string Caption, string ActionTitle, bool AskToClose)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption;
            padre_lista_usuarios = LegacyForm;
            ConfirmToClose = AskToClose;
        }

        // Esperamos a la carga de cualquier form invocado de main
        internal main padre_main;
        public TaskLoadingForm (main LegacyForm, string Caption, string ActionTitle, bool AskToClose)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption;
            padre_main = LegacyForm;
            ConfirmToClose = AskToClose;
        }

        // Esperamos a la carga de cualquier form invocado de main
        internal rit_mdi_form padre_rit_mdi_form;
        public TaskLoadingForm(rit_mdi_form LegacyForm, string Caption, string ActionTitle, bool AskToClose)
        {
            InitializeComponent();

            this.lblTitle.Text = ActionTitle;
            this.lblCaption.Text = Caption;
            padre_rit_mdi_form = LegacyForm;
            ConfirmToClose = AskToClose;
        }
        #endregion



        private void TaskLoadingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TaskLoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfirmToClose)
            {
                if (RJMessageBox.Show("¿Seguro que deseas cancelar esta accion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Cerramos el form
                    e.Cancel = false;
                }
                else
                {
                    // Seguimos en el form
                    e.Cancel = true;
                }
            } else
            {
                e.Cancel = false; // Cerramos directamente
            }
        }

        private void TaskLoadingForm_Shown(object sender, EventArgs e)
        {
            this.backgroundWorker_JobsToDo.RunWorkerAsync();
        }

        private void backgroundWorker_JobsToDo_DoWork(object sender, DoWorkEventArgs e)
        {
            // Creamos las ordenes de accion segun el constructor
            if (padre_backup != null)
            {
                #region CREAMOS EL BACKUP PARA EXPORTAR
                #region Datos de inventarios
                if (BU_CONFIG.MachinesInventory_Make)
                {
                    MessageBox.Show("equipos");
                }
                if (BU_CONFIG.PrintersInventory_Make)
                {
                    MessageBox.Show("impresoras");
                }
                if (BU_CONFIG.TonersInventory_Make)
                {
                    MessageBox.Show("toners");
                }
                if (BU_CONFIG.SparePartsInventory_Make)
                {
                    MessageBox.Show("refacciones");
                }
                if (BU_CONFIG.CurrentsEmailDirections_Make)
                {
                    MessageBox.Show("direcciones recurrentes");
                }
                if (BU_CONFIG.SaveLocations_Make)
                {
                    MessageBox.Show("localidades guardadas");
                }
                if (BU_CONFIG.UsersInventory_Make)
                {
                    MessageBox.Show("usuarios");
                }
                #endregion

                #region Datos de configuracion del usuario
                if (BU_CONFIG.EmailIDC_Save)
                {
                    MessageBox.Show("se guardara " + "email de idc");
                }
                if (BU_CONFIG.PasswordRED_Save)
                {
                    MessageBox.Show("se guardara " + "contraseña de red");

                }
                if (BU_CONFIG.NameIDC_Save)
                {
                    MessageBox.Show("se guardara " + "nombre del idc");

                }
                if (BU_CONFIG.LocationIDC_Save)
                {
                    MessageBox.Show("se guardara " + "localidad del idc");

                }
                if (BU_CONFIG.ProjectIDC_Save)
                {
                    MessageBox.Show("se guardara " + "proyecto actual del idc");

                }
                if (BU_CONFIG.Client_Save)
                {
                    MessageBox.Show("se guardara " + "cliente actual");

                }
                if (BU_CONFIG.DefaultLocationDirection_Save)
                {
                    MessageBox.Show("se guardara " + "direccion de la localidad del idc");

                }
                if (BU_CONFIG.CenterOfServiceIDCDefault_Save)
                {
                    MessageBox.Show("se guardara " + "centro de servicios del idc");

                }
                if (BU_CONFIG.EmailSupportLeader_Save)
                {
                    MessageBox.Show("se guardara " + "email del lider de proyecto");

                }
                if (BU_CONFIG.NameSupportLeader_Save)
                {
                    MessageBox.Show("se guardara " + "nombre del lider de proyecto");

                }
                if (BU_CONFIG.RedUserIDC_Save)
                {
                    MessageBox.Show("se guardara " + "usuario de red del idc");

                }
                if (BU_CONFIG.EmailTonerDistrib_Save)
                {
                    MessageBox.Show("se guardara " + "email del proveedor de toner");

                }
                if (BU_CONFIG.ThemeSelection_Save)
                {
                    MessageBox.Show("se guardara " + "tema seleccionado");

                }
                if (BU_CONFIG.UpdatesDetection_Save)
                {
                    MessageBox.Show("se guardara " + "detecciones de actualizaciones automaticas");

                }
                if (BU_CONFIG.BETAUpdatesDetection_Save)
                {
                    MessageBox.Show("se guardara " + "deteccion de actualizaciones beta auto");

                }
                if (BU_CONFIG.ResguardPDFMake_Save)
                {
                    MessageBox.Show("se guardara " + "crear pdf de los resguardos");

                }
                if (BU_CONFIG.OpenInventoryOnMaximize_Save)
                {
                    MessageBox.Show("se guardara " + "abrir inventario siempre maximizado");

                }
                if (BU_CONFIG.ActualRITCounter_Save)
                {
                    MessageBox.Show("se guardara " + "contador actual del rit");

                }
                if (BU_CONFIG.MakeEmptyProjectOnOpen_Save)
                {
                    MessageBox.Show("se guardara " + "crear proyecto en blanco al abrir");

                }
                if (BU_CONFIG.DefaultLocationSelected_Save)
                {
                    MessageBox.Show("se guardara " + "localidad default seleccionado");

                }
                #endregion
                #endregion

            }
            else if (padre_invent != null)
            {
                #region FUNCION DE CODIGO PARA SOBRECARGA DE ESPERA A LA APERTURA DE FORMULARIO EN MAIN

                #endregion
            }
        }

        private void backgroundWorker_JobsToDo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (padre_backup != null)
            {
                MessageBox.Show("Ha terminado el proceso de respaldo con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ConfirmToClose = false;
            this.Close();
        }
    }
}
