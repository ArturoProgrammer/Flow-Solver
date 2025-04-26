using System;
using System.Windows.Forms;
using System.IO;

using CustomMessageBox;
using System.Diagnostics;
using System.Threading;
using DocumentFormat.OpenXml.Wordprocessing;

namespace RIT_Solver
{
    public partial class PrinterForm : Form
    {
        string DocumentURL;
        string Constructor;
        Form BaseForm;

        public PrinterForm(string DocumentPath, string aConstructor, Form LegacyForm)
        {
            InitializeComponent();
            DocumentURL = DocumentPath;
            Constructor = aConstructor;
            BaseForm = LegacyForm;

            if (Properties.Settings.Default.SYSDATA_MetodoDeImpresionPorDefecto == "WebView2")
            {
                // Inicializar WebView2
                //webView21.NavigationCompleted += webView21_NavigationCompleted;
                webView21.EnsureCoreWebView2Async(null);
            } else
            {
                // En caso de tener seleccionado el metodo de impresion de Windows por defecto
                PrintPdfWithNormalMethod(DocumentPath);
            }
        }

        public void PrintPdfWithNormalMethod(string rutaPdf)
        {
            try
            {
                using (PrintDialog Dialog = new PrintDialog())
                {
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                        {
                            Verb = "print",
                            CreateNoWindow = true,
                            FileName = rutaPdf,
                            WindowStyle = ProcessWindowStyle.Normal
                        };

                        Process printProcess = new Process();
                        printProcess.StartInfo = printProcessInfo;
                        printProcess.Start();

                        printProcess.WaitForInputIdle();

                        Thread.Sleep(3000);

                        if (false == printProcess.CloseMainWindow())
                        {
                            printProcess.Kill();
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al imprimir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PrinterForm_Load(object sender, EventArgs e)
        {
            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{this.Name}'", "oka");

            CommonMethodsLibrary.OutMessage("in", this.Name, $@"PROCESANDO TRABAJO '{DocumentURL}'", "inf");

            try
            {
                this.Text += " - " + DocumentURL;

                CommonMethodsLibrary.OutMessage("in", this.Name, $@"ARCHIVO '{DocumentURL}' CARGADO EN VISUALIZADOR PARA IMPRESION", "OKA");
            }
            catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"ERROR INESPERADO EN EL PROCESO DE DESCARGA. EL PROGRAMA DICE: '{ex.ToString()}'", "EXC");

                RJMessageBox.Show(ex.ToString());
            }
        }


        private void PrinterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Constructor == "rit_mdi_form")
            {
                if (!Properties.Settings.Default.SYSDATA_GUARDARRITENPDF)
                {
                    if (File.Exists(DocumentURL))
                    {
                        File.Delete(DocumentURL);
                        CommonMethodsLibrary.OutMessage("Out", this.Name, $"SE ELIMINO EL ARCHIVO {DocumentURL} PARA EL MANDANTE {Constructor}", "oka");
                    }
                }

                // Actualizamos el valor de propiedad de impresion
                rit_mdi_form frm = (rit_mdi_form)BaseForm;
                frm.IsRitAlreadyPrinted = true;
                frm.linklblRitImpreso.Text = frm.IsRitAlreadyPrinted.ToString();
                frm.UpdateNodeColorByProgress();
            } else if (Constructor == "datos_equipo")
            {
                if (Properties.Settings.Default.SYSDATA_GUARDARRESGUARDOPDF == false)
                {
                    if (File.Exists(DocumentURL))
                    {
                        File.Delete(DocumentURL);
                        CommonMethodsLibrary.OutMessage("Out", this.Name, $"SE ELIMINO EL ARCHIVO {DocumentURL} PARA EL MANDANTE {Constructor}", "oka");
                    }
                }
            } else if (Constructor == "inventarios")
            {
                if (File.Exists(DocumentURL))
                {
                    File.Delete(DocumentURL);
                    CommonMethodsLibrary.OutMessage("Out", this.Name, $"SE ELIMINO EL ARCHIVO {DocumentURL} PARA EL MANDANTE {Constructor}", "oka");

                }
            } else if (Constructor == "actividads_mdi_form")
            {
                if (!Properties.Settings.Default.SYSDATA_GUARDARRITENPDF)
                {
                    if (File.Exists(DocumentURL))
                    {
                        File.Delete(DocumentURL);
                        CommonMethodsLibrary.OutMessage("Out", this.Name, $"SE ELIMINO EL ARCHIVO {DocumentURL} PARA EL MANDANTE {Constructor}", "oka");
                    }

                    // Actualizmaos los valores de historicos de reportes
                    actividades_mdi_form frm = (actividades_mdi_form)BaseForm;
                    //frm.UpdateMensualStatics();
                }
            } else
            {
                CommonMethodsLibrary.OutMessage("Out", this.Name, $"NO SE ELIMINARA EL ARCHIVO PARA EL MANDANTE {Constructor}", "inf");
            }

            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE CERRO EL FORMULARIO '{this.Name}'", "INF");
        }

        private void PrinterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                webView21.CoreWebView2.Navigate("file:///" + DocumentURL);
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.SYSDATA_HabilitarMetodoDeImpresionSecundarioAutomaticamente)
                {
                    PrintPdfWithNormalMethod(DocumentURL);
                } else
                {
                    MessageBox.Show($"Ha ocurrido un error inesperado a la hora de cargar el documento.\n{ex.Message}\n\n{ex}\n\nPara saltar este error, asegurate de tener activada la configuarion 'Habilitar metodo de impresio secundario automatico en caso de fallo con WebView2'.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}
