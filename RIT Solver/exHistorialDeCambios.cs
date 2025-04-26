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
using System.Runtime.CompilerServices;
using CefSharp.DevTools.Target;

namespace RIT_Solver
{
    public partial class exHistorialDeCambios : Form
    {
        private string HOSTNAME;
        private MachineEventsHistorial Historial;
        bool haveToClose = false;

        public exHistorialDeCambios(InventarioViewModel _selectedMachine)
        {
            InitializeComponent();

            string targetDirectory = $@"{Application.StartupPath}\Inventories";
            string targetPath = $@"{targetDirectory}\{_selectedMachine.HOSTNAME}{MachineEventsHistorial.FileSuffix}";

            try
            {
                if (Directory.Exists(targetDirectory) && File.Exists(targetPath))
                {
                    Historial = new MachineEventsHistorial(targetPath);
                    //MessageBox.Show("si existe el archivo");

                    _LoadVisualizationData();   
                }
                else
                {
                    //this.Close();
                    MessageBox.Show("El archivo del registro de historial solicitado no existe!", "Historial de Eventos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    haveToClose = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HOSTNAME = _selectedMachine.HOSTNAME;

            // VALORES INICIALES PARA LA INTERFAZ
            this.lblTitulo.Text = "";
            this.rtxtMensaje.Text = "";
            this.lblHASH.Text = "";
            this.lblCreacion.Text = "";
        }

        public exHistorialDeCambios(string _HistorialPath, string _Hostname)
        {
            InitializeComponent();

            try
            {
                Historial = new MachineEventsHistorial(_HistorialPath);
                //MessageBox.Show("si existe el archivo");

                _LoadVisualizationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HOSTNAME = _Hostname;

            // VALORES INICIALES PARA LA INTERFAZ
            this.lblTitulo.Text = "";
            this.rtxtMensaje.Text = "";
            this.lblHASH.Text = "";
            this.lblCreacion.Text = "";
        }

        void _LoadVisualizationData()
        {
            #region CARGAMOS LOS VALORES DE VISUALIZACION
            foreach (M_EventItem ev in Historial.Events)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ev.Title;
                item.ImageIndex = 0;
                item.StateImageIndex = 0;
                item.Tag = ev;
                item.Group = this.lviewHistorialDeEventos.Groups.Cast<ListViewGroup>().FirstOrDefault();

                this.lviewHistorialDeEventos.Items.Add(item);
            }
            #endregion
        }

        private void exHistorialDeCambios_Load(object sender, EventArgs e)
        {
            this.Text = $"Historial de Cambios - {HOSTNAME}";

            if (haveToClose)
            {
                this.Close();
            }
        }

        M_EventItem actualEventSelected = null;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lviewHistorialDeEventos.SelectedItems.Count == 1)
                {
                    actualEventSelected = (M_EventItem)this.lviewHistorialDeEventos.SelectedItems[0].Tag;
                }

                if (actualEventSelected != null)
                {
                    // MOSTRAMOS LOS DATOS EN PANTALLA
                    this.lblTitulo.Text = actualEventSelected.Title;
                    this.rtxtMensaje.Text = actualEventSelected.Message;
                    this.lblHASH.Text = actualEventSelected.HASH.ToString();
                    this.lblCreacion.Text = actualEventSelected.CreationDate.ToString("f");
                } else
                {
                    this.lblTitulo.Text = "";
                    this.rtxtMensaje.Text = "";
                    this.lblHASH.Text = "";
                    this.lblCreacion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado! {ex.Message}\n\n{ex}", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFusionarHistoriales_Click(object sender, EventArgs e)
        {
            /* 
             * Combinamos dos historiales en uno
             * */
            openFileDialog_Historial.InitialDirectory = $@"{Application.StartupPath}\Inventories";

            if (openFileDialog_Historial.ShowDialog() == DialogResult.OK)
            {
                string EXTRA_1 = "";

                foreach (string p in openFileDialog_Historial.FileNames)
                {
                    FileInfo fi = new FileInfo(p);
                    EXTRA_1 += $"* {fi.Name}\n";
                }

                FileInfo fi_actual = new FileInfo(Historial.FilePath);
                if (MessageBox.Show($"¿Estas seguro que deseas fusionar el Historial de Eventos '{fi_actual.Name}' con los siguientes historiales?\n\n{EXTRA_1}\nConsidera que estos archivos seran eliminados una vez fusionados. Si aun los deseas conservar, exportalos antes de fusionar.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Historial.MergeHistorials(openFileDialog_Historial.FileNames);

                    _LoadVisualizationData();
                }
            }
        }

        private void btnExportarHistorial_Click(object sender, EventArgs e)
        {
            saveFileDialog_Historial.InitialDirectory = $@"{Application.StartupPath}\Inventories";

            if (saveFileDialog_Historial.ShowDialog() == DialogResult.OK)
            {
                string h_content = File.ReadAllText(Historial.FilePath);
                File.WriteAllText(saveFileDialog_Historial.FileName, h_content);
            }
        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que deseas eliminar el Historial de Eventos actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists(Historial.FilePath))
                {
                    File.Delete(Historial.FilePath);
                    this.Close();
                } else
                {
                    MessageBox.Show($"El archivo de historial '{Historial.FilePath}' no se encuentra en la ubicacion especificada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.btnEliminarHistorial.Enabled = false;
                }
            }
        }
    }
}
