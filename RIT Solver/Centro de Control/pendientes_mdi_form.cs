using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Windows.ApplicationModel;

namespace RIT_Solver.Centro_de_Control
{
    public partial class pendientes_mdi_form : Form
    {
        private main BaseForm;
        public ToDoList actualList;

        public pendientes_mdi_form(main LegacyForm)
        {
            InitializeComponent();

            BaseForm = LegacyForm;
            actualList = new ToDoList();
        }

        public pendientes_mdi_form(main LegacyForm, string _commonParam, string Title)
        {
            InitializeComponent();

            BaseForm = LegacyForm;
            actualList = new ToDoList();
            actualList.Title = Title;
            this.lblHASH.Text = actualList.HASH.ToString();
        }

        public pendientes_mdi_form(main LegacyForm, string _Path)
        {
            InitializeComponent();

            BaseForm = LegacyForm;
            actualList = ToDoList.BuildObject(_Path);

            this.Text = actualList.Title;
            this.lblHASH.Text = actualList.HASH.ToString();
            LoadVisualizationItems();
        }

        void LoadVisualizationItems()
        {
            foreach (ToDoListItem i in actualList.Items)
            {
                ListViewItem item = new ListViewItem();

                item.Text = i.ID.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = i.Title
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = i.Message
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = i.Notes
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = i.Finished.ToString()
                });

                if (i.Finished)
                {
                    item.ImageIndex = 0;
                }

                this.lviewPendientes.Items.Add(item);
            }
        }

        public void WriteStatus(string message, bool status)
        {
            this.lblJobStatus.Text = message;

            if (status)
            {
                this.lblJobStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lblJobStatus.ForeColor = Color.Red;
            }
        }

        private void pendientes_mdi_form_Load(object sender, EventArgs e)
        {
            this.lblID.Text = "";
            this.rtxtMensaje.Text = "";
            this.rtxtNotas.Text = "";
            this.lblTitulo.Text = "";
            this.chckboxPendienteTerminado.Checked = false;

            // Cargamos los datos en el MDI
            // Añadimos el elemento al TreeNode segun sea el caso requerido
            TreeNode node = new TreeNode();
            node.Text = actualList.Title;
            node.Tag = actualList.HASH;
            node.ToolTipText = actualList.FilePath;
            node.ImageIndex = 5;
            node.SelectedImageIndex = 5;

            BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].Nodes.Add(node);
            BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].ExpandAll();

            this.txtTituloDeLista.Text = actualList.Title;
        }

        private void añadirPendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Añadir nuevo pendiente
             */
            mdi_nuevo_pendiente child_form = new mdi_nuevo_pendiente(this);
            child_form.TopLevel = false;
            child_form.WindowState = FormWindowState.Maximized;
            //child_form.MdiParent = this;
            this.panelMDI.Controls.Add(child_form);
            child_form.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Guardamos la actividad
             */
            WriteStatus("Guardando list de pendiente...", true);
            bool canSave = false;

            try
            {
                if (String.IsNullOrEmpty(actualList.FilePath))
                {
                    /*
                     * En caso de que no contamos con un Path establecido, debemos escoger la ruta
                     */
                    this.saveFileDialog1.Title = "Selecciona la ruta de guardado de la lista...";
                    this.saveFileDialog1.Filter = "Listado de pendientes (*.todolist) |*.todolist";
                    this.saveFileDialog1.FileName = "";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        actualList.FilePath = saveFileDialog1.FileName;
                        canSave = true;
                    }
                } else
                {
                    canSave = true;
                }

                if (canSave)
                {
                    // Actualizamos el objeto segun la visualizacion
                    actualList.Title = this.txtTituloDeLista.Text;
                    actualList.Items.Clear();

                    foreach (ListViewItem item in this.lviewPendientes.Items)
                    {
                        ToDoListItem obj = new ToDoListItem()
                        {
                            ID = Int32.Parse(item.Text.ToString()),
                            Title = item.SubItems[1].Text,
                            Message = item.SubItems[2].Text,
                            Notes = item.SubItems[3].Text,
                            Finished = bool.Parse(item.SubItems[4].Text)
                        };

                        actualList.Items.Add(obj);
                    }

                    actualList.Save();

                    // Cambiamos el nombre y los datos del nodo
                    TreeNode node = new TreeNode();
                    node.Text = actualList.Title;
                    node.Tag = actualList.HASH;
                    node.ToolTipText = actualList.FilePath;
                    node.ImageIndex = 5;
                    node.SelectedImageIndex = 5;

                    TreeNode targetNode = null;
                    foreach (TreeNode n in BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].Nodes)
                    {
                        if (n.Tag.ToString() == actualList.HASH.ToString())
                        {
                            n.Text = actualList.Title;
                            n.Tag = actualList.HASH;
                            n.ToolTipText = actualList.FilePath;
                            break;
                        }
                    }

                    WriteStatus($"Listado guadado con exito en '{actualList.FilePath}'!", true);
                }
            } catch (Exception ex)
            {
                WriteStatus($"Ocurrio un error inesperado! {ex.Message}", false);
                CommonMethodsLibrary.OutMessage("OUT", $"{this.Name}.cs", $"ERROR A LA HORA DE GUARDADO DE LA LISTA DE PENDIENTES! {ex.Message}\n{ex}", "ERR");
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Eliminamos el nodo de esta lista
            TreeNode targetNode = BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].Nodes
                                            .Cast<TreeNode>()
                                            .Where(t => t.Tag.ToString() == actualList.HASH.ToString())
                                            .FirstOrDefault();

            BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].Nodes.Remove(targetNode);

            this.Close();
        }

        private void eliminarElPendienteSelecciondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Eliminar pendiente seleccionado
             * */
            if (actualSelected != null) {
                if (MessageBox.Show($"¿Seguro que deseas eliminar el pendiente '{actualSelected.Title}' de la lista?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<ToDoListItem> _lista = new List<ToDoListItem>();

                    foreach (ListViewItem i in this.lviewPendientes.Items)
                    {
                        if (i.Text == this.lblID.Text)
                        {
                            foreach (ToDoListItem j in actualList.Items)
                            {
                                if (j.ID != Int32.Parse(i.Text))
                                {
                                    _lista.Add(j);
                                    break;
                                }
                            }

                            i.Remove();
                            actualList.Items = _lista;
                            break;
                        }
                    }
                }
            }
        }

        private void marcarPendienteTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Marcamos el pendiente como terminado
             * */
            if (actualSelected != null)
            {
                
            }
        }

        private void editarPendienteSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Editamos el pendiente
             * */
        }

        ToDoListItem actualSelected = null;
        private void lviewPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lviewPendientes.SelectedItems.Count == 1)
            {
                ListViewItem item = this.lviewPendientes.SelectedItems[0];
                actualSelected = new ToDoListItem()
                {
                    ID = Int32.Parse(item.Text.ToString()),
                    Title = item.SubItems[1].Text,
                    Message = item.SubItems[2].Text,
                    Notes = item.SubItems[3].Text,
                    Finished = bool.Parse(item.SubItems[4].Text)
                };

                bool haveToEnable = false;
                if (actualSelected != null)
                {
                    this.lblID.Text = actualSelected.ID.ToString();
                    this.rtxtMensaje.Text = actualSelected.Message;
                    this.rtxtNotas.Text = actualSelected.Notes;
                    this.lblTitulo.Text = actualSelected.Title;
                    this.chckboxPendienteTerminado.Checked = actualSelected.Finished;
                    haveToEnable = true;
                }

                this.nuevoPendiente.Enabled = haveToEnable;
                this.eliminarPendienteSeleccionado.Enabled = haveToEnable;
            }
        }

        private void chckboxPendienteTerminado_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ToDoListItem i in actualList.Items)
            {
                if (i.ID == actualSelected.ID)
                {
                    i.Finished = this.chckboxPendienteTerminado.Checked;
                }
            }

            foreach (ListViewItem i in this.lviewPendientes.Items)
            {
                if (i.Text == this.lblID.Text)
                {
                    // Actualizamos el valor
                    i.SubItems[4].Text = this.chckboxPendienteTerminado.Checked.ToString();

                    if (this.chckboxPendienteTerminado.Checked)
                    {
                        // Cambiamos el estilo de la fila por ya haberse terminado
                        Font _font = new Font(i.Font, FontStyle.Strikeout);
                        Color _color = Color.FromKnownColor(KnownColor.ControlDarkDark);

                        i.Font = _font;
                        i.ForeColor = _color;

                        foreach (ListViewItem.ListViewSubItem sub in i.SubItems)
                        {
                            sub.Font = _font;
                            sub.ForeColor = _color;
                        }

                        i.ImageIndex = 0;
                    } else
                    {
                        // Ponemos el estilo por defecto
                        Font _font = new Font("Microsoft Sans Serif", 8.25f);
                        Color _color = Color.FromKnownColor(KnownColor.ControlText);

                        i.Font = _font;
                        i.ForeColor = _color;

                        foreach (ListViewItem.ListViewSubItem sub in i.SubItems)
                        {
                            sub.Font = _font;
                            sub.ForeColor = _color;
                        }
                    }
                    break;
                }
            }
        }

        private void rtxtNotas_TextChanged(object sender, EventArgs e)
        {
            if (actualSelected != null)
            {
                foreach (ToDoListItem i in actualList.Items)
                {
                    if (i.ID == actualSelected.ID)
                    {
                        i.Notes = this.rtxtNotas.Text;
                    }
                }

                foreach (ListViewItem i in this.lviewPendientes.Items)
                {
                    if (i.Text == this.lblID.Text)
                    {
                        i.SubItems[3].Text = this.rtxtNotas.Text.Trim();
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.cerrarToolStripMenuItem.PerformClick();
        }

        private void toolMinimizarReporte_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTituloDeLista_TextChanged(object sender, EventArgs e)
        {
            actualList.Title = this.txtTituloDeLista.Text.Trim();
            foreach (TreeNode n in BaseForm.treeViewCentroDeControl.Nodes["nodePendientesPorHacer"].Nodes)
            {
                if (n.Tag.ToString() == actualList.HASH.ToString())
                {
                    n.Text = actualList.Title;
                    break;
                }
            }
        }
    }
}
