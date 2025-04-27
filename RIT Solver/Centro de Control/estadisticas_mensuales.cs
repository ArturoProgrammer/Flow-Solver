using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver.Centro_de_Control
{
    public partial class estadisticas_mensuales : Form
    {
        private main BaseForm;
        private MensualStadistics historicalData;

        public estadisticas_mensuales(main LegacyForm)
        {
            InitializeComponent();
            BaseForm = LegacyForm;
        }

        Size t_size;

        private void estadisticas_mensuales_Load(object sender, EventArgs e)
        {
            historicalData = MensualStadistics.Get();
            this.txtRutaOrigenDeDatos.Text = historicalData.FilePath;

            _LoadAllData();
            int t_width = (int)(this.lviewRitsComprobados.TileSize.Width + (5));
            t_size = new Size(t_width, this.lviewRitsComprobados.TileSize.Height);

            this.lviewRitsImpresos.TileSize = t_size;
            this.lviewRitsFirmados.TileSize = t_size;
            this.lviewRitsGenerados.TileSize = t_size;
            this.lviewRitsComprobados.TileSize = t_size;
        }

        void _LoadAllData()
        {
            bool aStatus = false;
            historicalData = MensualStadistics.Get();

            if (this.historicalData.Registro.Count == 0)
            {
                aStatus = false;
            }
            else
            {
                this.treeViewHistoricalStadistics.Nodes.Clear();
                this.lviewRitsGenerados.Items.Clear();
                this.lviewRitsFirmados.Items.Clear();
                this.lviewRitsImpresos.Items.Clear();
                this.lviewRitsComprobados.Items.Clear();
                this.rtxtDetallesRitSeleccionado.Text = "";

                foreach (MensualStadistics.AnualData a in historicalData.Registro)
                {
                    foreach (int y in a.YearData.Keys)
                    {
                        int year = y;

                        TreeNode anualTreeNode = new TreeNode()
                        {
                            Text = year.ToString(),
                            ImageIndex = 0,
                            SelectedImageIndex = 0,
                            Name = $"nodeYear_{year}"
                        };

                        foreach (MensualStadistics.MonthlyData m in a.YearData[y])
                        {
                            int imgIndex = ImageOfMonthSelector(m.Mes);
                            TreeNode monthTreeNode = new TreeNode()
                            {
                                Text = m.Mes,
                                ImageIndex = imgIndex,
                                SelectedImageIndex = imgIndex,
                                Tag = m
                            };

                            anualTreeNode.Nodes.Add(monthTreeNode);
                        }

                        this.treeViewHistoricalStadistics.Nodes.Add(anualTreeNode);
                    }
                }

                aStatus = true;

                this.treeViewHistoricalStadistics.Enabled = aStatus;
                try
                {
                    this.treeViewHistoricalStadistics.Nodes[$"nodeYear_{DateTime.Now.ToString("yyyy")}"].Expand();
                } catch { }

                try
                {
                    // Intentamos seleccionar al nodo del mes actual en caso de existir
                    int actualYear = Int32.Parse(DateTime.Now.ToString("yyyy"));
                    string actualMonth = MensualStadistics.CapitalizarPrimeraLetra(DateTime.Now.ToString("MMMM"));

                    TreeNode yearNode = this.treeViewHistoricalStadistics.Nodes
                                            .Cast<TreeNode>()
                                            .Where(t => t.Name == $"nodeYear_{actualYear}")
                                            .FirstOrDefault();

                    if (yearNode != null)
                    {
                        TreeNode month = yearNode.Nodes
                                            .Cast<TreeNode>()
                                            .Where(t => t.Text == actualMonth)
                                            .FirstOrDefault();
                        if (month != null)
                        {
                            this.treeViewHistoricalStadistics.SelectedNode = month;
                        }
                    }
                } catch { }
            }

            this.lviewRitsComprobados.Enabled = aStatus;
            this.lviewRitsImpresos.Enabled = aStatus;
            this.lviewRitsGenerados.Enabled = aStatus;
            this.lviewRitsFirmados.Enabled = aStatus;
        }

        int ImageOfMonthSelector(string month)
        {
            int i = 0;

            switch (month.ToLower())
            {
                case "enero":
                    i = 1;
                    break;
                case "febrero":
                    i = 2;
                    break;
                case "marzo":
                    i = 3;
                    break;
                case "abril":
                    i = 4;
                    break;
                case "mayo":
                    i = 5;
                    break;
                case "junio":
                    i = 6;
                    break;
                case "julio":
                    i = 7;
                    break;
                case "agosto":
                    i = 8;
                    break;
                case "septiembre":
                    i = 9;
                    break;
                case "octubre":
                    i = 10;
                    break;
                case "noviembre":
                    i = 11;
                    break;
                case "diciembre":
                    i = 12;
                    break;
            }

            return i;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        MensualStadistics.MonthlyData actualMonthSelected;
        private void treeViewHistoricalStadistics_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeViewHistoricalStadistics.SelectedNode != null)
            {
                if (this.treeViewHistoricalStadistics.SelectedNode.Parent != null && this.treeViewHistoricalStadistics.SelectedNode.Parent.Name.Contains("nodeYear_"))
                {
                    actualMonthSelected = (MensualStadistics.MonthlyData)this.treeViewHistoricalStadistics.SelectedNode.Tag;
                }
            }
        }

        private void AjustarTileSize(ListView listView)
        {
            int maxWidth = 0;
            int maxHeight = 0;

            using (Graphics g = listView.CreateGraphics())
            {
                foreach (ListViewItem item in listView.Items)
                {
                    // Calcula el ancho del ítem principal
                    SizeF itemSize = g.MeasureString(item.Text, listView.Font);
                    int itemWidth = (int)itemSize.Width;
                    int itemHeight = (int)itemSize.Height;

                    // Calcula el ancho de los subitems
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        SizeF subItemSize = g.MeasureString(subItem.Text, listView.Font);
                        itemWidth = Math.Max(itemWidth, (int)subItemSize.Width);
                        itemHeight += (int)subItemSize.Height;
                    }

                    maxWidth = Math.Max(maxWidth, itemWidth);
                    maxHeight = Math.Max(maxHeight, itemHeight);
                }
            }

            // Establece el nuevo tamaño del mosaico
            listView.TileSize = new Size(maxWidth + 10, maxHeight + 10);
        }


        private void treeViewHistoricalStadistics_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (actualMonthSelected != null)
            {
                #region LIMPIAMOS LAS LISTAS Y LOS CONTROLES DE VISUALIZACION
                this.lviewRitsGenerados.Items.Clear();
                this.lviewRitsFirmados.Items.Clear();
                this.lviewRitsImpresos.Items.Clear();
                this.lviewRitsComprobados.Items.Clear();
                #endregion

                MensualStadistics.MonthlyData m = actualMonthSelected;

                foreach (MensualStadistics.ReportStData i in m.DataReports)
                {
                    // Lo asignamos en el lugar correspondiente
                    if (i.IsPrinted)
                    {
                        #region CODIGO DE GENERACION DEL LISTVIEW
                        ListViewItem item = new ListViewItem();
                        item.Text = i.FallaReportada;
                        item.ImageIndex = 0;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeFolio
                        });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeReporte
                        });
                        item.Tag = i;
                        #endregion

                        this.lviewRitsImpresos.Items.Add(item);
                    }
                    if (i.IsSigned)
                    {
                        #region CODIGO DE GENERACION DEL LISTVIEW
                        ListViewItem item = new ListViewItem();
                        item.Text = i.FallaReportada;
                        item.ImageIndex = 1;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeFolio
                        });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeReporte
                        });
                        item.Tag = i;
                        #endregion

                        this.lviewRitsFirmados.Items.Add(item);
                    }
                    if (i.IsGenerated)
                    {
                        #region CODIGO DE GENERACION DEL LISTVIEW
                        ListViewItem item = new ListViewItem();
                        item.Text = i.FallaReportada;
                        item.ImageIndex = 3;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeFolio
                        });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeReporte
                        });
                        item.Tag = i;
                        #endregion

                        this.lviewRitsGenerados.Items.Add(item);
                    }
                    if (i.IsProved)
                    {
                        #region CODIGO DE GENERACION DEL LISTVIEW
                        ListViewItem item = new ListViewItem();
                        item.Text = i.FallaReportada;
                        item.ImageIndex = 2;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeFolio
                        });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = i.NoDeReporte
                        });
                        item.Tag = i;
                        #endregion

                        this.lviewRitsComprobados.Items.Add(item);
                    }
                }

                int rits_impresos = this.lviewRitsImpresos.Items.Count;

                this.lblTotalImpresos.Text = $"Total: {rits_impresos}";
                this.lblTotalFirmados.Text = $"({this.lviewRitsFirmados.Items.Count} / {rits_impresos})";
                this.lblTotalGenerados.Text = $"({this.lviewRitsGenerados.Items.Count} / {rits_impresos})";
                this.lblTotalComprobados.Text = $"({this.lviewRitsComprobados.Items.Count} / {rits_impresos})";
            }
        }

        private void btnRecargarOrigenDeDatos_Click(object sender, EventArgs e)
        {
            /* 
             * Recargamos el archivo de datos
             * */
            _LoadAllData();
        }

        string BoolToText(bool status)
        {
            string r;

            if (status)
            {
                r = "Si";
            } else
            {
                r = "No";
            }

            return r;
        }

        private void lviewSelected_DoubleClick(object sender, EventArgs e)
        {
            if (actualReportStDataSelected != null)
            {
                this.rtxtDetallesRitSeleccionado.Text = $@"El Reporte del No. de Folio <'{actualReportStDataSelected.NoDeFolio}'> perteneciente al No. de Reporte en SAS <'{actualReportStDataSelected.NoDeReporte}'> para la Falla Reportada <'{actualReportStDataSelected.FallaReportada}'> tiene las siguientes propiedades:

        - Reporte Impreso: {BoolToText(actualReportStDataSelected.IsPrinted)}                               - Reporte Firmado: {BoolToText(actualReportStDataSelected.IsSigned)}
        - Reporte Generado en SAS: {BoolToText(actualReportStDataSelected.IsGenerated)}               - Reporte Comprobado: {BoolToText(actualReportStDataSelected.IsProved)}
";
            } else
            {
                this.rtxtDetallesRitSeleccionado.Text = "";
            }
        }

        /// <summary>
        /// Reporte de datos Estadisticos actualmente seleccionado
        /// </summary>
        MensualStadistics.ReportStData actualReportStDataSelected;
        private void lviewSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lview = sender as ListView;

            if (lview.SelectedItems != null && lview.SelectedItems.Count == 1)
            {
                actualReportStDataSelected = (MensualStadistics.ReportStData)lview.SelectedItems[0].Tag;
            } else
            {
                actualReportStDataSelected = null;
                this.rtxtDetallesRitSeleccionado.Text = "";
            }
        }
    }
}
