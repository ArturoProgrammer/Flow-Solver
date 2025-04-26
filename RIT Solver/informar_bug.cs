using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


using CustomMessageBox;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Diagnostics;
using System.Net;


namespace RIT_Solver
{
    public partial class informar_bug : Form
    {
        string complete_asunto = "";
        public informar_bug()
        {
            InitializeComponent();
        }

        private void richtbMensaje_TextChanged(object sender, EventArgs e)
        {
            /* IGNORAR */
        }

        private void informar_bug_Load(object sender, EventArgs e)
        {
            /* IGNORAR*/
        }

        static string Usuario = Properties.Settings.Default.EmailUsuarioIDC;
        static string Password = Properties.Settings.Default.EmailPasswordIDC;

        // Funcion para enviar el correo
        public static void EnviarCorreo(StringBuilder Mensaje, string De, string Para, string Asunto, out string Error, bool useBackupMethod = false)
        {
            Error = "";

            if (!useBackupMethod)
            {
                #region
                try
                {
                    // Pie de pagina del mensaje - Modificar para que contenga la firma personalizada del usuario
                    Mensaje.Append(Environment.NewLine);
                    Mensaje.Append(string.Format("Este correo ha sido enviado usando RIT Solver For IDC"));
                    Mensaje.Append(Environment.NewLine);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(De);
                    mail.To.Add(Para);
                    mail.Subject = Asunto;
                    mail.Body = Mensaje.ToString();

                    SmtpClient smtp = new SmtpClient("smtp.office365.com");
                    smtp.Port = 587;

                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    Error = "Envio realizado con exito!";

                    RJMessageBox.Show(Error, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Error = "Error: " + ex.Message;
                    RJMessageBox.Show(Error, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else
            {
                #region
                // Codificar los valores para que sean válidos en una URL
                string asuntoCodificado = Uri.EscapeDataString(Asunto);
                string cuerpoCodificado = Uri.EscapeDataString(Mensaje.ToString());

                // Crear la URL mailto
                string mailto = $"mailto:{De}&subject={asuntoCodificado}&body={cuerpoCodificado}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = mailto,
                    UseShellExecute = true // Necesario para lanzar el cliente de correo
                }); 
                
                
                #endregion
            }
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (this.txtFalla.Text == string.Empty)
            {
                RJMessageBox.Show("Debe completar el campo de Falla para poder enviar", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errors = true;
            } else if (this.richtbMensaje.Text == string.Empty)
            {
                RJMessageBox.Show("Debe completar el campo de mensaje para poder enviar", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errors = true;
                
            } else
            {
                errors = false;
            }

            if (errors == false)
            {
                /* FUNCION PARA ENVIAR EL CORREO */

                // Confirmacion de envio
                if (RJMessageBox.Show("¿Seguro que desea enviar este correo?", "Confirmacion de envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    // codigo para envio

                    string Error = "";
                    StringBuilder MensajeBuilder = new StringBuilder();

                    // Mensaje de usuario
                    MensajeBuilder.Append(this.richtbMensaje.Text.Trim());

                    // DATOS DE LA APLICACION
                    MensajeBuilder.Append(Environment.NewLine + Environment.NewLine +
                        "========================== [ INFORMACION DE LA APLICACION ] ==========================" +
                        Environment.NewLine);
                    MensajeBuilder.Append(Environment.NewLine +
                        $"VERSION DE SOFTWARE: {Properties.Settings.Default.SYS_VERSION}" +
                        Environment.NewLine +
                        $"USUARIO IDC REPORTANDO: {Properties.Settings.Default.NombreIDC}" +
                        Environment.NewLine +
                        $"LOCALIDAD: {Properties.Settings.Default.LocalidadIDC}" +
                        Environment.NewLine +
                        $"VERSION DE ENSAMBLADO: {Properties.Settings.Default.SYS_ASSEMBLY}" +
                        Environment.NewLine +
                        $"ULTIMA ACTUALIZACION: {Properties.Settings.Default.SYS_LAST_UPDATE}" +
                        Environment.NewLine);

                    complete_asunto = $"{this.txtPreAsunto.Text} // {this.txtFalla.Text}";
                    // Envio de mensaje
                    EnviarCorreo(MensajeBuilder, Usuario, "soporte.hermosillo@ferromex.mx", complete_asunto, out Error, useBackupMethod:true);
                    this.Close();
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informar_bug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }
    }
}
