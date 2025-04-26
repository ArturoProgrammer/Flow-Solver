using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Microsoft.VisualBasic;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class libreta_direcciones_emails : Form
    {
        /// <summary>
        /// Mandantes del formulario
        /// </summary>
        public enum Mandant
        {
            CONFIG_PANEL,
            TONER_REQUEST,
            SPARE_PARTS_REQUEST,
        }

        public libreta_direcciones_emails(Mandant mandante)
        {
            InitializeComponent();

            if (mandante == Mandant.CONFIG_PANEL)
            {
                this.btnAñadirDireccion.Enabled = false;
            }
        }


        private void CrearDireccion(string Nombre, string Direccion)
        {
            try
            {
                EmailCard c = new EmailCard(Nombre, Direccion);
                c.Save();

                // Añadimos le item a la visualizacion
                ListViewItem item = new ListViewItem();
                item.Text = Nombre;
                item.Tag = c;
                item.StateImageIndex = 0;
                item.ImageIndex = 0;
                item.Group = lviewDirecciones.Groups[0];

                this.lviewDirecciones.Items.Add(item);

            } catch (Exception ex)
            {
                RJMessageBox.Show($"{ex.Message}\n{ex}", "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BorrarDireccion (string aNombre)
        {
            try
            {
                if (this.lviewDirecciones.SelectedItems.Count == 1) {
                    EmailCard c = (EmailCard)this.lviewDirecciones.SelectedItems[0].Tag;

                    if (MessageBox.Show($"¿Estas seguro que deseas eliminar la direccion < {c.EmployeeName}.json >?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        c.Delete();
                        LoadEmailsDirections(); // Recargamos las direcciones

                        RJMessageBox.Show($"Se ha borrado con exito el contacto de {aNombre}", "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadEmailsDirections()
        {
            this.lviewDirecciones.Items.Clear();

            // Carga las direcciones de correo existentes en el directorio de direcciones
            DirectoryInfo di = new DirectoryInfo($@"{Application.StartupPath}\Addresses\");
            FileInfo[] files = di.GetFiles("*.json");

            foreach (FileInfo file in files)
            {
                JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                EmailCard c = new EmailCard();
                c.EmployeeName = file.Name.Replace(".json", "");
                c.EmployeeDirection = json[c.EmployeeName].ToString();

                // Añadimos le item a la visualizacion
                ListViewItem item = new ListViewItem();
                item.Text = c.EmployeeName;
                item.Tag = c;
                item.StateImageIndex = 0;
                item.ImageIndex = 0;
                item.Group = lviewDirecciones.Groups[0];

                this.lviewDirecciones.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listDirecciones.Items.Add("Andrea Yuritze Tello Rodriguez");
            if (!Directory.Exists($@"{Application.StartupPath}\Addresses\"))
            {
                Directory.CreateDirectory($@"{Application.StartupPath}\Addresses\");
                LoadEmailsDirections();
            } else
            {
                LoadEmailsDirections();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aNombre = Interaction.InputBox("Nombre de la persona:", "Datos");
            string aCorreo = Interaction.InputBox("Correo electronico:", "Datos");

            if (!string.IsNullOrEmpty(aNombre) & !string.IsNullOrEmpty(aCorreo))
            {
                CrearDireccion(aNombre, aCorreo);
                RJMessageBox.Show("¡Correo añadido a la libreta!", "Lbreta de Direcciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            if (this.lviewDirecciones.SelectedItems.Count > 0)
            {
                BorrarDireccion(this.lviewDirecciones.SelectedItems[0].Text);
            }
        }

        bool IsAnswered = false;
        internal EmailCard RESPONSE = null;

        private void btnAñadirDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lviewDirecciones.SelectedItems.Count > 0)
                {
                    EmailCard card = (EmailCard)this.lviewDirecciones.SelectedItems[0].Tag;
                    RESPONSE = card;

                    IsAnswered = true;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                IsAnswered = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void lviewDirecciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btnAñadirDireccion.PerformClick();
        }

        private void libreta_direcciones_emails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsAnswered)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
