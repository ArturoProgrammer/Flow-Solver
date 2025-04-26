using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using SpreadsheetLight;
using System.IO;

using CustomMessageBox;
using System.Diagnostics;
using System.Net;


namespace RIT_Solver
{
    public partial class solicitar_toner : Form
    {
        public static string Usuario = Properties.Settings.Default.EmailUsuarioIDC;
        public static string Password = Properties.Settings.Default.EmailPasswordIDC;
        public static string Distribuidor = Properties.Settings.Default.EmailDistribuidorToner;
        
        List<string> array_adjuntos = new List<string>();

        public solicitar_toner()
        {
            InitializeComponent();
        }

        public void ImportarExcel(string BookPath, string SheetBook)
        {
            if (BookPath != string.Empty)
            {
                SLDocument sl;
                try
                {
                    sl = new SLDocument(BookPath, SheetBook);
                    int iRow = 2;

                    if (SheetBook == "IMPRESORAS")
                    {
                        
                    }

                    List<ImpresorasViewModel> lst = new List<ImpresorasViewModel>();

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {

                        ImpresorasViewModel oImpresora = new ImpresorasViewModel();

                        oImpresora.Impresora = sl.GetCellValueAsString(iRow, 1);
                        oImpresora.Marca = sl.GetCellValueAsString(iRow, 2);
                        oImpresora.Modelo = sl.GetCellValueAsString(iRow, 3);
                        oImpresora.Ubicacion = sl.GetCellValueAsString(iRow, 4);
                        oImpresora.IP = sl.GetCellValueAsString(iRow, 5);

                        lst.Add(oImpresora);

                        iRow++;
                    }
                    dataGridView1.DataSource = lst;
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Ha ocurrido un error inesperado y desconocido en la carga del inventario." + Environment.NewLine + Environment.NewLine + "El programa dice:" + Environment.NewLine + ex.Message, "Error en el inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void solicitar_toner_Load(object sender, EventArgs e)
        {
            /* ELIMINAR ESTO AL FINALIZAR LECTURA DE JSONs */
            /* =====[ AGREGAR ]=====
             * - AGREGADO DE IMPRESORAS
             * */

            this.dataGridView1.Visible = false;

            /*
            if (Properties.Settings.Default.SYSDATA_INVENTORY_PATH != string.Empty)
            {
                
            }
            */

            string inv_path = $@"{Application.StartupPath}\Inventories\IMPRESORAS.xlsx";
            try
            {
                int iRow = 2;
                SLDocument sl = new SLDocument(inv_path, "IMPRESORAS");

                List<string> list = new List<string>();
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    //ImpresorasViewModel oImpresora = new ImpresorasViewModel();
                    string oImpresora;

                    oImpresora = sl.GetCellValueAsString(iRow, 1);

                    list.Add(oImpresora);

                    iRow++;
                }
                foreach (string impresora in list)
                {
                    this.cBoxImpresora.Items.Add(impresora);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.ToString());
            }

            // INICIALIZAMOS EL INVENTARIO
            ImportarExcel(inv_path, "IMPRESORAS");


            /* ELIMINAR ESTO AL FINALIZAR LECTURA DE JSONs */

            /* Datos inciales del solitante */
            this.txtAsuntoPt_UNO.Enabled = false;
            this.txtAsuntoPt_UNO.Text = $"SOLICITUD DE REPOSICION DE TONER";
            this.txtLocalidad.Text = Properties.Settings.Default.LocalidadIDC;  // Valor por defecto / USUARIO CAMBIAR
            this.txtProveedor.Text = Distribuidor;
            this.cBoxImpresora.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void EnviarCorreo(StringBuilder Mensaje, string De, string Para, string Asunto, out string Error, List<string> Adjuntos, bool useBackupMethod = false)
        {
            #region ENVIO DE CORREO DE LA SOLICITUD
            Error = "";

            // Pie de pagina del mensaje - Modificar para que contenga la firma personalizada del usuario
            Mensaje.Append(Environment.NewLine);
            Mensaje.Append(string.Format("Este correo ha sido enviado usando RIT Solver For IDC"));
            Mensaje.Append(Environment.NewLine);

            if (!useBackupMethod)
            {
                #region
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(De);
                    mail.To.Add(Para);
                    mail.Subject = Asunto;
                    mail.Body = Mensaje.ToString();

                    foreach (string archivos in Adjuntos)
                    {
                        mail.Attachments.Add(new Attachment(archivos));
                    }

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

                    return;
                }
                #endregion
            }
            else
            {
                #region
                try
                {
                    // Añadimos las direcciones a enviar
                    string direcciones_destinos = Para;
                    // Codificar los valores para que sean válidos en una URL
                    string asuntoCodificado = Uri.EscapeDataString(Asunto);
                    string cuerpoCodificado = Uri.EscapeDataString(Mensaje.ToString());

                    // Crear la URL mailto
                    string mailto = $"mailto:{direcciones_destinos}&subject={asuntoCodificado}&body={cuerpoCodificado}";

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
            #endregion
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            #region ENVIAMOS EL CORREO - METODO
            if (this.chckBoxAmarillo.Checked == false & this.chckBoxCyan.Checked == false & this.chckBoxMagenta.Checked == false & this.chckBoxNegro.Checked == false)
            {
                RJMessageBox.Show("Debes seleccionar almenos una tinta para solicitar!", "Solicitar Toner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                if (!String.IsNullOrEmpty(this.txtAsuntoPt_DOS.Text))
                {
                    this.txtAsuntoPt_UNO.Text = this.txtAsuntoPt_UNO.Text + " // ";
                }

                string Asunto_FULL = this.txtAsuntoPt_UNO.Text + this.txtAsuntoPt_DOS.Text;
                string failure = "";

                StringBuilder mensaje = new StringBuilder();
                mensaje.Append(this.rtBoxMensaje.Text);
                mensaje.Append(Environment.NewLine);
                mensaje.Append(Environment.NewLine);
                mensaje.Append("================== [ INFORMACION ] ==================\n");
                mensaje.Append(Environment.NewLine);
                mensaje.Append("SOLICITO LOS SIGUIENTES TONERS CON LA SIGUIENTE CANTIDAD:");
                mensaje.Append(Environment.NewLine);
                if (this.chckBoxCyan.Checked == true) { mensaje.Append($"* Cyan: {this.numericCantidadCyan.Value}"); mensaje.Append(Environment.NewLine); }
                if (this.chckBoxMagenta.Checked == true) { mensaje.Append($"* Magenta: {this.numericCantidadMagenta.Value}"); mensaje.Append(Environment.NewLine); }
                if (this.chckBoxAmarillo.Checked == true) { mensaje.Append($"* Amarillo: {this.numericCantidadAmarillo.Value}"); mensaje.Append(Environment.NewLine); }
                if (this.chckBoxNegro.Checked == true) { mensaje.Append($"* Negro: {this.numericCantidadNegro.Value}"); mensaje.Append(Environment.NewLine); }
                mensaje.Append($"IMPRESORA: {this.cBoxImpresora.Text}" +
                    Environment.NewLine +
                    $"MODELO: {this.txtModelo.Text}" +
                    Environment.NewLine +
                    $"LOCALIDAD: {this.txtLocalidad.Text}" +
                    Environment.NewLine);

                if (RJMessageBox.Show("¿Seguro que desea enviar este correo electronico?", "Confirmacion de envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnviarCorreo(mensaje, Usuario, this.txtProveedor.Text, Asunto_FULL, out failure, array_adjuntos, true);
                    this.Close();
                }
            }
            #endregion
        }

        private void btnAñadirAdjunto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    listAdjuntos.Items.Add(Path.GetFileName(path));
                    array_adjuntos.Add(path);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error de programacion: " + Environment.NewLine + Environment.NewLine + "El programa indica" + Environment.NewLine + ex, "Error - Informe al programador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxImpresora_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IMPRESORA = this.cBoxImpresora.Text;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                int strFila = Row.Index;
                string valor = Convert.ToString(Row.Cells["Impresora"].Value);
                
                if (valor.Trim() == this.cBoxImpresora.Text.Trim())
                {
                    //RJMessageBox.Show(dataGridView1.Rows[strFila].Cells["Modelo"].Value.ToString(), "FALLA");
                    this.txtModelo.Text = dataGridView1.Rows[strFila].Cells["Modelo"].Value.ToString();
                    this.txtLocalidad.Text = dataGridView1.Rows[strFila].Cells["Ubicacion"].Value.ToString();

                    this.txtAsuntoPt_UNO.Text = $"SOLICITUD DE REPOSICION DE TONER// Impresora: {IMPRESORA}";
                }
            }
        }

        private void solicitar_toner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try {
                if (this.numericCantidadCyan.Enabled)
                {
                    this.numericCantidadCyan.Value += 1;
                }
                if (this.numericCantidadMagenta.Enabled)
                {
                    this.numericCantidadMagenta.Value += 1;
                }
                if (this.numericCantidadAmarillo.Enabled)
                {
                    this.numericCantidadAmarillo.Value += 1;
                }
                if (this.numericCantidadNegro.Enabled)
                {
                    this.numericCantidadNegro.Value += 1;
                }
            } catch (Exception ex)
            {

            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.numericCantidadCyan.Enabled)
                {
                    this.numericCantidadCyan.Value -= 1;
                }
            } catch (Exception ex) { }

            try
            {
                if (this.numericCantidadMagenta.Enabled)
                {
                    this.numericCantidadMagenta.Value -= 1;
                }
            } catch (Exception ex) { }

            try
            {
                if (this.numericCantidadAmarillo.Enabled)
                {
                    this.numericCantidadAmarillo.Value -= 1;
                }
            } catch (Exception ex) { }

            try
            {
                if (this.numericCantidadNegro.Enabled)
                {
                    this.numericCantidadNegro.Value -= 1;
                }
            } catch (Exception ex) { }

        }

        void _ValidateAllTonersSelected()
        {
            if (chckBoxCyan.Checked && chckBoxMagenta.Checked && chckBoxAmarillo.Checked && chckBoxNegro.Checked)
            {
                this.chckboxTodos.Checked = true;
            } else
            {
                this.chckboxTodos.Checked = false;
            }
        }

        private void chckBoxCyan_CheckedChanged(object sender, EventArgs e)
        {
            this.numericCantidadCyan.Enabled = chckBoxCyan.Checked;
            _ValidateAllTonersSelected();
        }

        private void chckBoxMagenta_CheckedChanged(object sender, EventArgs e)
        {
            this.numericCantidadMagenta.Enabled = chckBoxMagenta.Checked;
            _ValidateAllTonersSelected();
        }

        private void chckBoxAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            this.numericCantidadAmarillo.Enabled = chckBoxAmarillo.Checked;
            _ValidateAllTonersSelected();
        }

        private void chckBoxNegro_CheckedChanged(object sender, EventArgs e)
        {
            this.numericCantidadNegro.Enabled = chckBoxNegro.Checked;
            _ValidateAllTonersSelected();
        }

        private void chckboxTodos_CheckedChanged(object sender, EventArgs e)
        {
            bool val = false;

            if (this.chckboxTodos.Checked)
            {
                val = true;
            }

            this.chckBoxCyan.Checked = val;
            this.chckBoxMagenta.Checked = val;
            this.chckBoxAmarillo.Checked = val;
            this.chckBoxNegro.Checked = val;
        }
    }
}
