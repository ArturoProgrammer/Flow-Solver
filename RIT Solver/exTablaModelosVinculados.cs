using CefSharp.DevTools.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver
{
    public partial class exTablaModelosVinculados : Form
    {
        public MachineModelSyncItem RESPONSE = new MachineModelSyncItem();
        private MachinesModelsSync modelsVinculated = MachinesModelsSync.Load();

        public exTablaModelosVinculados()
        {
            InitializeComponent();
        }

        private void exTablaModelosVinculados_Load(object sender, EventArgs e)
        {
            this.txtRutaDelArchivo.Text = modelsVinculated.DataBaseFilePath;

            foreach (MachineModelSyncItem m in modelsVinculated.Items)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.NombreComercial;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "subitemNombreClave",
                    Text = $"{m.NombreClave}",
                });

                switch (m.Tipo)
                {
                    case "LAPTOP":
                        item.ImageIndex = 0;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                        break;
                    case "PC":
                        item.ImageIndex = 1;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                        break;
                }
                item.Tag = m;

                this.lviewTablaDeModelosVinculados.Items.Add(item);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Abrimos el modelo vinculado para visualizacion
            if (actualModelSyncSelected != null)
            {
                exViewSyncModel frm = new exViewSyncModel(actualModelSyncSelected, exViewSyncModel.StartOption.READ);
                frm.ShowDialog();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Editamos el modelo vinculado
            if (actualModelSyncSelected != null)
            {
                MachineModelSyncItem previousModel = actualModelSyncSelected;

                exViewSyncModel frm = new exViewSyncModel(actualModelSyncSelected, exViewSyncModel.StartOption.UPDATE);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Encontramos el indice del objeto anterior
                    ListViewItem targetItemToReplace = this.lviewTablaDeModelosVinculados.Items
                        .Cast<ListViewItem>()
                        .Where(g => g.Text.Trim() == previousModel.NombreComercial.Trim())
                        .FirstOrDefault();

                    int _targetIndex = this.lviewTablaDeModelosVinculados.Items.IndexOf(targetItemToReplace);

                    MachineModelSyncItem m = frm.RESPONSE;
                    ListViewItem item = new ListViewItem()
                    {
                        Text = m.NombreComercial,
                        Tag = m,
                    };
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Name = "subitemNombreClave",
                        Text = $"{m.NombreClave}",
                    });

                    switch (m.Tipo)
                    {
                        case "LAPTOP":
                            item.ImageIndex = 0;
                            item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                            break;
                        case "PC":
                            item.ImageIndex = 1;
                            item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                            break;
                    }

                    modelsVinculated.Items.Remove(previousModel);   // Eliminamos el objeto viejo del listado
                    modelsVinculated.Items.Add(m);  // Añadimos al listado del objeto

                    this.lviewTablaDeModelosVinculados.Items.Remove(targetItemToReplace); // Eliminamos el objeto anterior
                    this.lviewTablaDeModelosVinculados.Items.Insert(_targetIndex, item);     // Insertamos el nuevo objeto en el indice indicado
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Añadimos un modelo vinculado nuevo
            exViewSyncModel frm = new exViewSyncModel(exViewSyncModel.StartOption.CREATE);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MachineModelSyncItem m = frm.RESPONSE;
                ListViewItem item = new ListViewItem()
                {
                    Text = m.NombreComercial,
                    Tag = m,
                };
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "subitemNombreClave",
                    Text = $"{m.NombreClave}",
                });

                switch (m.Tipo)
                {
                    case "LAPTOP":
                        item.ImageIndex = 0;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lvgroupLaptops"];
                        break;
                    case "PC":
                        item.ImageIndex = 1;
                        item.Group = this.lviewTablaDeModelosVinculados.Groups["lviewDesktopPCs"];
                        break;
                }

                modelsVinculated.Items.Add(m); // Añadimos al listado del objeto
                this.lviewTablaDeModelosVinculados.Items.Add(item); // Añadimos a la visualizacion
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Eliminamos el modelo vinculado seleccionado
            if (actualModelSyncSelected != null)
            {
                if (MessageBox.Show($"¿Seguro que deseas eliminar la vinculacion de '{actualModelSyncSelected.NombreComercial} -> {actualModelSyncSelected.NombreClave}'?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MachineModelSyncItem previousModel = actualModelSyncSelected;

                    // Encontramos el indice del objeto anterior
                    ListViewItem targetItemToReplace = this.lviewTablaDeModelosVinculados.Items
                        .Cast<ListViewItem>()
                        .Where(g => g.Text.Trim() == previousModel.NombreComercial.Trim())
                        .FirstOrDefault();

                    modelsVinculated.Items.Remove(previousModel);   // Eliminamos el objeto viejo del listado
                    this.lviewTablaDeModelosVinculados.Items.Remove(targetItemToReplace); // Eliminamos el objeto anterior

                    if (this.lviewTablaDeModelosVinculados.Items.Count >= 1)
                    {
                        this.lviewTablaDeModelosVinculados.Items[0].Selected = true;
                    }
                }
            }
        }

        MachineModelSyncItem actualModelSyncSelected = null;
        private void lviewTablaDeModelosVinculados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lviewTablaDeModelosVinculados.SelectedItems.Count == 1)
                {
                    actualModelSyncSelected = (MachineModelSyncItem)this.lviewTablaDeModelosVinculados.SelectedItems[0].Tag;
                }

                if (actualModelSyncSelected != null)
                {
                    this.btnEditarModeloVinculado.Enabled = true;
                    this.btnEliminarModeloVinculado.Enabled = true;
                    this.btnAceptar.Enabled = true;
                }
                else
                {
                    this.btnEditarModeloVinculado.Enabled = false;
                    this.btnEliminarModeloVinculado.Enabled = false;
                    this.btnAceptar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado! {ex.Message}\n\n{ex}", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsAnswered = false;
            this.Close();
        }

        bool IsAnswered = false;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                /* 
                 * ESTABLECEMOS EL VALOR TRUE YA QUE NO HAY PROCESOS DE VALIDACION POR REALIZAR
                 * */
                if (true)
                {
                    // Asignamos el elemento
                    RESPONSE = actualModelSyncSelected;
                    IsAnswered = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                IsAnswered = false;
            }
        }

        private void exTablaModelosVinculados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAnswered)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void toolStrpBtn_AbrirUbicacionDelArchivo_Click(object sender, EventArgs e)
        {
            /* 
             * Abrimos el directorio de la ubicacion mostrada
             * */
            FileInfo fi = new FileInfo(this.txtRutaDelArchivo.Text);

            Process.Start("explorer.exe", fi.DirectoryName);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.btnAceptar.PerformClick();
        }

        private void lviewTablaDeModelosVinculados_DoubleClick(object sender, EventArgs e)
        {
            if (actualModelSyncSelected != null && this.lviewTablaDeModelosVinculados.SelectedItems.Count == 1)
            {
                this.btnVerModeloVinculado.PerformClick();
            }
        }
    }
}
