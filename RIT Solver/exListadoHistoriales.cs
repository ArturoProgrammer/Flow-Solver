using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class exListadoHistoriales : Form
    {
        private List<MachineEventsHistorial> Historiales = new List<MachineEventsHistorial>();

        public exListadoHistoriales()
        {
            InitializeComponent();
        }

        void _LoadAllData()
        {
            Historiales.Clear();
            this.lviewHistoriales.Items.Clear();

            // Cargamos los elementos
            string path = $@"{Application.StartupPath}\Inventories";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] historials = di.GetFiles()
                                            .Cast<FileInfo>()
                                            .Where(f => f.Extension == $".{MachineEventsHistorial.FileExtension}")
                                            .ToArray();

            foreach (FileInfo f in historials)
            {
                Historiales.Add(new MachineEventsHistorial(f.FullName));
            }

            // Cargamos la visualizacion
            foreach (MachineEventsHistorial m in Historiales)
            {
                if (!String.IsNullOrEmpty(m.Hostname)) {
                    ListViewItem item = new ListViewItem();
                    item.Text = $"{m.Hostname}";
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = $"Eventos: {m.Events.Count}"
                    });
                    item.ImageIndex = 0;
                    item.Tag = m;

                    this.lviewHistoriales.Items.Add(item);
                }
            }

            this.lblTotal.Text = $"Total de Historiales: {this.lviewHistoriales.Items.Count}";
            _EnableButtons();
        }

        void _EnableButtons()
        {
            bool aStatus = false;
            if (actualSelected != null)
            {
                aStatus = true;
            }

            // Botones del MenuStrip
            this.btnVerHistorial.Enabled = aStatus;
            this.btnEliminarHistorial.Enabled = aStatus;
            this.btnFusionarHistoriales.Enabled = aStatus;
            this.btnExportarHistorial.Enabled = aStatus;
            this.btnEditarHistorial.Enabled = aStatus;
        }

        private void exListadoHistoriales_Load(object sender, EventArgs e)
        {
            _LoadAllData();
        }

        MachineEventsHistorial actualSelected;
        private void lviewHistoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lviewHistoriales.SelectedItems.Count == 1)
            {
                actualSelected = (MachineEventsHistorial)this.lviewHistoriales.SelectedItems[0].Tag;
            } else
            {
                actualSelected = null;
            }

            if (actualSelected != null)
            {
                this.lblHostnameSeleccionado.Text = actualSelected.Hostname;
            } else
            {
                this.lblHostnameSeleccionado.Text = "-";
            }

            _EnableButtons();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (actualSelected != null)
            {
                exHistorialDeCambios frm = new exHistorialDeCambios(actualSelected.FilePath, actualSelected.Hostname);
                frm.ShowDialog();
            }
        }

        private void lviewHistoriales_DoubleClick(object sender, EventArgs e)
        {
            this.btnVerHistorial.PerformClick();
        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que deseas eliminar el Historial de Eventos actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists(actualSelected.FilePath))
                {
                    File.Delete(actualSelected.FilePath);
                    _EnableButtons();
                }
                else
                {
                    MessageBox.Show($"El archivo de historial '{actualSelected.FilePath}' no se encuentra en la ubicacion especificada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarHistorial_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = $@"{Application.StartupPath}\Inventories";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string h_content = File.ReadAllText(actualSelected.FilePath);
                File.WriteAllText(saveFileDialog1.FileName, h_content);
            }
        }

        private void btnEditarHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"No se pueden editar los historiales de eventos de equipos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
