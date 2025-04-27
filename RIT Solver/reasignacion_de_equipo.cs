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
using SpreadsheetLight;

namespace Flow_Solver
{
    public partial class reasignacion_de_equipo : Form
    {
        internal inventarios padre;

        #region VARIABLES PUBLICAS Y GLOBALES
        // Variables del usuario
        public string Nombre { get; set; }
        public string NumDeEmp { get; set; }
        public string Ext { get; set; }
        public string UsuarioRed { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        #endregion

        string previousHostname = "";

        /// <summary>
        /// Sobrecarga de constructor para invocar el Form de Reasignacion de equipo.
        /// </summary>
        /// <param name="LegacyForm">Formulario Heredado.</param>
        /// <param name="Hostname">Hostname del equipo a reasignar.</param>
        /// <param name="TipoDeEquipo">Tipo de equipo a reasignar.</param>
        /// <param name="SN">Numero de Serie del equipo a reasignar.</param>
        /// <param name="Marca">Marca del equipo a reasignar.</param>
        /// <param name="Modelo">Modelo del equipo a reasignar.</param>
        /// <param name="Ubicacion">Ubicacion del equipo a reasignar.</param>
        /// <param name="Comentarios">Comentarios extra del equipo a reasignar.</param>
        /// <param name="NombreUsuario">Nombre del usuario anterior.</param>
        /// <param name="NumDeEmpleado">Numero de empleado del usuario anterior.</param>
        /// <param name="Ext">Extension telefonica del usuario anterior.</param>
        /// <param name="UsuarioRed">Usuario de red del usuario anterior.</param>
        /// <param name="Correo">Correo electronico del usuario anterior.</param>
        /// <param name="Departamento">Departamento del usuario anterior.</param>
        public reasignacion_de_equipo(inventarios LegacyForm, string Hostname, string TipoDeEquipo, string SN, string Marca, string Modelo, string Ubicacion, string Comentarios, string NombreUsuario, string NumDeEmpleado, string Ext, string UsuarioRed, string Correo, string Departamento)
        {
            InitializeComponent();

            /** Cargamos los datos del equipo **/
            this.lblHostname.Text = Hostname;
            this.lblTipoDeEquipo.Text = TipoDeEquipo;
            this.lblSerialNumber.Text = SN;
            this.lblMarca.Text = Marca;
            this.lblModelo.Text = Modelo;
            this.lblUbicacion.Text = Ubicacion;
            this.lblComentarios.Text = Comentarios;

            /** Cargamos los datos del usuario anterior **/
            this.lblUsuario.Text = NombreUsuario;
            this.lblNumDeEmpleado.Text = NumDeEmpleado;
            this.lblExtension.Text = Ext;
            this.lblUsuarioDeRed.Text = UsuarioRed;
            this.lblCorreo.Text = Correo;
            this.lblDepartamento.Text = Departamento;

            /** Borramos los datos inciales del nuevo usuario **/
            /*
            this.lblNuevoUsuario.Text = string.Empty;
            this.lblNuevoNumDeEmpleado.Text = string.Empty;
            this.lblNuevoExt.Text = string.Empty;
            this.lblNuevoUsuarioRed.Text = string.Empty;
            this.lblNuevoCorreo.Text = string.Empty;
            this.lblNuevoDepartamento.Text = string.Empty;
            */

            padre = LegacyForm;
        }

        private void btnEscogerUsuario_Click(object sender, EventArgs e)
        {
            lista_usuarios frm = new lista_usuarios(this);
            frm.ShowDialog();
        }

        private void btnReasignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RJMessageBox.Show("¿Seguro que desear realizar la reasignacion de este equipo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Añadimos tarea de reasignacion en el inventario
                    string file_path = $@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx";

                    if (File.Exists(file_path))
                    {
                        SLDocument sl = new SLDocument(file_path);
                        try
                        {
                            var grilla = padre.dataGridView1;

                            /* PRIMERO VALIDAMOS LA EXISTENCIA DEL EQUIPO POR HOSTNAME Y SERIE */
                            List<InventarioViewModel> ulst = new List<InventarioViewModel>();

                            // Añadimos los ya existentes
                            #region GRABAMOS LOS DATOS DE NUEVOS DE GRILLA ACTUAL
                            int iRow = 2;

                            int ciclo = 0;
                            // Carga los datos ya existentes
                            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                            {
                                // Numero de Serie de la fila actual
                                string SERIALNUMBER = sl.GetCellValueAsString(iRow, 8);

                                if (this.lblSerialNumber.Text != SERIALNUMBER)
                                {
                                    //MessageBox.Show($"Usuario actual leyendo: {sl.GetCellValueAsString(iRow, 1)} {Environment.NewLine + Environment.NewLine}SN a Omitir: {this.lblSerialNumber.Text}{Environment.NewLine}SN Actual: {SERIALNUMBER}");
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

                                    /*
                                    if (MessageBox.Show($"Ciclo: {ciclo++} / Fila: {iRow-1} {Environment.NewLine + Environment.NewLine} {sl.GetCellValueAsString(iRow, 1)} / {sl.GetCellValueAsString(iRow, 6)} / {sl.GetCellValueAsString(iRow, 7)}", this.Name, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                                    {
                                        break;
                                    }*/

                                    iRow++;
                                } else
                                {
                                    // Omitimos el equipo a reasignar y añadimos el nuevo
                                    //MessageBox.Show($"Se omitira este equipo porque es el buscado! {Environment.NewLine + Environment.NewLine}{sl.GetCellValueAsString(iRow, 1)} / {sl.GetCellValueAsString(iRow, 6)} / {sl.GetCellValueAsString(iRow, 7)}");
                                    
                                    //iRow++;
                                    InventarioViewModel nuevoEquipo = new InventarioViewModel();
                                    nuevoEquipo.NOMBRE = Nombre;
                                    nuevoEquipo.NumDeEmpleado = NumDeEmp;
                                    nuevoEquipo.EXT = Ext;
                                    nuevoEquipo.USER = UsuarioRed;
                                    nuevoEquipo.MAIL = Correo;
                                    nuevoEquipo.HOSTNAME = this.lblHostname.Text;
                                    nuevoEquipo.TipoDeEquipo = this.lblTipoDeEquipo.Text;
                                    nuevoEquipo.SN = this.lblSerialNumber.Text;
                                    nuevoEquipo.Marca = this.lblMarca.Text;
                                    nuevoEquipo.Modelo = this.lblModelo.Text;
                                    nuevoEquipo.Ubicacion = this.lblUbicacion.Text;
                                    nuevoEquipo.Departamento = Departamento;
                                    nuevoEquipo.Comentarios = this.lblComentarios.Text;

                                    ulst.Add(nuevoEquipo); // Añadimos el equipo al Array

                                    iRow++;
                                }
                            }
                            #endregion
                            
                            // Actualizamos la grilla del formulario padre
                            grilla.DataSource = ulst;


                            #region GUARDAMOS EL NUEVO EXCEL ACTUALIZADO SEGUN LA GRILLA
                            /*
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
                            */

                            padre.toolGuardarActual.PerformClick();
                            #endregion

                            //grilla.DataSource = ulst;

                            /* 
                             * Validamos carta de resguardo generada 
                             * */
                            // To Do...
                            
                            // Informamos a la grabadora de eventos
                            string jsonPath = $@"{Application.StartupPath}\Inventories\{lblHostname.Text}{MachineEventsHistorial.FileSuffix}";

                            if (File.Exists(jsonPath))
                            {
                                MachineEventsHistorial.UpdateRecorder(jsonPath, M_EventItem.FromTemplate_ReasignMachine(lblHostname.Text, lblUsuario.Text, lblNuevoUsuario.Text));
                            }

                            RJMessageBox.Show("Reasignacion del equipo realizada con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message} {Environment.NewLine + Environment.NewLine} {ex.ToString()}", this.Text);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void reasignacion_de_equipo_Load(object sender, EventArgs e)
        {

        }
    }
}
