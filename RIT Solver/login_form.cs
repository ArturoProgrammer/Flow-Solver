using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Select();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
