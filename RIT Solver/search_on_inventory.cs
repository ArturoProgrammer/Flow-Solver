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
using SpreadsheetLight;

using CustomMessageBox;
using Flow_Solver.Centro_de_Control;


namespace Flow_Solver
{
    public partial class search_on_inventory : Form
    {
        private inventarios padre;
        string Constructor;

        public search_on_inventory(inventarios aLegacyForm, string aConstructor)
        {
            InitializeComponent();
            padre = aLegacyForm;
            this.MinimumSize = this.Size;
            Constructor = aConstructor;
            CommonMethodsLibrary.OutMessage("in", this.Name, $"MANDANTE REGISTRADO '{Constructor}'", "oka");
        }

        public search_on_inventory(inventarios aLegacyForm, string aConstructor, string aSegun, string aQueCoincida, string aValorBuscado)
        {
            InitializeComponent();
            padre = aLegacyForm;
            this.MinimumSize = this.Size;
            Constructor = aConstructor;
            CommonMethodsLibrary.OutMessage("in", this.Name, $"MANDANTE REGISTRADO '{Constructor}'", "oka");

            haveToSearch = true;
            segun = aSegun;
            queCoincida = aQueCoincida;
            valorBuscado = aValorBuscado;
        }

        #region METODOS PROPIOS
        /// <summary>
        /// Metodo para realizar la busqueda de coincidencias de un dato a buscar.
        /// </summary>
        /// <param name="aDatoBuscar">Dato que se buscara.</param>
        /// <param name="aDondeBuscar">Inventario en el que se realizara el filtrado</param>
        private void FiltrarInventario(string aDatoBuscar, string aDondeBuscar)
        {
            Filter.Initialize(this);

            if (!string.IsNullOrEmpty(aDatoBuscar))
            {
                // Si la casilla esta vacia indica que se cargaran los inventarios por default
                
                switch (this.cboxInventarioABuscar.Text)

                {
                    case "USUARIOS Y EQUIPOS":
                        // En caso de buscar en el inventario de usuarios
                        this.dataGridView1.DataSource = Filter.UsuariosYEquipos_Filtro(aDatoBuscar, aDondeBuscar, this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusculasMinusculas.Checked, this.fatherDataGridViewEmulate);
                        break;
                    case "IMPRESORAS":
                        // En caso de buscar en impresoras
                        this.dataGridView1.DataSource = Filter.Impresoras_Filtro(aDatoBuscar, aDondeBuscar, this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusculasMinusculas.Checked, this.fatherDataGridViewEmulate);
                        break;
                    case "TONERS":
                        // En caso de buscar en toners
                        this.dataGridView1.DataSource = Filter.Toners_Filtro(aDatoBuscar, aDondeBuscar, this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusculasMinusculas.Checked, this.fatherDataGridViewEmulate);
                        break;
                    case "REFACCIONES":
                        // En caso de buscar en refacciones
                        this.dataGridView1.DataSource = Filter.Refacciones_Filtro(aDatoBuscar, aDondeBuscar, this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusculasMinusculas.Checked, this.fatherDataGridViewEmulate);
                        break;
                    default:
                        Console.WriteLine($"***** BUSCANDO: {aDatoBuscar} EN: {aDondeBuscar} DE: {this.cboxInventarioABuscar.Text}");
                        break;
                }
            }
        }
        
        /// <summary>
        /// Indica si la operacion se realizo correctamente
        /// </summary>
        /// <param name="IsReady"> 'true', cuando la operacion se realizo correctamente; y 'false' cuando no se concreto</param>
        public void UpdateJob(bool IsReady)
        {
            if (IsReady)
            {
                this.toolStripJobStatus.Text = "Listo!";
                this.toolStripJobStatus.ForeColor = Color.Green;
            }
            else
            {
                this.toolStripJobStatus.Text = "Error!";
                this.toolStripJobStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Actualiza el Label que indica la cantidad de resultados encontrados.
        /// </summary>
        /// <param name="Results">Cantidad de resultados de la lista de filtrado</param>
        public void UpdateResultsFound(int Results)
        {
            if (Results > 0)
            {
                this.toolStripCoincidencias.Text = $"{Results} Coincidencias encontradas";
                this.toolStripCoincidencias.ForeColor = Color.Green;
            } else
            {
                this.toolStripCoincidencias.Text = $"No se encontraron coincidencias";
                this.toolStripCoincidencias.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Ultima fila seleccionada que fue pintada.
        /// </summary>
        private int LastSelectionRow { get; set; }

        /// <summary>
        /// Resalta la fila de la seleccion actual en el DataGridView indicado.
        /// </summary>
        /// <param name="Row">Fila del elemento seleccionado.</param>
        private void ResaltSelection (DataGridViewRow Row)
        {
            if (this.cboxInventarioABuscar.Text == "USUARIOS Y EQUIPOS")
            {
                DataGridView grilla = padre.dataGridView1;

                grilla.Rows[LastSelectionRow].Cells["NOMBRE"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["NumDeEmpleado"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["EXT"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["USER"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["MAIL"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["HOSTNAME"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["TipoDeEquipo"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["SN"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["Marca"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["Modelo"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["Ubicacion"].Style.BackColor = Color.White;
                grilla.Rows[LastSelectionRow].Cells["Departamento"].Style.BackColor = Color.LightCoral;
                grilla.Rows[LastSelectionRow].Cells["Comentarios"].Style.BackColor = Color.White;
            }

            foreach (DataGridViewCell cell in Row.Cells)
            {
                //cell.Style.BackColor = Color.FromArgb(255, 249, 132);
                cell.Style.BackColor = Color.FromArgb(93, 206, 255);
            }

            LastSelectionRow = Row.Index;   // Indicamos la ultima celda que se selecciono
        }
        #endregion



        bool haveToSearch = false;
        string segun = "";
        string queCoincida = "";
        string valorBuscado = "";

        private void search_on_inventory_Load(object sender, EventArgs e)
        {
            this.toolStripCoincidencias.Text = String.Empty;

            #region Cargamos valores de lista de inventarios disponibles
            this.cboxInventarioABuscar.Items.Clear();
            string INV_DIR = $@"{Application.StartupPath}\Inventories\";

            if (Directory.Exists(INV_DIR))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(INV_DIR);
                    FileInfo[] files = di.GetFiles("*.xlsx");

                    foreach (FileInfo file in files)
                    {
                        int s_len = file.Name.Length;
                        this.cboxInventarioABuscar.Items.Add(file.Name.Remove(s_len - 5, 5));
                    }


                    this.cboxInventarioABuscar.SelectedIndex = 3;
                    this.cboxColumnaDondeBuscar.SelectedIndex = 0;

                    this.chckboxIgnorarMayusculasMinusculas.Checked = true;
                    this.chckboxCoincidirCeldaCompleta.Checked = false;

                    this.Cursor = Cursors.Default;

                    this.UpdateJob(true);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message);
                    this.UpdateJob(false);
                }
            } else
            {
                this.UpdateJob(false);
            }
            #endregion

            /*
            int iC = 1;
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                iC++;
            }*/

            this.txtDatoBuscar.Select();
            this.cboxInventarioABuscar.Text = Constructor;

            if (haveToSearch)
            {
                this.cboxColumnaDondeBuscar.Text = segun;
                if (queCoincida.Trim() == "Coincidir con todo el contenido de la celda...")
                {
                    this.chckboxCoincidirCeldaCompleta.Checked = true;
                }
                else if (queCoincida.Trim() == "Que la celda contenga...")
                {
                    this.chckboxIgnorarMayusculasMinusculas.Checked = true;
                }
                this.txtDatoBuscar.Text = valorBuscado;
                this.btnBuscarInfo.PerformClick();
                //this.btnBuscarInfo.PerformClick();
            }

        }

        private void cboxInventarioABuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("Seleccionado: " + cboxInventarioABuscar.SelectedIndex + " / " + cboxInventarioABuscar.Text);
            this.cboxColumnaDondeBuscar.Items.Clear();
            fatherDataGridViewEmulate.DataSource = null;
            
            SLDocument sl; // COMMON VALUE

            #region EXTRAEMOS COLUMNAS DEL INVENTARIO SELECCIONADO
            string INVENTORIES_DIR_PATH = $@"{Application.StartupPath}\Inventories";

            try
            {
                int iRow = 1;

                if (this.cboxInventarioABuscar.Text == "USUARIOS Y EQUIPOS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx");

                        for (int i = 1; i <= 13; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxColumnaDondeBuscar.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (this.cboxInventarioABuscar.Text == "IMPRESORAS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx");

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxColumnaDondeBuscar.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (this.cboxInventarioABuscar.Text == "TONERS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx");

                        for (int i = 1; i <= 4; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxColumnaDondeBuscar.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (this.cboxInventarioABuscar.Text == "REFACCIONES") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx"))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{this.cboxInventarioABuscar.Text}.xlsx");

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"*- {i} -" + sl.GetCellValueAsString(iRow, i));
                            this.cboxColumnaDondeBuscar.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
            #endregion

            #region LLENAMOS EL FATHER_DATA_GRID_VIEW_EMULATED
            switch (this.cboxInventarioABuscar.Text)
            {
                case "USUARIOS Y EQUIPOS":
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx"))
                    {
                        int iRow = 2;
                        // Cargamos archivo hecho por molde
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx");

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
                        }
                        fatherDataGridViewEmulate.DataSource = lst;
                    }
                    break;

                case "IMPRESORAS":
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx"))
                    {
                        int iRow = 2;
                        // Cargamos archivo hecho por molde
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx");

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
                        fatherDataGridViewEmulate.DataSource = lst;
                    }
                    break;

                case "TONERS":
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx"))
                    {
                        int iRow = 2;
                        // Cargamos archivo hecho por molde
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx");

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
                        fatherDataGridViewEmulate.DataSource = lst;
                        //if (lst.Count > 0) { Console.WriteLine("****--TONER CARGADO EN FATHER VIEW"); }
                    }
                    break;

                case "REFACCIONES":
                    if (File.Exists($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx"))
                    {
                        int iRow = 2;
                        // Cargamos archivo hecho por molde
                        sl = new SLDocument($@"{INVENTORIES_DIR_PATH}\{cboxInventarioABuscar.Text}.xlsx");

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
                        fatherDataGridViewEmulate.DataSource = lst;
                    }
                    break;
            }
            #endregion

            this.cboxColumnaDondeBuscar.SelectedIndex = 0;
        }

        private void btnBuscarInfo_Click(object sender, EventArgs e)
        {
            //Console.WriteLine($"BentarioABuscar.Text");

            if (!String.IsNullOrEmpty(this.txtDatoBuscar.Text))
            {
                string INVENTARIO = this.cboxInventarioABuscar.Text;
                string COLUMNA = "";
                string OBJETO = this.txtDatoBuscar.Text;

                switch (this.cboxColumnaDondeBuscar.Text)
                {
                    case "Nombre de Usuario":
                        COLUMNA = "NOMBRE";
                        break;
                    case "No. Emp.":
                        COLUMNA = "NumDeEmpleado";
                        break;
                    case "Ext.":
                        COLUMNA = "EXT";
                        break;
                    case "Red User":
                        COLUMNA = "USER";
                        break;
                    case "Correo":
                        COLUMNA = "MAIL";
                        break;
                    case "Tipo de Equipo":
                        COLUMNA = "TipoDeEquipo";
                        break;
                    case "No. Serie":
                        COLUMNA = "SN";
                        break;
                    default:
                        COLUMNA = this.cboxColumnaDondeBuscar.Text;
                        break;
                }

                FiltrarInventario(OBJETO, COLUMNA);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int renglon = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* SELECCIONA EL INDICE DEL ELEMENTO */
            try
            {
                renglon = dataGridView1.CurrentCell.RowIndex;

                switch (this.cboxInventarioABuscar.Text)
                {
                    case "USUARIOS Y EQUIPOS":
                        string USUARIO = dataGridView1.Rows[renglon].Cells["NOMBRE"].Value.ToString();
                        string EQUIPO = dataGridView1.Rows[renglon].Cells["TipoDeEquipo"].Value.ToString();
                        string HOSTNAME = dataGridView1.Rows[renglon].Cells["HOSTNAME"].Value.ToString();

                        break;
                    case "IMPRESORAS":
                        string IMPRESORA = dataGridView1.Rows[renglon].Cells["Impresora"].Value.ToString();
                        string UBICACION = dataGridView1.Rows[renglon].Cells["Ubicacion"].Value.ToString();
                        string MODELO = dataGridView1.Rows[renglon].Cells["Modelo"].Value.ToString();

                        break;
                    case "TONERS":
                        string MODELOi = dataGridView1.Rows[renglon].Cells["Modelo"].Value.ToString();
                        string DESCRIPCION = dataGridView1.Rows[renglon].Cells["Descripcion"].Value.ToString();
                        string CANTIDAD = dataGridView1.Rows[renglon].Cells["Cantidad"].Value.ToString();

                        break;
                    case "REFACCIONES":
                        string DESCRIPCIONr = dataGridView1.Rows[renglon].Cells["Descripcion"].Value.ToString();
                        string MODELOr = dataGridView1.Rows[renglon].Cells["Modelo"].Value.ToString();
                        string SERIE = dataGridView1.Rows[renglon].Cells["Serie"].Value.ToString();

                        break;
                }
            }
            catch
            {
                // IGNORAR
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* SELECCIONA EL ELEMENTO EN EL INVENTARIO PRINCIPAL */

            /** METODO
             * - RECORRER HASTA ENCONTRAR EL NOMBRE DEL USUARIO
             * - VALIDAR QUE EL NUMERO DE SERIE SEA EL MISMO
             * - SELECCIONAR FILA ENCONTRADA (SI SE ENCONTRO)
             * **/

            string MANDANTE = "";

            switch (padre.txtInventarioActual.Text)
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

            string NOMBRE_THISDGV = this.dataGridView1.Rows[renglon].Cells["NOMBRE"].Value.ToString();
            string EQUIPO_THISDGV = dataGridView1.Rows[renglon].Cells["SN"].Value.ToString();
            string HOSTNAME_THISDGV = dataGridView1.Rows[renglon].Cells["HOSTNAME"].Value.ToString();

            if (MANDANTE == Constructor)
            {
                foreach (DataGridViewRow row in padre.dataGridView1.Rows)
                {
                    string NOMBRE_PADRE = row.Cells["NOMBRE"].Value.ToString();
                    string EQUIPO_PADRE = row.Cells["SN"].Value.ToString();
                    string HOSTNAME_PADRE = dataGridView1.Rows[renglon].Cells["HOSTNAME"].Value.ToString();

                    if (NOMBRE_PADRE == NOMBRE_THISDGV & EQUIPO_PADRE == EQUIPO_THISDGV & HOSTNAME_PADRE == HOSTNAME_THISDGV)
                    {
                        /*
                        int RenglonPadre = row.Index;
                        
                        padre.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        padre.dataGridView1.Rows[RenglonPadre].Selected = true;
                        padre.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        */

                        /* Marcamos la seleccion */
                        this.ResaltSelection(row);

                        CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ENCONTRO EL NOMBRE BUSCADO {NOMBRE_PADRE} PARA EL EQUIPO {EQUIPO_PADRE}", "oka");
                    }
                }
            } else
            {
                CommonMethodsLibrary.OutMessage("in", this.Name, $"NO SE ENCONTRO NINGUNA ACCION PARA EL MANDANTE '{Constructor}'", "err");
            }

            
        }
    }
}
