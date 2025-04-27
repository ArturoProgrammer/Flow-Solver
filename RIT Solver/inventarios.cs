using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SpreadsheetLight;
using System.IO;

using System.Text.Json;
using System.Text.Json.Serialization;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using CustomMessageBox;
using Microsoft.VisualBasic;
using Flow_Solver.Centro_de_Control;
using Org.BouncyCastle.Asn1.X509;
using Flow_Solver.MachineProfiles;

namespace Flow_Solver
{
    public partial class inventarios : Form
    {
        private main padre_main;
        private rit_mdi_form padre_rit;
        private dynamic padre_actividad;

        /// <summary>
        /// Objeto maquina seleccionado actualmente
        /// </summary>
        public InventarioViewModel ActualMachine = new InventarioViewModel();

        private InventoryClass ActualInv = InventoryClass.UsuariosYEquipos; // Por defecto

        string inventory_path = Properties.Settings.Default.SYSDATA_INVENTORY_PATH;
        int renglon_actual;
        int renglon_anterior;
        static List<string> USUARIOS_LIST = new List<string>();
        System.Collections.Specialized.StringCollection COLLECTION = new System.Collections.Specialized.StringCollection();

        public bool WAS_EDIT_FLAG = false;


        public inventarios(main LegacyForm)
        {
            InitializeComponent();

            padre_main = LegacyForm;
            //this.Text = "Sistema de Inventarios";
            this.btnPedirToner.Enabled = false;
            this.importarEquipoToolStripMenuItem.Enabled = false;
            this.btnCargarDatos.Enabled = false;
        }

        public inventarios (rit_mdi_form LegacyForm)
        {
            InitializeComponent();
            padre_rit = LegacyForm;
            //this.Text = "Sistema de Inventarios";
            //this.btnPedirToner.Enabled = false;
        }

        public inventarios (crear_actividad LegacyForm, InventoryClass SelectedInventory)
        {
            InitializeComponent();
            padre_actividad = LegacyForm;
            ActualInv = SelectedInventory;
            this.btnPedirToner.Enabled = false;
            this.importarEquipoToolStripMenuItem.Enabled = false;
            this.btnCargarDatos.Enabled = false;
            this.toolCambiarInventario.Enabled = false;
        }

        public inventarios(actividades_mdi_form LegacyForm, InventoryClass SelectedInventory)
        {
            InitializeComponent();
            padre_actividad = LegacyForm;
            ActualInv = SelectedInventory;
            this.btnPedirToner.Enabled = false;
            this.importarEquipoToolStripMenuItem.Enabled = false;
            this.btnCargarDatos.Enabled = false;
            this.toolCambiarInventario.Enabled = false;
        }

        private void UpdateJob (bool Status, string Message)
        {
            if (Status)
            {
                this.toolStrip_JobStatus.ForeColor = Color.Green;
                this.toolStrip_JobStatus.Image = Properties.Resources.check;
            }
            else
            {
                this.toolStrip_JobStatus.ForeColor = Color.Red;
                this.toolStrip_JobStatus.Image = Properties.Resources.error;
            }
            this.toolStrip_JobStatus.Text = Message;
        }


        public static void UserJsonFileMaker (string aNombre, string aNoDeEmpleado, string aExt, string aRedUser, string aMail, string aDepartamento, string aLocalidadAsignada)
        {
            /* CREA EL ARCHIVO JSON CON LOS DATOS DEL USUARIO */
            string usersJson_path = $@"{Application.StartupPath}\UsersCard\";

            if (!Directory.Exists(usersJson_path))
            {
                Directory.CreateDirectory(usersJson_path);
                CommonMethodsLibrary.OutMessage("out", "inventarios", $@"SE CREO EL DIRECTORIO DE TARJETAS '{usersJson_path}'", "OKA");
            }

            // Creamos el archivo JSON
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("nombre", aNombre);
            dict.Add("no_empleado", aNoDeEmpleado);
            dict.Add("extension", aExt);
            dict.Add("red_user", aRedUser);
            dict.Add("mail", aMail);
            dict.Add("departamento", aDepartamento);
            dict.Add("localidad_asignada", aLocalidadAsignada);

            string finalJson = System.Text.Json.JsonSerializer.Serialize(dict);

            File.WriteAllText($@"{usersJson_path}\{aNombre.Trim()}_Profile.card", finalJson);
            CommonMethodsLibrary.OutMessage("out", "inventarios", $@"SE CREO LA TARJETA DEL USUARIO '{aNombre}' EN LA RUTA '{usersJson_path}\{aNombre.Trim()}_Profile.card", "OKA");
        }

        void _EnableSortRowsProcedure()
        {
            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        void _AddMissingColumn(SLDocument sl, int newColumnIndex, string _ColumnName)
        {
            // Añade el encabezado de la nueva columna
            sl.SetCellValue(1, newColumnIndex, _ColumnName);

            // Opcional: Agrega valores predeterminados a las filas siguientes (ejemplo: vacío o fecha por defecto)
            SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
            for (int row = 2; row <= stats.EndRowIndex; row++)
            {
                sl.SetCellValue(row, newColumnIndex, ""); // Deja las celdas vacías o añade un valor predeterminado
            }
        }

        void _ValidateExtraOriginalColumns(string _SheetBook, string _BookPath, string _ColumnName)
        {
            if (_SheetBook == "USUARIOS Y EQUIPOS" && Directory.Exists(_BookPath.Trim()))
            {
                using (SLDocument sl = new SLDocument(_BookPath))
                {
                    // Leer la primera hoja (por defecto)
                    SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
                    int totalColumns = stats.EndColumnIndex;

                    bool columnExists = false;

                    for (int col = 1; col <= totalColumns; col++)
                    {
                        string header = sl.GetCellValueAsString(1, col); // Leer el encabezado de la columna
                        if (header.Equals(_ColumnName, StringComparison.OrdinalIgnoreCase))
                        {
                            columnExists = true;
                            break;
                        }
                    }

                    if (columnExists)
                    {
                        CommonMethodsLibrary.OutMessage("IN", "inventarios.cs", "La columna 'Fecha de Fabricación' existe en el archivo.", "INF");
                    }
                    else
                    {
                        _AddMissingColumn(sl, totalColumns + 1, _ColumnName);
                        sl.SaveAs(_SheetBook);
                        CommonMethodsLibrary.OutMessage("IN", "inventarios.cs", "La columna 'Fecha de Fabricación' no existe en el archivo. Se creara la columna", "WAR");
                    }
                }
            }
        }


        #region METODO DE LECTURA DE EXCELS PARA INVENTARIOS
        /// <summary>
        /// Importa los datos del archivo excel
        /// </summary>
        /// <param name="SheetBook">Nombre del archivo Excel sin la extension .xlsx</param>
        private void ImportarExcel (string SheetBook, DataGridView TargetGrid)
        {
            /*
             * Establecemos esta variable sin validacion debido a las nuevas configuraciones de codigo 
             */
            if (true)
            {
                TargetGrid.DataSource = null;
                // Directorio de los inventarios
                /* INVENTARIOS:
                 * 
                 * - USUARIOS Y EQUIPOS
                 * - IMPRESORAS
                 * - TONERS
                 * - REFACCIONES
                 * 
                 */

                string BOOK_PATH = $@"{Application.StartupPath}\Inventories\{SheetBook}.xlsx";

                // Validamos primero la existencia de las columnas adicionales a las originales de versionaes pasadas
                /*
                 * Columnas a validar:
                 * 
                 * - Año de fabricacion del modelo
                 * - Fecha de asignacion al usuario actual
                 */
                _ValidateExtraOriginalColumns(SheetBook, BOOK_PATH, "Fecha de Fabricacion");
                _ValidateExtraOriginalColumns(SheetBook, BOOK_PATH, "Fecha de Asignacion");


                SLDocument sl;
                try
                {
                    int iRow = 2;

                    if (SheetBook == "USUARIOS Y EQUIPOS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                    {
                        #region
                        if (File.Exists(BOOK_PATH))
                        {
                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CARGANDO ARCHIVO DE INVENTARIO EXISTENTE '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");

                            this.txtRutaDeInventario.Text = BOOK_PATH;

                            // Cargamos el archivo que se creo en base al molde con anterioridad
                            sl = new SLDocument(BOOK_PATH);

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

                                DateTime _CreationDateTime;
                                if (DateTime.TryParse(sl.GetCellValueAsString(iRow, 14).Trim(), out _CreationDateTime)) { }
                                oUsuario.FechaDeFabricacion = _CreationDateTime;

                                DateTime _AsignementDateTime;
                                if (DateTime.TryParse(sl.GetCellValueAsString(iRow, 15).Trim(), out _AsignementDateTime)) { }
                                oUsuario.FechaDeAsignacion = _AsignementDateTime;

                                // Añadimos los usuarios registrados
                                USUARIOS_LIST.Add(sl.GetCellValueAsString(iRow, 1));

                                CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"SINCRONIZANDO LOS DATOS DE LOS USUARIOS", "inf");

                                #region PROCESO DE CREACION DE TARJETAS DE USUARIO AUTOMATICAS
                                string targetCardPath = $@"{Application.StartupPath}\UsersCard\{oUsuario.NOMBRE.Trim()}_Profile.card";
                                if (File.Exists(targetCardPath) == false)
                                {
                                    File.WriteAllText(targetCardPath, $@"{{
    ""nombre"": ""{oUsuario.NOMBRE}"",
    ""no_empleado"": ""{oUsuario.NumDeEmpleado}"",
    ""extension"": ""{oUsuario.EXT}"",
    ""red_user"": ""{oUsuario.USER}"",
    ""mail"": ""{oUsuario.MAIL}"",
    ""departamento"": ""{oUsuario.Departamento}"",
    ""localidad_asignada"": """"
}}");
                                }
                                #endregion

                                #region PROCESO DE SINCRONIZACION DE USUARIOS
                                if (!Properties.Settings.Default.FIRST_INITIALIZE_INVENTORY)
                                {
                                    if (File.Exists(targetCardPath))
                                    {
                                        //RJMessageBox.Show($"Existe: {oUsuario.NOMBRE}");

                                        string json_card = File.ReadAllText(targetCardPath);
                                        JObject json_parsed = JObject.Parse(json_card);

                                        string USUARIO_NOMBRE = json_parsed["nombre"].ToString();
                                        string USUARIO_NOEMPLEADO = json_parsed["no_empleado"].ToString();
                                        string USUARIO_EXTENSION = json_parsed["extension"].ToString();
                                        string USUARIO_RED = json_parsed["red_user"].ToString();
                                        string USUARIO_EMAIL = json_parsed["mail"].ToString();
                                        string USUARIO_DEPARTAMENTO = json_parsed["departamento"].ToString();

                                        oUsuario.NumDeEmpleado = USUARIO_NOEMPLEADO;
                                        oUsuario.EXT = USUARIO_EXTENSION;
                                        oUsuario.USER = USUARIO_RED;
                                        oUsuario.MAIL = USUARIO_EMAIL;
                                        oUsuario.Departamento = USUARIO_DEPARTAMENTO;
                                    }
                                }
                                #endregion
                                CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"DATOS DE USUARIOS SINCRONIZCADOS", "OKA");


                                lst.Add(oUsuario);
                                iRow++;
                            }

                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"GRILLA CARGADA", "oka");

                        }
                        else
                        {
                            // En caso de que no exista se cree los datos del inventario
                            sl = new SLDocument(BOOK_PATH, SheetBook);

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

                                DateTime _CreationDateTime;
                                if (DateTime.TryParse(sl.GetCellValueAsString(iRow, 14).Trim(), out _CreationDateTime)) { }
                                oUsuario.FechaDeFabricacion = _CreationDateTime;

                                DateTime _AsignementDateTime;
                                if (DateTime.TryParse(sl.GetCellValueAsString(iRow, 15).Trim(), out _AsignementDateTime)) { }
                                oUsuario.FechaDeAsignacion = _AsignementDateTime;

                                // Añadimos los usuarios registrados
                                USUARIOS_LIST.Add(sl.GetCellValueAsString(iRow, 1));

                                lst.Add(oUsuario);

                                iRow++;
                            }

                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"GRILLA CARGADA", "oka");

                            foreach (InventarioViewModel i in lst)
                            {
                                /* SOLUCIONAR BUG
                                * SOLO SE EJECUTE UNA VEZ
                                * */
                                UserJsonFileMaker(i.NOMBRE, i.NumDeEmpleado, i.EXT, i.USER, i.MAIL, i.Departamento, "No asignada");
                            }

                            foreach (string element in USUARIOS_LIST)
                            {
                                if (!COLLECTION.Contains(element))
                                {
                                    COLLECTION.Add(element);
                                }
                            }

                            // Crea el archivo de inventario futuro
                            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CREANDO ARCHIVO DE INVENTARIO '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                            ExcelMake.Make(this, SheetBook);
                        }

                        // Asignamos los nombres de las cabeceras de las columnas
                        this.dataGridView1.Columns["NOMBRE"].HeaderText = "Nombre de Usuario";
                        this.dataGridView1.Columns["NumDeEmpleado"].HeaderText = "No. Emp.";
                        this.dataGridView1.Columns["EXT"].HeaderText = "Ext.";
                        this.dataGridView1.Columns["USER"].HeaderText = "Red User";
                        this.dataGridView1.Columns["MAIL"].HeaderText = "Correo";
                        this.dataGridView1.Columns["HOSTNAME"].HeaderText = "Hostname";
                        this.dataGridView1.Columns["TipoDeEquipo"].HeaderText = "Tipo de Equipo";
                        this.dataGridView1.Columns["SN"].HeaderText = "No. Serie";
                        this.dataGridView1.Columns["Marca"].HeaderText = "Marca";
                        this.dataGridView1.Columns["Modelo"].HeaderText = "Modelo";
                        this.dataGridView1.Columns["Ubicacion"].HeaderText = "Ubicacion";
                        this.dataGridView1.Columns["Departamento"].HeaderText = "Departamento";
                        this.dataGridView1.Columns["Comentarios"].HeaderText = "Comentarios";
                        this.dataGridView1.Columns["FechaDeFabricacion"].HeaderText = "Fecha de Fabric.";
                        this.dataGridView1.Columns["FechaDeAsignacion"].HeaderText = "Fecha de Asign.";

                        UpdateJob(true, $"Inventario Cargado con Exito!");
                        _EnableSortRowsProcedure();

                        Properties.Settings.Default.SYS_CACHE_INVENTORY_LISTAUSUARIOS = COLLECTION;
                        Properties.Settings.Default.Save();

                        #endregion
                    }
                    else if (SheetBook == "IMPRESORAS")   // ========= INVENTARIO DE IMPRESORAS
                    {
                        #region
                        if (File.Exists(BOOK_PATH))
                        {
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO ARCHIVO DE INVENTARIO EXISTENTE '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                            
                            // Cargamos archivo hecho por molde
                            this.txtRutaDeInventario.Text = BOOK_PATH;
                            sl = new SLDocument(BOOK_PATH, SheetBook);

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

                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            dataGridView1.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");
                        }
                        else
                        {
                            ExcelMake.Make(this, SheetBook);

                            sl = new SLDocument(BOOK_PATH, SheetBook);

                            List<ImpresorasViewModel> lst = new List<ImpresorasViewModel>();
                            TargetGrid.DataSource = lst;

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

                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");

                            // Crea el archivo de inventario futuro
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CREANDO ARCHIVO DE INVENTARIO '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                        }
                        _EnableSortRowsProcedure();
                        UpdateJob(true, $"Inventario Cargado con Exito!");
                        #endregion
                    }
                    else if (SheetBook == "TONERS")     // ========= INVENTARIO DE TONERS
                    {
                        #region
                        if (File.Exists(BOOK_PATH))
                        {
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO ARCHIVO DE INVENTARIO EXISTENTE '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                            
                            // Cargamos archivo hecho por molde
                            this.txtRutaDeInventario.Text = BOOK_PATH;
                            sl = new SLDocument(BOOK_PATH, SheetBook);

                            List<TonersViewModel> lst = new List<TonersViewModel>();

                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                TonersViewModel oToner = new TonersViewModel();

                                oToner.Modelo = sl.GetCellValueAsString(iRow, 1);
                                oToner.Marca = sl.GetCellValueAsString(iRow, 2);
                                oToner.Descripcion = sl.GetCellValueAsString(iRow, 3);
                                oToner.Cantidad = sl.GetCellValueAsString(iRow, 4);

                                lst.Add(oToner);

                                iRow++;
                            }
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");
                        }
                        else
                        {
                            ExcelMake.Make(this, SheetBook);

                            sl = new SLDocument(BOOK_PATH, SheetBook);

                            List<TonersViewModel> lst = new List<TonersViewModel>();
                            TargetGrid.DataSource = lst;

                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                TonersViewModel oToner = new TonersViewModel();

                                oToner.Modelo = sl.GetCellValueAsString(iRow, 1);
                                oToner.Marca = sl.GetCellValueAsString(iRow, 2);
                                oToner.Descripcion = sl.GetCellValueAsString(iRow, 3);
                                oToner.Cantidad = sl.GetCellValueAsString(iRow, 4);

                                lst.Add(oToner);

                                iRow++;
                            }
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");

                            // Crea el archivo de inventario futuro
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CREANDO ARCHIVO DE INVENTARIO '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                            ExcelMake.Make(this, SheetBook);
                        }

                        _EnableSortRowsProcedure();
                        UpdateJob(true, $"Inventario Cargado con Exito!");
                        #endregion

                    }
                    else if (SheetBook == "REFACCIONES")
                    {
                        #region
                        if (File.Exists(BOOK_PATH))
                        {
                            // Cargamos archivo hecho por molde
                            this.txtRutaDeInventario.Text = BOOK_PATH;
                            sl = new SLDocument(BOOK_PATH, SheetBook);
                            List<RefaccionesViewModel> lst = new List<RefaccionesViewModel>();

                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                RefaccionesViewModel oRefaccion = new RefaccionesViewModel();

                                oRefaccion.Marca = sl.GetCellValueAsString(iRow, 1);
                                oRefaccion.Descripcion = sl.GetCellValueAsString(iRow, 2);
                                oRefaccion.Modelo = sl.GetCellValueAsString(iRow, 3);
                                oRefaccion.Serie = sl.GetCellValueAsString(iRow, 4);
                                oRefaccion.Ubicacion = sl.GetCellValueAsString(iRow, 5);
                                //oRefaccion.Comentario = sl.GetCellValueAsString(iRow, 6);

                                lst.Add(oRefaccion);

                                iRow++;
                            }
                            TargetGrid.DataSource = lst;
                        }
                        else
                        {
                            ExcelMake.Make(this, SheetBook);

                            sl = new SLDocument(BOOK_PATH, SheetBook);
                            List<RefaccionesViewModel> lst = new List<RefaccionesViewModel>();
                            TargetGrid.DataSource = lst;

                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                RefaccionesViewModel oRefaccion = new RefaccionesViewModel();

                                oRefaccion.Marca = sl.GetCellValueAsString(iRow, 1);
                                oRefaccion.Descripcion = sl.GetCellValueAsString(iRow, 2);
                                oRefaccion.Modelo = sl.GetCellValueAsString(iRow, 3);
                                oRefaccion.Serie = sl.GetCellValueAsString(iRow, 4);
                                oRefaccion.Ubicacion = sl.GetCellValueAsString(iRow, 5);
                                //oRefaccion.Comentario = sl.GetCellValueAsString(iRow, 6);

                                lst.Add(oRefaccion);

                                iRow++;
                            }

                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                            TargetGrid.DataSource = lst;
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");

                            // Crea el archivo de inventario futuro
                            CommonMethodsLibrary.OutMessage("in", this.Name, $@"CREANDO ARCHIVO DE INVENTARIO '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");
                            ExcelMake.Make(this, SheetBook);
                        }

                        _EnableSortRowsProcedure();
                        UpdateJob(true, $"Inventario Cargado con Exito!");
                        #endregion
                    }

                    TargetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"HA OCURRIDO UN ERROR INESPERADO CON EL PROGRAMA. EL PROGRAMA DICE: '{ex}\n{ex.ToString()}'", "err");

                    UpdateJob(false, $"Error: {ex.Message}");
                    RJMessageBox.Show("Ha ocurrido un error. Si esta editando el archivo de inventario, cierrelo y reintente. " + Environment.NewLine + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Enabled caso de que no hay un nuevo libro
            }
        }
        #endregion

        
        private void inventarios_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SYSDATA_OPEN_INVENTORY_ALWAYS_MAXIMIZE)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            /* 
             * EN CASO DE QUE NO EXISTA UNA RUTA DE INVENTARIO GUARDAD EN LA CONFIGURACION
             * CARGAMOS UNA...
             */
            if (CommonMethodsLibrary.ValidateInventoryExists(InventoryClass.UsuariosYEquipos)) 
            {
                if (inventory_path == String.Empty && Properties.Settings.Default.CAN_CONTINUE_QUEST_INVENTORYPATH)
                {
                    // Si el usuario cuenta con una plantilla, cargamos la plantilla
                    #region SI EL USUARIO CUENTA CON UNA PLANTILLA, LA CARGAMOS
                    MsgBoxWNeverAskAgain frmAskPlantilla = new MsgBoxWNeverAskAgain("Carga de Inventarios - Plantilla", "¿Cuentas con una plantilla de inventario y deseas cargarla?\n\nSi no cuentas con una plantilla no hay inconveniente, se abrira un inventario en blanco", false);

                    if (frmAskPlantilla.ShowDialog() == DialogResult.Yes)
                    {
                        try
                        {
                            openFileDialog1.Title = "Seleccione un archivo de inventario de molde...";
                            openFileDialog1.Filter = "Excel (*.xlsx; *.xls; *.xlsm)|*.xlsx;*.xls;*.xlsm|Todos los Archivos(*.*)|*.*";
                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                CommonMethodsLibrary.OutMessage("in", this.Name, $@"SE HA INGRESADO EL ARCHIVO '{openFileDialog1.FileName}' COMO MOLDE DE INVENTARIO", "inf");

                                inventory_path = openFileDialog1.FileName;
                                Properties.Settings.Default.SYSDATA_INVENTORY_PATH = inventory_path;

                                ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);
                            }
                        }
                        catch (Exception ex)
                        {
                            CommonMethodsLibrary.OutMessage("out", this.Name, $@"HA OCURRIDO UN ERROR INESPERADO CON EL PROGRAMA. EL PROGRAMA DICE: '{ex.ToString()}'", "err");

                            RJMessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        /* 
                         * Abrimos un inventario en blanco
                         * */
                    }
                    #endregion

                    // Actualizamos el valor de la propiedad
                    Properties.Settings.Default.CAN_CONTINUE_QUEST_INVENTORYPATH = !frmAskPlantilla.CheckBox_Value;
                }
                else
                {
                    // Abrimos los inventarios
                    inventory_path = $@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx";

                    CommonMethodsLibrary.OutMessage("in", this.Name, $@"RUTA '{inventory_path}' CARGADA COMO MOLDE DE INVENTARIO", "oka");
                }
            } else
            {
                /* 
                 * Establecemos el inventory Path para los casos en los que este el archivo excel en existencia, pero no este
                 * guardada su ruta en la variable
                 * */
                inventory_path = $@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx";
            }

            Properties.Settings.Default.Save();     // Guardamos el archivo molde de inventario y que se deje de preguntar en caso de no existir alguno

            /* =======  [ Iniciamos carga de ajustes por defecto para el inventario una vez cargado ]  ======= */

            /** Valores del toolCambiarInventario **/
            this.toolCambiarInventario.Items.Add("Usuarios y equipos");
            this.toolCambiarInventario.Items.Add("Impresoras");
            this.toolCambiarInventario.Items.Add("Toners");
            this.toolCambiarInventario.Items.Add("Refacciones");
            
            this.toolCambiarInventario.SelectedIndex = 0;

            /** Valor inicial del label de usuario **/
            this.toolTipoDeEquipo.Text = "";


            /** VALORES DE CAMPOS DE INTERFAZ **/
            this.txtRutaDeInventario.Text = inventory_path;
            this.txtInventarioActual.Text = "Inventario de Usuarios y Equipos";

            if (padre_actividad != null)
            {
                switch (ActualInv)
                {
                    case InventoryClass.UsuariosYEquipos:
                        // Cargamos los datos
                        ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);

                        // Cargamos los estilos visuales
                        /* Coloreamos las columnas de datos vinculados */
                        var grilla = this.dataGridView1;

                        grilla.Columns["NOMBRE"].DefaultCellStyle.BackColor = Color.LightCoral;   // Nombre
                        grilla.Columns["NumDeEmpleado"].DefaultCellStyle.BackColor = Color.LightCoral;   // No. De Emp.
                        grilla.Columns["EXT"].DefaultCellStyle.BackColor = Color.LightCoral;   // Extension
                        grilla.Columns["USER"].DefaultCellStyle.BackColor = Color.LightCoral;   // Usuario de Red
                        grilla.Columns["MAIL"].DefaultCellStyle.BackColor = Color.LightCoral;   // Correo
                        grilla.Columns["Departamento"].DefaultCellStyle.BackColor = Color.LightCoral;  // Departamento
                        break;
                    case InventoryClass.Impresoras:
                        ImportarExcel("IMPRESORAS", this.dataGridView1);
                        break;
                    case InventoryClass.Refacciones:
                        ImportarExcel("REFACCIONES", this.dataGridView1);
                        break;
                    case InventoryClass.Toners:
                        ImportarExcel("TONERS", this.dataGridView1);
                        break;
                }
            }
            else
            {
                // Cargamos los datos
                ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);

                // Cargamos los estilos visuales
                /* Coloreamos las columnas de datos vinculados */
                var grilla = this.dataGridView1;

                grilla.Columns["NOMBRE"].DefaultCellStyle.BackColor = Color.LightCoral;   // Nombre
                grilla.Columns["NumDeEmpleado"].DefaultCellStyle.BackColor = Color.LightCoral;   // No. De Emp.
                grilla.Columns["EXT"].DefaultCellStyle.BackColor = Color.LightCoral;   // Extension
                grilla.Columns["USER"].DefaultCellStyle.BackColor = Color.LightCoral;   // Usuario de Red
                grilla.Columns["MAIL"].DefaultCellStyle.BackColor = Color.LightCoral;   // Correo
                grilla.Columns["Departamento"].DefaultCellStyle.BackColor = Color.LightCoral;  // Departamento
            }

            this.dataGridView1.Select();
        }

        private void usuariosYEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryHasChange(InventoryClass.UsuariosYEquipos);
        }

        /// <summary>
        /// Cargamos los parametros de busqueda
        /// </summary>
        void LoadSearchParams()
        {
            //MessageBox.Show(ActualInv.ToString());
            this.cboxTipoValor.Items.Clear();
            this.txtValorBuscar.Text = "";


            #region EXTRAEMOS COLUMNAS DEL INVENTARIO SELECCIONADO
            SLDocument sl; // COMMON VALUE

            string INVENTORIES_DIR_PATH = $@"{Application.StartupPath}\Inventories";

            try
            {
                int iRow = 1;

                if (ActualInv == InventoryClass.UsuariosYEquipos) // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    string targetPath = $@"{INVENTORIES_DIR_PATH}\USUARIOS Y EQUIPOS.xlsx";
                    
                    if (File.Exists(targetPath))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument(targetPath);
                        
                        for (int i = 1; i <= 13; i++)
                        {
                            string valor = sl.GetCellValueAsString(iRow, i);
                            Console.WriteLine($"*- {i} -" + valor);
                            this.cboxTipoValor.Items.Add(valor);
                        }
                    } else
                    {
                        MessageBox.Show(targetPath);
                    }
                }
                else if (ActualInv == InventoryClass.Impresoras) // ========= IMPRESORAS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\IMPRESORAS.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\IMPRESORAS.xlsx");

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxTipoValor.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (ActualInv == InventoryClass.Toners) // ========= TONERS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\TONERS.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\TONERS.xlsx");

                        for (int i = 1; i <= 4; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxTipoValor.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (ActualInv == InventoryClass.Refacciones) // ========= REFACCIONES
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\REFACCIONES.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\REFACCIONES.xlsx");

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxTipoValor.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion


            if (this.cboxTipoValor.Items.Count > 0)
            {
                this.cboxTipoValor.SelectedIndex = 0;
            }
            this.cboxParametroDeCoincidencia.SelectedIndex = 1;
        }

        private void CargarDatos()
        {
            if (padre_rit != null)
            {
                //if (this.txtInventarioActual.Text == "Inventario de Usuarios y Equipos")
                if (ActualInv == InventoryClass.UsuariosYEquipos)
                {
                    string usuario = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();
                    string equipo = dataGridView1.Rows[renglon_actual].Cells["TipoDeEquipo"].Value.ToString();
                    string sn = dataGridView1.Rows[renglon_actual].Cells["SN"].Value.ToString();
                    /*
                    padre_rit.txtTipoDeEquipo.Text = dataGridView1.Rows[renglon_actual].Cells["TipoDeEquipo"].Value.ToString();
                    padre_rit.txtMarca.Text = dataGridView1.Rows[renglon_actual].Cells["Marca"].Value.ToString();
                    padre_rit.txtModelo.Text = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
                    padre_rit.txtNoDeSerie.Text = dataGridView1.Rows[renglon_actual].Cells["SN"].Value.ToString();
                    padre_rit.cboxUsuariofinal.Text = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();
                    padre_rit.txtDepartamento.Text = dataGridView1.Rows[renglon_actual].Cells["Departamento"].Value.ToString();
                    padre_rit.txtNoDeEmpleado.Text = dataGridView1.Rows[renglon_actual].Cells["NumDeEmpleado"].Value.ToString();
                    padre_rit.txtTelefono.Text = dataGridView1.Rows[renglon_actual].Cells["EXT"].Value.ToString();
                    */

                    padre_rit.txtTipoDeEquipo.Text = ActualMachine.TipoDeEquipo;
                    padre_rit.txtMarca.Text = ActualMachine.Marca;
                    padre_rit.txtModelo.Text = ActualMachine.Modelo;
                    padre_rit.txtNoDeSerie.Text = ActualMachine.SN;
                    padre_rit.cboxUsuariofinal.Text = ActualMachine.NOMBRE;
                    padre_rit.txtDepartamento.Text = ActualMachine.Departamento;
                    padre_rit.txtNoDeEmpleado.Text = ActualMachine.NumDeEmpleado;
                    padre_rit.txtTelefono.Text = ActualMachine.EXT;
                    padre_rit.txtHostname.Text = ActualMachine.HOSTNAME;

                    this.Close();
                    padre_rit.UpdateJobStatus(true, $@"{usuario} / {equipo} - {sn} cargado con exito!");
                    //RJMessageBox.Show($"Datos de < {usuario} / {equipo} > al formulario principal con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"DATOS CARGADOS DESDE EL INVENTARIO HASTA EL FORMULARIO PRINCIPAL", "INF");
                }
            } else if (padre_actividad != null)
            {
                if (this.txtInventarioActual.Text == "Inventario de Usuarios y Equipos")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            /* CARGA LOS DATOS DE LA FILA SELECCIONADA AL FORM PRINCIPAL */
            CargarDatos();
        }

        private void btnExaminarRuta_Click(object sender, EventArgs e)
        {
            /* Busca o carga una ruta nueva del archivo - MAS NO SE GUARDA EN LA CONFIGURACION */
            #region
            try
            {
                openFileDialog1.Filter = "Excel (*.xlsx; *.xls; *.xlsm)|*.xlsx;*.xls;*.xlsm|Todos los Archivos(*.*)|*.*";
                openFileDialog1.Title = "Abrir archivo de inventario...";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CommonMethodsLibrary.OutMessage("in", this.Name, $@"SE HA INGRESADO EL ARCHIVO '{openFileDialog1.FileName}' COMO MOLDE DE INVENTARIO", "inf");

                    inventory_path = openFileDialog1.FileName;
                    this.txtRutaDeInventario.Text = inventory_path;

                    if (RJMessageBox.Show("¿Deseas guardar este inventario como default?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CommonMethodsLibrary.OutMessage("in", this.Name, $@"SE HA ESTABLECIDO EL ARCHIVO '{openFileDialog1.FileName}' COMO MOLDE DE INVENTARIO", "OKA");

                        Properties.Settings.Default.SYSDATA_INVENTORY_PATH = inventory_path;
                        Properties.Settings.Default.Save();
                    }

                    // Cargamos
                    ImportarExcel("EQUIPOS", this.dataGridView1);
                } else
                {
                    if (string.IsNullOrEmpty(Properties.Settings.Default.SYSDATA_INVENTORY_PATH))
                    {
                        RJMessageBox.Show("Debe seleccionar un archivo para poder continuar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("IN", this.Name, $@"HA OCURRIDO UN ERROR INESPERADO CON EL PROGRAMA. EL PROGRAMA DICE: '{ex.ToString()}'", "err");

                RJMessageBox.Show("El archivo seleccionado no es un tipo válido" + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryHasChange(InventoryClass.Impresoras);
        }
        
        private void tonersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryHasChange(InventoryClass.Toners);
        }

        private void InventoryHasChange (InventoryClass aConstructor)
        {
            /* METODO PARA CARGAR EL NUEVO INVENTARIO SELECCIONADO */
            var grilla = this.dataGridView1;

            if (!bgworker_LoadInventoryInterface.IsBusy)
            {
                
            } else
            {
                bgworker_LoadInventoryInterface.CancelAsync();
            }

            bool aStatus = false;
            
            switch (aConstructor)
            {
                case InventoryClass.UsuariosYEquipos:
                    aStatus = true;

                    #region USUARIOS Y EQUIPOS
                    if (WAS_EDIT_FLAG)
                    {
                        if (!Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO)
                        {
                            switch (RJMessageBox.Show($"¿Deseas guardar los cambios del < {this.txtInventarioActual.Text} > antes de cerrarlo?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    SaveChanges(this.txtInventarioActual.Text);

                                    this.txtInventarioActual.Text = "Inventario de Usuarios y Equipos";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = true;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = true;
                                    this.toolReasignarEquipo.Enabled = true;
                                    //this.toolCambiarInventario.SelectedItem = 0;

                                    ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);
                                    break;
                                case DialogResult.No:
                                    WAS_EDIT_FLAG = false;
                                    this.txtInventarioActual.Text = "Inventario de Usuarios y Equipos";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = true;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = true;
                                    this.toolReasignarEquipo.Enabled = true;

                                    ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                        else
                        {
                            SaveChanges(this.txtInventarioActual.Text);

                            this.txtInventarioActual.Text = "Inventario de Usuarios y Equipos";
                            this.toolStrpBtnVerPerfilDeMaquina.Enabled = true;
                            this.btnPedirToner.Enabled = false;
                            this.btnCargarDatos.Enabled = true;
                            this.toolReasignarEquipo.Enabled = true;

                            ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);
                        }
                    }
                    else
                    {
                        SaveChanges(this.txtInventarioActual.Text);

                        this.txtInventarioActual.Text = "Inventario de Usuarios y Equipos";
                        this.toolStrpBtnVerPerfilDeMaquina.Enabled = true;
                        this.btnPedirToner.Enabled = false;
                        this.btnCargarDatos.Enabled = true;
                        this.toolReasignarEquipo.Enabled = true;

                        ImportarExcel("USUARIOS Y EQUIPOS", this.dataGridView1);
                    }
                    #endregion

                    if (padre_rit == null)
                    {
                        this.btnCargarDatos.Enabled = false;
                    } else
                    {
                        this.btnCargarDatos.Enabled = true;
                    }


                    if (grilla.ColumnCount == 0)
                    {
                        /*
                        DataGridViewColumn colNombre = new DataGridViewColumn();
                        colNombre.HeaderText = "";
                        */
                        List<InventarioViewModel> lst = new List<InventarioViewModel>();
                        //lst.Add(new InventarioViewModel());

                        grilla.DataSource = lst;
                    }

                    grilla.Columns["NOMBRE"].DefaultCellStyle.BackColor = Color.LightCoral;   // Nombre
                    grilla.Columns["NumDeEmpleado"].DefaultCellStyle.BackColor = Color.LightCoral;   // No. De Emp.
                    grilla.Columns["EXT"].DefaultCellStyle.BackColor = Color.LightCoral;   // Extension
                    grilla.Columns["USER"].DefaultCellStyle.BackColor = Color.LightCoral;   // Usuario de Red
                    grilla.Columns["MAIL"].DefaultCellStyle.BackColor = Color.LightCoral;   // Correo
                    grilla.Columns["Departamento"].DefaultCellStyle.BackColor = Color.LightCoral;  // Departamento

                    this.statusLabelMensajeDeAdvertencia.Text = "NOTA: No se guardaran las modificaciones hechas en las celdas vinculadas";
                    this.statusLabelMensajeDeAdvertencia.Visible = true;
                    break;
                case InventoryClass.Impresoras:
                    aStatus = false;

                    #region IMPRESORAS
                    /* CUANDO SE SELECCIONE EL INVENTARIO DE IMPRESORAS */
                    if (WAS_EDIT_FLAG)
                    {
                        if (!Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO)
                        {
                            switch (RJMessageBox.Show($"¿Deseas guardar los cambios del < {this.txtInventarioActual.Text} > antes de cerrarlo?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    SaveChanges(this.txtInventarioActual.Text);

                                    this.txtInventarioActual.Text = "Inventario de Impresoras";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = false;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("IMPRESORAS", this.dataGridView1);
                                    break;
                                case DialogResult.No:
                                    WAS_EDIT_FLAG = false;
                                    this.txtInventarioActual.Text = "Inventario de Impresoras";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = false;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("IMPRESORAS", this.dataGridView1);
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                        else
                        {
                            SaveChanges(this.txtInventarioActual.Text);

                            this.txtInventarioActual.Text = "Inventario de Impresoras";
                            this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                            this.btnPedirToner.Enabled = false;
                            this.btnCargarDatos.Enabled = false; 
                            this.toolReasignarEquipo.Enabled = false;

                            ImportarExcel("IMPRESORAS", this.dataGridView1);
                        }
                    }
                    else
                    {
                        SaveChanges(this.txtInventarioActual.Text);

                        this.txtInventarioActual.Text = "Inventario de Impresoras";
                        this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                        this.btnPedirToner.Enabled = false;
                        this.btnCargarDatos.Enabled = false;
                        this.toolReasignarEquipo.Enabled = false;

                        ImportarExcel("IMPRESORAS", this.dataGridView1);
                    }
                    #endregion

                    this.statusLabelMensajeDeAdvertencia.Visible = false;
                    break;
                case InventoryClass.Toners:
                    aStatus = false;

                    #region TONERS
                    /* CUANDO SE SELECCIONE EL INVENTARIO DE TONERS */
                    if (WAS_EDIT_FLAG)
                    {
                        if (!Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO)
                        {
                            switch (RJMessageBox.Show($"¿Deseas guardar los cambios del < {this.txtInventarioActual.Text} > antes de cerrarlo?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    SaveChanges(this.txtInventarioActual.Text);

                                    this.txtInventarioActual.Text = "Inventario de Toners";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = true;
                                    this.btnCargarDatos.Enabled = false;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("TONERS", this.dataGridView1);
                                    break;
                                case DialogResult.No:
                                    WAS_EDIT_FLAG = false;
                                    this.txtInventarioActual.Text = "Inventario de Toners";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = true;
                                    this.btnCargarDatos.Enabled = false;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("TONERS", this.dataGridView1);
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                        else
                        {
                            SaveChanges(this.txtInventarioActual.Text);

                            this.txtInventarioActual.Text = "Inventario de Toners";
                            this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                            this.btnPedirToner.Enabled = true;
                            this.btnCargarDatos.Enabled = false;
                            this.toolReasignarEquipo.Enabled = false;

                            ImportarExcel("TONERS", this.dataGridView1);
                        }
                    }
                    else
                    {
                        SaveChanges(this.txtInventarioActual.Text);

                        this.txtInventarioActual.Text = "Inventario de Toners";
                        this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                        this.btnPedirToner.Enabled = true;
                        this.btnCargarDatos.Enabled = false;
                        this.toolReasignarEquipo.Enabled = false;

                        ImportarExcel("TONERS", this.dataGridView1);
                    }
                    #endregion

                    this.statusLabelMensajeDeAdvertencia.Visible = false;
                    break;
                case InventoryClass.Refacciones:
                    aStatus = false;

                    #region REFACCIONES
                    /* CUANDO SE SELECCIONE EL INVENTARIO DE REFACCIONES */
                    if (WAS_EDIT_FLAG)
                    {
                        if (!Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO)
                        {
                            switch (RJMessageBox.Show($"¿Deseas guardar los cambios del < {this.txtInventarioActual.Text} > antes de cerrarlo?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    SaveChanges(this.txtInventarioActual.Text);

                                    this.txtInventarioActual.Text = "Inventario de Refacciones";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = true;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("REFACCIONES", this.dataGridView1);
                                    break;
                                case DialogResult.No:
                                    WAS_EDIT_FLAG = false;
                                    this.txtInventarioActual.Text = "Inventario de Refacciones";
                                    this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                                    this.btnPedirToner.Enabled = false;
                                    this.btnCargarDatos.Enabled = true;
                                    this.toolReasignarEquipo.Enabled = false;

                                    ImportarExcel("REFACCIONES", this.dataGridView1);
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                        else
                        {
                            SaveChanges(this.txtInventarioActual.Text);

                            this.txtInventarioActual.Text = "Inventario de Refacciones";
                            this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                            this.btnPedirToner.Enabled = false;
                            this.btnCargarDatos.Enabled = true;
                            this.toolReasignarEquipo.Enabled = false;

                            ImportarExcel("REFACCIONES", this.dataGridView1);
                        }
                    }
                    else
                    {
                        SaveChanges(this.txtInventarioActual.Text);

                        this.txtInventarioActual.Text = "Inventario de Refacciones";
                        this.toolStrpBtnVerPerfilDeMaquina.Enabled = false;
                        this.btnPedirToner.Enabled = false;
                        this.btnCargarDatos.Enabled = true;
                        this.toolReasignarEquipo.Enabled = false;

                        ImportarExcel("REFACCIONES", this.dataGridView1);
                    }
                    #endregion

                    this.statusLabelMensajeDeAdvertencia.Visible = false;
                    break;
            }

            this.toolCargarSeleccion.Enabled = aStatus;
            this.toolReasignarEquipo.Enabled = aStatus;
            this.toolModificarTarjetaDeUsuario.Enabled = aStatus;
            this.toolCrearResguardoDelEquipo.Enabled = aStatus;
            this.toolVerHistorialDelEquipoSeleccionado.Enabled = aStatus;
            this.toolImprimir.Enabled = aStatus;

            this.cargarToolStripMenuItem.Enabled = aStatus;
            this.reasignarequipoToolStripMenuItem.Enabled = aStatus;
            this.modificarUsuarioPropietarioToolStripMenuItem.Enabled = aStatus;
            this.crearResguardoToolStripMenuItem.Enabled = aStatus;
            this.verHistorialDelEquipoSeleccionadoToolStripMenuItem.Enabled = aStatus;


            ActualInv = aConstructor;
            LoadSearchParams();
        }

        private void refaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryHasChange(InventoryClass.Refacciones);
        }

        private void GridColorPaint()
        {
            var grilla = this.dataGridView1;
            //MessageBox.Show($"Fila anterior: {renglon_anterior} {Environment.NewLine}Fila actual: {renglon_actual}");


            // Subrayamos la columna
            // dataGridView1.Rows[renglon_actual].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);


            // Despintamos la seleccion anterior
            grilla.Rows[renglon_anterior].Cells["NOMBRE"].Style.BackColor = Color.LightCoral;   // Nombre
            grilla.Rows[renglon_anterior].Cells["NumDeEmpleado"].Style.BackColor = Color.LightCoral;   // No. De Emp.
            grilla.Rows[renglon_anterior].Cells["EXT"].Style.BackColor = Color.LightCoral;   // Extension
            grilla.Rows[renglon_anterior].Cells["USER"].Style.BackColor = Color.LightCoral;   // Usuario de Red
            grilla.Rows[renglon_anterior].Cells["MAIL"].Style.BackColor = Color.LightCoral;   // Correo

            grilla.Rows[renglon_anterior].Cells["HOSTNAME"].Style.BackColor = Color.White;   // Hostname
            grilla.Rows[renglon_anterior].Cells["TipoDeEquipo"].Style.BackColor = Color.White;   // Tipo de equipo
            grilla.Rows[renglon_anterior].Cells["SN"].Style.BackColor = Color.White;   // Numero de serie
            grilla.Rows[renglon_anterior].Cells["Marca"].Style.BackColor = Color.White;   // Marca
            grilla.Rows[renglon_anterior].Cells["Modelo"].Style.BackColor = Color.White;   // Modelo
            grilla.Rows[renglon_anterior].Cells["Ubicacion"].Style.BackColor = Color.White;   // Ubicacion

            grilla.Rows[renglon_anterior].Cells["Departamento"].Style.BackColor = Color.LightCoral;  // Departamento

            grilla.Rows[renglon_anterior].Cells["Comentarios"].Style.BackColor = Color.White;   // Comentarios

            

            // Coloreamos la nueva seleccion
            grilla.Rows[renglon_actual].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.ControlLight); ;
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //renglon_actual = dataGridView1.CurrentCell.RowIndex;
            CargarDatos();
        }

        private void btnPedirToner_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            frm.ShowDialog();
            
            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtInventarioActual.Text == "Inventario de Usuarios y equipos")
            {
                añadir_equipo frm = new añadir_equipo(this);
                frm.Show();

                CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");
            }
            else
            {
                RJMessageBox.Show("Debes estar dentro del inventario de Usuarios y Equipos para realizar esta accion", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void solicitarTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            frm.ShowDialog();

            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");
        }

        private void EliminarUsuarioDeInventario()
        {
            #region METODO PARA ELIMINAR UN EQUIPO
            if (this.txtInventarioActual.Text == "Inventario de Usuarios y Equipos")
            {
                string usuario = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();
                string equipo = dataGridView1.Rows[renglon_actual].Cells["TipoDeEquipo"].Value.ToString();
                string hostname = dataGridView1.Rows[renglon_actual].Cells["HOSTNAME"].Value.ToString();

                if (RJMessageBox.Show($"¿Seguro que deseas eliminar el equipo < {equipo} / {hostname} / {usuario} > del inventario?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    /**
                    * PROCESO 2 - IDEA NUEVA
                    * 1 SELECCIONAR USUARIO A ELIMINAR
                    * 2 GUARDAR DATO POR DATO EN LISTA A EXCEPCION DEL QUE SE DESEA ELIMINAR
                    * 3 CARGAR LISTA NUEVA EN LA GRILLA
                    * 4 GUARDAR LA GRILLA COMO EXCEL DE INVENTARIO ACTUALIZADO
                    * **/
                    SLDocument nsl = new SLDocument();

                    List<InventarioViewModel> lst = new List<InventarioViewModel>();

                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        InventarioViewModel oUsuario = new InventarioViewModel();

                        oUsuario.NOMBRE = row.Cells[0].Value.ToString();
                        oUsuario.NumDeEmpleado = row.Cells[1].Value.ToString();
                        oUsuario.EXT = row.Cells[2].Value.ToString();
                        oUsuario.USER = row.Cells[3].Value.ToString();
                        oUsuario.MAIL = row.Cells[4].Value.ToString();
                        oUsuario.HOSTNAME = row.Cells[5].Value.ToString();
                        oUsuario.TipoDeEquipo = row.Cells[6].Value.ToString();
                        oUsuario.SN = row.Cells[7].Value.ToString();
                        oUsuario.Marca = row.Cells[8].Value.ToString();
                        oUsuario.Modelo = row.Cells[9].Value.ToString();
                        oUsuario.Ubicacion = row.Cells[10].Value.ToString();
                        oUsuario.Departamento = row.Cells[11].Value.ToString();
                        oUsuario.Comentarios = row.Cells[12].Value.ToString();

                        if (oUsuario.NOMBRE != usuario | oUsuario.TipoDeEquipo != equipo | oUsuario.HOSTNAME != hostname)
                        {
                            lst.Add(oUsuario);
                        } else
                        {
                            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE REGISTRO ELIMINACION DE USUARIO", "war");
                        }
                    }

                    CommonMethodsLibrary.OutMessage("in", this.Name, $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
                    dataGridView1.DataSource = lst;
                    CommonMethodsLibrary.OutMessage("in", this.Name, $@"GRILLA CARGADA", "oka");

                    CommonMethodsLibrary.OutMessage("OUT", this.Name, $@"GUARDANDO ARCHIVO DE INVENTARIO ACTUALIZADO", "inf");
                    ExcelMake.Make(this, "USUARIOS Y EQUIPOS");
                }
            }
            #endregion
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtInventarioActual.Text == "Inventario de Usuarios y equipos")
            {
                EliminarUsuarioDeInventario();
            }
            else
            {
                RJMessageBox.Show("Debes estar dentro del inventario de Usuarios y Equipos para realizar esta accion", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void añadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region METODO PARA MODIFICACAR / ELIMINAR / AÑADIR USUARIOS SEGUN LA LISTA
            if (this.txtInventarioActual.Text == "Inventario de Usuarios y equipos")
            {
                string USUARIO = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();

                inventario_lista_usuarios frm = new inventario_lista_usuarios(this, USUARIO, false);
                frm.ShowDialog();

                CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");
            }
            #endregion
        }

        
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            /* TECLAS:
             * DEL - ELIMINAR EQUIPO
             * ENTER - IMPORTAR USUARIO
             */

            if (e.KeyValue == (char)Keys.Delete)
            {
                EliminarUsuarioDeInventario();
            } else if (e.KeyValue == (char)Keys.Enter)
            {
                CargarDatos();
            }
        }

        private void SaveChanges(string aConstructor)
        {
            
            switch (aConstructor)
            {
                case "Inventario de Usuarios y Equipos":
                    ExcelMake.Make(this, "USUARIOS Y EQUIPOS");
                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE GUARDARON LOS CAMBIOS DEL INVENTARIO '{aConstructor}'", "oka");
                    break;
                case "Inventario de Impresoras":
                    ExcelMake.Make(this, "IMPRESORAS");
                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE GUARDARON LOS CAMBIOS DEL INVENTARIO '{aConstructor}'", "oka");

                    break;
                case "Inventario de Toners":
                    ExcelMake.Make(this, "TONERS");
                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE GUARDARON LOS CAMBIOS DEL INVENTARIO '{aConstructor}'", "oka");

                    break;
                case "Inventario de Refacciones":
                    ExcelMake.Make(this, "REFACCIONES");
                    CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE GUARDARON LOS CAMBIOS DEL INVENTARIO '{aConstructor}'", "oka");

                    break;
            }
            WAS_EDIT_FLAG = false;

            // Informamos a la grabadora de eventos
            foreach (Tuple<string, string, string> e in edittedProps)
            {
                string hostname = e.Item1;
                string targetPath = $@"{Application.StartupPath}\Inventories\{hostname}{MachineEventsHistorial.FileSuffix}";

                MachineEventsHistorial rec = new MachineEventsHistorial(targetPath);
                rec.AddEvent(M_EventItem.FromTemplate_UpdatedMachine(e.Item2, e.Item3));
                rec.Save();
            }
        }



        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges(this.txtInventarioActual.Text);
            RJMessageBox.Show("Inventario guardado con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inventarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WAS_EDIT_FLAG) {
                if (!Properties.Settings.Default.SYSDATA_GUARDARSIEMRPEINVENTARIO) {
                    switch (RJMessageBox.Show($"¿Deseas guardar los cambios del < {this.txtInventarioActual.Text} > antes de cerrarlo?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                    {
                        case DialogResult.Yes:
                            SaveChanges(this.txtInventarioActual.Text);

                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                } else
                {
                    SaveChanges(this.txtInventarioActual.Text);

                }
            }
        }

        private void inventarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                CommonMethodsLibrary.OutMessage("out", this.Name, $@"CERAMOS EL FORMULARIO '{this.Name}'", "inf");

                this.Close();
            }
        }

        private void toolPedirToner_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            frm.ShowDialog();

            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");

        }

        private void toolCargarSeleccion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolGuardarActual_Click(object sender, EventArgs e)
        {
            SaveChanges(this.txtInventarioActual.Text);
            RJMessageBox.Show("Inventario guardado con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolAñadirElemento_Click(object sender, EventArgs e)
        {
            /* AÑADIR ELEMENTO AL INVENTARIO ACTUAL */

            // Proceso de evaluacion
            switch (this.txtInventarioActual.Text)
            {
                case "Inventario de Usuarios y Equipos":
                    // Operacion asincrona
                    backgroundWorker_WaitScreen.RunWorkerAsync();

                    añadir_equipo frm_e = new añadir_equipo(this);
                    frm_e.ShowDialog();
                    break;
                case "Inventario de Impresoras":
                    añadir_impresora frm_i = new añadir_impresora(this);
                    frm_i.ShowDialog();
                    break;
                case "Inventario de Toners":
                    añadir_toner frm_t = new añadir_toner(this);
                    frm_t.ShowDialog();
                    break;
                case "Inventario de Refacciones":
                    añadir_refaccion frm_r = new añadir_refaccion(this);
                    frm_r.ShowDialog();
                    break;
            }
        }

        private void toolEliminarElemento_Click(object sender, EventArgs e)
        {
            /* ELIMINAR ELEMENTO DEL INVENTARIO ACTUAL */

            // Proceso de evaluacion
            switch (this.txtInventarioActual.Text)
            {
                case "Inventario de Usuarios y Equipos":
                    EliminarUsuarioDeInventario();
                    WAS_EDIT_FLAG = false;
                    break;
                case "Inventario de Impresoras":
                    #region ELIMINACION DE IMPRESORA SELECCIONADA

                    string IMPRESORA = dataGridView1.Rows[renglon_actual].Cells["Impresora"].Value.ToString();

                    if (RJMessageBox.Show($"¿Seguro que deseas eliminar la impresora < {IMPRESORA} > del inventario?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        SLDocument nsl = new SLDocument();

                        List<ImpresorasViewModel> lst = new List<ImpresorasViewModel>();

                        foreach (DataGridViewRow row in this.dataGridView1.Rows)
                        {
                            ImpresorasViewModel impresora = new ImpresorasViewModel();

                            impresora.Impresora = row.Cells[0].Value.ToString();
                            impresora.Marca = row.Cells[1].Value.ToString();
                            impresora.Modelo = row.Cells[2].Value.ToString();
                            impresora.Ubicacion = row.Cells[3].Value.ToString();
                            impresora.IP = row.Cells[4].Value.ToString();

                            if (impresora.Impresora != IMPRESORA)
                            {
                                lst.Add(impresora);
                            }
                        }

                        dataGridView1.DataSource = lst;

                        ExcelMake.Make(this, "IMPRESORA");
                    }
                    #endregion
                    WAS_EDIT_FLAG = false;
                    break;
                case "Inventario de Toners":
                    #region ELIMINACION DE IMPRESORA SELECCIONADA

                    string MODELO = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
                    string MARCA = dataGridView1.Rows[renglon_actual].Cells["Marca"].Value.ToString();
                    string DESCRIPCION = dataGridView1.Rows[renglon_actual].Cells["Descripcion"].Value.ToString();
                    string CANTIDAD = dataGridView1.Rows[renglon_actual].Cells["Cantidad"].Value.ToString();


                    if (RJMessageBox.Show($"¿Seguro que deseas eliminar el toner < {DESCRIPCION} > para las impresoras modelo < {MODELO} > del inventario?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        SLDocument nsl = new SLDocument();

                        List<TonersViewModel> lst = new List<TonersViewModel>();

                        foreach (DataGridViewRow row in this.dataGridView1.Rows)
                        {
                            TonersViewModel toner = new TonersViewModel();

                            toner.Modelo = row.Cells[0].Value.ToString();
                            toner.Marca = row.Cells[1].Value.ToString();
                            toner.Descripcion = row.Cells[2].Value.ToString();
                            toner.Cantidad = row.Cells[3].Value.ToString();

                            if (toner.Modelo != MODELO & toner.Marca != MARCA & toner.Descripcion != DESCRIPCION & toner.Cantidad != DESCRIPCION)
                            {
                                lst.Add(toner);
                            }
                        }

                        dataGridView1.DataSource = lst;

                        ExcelMake.Make(this, "TONER");
                    }
                    #endregion
                    WAS_EDIT_FLAG = false;
                    break;
                case "Inventario de Refacciones":
                    break;
            }
        }

        private void toolCambiarInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.toolCambiarInventario.SelectedIndex)
            {
                case 0: // "Usuarios y equipos":
                    InventoryHasChange(InventoryClass.UsuariosYEquipos);
                    break;
                case 1: // "Impresoras":
                    InventoryHasChange(InventoryClass.Impresoras);
                    break;
                case 2: // "Toners":
                    InventoryHasChange(InventoryClass.Toners);
                    break;
                case 3: // "Refacciones":
                    InventoryHasChange(InventoryClass.Refacciones);
                    break;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /* METODO DE FUNCIONAMIENTO:
             * CREA ARCHIVO EXCEL DE VISUALIZACION ACTUAL
             * IMPRIME EL ARCHIVO
             * ELIMINA EL ARCHIVO POST-IMPRESION
             */

            string TEMPORAL_EXCEL_PATH = $@"{Application.StartupPath}\TEMPORAL_EXCEL.xlsx";
            ExcelPDFConverter.Initialize(this);

            switch (this.txtInventarioActual.Text)
            {
                case "Inventario de Usuarios y Equipos":
                    #region METODO DE GENERACION
                    /* INVENTARIO DE USUARIOS Y EQUIPOS */
                    PrinterForm frm_e = new PrinterForm(ExcelPDFConverter.MakePDFOfUsuariosYEquipos(), "inventarios", this);
                    frm_e.Show();
                    #endregion
                    break;
                /*
                case "Inventario de Impresoras":
                    #region METODO DE GENERACION
                    PrinterForm frm_i = new PrinterForm(ExcelPDFConverter.MakePDFOfImpresoras(), "inventarios");
                    frm_i.Show();
                    #endregion
                    break;*/
            }
        }




        search_on_inventory frm_search;
        
        private void toolBuscar_Click(object sender, EventArgs e)
        {
            //FiltrarInventario(this.toolDatoABuscar.Text, this.toolBuscarEn.Text);
            string MANDANTE = "";

            switch (this.txtInventarioActual.Text)
            {
                case "Inventario de Usuarios y Equipos":
                    MANDANTE = "USUARIOS Y EQUIPOS";
                    break;
                case "Inventario de Impresoras":
                    MANDANTE = "IMPRESORAS";
                    break;
                case "Inventario de Toners":
                    MANDANTE = "TONERS";
                    break;
                case "Inventario de Refacciones":
                    MANDANTE = "REFACCIONES";
                    break;
                default:
                    MANDANTE = "NULL";
                    break;
            }

            frm_search = new search_on_inventory(this, MANDANTE);
            bool openFormsCount = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "search_on_inventory")
                {
                    openFormsCount = true;

                    if (f.WindowState == FormWindowState.Minimized)
                    {
                        f.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        f.BringToFront();
                    }
                }
                else
                {
                    openFormsCount = false;
                }
            }

            if (!openFormsCount)
            {
                frm_search.Show();
                CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm_search.Name}'", "oka");

            }
        }

        private void toolModificarTarjetaDeUsuario_Click(object sender, EventArgs e)
        {
            /* Modificamos el usuario que hemos seleccionado */
            string usuario = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();

            inventario_lista_usuarios frm = new inventario_lista_usuarios(this, usuario, true);
            frm.ShowDialog();

            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE ABRIO EL FORMULARIO '{frm.Name}'", "oka");

        }

        private void inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonMethodsLibrary.OutMessage("out", this.Name, $@"SE CERRO EL FORMULARIO '{this.Name}'", "INF");

            #region CIERRE DE FORMULARIOS ABIERTOS

            /*
            bool Form_search_on_inv = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "search_on_inventory")
                {
                    Form_search_on_inv = true;
                }
            }

            if (Form_search_on_inv)
            {
                
                try 
                {
                    frm_search.Close();
                } catch (Exception ex)
                {

                }
            }*/

            #endregion
        }

        private void toolReasignarEquipo_Click(object sender, EventArgs e)
        {
            // Datos del usuario actual
            string USUARIO = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();
            string NODEEMP = dataGridView1.Rows[renglon_actual].Cells["NumDeEmpleado"].Value.ToString();
            string EXTENSION = dataGridView1.Rows[renglon_actual].Cells["EXT"].Value.ToString();
            string REDUSER = dataGridView1.Rows[renglon_actual].Cells["USER"].Value.ToString();
            string CORREO = dataGridView1.Rows[renglon_actual].Cells["MAIL"].Value.ToString();
            string DEPARTAMENTO = dataGridView1.Rows[renglon_actual].Cells["Departamento"].Value.ToString();


            // Datos de equipo
            string HOSTNAME = dataGridView1.Rows[renglon_actual].Cells["HOSTNAME"].Value.ToString();
            string EQUIPO = dataGridView1.Rows[renglon_actual].Cells["TipoDeEquipo"].Value.ToString();
            string SN = dataGridView1.Rows[renglon_actual].Cells["SN"].Value.ToString();
            string MARCA = dataGridView1.Rows[renglon_actual].Cells["Marca"].Value.ToString();
            string MODELO = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
            string Ubicacion = dataGridView1.Rows[renglon_actual].Cells["Ubicacion"].Value.ToString();
            string Comentarios = dataGridView1.Rows[renglon_actual].Cells["Comentarios"].Value.ToString();


            // Copiara todos los datos en una nueva fila
            reasignacion_de_equipo frm = new reasignacion_de_equipo(this, HOSTNAME, EQUIPO, SN, MARCA, MODELO, Ubicacion, Comentarios, USUARIO, NODEEMP, EXTENSION, REDUSER, CORREO, DEPARTAMENTO);
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCrearResguardoDelEquipo_Click(object sender, EventArgs e)
        {
            this.backgroundWorker_WaitScreen.RunWorkerAsync();

            añadir_equipo frm = new añadir_equipo(this, true);
            frm.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {
                renglon_anterior = renglon_actual;  // Estblecemos el renglon anterior
                renglon_actual = dataGridView1.CurrentCell.RowIndex;    // Establecemos el actual
                
                switch (this.txtInventarioActual.Text)
                {
                    case "Inventario de Usuarios y Equipos":
                        #region
                        string USUARIO = dataGridView1.Rows[renglon_actual].Cells["NOMBRE"].Value.ToString();
                        string EQUIPO = dataGridView1.Rows[renglon_actual].Cells["TipoDeEquipo"].Value.ToString();
                        string HOSTNAME = dataGridView1.Rows[renglon_actual].Cells["HOSTNAME"].Value.ToString();

                        this.toolTipoDeEquipo.Text = EQUIPO;
                        this.toolHostname.Text = HOSTNAME;
                        this.toolNombre.Text = USUARIO;

                        // Actualizamos el objeto ActualMachine
                        ActualMachine.NOMBRE = USUARIO;
                        ActualMachine.NumDeEmpleado = dataGridView1.Rows[renglon_actual].Cells["NumDeEmpleado"].Value.ToString();
                        ActualMachine.EXT = dataGridView1.Rows[renglon_actual].Cells["EXT"].Value.ToString();
                        ActualMachine.USER = dataGridView1.Rows[renglon_actual].Cells["USER"].Value.ToString();
                        ActualMachine.MAIL = dataGridView1.Rows[renglon_actual].Cells["MAIL"].Value.ToString();
                        ActualMachine.HOSTNAME = HOSTNAME;
                        ActualMachine.TipoDeEquipo = EQUIPO;
                        ActualMachine.SN = dataGridView1.Rows[renglon_actual].Cells["SN"].Value.ToString();
                        ActualMachine.Marca = dataGridView1.Rows[renglon_actual].Cells["Marca"].Value.ToString();
                        ActualMachine.Modelo = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
                        ActualMachine.Ubicacion = dataGridView1.Rows[renglon_actual].Cells["Ubicacion"].Value.ToString();
                        ActualMachine.Departamento = dataGridView1.Rows[renglon_actual].Cells["Departamento"].Value.ToString();
                        ActualMachine.Comentarios = dataGridView1.Rows[renglon_actual].Cells["Comentarios"].Value != null ? dataGridView1.Rows[renglon_actual].Cells["Comentarios"].Value.ToString() : "";

                        string[] availableTypes = new string[] { "pc", "laptop", "desktop", "escritorio", "portatil" };
                        bool e_flag = false;

                        if (availableTypes.Contains(ActualMachine.TipoDeEquipo.ToLower().Trim()))
                        {
                            e_flag = true;
                        }
                        this.toolStrpBtnVerPerfilDeMaquina.Enabled = e_flag;

                        //GridColorPaint();
                        #endregion
                        break;
                    case "Inventario de Impresoras":
                        #region
                        string IMPRESORA = dataGridView1.Rows[renglon_actual].Cells["Impresora"].Value.ToString();
                        string UBICACION = dataGridView1.Rows[renglon_actual].Cells["Ubicacion"].Value.ToString();
                        string MODELO = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();

                        this.toolTipoDeEquipo.Text = IMPRESORA;
                        this.toolHostname.Text = MODELO;
                        this.toolNombre.Text = UBICACION;
                        #endregion
                        break;
                    case "Inventario de Toners":
                        #region
                        string MODELOi = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
                        string DESCRIPCION = dataGridView1.Rows[renglon_actual].Cells["Descripcion"].Value.ToString();
                        string CANTIDAD = dataGridView1.Rows[renglon_actual].Cells["Cantidad"].Value.ToString();

                        this.toolTipoDeEquipo.Text = MODELOi;
                        this.toolHostname.Text = CANTIDAD;
                        this.toolNombre.Text = DESCRIPCION;
                        #endregion
                        break;
                    case "Inventario de Refacciones":
                        #region
                        string DESCRIPCIONr = dataGridView1.Rows[renglon_actual].Cells["Descripcion"].Value.ToString();
                        string MODELOr = dataGridView1.Rows[renglon_actual].Cells["Modelo"].Value.ToString();
                        string SERIE = dataGridView1.Rows[renglon_actual].Cells["Serie"].Value.ToString();

                        this.toolTipoDeEquipo.Text = DESCRIPCIONr;
                        this.toolHostname.Text = SERIE;
                        this.toolNombre.Text = MODELOr;
                        #endregion
                        break;
                }
            }
            catch
            {
                // IGNORAR
            }
            
        }

        private void toolExportarInventarios_Click(object sender, EventArgs e)
        {
            /* Creamos una copia de respaldo del inventario */
            respaldo_de_programa frm = new respaldo_de_programa();
            frm.ShowDialog();
        }

        private void inventarios_Shown(object sender, EventArgs e)
        {
            
            if (padre_main != null)
            {
                padre_main.loadingForm.Close();
                padre_main.backgroundWorker_WaitScreen.CancelAsync();

                this.Focus();
            } else if (padre_rit != null) {
                //padre_rit.loadingForm.Close();
                padre_rit.backgroundWorker_WaitScreen.CancelAsync();
            }
            
        }


        public TaskLoadingForm loadingForm;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            loadingForm = new TaskLoadingForm(this, "Cargando usuarios, departamentos y formatos!", "En espera", false);
            loadingForm.ShowDialog();
        }

        private void btnBuscarCoincidencia_Click(object sender, EventArgs e)
        {
            /* 
             * Buscamos y mostramos la primer coincidencia encontrada
             * */
            if (!String.IsNullOrEmpty(this.txtValorBuscar.Text))
            {
                string MANDANTE = "";

                switch (ActualInv)
                {
                    case InventoryClass.UsuariosYEquipos:
                        MANDANTE = "USUARIOS Y EQUIPOS";
                        break;
                    case InventoryClass.Impresoras:
                        MANDANTE = "IMPRESORAS";
                        break;
                    case InventoryClass.Toners:
                        MANDANTE = "TONERS";
                        break;
                    case InventoryClass.Refacciones:
                        MANDANTE = "REFACCIONES";
                        break;
                    default:
                        MANDANTE = "NULL";
                        break;
                }

                search_on_inventory frm = new search_on_inventory(this, MANDANTE, this.cboxTipoValor.Text, this.cboxParametroDeCoincidencia.Text, this.txtValorBuscar.Text);
                frm.Show();
            }
        }

        private void toolVerHistorialDelEquipoSeleccionado_Click(object sender, EventArgs e)
        {
            /*
             * Abrimos el formulario del historial del equipo actualmente seleccionado
             */
            exHistorialDeCambios frm = new exHistorialDeCambios(ActualMachine);
            frm.Show();
        }

        /// <summary>
        /// Tupla valores:
        /// 1 : hostname afectado, 2 : propiedad afectada, 3 : valor nuevo
        /// </summary>
        List<Tuple<string, string, string>> edittedProps = new List<Tuple<string, string, string>>();

        string lastProp_PreviousValue = "";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lastProp_PreviousValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        string lastProp_NewValue = "";
        string lastProp_ColName = "";
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            WAS_EDIT_FLAG = true;

            // Solo lo registramos si estamos en el inventario de Equipos
            if (ActualInv == InventoryClass.UsuariosYEquipos)
            {
                lastProp_NewValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value != null ? dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() : "";
                lastProp_ColName = dataGridView1.Columns[e.ColumnIndex].HeaderText;

                Tuple<string, string, string> _tup = new Tuple<string, string, string>(ActualMachine.HOSTNAME, lastProp_ColName, lastProp_NewValue);

                edittedProps.Add(_tup);
            }
        }

        private void txtValorBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnBuscarCoincidencia.PerformClick();
            }
        }

        private void visualizarTablaDeHistorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabla_historiales frm = new tabla_historiales();
            frm.ShowDialog();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * ACTUALIZAMOS SEGUN EL NOMBRE EN ORDEN ALFABETICO
             * */
            List<DataGridViewRow> filas = dataGridView1.Rows.Cast<DataGridViewRow>()
                                            .Where(row => !row.IsNewRow)
                                            .OrderBy(row => row.Cells[1].Value?.ToString())
                                            .ToList();
        }

        private void numeroDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> filas = dataGridView1.Rows.Cast<DataGridViewRow>()
                                            .Where(row => !row.IsNewRow)
                                            .OrderBy(row => row.Cells[1].Value?.ToString())
                                            .ToList();

        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void toolPedirRefaccion_Click(object sender, EventArgs e)
        {
            solicitar_refaccion frm = new solicitar_refaccion();
            frm.Show();
        }

        private void toolStrpBtnAlertas_Click(object sender, EventArgs e)
        {
            /* 
             * Mostramos las alertas en el sistema
             * */
        }

        private void toolStrpVerPerfilDeMaquina_Click(object sender, EventArgs e)
        {
            /* 
             * Abrimos el perfil del equipo seleccionado
             * */
            MachineProfiles.machine_profile frm = new MachineProfiles.machine_profile(MachineProfile.Build(ActualMachine));
            frm.Show();
        }

        private void toolCambiarInventario_Click(object sender, EventArgs e)
        {

        }
    }
}
