using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class MsgBoxWNeverAskAgain : Form
    {
        /// <summary>
        /// Indica el estado de chequeo del control. True en caso de seleccionarse no volver a preguntar y False en caso contrario
        /// </summary>
        public bool CheckBox_Value;

        /// <summary>
        /// Cuadro de dialogo que indicara si se debe o no volver a preguntar una configuracion. El cuadro retorna DialogResult.No o DialogResult.Yes
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="Message"></param>
        /// <param name="DefaultCheckBoxValue"></param>
        public MsgBoxWNeverAskAgain(string Caption, string Message, bool DefaultCheckBoxValue)
        {
            InitializeComponent();
            this.Text = Caption;
            this.lblMessage.Text = Message;
            this.checkBox1.Checked = DefaultCheckBoxValue;
            this.StartPosition = FormStartPosition.CenterParent;

            this.DialogResult = DialogResult.None;
        }

        private void MsgBoxWNeverAskAgain_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_Value = this.checkBox1.Checked;
        }

        private void MsgBoxWNeverAskAgain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
