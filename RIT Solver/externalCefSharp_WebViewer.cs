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
    public partial class externalCefSharp_WebViewer : Form
    {
        public externalCefSharp_WebViewer(string FormTittle, string WebLink)
        {
            InitializeComponent();
            this.Text = FormTittle;
            this.chromiumWebBrowser1.LoadUrl(WebLink);
        }

        public externalCefSharp_WebViewer(string FormTittle, string WebLink, Size FormSize)
        {
            InitializeComponent();
            this.Text = FormTittle;
            this.chromiumWebBrowser1.LoadUrl(WebLink);
            this.Size = FormSize;
        }

        private void externalCefSharp_WebViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
