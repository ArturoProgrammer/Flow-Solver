using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

using SpreadsheetLight;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DocumentFormat.OpenXml;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class añadir_equipo : Form
    {
        private inventarios padre;

        /* DATOS DE HARDWARE */
        public static string EQUIPO_PROCESADOR = "";
        public static string EQUIPO_FRECUENCIA = "";
        public static string EQUIPO_RAM = "";
        public static string EQUIPO_ALMACENAMIENTO_TIPO = "";
        public static string EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD = "";
        public static string EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD = "";
        public static string EQUIPO_UNIDADOPTICA = "";


        /* DATOS DE SOFTWARE */
        public static string EQUIPO_SOFTWARE_1;
        public static string EQUIPO_SOFTWARE_1_VERSION;
        public static string EQUIPO_SOFTWARE_1_IDIOMA;

        public static string EQUIPO_SOFTWARE_2;
        public static string EQUIPO_SOFTWARE_2_VERSION;
        public static string EQUIPO_SOFTWARE_2_IDIOMA;

        public static string EQUIPO_SOFTWARE_3;
        public static string EQUIPO_SOFTWARE_3_VERSION;
        public static string EQUIPO_SOFTWARE_3_IDIOMA;

        public static string EQUIPO_SOFTWARE_4;
        public static string EQUIPO_SOFTWARE_4_VERSION;
        public static string EQUIPO_SOFTWARE_4_IDIOMA;

        public static string EQUIPO_SOFTWARE_5;
        public static string EQUIPO_SOFTWARE_5_VERSION;
        public static string EQUIPO_SOFTWARE_5_IDIOMA;


        /* ACCESORIOS EN EXISTENCIA */
        public static bool CARGADOR = false;
        public static bool UPS = false;
        public static bool MONITOR = false;
        public static bool EXTRA1 = false;
        public static bool EXTRA2 = false;


        /* BANDERA DE RESGUARDO GENERADO */
        public static bool RESGUARDO_CREATED = false;

        /* 
         * Sobrecarga para llamado desde inventario
         * Tarea: añadir equipo nuevo
         * */


        public añadir_equipo(inventarios LegacyForm)
        {
            InitializeComponent();

            this.dataGridView1.Visible = false;

            padre = LegacyForm;


            // Valores por defecto de cboxUsuario
            this.cboxUsuario.Items.Add("---------Seleccionar usuario---------");
            this.cboxUsuario.Items.Add("> Nuevo usuario ...");
            UsersCardsLoadMethod();
            this.cboxUsuario.SelectedIndex = 0;
        }

        internal bool justResguardCard = false;
        /* 
         * Sobrecarga para llamado desde inventario
         * Tarea: solo generar resguardo o modificar equipo
         * */
        public añadir_equipo(inventarios LegacyForm, bool _JustResguardCard)
        {
            justResguardCard = _JustResguardCard;
            InitializeComponent();
            padre = LegacyForm;

            /** Cargamos los datos iniciales del equipo actual **/
            var grilla = padre.dataGridView1;
            this.dataGridView1.Visible = false;

            // Valores por defecto de cboxUsuario
            this.cboxUsuario.Items.Add("---------Seleccionar usuario---------");
            this.cboxUsuario.Items.Add("> Nuevo usuario ...");
            UsersCardsLoadMethod();

            if (justResguardCard)
            {
                if (cboxUsuario.Items.Contains(padre.ActualMachine.NOMBRE))
                {
                    this.cboxUsuario.Text = padre.ActualMachine.NOMBRE;
                } else
                {
                    this.cboxUsuario.SelectedIndex = 0;
                }

                this.txtMarca.Text = padre.ActualMachine.Marca;
                this.txtModelo.Text = padre.ActualMachine.Modelo;
                this.txtTipoDeEquipo.Text = padre.ActualMachine.TipoDeEquipo;
                this.txtNumeroDeSerie.Text = padre.ActualMachine.SN;
                this.txtUbicacion.Text = padre.ActualMachine.Ubicacion;
                this.txtHOSTNAME.Text = padre.ActualMachine.HOSTNAME;
                this.txtComentario.Text = padre.ActualMachine.Comentarios;

                this.btnGuardar.Enabled = false;
            }
        }

        #region METODOS DEL CODIGO
        private void UsersCardsLoadMethod ()
        {
            string path = $@"{Application.StartupPath}\UsersCard\";


            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles("*.card");
                foreach (FileInfo file in files)
                {
                    int s_len = file.Name.Length;

                    this.cboxUsuario.Items.Add(file.Name.Remove(s_len - 13, 13));
                }
            }
        }
        #endregion

        
        // Lista publica para aaceder y añadir con posterioridad
        public List<PuestosViewModel> lst = new List<PuestosViewModel>();
        private MachinesModelsSync machinesModels = MachinesModelsSync.Load();

        /* Al cargar el formulario */
        private void añadir_equipo_Load(object sender, EventArgs e)
        {
            /* CARGAMOS LOS VALORES POR DEFECTO */
            
            string file_path = $@"{Application.StartupPath}\PUESTOS DE TRABAJO.xlsx";

            // Valores por defecto del cboxPuestos
            if (File.Exists(file_path))
            {
                SLDocument sl = new SLDocument(file_path, "Base de Datos");
                try
                {
                    int iRow = 1;

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        PuestosViewModel oPuesto = new PuestosViewModel();

                        oPuesto.Puesto = sl.GetCellValueAsString(iRow, 1);
                        oPuesto.Division = sl.GetCellValueAsString(iRow, 2);
                        oPuesto.Localidad = sl.GetCellValueAsString(iRow, 3);
                        oPuesto.DireccionGeneralAdjunta = sl.GetCellValueAsString(iRow, 4);
                        oPuesto.Direccion = sl.GetCellValueAsString(iRow, 5);
                        oPuesto.Subdireccion = sl.GetCellValueAsString(iRow, 6);
                        oPuesto.Gerencia = sl.GetCellValueAsString(iRow, 7);
                        oPuesto.Jefatura = sl.GetCellValueAsString(iRow, 8);
                        oPuesto.CentroDeCostos = sl.GetCellValueAsString(iRow, 9);
                        oPuesto.DenominacionCentroDeCostos = sl.GetCellValueAsString(iRow, 10);

                        lst.Add(oPuesto);
                        iRow++;
                    }

                } catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Añadir equipo");
                }
            }

            foreach (PuestosViewModel i in lst)
            {
                this.cboxPuestoDelUsuario.Items.Add(i.Puesto);
            }
            dataGridView1.DataSource = lst;

            AutoCompleteStringCollection savedModels = new AutoCompleteStringCollection();
            foreach (MachineModelSyncItem m in MachinesModelsSync.Load().Items)
            {
                savedModels.Add(m.NombreComercial);
            }
            this.txtModelo.AutoCompleteCustomSource = savedModels;
        }

        public static string USUARIO_NOMBRE;
        public static string USUARIO_NOEMPLEADO;
        public static string USUARIO_EXTENSION;
        public static string USUARIO_RED;
        public static string USUARIO_EMAIL;
        public static string USUARIO_DEPARTAMENTO;

        private void cboxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local_path = $@"{Application.StartupPath}\UsersCard\";

            switch (this.cboxUsuario.Text)
            {
                case "> Nuevo usuario ...":
                    añadir_usuario frm = new añadir_usuario(this.Name);
                    frm.ShowDialog();


                    break;
                case "---------Seleccionar usuario---------":
                    break;
                default:
                    string usuario = this.cboxUsuario.Text;

                    if (File.Exists($@"{local_path}\{usuario}_Profile.card"))
                    {
                        string json_card = File.ReadAllText($@"{local_path}\{usuario}_Profile.card");
                        JObject json_parsed = JObject.Parse(json_card);

                        USUARIO_NOMBRE = json_parsed["nombre"].ToString();
                        USUARIO_NOEMPLEADO = json_parsed["no_empleado"].ToString();
                        USUARIO_EXTENSION = json_parsed["extension"].ToString();
                        USUARIO_RED = json_parsed["red_user"].ToString();
                        USUARIO_EMAIL = json_parsed["mail"].ToString();
                        USUARIO_DEPARTAMENTO = json_parsed["departamento"].ToString();

                        this.lblDepartamento.Text = $"Departamento: {USUARIO_DEPARTAMENTO}";
                        this.lblNumeroDeEmpleado.Text = $"Num. Emp: {USUARIO_NOEMPLEADO}";
                    } else
                    {
                        RJMessageBox.Show("No existe la tarjeta el usuario solicitado! reinicie el inventario para crear una de manera automatica", "Añadir equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        public void ReloadMethod()
        {
            this.cboxUsuario.Items.Clear();

            this.cboxUsuario.Items.Add("---------Seleccionar usuario---------");
            this.cboxUsuario.Items.Add("> Nuevo usuario ...");
            UsersCardsLoadMethod();
            this.cboxUsuario.SelectedIndex = 0;
        }

        private void btnRecargarInventario_Click(object sender, EventArgs e)
        {
            ReloadMethod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.cboxUsuario.Text != "---------Seleccionar usuario---------" & this.cboxUsuario.Text != "> Nuevo usuario ...")
            {
                if (!string.IsNullOrEmpty(txtHOSTNAME.Text) & !string.IsNullOrEmpty(txtTipoDeEquipo.Text))
                {
                    USUARIO_SUBDIRECCION = this.cboxSubdireccion.Text;
                    USUARIO_DIRECCION = this.cboxDireccion.Text;
                    USUARIO_DIRECCIONADJUNTA = this.cboxDGA.Text;

                    datos_equipo frm = new datos_equipo(this);
                    frm.ShowDialog();
                } else
                {
                    RJMessageBox.Show("Debe llenar los campos obligatorios", "Añadir equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                RJMessageBox.Show("Debe seleccionar a un usuario!", "Añadir equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static string USUARIO_SUBDIRECCION;
        public static string USUARIO_DIRECCIONADJUNTA;
        public static string USUARIO_DIRECCION;
        public static string USUARIO_DIVISION;
        public static string USUARIO_CENTRODECOSTOS;
        public static string USUARIO_UBICACION;
        public static string USUARIO_PUESTO;

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            añadir_usuario frm = new añadir_usuario(this.Name);
            frm.ShowDialog();
        }

        private void cboxPuestoDelUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puesto_select = this.cboxPuestoDelUsuario.Text;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                int strFila = Row.Index;
                string puesto = Convert.ToString(Row.Cells["Puesto"].Value);

                if (puesto.Trim() == this.cboxPuestoDelUsuario.Text.Trim()) {
                    //lblSubdireccion.Text = $"Subdireccion: {dataGridView1.Rows[strFila].Cells["Subdireccion"].Value.ToString()}";
                    //lblDireccionAdjunta.Text = $"Direccion Adjunta: {dataGridView1.Rows[strFila].Cells["DireccionGeneralAdjunta"].Value.ToString()}";
                    //lblDireccion.Text = $"Direccion: {dataGridView1.Rows[strFila].Cells["Direccion"].Value.ToString()}";
                    this.txtCentroCostos.Text = dataGridView1.Rows[strFila].Cells["CentroDeCostos"].Value.ToString();

                    USUARIO_PUESTO = this.cboxPuestoDelUsuario.Text;
                    USUARIO_CENTRODECOSTOS = dataGridView1.Rows[strFila].Cells["CentroDeCostos"].Value.ToString();
                }
            }
        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {
            USUARIO_UBICACION = this.txtUbicacion.Text;
            this.txtUbicacion.Text = this.txtUbicacion.Text.ToUpper();
        }


        #region DATOS DE ACCESORIOS IMPORTADOS DEL FORM DATOS_EQUIPO
        /* DATOS DE ACCESORIOS */
        /** CARGADOR **/
        public static string CARGADOR_MARCA;
        public static string CARGADOR_MODELO;
        public static string CARGADOR_SERIE;
        /** UPS **/
        public static string UPS_MARCA;
        public static string UPS_MODELO;
        public static string UPS_SERIE;
        /** MONITOR **/
        public static string MONITOR_MARCA;
        public static string MONITOR_MODELO;
        public static string MONITOR_SERIE;
        /** EXTRA 1 **/
        public static string EXTRA1_TIPO;
        public static string EXTRA1_MARCA;
        public static string EXTRA1_MODELO;
        public static string EXTRA1_SERIE;
        /** EXTRA 2 **/
        public static string EXTRA2_TIPO;
        public static string EXTRA2_MARCA;
        public static string EXTRA2_MODELO;
        public static string EXTRA2_SERIE;
        #endregion

        private void LimpiezaDeVariables ()
        {
            /** CARGAODR **/
            CARGADOR_MARCA = "";
            CARGADOR_MODELO = "";
            CARGADOR_SERIE = "";
            /** UPS **/
            UPS_MARCA = "";
            UPS_MODELO = "";
            UPS_SERIE = "";
            /** MONITOR **/
            MONITOR_MARCA = "";
            MONITOR_MODELO = "";
            MONITOR_SERIE = "";
            /** EXTRA 1 **/
            EXTRA1_TIPO = "";
            EXTRA1_MARCA = "";
            EXTRA1_MODELO = "";
            EXTRA1_SERIE = "";
            /** EXTRA 2 **/
            EXTRA2_TIPO = "";
            EXTRA2_MARCA = "";
            EXTRA2_MODELO = "";
            EXTRA2_SERIE = "";

            CARGADOR = false;
            UPS = false;
            MONITOR = false;
            EXTRA1 = false;
            EXTRA2 = false;

            datos_equipo.EXTRA1_TIPO = "";
            datos_equipo.EXTRA2_TIPO = "";
        }



        public void btnGuardar_Click(object sender, EventArgs e)
        { 
            var grilla = padre.dataGridView1;
            string file_path = $@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx";

            
            
            if (!string.IsNullOrEmpty(txtMarca.Text) & !string.IsNullOrEmpty(cboxUsuario.Text) & !string.IsNullOrEmpty(txtModelo.Text) & !string.IsNullOrEmpty(txtTipoDeEquipo.Text) & !string.IsNullOrEmpty(txtNumeroDeSerie.Text) & !string.IsNullOrEmpty(txtHOSTNAME.Text))
            {
                /* PRIMERO VALIDAMOS LA EXISTENCIA DEL EQUIPO POR HOSTNAME Y SERIE */
                if (ExcelMake.ValidateMachineExistence(this, grilla, txtTipoDeEquipo.Text, txtHOSTNAME.Text, txtNumeroDeSerie.Text))
                {

                    List<InventarioViewModel> ulst = new List<InventarioViewModel>();

                    if (File.Exists(file_path))
                    {
                        SLDocument sl = new SLDocument(file_path);
                        try
                        {
                            // Añadimos los ya existentes
                            #region GRABAMOS LOS DATOS DE NUEVOS DE GRILLA ACTUAL
                            int iRow = 2;

                            // Carga los datos ya existentes
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

                                ulst.Add(oUsuario);
                                iRow++;
                            }

                            // Añadimos el equipo nuevo
                            iRow++;
                            InventarioViewModel nuevoEquipo = new InventarioViewModel();
                            nuevoEquipo.NOMBRE = USUARIO_NOMBRE;
                            nuevoEquipo.NumDeEmpleado = USUARIO_NOEMPLEADO;
                            nuevoEquipo.EXT = USUARIO_EXTENSION;
                            nuevoEquipo.USER = USUARIO_RED;
                            nuevoEquipo.MAIL = USUARIO_EMAIL;
                            nuevoEquipo.HOSTNAME = this.txtHOSTNAME.Text;
                            nuevoEquipo.TipoDeEquipo = this.txtTipoDeEquipo.Text;
                            nuevoEquipo.SN = this.txtNumeroDeSerie.Text;
                            nuevoEquipo.Marca = this.txtMarca.Text;
                            nuevoEquipo.Modelo = this.txtModelo.Text;
                            nuevoEquipo.Ubicacion = this.txtUbicacion.Text;
                            nuevoEquipo.Departamento = USUARIO_DEPARTAMENTO;
                            nuevoEquipo.Comentarios = this.txtComentario.Text;

                            ulst.Add(nuevoEquipo); // Añadimos el equipo al Array


                            /* AÑADIMOS LOS ACCESORIOS EN CASO DE EXISTIR */
                            if (UPS)
                            {
                                InventarioViewModel ups = new InventarioViewModel();
                                ups.NOMBRE = USUARIO_NOMBRE;
                                ups.NumDeEmpleado = USUARIO_NOEMPLEADO;
                                ups.EXT = USUARIO_EXTENSION;
                                ups.USER = USUARIO_RED;
                                ups.MAIL = USUARIO_EMAIL;
                                ups.HOSTNAME = this.txtHOSTNAME.Text;
                                ups.TipoDeEquipo = "UPS";
                                ups.SN = UPS_SERIE;
                                ups.Marca = UPS_MARCA;
                                ups.Modelo = UPS_MODELO;
                                ups.Ubicacion = this.txtUbicacion.Text;
                                ups.Departamento = USUARIO_DEPARTAMENTO;
                                ups.Comentarios = this.txtComentario.Text;

                                ulst.Add(ups);
                            }
                            if (MONITOR)
                            {
                                InventarioViewModel monitor = new InventarioViewModel();
                                monitor.NOMBRE = USUARIO_NOMBRE;
                                monitor.NumDeEmpleado = USUARIO_NOEMPLEADO;
                                monitor.EXT = USUARIO_EXTENSION;
                                monitor.USER = USUARIO_RED;
                                monitor.MAIL = USUARIO_EMAIL;
                                monitor.HOSTNAME = this.txtHOSTNAME.Text;
                                monitor.TipoDeEquipo = "MONITOR";
                                monitor.SN = MONITOR_SERIE;
                                monitor.Marca = MONITOR_MARCA;
                                monitor.Modelo = MONITOR_MODELO;
                                monitor.Ubicacion = this.txtUbicacion.Text;
                                monitor.Departamento = USUARIO_DEPARTAMENTO;
                                monitor.Comentarios = this.txtComentario.Text;

                                ulst.Add(monitor);
                            }
                            if (EXTRA1)
                            {
                                InventarioViewModel extra1 = new InventarioViewModel();
                                extra1.NOMBRE = USUARIO_NOMBRE;
                                extra1.NumDeEmpleado = USUARIO_NOEMPLEADO;
                                extra1.EXT = USUARIO_EXTENSION;
                                extra1.USER = USUARIO_RED;
                                extra1.MAIL = USUARIO_EMAIL;
                                extra1.HOSTNAME = this.txtHOSTNAME.Text;
                                extra1.TipoDeEquipo = EXTRA1_TIPO;
                                extra1.SN = EXTRA1_SERIE;
                                extra1.Marca = EXTRA1_MARCA;
                                extra1.Modelo = EXTRA1_MODELO;
                                extra1.Ubicacion = this.txtUbicacion.Text;
                                extra1.Departamento = USUARIO_DEPARTAMENTO;
                                extra1.Comentarios = this.txtComentario.Text;

                                ulst.Add(extra1);
                            }
                            if (EXTRA2)
                            {
                                InventarioViewModel extra2 = new InventarioViewModel();
                                extra2.NOMBRE = USUARIO_NOMBRE;
                                extra2.NumDeEmpleado = USUARIO_NOEMPLEADO;
                                extra2.EXT = USUARIO_EXTENSION;
                                extra2.USER = USUARIO_RED;
                                extra2.MAIL = USUARIO_EMAIL;
                                extra2.HOSTNAME = this.txtHOSTNAME.Text;
                                extra2.TipoDeEquipo = EXTRA2_TIPO;
                                extra2.SN = EXTRA2_SERIE;
                                extra2.Marca = EXTRA2_MARCA;
                                extra2.Modelo = EXTRA2_MODELO;
                                extra2.Ubicacion = this.txtUbicacion.Text;
                                extra2.Departamento = USUARIO_DEPARTAMENTO;
                                extra2.Comentarios = this.txtComentario.Text;

                                ulst.Add(extra2);
                            }
                            #endregion

                            #region GUARDAMOS EL NUEVO EXCEL ACTUALIZADO SEGUN LA GRILLA
                            if (padre.txtInventarioActual.Text == "Inventario de Usuarios y Equipos")
                            {
                                // Actualizamos grilla de form padre
                                grilla.DataSource = ulst;

                                // Proceso de guardado
                                try
                                {
                                    SLDocument nsl = new SLDocument();
                                    int iC = 1;
                                    foreach (DataGridViewColumn column in grilla.Columns)
                                    {
                                        nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                                        iC++;
                                    }

                                    int iR = 2;
                                    foreach (DataGridViewRow row in grilla.Rows)
                                    {
                                        nsl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                                        nsl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                                        nsl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                                        nsl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                                        nsl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                                        nsl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                                        nsl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                                        nsl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                                        nsl.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                                        nsl.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                                        nsl.SetCellValue(iR, 11, row.Cells[10].Value.ToString());
                                        nsl.SetCellValue(iR, 12, row.Cells[11].Value.ToString());
                                        nsl.SetCellValue(iR, 13, row.Cells[12].Value.ToString());
                                        iR++;
                                    }

                                    string invs_path = $@"{Application.StartupPath}\Inventories\";

                                    if (!Directory.Exists(invs_path))
                                    {
                                        Directory.CreateDirectory(invs_path);
                                    }

                                    nsl.SaveAs($@"{invs_path}\USUARIOS Y EQUIPOS.xlsx");
                                }
                                catch (Exception ex)
                                {
                                    RJMessageBox.Show(ex.ToString(), "Guardado de archivo");
                                }
                            }
                            #endregion

                            // Actualizamos la grilla del formulario padre
                            grilla.DataSource = ulst;

                            // Informamos al grabador de eventos del equipo
                            string path = $@"{Application.StartupPath}\Inventories\{txtHOSTNAME.Text}{MachineEventsHistorial.FileSuffix}";
                            MachineEventsHistorial rec = new MachineEventsHistorial(path);
                            rec.AddEvent(M_EventItem.FromTemplate_NewMachine(this.txtHOSTNAME.Text));
                            rec.Save();
                            
                            RJMessageBox.Show("Equipo guardado con exito en el inventario!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                            if (RESGUARDO_CREATED)
                            {
                                this.Close();
                            }
                            else
                            {
                                if (RJMessageBox.Show("¿Desea cerrar sin generar un resguardo responsivo para este equipo y sus accesorios?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            RJMessageBox.Show(ex.Message, "Añadir equipo");
                        }
                    }
                }
            } else
            {
                RJMessageBox.Show("Debes llenar los campos obligatorios!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboxSubdireccion_TextChanged(object sender, EventArgs e)
        {
            USUARIO_SUBDIRECCION = this.cboxSubdireccion.Text;
        }

        private void cboxDireccion_TextChanged(object sender, EventArgs e)
        {
            USUARIO_DIRECCION = this.cboxDireccion.Text;
        }

        private void cboxDGA_TextChanged(object sender, EventArgs e)
        {
            USUARIO_DIRECCIONADJUNTA = this.cboxDGA.Text;
        }

        private void añadir_equipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }

        private void añadir_equipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiezaDeVariables();
        }

        private void txtDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            USUARIO_DIVISION = this.txtDivision.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarDesdeArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Seleccione el archivo de datos extraidos a cargar...";
            openFileDialog1.Filter = "Archivos JSON | *.json";
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json_data = File.ReadAllText($@"{openFileDialog1.FileName}");
                    JObject json_parsed = JObject.Parse(json_data);

                    txtHOSTNAME.Text = json_parsed["HOSTNAME"].ToString();
                    txtNumeroDeSerie.Text = json_parsed["SERIAL_NUMBER"].ToString();
                    txtTipoDeEquipo.Text = json_parsed["TIPO_DE_EQUIPO"].ToString();
                    txtMarca.Text = json_parsed["MARCA"].ToString();
                    txtModelo.Text = json_parsed["MODELO"].ToString();
                    txtUbicacion.Text = json_parsed["UBICACION"].ToString();
                    lblUsuarioDelArchivo.Text = "Usuario del Archivo: " + Environment.NewLine + json_parsed["USUARIO_ASIGNADO"].ToString();
                    lblUsuarioDelArchivo.Visible = true;
                    EQUIPO_RAM = json_parsed["CANTIDAD_DE_RAM"].ToString();
                    EQUIPO_PROCESADOR = json_parsed["MODELO_DEL_PROCESADOR"].ToString();
                    EQUIPO_FRECUENCIA = json_parsed["VELOCIDAD_DEL_PROCESADOR"].ToString();

                } catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region VALIDADOR DE CAMPOS
        string ERROR_BLANK_FIELD = "Debes llenar este campo obligatorio";

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, ERROR_BLANK_FIELD);
            } else
            {
                errorProvider1.SetError(txtMarca, "");
            }
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, ERROR_BLANK_FIELD);
            }
            else
            {
                errorProvider1.SetError(txtModelo, "");
            }
        }

        private void txtTipoDeEquipo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoDeEquipo.Text))
            {
                errorProvider1.SetError(txtTipoDeEquipo, ERROR_BLANK_FIELD);
            }
            else
            {
                errorProvider1.SetError(txtTipoDeEquipo, "");
            }
        }

        private void txtNumeroDeSerie_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroDeSerie.Text))
            {
                errorProvider1.SetError(txtNumeroDeSerie, ERROR_BLANK_FIELD);
            }
            else
            {
                errorProvider1.SetError(txtNumeroDeSerie, "");
            }
        }

        private void txtHOSTNAME_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHOSTNAME.Text))
            {
                errorProvider1.SetError(txtHOSTNAME, ERROR_BLANK_FIELD);
            }
            else
            {
                errorProvider1.SetError(txtHOSTNAME, "");
            }
        }

        private void cboxUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboxUsuario.Text) | cboxUsuario.Text == "---------Seleccionar usuario---------")
            {
                errorProvider1.SetError(cboxUsuario, ERROR_BLANK_FIELD);
            }
            else
            {
                errorProvider1.SetError(cboxUsuario, "");
            }
        }
        #endregion

        private void añadir_equipo_Shown(object sender, EventArgs e)
        {
            padre.loadingForm.Close();
        }

        #region VALORES DE TEXTBOXES EN MAYUSCULAS
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            this.txtMarca.Text = txtMarca.Text.ToUpper();
            this.txtMarca.SelectionStart = txtMarca.Text.Length;
        }

        private void txtTipoDeEquipo_TextChanged(object sender, EventArgs e)
        {
            this.txtTipoDeEquipo.Text = txtTipoDeEquipo.Text.ToUpper();
            this.txtTipoDeEquipo.SelectionStart = txtTipoDeEquipo.Text.Length;
        }

        private void txtNumeroDeSerie_TextChanged(object sender, EventArgs e)
        {
            this.txtNumeroDeSerie.Text = txtNumeroDeSerie.Text.ToUpper();
            this.txtNumeroDeSerie.SelectionStart = txtNumeroDeSerie.Text.Length;
        }

        private void txtHOSTNAME_TextChanged(object sender, EventArgs e)
        {
            this.txtHOSTNAME.Text = txtHOSTNAME.Text.ToUpper();
            this.txtHOSTNAME.SelectionStart = txtHOSTNAME.Text.Length;
        }

        private void txtUbicacion_TextChanged_1(object sender, EventArgs e)
        {
            this.txtUbicacion.Text = txtUbicacion.Text.ToUpper();
            this.txtUbicacion.SelectionStart = txtUbicacion.Text.Length;
        }
        #endregion

        private void btnVincularModelo_Click(object sender, EventArgs e)
        {
            /*
             * Abrimos el formulario para vincular el modelo en caso que no este existente
             * */
            exViewSyncModel frm = new exViewSyncModel(exViewSyncModel.StartOption.CREATE, this.txtModelo.Text);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool isAutoSelect = false;

                if (Properties.Settings.Default.SYSDATA_AutoSelectRecentSincModel)
                {
                    isAutoSelect = true;
                }
                else
                {
                    if (MessageBox.Show("¿Deseas cargar el modelo recientemente vinculado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isAutoSelect = true;
                    }
                }

                if (isAutoSelect)
                {
                    MachinesModelsSync modelsList = MachinesModelsSync.Load();
                    modelsList.Items.Add(frm.RESPONSE);
                    modelsList.Save();
                }
            }
        }

        private void btnSeleccionarModeloVinculado_Click(object sender, EventArgs e)
        {
            /* 
             * Seleccionamos un modelo vinculado del listado
             * */
            exTablaModelosVinculados frm = new exTablaModelosVinculados();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtMarca.Text = frm.RESPONSE.Marca;
                this.txtModelo.Text = frm.RESPONSE.NombreComercial;
                this.txtTipoDeEquipo.Text = frm.RESPONSE.Tipo;

                #region CARGAMOS LOS VALORES DE HARDWARE DLE PROCESADOR
                EQUIPO_PROCESADOR = frm.RESPONSE.Procesador;
                EQUIPO_FRECUENCIA = frm.RESPONSE.Frecuencia.ToString();
                EQUIPO_RAM = frm.RESPONSE.RAM.ToString();
                EQUIPO_ALMACENAMIENTO_TIPO = frm.RESPONSE.TipoAlmacenamiento;
                EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD = frm.RESPONSE.AlmacenamientoHDD.ToString();
                EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD = frm.RESPONSE.AlmacenamientoSSD.ToString();
                //EQUIPO_UNIDADOPTICA = frm.RESPONSE.TieneUnidadOptica;
                #endregion
            }
        }

        bool isAVinculatedModel = false;
        string vinculatedModelByParam = "";
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            /* 
             * Detectamos si el modelo ingresado es un nombre clave de modelo
             * */
            string[] _CodeNamesModels = machinesModels.Items
                .Cast<MachineModelSyncItem>()
                .Select(m => m.NombreClave)
                .ToArray();

            if (_CodeNamesModels.Contains(this.txtModelo.Text.Trim()))
            {
                isAVinculatedModel = true;
                vinculatedModelByParam = "byCodeName";
            } else
            {
                isAVinculatedModel = false;
            }

            /* 
             * En caso de que aun no se haya detectado un modelo vinculado segun su nombre clave,
             * tambien lo buscamos segun su nombre comercial
             * */
            if (!isAVinculatedModel)
            {
                string[] _ComercialNamesModels = machinesModels.Items
                .Cast<MachineModelSyncItem>()
                .Select(m => m.NombreComercial)
                .ToArray();

                if (_ComercialNamesModels.Contains(this.txtModelo.Text.Trim()))
                {
                    isAVinculatedModel = true;
                    vinculatedModelByParam = "byComercialName";
                }
                else
                {
                    isAVinculatedModel = false;
                }
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (isAVinculatedModel)
            {
                MachineModelSyncItem linkedModel = null;
                switch (vinculatedModelByParam)
                {
                    case "byCodeName":
                        linkedModel = machinesModels.Items
                            .Cast<MachineModelSyncItem>()
                            .Where(m => m.NombreClave == this.txtModelo.Text.Trim())
                            .FirstOrDefault();
                        break;
                    case "byComercialName":
                        linkedModel = machinesModels.Items
                            .Cast<MachineModelSyncItem>()
                            .Where(m => m.NombreComercial == this.txtModelo.Text.Trim())
                            .FirstOrDefault();
                        break;
                }

                if (linkedModel != null)
                {
                    if (MessageBox.Show($"Encontramos la siguiente relacion de modelo:\n\n* {linkedModel.NombreClave} -> {linkedModel.NombreComercial}\n\n¿Deseas asignar el nombre comercial en lugar del nombre clave?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.txtMarca.Text = linkedModel.Marca;
                        this.txtModelo.Text = linkedModel.NombreComercial;
                        this.txtTipoDeEquipo.Text = linkedModel.Tipo;

                        #region CARGAMOS LOS VALORES DE HARDWARE DLE PROCESADOR
                        EQUIPO_PROCESADOR = linkedModel.Procesador;
                        EQUIPO_FRECUENCIA = linkedModel.Frecuencia.ToString();
                        EQUIPO_RAM = linkedModel.RAM.ToString();
                        EQUIPO_ALMACENAMIENTO_TIPO = linkedModel.TipoAlmacenamiento;
                        EQUIPO_ALMACENAMIENTO_CANTIDAD_HDD = linkedModel.AlmacenamientoHDD.ToString();
                        EQUIPO_ALMACENAMIENTO_CANTIDAD_SSD = linkedModel.AlmacenamientoSSD.ToString();
                        //EQUIPO_UNIDADOPTICA = linkedModel.TieneUnidadOptica;
                        #endregion
                    }
                } else
                {
                    MessageBox.Show($"Ha ocurrido un error de busqueda y lectura de datos y no se encontro el resultado '{this.txtModelo.Text.Trim()}' para el parametro '{vinculatedModelByParam}'", "Error de lectura - Modelo Vinculado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCentroCostos_TextChanged(object sender, EventArgs e)
        {
            USUARIO_CENTRODECOSTOS = this.txtCentroCostos.Text.ToUpper().Trim();
        }
    }
}
