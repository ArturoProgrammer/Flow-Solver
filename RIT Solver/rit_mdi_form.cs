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

using iTextSharp.text.pdf;          // LIBRERIA ENCARGADA DE ESCRITURA EN FORMULARIOS PDF
using iTextSharp.text;              // LIBRERIA ENCARGADA DE ESCRITURA EN FORMULARIOS PDF

using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using CustomMessageBox;

using Microsoft.VisualBasic;
using SpreadsheetLight;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Web.Configuration;
using FuzzyString;
using System.Net;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Drawing.Charts;
using System.Linq.Expressions;
using DocumentFormat.OpenXml.Drawing.Diagrams;
//using DocumentFormat.OpenXml.Spreadsheet;
//using DocumentFormat.OpenXml.Wordprocessing;

namespace Flow_Solver
{
    public partial class rit_mdi_form : Form
    {
        #region BANDERAS Y VARIABLES GLOBALES
        public string dia_reporte = "";
        public string mes_reporte = "";
        public string año_reporte = "";

        string dia_servicio = "";
        string mes_servicio = "";
        string año_servicio = "";

        string path_rit_destiny;

        string ACCION_LINEA1 = "";
        string ACCION_LINEA2 = "";
        string ACCION_LINEA3 = "";
        string ACCION_LINEA4 = "";
        string ACCION_LINEA5 = "";
        string ACCION_LINEA6 = "";
        string ACCION_LINEA7 = "";

        bool IF_PROJ_SAVED;
        string BTN_DEFAULT_FN;
        bool IMP_PROJ = false;

        /// <summary>
        /// Esta es la ruta por defecto del proyecto en caso de que se ejecute el constructor de abrir proyecto existente
        /// </summary>
        string LEGACY_PROJECTJSON_PATH = "";

        internal RitJsonProject ActualProject = new RitJsonProject();

        // VARIABLES DE IDENTIFICADORES GLOBALES
        /// <summary>
        /// GUID del MDI actual
        /// </summary>
        public int MDI_ID = CommonMethodsLibrary.IdentifierGenerator();

        /// <summary>
        /// Ticket generado en ServiceDesk
        /// </summary>
        public bool IsAlreadyTicketGenerated { get; set; } = false;
        /// <summary>
        /// Ticket impreso
        /// </summary>
        public bool IsRitAlreadyPrinted { get; set; } = false;
        /// <summary>
        /// Ticket firmado por el usuario
        /// </summary>
        public bool IsRitAlreadySigned { get; set; } = false;
        /// <summary>
        /// Ticket comprobado en Forms
        /// </summary>
        public bool IsRitAlreadyComprobado { get; set; } = false;
        #endregion

        #region METODOS PROPIOS
        /* ===================[ INICIO / METODO DEL LLENADO DE LA IMPRESION ]=================== */
        /// <summary>
        /// Generamos el archivo PDF y lo llenamos con la informacion del objeto proporcionada
        /// </summary>
        /// <returns>Retorna el PATH del PDF llenado</returns>
        private string FillPDFForm()
        {
            #region CODIGO PARA EL LLENADO DE LOS FORMULARIOS RIT PDF
            /*

            try
            {
                Properties.Settings.Default.NoDeReporte = this.txtNoDeReporteDelCliente.Text;

                string out_name;
                // Nombre de salida del archivo
                if (this.txtNoDeReporteDelCliente.Text == string.Empty)
                {
                    out_name = this.cboxUsuariofinal.Text + " - " + this.txtFallaReportada.Text;
                }
                else
                {
                    out_name = $"{Properties.Settings.Default.NoDeReporte} - {this.cboxUsuariofinal.Text} - {this.txtFallaReportada.Text}";
                }

                string pdfRITTemplate = Properties.Settings.Default.RITFormPath;
                string newFile = $@"{path_rit_destiny}\{out_name}.pdf";
                ActualProject.PdfPath = newFile;    // Establecemos el PATH de salida del proyecto

                PdfReader pdfReader = new PdfReader(pdfRITTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));    // Documento de salida



                AcroFields pdfFormFilelds = pdfStamper.AcroFields;

                // Se escribe la informacion del reporte
                pdfFormFilelds.SetField("Centro de Servicio", this.txtCentroDeServicios.Text);
                pdfFormFilelds.SetField("No Reporte del Cliente", $"   #{this.txtNoDeReporteDelCliente.Text}");
                pdfFormFilelds.SetField("ContadorDeFolio", this.richTextBoxContadorDeRIT.Text);
                pdfFormFilelds.SetField("DD1", dia_reporte);
                pdfFormFilelds.SetField("MM1", mes_reporte);
                pdfFormFilelds.SetField("YY1", año_reporte);
                pdfFormFilelds.SetField("Hora de Reporte", this.txtHora.Text);
                pdfFormFilelds.SetField("Min de Reporte", this.txtMinuto.Text);
                pdfFormFilelds.SetField("Tipo de Equipo", this.txtTipoDeEquipo.Text);
                pdfFormFilelds.SetField("Marca", this.txtMarca.Text);
                pdfFormFilelds.SetField("Modelo", this.txtModelo.Text);
                pdfFormFilelds.SetField("No de Serie", this.txtNoDeSerie.Text);
                pdfFormFilelds.SetField("Cliente", this.txtCliente.Text);
                pdfFormFilelds.SetField("Sucursal", this.txtSucursal.Text);
                pdfFormFilelds.SetField("No Suc", this.txtNoDeSucursal.Text);
                pdfFormFilelds.SetField("Dirección", this.txtDireccion.Text);
                pdfFormFilelds.SetField("Población", this.cboxPoblacion.Text);
                pdfFormFilelds.SetField("Usuario Final", this.cboxUsuariofinal.Text);
                pdfFormFilelds.SetField("Departamento", this.txtDepartamento.Text);
                pdfFormFilelds.SetField("No de Empleado", this.txtNoDeEmpleado.Text);
                pdfFormFilelds.SetField("Tel", this.txtTelefono.Text);
                pdfFormFilelds.SetField("Técnico", this.txtTecnico.Text);
                //pdfFormFilelds.SetField("Firma");
                pdfFormFilelds.SetField("Falla reportada", this.txtFallaReportada.Text);

                // Se escriben las refacciones utilizadas
                if (this.txtRefaccionesUtilizadas.Enabled == true)
                {
                    pdfFormFilelds.SetField("Refacciones Utilizadas", this.txtRefaccionesUtilizadas.Text);
                }

                // Se marca reporte cerrado o pendiente
                if (rbtnReporteCerradoSi.Checked)
                {
                    pdfFormFilelds.SetField("Cerrado Si", "X");
                }
                else if (rbtnReporteCerradoNo.Checked)
                {
                    pdfFormFilelds.SetField("Cerrado No", "X");
                    pdfFormFilelds.SetField("Motivo de Pendiente", this.txtCausasDeNoCierre.Text);
                }

                // Fecha de atencion del reporte
                pdfFormFilelds.SetField("DD2", dia_servicio);
                pdfFormFilelds.SetField("MM2", mes_servicio);
                pdfFormFilelds.SetField("YY2", año_servicio);

                // Se llenan los campos de horas
                pdfFormFilelds.SetField("HH1", this.txtHoraInicioTraslado.Text);
                pdfFormFilelds.SetField("MN1", this.txtMinutoInicioTraslado.Text);

                pdfFormFilelds.SetField("HH2", this.txtHoraLlegada.Text);
                pdfFormFilelds.SetField("MN2", this.txtMinutoLlegada.Text);

                pdfFormFilelds.SetField("HH3", this.txtHoraDeComienzo.Text);
                pdfFormFilelds.SetField("MN3", this.txtMinutoDeComienzo.Text);

                pdfFormFilelds.SetField("HH4", this.txtHoraDeTermino.Text);
                pdfFormFilelds.SetField("MN4", this.txtMinutoDeTermino.Text);

                pdfFormFilelds.SetField("HH5", this.txtHoraDeEspera.Text);
                pdfFormFilelds.SetField("MN5", this.txtMinutoDeEspera.Text);

                pdfFormFilelds.SetField("HH6", this.txtHoraDeRetorno.Text);
                pdfFormFilelds.SetField("MN6", this.txtMinutoDeRetorno.Text);

                // Acciones tomadas para la resolucion del reporte
                ACCION_LINEA1 = this.txtLinea1.Text;
                ACCION_LINEA2 = this.txtLinea2.Text;
                ACCION_LINEA3 = this.txtLinea3.Text;
                ACCION_LINEA4 = this.txtLinea4.Text;
                ACCION_LINEA5 = this.txtLinea5.Text;
                ACCION_LINEA6 = this.txtLinea6.Text;
                ACCION_LINEA7 = this.txtLinea7.Text;

                pdfFormFilelds.SetField("ACT_LINEA1", ACCION_LINEA1);
                pdfFormFilelds.SetField("ACT_LINEA2", ACCION_LINEA2);
                pdfFormFilelds.SetField("ACT_LINEA3", ACCION_LINEA3);
                pdfFormFilelds.SetField("ACT_LINEA4", ACCION_LINEA4);
                pdfFormFilelds.SetField("ACT_LINEA5", ACCION_LINEA5);
                pdfFormFilelds.SetField("ACT_LINEA6", ACCION_LINEA6);
                pdfFormFilelds.SetField("ACT_LINEA7", ACCION_LINEA7);

                // Cambia la propiedad para que no se pueda editar el PDF
                //pdfStamper.FormFlattening = false;

                // Cierra el PDF
                pdfStamper.Close();

                // ACTUALIZAMOS EL CONTADOR DE RIT
                Properties.Settings.Default.RITCounter += 1;

                // Firmamos si esta habilitado
                if (Properties.Settings.Default.SYSDATA_FIRMA_HABILITADA)
                {
                    //iTextSharp.text.Image firma = iTextSharp.text.Image.GetInstance(Properties.Settings.Default.FirmaIDCPath);
                    //firma.ScalePercent(24f);
                    //firma.SetAbsolutePosition(2f, 2f);

                    //Document doc = new Document();
                    //PdfWriter.GetInstance(doc, new FileStream(newFile, FileMode.Open));
                    //doc.Open();

                    //doc.Add(firma);
                    //doc.Close();
                }

                Properties.Settings.Default.Save();

                //Abrir el documento desde su ruta
                //System.Diagnostics.Process.Start(newFile);

                //string sTmp = $"Datos asignados ticket {out_name}.pdf guardado con exito!";
                //RJMessageBox.Show(sTmp, "Formulario RIT PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateJobStatus(true, "Formato RIT guardado en PDF!");

                // Informamos a la grabadora de eventos
                string targetPath = $@"{Application.StartupPath}\Inventories\{txtHostname.Text}{MachineEventsHistorial.FileSuffix}";
                MachineEventsHistorial rec = new MachineEventsHistorial(targetPath);
                rec.AddEvent(M_EventItem.FromTemplate_AttendedReport(this.richTextBoxContadorDeRIT.Text, this.txtFallaReportada.Text, this.txtNoDeReporteDelCliente.Text));
                rec.Save();
            }
            catch (Exception ex)
            {
                UpdateJobStatus(false, $"{ex.Message}");
            }
            */
            #endregion

            /* SE INGRESA LA FOTO DE LA FIRMA DEL IDC */
            // ===========> HACER

            return ActualProject.PdfPath;
        }
        /* ===================[ FIN / METODO DEL LLENADO DE LA IMPRESION ]=================== */

        /* ===================[ INICIO / METODO DEL PROCESOS DE IMPRESION ]=================== */
        #region METODOS DE IMPRESION / APLICADO ACTUALMENTE: printPDFWithAcrobat
        public void printPDFWithAcrobat(string path)
        {
            try
            {
                /*
                string out_name;

                if (this.txtNoDeReporteDelCliente.Text == string.Empty)
                {
                    out_name = this.cboxUsuariofinal.Text + " - " + this.txtFallaReportada.Text;
                }
                else
                {
                    out_name = $"#{Properties.Settings.Default.NoDeReporte} - {this.cboxUsuariofinal.Text} - {this.txtFallaReportada.Text}";
                }

                string newFile = path_rit_destiny + $@"{out_name}.pdf";
                string Filepath = newFile;
                */

                PrinterForm frm = new PrinterForm(path, "rit_mdi_form", this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("No podemos imprimir el formato PDF desde la App! asegurese de que Adobe Acrobat Reader se encuentre instalado en el equipo y vuelva a intentarlo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        /* ===================[ FIN / METODO DEL PROCESOS DE IMPRESION ]=================== */


        // Apertura de proyectos existentes
        private void OpenRITProjects(RitJsonProject json)
        {
            // DESERIALIZACION DEL JSON
            try
            {
                #region CARGA LOS DATOS DEL PROYECTO AL FORMULARIO
                /*
                txtNombreDelProyecto.Text = json.NombreProyecto;
                richTextBoxContadorDeRIT.Text = json.NoFolio;
                txtFallaReportada.Text = json.Falla;
                
                txtNoDeReporteDelCliente.Text = json.NoTicket;
                txtTipoDeEquipo.Text = json.TipoEquipo;
                txtMarca.Text = json.Marca;
                txtModelo.Text = json.Modelo;
                txtNoDeSerie.Text = json.NoSerie;
                txtCliente.Text = json.Cliente;
                txtHora.Text = json.FechaDeGeneracionReporte.Hour.ToString();
                txtMinuto.Text = json.FechaDeGeneracionReporte.Minute.ToString();
                txtSucursal.Text = json.Sucursal;
                txtNoDeSucursal.Text = json.NoSucursal;
                txtDireccion.Text = json.Direccion;
                cboxPoblacion.Text = json.Poblacion;
                cboxUsuariofinal.Text = json.UsuarioFinal;
                txtDepartamento.Text = json.Departamento;
                txtNoDeEmpleado.Text = json.NoEmpleado;
                txtTelefono.Text = json.Telefono;
                txtCentroDeServicios.Text = json.CentroServicios;
                txtTecnico.Text = json.Tecnico;

                DateTime date = json.FechaDeGeneracionReporte;
                //this.lblFechaDeReporte.Text = $"{dia_reporte} / {mes_reporte} / {año_reporte}";
                calendarFecha.SetDate(date);
                */
                /** INFORMACION DEL TRABAJO Y FINALIZACION **/
                if (json.UsaronRefacciones)
                {
                    this.rbtnRefaccionesSi.Checked = true;
                }
                else
                {
                    this.rbtnRefaccionesNo.Checked = true;
                }
                txtHoraInicioTraslado.Text = json.HoraInicioTraslado;
                txtMinutoInicioTraslado.Text = json.MinutoInicioTraslado;

                txtHoraLlegada.Text = json.HoraLlegada;
                txtMinutoLlegada.Text = json.MinutoLlegada;

                txtHoraDeComienzo.Text = json.HoraComienzo;
                txtMinutoDeComienzo.Text = json.MinutoComienzo;

                txtHoraDeTermino.Text = json.HoraTermino;
                txtMinutoDeTermino.Text = json.MinutoTermino;

                txtHoraDeEspera.Text = json.HoraEspera;
                txtMinutoDeEspera.Text = json.MinutoEspera;

                txtHoraDeRetorno.Text = json.HoraRetorno;
                txtMinutoDeRetorno.Text = json.MinutoRetorno;

                if (json.ReporteCerrado)
                {
                    this.rbtnReporteCerradoSi.Checked = true;
                }
                else
                {
                    this.rbtnReporteCerradoNo.Checked = true;
                }

                DateTime date_atencion = json.FechaDeAtencion;
                //this.lblFechaDeServicio.Text = $"{dia_atencion} / {mes_atencion} / {año_atencion}";
                calendarFechaDeServicio.SetDate(date_atencion);

                /** ACCIONES TOMADAS **/
                this.txtLinea1.Text = json.AccionesRealizadas[0];
                this.txtLinea2.Text = json.AccionesRealizadas[1];
                this.txtLinea3.Text = json.AccionesRealizadas[2];
                this.txtLinea4.Text = json.AccionesRealizadas[3];
                this.txtLinea5.Text = json.AccionesRealizadas[4];
                this.txtLinea6.Text = json.AccionesRealizadas[5];
                this.txtLinea7.Text = json.AccionesRealizadas[6];

                IsAlreadyTicketGenerated = json.IsAlreadyTicketGenerated;
                IsRitAlreadyPrinted = json.IsRitAlreadyPrinted;
                IsRitAlreadySigned = json.IsRitAlreadySigned;
                IsRitAlreadyComprobado = json.IsRitAlreadyComprobado;

                this.txtHostname.Text = json.Hostname;

                UpdateJobStatus(true, "Proyecto cargado con exito!");
                #endregion
            }
            catch (Exception ex)
            {
                UpdateJobStatus(false, $"{ex.Message}");
            }
        }

        #region METODO DE ESTADO Y MENSAJE DEL TRABAJO ACTUAL
        public void UpdateJobStatus(bool JobOK, string JobMessage)
        {
            if (JobOK)
            {
                // toolJobStatus
                this.toolJobStatus.Text = "Todo listo!";
                this.toolJobStatus.Image = Properties.Resources.check;
                // toolJobMessage
                this.toolJobMessage.ForeColor = System.Drawing.Color.Green;
                this.toolJobMessage.Text = JobMessage;
            }
            else
            {
                // toolJobStatus
                this.toolJobStatus.Text = "Error de trabajo!";
                this.toolJobStatus.Image = Properties.Resources.error;
                // toolJobMessage
                this.toolJobMessage.ForeColor = System.Drawing.Color.Red;
                this.toolJobMessage.Text = JobMessage;
            }
        }
        #endregion

        #region ACTUALIZACION DEL COLOR DE NODOS SEGUN EL AVANCE DEL RIT
        public void UpdateNodeColorByProgress()
        {
            Color generated = Color.FromKnownColor(KnownColor.DarkRed);
            Color printed = Color.FromKnownColor(KnownColor.Orange);
            Color signed = Color.FromKnownColor(KnownColor.Highlight);
            Color proved = Color.FromKnownColor(KnownColor.Green);

            if (IsAlreadyTicketGenerated)
            {
                foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                {
                    if (node.Name == MDI_ID.ToString())
                    {
                        node.ForeColor = generated;
                        break;
                    }

                }
            }

            if (IsRitAlreadyPrinted)
            {
                foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                {
                    if (node.Name == MDI_ID.ToString())
                    {
                        node.ForeColor = printed;
                        node.ImageIndex = 3;
                        node.SelectedImageIndex = 3;
                        break;
                    }
                }

                if (IsRitAlreadySigned)
                {
                    // Pintamos...
                    foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                    {
                        if (node.Name == MDI_ID.ToString())
                        {
                            node.ForeColor = signed;
                            node.ImageIndex = 4;
                            node.SelectedImageIndex = 4;

                            break;
                        }
                    }

                    if (IsRitAlreadyComprobado)
                    {
                        foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                        {
                            if (node.Name == MDI_ID.ToString())
                            {
                                node.ForeColor = proved;
                                node.ImageIndex = 2;
                                node.SelectedImageIndex = 2;

                                break;
                            }

                        }
                    }
                    else
                    {
                        foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                        {
                            if (node.Name == MDI_ID.ToString())
                            {
                                node.ForeColor = signed;
                                node.ImageIndex = 4;
                                node.SelectedImageIndex = 4;

                                break;
                            }

                        }
                    }
                }
                else
                {
                    foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
                    {
                        if (node.Name == MDI_ID.ToString())
                        {
                            node.ForeColor = printed;
                            node.ImageIndex = 3;
                            node.SelectedImageIndex = 3;

                            break;
                        }

                    }
                }
            }


            MensualStadistics.ReportStData data = new MensualStadistics.ReportStData()
            {
                FallaReportada = this.txtFallaReportada.Text,
                NoDeFolio = this.flNumericUpDownLabelJoint1.Value.ToString(),
                NoDeReporte = !String.IsNullOrEmpty(this.txtNoReporte.Value.Trim()) ? $"#{txtNoReporte.Value}" : "",
                IsPrinted = this.IsRitAlreadyPrinted,
                IsGenerated = this.IsAlreadyTicketGenerated,
                IsSigned = this.IsRitAlreadySigned,
                IsProved = this.IsRitAlreadyComprobado,
                HASH = ActualProject.HASH
            };
            int a_year = Int32.Parse(this.calendarFechaDeServicio.SelectionStart.ToString("yyyy"));
            string a_month = this.calendarFechaDeServicio.SelectionStart.ToString("MMMM");
            MensualStadistics.UpdateMonthData(a_year, a_month, ActualProject.HASH, data);

        }
        #endregion
        #endregion

        public main padre;

        public rit_mdi_form(main LegacyForm)
        {
            CheckForIllegalCrossThreadCalls = true;
            InitializeComponent();
            padre = LegacyForm;

            AssignDate();

            #region SECCION DE PERFILES DE DATOS
            /*
                - Edicion de perfiles (nuevos y los existentes por default)
                - Creacion de perfiles por parte del usuario
             */
            this.cboxPerfiles.Items.Add("Default");             // Perfil por defecto
            this.cboxPerfiles.Items.Add("Mantenimiento");
            this.cboxPerfiles.Items.Add("------------ Agregar nuevo perfil ------------");

            // Carga de perfiles personalizados a la lista cboxPerfiles
            if (Directory.Exists(Application.StartupPath + @"\Profiles\"))
            {
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Profiles\");
                FileInfo[] files = di.GetFiles("*.json");
                foreach (FileInfo file in files)
                {
                    int s_len = file.Name.Length;

                    this.cboxPerfiles.Items.Add(file.Name.Remove(s_len - 5, 5));
                    this.perfilesToolStripMenuItem.DropDownItems.Add(file.Name.Remove(s_len - 5, 5));
                }
            }

            this.cboxPerfiles.SelectedIndex = 0;
            #endregion

            _LoadActualInventoryList();

            Properties.Settings.Default.RITCounter++;
            Properties.Settings.Default.Save();
            this.flNumericUpDownLabelJoint1.Value = Properties.Settings.Default.RITCounter;

            int counter = LegacyForm.treeViewProyectos.Nodes[0].Nodes.Count;
            string formText = $"Nuevo proyecto RIT {counter + 1}...";

            //padre.lblProyectos_Text.Visible = false;
            ActualProject.NombreProyecto = formText;    // Asignamos el nombre por defecto
            ActualProject.HASH = MDI_ID;                // Asignamos el HASH del proyecto en caso de ser nuevo

            this.Text = ActualProject.NombreProyecto;
            //this.txtNombreDelProyecto.Text = ActualProject.NombreProyecto;
        }


        public rit_mdi_form(main LegacyForm, string ProjectFilePath)
        {
            // Sobrecarga para abrir proyecto de ticket existente
            //MessageBox.Show(ProjectFilePath);
            InitializeComponent();
            padre = LegacyForm;
            LEGACY_PROJECTJSON_PATH = ProjectFilePath;
            ActualProject = RitJsonProject.LoadProject(LEGACY_PROJECTJSON_PATH);

            AssignDate();

            #region SECCION DE PERFILES DE DATOS
            /*
                - Edicion de perfiles (nuevos y los existentes por default)
                - Creacion de perfiles por parte del usuario
             */
            this.cboxPerfiles.Items.Add("Default");             // Perfil por defecto
            this.cboxPerfiles.Items.Add("Mantenimiento");
            this.cboxPerfiles.Items.Add("------------ Agregar nuevo perfil ------------");

            // Carga de perfiles personalizados a la lista cboxPerfiles
            if (Directory.Exists(Application.StartupPath + @"\Profiles\"))
            {
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Profiles\");
                FileInfo[] files = di.GetFiles("*.json");
                foreach (FileInfo file in files)
                {
                    int s_len = file.Name.Length;

                    this.cboxPerfiles.Items.Add(file.Name.Remove(s_len - 5, 5));
                    this.perfilesToolStripMenuItem.DropDownItems.Add(file.Name.Remove(s_len - 5, 5));
                }
            }

            this.cboxPerfiles.SelectedIndex = 0;
            #endregion

            _LoadActualInventoryList();

            IMP_PROJ = true;
            OpenRITProjects(ActualProject); // Carga el proyecto en el formulario
            this.Text = this.txtFallaReportada.Text + " - " + ProjectFilePath;
            //MessageBox.Show("PAUSA");

            //padre.lblProyectos_Text.Visible = false;
        }

        public void AssignDate()
        {
            #region CREAMOS EL DIRECTORIO CORRESPONDIENTE AL MES ACTUAL EN CURSO
            DateTime fechaActual = DateTime.Now;

            // CARGAR FECHA DE REPORTE
            año_reporte = fechaActual.Year.ToString();
            mes_reporte = fechaActual.ToString("MM");
            dia_reporte = fechaActual.ToString("dd");
            //this.lblFechaDeReporte.Text = $"{dia_reporte} / {mes_reporte} / {año_reporte}";

            // CARGAR DATOS DE FECHA DE ATENCION
            año_servicio = fechaActual.Year.ToString();
            mes_servicio = fechaActual.ToString("MM");
            dia_servicio = fechaActual.ToString("dd");
            //this.lblFechaDeServicio.Text = $"{dia_servicio} / {mes_servicio} / {año_servicio}";

            /* Establecemos los valores de la carpeta de trabajo del mes actual */
            string AÑO;
            string MES;
            string path;

            AÑO = fechaActual.Year.ToString();
            MES = fechaActual.ToString("MMMM");
            path = Properties.Settings.Default.RITFormPathDestiny + $@"\RITs\{AÑO}\{MES}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path_rit_destiny = path;
            #endregion
        }

        /// <summary>
        /// Carga en la grilla de local de datos el inventario actual
        /// </summary>
        void _LoadActualInventoryList()
        {
            // Cargamos los equipos del inventario al DGV del form
            #region CODIGO DE CARGA
            string INVENTORIES_DIR_PATH = $@"{Application.StartupPath}\Inventories";

            SLDocument sl;

            int iRow = 2;

            if (File.Exists($@"{INVENTORIES_DIR_PATH}\USUARIOS Y EQUIPOS.xlsx"))
            {
                try
                {
                    // Cargamos el archivo que se creo en base al molde con anterioridad
                    sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\USUARIOS Y EQUIPOS.xlsx");

                    List<InventarioViewModel> lst = new List<InventarioViewModel>();

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        InventarioViewModel oUsuario = new InventarioViewModel();

                        oUsuario.NOMBRE = sl.GetCellValueAsString(iRow, 1);
                        oUsuario.NumDeEmpleado = sl.GetCellValueAsString(iRow, 2);
                        oUsuario.EXT = sl.GetCellValueAsString(iRow, 3);
                        oUsuario.USER = sl.GetCellValueAsString(iRow, 4);
                        oUsuario.MAIL = sl.GetCellValueAsString(iRow, 5);
                        oUsuario.HOSTNAME = sl.GetCellValueAsString(iRow, 6);
                        oUsuario.TipoDeEquipo = sl.GetCellValueAsString(iRow, 7);
                        oUsuario.SN = sl.GetCellValueAsString(iRow, 8);
                        oUsuario.Marca = sl.GetCellValueAsString(iRow, 9);
                        oUsuario.Modelo = sl.GetCellValueAsString(iRow, 10);
                        oUsuario.Ubicacion = sl.GetCellValueAsString(iRow, 11);
                        oUsuario.Departamento = sl.GetCellValueAsString(iRow, 12);
                        oUsuario.Comentarios = sl.GetCellValueAsString(iRow, 13);

                        lst.Add(oUsuario);
                        iRow++;
                        this.toolJobStatus.Text = "Listo!";
                    }

                    dataGridViewInventarios.DataSource = lst;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex}");
                }
            }
            #endregion
        }

        private void rit_mdi_form_Load(object sender, EventArgs e)
        {
            #region METODO DE CARGA INICIAL
            #region CONFIGURACION DE LOS TEMAS
            //MessageBox.Show(MDI_ID.ToString());

            // DEJAR ASI HASTA APLICAR LOS METODOS DE ESTILOS
            this.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            #endregion

            //this.MaximumSize = Size;
            this.TopMost = true;
            BTN_DEFAULT_FN = "Imprimir y guardar PDF";
            this.toolMDI_ID.Text = MDI_ID.ToString();

            this.toolJobStatus.Text = "";
            this.toolJobMessage.Text = "";

            if (string.IsNullOrEmpty(Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT))
            {
                // Asignamos la localidad 'Direccion_default.json'
                Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT = "Direccion_default";
            }


            // Cargamos los datos de la localidad por defecto
            CommonMethodsLibrary.LoadDirection(Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT, this);

            /* CARGAMOS LOS USUARIOS DISPONIBLES EN EL INVENTARIO SEGUN LA LOCALIDAD QUE ESTEMOS MANEJANDO*/
            // LA FUNCION SE REALIZA EN SU METODO CORRESPONDIENTE


            /* CARGAMOS LAS LOCALIDADES DISPONIBLES EN EL INVENTARIO */
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {
                DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                FileInfo[] files = di.GetFiles("*.json");

                foreach (FileInfo file in files)
                {
                    JObject json = JObject.Parse(File.ReadAllText(file.FullName));
                    //this.cboxPoblacion.Items.Add(json["poblacion"]);
                }
            }


            string poblacion = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;
            int index = 0;
            /*
            foreach (var i in this.cboxPoblacion.Items)
            {
                if (i == poblacion)
                {
                    this.cboxPoblacion.SelectedIndex = index;
                }
                index++;
            }*/


            /* AÑADIMOS AL ARBOL DE NODOS */
            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes.Add(MDI_ID.ToString(), ActualProject.NombreProyecto);         // POR FACILIDAD SE ASIGNA EL MISMO VALOR DE NOMBRE Y CLAVE

            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].ContextMenuStrip = padre.contextMenuStripNodos;
            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].ImageIndex = 1;
            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].SelectedImageIndex = 1;
            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Expand();

            padre.lblNodoDeProyectosSeleccionado.Text = $"Mis Proyectos ({padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes.Count})";

            this.linklblTicketGeneradoEnSAS.Text = IsAlreadyTicketGenerated.ToString();
            this.linklblRitImpreso.Text = IsRitAlreadyPrinted.ToString();
            this.linklblRitFirmado.Text = IsRitAlreadySigned.ToString();
            this.linklblRitComprobado.Text = IsRitAlreadyComprobado.ToString();

            UpdateNodeColorByProgress();    // Actualizamos el color del nodo segun el estatus

            padre.toolLblActualMDIReporteName.Text = this.Text;
            #endregion

            // Minimizamos los anteriores a este
        }


        private void calendarFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show("Se cambio el valor de fecha del reporte");

            DateTime inicio = calendarFechaGeneracion.SelectionStart;

            string dia = inicio.Day.ToString();
            string mes = inicio.Month.ToString();
            string año = inicio.Year.ToString();

            this.lblFechaDeGeneracion.Label = $"{dia} / {mes} / {año}";

            dia_reporte = dia;
            mes_reporte = mes;
            año_reporte = año;
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCausasDeNoCierre.Enabled = true;
        }


        /* Cierre el proyecto actual */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"CIERRE DEL FORMULARIO RIT MDI ID: {this.MDI_ID}", "INF");

                this.Close();
            }
        }

        private void sistemaDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventarios frm = new inventarios(this);

            CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ABRE EL FORMS DE INVENTARIOS", "INF");
            frm.ShowDialog();
        }

        private void calendarFechaDeServicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime inicio = calendarFechaDeServicio.SelectionStart;

            string dia = inicio.Day.ToString();
            string mes = inicio.Month.ToString();
            string año = inicio.Year.ToString();

            lblFechaDeServicio.Text = $"{dia} / {mes} / {año}";

            dia_servicio = dia;
            mes_servicio = mes;
            año_servicio = año;
        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCausasDeNoCierre.Enabled = false;
        }

        private void seleccionarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista_usuarios frm = new lista_usuarios(this);
            frm.ShowDialog();
        }

        private void btnSolicitarRefaccion_Click(object sender, EventArgs e)
        {
            solicitar_refaccion frm = new solicitar_refaccion(this);
            bool openFormsCount = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "solicitar_refaccion")
                {
                    openFormsCount = true;
                    f.BringToFront();
                }
                else
                {
                    openFormsCount = false;
                }
            }

            if (!openFormsCount)
            {
                // Establecemos algunos valores por defecto

                // Se envian valores al siguiente formulario
                /*
                frm.txtNoDeReporte.Text = this.txtNoDeReporteDelCliente.Text;
                frm.txtProyecto.Text = Properties.Settings.Default.ProyectoIDC;
                frm.txtLocalidad.Text = this.cboxPoblacion.Text;
                frm.txtNombreDeUsuario.Text = this.cboxUsuariofinal.Text;
                frm.txtDepartamento.Text = this.txtDepartamento.Text;
                frm.txtTelefono.Text = this.txtTelefono.Text;
                frm.txtMarca.Text = this.txtMarca.Text;
                frm.txtModelo.Text = this.txtModelo.Text;
                frm.txtSolicitante.Text = this.txtTecnico.Text;
                frm.txtDescripcion.Text = this.txtRefaccionesUtilizadas.Text;
                */

                // Abrimos la instancia para enviar correo
                frm.Show();
            }
        }

        private void btnCargarPerfil_Click(object sender, EventArgs e)
        {
            // Cargar perfil de usuario seleccionado
            ProfilesLoadMethod(this.cboxPerfiles.Text);
        }

        private void btnSolicitarToner_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            bool openFormsCount = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "solicitar_toner")
                {
                    openFormsCount = true;
                    f.BringToFront();
                }
                else
                {
                    openFormsCount = false;
                }
            }

            if (!openFormsCount)
            {
                frm.Show();
            }
        }

        /// <summary>
        /// Remueve los acentos en las cadenas ingresadas.
        /// </summary>
        /// <param name="inputString">Cadena a eliminar acentos.</param>
        /// <returns>Retorno la cadena sin acentos.</returns>
        public static string RemoveAccentsWithRegEx(string inputString)
        {
            Regex replace_a_Accents = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex replace_e_Accents = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex replace_i_Accents = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex replace_o_Accents = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex replace_u_Accents = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);

            inputString = replace_a_Accents.Replace(inputString, "a");
            inputString = replace_e_Accents.Replace(inputString, "e");
            inputString = replace_i_Accents.Replace(inputString, "i");
            inputString = replace_o_Accents.Replace(inputString, "o");
            inputString = replace_u_Accents.Replace(inputString, "u");

            return inputString;
        }

        /// <summary>
        /// Almacena los usuarios con una tarjeta de Perfil disponible.
        /// </summary>
        List<Usuario> listUsuarios = new List<Usuario>();

        /// <summary>
        /// Carga las tarjetas de los usuarios disponibles en la lista Usuarios.
        /// </summary>
        private void CardsLoad()
        {
            string cards_path = $@"{Application.StartupPath}\UsersCard\";
            listUsuarios.Clear();

            //MessageBox.Show(cards_path);

            if (Directory.Exists(cards_path))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(cards_path);
                    FileInfo[] files = di.GetFiles("*.card");

                    //MessageBox.Show("Cargando usuarios");

                    foreach (FileInfo file in files)
                    {
                        int s_len = file.Name.Length;

                        // Carga todos los usuarios en la lista
                        //MessageBox.Show(file.FullName);
                        JObject json_parsed = JObject.Parse(File.ReadAllText(file.FullName));

                        Usuario obj = new Usuario();
                        obj.Nombre = RemoveAccentsWithRegEx(file.Name.Remove(s_len - 13, 13).ToLower().Trim());
                        obj.NoEmpleado = json_parsed["no_empleado"].ToString();
                        obj.Extension = json_parsed["extension"].ToString();
                        obj.Red = json_parsed["red_user"].ToString();
                        obj.Email = json_parsed["mail"].ToString();
                        obj.Departamento = json_parsed["departamento"].ToString();
                        obj.Localidad = json_parsed["localidad_asignada"].ToString();

                        listUsuarios.Add(obj);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} {Environment.NewLine + Environment.NewLine} {ex.ToString()}");
                }
            }
        }

        /// <summary>
        /// Encuentra la Tarjeta de usuario y el equipo en el inventario de un usuario en especifico.
        /// </summary>
        /// <param name="ReportUserName">Usuario del reporte a buscar.</param>
        /// <returns>
        /// Valores de tupla.
        /// <br></br>
        /// T1 -> indica si tenemos tarjeta de usuario
        /// <br></br>
        /// T2 -> tarjeta de perfil del usuario
        /// <br></br>
        /// T3 -> indica si tenemos un equipo registrados en el inventario para este usuario
        /// <br></br>
        /// T1 -> equipo de computo del usuario selecionado
        /// </returns>
        private Tuple<bool, Usuario, bool, InventarioViewModel> FindReportUser(string ReportUserName)
        {
            ReportUserName = RemoveAccentsWithRegEx(ReportUserName);  // Removemos los acentos
            string userInLocalList = "";

            Usuario userCard = new Usuario();
            InventarioViewModel userMachine = new InventarioViewModel();

            //MessageBox.Show($"Buscando a {aUserName} en el inventario");

            CardsLoad();

            bool Exists = false;
            bool haveProfileCard = false;   // Esta es la variable que nos indica que encontramos la tarjeta del usuario
            bool haveMachineCard = false;   // Esta variable indica si encontramos o seleccionamos la maquina pertinente del usuario

            if (listUsuarios.Count >= 1)
            {
                int comparation = 0;
                foreach (Usuario user in listUsuarios)
                {
                    userInLocalList = RemoveAccentsWithRegEx(user.Nombre);
                    ReportUserName = ReportUserName.ToLower();

                    string[] partesNombre1 = ReportUserName.Split(' ');
                    string[] partesNombre2 = userInLocalList.Split(' ');
                    bool sonIguales = partesNombre1.All(parte => partesNombre2.Contains(parte, StringComparer.OrdinalIgnoreCase));

                    string a = "";
                    foreach (string i in partesNombre1)
                    {
                        a += $" {i}";
                    }
                    string b = "";
                    foreach (string i in partesNombre1)
                    {
                        b += $" {i}";
                    }

                    if (sonIguales)
                    {
                        Exists = true;

                        //MessageBox.Show($"{a}//{b} :: {Exists}");
                        break;
                    }
                    else
                    {
                        Exists = false;
                        //MessageBox.Show($"{a}//{b} :: {Exists}");
                    }
                }

                #region EN CASO DE QUE EXISTA BUSCAMOS EN EL INVENTARIOR
                if (Exists)
                {
                    #region CARGAMOS LOS DATOS DEL PERFFIL DEL USUARIO
                    try
                    {
                        string cards_path = $@"{Application.StartupPath}\UsersCard\";

                        DirectoryInfo di = new DirectoryInfo(cards_path);
                        FileInfo[] files = di.GetFiles("*.card");

                        //MessageBox.Show("Cargando usuarios despues de encontrar el usuario");

                        foreach (FileInfo file in files)
                        {
                            string SPECULATIVE_USER = $@"{ReportUserName}_Profile.card";

                            // Partes del nombre del archivo
                            string[] fileNameParts = file.Name.Replace("_Profile.card", "").Split(' ');
                            // Partes del nombre especulativo del archivo
                            string[] speculativeNameParts = ReportUserName.Split(' ');
                            bool sonIguales = fileNameParts.All(parte => speculativeNameParts.Contains(parte, StringComparer.OrdinalIgnoreCase));

                            if (sonIguales)
                            {
                                MessageBox.Show($"Si existe la tarjeta para el usuario ***{file.Name}***");

                                string json_card = File.ReadAllText(file.FullName);
                                JObject json_parsed = JObject.Parse(json_card);

                                userCard.Departamento = json_parsed["departamento"].ToString();
                                userCard.NoEmpleado = json_parsed["no_empleado"].ToString();
                                userCard.Extension = json_parsed["extension"].ToString();

                                haveProfileCard = true;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\n{ex}");
                    }
                    #endregion

                    // Si tenemos la carta de perfil del usuario, buscamos algun registro en el inventario
                    if (haveProfileCard)
                    {
                        #region OBTENEMOS EL EQUIPO DEL USUARIO DEL REPORTE
                        // Cargamos el equipo si existe en el inventario
                        // Checamos en la lista
                        List<InventarioViewModel> lst = new List<InventarioViewModel>();
                        var grilla = dataGridViewInventarios;

                        try
                        {
                            string path = $@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx";

                            int iRow = 2;
                            SLDocument sl = new SLDocument(path);
                            MessageBox.Show($"*** Iniciando busqueda en el inventario.\n\n{path}");

                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                InventarioViewModel equipo = new InventarioViewModel();

                                equipo.NOMBRE = sl.GetCellValueAsString(iRow, 1);
                                MessageBox.Show(equipo.NOMBRE);
                                equipo.NumDeEmpleado = sl.GetCellValueAsString(iRow, 2);
                                MessageBox.Show(equipo.NumDeEmpleado);
                                equipo.EXT = sl.GetCellValueAsString(iRow, 3);
                                MessageBox.Show(equipo.EXT);
                                equipo.USER = sl.GetCellValueAsString(iRow, 4);
                                MessageBox.Show(equipo.USER);
                                equipo.MAIL = sl.GetCellValueAsString(iRow, 5);
                                MessageBox.Show(equipo.MAIL);
                                equipo.HOSTNAME = sl.GetCellValueAsString(iRow, 6);
                                MessageBox.Show(equipo.HOSTNAME);
                                equipo.TipoDeEquipo = sl.GetCellValueAsString(iRow, 7);
                                MessageBox.Show(equipo.TipoDeEquipo);
                                equipo.SN = sl.GetCellValueAsString(iRow, 8);
                                MessageBox.Show(equipo.SN);
                                equipo.Marca = sl.GetCellValueAsString(iRow, 9);
                                MessageBox.Show(equipo.Marca);
                                equipo.Modelo = sl.GetCellValueAsString(iRow, 10);
                                MessageBox.Show(equipo.Modelo);
                                equipo.Ubicacion = sl.GetCellValueAsString(iRow, 11);
                                MessageBox.Show(equipo.Ubicacion);
                                equipo.Departamento = sl.GetCellValueAsString(iRow, 12);
                                MessageBox.Show(equipo.Departamento);
                                equipo.Comentarios = sl.GetCellValueAsString(iRow, 13);
                                MessageBox.Show(equipo.Comentarios);

                                iRow++;

                                //string VALOR_ANALIZANDO = grilla.Rows[iRow - 2].Cells["NOMBRE"].Value.ToString();
                                //MessageBox.Show($"*-*-*- -*-*-*");

                                // Partes del nombre del archivo
                                string[] nameInInventory = equipo.NOMBRE.Split(' ');
                                // Partes del nombre especulativo del archivo
                                string[] nameFounded = userCard.Nombre.Split(' ');
                                bool sonIguales = nameInInventory.All(parte => nameFounded.Contains(parte, StringComparer.OrdinalIgnoreCase));

                                MessageBox.Show($" REP:{ReportUserName.Trim().ToLower()} {Environment.NewLine}");

                                if (sonIguales)
                                {
                                    MessageBox.Show($"MAQUINA ENCONTRADAAAAA: {equipo.HOSTNAME}");
                                    lst.Add(equipo);
                                }
                                else
                                {
                                    MessageBox.Show($"NO ES ESTA: {equipo.HOSTNAME}");
                                }
                                MessageBox.Show($"{iRow - 1} -> {iRow}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}\n{ex}");
                        }

                        MessageBox.Show(lst.Count.ToString());

                        /* 
                         * Abrimos el selector de equipo
                         * */
                        if (lst.Count >= 1)
                        {
                            select_machine frm = new select_machine(this, lst);
                            frm.ShowDialog();
                        }
                        #endregion
                    }
                }
                else
                {
                    MessageBox.Show("No tenemos una tarjeta del usuario");
                }
                #endregion
            }

            return new Tuple<bool, Usuario, bool, InventarioViewModel>(haveProfileCard, userCard, haveMachineCard, userMachine);
        }

        /// <summary>
        /// Obtiene los valores de las cadenas de entrada.
        /// </summary>
        /// <param name="X">Primer cadena de entrada.</param>
        /// <param name="Y">Segunda cadena de entrada</param>
        /// <returns>Retorna matriz bidimensional de las cadenas de entrada.</returns>
        public static int getEditDistance(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            int[][] T = new int[m + 1][];
            for (int i = 0; i < m + 1; ++i)
            {
                T[i] = new int[n + 1];
            }

            for (int i = 1; i <= m; i++)
            {
                T[i][0] = i;
            }
            for (int j = 1; j <= n; j++)
            {
                T[0][j] = j;
            }

            int cost;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    cost = X[i - 1] == Y[j - 1] ? 0 : 1;
                    T[i][j] = Math.Min(Math.Min(T[i - 1][j] + 1, T[i][j - 1] + 1),
                            T[i - 1][j - 1] + cost);
                }
            }

            return T[m][n];
        }

        /// <summary>
        /// Compara y encuentra la similitud entre dos cadenas de texto.
        /// </summary>
        /// <param name="x">Primer cadena a comparar.</param>
        /// <param name="y">Segunda cadena a comparar.</param>
        /// <returns>Devuelve el valor double de similitud entre las dos cadenas.</returns>
        /// <exception cref="ArgumentException">Excepcion producida cuando las cadenas de entrada son de valor Null.</exception>
        public static double findSimilarity(string x, string y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Strings must not be null");
            }

            double maxLength = Math.Max(x.Length, y.Length);
            if (maxLength > 0)
            {
                // opcionalmente ignora el caso si es necesario
                return (maxLength - getEditDistance(x, y)) / maxLength;
            }
            return 1.0;
        }


        /* CARGA LOS DATOS DE UN REPORTE ABIERTO EN SAS */
        async void importarDatosDeReporteDeSASAFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        #region PERFILES DE DATOS DEL USUARIO - CREACION, ELIMINACION Y CARGA

        // Funcion para cargar perfiles de la cinta de opciones
        private void ProfilesLoadMethod(string aMandante)
        {
            if (aMandante != "Default")
            {
                if (aMandante == "------------ Agregar nuevo perfil ------------")
                {
                    //RJMessageBox.Show("Funcion aun no disponible:/" + Environment.NewLine + "Podras crear tus propios perfiles de datos para reutilizarlos y evitar escribis manualmente muchas veces un mismo trabajo.", "Proximamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    #region CREACION DE PERFIL
                    bool nameFlag = false;

                    // Añadimos todos los datos a guardar en el perfil
                    Dictionary<string, string> dic = new Dictionary<string, string>();

                    dic.Add("falla", this.txtFallaReportada.Text);
                    //if (rbtnRefaccionesSi.Checked == true) { dic.Add("opc_refaccion", "1"); dic.Add("refaccion", this.txtRefaccionesUtilizadas.Text); } else if (rbtnRefaccionesNo.Checked == true) { dic.Add("opc_refaccion", "0"); dic.Add("refaccion", "NULL"); }
                    if (rbtnRefaccionesSi.Checked == true) { dic.Add("opc_cerrado", "1"); dic.Add("causa_pendiente", "NULL"); } else if (rbtnRefaccionesNo.Checked == true) { dic.Add("opc_cerrado", "0"); dic.Add("causa_pendiente", this.txtCausasDeNoCierre.Text); }
                    dic.Add("accion_1", txtLinea1.Text);
                    dic.Add("accion_2", txtLinea2.Text);
                    dic.Add("accion_3", txtLinea3.Text);
                    dic.Add("accion_4", txtLinea4.Text);
                    dic.Add("accion_5", txtLinea5.Text);
                    dic.Add("accion_6", txtLinea6.Text);
                    dic.Add("accion_7", txtLinea7.Text);

                    string pName = Interaction.InputBox("¡Datos cargados con exito! ¿Como desea nombrar este perfil?", "Nombramiento", "");

                    if (!string.IsNullOrEmpty(pName) || pName == " ")
                    {
                        foreach (string perfil in cboxPerfiles.Items)
                        {
                            if (perfil == pName)
                            {
                                nameFlag = true;
                            }
                        }

                        if (nameFlag == true)
                        {
                            // En caso de que el nombre no este disponible
                            RJMessageBox.Show("El nombre no es valido! intenta con otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (nameFlag == false)
                        {
                            /* EN CASO DE EJECUTAR UN PERFIL SELECCIONADO */

                            Manipulation.saveProfile(pName, dic);
                            this.cboxPerfiles.Items.Add(pName);

                            RJMessageBox.Show("¡Perfil creado y añadido a cinta de opciones con exito!", "Perfil creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion

                }
                else if (RJMessageBox.Show($"¿Desea cargar el perfil < {aMandante} >?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (aMandante == "Mantenimiento")
                    {
                        /* BORRAR AL IMPLEMENTAR PERFILES PERSONALIZADOS */

                        Dictionary<string, string> dic = new Dictionary<string, string>()
                        {
                            {"Nombre del perfil", "Mantenimiento"},
                            {"Acciones_LINEA1", "* Sopleteo de CPU/Laptop       * Monitor: "},
                            {"Acciones_LINEA2", "* Limpieza de mouse/teclado    * UPS: "},
                            {"Acciones_LINEA3", "* Limpieza de regulador/ups    * Regulador:"},
                            {"Acciones_LINEA4", "* Limpieza del monitor"},
                            {"Acciones_LINEA5", "* Borrado temporales           * HDD: "},
                            {"Acciones_LINEA6", "* Actualizacion antivirus      * RAM: "},
                            {"Acciones_LINEA7", "* Revision cableado            * Windows 10 Pro"}
                        };
                        this.txtFallaReportada.Text = dic["Nombre del perfil"];
                        this.txtLinea1.Text = dic["Acciones_LINEA1"];
                        this.txtLinea2.Text = dic["Acciones_LINEA2"];
                        this.txtLinea3.Text = dic["Acciones_LINEA3"];
                        this.txtLinea4.Text = dic["Acciones_LINEA4"];
                        this.txtLinea5.Text = dic["Acciones_LINEA5"];
                        this.txtLinea6.Text = dic["Acciones_LINEA6"];
                        this.txtLinea7.Text = dic["Acciones_LINEA7"];

                        this.rbtnRefaccionesNo.Checked = true;
                        this.rbtnRefaccionesSi.Checked = true;
                    }
                    else
                    {
                        #region CARGA DE PERFIL PERSONALIZADO
                        string json_profile = File.ReadAllText($@"{Application.StartupPath}\Profiles\{aMandante}.json");
                        JObject json = JObject.Parse(json_profile);

                        this.txtFallaReportada.Text = json["falla"].ToString();

                        if ((string)json["opc_refaccion"] == "1")
                        {
                            this.rbtnRefaccionesSi.Checked = true;
                            //this.txtRefaccionesUtilizadas.Text = json["refaccion"].ToString();
                        }
                        else
                        {
                            this.rbtnRefaccionesNo.Checked = true;
                        }

                        if ((string)json["opc_cerrado"] == "0")
                        {
                            this.rbtnRefaccionesNo.Checked = true;
                            this.txtCausasDeNoCierre.Text = json["causa_pendiente"].ToString();
                        }
                        else
                        {
                            this.rbtnRefaccionesSi.Checked = true;
                        }

                        this.txtLinea1.Text = json["accion_1"].ToString();
                        this.txtLinea2.Text = json["accion_2"].ToString();
                        this.txtLinea3.Text = json["accion_3"].ToString();
                        this.txtLinea4.Text = json["accion_4"].ToString();
                        this.txtLinea5.Text = json["accion_5"].ToString();
                        this.txtLinea6.Text = json["accion_6"].ToString();
                        this.txtLinea7.Text = json["accion_7"].ToString();
                        #endregion
                    }

                    /* PONER ACCION 
                    * > | TERMINAR LA QUE EL USUARIO PUEDA ELEGIR SUS PROPIOS PERFILES | < 
                    */
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        public void LimpiarCampos()
        {
            /* 
             * Limpiamos todos los campos del formulario
             * */
        }


        // Funcion para eliminar algun perfil seleccionado
        private void ProfileDeleteMethod()
        {
            string selectedProfile = this.cboxPerfiles.Text;

            if (RJMessageBox.Show($"¿Seguro que deseas eliminar el perfil < {selectedProfile} >?", "Eliminar perfil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string profilesPath = $@"{Application.StartupPath}\Profiles";

                string absPath = $@"{profilesPath}\{selectedProfile}.json";

                if (File.Exists(absPath))
                {
                    // Eliminamos perfil en el directorio
                    File.Delete(absPath);

                    // ELiminamos de las listas actuales
                    this.cboxPerfiles.Items.Remove(selectedProfile);

                    ToolStripItem item_to_delete = null;

                    foreach (ToolStripItem item in perfilesToolStripMenuItem.DropDownItems)
                    {
                        if (item.ToString() == selectedProfile)
                        {
                            item_to_delete = item;
                        }
                    }

                    if (item_to_delete != null)
                    {
                        this.perfilesToolStripMenuItem.DropDownItems.Remove(item_to_delete);
                    }

                    this.cboxPerfiles.SelectedIndex = 0;

                    RJMessageBox.Show($"Se ha borrado con exito el perfil < {selectedProfile} > !", "Perfil Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        private void cboxPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfilesLoadMethod(this.cboxPerfiles.Text);
        }

        #region MANIPULACION DE LINEAS DE ACCIONES
        /** PASE DE FOC AUTOMATICO **/
        private void txtLinea1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea2.Focus();
            }
        }
        private void txtLinea2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea3.Focus();
            }
        }

        private void txtLinea3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea4.Focus();
            }
        }

        private void txtLinea4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea5.Focus();
            }
        }

        private void txtLinea5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea6.Focus();
            }
        }

        private void txtLinea6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea7.Focus();
            }
        }

        private void txtLinea7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtLinea1.Focus();
            }
        }

        /** ACIONES DE PUNTUAION AUTOMATICA **/
        private void txtLinea1_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea1.Text))
            {
                txtLinea1.Text += "* ";
                txtLinea1.SelectionStart = txtLinea2.Text.Length;
            }
        }

        private void txtLinea2_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea2.Text))
            {
                txtLinea2.Text += "* ";
                txtLinea2.SelectionStart = txtLinea2.Text.Length;
            }
        }

        private void txtLinea3_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea3.Text))
            {
                txtLinea3.Text += "* ";
                txtLinea3.SelectionStart = txtLinea3.Text.Length;
            }
        }

        private void txtLinea4_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea4.Text))
            {
                txtLinea4.Text += "* ";
                txtLinea4.SelectionStart = txtLinea4.Text.Length;
            }
        }

        private void txtLinea5_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea5.Text))
            {
                txtLinea5.Text += "* ";
                txtLinea5.SelectionStart = txtLinea5.Text.Length;
            }
        }

        private void txtLinea6_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea6.Text))
            {
                txtLinea6.Text += "* ";
                txtLinea6.SelectionStart = txtLinea6.Text.Length;
            }
        }

        private void txtLinea7_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinea7.Text))
            {
                txtLinea7.Text += "* ";
                txtLinea7.SelectionStart = txtLinea7.Text.Length;
            }
        }
        #endregion

        #region PASES DE HORA Y MINUTOS AUTOMATIZADOS
        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMinuto_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnBorrarPerfil_Click(object sender, EventArgs e)
        {
            /* BORRAR UN PERFIL SELECCIONADO */

            // AÑADIR EXCEPCIONES DE PERFILES QUE NO SE PUEDEN BORRAR
            ProfileDeleteMethod();
        }

        /* Guarda el RIT en PDF sin imprimir */
        private void guardarRITPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (string.IsNullOrEmpty(this.txtFallaReportada.Text))
            {
                this.errorProvider1.SetError(this.txtFallaReportada, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa la falla reportada!");
            }
            else if (string.IsNullOrEmpty(this.cboxUsuariofinal.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cboxUsuariofinal, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa el usuario del reporte!");
            }
            else
            {
                this.errorProvider1.Clear();
                FillPDFForm();
            }
            */
        }


        /* Abre proyecto de ticket JSON */
        private void abrirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Abrir proyecto de ticket...";
                openFileDialog1.Filter = "Archivo de Formulario RIT | *.ritproj|Archivo JSON | *.json";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    LEGACY_PROJECTJSON_PATH = openFileDialog1.FileName; // Indicamos el path del proyecto
                    ActualProject = RitJsonProject.LoadProject(openFileDialog1.FileName);
                    OpenRITProjects(ActualProject);

                    this.Text = this.txtFallaReportada.Text + " - " + openFileDialog1.FileName; // Actualizamos el nombre del MDI
                    padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[this.MDI_ID.ToString()].Text = ActualProject.NombreProyecto;     // Actualizamos el nombre del nodo asociado
                    ActualProject.IsProjectSaved = true;
                }

                padre.toolLblActualMDIReporteName.Text = this.Text;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"No se pudo abrir el proyecto < {Path.GetFileName(openFileDialog1.FileName)} > a causa de un error inesperado. {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("IN", this.Name, $"NO SE PUDO ABRIR EL PROYECTO '{Path.GetFileName(openFileDialog1.FileName)}' POR EXCEPCION INESPERADA", "EXC");
            }
        }


        /* Imprime RIT sin guardar (arreglar) */
        private void imprimirRITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Solamente imrpime el formato RIT */
            /*
            if (string.IsNullOrEmpty(this.txtFallaReportada.Text))
            {
                this.errorProvider1.SetError(this.txtFallaReportada, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa la falla reportada!");
            }
            else if (string.IsNullOrEmpty(this.cboxUsuariofinal.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cboxUsuariofinal, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa el usuario del reporte!");
            }
            else
            {
                this.errorProvider1.Clear();
                printPDFWithAcrobat(FillPDFForm()); // Imprimimos el archivo
                UpdateJobStatus(true, "Preparando metodo de impresion!"); 
            }
            */
        }

        private void txtFallaReportada_TextChanged(object sender, EventArgs e)
        {
            string[] INVALID_CHARS = { "/", "<", ">", ":", "\"", "|", "?", "*", "." };

            foreach (string i in INVALID_CHARS)
            {
                if (this.txtFallaReportada.Value.Contains(i))
                {
                    this.txtFallaReportada.Value = this.txtFallaReportada.Text.Replace(i, "-");
                    //this.txtFallaReportada.SelectionStart = this.txtFallaReportada.TextLength;
                }
            }
        }

        private void perfilesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //RJMessageBox.Show(e.ClickedItem.Text);
            ProfilesLoadMethod(e.ClickedItem.Text);
        }

        /* Guardado de tikcet aproyecto JSON */
        private void guardarTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtFallaReportada.Text != String.Empty)
            {
                errorProvider1.SetError(txtFallaReportada, "");
                try
                {
                    // Si es un proyecto que no esta guardado, lo guardamos localmente
                    if (ActualProject.IsProjectSaved == false)
                    {
                        saveFileDialog1.Title = "Guardar proyecto de ticket...";
                        saveFileDialog1.Filter = "Archivo de Formulario RIT | *.ritproj|Archivo JSON | *.json";
                        //saveFileDialog1.FileName = $"{this.txtNombreDelProyecto.Text}";

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            UpdateJobStatus(true, "Guardando proyecto...");
                            string jsonProjectPath = saveFileDialog1.FileName;
                            FileInfo fi = new FileInfo(jsonProjectPath);

                            // Grabamos el objeto y lo guardamos
                            ActualProject.NombreProyecto = fi.Name.Replace(".json", "").Replace(".ritproj", "");
                            ActualProject.FillUpdate(this);
                            ActualProject.SaveProject(saveFileDialog1.FileName);

                            // Actualizamos los valores de visualizaciones
                            this.Text = this.txtFallaReportada.Text + " - " + jsonProjectPath;
                            //this.txtNombreDelProyecto.Text = ActualProject.NombreProyecto;
                            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].Text = ActualProject.NombreProyecto;

                            LEGACY_PROJECTJSON_PATH = saveFileDialog1.FileName;
                            UpdateJobStatus(true, $"Proyecto '{LEGACY_PROJECTJSON_PATH}' guardado!");
                        }
                    }
                    else
                    {
                        // Actualiza los datos del archivo existente en caso de existir
                        UpdateJobStatus(true, "Guardando proyecto...");

                        // Grabamos el objeto y lo guardamos
                        ActualProject.FillUpdate(this);
                        ActualProject.SaveProject(LEGACY_PROJECTJSON_PATH);

                        // Actualizamos los valores de visualizaciones
                        padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].Text = ActualProject.NombreProyecto;
                        UpdateJobStatus(true, $"Proyecto '{LEGACY_PROJECTJSON_PATH}' guardado!");
                    }

                    padre.toolLblActualMDIReporteName.Text = this.Text;
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString());
                }

            }
            else
            {
                errorProvider1.SetError(txtFallaReportada, "Ingresa la falla reportada!");
            }
        }

        private void limpiarCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void guardarEImpirmirRITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Guarda e imprime el RIT */
            /*
            if (string.IsNullOrEmpty(this.txtFallaReportada.Text))
            {
                this.errorProvider1.SetError(this.txtFallaReportada, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa la falla reportada!");
            }
            else if (string.IsNullOrEmpty(this.cboxUsuariofinal.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cboxUsuariofinal, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa el usuario del reporte!");
            }
            else
            {
                this.errorProvider1.Clear();
                printPDFWithAcrobat(FillPDFForm()); // Imprimimos el archivo
                UpdateJobStatus(true, "Preparando metodo de impresion!");
            }
            */
        }

        private void solicitarTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            frm.ShowDialog();
        }

        private void rbtnRefaccionesNo_CheckedChanged(object sender, EventArgs e)
        {
            //this.txtRefaccionesUtilizadas.Enabled = false;
            this.btnReducirToner.Enabled = false;
            this.btnSolicitarRefaccion.Enabled = false;
            this.btnReducirRefaccion.Enabled = false;
        }

        private void rbtnRefaccionesSi_CheckedChanged(object sender, EventArgs e)
        {
            //this.txtRefaccionesUtilizadas.Enabled = true;
            this.btnReducirToner.Enabled = true;
            this.btnSolicitarRefaccion.Enabled = true;
            this.btnReducirRefaccion.Enabled = true;
        }

        private void rit_mdi_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Removemos el nodo de este proyecto de la vista de arbol
            padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].Remove();

            // Evaluamos la reaparicion del panel de acceso rapido
            int i = 0;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "rit_mdi_form")
                {
                    i++;
                }
            }

            if (i > 0)
            {
                // Ignoramos ...
            }
            else
            {
                //padre.lblProyectos_Text.Visible = true;
            }

            padre.lblNodoDeProyectosSeleccionado.Text = $"Mis Proyectos ({padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes.Count})";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_DEFAULT_FN = "Guardar PDF";
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_DEFAULT_FN = "Imprimir";
        }

        private void imprimirYGuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_DEFAULT_FN = "Imprimir y guardar PDF";
        }

        private void rit_mdi_form_Activated(object sender, EventArgs e)
        {
            MessageBox.Show($"Form '{MDI_ID}' Activado");
        }

        private void rit_mdi_form_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("usando");
        }

        private void toolLimbiarFormulario_Click(object sender, EventArgs e)
        {
            // En caso de activarse en formulario principal
            LimpiarCampos();
        }

        private void toolAbrirInventario_Click(object sender, EventArgs e)
        {
            // Iniciamos la pantalla de carga
            //this.backgroundWorker_WaitScreen.RunWorkerAsync();

            inventarios frm = new inventarios(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// Busca los equipos viculados a este usuario
        /// </summary>
        private void LoadUsersList()
        {
            // Cargamos los datos del usuario seleccionado en el formulario
            try
            {
                /*
                this.txtHostname.AutoCompleteMode = AutoCompleteMode.None;

                JObject json_parsed = JObject.Parse(File.ReadAllText($@"{Application.StartupPath}\UsersCard\{this.cboxUsuariofinal.Text}_Profile.card"));

                // Cargamos los datos del empleado desde su tarjeta
                this.txtNoDeEmpleado.Text = json_parsed["no_empleado"].ToString();
                this.txtTelefono.Text = json_parsed["extension"].ToString();
                this.txtDepartamento.Text = json_parsed["departamento"].ToString();

                // Cargamos el hostname del equipo desde el inventario
                #region CODIGO
                // 1. Cargamos los Hostnames que correspondan a este usuario asignado
                List<string> hostnamesOfThisUser = new List<string>();

                foreach (DataGridViewRow fila in dataGridViewInventarios.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == this.cboxUsuariofinal.Text && fila.Cells[5].Value != null)
                    {
                        string[] acceptedValues = new string[]
                        {
                            "pc", "laptop"
                        };

                        if (acceptedValues.Contains(fila.Cells[6].Value.ToString().ToLower().Trim()))
                        {
                            hostnamesOfThisUser.Add(fila.Cells[5].Value.ToString());
                        }
                    }
                }

                // 2. En caso de que haya mas de 1 hostname, agregamos los AutoCompleteCollection al control
                if (hostnamesOfThisUser.Count > 1)
                {
                    AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
                    foreach (string h in hostnamesOfThisUser)
                    {
                        stringCollection.Add(h);
                    }

                    this.txtHostname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.txtHostname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.txtHostname.AutoCompleteCustomSource = stringCollection;
                }

                // 3. Seleccionamos el primero o el por defecto
                if (hostnamesOfThisUser.Count > 0)
                {
                    this.txtHostname.Text = hostnamesOfThisUser[0];
                }
                #endregion
                */
                UpdateJobStatus(true, "Datos de usuario cargados con exito!");
            }
            catch (Exception ex)
            {
                // Mostrar Error
                UpdateJobStatus(false, $"No se pudo cargar los datos. {ex.Message}");
            }
        }

        private void txtUsuariofinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsersList();
        }

        internal string POBLATION_JSON_FILE = "";
        private void txtPoblacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambiar la lista de usuarios disponibles segun la localidad seleccionada
            /*
            this.cboxUsuariofinal.Items.Clear();

            string CARDS_PATH = $@"{Application.StartupPath}\UsersCard";

            if (Directory.Exists(CARDS_PATH))
            {
                DirectoryInfo dir = new DirectoryInfo(CARDS_PATH);
                FileInfo[] files_cards = dir.GetFiles("*.card");

                string POBLACION_SELECCIONADA = this.cboxPoblacion.Text;

                foreach (FileInfo file in files_cards)
                {
                    JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                    if (json["localidad_asignada"].ToString() == POBLACION_SELECCIONADA)
                    {
                        this.cboxUsuariofinal.Items.Add(file.Name.Remove(file.Name.Length - 13, 13));
                    }
                }
            }

            #region ENCONTRAMOS EL ARCHIVO DE LOCALIDAD SELECCIONADA
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {

                DirectoryInfo dir = new DirectoryInfo(LOCALS_PATH);
                FileInfo[] files_directions = dir.GetFiles("*.json");

                foreach (FileInfo file in files_directions)
                {
                    JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                    if (json["poblacion"].ToString() == this.cboxPoblacion.Text)
                    {
                        POBLATION_JSON_FILE = file.FullName;
                    }
                }
            }
            #endregion

            // Cambiamos los datos relacionados a la poblacion
            if (!String.IsNullOrEmpty(POBLATION_JSON_FILE))
            {
                CommonMethodsLibrary.ExtractAllData(POBLATION_JSON_FILE, this);
            } else
            {
                CommonMethodsLibrary.OutMessage("in", "rit_mdi_form.cs", "No se encontro el archivo Json de localidad asignada!", "ERR");
            }
            */
        }

        private void toolImprimirYGuardarRIT_Click(object sender, EventArgs e)
        {
            /**  Imprime y guarda el PDF de RIT **/
            /*
            if (string.IsNullOrEmpty(this.txtFallaReportada.Text))
            {
                this.errorProvider1.SetError(this.txtFallaReportada, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa la falla reportada!");
            }
            else if (string.IsNullOrEmpty(this.cboxUsuariofinal.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cboxUsuariofinal, "Campo vacio!");
                UpdateJobStatus(false, "Ingresa el usuario del reporte!");
            }
            else
            {
                this.errorProvider1.Clear();
                printPDFWithAcrobat(FillPDFForm());
                UpdateJobStatus(true, "Preparando metodo de impresion!");
            }
            */
        }

        public TaskLoadingForm loadingForm;
        private void backgroundWorker_WaitScreen_DoWork(object sender, DoWorkEventArgs e)
        {
            // Abrimos ventana de carga
            loadingForm = new TaskLoadingForm(this, "Leyendo y extrayendo los datos necesarios de los inventarios disponibles.", "Cargando", false);
            loadingForm.Show();
        }

        private void btnGenerarReporteEnSASVia911_Click(object sender, EventArgs e)
        {
            // Generamos el reporte de proyecto actual en SAS via 911@ferromex.mx
        }

        void ResignProjectName()
        {
            /*
            if (String.IsNullOrEmpty(this.txtNombreDelProyecto.Text.Trim()))
            {
                ActualProject.NombreProyecto = this.txtNombreDelProyecto.Text;
                padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].Text = ActualProject.NombreProyecto;
            } else
            {
                UpdateJobStatus(false, $"No se puede reasignar un nombre de proyecto vacio!");
            }
            */
        }

        private void txtNombreDelProyecto_Leave(object sender, EventArgs e)
        {
            ResignProjectName();
        }

        private void toolAbrirPDF_Click(object sender, EventArgs e)
        {
            // Buscamos el PDF para abrirlo
            if (!String.IsNullOrEmpty(ActualProject.PdfPath))
            {
                string place = Regex.Replace(ActualProject.PdfPath, @"\\+", @"\");  // Variable de uso local sin diagonales duplicadas (Ruta Absoluta)

                if (File.Exists(place) && Path.GetExtension(place) == ".pdf")
                {
                    //MessageBox.Show($@"start {place}");
                    try
                    {
                        // Abrimos el archivo
                        Process.Start($@"{place}");
                        UpdateJobStatus(true, "Path del RIT en PDF abierto con exito!");
                    }
                    catch (Exception ex)
                    {
                        UpdateJobStatus(false, ex.Message);
                        //MessageBox.Show($"{ex.Message}\n\n{ex}");
                    }
                }
                else if (File.Exists(place) && Path.GetExtension(place) == ".json")
                {
                    UpdateJobStatus(false, "Primero guarda el PDF y despues ejecuta esta funcion nuevamente!");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            #region CREACION DE PERFIL
            bool nameFlag = false;

            // Añadimos todos los datos a guardar en el perfil
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("falla", this.txtFallaReportada.Text);
            //if (rbtnRefaccionesSi.Checked == true) { dic.Add("opc_refaccion", "1"); dic.Add("refaccion", this.txtRefaccionesUtilizadas.Text); } else if (rbtnRefaccionesNo.Checked == true) { dic.Add("opc_refaccion", "0"); dic.Add("refaccion", "NULL"); }
            if (rbtnRefaccionesSi.Checked == true) { dic.Add("opc_cerrado", "1"); dic.Add("causa_pendiente", "NULL"); } else if (rbtnRefaccionesNo.Checked == true) { dic.Add("opc_cerrado", "0"); dic.Add("causa_pendiente", this.txtCausasDeNoCierre.Text); }
            dic.Add("accion_1", txtLinea1.Text);
            dic.Add("accion_2", txtLinea2.Text);
            dic.Add("accion_3", txtLinea3.Text);
            dic.Add("accion_4", txtLinea4.Text);
            dic.Add("accion_5", txtLinea5.Text);
            dic.Add("accion_6", txtLinea6.Text);
            dic.Add("accion_7", txtLinea7.Text);

            string pName = Interaction.InputBox("¡Datos cargados con exito! ¿Como desea nombrar este perfil?", "Nombramiento", "");

            if (!string.IsNullOrEmpty(pName) || pName == " ")
            {
                foreach (string perfil in cboxPerfiles.Items)
                {
                    if (perfil == pName)
                    {
                        nameFlag = true;
                    }
                }

                if (nameFlag == true)
                {
                    // En caso de que el nombre no este disponible
                    RJMessageBox.Show("El nombre no es valido! intenta con otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nameFlag == false)
                {
                    /* EN CASO DE EJECUTAR UN PERFIL SELECCIONADO */

                    Manipulation.saveProfile(pName, dic);
                    this.cboxPerfiles.Items.Add(pName);

                    RJMessageBox.Show("¡Perfil creado y añadido a cinta de opciones con exito!", "Perfil creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion
        }


        void _DoubleClickEmulator(TreeNode targetNode)
        {
            padre.treeViewProyectos.SelectedNode = targetNode;

            TreeNodeMouseClickEventArgs args = new TreeNodeMouseClickEventArgs(targetNode, MouseButtons.Left, 2, 0, 0);
            padre.treeViewProyectos_NodeMouseDoubleClick(padre.treeViewProyectos, args);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Abrimos el MDI anterior en la cola de nodos
            string MDI_ID = this.MDI_ID.ToString();

            int index = 0;
            foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
            {
                if (node.Name == MDI_ID)
                {
                    break;
                }

                index++;
            }
            int actualPosition = index;
            int targetPosition = actualPosition - 1 >= 0 ? actualPosition - 1 : 0;

            TreeNode T_node = padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[targetPosition];

            _DoubleClickEmulator(T_node);
            //MessageBox.Show($"For Child: {MDI_ID}\nActual Post: {actualPosition}\nTarget Post: {targetPosition}");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Abrimos el MDI siguiente en la cola de nodos
            string MDI_ID = this.MDI_ID.ToString();

            int index = 0;
            foreach (TreeNode node in padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes)
            {
                if (node.Name == MDI_ID)
                {
                    break;
                }

                index++;
            }
            int actualPosition = index;
            int targetPosition = actualPosition + 1 <= padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes.Count - 1 ? actualPosition + 1 : padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes.Count - 1;

            TreeNode T_node = padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[targetPosition];

            _DoubleClickEmulator(T_node);
            //MessageBox.Show($"For Child: {MDI_ID}\nActual Post: {actualPosition}\nTarget Post: {targetPosition}");
        }

        private void btnCargarEquipo_Click(object sender, EventArgs e)
        {
            /*
             * Cargamos los datos del equipo
             */

            int coincs = 0;
            InventarioViewModel machine = new InventarioViewModel();
            string _hostname = this.txtHostname.Text;

            // Cargamos los datos del hostname si fue cargado manualmente
            if (!String.IsNullOrEmpty(this.txtHostname.Text.Trim()))
            {
                foreach (DataGridViewRow fila in dataGridViewInventarios.Rows)
                {
                    if (fila.Cells[5].Value.ToString().ToLower() == _hostname.ToLower())
                    {
                        string _tipo = fila.Cells[6].Value.ToString().ToLower();

                        string[] tags = new string[]
                        {
                            "pc", "desktop", "laptop", "portatil", "ipad", "escritorio"
                        };

                        if (tags.Contains(_tipo))
                        {
                            machine.TipoDeEquipo = fila.Cells["TipoDeEquipo"].Value.ToString();
                            machine.SN = fila.Cells["SN"].Value.ToString();
                            machine.Marca = fila.Cells["Marca"].Value.ToString();
                            machine.Modelo = fila.Cells["Modelo"].Value.ToString();

                            coincs++;
                        }

                        break;
                    }
                }
            }
            else
            {
                UpdateJobStatus(false, "No puedes cargar un hostname vacio!");
            }

            if (coincs > 0)
            {
                this.txtTipoDeEquipo.Text = machine.TipoDeEquipo;
                this.txtMarcaEquipo.Text = machine.Marca;
                this.txtModeloEquipo.Text = machine.Modelo;
                this.txtNoSerie.Text = machine.SN;

                UpdateJobStatus(true, $"Equipo de computo de hostname '{_hostname}' cargado con exito!!");
            }
            else
            {
                UpdateJobStatus(false, $"No se encontro un equipo de computo de hostname '{_hostname}'!");
            }
        }

        private void txtNoDeReporteDelCliente_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNoReporte.Text.Length == 6)
            {
                // No. de Reporte insertado
                this.IsAlreadyTicketGenerated = true;
                UpdateNodeColorByProgress();
                this.btnVerReporte.Enabled = true;
            }
            else
            {
                // No. de reporte no ingresado
                this.IsAlreadyTicketGenerated = false;
                UpdateNodeColorByProgress();
                this.btnVerReporte.Enabled = false;
            }

            this.linklblTicketGeneradoEnSAS.Text = IsAlreadyTicketGenerated.ToString();
        }

        private void btnVisualizarReporte_Click(object sender, EventArgs e)
        {

        }

        private void linklblTicketGeneradoEnSAS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsAlreadyTicketGenerated == true)
            {
                IsAlreadyTicketGenerated = false;
            }
            else
            {
                IsAlreadyTicketGenerated = true;
            }

            this.linklblTicketGeneradoEnSAS.Text = IsAlreadyTicketGenerated.ToString();
            UpdateNodeColorByProgress();
        }

        private void linklblRitImpreso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsRitAlreadyPrinted == true)
            {
                IsRitAlreadyPrinted = false;
            }
            else
            {
                IsRitAlreadyPrinted = true;
            }

            this.linklblRitImpreso.Text = IsRitAlreadyPrinted.ToString();
            UpdateNodeColorByProgress();
        }

        private void linklblRitFirmado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsRitAlreadySigned == true)
            {
                IsRitAlreadySigned = false;
            }
            else
            {
                IsRitAlreadySigned = true;
            }

            this.linklblRitFirmado.Text = IsRitAlreadySigned.ToString();
            UpdateNodeColorByProgress();
        }

        private void linklblRitComprobado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsRitAlreadyComprobado == true)
            {
                IsRitAlreadyComprobado = false;
            }
            else
            {
                IsRitAlreadyComprobado = true;
            }

            this.linklblRitComprobado.Text = IsRitAlreadyComprobado.ToString();
            UpdateNodeColorByProgress();
        }

        private void toolStrpBtnCerrarProyecto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtFallaReportada.Text.Trim()))
            {
                DialogResult dg = MessageBox.Show($"¿Deseas guardar el proyecto '{this.txtFallaReportada.Text}' - {this.MDI_ID} antes de cerrar el proyecto?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (dg)
                {
                    case DialogResult.Yes:
                        // Guardamos y cerramos
                        this.toolGuardarProyecto.PerformClick();
                        this.Close();
                        break;
                    case DialogResult.No:
                        // Cerramos sin guardar
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        // No cerramos el Reporte
                        break;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void minimizarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Minimized;
        }

        private void cboxUsuariofinal_TextChanged(object sender, EventArgs e)
        {
            /*
            if (String.IsNullOrEmpty(this.cboxUsuariofinal.Text.Trim()))
            {
                this.btnVerTarjetaDeUsuarioActual.Enabled = false;
                this.btnCargarEquipo.Enabled = false;
                this.txtHostname.Text = "";
            } else
            {
                this.btnVerTarjetaDeUsuarioActual.Enabled = true;
                this.btnCargarEquipo.Enabled = true;
                LoadUsersList();
            }
            */
        }

        private void btnVerTarjetaDeUsuarioActual_Click(object sender, EventArgs e)
        {
            lista_usuarios frm = new lista_usuarios(this, this.txtUsuarioFinal.Value.Trim());
            frm.ShowDialog();
        }

        private void btnVerHistorialDeEquipo_Click(object sender, EventArgs e)
        {
            /*
             * Abrimos el formulario del historial del equipo actualmente seleccionado
             */
            InventarioViewModel selectedMachine = InventarioViewModel.GetMachineByHostname(this.txtHostname.Text.Trim());
            //MessageBox.Show(selectedMachine.HOSTNAME);

            try
            {
                if (selectedMachine != null)
                {
                    exHistorialDeCambios frm = new exHistorialDeCambios(selectedMachine);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se ha cargado correctamente el valor para '{txtHostname.Text}'!", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReducirToner_Click(object sender, EventArgs e)
        {
            /* 
             * Reducimos el Toner en caso de haberse usado en el reporte
             */
        }

        private void btnReducirRefaccion_Click(object sender, EventArgs e)
        {
            /* 
             * Reducimos una Refaccion en caso de haberse usado en el reporte
             */
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtFallaReportada.Text != String.Empty)
            {
                errorProvider1.SetError(txtFallaReportada, "");
                try
                {
                    saveFileDialog1.Title = "Guardar proyecto de ticket como...";
                    saveFileDialog1.Filter = "Archivo de Formulario RIT | *.ritproj|Archivo JSON | *.json";
                    //saveFileDialog1.FileName = $"{this..Text}";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        UpdateJobStatus(true, "Guardando proyecto...");
                        string jsonProjectPath = saveFileDialog1.FileName;
                        FileInfo fi = new FileInfo(jsonProjectPath);

                        // Grabamos el objeto y lo guardamos
                        ActualProject.NombreProyecto = fi.Name.Replace(".json", "").Replace(".ritproj", "");
                        ActualProject.FillUpdate(this);
                        ActualProject.SaveProject(saveFileDialog1.FileName);

                        // Actualizamos los valores de visualizaciones
                        this.Text = this.txtFallaReportada.Text + " - " + jsonProjectPath;
                        //this.txtNombreDelProyecto.Text = ActualProject.NombreProyecto;
                        padre.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[MDI_ID.ToString()].Text = ActualProject.NombreProyecto;

                        LEGACY_PROJECTJSON_PATH = saveFileDialog1.FileName;
                        UpdateJobStatus(true, $"Proyecto '{LEGACY_PROJECTJSON_PATH}' guardado!");
                    }

                    padre.toolLblActualMDIReporteName.Text = this.Text;
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString());
                }
            }
            else
            {
                errorProvider1.SetError(txtFallaReportada, "Ingresa la falla reportada!");
            }
        }

        private void txtNoDeReporteDelCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage_DatosDeConvenio_Click(object sender, EventArgs e)
        {

        }
    }
}
