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

namespace RIT_Solver
{
    public partial class pdf_viewer : Form
    {
        private string doc_path = "";
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aConstructor"></param>
        /// <param name="Path"></param>
        public pdf_viewer(string aConstructor, string Path)
        {
            InitializeComponent();

            this.Text = "PDF Viewer";
            this.btnCerrar.Visible = false;

            try
            {
                webView21.EnsureCoreWebView2Async(null);
                if (aConstructor == "actividades_mdi_form")
                {
                    this.Text = this.Text + $" - {Path}";
                    if (File.Exists(Path))
                    {
                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"EJECUTRANDO ARCHIVO '{Path}' PARA EL MANDANTE '{aConstructor}'", "oka");

                        doc_path = Path;
                    }
                    else
                    {
                        // INFORMAR DE ERROR POR ARCHIVO NO ENCONTRADO

                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"NO EXISTE EL ARCHIVO '{Path}' PARA EL MANDANTE '{aConstructor}'", "ERR");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public pdf_viewer(string aConstructor)
        {
            InitializeComponent();

            this.Text = "PDF Viewer";
            this.btnCerrar.Visible = false;

            try
            {
                webView21.EnsureCoreWebView2Async(null);


                if (aConstructor == "organigrama_compusof")
                {
                    this.Text = this.Text + " - Organigrama de contacto Compusof 2022";
                    if (File.Exists($@"{Application.StartupPath}\ORGANIGRAMA 2022.pdf"))
                    {
                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"EJECUTRANDO ARCHIVO '{Application.StartupPath}\ORGANIGRAMA 2022.pdf' PARA EL MANDANTE '{aConstructor}'", "oka");

                        doc_path = $@"{Application.StartupPath}\ORGANIGRAMA 2022.pdf";
                    }
                    else
                    {
                        // INFORMAR DE ERROR POR ARCHIVO NO ENCONTRADO

                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"NO EXISTE EL ARCHIVO '{Application.StartupPath}\ORGANIGRAMA 2022.pdf' PARA EL MANDANTE '{aConstructor}'", "ERR");
                    }
                }
                else if (aConstructor == "organigrama_de_escalado")
                {
                    // Descomentar una vez que se hayan creado el archivo especifico

                    //this.Text = this.Text + " - Organigrama para el escalado de reportes";
                    //if (File.Exists($@"{Application.StartupPath}\ORGANIGRAMA DE ESCALADO 2022.pdf"))
                    //{
                    //    CommonMethodsLibrary.OutMessage("in", this.Name, $@"EJECUTRANDO ARCHIVO '{Application.StartupPath}\ORGANIGRAMA DE ESCALADO 2022.pdf' PARA EL MANDANTE '{aConstructor}'", "oka");

                    //    this.axAcroPDF1.LoadFile($@"{Application.StartupPath}\ORGANIGRAMA DE ESCALADO 2022.pdf");
                    //}
                    //else
                    //{
                    //    // INFORMAR DE ERROR POR ARCHIVO NO ENCONTRADO
                    //    CommonMethodsLibrary.OutMessage("in", this.Name, $@"NO EXISTE EL ARCHIVO '{Application.StartupPath}\ORGANIGRAMA DE ESCALADO 2022.pdf' PARA EL MANDANTE '{aConstructor}'", "ERR");
                    //}
                }
                else if (aConstructor == "manual_de_usuario")
                {
                    this.Text = this.Text + " - Manual de usuario de la aplicacion";
                    if (File.Exists($@"{Application.StartupPath}\RIT Solver - Guia de Usuario.pdf"))
                    {
                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"EJECUTRANDO ARCHIVO '{Application.StartupPath}\RIT Solver - Guia de Usuario.pdf' PARA EL MANDANTE '{aConstructor}'", "oka");

                        doc_path = $@"{Application.StartupPath}\RIT Solver - Guia de Usuario.pdf";
                    }
                    else
                    {
                        // INFORMAR DE ERROR POR ARCHIVO NO ENCONTRADO
                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"NO EXISTE EL ARCHIVO '{Application.StartupPath}\RIT Solver - Guia de Usuario.pdf' PARA EL MANDANTE '{aConstructor}'", "ERR");

                    }
                }
                else
                {
                    CommonMethodsLibrary.OutMessage("in", this.Name, $"NO EXISTE EL ARCHIVO SOLICITADO PARA EL MANDANTE '{aConstructor}'", "err");
                }
            } catch (Exception ex)
            {
                RJMessageBox.Show("Se requiere tener instalado Adobe Acrobat Reader! porfavor valide que se encuentre instalado en su sistema o de lo contrario instalelo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pdf_viewer_Load(object sender, EventArgs e)
        {
            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{this.Name}'", "oka");
        }

        private void pdf_viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonMethodsLibrary.OutMessage("out", this.Name, $"CIERRE DE FORMULARIO '{this.Name}'", "inf");

        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                webView21.CoreWebView2.Navigate("file:///" + doc_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de cargar el documento.\n{ex.Message}\n\n{ex.ToString()}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
