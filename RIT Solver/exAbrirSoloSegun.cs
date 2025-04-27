using DocumentFormat.OpenXml.Office2016.Drawing.Charts;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Converters;

namespace Flow_Solver
{
    public partial class exAbrirSoloSegun : Form
    {
        /// <summary>
        /// Lista virtual desde la que se obtienen y clasifican los elementos de visualizacion
        /// </summary>
        private List<RitJsonProject> _virtualList = new List<RitJsonProject>();
        /// <summary>
        /// Listado de los paths de los proyectos seleccionados
        /// </summary>
        public List<RitJsonProject> Response = new List<RitJsonProject>();

        public exAbrirSoloSegun()
        {
            InitializeComponent();
        }

        private void toolStrpBtn_Examinar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fBrowser = new FolderBrowserDialog())
            {
                if (fBrowser.ShowDialog() == DialogResult.OK)
                {
                    this.txtRutaDirectorio.Text = fBrowser.SelectedPath;
                    _LoadAllData();
                }
            }
        }

        private void exAbrirSoloSegun_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isAccepted)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        bool isAccepted = false;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isAccepted = false;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool canContinue = false; 

            if (this.chckboxCargarSinPreguntar.Checked)
            {
                canContinue = true;
            } else
            {
                if (MessageBox.Show($"¿Seguro que deseas cargar la seleccion realizada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    canContinue = true;
                }
            }

            if (canContinue)
            {
                RitJsonProject[] l_array = this.lviewTablaDeProyectos.Items
                                            .Cast<ListViewItem>()
                                            .Where(i => i.Checked == true)
                                            .Select(i => (RitJsonProject)i.Tag)
                                            .ToArray();
                Response = l_array.ToList();

                isAccepted = true;
                this.Close();
            }
        }

        private void exAbrirSoloSegun_Load(object sender, EventArgs e)
        {
            string route = $@"{Properties.Settings.Default.RITFormPathDestiny}\RITs\{DateTime.Now.ToString("yyyy")}";
            if (!Directory.Exists(route))
            {
                Directory.CreateDirectory(route);
            }

            string path = $@"{route}\{DateTime.Now.ToString("MMMM")}";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            this.txtRutaDirectorio.Text = path;

            _LoadAllData();
        }

        void _LoadAllData()
        {
            this.toolStrpBtn_AbrirUbicacionDelArchivo.Enabled = true;
            Response.Clear();
            _virtualList.Clear();

            #region CARGAMOS LOS PROYECTOS DEL DIRECTORIO SELECCIONADO
            DirectoryInfo di = new DirectoryInfo(this.txtRutaDirectorio.Text);
            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Extension == $".{RitJsonProject.FileExtension}")
                {
                    _virtualList.Add(RitJsonProject.LoadProject(fi.FullName));
                }
            }

            _UpdateViewItemsByParams();

            bool aStatus = false;
            if (_virtualList.Count > 0)
            {
                aStatus = true;
            }

            this.toogle_VerTodos.Enabled = aStatus;
            this.toogle_VerGeneradosEnSAS.Enabled = aStatus;
            this.toogle_VerImpresos.Enabled = aStatus;
            this.toogle_VerFirmados.Enabled = aStatus;
            this.toogle_VerComprobados.Enabled = aStatus;
            #endregion
        }

        void _UpdateViewItemsByParams()
        {
            this.chckboxSeleccionarTodos.Checked = false;

            List<RitJsonProject> _filterList = new List<RitJsonProject>();

            #region METODO Y PROCESO DE FILTRADO DE DATOS
            if (toogle_VerTodos.Checked)
            {
                // Clasificamos para todos
                _filterList = _virtualList;
            } else
            {
                List<RitJsonProject> elementosPreFiltrados = _virtualList;

                if (this.toogle_VerGeneradosEnSAS.Checked)
                {
                    List<RitJsonProject> PRE_DEAD = new List<RitJsonProject>();
                    foreach (RitJsonProject i in elementosPreFiltrados)
                    {
                        if (!i.IsAlreadyTicketGenerated)
                        {
                            PRE_DEAD.Add(i);
                        }
                    }

                    elementosPreFiltrados = PRE_DEAD;
                }

                if (this.toogle_VerImpresos.Checked)
                {
                    List<RitJsonProject> PRE_DEAD = new List<RitJsonProject>();
                    foreach (RitJsonProject i in elementosPreFiltrados)
                    {
                        if (!i.IsRitAlreadyPrinted)
                        {
                            PRE_DEAD.Add(i);
                        }
                    }
                    elementosPreFiltrados = PRE_DEAD;
                }

                if (this.toogle_VerFirmados.Checked)
                {
                    List<RitJsonProject> PRE_DEAD = new List<RitJsonProject>();
                    foreach (RitJsonProject i in elementosPreFiltrados)
                    {
                        if (!i.IsRitAlreadySigned)
                        {
                            PRE_DEAD.Add(i);
                        }
                    }
                    elementosPreFiltrados = PRE_DEAD;
                }

                if (this.toogle_VerComprobados.Checked)
                {
                    List<RitJsonProject> PRE_DEAD = new List<RitJsonProject>();
                    foreach (RitJsonProject i in elementosPreFiltrados)
                    {
                        if (!i.IsRitAlreadyComprobado)
                        {
                            PRE_DEAD.Add(i);
                        }
                    }
                    elementosPreFiltrados = PRE_DEAD;
                }


                _filterList = elementosPreFiltrados;
            }
            #endregion

            #region CARGA DE VISUALIZACION DE DATOS
            this.lviewTablaDeProyectos.Items.Clear();
            foreach (RitJsonProject u in _filterList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = u.NombreProyecto;
                item.ImageIndex = 0;
                item.StateImageIndex = 0;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.Falla
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.FechaDeGeneracionReporte.ToString("d")
                }); 
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.IsAlreadyTicketGenerated.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.IsRitAlreadyPrinted.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.IsRitAlreadySigned.ToString()
                }); 
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = u.IsRitAlreadyComprobado.ToString()
                });
                item.Tag = u;

                this.lviewTablaDeProyectos.Items.Add(item);
            }
            this.lblCoincidencias.Text = $"({_filterList.Count}/{_virtualList.Count})";
            #endregion
        }

        void _EnableTodosButton()
        {
            bool aStatus = true;
            bool bStatus = false;
            if (!this.toogle_VerGeneradosEnSAS.Checked && !this.toogle_VerImpresos.Checked && !this.toogle_VerFirmados.Checked && !this.toogle_VerComprobados.Checked)
            {
                aStatus = false;
                this.toogle_VerGeneradosEnSAS.Checked = false;
                this.toogle_VerImpresos.Checked = false;
                this.toogle_VerFirmados.Checked = false;
                this.toogle_VerComprobados.Checked = false;

                bStatus = true;
            }

            this.toogle_VerGeneradosEnSAS.Enabled = aStatus;
            this.toogle_VerImpresos.Enabled = aStatus;
            this.toogle_VerFirmados.Enabled = aStatus;
            this.toogle_VerComprobados.Enabled = aStatus;

            this.toogle_VerTodos.Enabled = bStatus;
            this.toogle_VerTodos.Checked = bStatus;
        }

        private void toogle_VerTodos_CheckedChanged(object sender, EventArgs e)
        {
            bool aStatus = true;
            if (this.toogle_VerTodos.Checked)
            {
                aStatus = false;
                this.toogle_VerGeneradosEnSAS.Checked = false;
                this.toogle_VerImpresos.Checked = false;
                this.toogle_VerFirmados.Checked = false;
                this.toogle_VerComprobados.Checked = false;
            } else
            {
                this.toogle_VerTodos.Enabled = false;
            }

            this.toogle_VerGeneradosEnSAS.Enabled = aStatus;
            this.toogle_VerImpresos.Enabled = aStatus;
            this.toogle_VerFirmados.Enabled = aStatus;
            this.toogle_VerComprobados.Enabled = aStatus;
            
            _UpdateViewItemsByParams();
        }

        private void toogle_VerGeneradosEnSAS_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateViewItemsByParams();
            _EnableTodosButton();
        }

        private void toogle_VerImpresos_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateViewItemsByParams();
            _EnableTodosButton();
        }

        private void toogle_VerFirmados_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateViewItemsByParams();
            _EnableTodosButton();
        }

        private void toogle_VerComprobados_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateViewItemsByParams();
            _EnableTodosButton();
        }


        void _ValidateAcceptButtonEnable ()
        {
            ListViewItem[] l_array = this.lviewTablaDeProyectos.Items
                                            .Cast<ListViewItem>()
                                            .Where(i => i.Checked == true)
                                            .ToArray();

            if (l_array.Length == 0)
            {
                this.btnAceptar.Enabled = false;
            } else
            {
                this.btnAceptar.Enabled = true;
            }
        }

        int _CountSelection()
        {
            int total = 0;

            total = this.lviewTablaDeProyectos.Items
                                            .Cast<ListViewItem>()
                                            .Where(i => i.Checked == true)
                                            .Count();

            return total;
        }

        private void lviewTablaDeProyectos_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Activamos la validacion del boton aceptar segun la candiad de elementos activados
            _ValidateAcceptButtonEnable();
            this.lblTotalSeleccionado.Text = _CountSelection().ToString();
        }

        private void lviewTablaDeProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toogle_VerGeneradosEnSAS_Click(object sender, EventArgs e)
        {

        }

        private void chckboxSeleccionarTodos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in this.lviewTablaDeProyectos.Items)
            {
                i.Checked = this.chckboxSeleccionarTodos.Checked;
            }
        }
    }
}
