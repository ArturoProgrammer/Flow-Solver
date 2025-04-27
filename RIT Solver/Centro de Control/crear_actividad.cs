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
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json.Linq;
using FileProjectManager;
using DocumentFormat.OpenXml.Bibliography;
using System.Xaml;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace Flow_Solver.Centro_de_Control
{
    public partial class crear_actividad : Form
    {
        internal Actividad _Actividad = new Actividad();
        ActProj project = new ActProj();
        InventoryClass InventarioSeleccionado = InventoryClass.UsuariosYEquipos;
        private main BaseForm;

        public crear_actividad(main LegacyForm)
        {
            InitializeComponent();
            _Actividad.ListaEquipos = new List<Inventario4ActViewModel>();
            _Actividad.ListaRefacciones = new List<RefaccionesViewModel>();
            _Actividad.ListaImpresoras = new List<ImpresorasViewModel>();
            _Actividad.ListaToners = new List<TonersViewModel>();

            BaseForm = LegacyForm;
        }


        #region METODOS PRIVADOS
        internal string INVENTORIES_DIRECTORY = $@"{Application.StartupPath}\Inventories";

        private void LoadExcelFile_UsuariosYEquipos()
        {
            string SheetBook = "USUARIOS Y EQUIPOS";
            string BOOK_PATH = $@"{Application.StartupPath}\Inventories\{SheetBook}.xlsx";

            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CARGANDO ARCHIVO DE INVENTARIO EXISTENTE '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");


            // Cargamos el archivo que se creo en base al molde con anterioridad
            SLDocument sl = new SLDocument(BOOK_PATH);
            int iRow = 2;
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

            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"CARGANDO DATOS EN LA GRILLA ACTUAL", "inf");
            this.fatherDataGridViewEmulate.DataSource = lst;
            CommonMethodsLibrary.OutMessage("in", "inventarios.cs", $@"GRILLA CARGADA", "oka");

            // Nombramos las columnas
            /**
             * No mover este codigo por temas de compatibilidad
             * **/
            this.fatherDataGridViewEmulate.Columns["NOMBRE"].HeaderText = "Nombre de Usuario";
            this.fatherDataGridViewEmulate.Columns["NumDeEmpleado"].HeaderText = "No. Emp.";
            this.fatherDataGridViewEmulate.Columns["EXT"].HeaderText = "Ext.";
            this.fatherDataGridViewEmulate.Columns["USER"].HeaderText = "Red User";
            this.fatherDataGridViewEmulate.Columns["MAIL"].HeaderText = "Correo";
            this.fatherDataGridViewEmulate.Columns["HOSTNAME"].HeaderText = "Hostname";
            this.fatherDataGridViewEmulate.Columns["TipoDeEquipo"].HeaderText = "Tipo de Equipo";
            this.fatherDataGridViewEmulate.Columns["SN"].HeaderText = "No. Serie";
            this.fatherDataGridViewEmulate.Columns["Marca"].HeaderText = "Marca";
            this.fatherDataGridViewEmulate.Columns["Modelo"].HeaderText = "Modelo";
            this.fatherDataGridViewEmulate.Columns["Ubicacion"].HeaderText = "Ubicacion";
            this.fatherDataGridViewEmulate.Columns["Departamento"].HeaderText = "Departamento";
            this.fatherDataGridViewEmulate.Columns["Comentarios"].HeaderText = "Comentarios";


        }


        // Opciones por defecto
        private string[] opcionesDefault =
        {
                "(Todos los equipos de computo)",
                "(Todos los monitores)"
        };

        /// <summary>
        /// Funcion encargada de cargar las columnas de datos disponibles del inventario seleccionado.
        /// </summary>
        private void LoadColumns()
        {
            SLDocument sl; // COMMON VALUE
            string Selection = this.cboxSegunInventario.Text;
            this.cboxSegunColumna.Items.Clear();

            #region EXTRAEMOS COLUMNAS DEL INVENTARIO SELECCIONADO
            try
            {
                int iRow = 1;

                if (Selection == "USUARIOS Y EQUIPOS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    string TARGET_BOOKPATH = $@"{INVENTORIES_DIRECTORY}\{Selection}.xlsx";

                    if (File.Exists(TARGET_BOOKPATH))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument(TARGET_BOOKPATH);

                        for (int i = 1; i <= 13; i++)
                        {
                            this.cboxSegunColumna.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }

                        // Cargamos el excel en la grilla emuladora

                    }
                }
                else if (this.cboxSegunInventario.Text == "IMPRESORAS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    string TARGET_BOOKPATH = $@"{INVENTORIES_DIRECTORY}\{Selection}.xlsx";

                    if (File.Exists(TARGET_BOOKPATH))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument(TARGET_BOOKPATH);

                        for (int i = 1; i <= 5; i++)
                        {
                            this.cboxSegunColumna.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (this.cboxSegunInventario.Text == "TONERS") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    string TARGET_BOOKPATH = $@"{INVENTORIES_DIRECTORY}\{Selection}.xlsx";

                    if (File.Exists(TARGET_BOOKPATH))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument(TARGET_BOOKPATH);

                        for (int i = 1; i <= 4; i++)
                        {
                            this.cboxSegunColumna.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }
                else if (this.cboxSegunInventario.Text == "REFACCIONES") // ========= INVENTARIO DE USUARIOS Y EQUIPOS
                {
                    string TARGET_BOOKPATH = $@"{INVENTORIES_DIRECTORY}\{Selection}.xlsx";

                    if (File.Exists(TARGET_BOOKPATH))
                    {
                        // Cargamos el archivo que se creo en base al molde con anterioridad
                        sl = new SLDocument(TARGET_BOOKPATH);

                        for (int i = 1; i <= 5; i++)
                        {
                            this.cboxSegunColumna.Items.Add(sl.GetCellValueAsString(iRow, i));
                        }
                    }
                }

                UpdateJob(false, $"Inventario {this.cboxSegunInventario.Text} cargado con exito!");
            }
            catch (Exception ex)
            {
                UpdateJob(true, $"Error al cargar el inventario");
                RJMessageBox.Show(ex.Message);
            }
            #endregion
        }


        /// <summary>
        /// Actualiza el valor del Status Job del formulario.
        /// </summary>
        /// <param name="IsOk">Indica si es un mensaje de Alerta u Ok.</param>
        /// <param name="Message">Mensaje a mostrar en el Status Job del Formulario.</param>
        private void UpdateJob(bool IsOk, string Message)
        {
            if (IsOk)
            {
                this.lblStatusJob.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.lblStatusJob.ForeColor = System.Drawing.Color.Red;
            }

            this.lblStatusJob.Text = Message;
        }


        private string HeaderTextColumn_Translate(string HeaderTextColumn)
        {
            string response = "";

            if (InventarioSeleccionado == InventoryClass.UsuariosYEquipos)
            {
                switch (HeaderTextColumn)
                {
                    case "Nombre de Usuario":
                        response = "NOMBRE";
                        break;
                    case "No. Emp.":
                        response = "NumDeEmpleado";
                        break;
                    case "Ext.":
                        response = "EXT";
                        break;
                    case "Red User":
                        response = "USER";
                        break;
                    case "Correo":
                        response = "MAIL";
                        break;
                    case "Hostname":
                        response = "HOSTNAME";
                        break;
                    case "Tipo de Equipo":
                        response = "TipoDeEquipo";
                        break;
                    case "No. Serie":
                        response = "SN";
                        break;
                    case "Marca":
                        response = "Marca";
                        break;
                    case "Modelo":
                        response = "Modelo";
                        break;
                    case "Ubicacion":
                        response = "Ubicacion";
                        break;
                    case "Departamento":
                        response = "Departamento";
                        break;
                    case "Comentarios":
                        response = "Comentarios";
                        break;
                }
            }

            return response;
        }


        /// <summary>
        /// Filtra la seleccion y la muestra en el ListView del Formulario.
        /// </summary>
        private void FilterInventorySelection()
        {
            string INVENTORY = this.cboxSegunInventario.Text;
            string COLUMNA = this.cboxSegunColumna.Text;
            string VALOR = this.txtSegunDato.Text;

            DataGridView grilla = this.dgvPreviewSelection;
            grilla.Rows.Clear();

            //Filter.Initialize(this);

            if (!string.IsNullOrEmpty(VALOR))
            {
                // Si la casilla esta vacia indica que se cargaran los inventarios por default
                switch (INVENTORY)
                {
                    case "USUARIOS Y EQUIPOS":
                        // En caso de buscar en el inventario de usuarios
                        if (!opcionesDefault.Contains(COLUMNA)) {
                            foreach (InventarioViewModel i in Filter.UsuariosYEquipos_Filtro(VALOR, HeaderTextColumn_Translate(COLUMNA), this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusMinus.Checked, this.fatherDataGridViewEmulate))
                            {
                                if (i.TipoDeEquipo.ToLower().Trim() == "laptop" || i.TipoDeEquipo.ToLower().Trim() == "pc" || i.TipoDeEquipo.ToLower().Trim() == "desktop" || i.TipoDeEquipo.ToLower().Trim() == "escritorio" || i.TipoDeEquipo.ToLower().Trim() == "computadora")
                                {
                                    AddRowToGrid(i);
                                }
                            }
                        } else
                        {
                            /* 
                             * En caso de que tengamos seleccionadas las opciones comunes
                             * */
                            if (COLUMNA == "(Todos los equipos de computo)")
                            {

                            } 

                            switch (COLUMNA)
                            {
                                case "(Todos los equipos de computo)":
                                    // Añadimos todos los equipos de computo, exceptuando monitores, impresoras, reguladores, etc.
                                    
                                    break;
                                case "(Todos los monitores)":

                                    break;
                            }
                        }
                        break;
                    case "IMPRESORAS":
                        // En caso de buscar en impresoras
                        _Actividad.ListaImpresoras = Filter.Impresoras_Filtro(VALOR, HeaderTextColumn_Translate(COLUMNA), this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusMinus.Checked, this.fatherDataGridViewEmulate);
                        break;
                    case "TONERS":
                        // En caso de buscar en toners
                        _Actividad.ListaToners = Filter.Toners_Filtro(VALOR, HeaderTextColumn_Translate(COLUMNA), this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusMinus.Checked, this.fatherDataGridViewEmulate);
                        break;
                    case "REFACCIONES":
                        // En caso de buscar en refacciones
                        _Actividad.ListaRefacciones = Filter.Refacciones_Filtro(VALOR, HeaderTextColumn_Translate(COLUMNA), this.chckboxCoincidirCeldaCompleta.Checked, this.chckboxIgnorarMayusMinus.Checked, this.fatherDataGridViewEmulate);
                        break;
                    default:
                        Console.WriteLine($"***** BUSCANDO: {VALOR} EN: {COLUMNA} DE: {INVENTORY}");
                        break;
                }
            }
        }
        #endregion


        private void crear_actividad_Load(object sender, EventArgs e)
        {
            /* Cargamos los datos iniciales */
            if (CommonMethodsLibrary.ValidateInventoryExists(InventoryClass.UsuariosYEquipos))
            {
                // Cargamos los inventarios existentes
                DirectoryInfo di = new DirectoryInfo(INVENTORIES_DIRECTORY);

                foreach (var inv_file in di.GetFiles())
                {
                    string invent = inv_file.Name.Replace(".xlsx", string.Empty);
                    this.cboxSegunInventario.Items.Add(invent);
                }

                InventarioSeleccionado = InventoryClass.UsuariosYEquipos;
                this.cboxSegunInventario.SelectedItem = "USUARIOS Y EQUIPOS";
                this.cboxSegunInventario.DropDownStyle = ComboBoxStyle.DropDownList;

                // Por defecto cargamos el inventario de usuarios y equipos en la grilla emulada
                LoadExcelFile_UsuariosYEquipos();

                // Cargamos las columnas del inventario seleccionado
                LoadColumns();
                this.cboxSegunColumna.DropDownStyle = ComboBoxStyle.DropDownList;

                UpdateJob(true, "Todo listo!");
                this.Cursor = Cursors.Default;

                this.txtNombreDeLaActividad.Text = "Nueva actividad 1";
                this.txtRutaDeGuardado.Text = $@"{actualDirSelected}\{this.txtNombreDeLaActividad.Text}{ActProj._FileExtension}";

                this.txtNombreDeLaActividad.Select();
            }
            else
            {
                this.Cursor = Cursors.Default;

                UpdateJob(false, "Datos faltantes!");
                MessageBox.Show("Para usar esta funcion primero debes contar con un inventario iniciado!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void cboxSegunInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColumns();

            // Actualizamos el inventario actualmente seleccionado
            switch (this.cboxSegunInventario.Text)
            {
                case "USUARIOS Y EQUIPOS":
                    InventarioSeleccionado = InventoryClass.UsuariosYEquipos;
                    break;
                case "IMPRESORAS":
                    InventarioSeleccionado = InventoryClass.Impresoras;
                    break;
                case "TONERS":
                    InventarioSeleccionado = InventoryClass.Toners;
                    break;
                case "REFACCIONES":
                    InventarioSeleccionado = InventoryClass.Refacciones;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSegunDato_Leave(object sender, EventArgs e)
        {
            // Procesamos los datos que se deberan filtrar
            if (this.cboxSegunInventario.Text != String.Empty && this.cboxSegunColumna.Text != String.Empty)
            {
                if (!String.IsNullOrEmpty(this.txtSegunDato.Text))
                {
                    // Actualizamos la grilla de datos
                    this.btnFiltrarSeleccion.PerformClick();
                }
            }
        }

        /// <summary>
        /// Añade una maquina a la grilla
        /// </summary>
        /// <param name="Machine"></param>
        private void AddRowToGrid(InventarioViewModel Machine)
        {
            // Añadimos el equipo a la lista de seleccion actual
            Inventario4ActViewModel objTranslate = Inventario4ActViewModel.ParseFromBaseModel(Machine); ;
            objTranslate.IsMachineReady = false;
            objTranslate.TicketID = "";
            objTranslate.PDFRitName = "";
            objTranslate.Notas = "";
            objTranslate.HASH = CommonMethodsLibrary.IdentifierGenerator();

            _Actividad.ListaEquipos.Add(objTranslate);

            // Creamos la fila
            int lastItemCount = this.dgvPreviewSelection.Rows.Count == 0 ? 1 : dgvPreviewSelection.Rows.Count;
            object[] row = { true, lastItemCount, Machine.NOMBRE, Machine.NumDeEmpleado, Machine.EXT, Machine.USER, Machine.MAIL, Machine.HOSTNAME, Machine.TipoDeEquipo, Machine.SN, Machine.Marca, Machine.Modelo, Machine.Ubicacion, Machine.Departamento, Machine.Comentarios };

            // Añadimos la fila a la grilla
            this.dgvPreviewSelection.Rows.Add(row);
        }

        private void btnFiltrarSeleccion_Click(object sender, EventArgs e)
        {
            FilterInventorySelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
             * Añadimos manualmente un equipo seleccionado
             */

            /**
             * POR DEFECTO SE SELECCIONA EL INVENTARIO DE USUARIOS Y EQUIPOS
             * **/
            inventarios frm = new inventarios(this, InventoryClass.UsuariosYEquipos);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Si todo fue correcto...
                AddRowToGrid(frm.ActualMachine);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Creamos la actividad
            _Actividad.Nombre = this.txtNombreDeLaActividad.Text.Trim();
            _Actividad.InventarioSeleccionado = InventoryClass.UsuariosYEquipos;
            #region PARSEAMOS SOLO LOS SELECCIONADOS
            List<Inventario4ActViewModel> selectedMachines = new List<Inventario4ActViewModel>();

            int index = 0;
            foreach (DataGridViewRow row in this.dgvPreviewSelection.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value == true)
                {
                    if (index < _Actividad.ListaEquipos.Count)
                    {
                        selectedMachines.Add(_Actividad.ListaEquipos[index]);
                    }
                }

                index++;
            }
            #endregion
            _Actividad.ListaEquipos = selectedMachines;
            _Actividad.Descripcion = this.rtxtboxDescripcion.Text.Trim();
            _Actividad.PasosARealizar = $"{txtLinea1.Text.Trim()}\n{txtLinea2.Text.Trim()}\n{txtLinea3.Text.Trim()}\n{txtLinea4.Text.Trim()}\n{txtLinea5.Text.Trim()}\n{txtLinea6.Text.Trim()}";
            _Actividad.FechaInicio = dateFechaInicio.Value;
            _Actividad.FechaTermino = datePickerFechaVencimiento.Value;
            _Actividad.EquiposTotales = selectedMachines.Count;
            _Actividad.EquiposProgresados = 0;
            _Actividad.HASH = CommonMethodsLibrary.IdentifierGenerator();

            try
            {
                // Creamos el archivo de proyecto
                project = new ActProj(_Actividad, CommonMethodsLibrary.IdentifierGenerator());
                project.RootPath = this.txtRutaDeGuardado.Text;
                project.SaveProject();
                
                // Cargamos el formulario de visualizacion de actividad
                actividades_mdi_form frm = new actividades_mdi_form(BaseForm, project.RootPath);
                frm.TopLevel = false;
                BaseForm.MDI_ACT_Panel.Controls.Add(frm);
                //frm.Show();
                //frm.BringToFront();

                BaseForm.ActualActividadOnTop = frm;

                // Cerramos este formulario
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error inesperado! El programa dice: {ex.Message}\n{ex}");
            }
        }

        private void dgvPreviewSelection_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int COL_EMAIL = 6;
            int COL_HOSTNAME = 7;

            if (e.ColumnIndex == COL_EMAIL && e.RowIndex != -1)
            {
                DataGridViewCell cell = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell linkCell)
                {
                    // Obtener el valor del enlace
                    string email = linkCell.Value?.ToString();

                    /* 
                     * Por hacer - ACCIONES CON EL EMAIL
                     * */
                    Uri mailtoUri = new Uri($"mailto:{email}");

                    // Abrir el cliente de correo predeterminado del usuario
                    Process.Start(mailtoUri.ToString());
                }
            }
            else if (e.ColumnIndex == COL_HOSTNAME && e.RowIndex != -1)
            {
                DataGridViewCell cell = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell linkCell)
                {
                    // Obtener el valor del enlace
                    string hostname = linkCell.Value?.ToString();

                    /* 
                     * Por hacer
                     * */
                }
            }
        }

        string actualDirSelected = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void btnExaminarPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialogEx1.ShowDialog() == DialogResult.OK)
                {
                    actualDirSelected = folderBrowserDialogEx1.SelectedPath;
                    this.txtRutaDeGuardado.Text = $@"{actualDirSelected}\{this.txtNombreDeLaActividad.Text}{ActProj._FileExtension}";
                    project.RootPath = this.txtRutaDeGuardado.Text.Trim();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNombreDeLaActividad_TextChanged(object sender, EventArgs e)
        {
            this.txtRutaDeGuardado.Text = $@"{actualDirSelected}\{this.txtNombreDeLaActividad.Text}{ActProj._FileExtension}";
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
    }
}
