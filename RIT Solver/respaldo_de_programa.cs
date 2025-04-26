using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver
{
    public partial class respaldo_de_programa : Form
    {
        public respaldo_de_programa()
        {
            InitializeComponent();

            this.lblDescripcionInventarios.Text = "";

        }

        private void btnDirectorioDeSalida_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtDirectorioDeSalida.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void checkedListBox_Inventarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.checkedListBox_Inventarios.SelectedItem.ToString())
            {
                case "Equipos de computo":
                    this.lblDescripcionInventarios.Text = "Computadoras, laptops, ups y cualquier equipo de hardware registrados.";
                    break;
                case "Impresoras":
                    this.lblDescripcionInventarios.Text = "Impresoras rentadas registradas en el inventario.";
                    break;
                case "Toners":
                    this.lblDescripcionInventarios.Text = "Toners inventariados.";
                    break;
                case "Refacciones":
                    this.lblDescripcionInventarios.Text = "Refacciones de stock guardadas en nuestro inventario.";
                    break;
                case "Direcciones de Correo":
                    this.lblDescripcionInventarios.Text = "Direcciones de correo recurrentes guardadas.";
                    break;
                case "Localidades guardadas":
                   this.lblDescripcionInventarios.Text = "Direcciones de localidades recurrentes guardadas.";
                    break;
                case "Inventario de usuarios":
                    this.lblDescripcionInventarios.Text = "Inventario del sistema de usuarios que contiene todas las tarjetas de informacion de cada usuario.";
                    break;
            }

        }

        
        private void btnExportarBackup_Click(object sender, EventArgs e)
        {
            /* Procesos para la creacion del backup */
            BackupConfiguration Configuration = new BackupConfiguration();

            // 1.- Se crea el objeto de configuracion
            #region REGISTRAMOS LOS CAMBIOS DE ITEMS CHEQUEADOS

            // Elementos de los inventarios
            foreach (object item in this.checkedListBox_Inventarios.CheckedItems)
            {
                switch (item.ToString().ToLower())
                {
                    case "equipos de computo":
                        Configuration.MachinesInventory_Make = true;
                        break;
                    case "impresoras":
                        Configuration.PrintersInventory_Make = true;
                        break;
                    case "toners":
                        Configuration.TonersInventory_Make = true;
                        break;
                    case "refacciones":
                        Configuration.SparePartsInventory_Make= true;
                        break;
                    case "direcciones de correo":
                        Configuration.CurrentsEmailDirections_Make = true;
                        break;
                    case "localidades guardadas":
                        Configuration.SaveLocations_Make = true;
                        break;
                    case "inventario de usuarios":
                        Configuration.UsersInventory_Make = true;
                        break;
                }
            }

            // Elementos de configuracion
            foreach (object item in this.checkedListBox_Config1.CheckedItems)
            {
                switch (item.ToString().ToLower())
                {
                    case "email del idc":
                        Configuration.EmailIDC_Save = true;
                        break;
                    case "password de red":
                        Configuration.PasswordRED_Save = true;
                        break;
                    case "nombre del idc":
                        Configuration.NameIDC_Save = true;
                        break;
                    case "localidad del idc":
                        Configuration.LocationIDC_Save = true;
                        break;
                    case "proyecto del idc":
                        Configuration.ProjectIDC_Save = true;
                        break;
                    case "cliente":
                        Configuration.Client_Save = true;
                        break;
                    case "direccion de la localidad default":
                        Configuration.DefaultLocationDirection_Save = true;
                        break;
                    case "centro de servicios de localidad default":
                        Configuration.CenterOfServiceIDCDefault_Save = true;
                        break;
                    case "email de lider de soporte":
                        Configuration.EmailSupportLeader_Save = true;
                        break;
                    case "nombre del lider de proyecto":
                        Configuration.NameSupportLeader_Save = true;
                        break;
                    case "usuario de red del idc":
                        Configuration.RedUserIDC_Save = true;
                        break;
                    case "email de distribuidor de toner":
                        Configuration.EmailTonerDistrib_Save = true;
                        break;
                    case "tema actual seleccionado":
                        Configuration.ThemeSelection_Save = true;
                        break;
                    case "deteccion de actualizaciones automaticas":
                        Configuration.UpdatesDetection_Save = true;
                        break;
                    case "deteccion de actualizaciones beta":
                        Configuration.BETAUpdatesDetection_Save = true;
                        break;
                    case "guardar pdf de resguardo":
                        Configuration.ResguardPDFMake_Save = true;
                        break;
                    case "abrir inventario siempre maximizado":
                        Configuration.OpenInventoryOnMaximize_Save = true;
                        break;
                    case "contador de rit actual":
                        Configuration.ActualRITCounter_Save = true;
                        break;
                    case "crear proyecto en blanco siempre al abrir":
                        Configuration.MakeEmptyProjectOnOpen_Save = true;
                        break;
                    case "localidad default":
                        Configuration.DefaultLocationSelected_Save = true;
                        break;
                }
            }
            #endregion

            // 2.- Se ejecuta funcion
            TaskLoadingForm frm = new TaskLoadingForm(this, "Respaldando los inventarios y configuracion del programa. Esta accion puede demorar.", "Exportando Configuracion", true, Configuration);
            frm.ShowDialog();
        }

        private void respaldo_de_programa_Load(object sender, EventArgs e)
        {
            #region CHEQUEAMOS TODOS LOS VALORES EN AUTOMATICO
            // Lista de inventarios
            for (int i = 0; i < checkedListBox_Inventarios.Items.Count; i++)
            {
                checkedListBox_Inventarios.SetItemChecked(i, true);
            }
            // Lista de Configuraacion 1
            for (int i = 0; i < checkedListBox_Config1.Items.Count; i++)
            {
                checkedListBox_Config1.SetItemChecked(i, true);
            }
            // Lista de Configuracion 2
            for (int i = 0; i < checkedListBox_Config2.Items.Count; i++)
            {
                checkedListBox_Config2.SetItemChecked(i, true);
            }
            #endregion

            this.checkedListBox_Inventarios.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
