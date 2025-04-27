using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Flow_Solver.Controls
{
    public partial class TagListForm : Form
    {
        public TagListForm ()
        {
            //InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Eliminar bordes predeterminados
            this.Padding = new Padding(10); // Añadir padding para el borde personalizado
            this.MouseDown += CustomForm_MouseDown; // Manejar el evento MouseDown para mover el formulario
        }

        // Sobrescribir el método OnPaint para dibujar el borde personalizado
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.Blue, 10)) // Cambiar el color y grosor del borde
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
        }

        // Manejar el evento MouseDown para mover el formulario
        private void CustomForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        // P/Invoke para permitir el movimiento del formulario
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TagListForm
            // 
            this.ClientSize = new System.Drawing.Size(413, 154);
            this.Name = "TagListForm";
            this.Text = "Listado de Tags Disponibles";
            this.ResumeLayout(false);

        }
    }
}
