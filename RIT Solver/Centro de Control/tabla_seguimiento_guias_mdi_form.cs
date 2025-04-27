using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
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

namespace Flow_Solver.Centro_de_Control
{
    public partial class tabla_seguimiento_guias_mdi_form : Form
    {
        main BaseForm;
        TrackWayBillsFile TracksDatas;

        public tabla_seguimiento_guias_mdi_form(main LegacyForm)
        {
            InitializeComponent();

            BaseForm = LegacyForm;

            // Abrimos el archivo de guias si es que existe
            string directoryPath = $@"{Application.StartupPath}\Inventories";
            string filePath = $@"{directoryPath}\WayBillNumbers_TrackFile.{TrackWayBillsFile.extension}";

            if (Directory.Exists(directoryPath))
            {
                if (File.Exists(filePath))
                {
                    TracksDatas = new TrackWayBillsFile(filePath); 
                } else
                {
                    TracksDatas = new TrackWayBillsFile();
                }
            } else
            {
                Directory.CreateDirectory(directoryPath);
                File.Create(filePath);
                TracksDatas = new TrackWayBillsFile();
            }
        }

        private void tabla_seguimiento_guias_mdi_form_Load(object sender, EventArgs e)
        {
            // Cargamos las guias de visualizacion
            try
            {
                foreach (WayBillData m in TracksDatas.WayBills)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = m.Titulo;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Name = "subitemNumeroDeGuia",
                        Text = $"{m.WayBill}"
                    });

                    if (m.Recibida) 
                    {
                        switch (m.Paqueteria)
                        {
                            case Paqueteria.DHL:
                                item.ImageIndex = 4;
                                break;
                            case Paqueteria.FEDEX:
                                item.ImageIndex = 5;
                                break;
                            case Paqueteria.PAQUETEXPRESS:
                                item.ImageIndex = 6;
                                break;
                        }
                        item.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
                    }
                    else
                    {
                        switch (m.Paqueteria)
                        {
                            case Paqueteria.NONE:
                                item.ImageIndex = 0;
                                break;
                            case Paqueteria.DHL:
                                item.ImageIndex = 1;
                                break;
                            case Paqueteria.FEDEX:
                                item.ImageIndex = 2;
                                break;
                            case Paqueteria.PAQUETEXPRESS:
                                item.ImageIndex = 3;
                                break;
                        } 
                    }
                    item.Tag = m;
                    item.ToolTipText = m.Descripcion;

                    this.lviewTablaGuias.Items.Add(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado durante la carga de la visualizacion! {ex.Message}\n{ex}", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        WayBillData actualSelected = null;
        private void lviewTablaDeModelosVinculados_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool aStatus = false;
            bool bStatus = false;   // Status indicador de que el envio esta marcado como recibido


            if (this.lviewTablaGuias.SelectedItems.Count == 1)
            {
                actualSelected = (WayBillData)this.lviewTablaGuias.SelectedItems[0].Tag;

                if (actualSelected.Recibida == false)
                {
                    bStatus = true;
                }
                aStatus = true;
            } else
            {
                actualSelected = null;
            }

            this.btnEliminarModeloVinculado.Enabled = aStatus;
            this.btnVisualizar.Enabled = aStatus;
            this.toolStrpBtnMarcarGuiaActualComoRecibida.Enabled = bStatus;
            this.toolStrpBtnVerMasInformacion.Enabled = aStatus;
        }

        private void btnVerModeloVinculado_Click(object sender, EventArgs e)
        {
            // Abrimos el navegador para visualizar el estado de la guia
            if (actualSelected != null)
            {
                waybill_tracking frm = new waybill_tracking(this, actualSelected.Paqueteria, actualSelected.WayBill);
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                this.PANEL_MDI.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();
            }
        }

        private void toolStrpBtnCerrarVisor_Click(object sender, EventArgs e)
        {
            foreach (Control i in PANEL_MDI.Controls)
            {
                if (i is Form)
                {
                    waybill_tracking frm = (waybill_tracking)i;
                    frm.Close();
                }
            }
        }

        private void toolStrpBtnMarcarGuiaActualComoRecibida_Click(object sender, EventArgs e)
        {
            // Marcamos como recibida la guia
            if (actualSelected != null && MessageBox.Show($"¿Deseas marcar la guia '{actualSelected.WayBill}' - {actualSelected.Titulo} como recibida?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem i in this.lviewTablaGuias.Items)
                {
                    WayBillData obj = (WayBillData)i.Tag;
                    if (obj.WayBill == actualSelected.WayBill)
                    {
                        obj.Recibida = true;
                        i.Tag = obj;
                        i.ForeColor = Color.FromKnownColor(KnownColor.Highlight);

                        switch (obj.Paqueteria)
                        {
                            case Paqueteria.DHL:
                                i.ImageIndex = 4;
                                break;
                            case Paqueteria.FEDEX:
                                i.ImageIndex = 5;
                                break;
                            case Paqueteria.PAQUETEXPRESS:
                                i.ImageIndex = 6;
                                break;
                        }
                        break;
                    }
                }

                // Actualizamos el archivo
                this.toolStrpBtnActualizarArchivo.PerformClick();
            }
        }

        private void btnAñadirModeloVinculado_Click(object sender, EventArgs e)
        {
            exNuevaGuia frm = new exNuevaGuia();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                WayBillData m = frm.RESPONSE;
                ListViewItem item = new ListViewItem();
                item.Text = m.Titulo;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "subitemNumeroDeGuia",
                    Text = $"{m.WayBill}",
                });

                switch (m.Paqueteria)
                {
                    case Paqueteria.NONE:
                        item.ImageIndex = 0;
                        break;
                    case Paqueteria.DHL:
                        item.ImageIndex = 1;
                        break;
                    case Paqueteria.FEDEX:
                        item.ImageIndex = 2;
                        break;
                    case Paqueteria.PAQUETEXPRESS:
                        item.ImageIndex = 3;
                        break;
                }
                item.Tag = m;
                item.ToolTipText = m.Descripcion;

                this.lviewTablaGuias.Items.Add(item);
                this.toolStrpBtnActualizarArchivo.PerformClick();
            }
        }

        private void toolStrpBtnActualizarArchivo_Click(object sender, EventArgs e)
        {
            // Reconstruimos los objetos segun la visualizacion
            List<WayBillData> lst = new List<WayBillData>();

            foreach (ListViewItem i in this.lviewTablaGuias.Items)
            {
                lst.Add((WayBillData)i.Tag);
            }

            TracksDatas.WayBills = lst;

            // Guardamos el objeto
            TracksDatas.Save();
        }

        private void lviewTablaGuias_DoubleClick(object sender, EventArgs e)
        {
            if (actualSelected != null && this.lviewTablaGuias.SelectedItems.Count == 1)
            {
                this.btnVisualizar.PerformClick();
            }
        }

        private void btnEliminarModeloVinculado_Click(object sender, EventArgs e)
        {
            // Marcamos como recibida la guia
            if (actualSelected != null && MessageBox.Show($"¿Seguro que deseas eliminar el tracking de la guia '{actualSelected.WayBill}' - {actualSelected.Titulo}?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem i in this.lviewTablaGuias.Items)
                {
                    WayBillData obj = (WayBillData)i.Tag;
                    if (obj.WayBill == actualSelected.WayBill)
                    {
                        i.Remove();
                        break;
                    }
                }

                // Actualizamos el archivo
                this.toolStrpBtnActualizarArchivo.PerformClick();
            }
        }

        private void toolStrpBtnVerMasInformacion_Click(object sender, EventArgs e)
        {
            if (actualSelected != null)
            {
                exNuevaGuia frm = new exNuevaGuia(actualSelected);
                frm.ShowDialog();
            }
        }

        private void toolStrpBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
