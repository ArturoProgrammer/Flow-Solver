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
using System.Diagnostics;
using System.Net;
using System.Web;


namespace Flow_Solver
{
    public partial class solicitar_refaccion : Form
    {
        /*
            AÑADIR QUE SE GUARDEN DATOS DEL CORREO
         */
        //const string Usuario = "soporte.hermosillo@ferromex.mx";    // Correo de usuario
        //const string Password = "Ferromex20221";                    // Contraseña del usuario

        static string Usuario = Properties.Settings.Default.EmailUsuarioIDC;
        static string Password = Properties.Settings.Default.EmailPasswordIDC;

        // Funcion para enviar el correo
        public static void EnviarCorreo(StringBuilder Mensaje, string De, String[] Para, String[] CC,string Asunto, out string Error, bool useBackupMethod = false)
        {
            Error = "";

            // Añadimos el pie del correo
            Mensaje.Append(Environment.NewLine);
            Mensaje.Append(string.Format("Este correo ha sido enviado usando RIT Solver For IDC"));
            Mensaje.Append(Environment.NewLine);
            
            if (!useBackupMethod)
            {
                #region
                try
                {
                    // Pie de pagina del mensaje - Modificar para que contenga la firma personalizada del usuario
                    

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(De);

                    // Añadimos las direcciones a enviar
                    foreach (string mailTo in Para)
                    {
                        mail.To.Add(mailTo);
                    }

                    if (CC.Count() == 1 & !string.IsNullOrEmpty(CC[0].ToString()))
                    {
                        foreach (string mailCC in CC)
                        {
                            mail.CC.Add(mailCC);
                        }
                    }

                    mail.Subject = Asunto;
                    mail.Body = Mensaje.ToString();

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.office365.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Send(mail);

                    Error = "Envio realizado con exito!";

                    RJMessageBox.Show(Error, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex)
                {
                    Error = "Error: " + ex.Message + "\n\n" + ex.ToString();
                    RJMessageBox.Show(Error, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else 
            {
                // Mandamos el mensaje por correo usando el metodo del comando Mailto en el Shell
                #region
                try
                {
                    // Añadimos las direcciones a enviar
                    List<string> destinos = new List<string>();
                    foreach (string mailTo in Para)
                    {
                        destinos.Add(mailTo);
                    }
                    string direcciones_destinos = String.Join(",", destinos);

                    List<string> copiascarbon = new List<string>();
                    if (CC.Count() == 1 & !string.IsNullOrEmpty(CC[0].ToString()))
                    {
                        foreach (string mailCC in CC)
                        {
                            copiascarbon.Add(mailCC);
                        }
                    }
                    string direcciones_cc = String.Join(",", copiascarbon);

                    // Codificar los valores para que sean válidos en una URL
                    string asuntoCodificado = Uri.EscapeDataString(Asunto);
                    string cuerpoCodificado = Uri.EscapeDataString(Mensaje.ToString());

                    // Crear la URL mailto
                    string mailto = $"mailto:{direcciones_destinos}?cc={WebUtility.UrlEncode(direcciones_cc)}&subject={asuntoCodificado}&body={cuerpoCodificado}";

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = mailto,
                        UseShellExecute = true // Necesario para lanzar el cliente de correo
                    });
                }
                catch (Exception ex)
                {
                    Error = "Error: " + ex.Message + "\n\n" + ex.ToString();
                    RJMessageBox.Show(Error, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void solicitar_refaccion_Load(object sender, EventArgs e)
        {
            /* IGNORAR FUNCION */
            this.btnAñadirCC.Visible = true;
            this.btnAñadirDestino.Visible = true;
        }

        #region CARGA Y ENVIO DE CORREO
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            // Nos aseguramos que los campos obligatorios esten llenos
            if (this.txtRemitente.Text == "" || this.txtEmailDestino.Text == "" || this.txtAsunto.Text == "")
            {
                RJMessageBox.Show("No se puede enviar el correo. Asegurese de llenar los campos obligatorios!", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // Advertencia de campos en 13 puntos vacios
                if (this.txtNoDeReporte.Text == "" || this.txtProyecto.Text == "" || this.txtLocalidad.Text == "" || this.txtNombreDeUsuario.Text == "" || this.txtDepartamento.Text == "" || this.txtTelefono.Text == "" || this.txtMarca.Text == "" || this.txtModelo.Text == "" || this.txtSerieDeLaRefaccion.Text == "" || this.txtDescripcion.Text == "" || this.txtMarcaDeLaRefaccion.Text == "" || this.txtSolicitante.Text == "" || this.txtLider.Text == "")
                {
                    String null_val = "N/A" as string;

                    if (RJMessageBox.Show("Existen campos vacios! Los campos en blanco se llenaran con el valor " + null_val, "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        // Evaluar componentes vacios
                        if (string.IsNullOrEmpty(this.txtNoDeReporte.Text)) { this.txtNoDeReporte.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtProyecto.Text)) { this.txtProyecto.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtLocalidad.Text)) { this.txtLocalidad.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtNombreDeUsuario.Text)) { this.txtNombreDeUsuario.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtDepartamento.Text)) { this.txtDepartamento.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtTelefono.Text)) { this.txtTelefono.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtMarca.Text)) { this.txtMarca.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtModelo.Text)) { this.txtModelo.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtSerieDeLaRefaccion.Text)) { this.txtSerieDeLaRefaccion.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtDescripcion.Text)) { this.txtDescripcion.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtMarcaDeLaRefaccion.Text)) { this.txtMarcaDeLaRefaccion.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtSolicitante.Text)) { this.txtSolicitante.Text = null_val; }
                        if (string.IsNullOrEmpty(this.txtLider.Text)) { this.txtLider.Text = null_val; }
                    }
                }

                if (RJMessageBox.Show("¿Seguro que desea enviar este correo?", "Confirmacion de Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    /*
                        FUNCIONALIDAD DE ENVIAR CORREO ELECTRONICOS
                    */
                    string Error = "";
                    StringBuilder MensajeBuilder = new StringBuilder();

                    MensajeBuilder.Append("INFORMO:");
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("NO. DEL REPORTE: " + this.txtNoDeReporte.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("PROYECTO: " + this.txtProyecto.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("LOCALIDAD: " + this.txtLocalidad.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("NOMBRE DEL USUARIO: " + this.txtNombreDeUsuario.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("DEPARTAMENTO: " + this.txtDepartamento.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("TELEFONO: " + this.txtTelefono.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("MARCA: " + this.txtMarca.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("MODELO: " + this.txtModelo.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("SERIE DE LA REFACCION DAÑADA: " + this.txtSerieDeLaRefaccion.Text.Trim());

                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("DESCRIPCION DE LA REFACCION DAÑADA: " + this.txtDescripcion.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("MARCA DE LA REFACCION: " + this.txtMarcaDeLaRefaccion.Text.Trim());

                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("SOLICITANTE: " + this.txtSolicitante.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append("LIDER: " + this.txtLider.Text.Trim());
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append(richTextBox1.Text);
                    MensajeBuilder.Append(Environment.NewLine);
                    MensajeBuilder.Append(Environment.NewLine);


                    if (!string.IsNullOrEmpty(this.txtEmailDestino.Text) | !string.IsNullOrEmpty(this.txtEmailCC.Text))
                    {
                        String[] destinos;
                        String[] CCs;

                        
                        if (txtEmailDestino.Text.Contains(";"))
                        {
                            destinos = this.txtEmailDestino.Text.Split(";".ToCharArray());
                        }
                        else
                        {
                            destinos = new string[1];
                            destinos[0] = txtEmailDestino.Text.Trim();
                        }

                        if (txtEmailCC.Text.Contains(";"))
                        {
                            CCs = this.txtEmailCC.Text.Split(";".ToCharArray());
                        }
                        else
                        {
                            CCs = new string[1];
                            CCs[0] = txtEmailCC.Text.Trim();
                        }    

                        //RJMessageBox.Show(MensajeBuilder.ToString());
                        EnviarCorreo(MensajeBuilder, this.txtRemitente.Text.Trim(), destinos, CCs, this.txtAsunto.Text.Trim(), out Error, true);
                        this.Close();
                    }


                }
            }
        }
        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //this.label19.Visible = true;
        }


        private rit_mdi_form padre;
        public solicitar_refaccion (rit_mdi_form LegacyForm)
        {
            padre = LegacyForm;
            // CUANDO SE INICIALIZA LA APP...
            InitializeComponent();

            this.txtRemitente.Text = Usuario;
            this.txtEmailDestino.Text = Properties.Settings.Default.EmailDestinoRefaccionesDefault;
            this.txtLider.Text = Properties.Settings.Default.LiderDeProyecto;

            // VALOR INICIAL DEL ASUNTO
            string asunto_mail = "SOLICITUD DE REFACCION // REPORTE " + padre.txtNoDeReporteDelCliente.Text + " // " + padre.txtRefaccionesUtilizadas.Text;
            this.txtAsunto.Text = asunto_mail;
        }

        public solicitar_refaccion()
        {
            InitializeComponent();
        }

        private void btnAñadirDestino_Click(object sender, EventArgs e)
        {
            // To
            libreta_direcciones_emails frm = new libreta_direcciones_emails(libreta_direcciones_emails.Mandant.SPARE_PARTS_REQUEST);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<string> mails = this.txtEmailDestino.Text.Split(';').ToList();
                mails.Add(frm.RESPONSE.EmployeeDirection);

                this.txtEmailDestino.Text = string.Join("; ", mails);
            }
        }

        private void btnAñadirCC_Click(object sender, EventArgs e)
        {
            // CC
            libreta_direcciones_emails frm = new libreta_direcciones_emails(libreta_direcciones_emails.Mandant.SPARE_PARTS_REQUEST);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<string> mails = this.txtEmailDestino.Text.Split(';').ToList();
                mails.Add(frm.RESPONSE.EmployeeDirection);

                this.txtEmailCC.Text = string.Join("; ", mails);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void solicitar_refaccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }
    }
}
