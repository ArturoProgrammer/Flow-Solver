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

using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

using CustomMessageBox;


namespace Flow_Solver
{
    public partial class datos_equipo : Form
    {
        private añadir_equipo padre;
        public datos_equipo(añadir_equipo LegacyForm)
        {
            padre = LegacyForm;
            InitializeComponent();

            if (padre.justResguardCard)
            {
                this.btnGuardarDatosDeAccesorios.Enabled = false;
            }
        }

        bool CLOSE_FLAG = true;

        /* DATOS DE ACCESORIOS */
        /** CARGADOR **/
        public static string CARGADOR_MARCA = "";
        public static string CARGADOR_MODELO = "";
        public static string CARGADOR_SERIE = "";
        /** UPS **/
        public static string UPS_MARCA = "";
        public static string UPS_MODELO = "";
        public static string UPS_SERIE = "";
        /** MONITOR **/
        public static string MONITOR_MARCA = "";
        public static string MONITOR_MODELO = "";
        public static string MONITOR_SERIE = "";
        /** EXTRA 1 **/
        public static string EXTRA1_TIPO = "";
        public static string EXTRA1_MARCA = "";
        public static string EXTRA1_MODELO = "";
        public static string EXTRA1_SERIE = "";
        /** EXTRA 2 **/
        public static string EXTRA2_TIPO = "";
        public static string EXTRA2_MARCA = "";
        public static string EXTRA2_MODELO = "";
        public static string EXTRA2_SERIE = "";


        private void AsignacionDeDatosAForm()
        {
            if (this.chckboxCargador.Checked | this.chckboxUPS.Checked | this.chckboxMonitor.Checked | this.chckboxExtra1.Checked | this.chckboxExtra2.Checked)
            {
                añadir_equipo.CARGADOR_MARCA = CARGADOR_MARCA;
                añadir_equipo.CARGADOR_MODELO = CARGADOR_MODELO;
                añadir_equipo.CARGADOR_SERIE = CARGADOR_SERIE;

                añadir_equipo.UPS_MARCA = UPS_MARCA;
                añadir_equipo.UPS_MODELO = UPS_MODELO;
                añadir_equipo.UPS_SERIE = UPS_SERIE;

                añadir_equipo.MONITOR_MARCA = MONITOR_MARCA;
                añadir_equipo.MONITOR_MODELO = MONITOR_MODELO;
                añadir_equipo.MONITOR_SERIE = MONITOR_SERIE;
            
                añadir_equipo.EXTRA1_TIPO = EXTRA1_TIPO;
                añadir_equipo.EXTRA1_MARCA = EXTRA1_MARCA;
                añadir_equipo.EXTRA1_MODELO = EXTRA1_MODELO;
                añadir_equipo.EXTRA1_SERIE = EXTRA1_SERIE;

                añadir_equipo.EXTRA2_TIPO = EXTRA2_TIPO;
                añadir_equipo.EXTRA2_MARCA = EXTRA2_MARCA;
                añadir_equipo.EXTRA2_MODELO = EXTRA2_MODELO;
                añadir_equipo.EXTRA2_SERIE = EXTRA2_SERIE;

                RJMessageBox.Show("Datos de accesorios guardados con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void datos_equipo_Load(object sender, EventArgs e)
        {
            #region CODIGO DE ASIGNACION
            this.numericHDD.Enabled = false;
            this.numericSSD.Enabled = false;

            this.chckboxCargador.Checked = false;
            this.chckboxUPS.Checked = false;
            this.chckboxMonitor.Checked = false;
            this.chckboxExtra1.Checked = false;
            this.chckboxExtra2.Checked = false;

            // CARGADOR
            lblCargadorMarca.Enabled = false;
            lblCargadorModelo.Enabled = false;
            lblCargadorSerie.Enabled = false;
            txtCargadorMarca.Enabled = false;
            txtCargadorModelo.Enabled = false;
            txtCargadorSerie.Enabled = false;

            // UPS
            lblUPSMarca.Enabled = false;
            lblUPSModelo.Enabled = false;
            lblUPSSerie.Enabled = false;
            txtUPSMarca.Enabled = false;
            txtUPSModelo.Enabled = false;
            txtUPSSerie.Enabled = false;

            // MONITOR
            lblMonitorMarca.Enabled = false;
            lblMonitorModelo.Enabled = false;
            lblMonitorSerie.Enabled = false;
            txtMonitorMarca.Enabled = false;
            txtMonitorModelo.Enabled = false;
            txtMonitorSerie.Enabled = false;

            // EXTRA 1
            txtTipo1.Enabled = false;
            lblExtra1Marca.Enabled = false;
            lblExtra1Modelo.Enabled = false;
            lblExtra1Serie.Enabled = false;
            txtExtra1Marca.Enabled = false;
            txtExtra1Modelo.Enabled = false;
            txtExtra1Serie.Enabled = false;

            // EXTRA
            txtTipo2.Enabled = false;
            lblExtra2Marca.Enabled = false;
            lblExtra1Marca.Enabled = false;
            lblExtra2Modelo.Enabled = false;
            lblExtra2Serie.Enabled = false;
            txtExtra2Marca.Enabled = false;
            txtExtra2Modelo.Enabled = false;
            txtExtra2Serie.Enabled = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;

            /* CARGADOR DE LOS DATOS DEL ARCHIVO JSON (EN CASO DE HABERSE USADO) */
            this.txtProcesador.Text = añadir_equipo.EQUIPO_PROCESADOR;
            añadir_equipo.EQUIPO_FRECUENCIA = añadir_equipo.EQUIPO_FRECUENCIA.Replace("GHz", String.Empty);
            añadir_equipo.EQUIPO_FRECUENCIA = añadir_equipo.EQUIPO_FRECUENCIA.Replace("@", String.Empty);
            añadir_equipo.EQUIPO_FRECUENCIA = añadir_equipo.EQUIPO_FRECUENCIA.Trim();
            this.txtFrecuenciaProcesador.Text = añadir_equipo.EQUIPO_FRECUENCIA;
            if (!String.IsNullOrEmpty(añadir_equipo.EQUIPO_RAM))
            {
                this.numericRam.Value = decimal.Parse(añadir_equipo.EQUIPO_RAM);
            }
            this.cboxAlmacenamientoTipo.Text = añadir_equipo.EQUIPO_ALMACENAMIENTO_TIPO;
            if (!String.IsNullOrEmpty(añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD.Trim()))
            {
                this.numericHDD.Value = decimal.Parse(añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD);
            }
            if (!String.IsNullOrEmpty(añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD.Trim()))
            {
                this.numericSSD.Value = decimal.Parse(añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD);
            }
            if (!String.IsNullOrEmpty(añadir_equipo.EQUIPO_UNIDADOPTICA.Trim()))
            {
                this.chckboxUnidadOptica.Checked = bool.Parse(añadir_equipo.EQUIPO_UNIDADOPTICA);
            }
            #endregion
        }

        private void MakeData (bool GenCard)
        {
            #region ASIGNACION DE VALORES
            /* DATOS DE HARDWARE */
            añadir_equipo.EQUIPO_PROCESADOR = this.txtProcesador.Text;
            añadir_equipo.EQUIPO_FRECUENCIA = "@ " + this.txtFrecuenciaProcesador.Text + " GHz";
            añadir_equipo.EQUIPO_RAM = this.numericRam.Text;
            añadir_equipo.EQUIPO_ALMACENAMIENTO_TIPO = this.cboxAlmacenamientoTipo.Text;

            if (cboxAlmacenamientoTipo.Text == "Ambos")
            {
                añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD = this.numericSSD.Value.ToString();
                añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD = this.numericHDD.Value.ToString();
            }
            else if (cboxAlmacenamientoTipo.Text == "HDD")
            {
                añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD = this.numericHDD.Value.ToString();
            }
            else if (cboxAlmacenamientoTipo.Text == "SSD")
            {
                añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD = this.numericSSD.Value.ToString();
            }

            if (this.chckboxUnidadOptica.Checked == true)
            {
                añadir_equipo.EQUIPO_UNIDADOPTICA = "Lector Optico DVD/CD";
            }


            /* DATOS DE SOFTWARES INSTALADOS */
            añadir_equipo.EQUIPO_SOFTWARE_1 = this.txtSoftware1.Text;
            añadir_equipo.EQUIPO_SOFTWARE_1_VERSION = this.txtSoftwareVersion1.Text;
            añadir_equipo.EQUIPO_SOFTWARE_1_IDIOMA = this.cboxSoftwareIdioma1.Text;

            añadir_equipo.EQUIPO_SOFTWARE_2 = this.txtSoftware2.Text;
            añadir_equipo.EQUIPO_SOFTWARE_2_VERSION = this.txtSoftwareVersion2.Text;
            añadir_equipo.EQUIPO_SOFTWARE_2_IDIOMA = this.cboxSoftwareIdioma2.Text;

            añadir_equipo.EQUIPO_SOFTWARE_3 = this.txtSoftware3.Text;
            añadir_equipo.EQUIPO_SOFTWARE_3_VERSION = this.txtSoftwareVersion3.Text;
            añadir_equipo.EQUIPO_SOFTWARE_3_IDIOMA = this.cboxSoftwareIdioma3.Text;

            añadir_equipo.EQUIPO_SOFTWARE_4 = this.txtSoftware4.Text;
            añadir_equipo.EQUIPO_SOFTWARE_4_VERSION = this.txtSoftwareVersion4.Text;
            añadir_equipo.EQUIPO_SOFTWARE_4_IDIOMA = this.cboxSoftwareIdioma4.Text;

            añadir_equipo.EQUIPO_SOFTWARE_5 = this.txtSoftware5.Text;
            añadir_equipo.EQUIPO_SOFTWARE_5_VERSION = this.txtSoftwareVersion5.Text;
            añadir_equipo.EQUIPO_SOFTWARE_5_IDIOMA = this.cboxSoftwareIdioma5.Text;




            /* DATOS DE LOS ACCESORIOS */
            if (this.chckboxCargador.Checked)
            {
                añadir_equipo.CARGADOR = true;
                CARGADOR_MARCA = this.txtCargadorMarca.Text;
                CARGADOR_MODELO = this.txtCargadorModelo.Text;
                CARGADOR_SERIE = this.txtCargadorSerie.Text;
            }
            if (this.chckboxUPS.Checked)
            {
                añadir_equipo.UPS = true;
                UPS_MARCA = this.txtUPSMarca.Text;
                UPS_MODELO = this.txtUPSModelo.Text;
                UPS_SERIE = this.txtUPSSerie.Text;
            }
            if (this.chckboxMonitor.Checked)
            {
                añadir_equipo.MONITOR = true;
                MONITOR_MARCA = this.txtMonitorMarca.Text;
                MONITOR_MODELO = this.txtMonitorModelo.Text;
                MONITOR_SERIE = this.txtMonitorSerie.Text;
            }
            if (this.chckboxExtra1.Checked)
            {
                EXTRA1_MARCA = this.txtExtra1Marca.Text;
                EXTRA1_MODELO = this.txtExtra1Modelo.Text;
                EXTRA1_SERIE = this.txtExtra1Serie.Text;
            }
            if (this.chckboxExtra2.Checked)
            {
                EXTRA2_MARCA = this.txtExtra2Marca.Text;
                EXTRA2_MODELO = this.txtExtra2Modelo.Text;
                EXTRA2_SERIE = this.txtExtra2Serie.Text;
            }

            EXTRA1_TIPO = txtTipo1.Text;
            EXTRA2_TIPO = txtTipo2.Text;

            AsignacionDeDatosAForm();
            #endregion

            if (GenCard) { GenerateResponsiveLetter(); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MakeData(true);
            añadir_equipo.RESGUARDO_CREATED = true;
            CLOSE_FLAG = false;
        }


        private void cboxAlmacenamientoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAlmacenamientoTipo.Text == "Ambos")
            {
                this.numericHDD.Enabled = true;
                this.numericSSD.Enabled = true;
            } else if (cboxAlmacenamientoTipo.Text == "HDD")
            {
                this.numericHDD.Enabled = true;
                this.numericSSD.Enabled = false;
            } else if (cboxAlmacenamientoTipo.Text == "SSD")
            {
                this.numericSSD.Enabled = true;
                this.numericHDD.Enabled = false;
            }   
        }

        public void GenerateResponsiveLetter()
        {

            // Genera la carta resguardo lista para impresion en caso de necesitarse
            string path_origin = Properties.Settings.Default.ActaResponsivaPath;

            int LAST_TOOLBOX = 1;

            if (File.Exists(path_origin))
            {
                string destiny_responsivefile = $@"{Properties.Settings.Default.RITFormPathDestiny}\RITs\Resguardos";
                // Generamos la carta con los datos
                string pdfCartaResguardoTemplate = path_origin;

                if (!Directory.Exists(destiny_responsivefile))
                {
                    Directory.CreateDirectory(destiny_responsivefile);
                }

                string newFileToDelete = $@"{destiny_responsivefile}\{añadir_equipo.USUARIO_NOEMPLEADO} - {añadir_equipo.USUARIO_NOMBRE} - {padre.txtMarca.Text} {padre.txtModelo.Text}.pdf";

                PdfReader pdfReader = new PdfReader(pdfCartaResguardoTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFileToDelete, FileMode.Create));

                AcroFields pdfFormFields = pdfStamper.AcroFields;

                DateTime fechaActual = DateTime.Now;
                string fecha_hoy = $"{fechaActual.Day}/{fechaActual.ToString("MMMM")}/{fechaActual.Year.ToString()}";

                /** ==============================[ HOJA 1 ]============================== **/
                pdfFormFields.SetField("FECHA_1", fecha_hoy);
                pdfFormFields.SetField("NUMERO_SERIE_EQUIPO", padre.txtNumeroDeSerie.Text);
                /* 
                 * CAMPOS DE SOFTWARE
                 * */
                // SOFTWARE 1
                pdfFormFields.SetField("SOFTWARE_1", añadir_equipo.EQUIPO_SOFTWARE_1);
                pdfFormFields.SetField("SOFTWARE_1_VERSION", añadir_equipo.EQUIPO_SOFTWARE_1_VERSION);
                pdfFormFields.SetField("SOFTWARE_1_LENGUAJE", añadir_equipo.EQUIPO_SOFTWARE_1_IDIOMA);
                // SOFTWARE 2
                pdfFormFields.SetField("SOFTWARE_2", añadir_equipo.EQUIPO_SOFTWARE_2);
                pdfFormFields.SetField("SOFTWARE_2_VERSION", añadir_equipo.EQUIPO_SOFTWARE_2_VERSION);
                pdfFormFields.SetField("SOFTWARE_2_LENGUAJE", añadir_equipo.EQUIPO_SOFTWARE_2_IDIOMA);
                // SOFTWARE 3
                pdfFormFields.SetField("SOFTWARE_3", añadir_equipo.EQUIPO_SOFTWARE_3);
                pdfFormFields.SetField("SOFTWARE_3_VERSION", añadir_equipo.EQUIPO_SOFTWARE_3_VERSION);
                pdfFormFields.SetField("SOFTWARE_3_LENGUAJE", añadir_equipo.EQUIPO_SOFTWARE_3_IDIOMA);
                // SOFTWARE 4
                pdfFormFields.SetField("SOFTWARE_4", añadir_equipo.EQUIPO_SOFTWARE_4);
                pdfFormFields.SetField("SOFTWARE_4_VERSION", añadir_equipo.EQUIPO_SOFTWARE_4_VERSION);
                pdfFormFields.SetField("SOFTWARE_4_LENGUAJE", añadir_equipo.EQUIPO_SOFTWARE_4_IDIOMA);
                // SOFTWARE 5
                pdfFormFields.SetField("SOFTWARE_5", añadir_equipo.EQUIPO_SOFTWARE_5);
                pdfFormFields.SetField("SOFTWARE_5_VERSION", añadir_equipo.EQUIPO_SOFTWARE_5_VERSION);
                pdfFormFields.SetField("SOFTWARE_5_LENGUAJE", añadir_equipo.EQUIPO_SOFTWARE_5_IDIOMA);
                pdfFormFields.SetField("Firma_1", añadir_equipo.USUARIO_NOMBRE);


                /** ==============================[ HOJA 2 ]============================== **/
                pdfFormFields.SetField("FECHA_2", fecha_hoy);
                pdfFormFields.SetField("EQUIPO_1", padre.txtTipoDeEquipo.Text);
                pdfFormFields.SetField("EQUIPO_1_MARCA", padre.txtMarca.Text);
                pdfFormFields.SetField("EQUIPO_1_MODELO", padre.txtModelo.Text);
                pdfFormFields.SetField("EQUIPO_1_NUMERO DE SERIE", padre.txtNumeroDeSerie.Text);
                pdfFormFields.SetField("EQUIPO_1_REFERENCIA", padre.txtHOSTNAME.Text);
                LAST_TOOLBOX++;

                /* 
                 * CAMPOS DE ESPECIFICACIONES
                 * */
                pdfFormFields.SetField("PROCESADOR_MODELO", añadir_equipo.EQUIPO_PROCESADOR);
                pdfFormFields.SetField("PROCESADOR_ESPECIFICACIONES", "@ " + this.txtFrecuenciaProcesador.Text + " GHz");
                pdfFormFields.SetField("MEMORIA_RAM", añadir_equipo.EQUIPO_RAM + " GB");

                if (this.cboxAlmacenamientoTipo.Text == "HDD")
                {
                    pdfFormFields.SetField("ALMACENAMIENTO", "HDD " + añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD + " GB");
                } 
                else if (this.cboxAlmacenamientoTipo.Text == "SSD")
                {
                    pdfFormFields.SetField("ALMACENAMIENTO", "SSD " + añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD + " GB");
                }
                else if (this.cboxAlmacenamientoTipo.Text == "Ambos")
                {
                    pdfFormFields.SetField("ALMACENAMIENTO", $"{añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD} GB HDD y {añadir_equipo.EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD} GB SSD");
                }

                if (this.chckboxUnidadOptica.Checked == true)
                {
                    pdfFormFields.SetField("UNIDAD_OPTICA", añadir_equipo.EQUIPO_UNIDADOPTICA);
                }


                /* CAMPOS DE ACCESORIOS DEL EQUIPO */
                /** CARGADOR **/
                if (this.chckboxCargador.Checked) {
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}", "CARGADOR");
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MARCA", CARGADOR_MARCA);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MODELO", CARGADOR_MODELO);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_NUMERO DE SERIE", CARGADOR_SERIE);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_REFERENCIA", padre.txtHOSTNAME.Text);
                    LAST_TOOLBOX++;
                }
                /** UPS **/
                if (this.chckboxUPS.Checked)
                {
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}", "UPS");
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MARCA", UPS_MARCA);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MODELO", UPS_MODELO);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_NUMERO DE SERIE", UPS_SERIE);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_REFERENCIA", padre.txtHOSTNAME.Text);
                    LAST_TOOLBOX++;
                }
                if (this.chckboxMonitor.Checked)
                {
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}", "MONITOR");
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MARCA", MONITOR_MARCA);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MODELO", MONITOR_MODELO);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_NUMERO DE SERIE", MONITOR_SERIE);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_REFERENCIA", padre.txtHOSTNAME.Text);
                    LAST_TOOLBOX++;
                }
                if (this.chckboxExtra1.Checked)
                {
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}", this.txtTipo1.Text);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MARCA", EXTRA1_MARCA);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MODELO", EXTRA1_MODELO);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_NUMERO DE SERIE", EXTRA1_SERIE);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_REFERENCIA", padre.txtHOSTNAME.Text);
                    LAST_TOOLBOX++;
                }
                if (this.chckboxExtra2.Checked)
                {
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}", this.txtTipo2.Text);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MARCA", EXTRA2_MARCA);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_MODELO", EXTRA2_MODELO);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_NUMERO DE SERIE", EXTRA2_SERIE);
                    pdfFormFields.SetField($"EQUIPO_{LAST_TOOLBOX}_REFERENCIA", padre.txtHOSTNAME.Text);
                    LAST_TOOLBOX++;
                }

                /* 
                 * CAMPOS DE DATOS DEL EMPLEADO
                 * */
                pdfFormFields.SetField("NUM_DE_EMPLEADO", añadir_equipo.USUARIO_NOEMPLEADO);
                pdfFormFields.SetField("NOMBRE", añadir_equipo.USUARIO_NOMBRE);
                pdfFormFields.SetField("DEPARTAMENTO", añadir_equipo.USUARIO_DEPARTAMENTO);
                pdfFormFields.SetField("SUBDIRECCION", añadir_equipo.USUARIO_SUBDIRECCION);
                pdfFormFields.SetField("DIRECCION_DE_AREA", añadir_equipo.USUARIO_DIRECCIONADJUNTA);
                pdfFormFields.SetField("DIRECCION", añadir_equipo.USUARIO_DIRECCION);
                pdfFormFields.SetField("DIVISION", añadir_equipo.USUARIO_DIVISION);
                pdfFormFields.SetField("UBICACION", añadir_equipo.USUARIO_UBICACION);
                pdfFormFields.SetField("PUESTO", añadir_equipo.USUARIO_PUESTO);
                pdfFormFields.SetField("CENTRO_DE_COSTOS", añadir_equipo.USUARIO_CENTRODECOSTOS);

                pdfFormFields.SetField("Firma_2", añadir_equipo.USUARIO_NOMBRE);

                pdfStamper.Close();

                // Eliminamos despues de imprimir

                /*
                printDocument1.DocumentName = newFileToDelete;

                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (RJMessageBox.Show() == DialogResult.Yes)
                    printDocument1.Print();
                }*/

                // Informamos a la grabadora de eventos
                string targetPath = $@"{Application.StartupPath}\Inventories\{padre.txtHOSTNAME.Text}{MachineEventsHistorial.FileSuffix}";
                MachineEventsHistorial rec = new MachineEventsHistorial(targetPath);
                rec.AddEvent(M_EventItem.FromTemplate_ResguardCardMaked(newFileToDelete, padre.cboxUsuario.Text));
                rec.Save();

                // Mandamos a imprimir la carta de resguardo
                PrinterForm frm = new PrinterForm(newFileToDelete, "datos_equipo", this);
                frm.ShowDialog();
            }
            else
            {
                RJMessageBox.Show("No se ha encontrado el archivo de origen para el formato Acta Responsiva!", "Añadir equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datos_equipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        #region REGION DE CHECKBOXES DE ACCESORIOS
        private void chckboxCargador_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxCargador.Checked)
            {
                lblCargadorMarca.Enabled = true;
                lblCargadorModelo.Enabled = true;
                lblCargadorSerie.Enabled = true;
                txtCargadorMarca.Enabled = true;
                txtCargadorModelo.Enabled = true;
                txtCargadorSerie.Enabled = true;
            } else
            {
                lblCargadorMarca.Enabled = false;
                lblCargadorModelo.Enabled = false;
                lblCargadorSerie.Enabled = false;
                txtCargadorMarca.Enabled = false;
                txtCargadorModelo.Enabled = false;
                txtCargadorSerie.Enabled = false;
            }
        }

        private void chckboxUPS_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxUPS.Checked)
            {
                lblUPSMarca.Enabled = true;
                lblUPSModelo.Enabled = true;
                lblUPSSerie.Enabled = true;
                txtUPSMarca.Enabled = true;
                txtUPSModelo.Enabled = true;
                txtUPSSerie.Enabled = true;
            } else
            {
                lblUPSMarca.Enabled = false;
                lblUPSModelo.Enabled = false;
                lblUPSSerie.Enabled = false;
                txtUPSMarca.Enabled = false;
                txtUPSModelo.Enabled = false;
                txtUPSSerie.Enabled = false;
            }
        }

        private void chckboxMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxMonitor.Checked)
            {
                lblMonitorMarca.Enabled = true;
                lblMonitorModelo.Enabled = true;
                lblMonitorSerie.Enabled = true;
                txtMonitorMarca.Enabled = true;
                txtMonitorModelo.Enabled = true;
                txtMonitorSerie.Enabled = true;
            } else
            {
                lblMonitorMarca.Enabled = false;
                lblMonitorModelo.Enabled = false;
                lblMonitorSerie.Enabled = false;
                txtMonitorMarca.Enabled = false;
                txtMonitorModelo.Enabled = false;
                txtMonitorSerie.Enabled = false;
            }
        }

        private void chckboxExtra1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxExtra1.Checked)
            {
                checkBox1.Enabled = true;
                txtTipo1.Enabled = true;
                lblExtra1Marca.Enabled = true;
                lblExtra1Modelo.Enabled = true;
                lblExtra1Serie.Enabled = true;
                txtExtra1Marca.Enabled = true;
                txtExtra1Modelo.Enabled = true;
                txtExtra1Serie.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                txtTipo1.Enabled = false;
                lblExtra1Marca.Enabled = false;
                lblExtra1Modelo.Enabled = false;
                lblExtra1Serie.Enabled = false;
                txtExtra1Marca.Enabled = false;
                txtExtra1Modelo.Enabled = false;
                txtExtra1Serie.Enabled = false;
            }
        }

        private void chckboxExtra2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckboxExtra2.Checked)
            {
                checkBox2.Enabled = true;
                txtTipo2.Enabled = true;
                lblExtra2Marca.Enabled = true;
                lblExtra2Modelo.Enabled = true;
                lblExtra2Serie.Enabled = true;
                txtExtra2Marca.Enabled = true;
                txtExtra2Modelo.Enabled = true;
                txtExtra2Serie.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                txtTipo2.Enabled = false;
                lblExtra2Marca.Enabled = false;
                lblExtra2Modelo.Enabled = false;
                lblExtra2Serie.Enabled = false;
                txtExtra2Marca.Enabled = false;
                txtExtra2Modelo.Enabled = false;
                txtExtra2Serie.Enabled = false;
            }
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                añadir_equipo.EXTRA1 = true;
            }
            else
            {
                añadir_equipo.EXTRA1 = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                añadir_equipo.EXTRA2 = true;
            }
            else
            {
                añadir_equipo.EXTRA2 = false;
            }
        }

        private void datos_equipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CLOSE_FLAG)
            {
                if (RJMessageBox.Show("¿Seguro que desea cerrar? perdera los datos del resguardo a excepcion de los accesorios", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // ASIGNA LOS DATOS DE RESGUARDO PARA LOS ACCESORIOS
                    MakeData(false);
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnGuardarDatosDeAccesorios_Click(object sender, EventArgs e)
        {
            MakeData(false);
            CLOSE_FLAG = false;
            this.Close();
        }

        private void txtTipo1_Enter(object sender, EventArgs e)
        {
            if (this.txtTipo1.Text == "Tipo de equipo")
            {
                this.txtTipo1.Text = string.Empty;
            }
        }

        private void txtTipo2_Enter(object sender, EventArgs e)
        {
            if (this.txtTipo2.Text == "Tipo de equipo")
            {
                this.txtTipo2.Text = string.Empty;
            }
        }
    }
}
