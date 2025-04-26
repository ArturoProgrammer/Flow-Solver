using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver.Centro_de_Control
{
    public partial class mdi_nuevo_pendiente : Form
    {
        pendientes_mdi_form BaseForm;

        public mdi_nuevo_pendiente(pendientes_mdi_form LegacyForm)
        {
            InitializeComponent();

            BaseForm = LegacyForm;
        }

        bool MultiValidator(int index)
        {
            bool isValid = false;

            switch (index)
            {
                case 0:
                    if (String.IsNullOrEmpty(this.txtTitulo.Text.Trim()))
                    {
                        this.errorProvider1.SetError(txtTitulo, "No puedes dejar este valor vacio!");
                        isValid = false;
                    }
                    else
                    {
                        this.errorProvider1.SetError(txtTitulo, "");
                        isValid = true;
                    }
                    break;
                case 1:
                    if (String.IsNullOrEmpty(this.rtxtMensaje.Text.Trim()))
                    {
                        this.errorProvider1.SetError(rtxtMensaje, "No puedes dejar este valor vacio!");
                        isValid = false;
                    }
                    else
                    {
                        this.errorProvider1.SetError(rtxtMensaje, "");
                        isValid = true;
                    }
                    break;
            }

            return isValid;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (MultiValidator(0) && MultiValidator(1))
            {
                #region CREAMOS EL NUEVO ITEM
                int lastID = 0;

                foreach (ListViewItem i in BaseForm.lviewPendientes.Items)
                {
                    lastID = Int32.Parse(i.Text.ToString()) + 1;
                }

                ListViewItem item = new ListViewItem();

                item.Text = lastID.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = this.txtTitulo.Text.Trim()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = this.rtxtMensaje.Text.Trim()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = this.rtxtNotas.Text.Trim()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "False"
                });
                #endregion

                BaseForm.lviewPendientes.Items.Add(item);
                this.Close();

                BaseForm.WriteStatus($"Elemento '{this.txtTitulo.Text.Trim()}' añadido con exito!...", true);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
