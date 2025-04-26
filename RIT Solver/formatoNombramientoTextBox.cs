using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver
{
    public partial class formatoNombramientoTextBox : UserControl
    {

        string _Text = "";

        #region PROPIEDADES
        public string Text {
            get
            {
                return _Text;
            }
            set 
            {
                _Text = value;
                this.txtValue.Text = _Text;
            }
        }
        #endregion

        public formatoNombramientoTextBox()
        {
            InitializeComponent();
        }

        private void formatoNombramientoTextBox_Load(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            _Text = this.txtValue.Text;
        }

        private void btnSeleccionarTag_Click(object sender, EventArgs e)
        {

        }
    }
}
