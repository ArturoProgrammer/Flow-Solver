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
    public partial class exNuevaGuia : Form
    {
        bool have2Response = false;
        public WayBillData RESPONSE = new WayBillData();

        public exNuevaGuia()
        {
            InitializeComponent();

            foreach (Paqueteria i in Enum.GetValues(typeof(Paqueteria)))
            {
                this.cboxPaqueteria.Items.Add(i);
            }
            this.cboxPaqueteria.SelectedIndex = 1;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public exNuevaGuia(WayBillData data)
        {
            InitializeComponent();

            foreach (Paqueteria i in Enum.GetValues(typeof(Paqueteria)))
            {
                this.cboxPaqueteria.Items.Add(i);
            }
            this.cboxPaqueteria.SelectedIndex = 1;
            this.StartPosition = FormStartPosition.CenterParent;

            this.txtTitulo.ReadOnly = true;
            this.txtGuiaDeRastreo.ReadOnly = true;
            this.cboxPaqueteria.Enabled = false;
            this.rtxtDescripcion.ReadOnly = true;

            this.btnGuardar.Enabled = false;

            this.txtTitulo.Text = data.Titulo;
            this.txtGuiaDeRastreo.Text = data.WayBill;
            this.cboxPaqueteria.Text = data.Paqueteria.ToString();
            this.rtxtDescripcion.Text = data.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            have2Response = false;
            this.Close();
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
                    if (String.IsNullOrEmpty(this.txtGuiaDeRastreo.Text.Trim()))
                    {
                        this.errorProvider1.SetError(txtGuiaDeRastreo, "No puedes dejar este valor vacio!");
                        isValid = false;
                    }
                    else
                    {
                        this.errorProvider1.SetError(txtGuiaDeRastreo, "");
                        isValid = true;
                    }
                    break;
                case 2:
                    if (String.IsNullOrEmpty(this.rtxtDescripcion.Text.Trim()))
                    {
                        this.errorProvider1.SetError(rtxtDescripcion, "No puedes dejar este valor vacio!");
                        isValid = false;
                    }
                    else
                    {
                        this.errorProvider1.SetError(rtxtDescripcion, "");
                        isValid = true;
                    }
                    break;
                case 3:
                    if (String.IsNullOrEmpty(this.cboxPaqueteria.Text.Trim()))
                    {
                        this.errorProvider1.SetError(cboxPaqueteria, "No puedes dejar este valor vacio!");
                        isValid = false;
                    }
                    else
                    {
                        this.errorProvider1.SetError(cboxPaqueteria, "");
                        isValid = true;
                    }
                    break;
            }

            return isValid;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MultiValidator(0) && MultiValidator(1) && MultiValidator(2) && MultiValidator(3))
            {
                RESPONSE = new WayBillData()
                {
                    Titulo = txtTitulo.Text.Trim(),
                    WayBill = txtGuiaDeRastreo.Text.Trim(),
                    Descripcion = rtxtDescripcion.Text.Trim(),
                    Recibida = false
                };

                if (Enum.TryParse(this.cboxPaqueteria.Text, true, out Paqueteria paq))
                {
                    RESPONSE.Paqueteria = paq;
                }
                else
                {
                    RESPONSE.Paqueteria = Paqueteria.NONE;
                }

                have2Response = true;
                this.Close();
            }
        }

        private void exNuevaGuia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (have2Response)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void txtGuiaDeRastreo_TextChanged(object sender, EventArgs e)
        {
            this.txtGuiaDeRastreo.Text = txtGuiaDeRastreo.Text.Replace(" ", "").Trim();
        }
    }
}
