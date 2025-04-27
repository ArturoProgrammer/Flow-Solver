using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class tabla_historiales : Form
    {
        public tabla_historiales()
        {
            InitializeComponent();
        }

        private void tabla_historiales_Load(object sender, EventArgs e)
        {
            _LoadAllData();
        }

        void _LoadAllData()
        {
            this.lviewTablaDeHistoriales.Items.Clear();

            string TARGET_DIR = $@"{Application.StartupPath}\Inventories";

            if (Directory.Exists(TARGET_DIR))
            {
                DirectoryInfo di = new DirectoryInfo(TARGET_DIR);
                foreach (FileInfo file in di.GetFiles())
                {
                    if (file.Extension == $".{MachineEventsHistorial.FileExtension}")
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = file.Name.Replace(MachineEventsHistorial.FileSuffix, "");
                        item.Tag = file.FullName;
                        item.ImageIndex = 0;
                        item.StateImageIndex = 0;

                        this.lviewTablaDeHistoriales.Items.Add(item);
                    }
                }
            }

            int loadedItems = this.lviewTablaDeHistoriales.Items.Count;
            this.jobStatus.Text = $"Se cargaron {loadedItems} registros de Historiales con exito!";
        }

        string actualSelectedPath = "";
        
        private void lviewTablaDeHistoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool aStatus = false;

            if (this.lviewTablaDeHistoriales.SelectedItems.Count == 1)
            {
                actualSelectedPath = this.lviewTablaDeHistoriales.SelectedItems[0].Tag.ToString();
                aStatus = true;
            }

            this.toolStrpBtnVisualizar.Enabled = aStatus;
            this.toolStrpBtnEliminar.Enabled = aStatus;
        }

        private void lviewTablaDeHistoriales_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(actualSelectedPath) && File.Exists(actualSelectedPath))
            {
                exHistorialDeCambios frm = new exHistorialDeCambios(actualSelectedPath, this.lviewTablaDeHistoriales.SelectedItems[0].Text);
                frm.ShowDialog();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _LoadAllData();
        }
    }
}
