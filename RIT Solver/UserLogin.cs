using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            this.Text = $"{Application.ProductName} - Login de Usuario";
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que salir del login?") == DialogResult.Yes)
            {
                e.Cancel = false;
            } else
            {
                e.Cancel = true;
            }
        }
    }
}
