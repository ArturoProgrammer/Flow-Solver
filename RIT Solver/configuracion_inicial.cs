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

using CustomMessageBox;

using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Flow_Solver
{
    public partial class configuracion_inicial : Form
    {

        public configuracion_inicial()
        {
            InitializeComponent();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            response = true;
            this.Close();
        }

        internal void MakeDefaultDirection()
        {
            string LOCAL_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (!Directory.Exists(LOCAL_PATH))
            {
                Directory.CreateDirectory(LOCAL_PATH);
            }

            #region CREAMOS LA DIRECCION
            /*
            Dictionary<string, string> direction = new Dictionary<string, string>();

            direction.Add("nombre", "Direccion default");
            direction.Add("direccion", this.txtDireccion.Text);
            direction.Add("sucursal", "");
            direction.Add("isDefaultDir", "true");
            direction.Add("no_de_sucursal", "");
            direction.Add("poblacion", this.txtLocalidad.Text);
            direction.Add("centro_servicios", this.txtCentroDeServicios.Text);

            switch (this.cboxCliente.Text.Trim())
            {
                case "Ferromex (FXE)":
                    direction.Add("estacion", "FXE");
                    break;
                case "Ferrosur (FSRR)":
                    direction.Add("estacion", "FSRR");
                    break;
                case "Intermodal (IMEX)":
                    direction.Add("estacion", "IMEX");
                    break;
                default:
                    direction.Add("estacion", "");
                    break;
            }

            string finaljson = System.Text.Json.JsonSerializer.Serialize(direction);
            File.WriteAllText($@"{LOCAL_PATH}\Direccion_default.json", finaljson);
            */
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            response = false;
            this.Close();
        }

        private void configuracion_inicial_Load(object sender, EventArgs e)
        {
            /* IGNORAR */
            this.txtNombre.Select();
        }

        bool response = false;
        private void configuracion_inicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (response)
            {
                DialogResult = DialogResult.OK;
            } else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
