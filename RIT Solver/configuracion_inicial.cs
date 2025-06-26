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
            this.Panel0.Visible = true;
            this.txtContraseña.UseSystemPasswordChar = true;

            // Valores por default
            this.txtEmailRefacciones.Text = "soporte.lider@ferromex.mx";
            this.txtLiderDeProyecto.Text = "Andrea Yuritze Tello Rodriguez";
            this.cboxCliente.Text = "Ferromex (FXE)";
            this.txtProyecto.Text = "Ferromex";
            this.cboxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            #region RUTA DE FORMATOS RIT
            string pathRit = Application.StartupPath + @"\FORMULARIO RIT HQ.pdf";

            if (File.Exists(pathRit))
            {
                this.txtRutaDeRIT.Text = pathRit;
            } else
            {
                MessageBox.Show("No se ha encontrado el archivo base de RIT!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            this.txtRutaRITDestino.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.txtEmailProveedorToner.Text = Properties.Settings.Default.EmailDistribuidorToner;
            #region RUTA DE FORMATOS DE RESGUARDOS
            string pathResponsiva = Application.StartupPath + @"\FORMULARIO ACTARESPONSIVA HQ.pdf";

            if (File.Exists(pathResponsiva))
            {
                this.txtRutaFormResguardos.Text = pathResponsiva;
            } else
            {
                MessageBox.Show("No se ha encontrado el archivo base de acta responsiva!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    

        private void button1_Click(object sender, EventArgs e)
        {
            int errors_on_form = 0;

            // Se asignan todas las propiedades en la configuracion
            if (string.IsNullOrEmpty(txtNombre.Text)) { errors_on_form++; } else { Properties.Settings.Default.NombreIDC = this.txtNombre.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtLocalidad.Text)) { errors_on_form++; } else { Properties.Settings.Default.LocalidadIDC = this.txtLocalidad.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtProyecto.Text)) { errors_on_form++; } else { Properties.Settings.Default.ProyectoIDC = this.txtProyecto.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtCorreo.Text)) { errors_on_form++; } else { Properties.Settings.Default.EmailUsuarioIDC = this.txtCorreo.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtContraseña.Text)) { errors_on_form++; } else { Properties.Settings.Default.EmailPasswordIDC = this.txtContraseña.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtEmailRefacciones.Text)) { errors_on_form++; } else { Properties.Settings.Default.EmailDestinoRefaccionesDefault = this.txtEmailRefacciones.Text.Trim(); errors_on_form--; }
            Properties.Settings.Default.Direccion = this.txtDireccion.Text.Trim();
            Properties.Settings.Default.CentroDeServicios = this.txtCentroDeServicios.Text.Trim();

            if (string.IsNullOrEmpty(txtLiderDeProyecto.Text)) { errors_on_form++; } else { Properties.Settings.Default.LiderDeProyecto = this.txtLiderDeProyecto.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtRutaDeRIT.Text)) { errors_on_form++; } else { Properties.Settings.Default.RITFormPath = this.txtRutaDeRIT.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtRutaRITDestino.Text)) { errors_on_form++; } else { Properties.Settings.Default.RITFormPathDestiny = this.txtRutaRITDestino.Text.Trim(); errors_on_form--; }
            Properties.Settings.Default.Cliente = this.cboxCliente.Text.Trim();
            if (string.IsNullOrEmpty(txtUsuarioDeRed.Text)) {  errors_on_form++; } else { Properties.Settings.Default.UsuarioDeRedIDC = this.txtUsuarioDeRed.Text.Trim(); errors_on_form--; }
            if (string.IsNullOrEmpty(txtEmailProveedorToner.Text)) { errors_on_form++; } else { Properties.Settings.Default.EmailDistribuidorToner = this.txtEmailProveedorToner.Text.Trim(); errors_on_form--; }

            
            // Se guarda la ruta del inventario
            if (!String.IsNullOrEmpty(this.txtRutaDelInventario.Text.Trim())) 
            { 
                Properties.Settings.Default.SYSDATA_INVENTORY_PATH = this.txtRutaDelInventario.Text; 
            }

            // Se guarda la ruta del acta responsiva
            if (!String.IsNullOrEmpty(this.txtRutaFormResguardos.Text.Trim()) && File.Exists(this.txtRutaFormResguardos.Text.Trim())) 
            { 
                Properties.Settings.Default.ActaResponsivaPath = $@"{Application.StartupPath}\FORMULARIO ACTARESPONSIVA HQ.pdf"; 
            } else 
            { 
                RJMessageBox.Show("No fue posible encontrar la ruta origen del formato de Acta Responsiva. Debera elegirlo manualmente en Configuracion", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


            /* 
             * Se establecen el valor -11 ya que es el conteo total de que todo esta OK 
             * */
            if (errors_on_form == -11)
            {
                // Se guardan las propiedades en la configuracion
                Properties.Settings.Default.FIRST_INITIALIZE = false;
                
                //Properties.Settings.Default.Save();

                /* VALIDA LA EXISTENCIA Y/O CREA EL DIRECTORIO */
                if (!Directory.Exists(this.txtRutaRITDestino.Text))
                {
                    Directory.CreateDirectory(this.txtRutaRITDestino.Text);
                }

                #region CREA LA DIRECCION DEFAULT INICIAL
                MakeDefaultDirection();
                #endregion

                response = true;
                tour_inicial frm = new tour_inicial();
                this.Close();
                frm.ShowDialog();
            } else
            {
                RJMessageBox.Show("Debes llenar los campos obligatorios!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void MakeDefaultDirection()
        {
            string LOCAL_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (!Directory.Exists(LOCAL_PATH))
            {
                Directory.CreateDirectory(LOCAL_PATH);
            }

            #region CREAMOS LA DIRECCION
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
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            response = false;
            this.Close();
        }

        private void btnExaminarFolder_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Escoger ruta destino...";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;

                    this.txtRutaRITDestino.Text = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error inesperado!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configuracion_inicial_Load(object sender, EventArgs e)
        {
            /* IGNORAR */
            this.txtNombre.Select();
        }

        private void txtRutaDeRIT_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRutaDeRIT.Text != Application.StartupPath + @"\FORMULARIO RIT HQ.pdf")
            {
                // warningProvider.SetIconPadding(txtRutaDeRIT, 57);
                warningProvider.SetError(txtRutaDeRIT, "Cambiar la ruta de la plantilla de RIT sin la indicacion del desarrollador es arriesgado ya que puede causar mal funcionamiento en el sistema!");
            }
        }

        private void btnExaminarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Escoger archivo de inventario (llenado)...";
                openFileDialog1.Filter = "Excel (*.xlsx; *.xls; *.xlsm)|*.xlsx;*.xls;*.xlsm|Todos los Archivos(*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    this.txtRutaDelInventario.Text = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error inesperado!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region VALIDACION DE CAMPOS
        string MSG_ERROR = "No puede dejar vacio este campo!";
        string MSG_OK = "Correcto!";
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, MSG_ERROR);
            } else
            {
                errorProvider.SetError(txtNombre, "");
                checkProvider.SetError(txtNombre, MSG_OK);
            }
        }

        private void txtLocalidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                errorProvider.SetError(txtLocalidad, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtLocalidad, "");
                checkProvider.SetError(txtLocalidad, MSG_OK);
            }
        }

        private void txtProyecto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProyecto.Text))
            {
                errorProvider.SetError(txtProyecto, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtProyecto, "");
                checkProvider.SetError(txtProyecto, MSG_OK);
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text) | !txtCorreo.Text.Contains("@ferromex.mx"))
            {
                errorProvider.SetError(txtCorreo, "Direccion de correo invalida");
            }
            else
            {
                errorProvider.SetError(txtCorreo, "");
                checkProvider.SetError(txtCorreo, MSG_OK);
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                checkProvider.SetError(btnVer, "");
                errorProvider.SetError(btnVer, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(btnVer, "");
                checkProvider.SetError(btnVer, MSG_OK);
            }
        }

        private void txtEmailRefacciones_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailRefacciones.Text))
            {
                errorProvider.SetError(txtEmailRefacciones, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtEmailRefacciones, "");
                checkProvider.SetError(txtEmailRefacciones, MSG_OK);
            }
        }

        private void txtLiderDeProyecto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLiderDeProyecto.Text))
            {
                errorProvider.SetError(txtLiderDeProyecto, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtLiderDeProyecto, "");
                checkProvider.SetError(txtLiderDeProyecto, MSG_OK);
            }
        }

        private void txtRutaRITDestino_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRutaRITDestino.Text))
            {
                checkProvider.SetError(btnExaminarRit, "");
                errorProvider.SetError(btnExaminarRit, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(btnExaminarRit, "");
                checkProvider.SetError(btnExaminarRit, MSG_OK);
            }
        }

        private void txtUsuarioDeRed_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioDeRed.Text))
            {
                errorProvider.SetError(txtUsuarioDeRed, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtUsuarioDeRed, "");
                checkProvider.SetError(txtUsuarioDeRed, MSG_OK);
            }
        }

        private void txtEmailProveedorToner_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailProveedorToner.Text))
            {
                errorProvider.SetError(txtEmailProveedorToner, MSG_ERROR);
            }
            else
            {
                errorProvider.SetError(txtEmailProveedorToner, "");
                checkProvider.SetError(txtEmailProveedorToner, MSG_OK);
            }
        }
        #endregion

        private void btnBuscarRutaResguardos_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Cargar RIT...";
                openFileDialog1.Filter = "Archivos PDF (*.pdf) |*.pdf";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    this.txtRutaFormResguardos.Text = path;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error inesperado!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
