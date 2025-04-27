using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Flow_Solver
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            this.label1.Text = "v" + Properties.Settings.Default.SYS_VERSION;
        }
    }
}
