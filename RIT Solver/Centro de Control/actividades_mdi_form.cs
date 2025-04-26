using CustomMessageBox;
using FileProjectManager;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Crypto.IO;
using RIT_Solver.Centro_de_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RIT_Solver
{
    public partial class actividades_mdi_form : Form
    {
        public ActProj ActualProject;
        private main BaseForm;

        /// <summary>
        /// Abrimos un archivo de proyecto de actividad desde una ubicacion path indicada
        /// </summary>
        /// <param name="LegacyForm"></param>
        /// <param name="Path">Path del proyecto</param>
        public actividades_mdi_form(main LegacyForm, string Path)
        {
            InitializeComponent();
            BaseForm = LegacyForm;

            try
            {
                // Construimos el objeto
                (bool status, ActProj _proj) = ActProj.Decompress(Path);

                ActualProject = _proj;

                if (status)
                {
                    // Cargamos todos los valores del proyecto en la visualizacion
                    foreach (Inventario4ActViewModel i in ActualProject._Actividad.ListaEquipos)
                    {
                        AddRowToGrid(i);
                    }

                    // Cargamos el nombre en la barra de proyectos
                    this.Text = $"{ActualProject._Actividad.Nombre} - {ActualProject.RootPath}";

                    // Cargamos los datos en el MDI
                    // Añadimos el elemento al TreeNode segun sea el caso requerido
                    TreeNode node = new TreeNode();
                    node.Text = ActualProject._Actividad.Nombre;
                    node.Tag = ActualProject._Actividad.HASH;
                    node.ToolTipText = ActualProject.RootPath;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;

                    BaseForm.treeViewCentroDeControl.Nodes[0].Nodes.Add(node);
                    BaseForm.treeViewCentroDeControl.ExpandAll();

                    selectedMachine = ActualProject._Actividad.ListaEquipos[0];
                    WriteStatus("Listo!", true);
                } else
                {
                    MessageBox.Show($"No se puede abrir el proyecto debido a un error interno en el archivo! pruebe abrir el archivo en modo de reparacion e intente mas tarde.", "Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de abrir el arhcivo! El programa dice: {ex.Message}", $"{ProductName} - Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteStatus(string message, bool status)
        {
            this.lblJobStatus.Text = message;

            if (status)
            {
                this.lblJobStatus.ForeColor = Color.Green;
            } else
            {
                this.lblJobStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Añade los objetos al DGV
        /// </summary>
        /// <param name="Machine"></param>
        private void AddRowToGrid(Inventario4ActViewModel Machine)
        {
            object[] row = {
                Machine.IsMachineReady,
                Machine.Id,
                Machine.NOMBRE,
                Machine.NumDeEmpleado,
                Machine.EXT,
                Machine.USER,
                Machine.MAIL,
                Machine.HOSTNAME,
                Machine.TipoDeEquipo,
                Machine.SN,
                Machine.Marca,
                Machine.Modelo,
                Machine.Ubicacion,
                Machine.Departamento,
                Machine.Comentarios,
                Machine.TicketID,
                Machine.PDFRitName,
                Machine.EvidenciaName,
                Machine.Notas,
                Machine.HASH
            };

            //MessageBox.Show(Machine.HASH.ToString());

            this.dgvPreviewSelection.Rows.Add(row);
            WriteStatus($"Equipo < {Machine.Modelo} {Machine.SN} > añadido con exito!", true);
        }

        /// <summary>
        /// Añade una nueva maquina al objeto del proyecto y al DGV
        /// </summary>
        /// <param name="Machine"></param>
        private void AddNewMachine(Inventario4ActViewModel Machine)
        {
            int lastNumber = this.dgvPreviewSelection.RowCount + 1;
            object[] row = {
                Machine.IsMachineReady,
                lastNumber,
                Machine.NOMBRE,
                Machine.NumDeEmpleado,
                Machine.EXT,
                Machine.USER,
                Machine.MAIL,
                Machine.HOSTNAME,
                Machine.TipoDeEquipo,
                Machine.SN,
                Machine.Marca,
                Machine.Modelo,
                Machine.Ubicacion,
                Machine.Departamento,
                Machine.Comentarios,
                Machine.TicketID,
                Machine.PDFRitName,
                Machine.EvidenciaName,
                Machine.Notas,
                Machine.HASH
            };

            // Buscamos que no tengas en existencia el equipo en la actividad
            int coinc = 0;
            foreach (Inventario4ActViewModel i in ActualProject._Actividad.ListaEquipos)
            {
                if (i.HOSTNAME.Trim().ToLower() == row[7].ToString().ToLower().Trim() && i.NOMBRE.Trim().ToLower() == row[2].ToString().ToLower().Trim() && i.Modelo.Trim().ToLower() == row[11].ToString().ToLower().Trim() && i.Marca.Trim().ToLower() == row[10].ToString().ToLower().Trim() && i.SN.Trim().ToLower() == row[9].ToString().ToLower().Trim())
                {
                    coinc++;
                    break;
                }
            }

            bool canAdd = false;
            if (coinc == 0)
            {
                canAdd = true;
            }

            if (canAdd)
            {
                ActualProject._Actividad.ListaEquipos.Add(Machine);
                this.dgvPreviewSelection.Rows.Add(row);
                WriteStatus($"Equipo < {Machine.Modelo} {Machine.SN} > añadido con exito!", true);
            }
            else
            {
                WriteStatus("No se añadio el equipo debido a que ya se encuentra añadido!", false);
            }
        }

        /// <summary>
        /// Actualizamos el grafico de avances de la actividad
        /// </summary>
        private void UpdateAvancesChart()
        {
            this.chartAvances.Series["SerieAvances"].Points.Clear();

            #region CONFIGURACION DEL GRAFICO PASTEL
            // Configurar el tipo de gráfico como pastel
            chartAvances.Series["SerieAvances"].ChartType = SeriesChartType.Pie;

            // Opcional: configurar leyenda y título
            chartAvances.Titles.Add("Progreso de la Actividad");
            #endregion

            string[] categorias = { "Completados", "Pendientes" };

            // obtenemos los valores de las categorias
            double TOTAL_COMPLETADOS = 0;
            double TOTAL_PENDIENTES = 0;

            foreach (Inventario4ActViewModel machine in ActualProject._Actividad.ListaEquipos)
            {
                if (machine.IsMachineReady)
                {
                    TOTAL_COMPLETADOS++;
                }
            }
            TOTAL_PENDIENTES = ActualProject._Actividad.ListaEquipos.Count() - TOTAL_COMPLETADOS;

            double[] valores = { TOTAL_COMPLETADOS, TOTAL_PENDIENTES };

            // Agregar datos al gráfico
            for (int i = 0; i < categorias.Length; i++)
            {
                chartAvances.Series[0].Points.AddXY(categorias[i], valores[i]);
            }
        }

        private void actividades_mdi_form_Load(object sender, EventArgs e)
        {
            // Progreso de Actividad
            /* 
             * Se carga en la seccion del constructor
             * */
            /*
            Inventario4ActViewModel[] equiposCompletados = ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.IsMachineReady == true).ToArray();
            if (equiposCompletados.Count() == ActualProject._Actividad.ListaEquipos.Count())
            {
                this.generarInformeDeActividadToolStripMenuItem.Enabled = true;
                this.toolStripButton7.Enabled = true;
            } else
            {
                this.generarInformeDeActividadToolStripMenuItem.Enabled = false;
                this.toolStripButton7.Enabled = false;
            }
            */

            // Informacion
            UpdateAvancesChart();
            this.rtxtDescripcion.Text = ActualProject._Actividad.Descripcion;
            this.lblFechaDeInicio.Text = ActualProject._Actividad.FechaInicio.ToString("g");
            this.lblFechaDeTerminoPrevista.Text = ActualProject._Actividad.FechaTermino.ToString("g");

            // Plantilla de llenado de RIT
            this.txtCentroDeServicio.Text = ActualProject.PlantillaRIT.CentroServicios;
            this.txtCliente.Text = ActualProject.PlantillaRIT.Cliente;
            this.txtDireccion.Text = ActualProject.PlantillaRIT.Direccion;
            this.txtTecnico.Text = ActualProject.PlantillaRIT.Tecnico;

            this.txtFallaReportada.Text = ActualProject.PlantillaRIT.Falla;

            this.txtLinea1.Text = ActualProject.PlantillaRIT.AccionesRealizadas[0];
            this.txtLinea2.Text = ActualProject.PlantillaRIT.AccionesRealizadas[1];
            this.txtLinea3.Text = ActualProject.PlantillaRIT.AccionesRealizadas[2];
            this.txtLinea4.Text = ActualProject.PlantillaRIT.AccionesRealizadas[3];
            this.txtLinea5.Text = ActualProject.PlantillaRIT.AccionesRealizadas[4];
            this.txtLinea6.Text = ActualProject.PlantillaRIT.AccionesRealizadas[5];
            this.txtLinea7.Text = ActualProject.PlantillaRIT.AccionesRealizadas[6];
        }

        private void SaveActividad()
        {
            /* 
             * Guardamos el proyecto de actividad
             * */
            WriteStatus("Guardando actividad...", true);

            #region ACTUALIZAMOS LOS DATOS DE LA PLANTILLA DEL PROYECTO
            /*
             * TERMINAR DE IMPLEMENTAR PARA EL RESTO DE CAMPOS DEL FORMULARIO MDI
             */
            ActualProject.PlantillaRIT.Falla = this.txtFallaReportada.Text;

            ActualProject.PlantillaRIT.AccionesRealizadas[0] = this.txtLinea1.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[1] = this.txtLinea2.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[2] = this.txtLinea3.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[3] = this.txtLinea4.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[4] = this.txtLinea5.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[5] = this.txtLinea6.Text;
            ActualProject.PlantillaRIT.AccionesRealizadas[6] = this.txtLinea7.Text;
            #endregion

            ActualProject.SaveProject();    // Guardamos el archivo
            BaseForm.toolLblActualMDIActividadName.Text = this.Text;
            WriteStatus($"Actividad < {ActualProject.RootPath} > guardada con exito!", true);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Inventario4ActViewModel selectedMachine = new Inventario4ActViewModel();
        private void dgvPreviewSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            // detectamos el hash actual
            int hash = (int)this.dgvPreviewSelection.Rows[e.RowIndex].Cells[18].Value;
            
            // establecemos el equipo actualmente seleccionado segun la lista
            selectedMachine = ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.HASH == hash).FirstOrDefault();
            */
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveActividad();    // Guardamos la actividad en el path actualmente establecido en RootPath
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            /* 
             * Añadimos otro equipo a la actividad
             * */
            inventarios frm = new inventarios(this, InventoryClass.UsuariosYEquipos);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Inventario4ActViewModel machine = Inventario4ActViewModel.ParseFromBaseModel(frm.ActualMachine);
                machine.IsMachineReady = false;
                machine.TicketID = "";
                machine.PDFRitName = "";
                machine.EvidenciaName = "";
                machine.Notas = "";
                machine.HASH = CommonMethodsLibrary.IdentifierGenerator();

                AddNewMachine(machine);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(ActualProject.RootPath);

            this.saveFileDialog1.Title = "Guardar actividad como...";
            this.saveFileDialog1.FileName = fi.Name;
            this.saveFileDialog1.InitialDirectory = fi.DirectoryName;
            this.saveFileDialog1.Filter = "Proyecto de Actividad (*.actproj) |*.actproj";

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Actualizamos la ruta del proyecto
                    ActualProject.RootPath = saveFileDialog1.FileName;
                    // Guardamos el proyecto
                    ActualProject.SaveProject();
                    // Actualizamos el nombre
                    this.Text = $"{ActualProject._Actividad.Nombre} - {ActualProject.RootPath}";
                }
            } catch (Exception ex)
            {
                WriteStatus("Ha ocurrido un error inesperado a la hora de guardar el proyecto!", false);
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de guardar el proyecto! {ex.Message}", $"{Application.ProductName} - Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actividades_mdi_form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            /* 
             * Eliminamos el equipo seleccionado actualmente
             * */
            if (MessageBox.Show($"¿Seguro que deseas eliminar al equipo < {selectedMachine.TipoDeEquipo} {selectedMachine.Modelo} {selectedMachine.HOSTNAME} de {selectedMachine.NOMBRE} > de la actividad?", $"{Application.ProductName} - Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try
                {
                    int hash = selectedMachine.HASH;

                    // Eliminamos del listado de equipos del proyecto
                    Inventario4ActViewModel targetMachine = ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.HASH == hash).FirstOrDefault();
                    ActualProject._Actividad.ListaEquipos.Remove(targetMachine);

                    // Eliminamos de la grilla de visualizacion
                    DataGridViewRow targetRow = new DataGridViewRow();
                    foreach (DataGridViewRow row in this.dgvPreviewSelection.Rows)
                    {
                        if (Int32.Parse(row.Cells["HASH"].Value.ToString()) == hash)
                        {
                            targetRow = row;
                            break;
                        }
                    }

                    if (this.dgvPreviewSelection.Rows.Contains(targetRow))
                    {
                        this.dgvPreviewSelection.Rows.Remove(targetRow);
                    }

                    /* 
                     * TAMBIEN HAY QUE PENSAR SI ELIMINAMOS ARCHIVOS Y DATOS RELACIONADOS
                     * DEL PROYECTO A ESTE EQUIPO, POR EJEMPLO EN CASO DE CONTAR CON UN
                     * RIT DE ESE EQUIPO EN LA CARPETA "attachments" ELIMINARLO ASI COMO
                     * OTROS DATOS...
                     * */

                    WriteStatus($"Equipo <{selectedMachine.Modelo} {selectedMachine.HOSTNAME}> eliminado!", true);

                    // Seleccionamos una fila por defecto en el DataGridView
                    if (this.dgvPreviewSelection.Rows.Count > 0)
                    {
                        this.dgvPreviewSelection.Rows[0].Cells[0].Selected = true;
                    } else
                    {
                        selectedMachine = new Inventario4ActViewModel();
                    }
                } catch (Exception ex)
                {
                    WriteStatus($"Ha ocurrido un error inesperado a la hora de intentar eliminar el equipo {selectedMachine.HOSTNAME}!", false);
                    MessageBox.Show($"Ha ocurrido un error inesperado a la hora de eliminar el equipo {selectedMachine.HOSTNAME}! {ex.Message}", $"{Application.ProductName} - Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPreviewSelection_SelectionChanged(object sender, EventArgs e)
        {
            bool aStatus = false;
            bool bStatus = false;   // Indica si el equipo esta completado

            // detectamos el hash actual
            if (this.dgvPreviewSelection.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dgvPreviewSelection.SelectedRows[0];
                int hash = (int)selectedRow.Cells[19].Value;

                // establecemos el equipo actualmente seleccionado segun la lista
                selectedMachine = ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.HASH == hash).FirstOrDefault();

                this.lblTipoDeEquipo.Text = selectedMachine.TipoDeEquipo;
                this.lblModelo.Text = selectedMachine.Modelo;
                this.lblHostname.Text = selectedMachine.HOSTNAME;
                this.lblNombre.Text = selectedMachine.NOMBRE;

                aStatus = true;

                if (selectedMachine.IsMachineReady)
                {
                    bStatus = true;
                }
            }

            // MenuStrip Controls
            this.eliminarElEquipoSelecciondoToolStripMenuItem.Enabled = aStatus;
            this.editarEquipoSeleccionadoToolStripMenuItem.Enabled = aStatus;
            this.generarRITParaElEquipoSeleccionadoToolStripMenuItem.Enabled = aStatus;
            this.completarEquipoToolStripMenuItem.Enabled = !bStatus;
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.Enabled = bStatus;

            // ToolStrip Controls
            this.toolStrpBtn_Eliminar.Enabled = aStatus;
            this.toolStrpBtn_Modificar.Enabled = aStatus;
            this.toolStrpBtn_Completar.Enabled = !bStatus;
            this.toolStrpBtn_Desmarcar.Enabled = bStatus;

            // ContextMenuStrip Controls
            this.eliminarEquipoSeleccionadoToolStripMenuItem.Enabled = aStatus;
            this.editarEquipoSeleccionadoToolStripMenuItem1.Enabled = aStatus;
            this.marcarCompletadoElEquipoSeleccionadoToolStripMenuItem.Enabled = !bStatus;
            this.desmarcarEquipoComoCompletadoToolStripMenuItem.Enabled = bStatus;
            this.generarRITParaElEquipoToolStripMenuItem.Enabled = aStatus;
        }

        private void editarEquipoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Abrimos el formulario de edicion del equipo seleccionado
             * */
            Centro_de_Control.exEditarEquipoSeleccionado frm = new Centro_de_Control.exEditarEquipoSeleccionado(this, selectedMachine);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Cargamos los datos actualizados en el proyecto
                // asd
            }
        }

        private void completarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centro_de_Control.equipo_completado frm = new Centro_de_Control.equipo_completado(this, selectedMachine);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Cargamos los datos actualizados en el proyecto
                UpdateAvancesChart();

                Inventario4ActViewModel[] equiposCompletados = ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.IsMachineReady == true).ToArray();
                if (equiposCompletados.Count() == ActualProject._Actividad.ListaEquipos.Count())
                {
                    this.generarInformeDeActividadToolStripMenuItem.Enabled = true;
                }
                else
                {
                    this.generarInformeDeActividadToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void generarRITParaElEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generarRITParaElEquipoSeleccionadoToolStripMenuItem.PerformClick();
        }


        private void generarRITParaElEquipoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Generamos el rit del equipo seleccionado siempre y cuando no haya ya uno hecho
             * */

            // Fila actual
            DataGridViewRow actualRow = this.dgvPreviewSelection.CurrentRow;
            string PDFRitName = actualRow.Cells["PDFRitName"].Value.ToString();

            if (String.IsNullOrEmpty(PDFRitName) == true)
            {
                this.Cursor = Cursors.WaitCursor;
                bgworkerRitMakerProcess.RunWorkerAsync();
            } else
            {
                if (MessageBox.Show($"Ya hay un RIT cargado para este equipo (posiblemente firmado), ¿deseas crear otro?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    bgworkerRitMakerProcess.RunWorkerAsync();
                }
            }
        }

        string path_rit_destiny = "";
        private void AssignDate()
        {
            DateTime fechaActual = DateTime.Now;

            /* Establecemos los valores de la carpeta de trabajo del mes actual */
            string AÑO;
            string MES;
            string path;

            AÑO = fechaActual.Year.ToString();
            MES = fechaActual.ToString("MMMM");
            path = Properties.Settings.Default.RITFormPathDestiny + $@"\RITs\{AÑO}\{MES}\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path_rit_destiny = path;
        }

        private void bgworkerRitMakerProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            #region CODIGO DE GENERACION DEL ARCHIVO RIT PARA EL EQUIPO SELECCIONADO
            #region CODIGO PARA EL LLENADO DE LOS FORMULARIOS RIT PDF
            try
            {
                AssignDate();

                string NoDeReporte = selectedMachine.TicketID;
                decimal RitCounter = Properties.Settings.Default.RITCounter + 1;

                Properties.Settings.Default.NoDeReporte = NoDeReporte;

                string out_name;
                // Nombre de salida del archivo
                if (NoDeReporte == string.Empty)
                {
                    out_name = selectedMachine.NOMBRE + " - " + this.txtFallaReportada.Text;
                }
                else
                {
                    out_name = Properties.Settings.Default.NoDeReporte + " - " + selectedMachine.NOMBRE + " - " + this.txtFallaReportada.Text;
                }

                string pdfRITTemplate = Properties.Settings.Default.RITFormPath;
                string newFile = $@"{path_rit_destiny}\{out_name}.pdf";
                string PdfPath = newFile;    // Establecemos el PATH de salida del proyecto

                PdfReader pdfReader = new PdfReader(pdfRITTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));    // Documento de salida

                AcroFields pdfFormFilelds = pdfStamper.AcroFields;

                DateTime Hoy = DateTime.Now;

                // Se escribe la informacion del reporte
                pdfFormFilelds.SetField("Centro de Servicio", this.txtCentroDeServicio.Text);
                pdfFormFilelds.SetField("No Reporte del Cliente", NoDeReporte);
                pdfFormFilelds.SetField("ContadorDeFolio", RitCounter.ToString());
                pdfFormFilelds.SetField("DD1", Hoy.ToString("dd"));
                pdfFormFilelds.SetField("MM1", Hoy.ToString("MM"));
                pdfFormFilelds.SetField("YY1", Hoy.ToString("yyyy"));
                pdfFormFilelds.SetField("Hora de Reporte", Hoy.ToString("hh"));
                pdfFormFilelds.SetField("Min de Reporte", Hoy.ToString("mm"));
                pdfFormFilelds.SetField("Tipo de Equipo", selectedMachine.TipoDeEquipo);
                pdfFormFilelds.SetField("Marca", selectedMachine.Marca);
                pdfFormFilelds.SetField("Modelo", selectedMachine.Modelo);
                pdfFormFilelds.SetField("No de Serie", selectedMachine.SN);
                pdfFormFilelds.SetField("Cliente", this.txtCliente.Text);
                pdfFormFilelds.SetField("Sucursal", this.txtSucursal.Text);
                pdfFormFilelds.SetField("No Suc", "");
                pdfFormFilelds.SetField("Dirección", this.txtDireccion.Text);
                pdfFormFilelds.SetField("Población", this.txtPoblacion.Text);
                pdfFormFilelds.SetField("Usuario Final", selectedMachine.NOMBRE);
                pdfFormFilelds.SetField("Departamento", selectedMachine.Departamento);
                pdfFormFilelds.SetField("No de Empleado", selectedMachine.NumDeEmpleado);
                pdfFormFilelds.SetField("Tel", selectedMachine.EXT);
                pdfFormFilelds.SetField("Técnico", this.txtTecnico.Text);
                //pdfFormFilelds.SetField("Firma");
                pdfFormFilelds.SetField("Falla reportada", this.txtFallaReportada.Text);

                // Se marca reporte cerrado o pendiente
                if (rbtnReporteCerrado_Si.Checked)
                {
                    pdfFormFilelds.SetField("Cerrado Si", "X");
                }
                else if (rbtnReporteCerrado_No.Checked)
                {
                    pdfFormFilelds.SetField("Cerrado No", "X");
                }

                // Fecha de atencion del reporte
                pdfFormFilelds.SetField("DD2", Hoy.ToString("dd"));
                pdfFormFilelds.SetField("MM2", Hoy.ToString("MM"));
                pdfFormFilelds.SetField("YY2", Hoy.ToString("yyyy"));

                // Acciones tomadas para la resolucion del reporte
                pdfFormFilelds.SetField("ACT_LINEA1", this.txtLinea1.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA2", this.txtLinea2.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA3", this.txtLinea3.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA4", this.txtLinea4.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA5", this.txtLinea5.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA6", this.txtLinea6.Text.Trim());
                pdfFormFilelds.SetField("ACT_LINEA7", this.txtLinea7.Text.Trim());

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

                WriteStatus("Formato RIT guardado en PDF!", true);
            }
            catch (Exception ex)
            {
                WriteStatus($"{ex.Message}", false);
            }
            #endregion
            #endregion
        }

        /*
         * MEJORAR Y REPARAR ESTO PARA PODER IMPLEMENTARLO EN EL CONTEO DE REPORTES
         * 
        public void UpdateMensualStatics(string noFolio, DateTime fechaDeServicio)
        {
            MensualStadistics.ReportStData data = new MensualStadistics.ReportStData()
            {
                FallaReportada = this.txtFallaReportada.Text,
                NoDeFolio = noFolio,
                NoDeReporte = "",
                IsPrinted = true,
                IsGenerated = false,
                IsSigned = false,
                IsProved = false,
                //HASH = ActualProject.HASH
            };
            int a_year = Int32.Parse(fechaDeServicio.ToString("yyyy"));
            string a_month = fechaDeServicio.ToString("MMMM");
            MensualStadistics.UpdateMonthData(a_year, a_month, ActualProject.HASH, data);
        }
        */

        private void bgworkerRitMakerProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string out_name;
            this.Cursor = Cursors.Default;

            if (selectedMachine.TicketID == string.Empty)
            {
                out_name = selectedMachine.NOMBRE + " - " + this.txtFallaReportada.Text;
            }
            else
            {
                out_name = Properties.Settings.Default.NoDeReporte + " - " + selectedMachine.NOMBRE + " - " + this.txtFallaReportada.Text;
            }

            string newFile = path_rit_destiny + $@"{out_name}.pdf";
            string Filepath = newFile;

            PrinterForm frm = new PrinterForm(Filepath, "actividades_mdi_form", this);
            frm.ShowDialog();
        }

        private void dgvPreviewSelection_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda modificada es un checkbox
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvPreviewSelection.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtener el valor actual del checkbox
                bool isChecked = (bool)dgvPreviewSelection[e.ColumnIndex, e.RowIndex].Value;

                // Aquí puedes realizar cualquier acción que desees cuando el estado del checkbox cambie
                if (isChecked)
                {
                    // El checkbox está marcado
                    // Realizar alguna acción
                }
                else
                {
                    // El checkbox está desmarcado
                    // Realizar alguna acción
                }
            }
        }

        private void dgvPreviewSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic ocurrió en una celda de tipo LinkLabel
            DataGridViewColumn columna = this.dgvPreviewSelection.Columns[e.ColumnIndex];

            if (columna is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda
                if (columna.Name == "Mail")
                {
                    string email = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    Uri mailtoUri = new Uri($"mailto:{email}");

                    // Abrir el cliente de correo predeterminado del usuario
                    Process.Start(mailtoUri.ToString());
                }
                else if (columna.Name == "Hostname")
                {
                    /* 
                     * Abrimos en consola de EndPoint central el perfil del equipo
                     * */
                }
                else if (columna.Name == "PDFRitName")
                {
                    /* 
                     * Abrimos el PDF seleccionado
                     * */
                    string pdfNombre = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    if (MessageBox.Show($"¿Deseas abrir el archivo '{pdfNombre}' de los recursos del proyecto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DirectoryInfo di = new DirectoryInfo(ActualProject.RootPath);
                        string projDirName = di.Name.Replace(ActProj._FileExtension, "");

                        string TARGET_DIR_PATH = $@"{Application.StartupPath}\Temp\_${projDirName}";

                        if (Directory.Exists($@"{TARGET_DIR_PATH}\attachments\"))
                        {
                            string TARGET_FILE_PATH = $@"{TARGET_DIR_PATH}\attachments\{pdfNombre}";

                            if (File.Exists(TARGET_FILE_PATH))
                            {
                                pdf_viewer frm = new pdf_viewer("actividades_mdi_form", TARGET_FILE_PATH);
                                frm.ShowDialog();
                            } else
                            {
                                MessageBox.Show("El archivo no existe en la ubicacion indicada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (columna.Name == "TicketID")
                {
                    /*
                     * Accedemos al ticket desde manageengine usando la API de su URL
                     */
                    string _ticketID = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    string url = $@"https://gmxtsas.mx:8080/WorkOrder.do?woMode=viewWO&woID={_ticketID}";
                    externalCefSharp_WebViewer frm = new externalCefSharp_WebViewer($"Reporte en ServiceDesk - Visualizacion de ##{_ticketID}##", url);
                    frm.Show();
                }
                else if (columna.Name == "Evidencia")
                {
                    /*
                     * Abrimos el archivo de evidencia
                     */
                    string _evidencia = this.dgvPreviewSelection.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    if (MessageBox.Show($"¿Deseas abrir el archivo '{_evidencia}' de los recursos del proyecto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DirectoryInfo di = new DirectoryInfo(ActualProject.RootPath);
                        string projDirName = di.Name.Replace(ActProj._FileExtension, "");

                        string TARGET_DIR_PATH = $@"{Application.StartupPath}\Temp\_${projDirName}";

                        if (Directory.Exists($@"{TARGET_DIR_PATH}\attachments\"))
                        {
                            string TARGET_FILE_PATH = $@"{TARGET_DIR_PATH}\attachments\{_evidencia}";

                            if (File.Exists(TARGET_FILE_PATH))
                            {
                                // To Do..
                            } else
                            {
                                MessageBox.Show("El archivo no existe en la ubicacion indicada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void actividades_mdi_form_FormClosing(object sender, FormClosingEventArgs e)
        {

            switch (MessageBox.Show("¿Seguro que deseas salir antes de guardar?\nPresiona Si para guardar y salir", $"{Application.ProductName} - Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    // Guardamos y cerramos
                    e.Cancel = false;
                    SaveActividad();
                    ClosingProcedureMethod();
                    break;
                case DialogResult.No:
                    // Cerramos sin guardar
                    e.Cancel = false;
                    ClosingProcedureMethod();
                    break;
                case DialogResult.Cancel:
                    // Cancelamos el cierre del formulario
                    e.Cancel = true;
                    break;
                default:
                    // Por defecto cancelamos la operacion de cierre
                    e.Cancel = true;
                    break;
            }
        }

        /// <summary>
        /// Metodos de los procedimientos de cierre a efectuar
        /// </summary>
        void ClosingProcedureMethod()
        {
            // Eliminamos la carpeta temporal del proyecto
            if (!String.IsNullOrEmpty(ActualProject.TemporalRootPath) && Directory.Exists(ActualProject.TemporalRootPath))
            {
                Directory.Delete(ActualProject.TemporalRootPath, true);
                CommonMethodsLibrary.OutMessage("OUT", $"{this.Name}.cs", $"Carpeta temporal '{ActualProject.TemporalRootPath}' del proyecto '{ActualProject._Actividad.Nombre}' eliminada con exito!", "INF");
            }

            // Eliminamos el nodo del TreeView
            TreeNode node = BaseForm.treeViewCentroDeControl.Nodes[0].Nodes.Cast<TreeNode>().Where(i => Int32.Parse(i.Tag.ToString()) == ActualProject._Actividad.HASH).FirstOrDefault();
            BaseForm.treeViewCentroDeControl.Nodes[0].Nodes.Remove(node);
        }

        private void generarInformeDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Generamos un informe de resultados una vez que se ha terminado la actividad
             * */
            try
            {
                saveFileDialog1.Title = "Selecciona el lugar a guardar el archivo";
                saveFileDialog1.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog1.FileName = $"Informe de Resultados de Actividad {ActualProject._Actividad.Nombre}";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    WriteStatus("Guardando PDF...", true);
                    InformesActividades.GenerateResultReport(this.dgvPreviewSelection, ActualProject._Actividad, saveFileDialog1.FileName);

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        pdf_viewer frm = new pdf_viewer("actividades_mdi_form", saveFileDialog1.FileName);
                        frm.ShowDialog();
                    }

                    WriteStatus($"PDF guardado con exito! < {saveFileDialog1.FileName} >", true);
                }
            }
            catch (Exception ex)
            {
                WriteStatus($"Ha ocurrido un error inesperado! {ex.Message}", false);
            }
        }

        private void enviarCorreoDeAvancesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Selecciona el lugar a guardar el archivo";
                saveFileDialog1.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog1.FileName = $"Resumen de Actividad {ActualProject._Actividad.Nombre}";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    WriteStatus("Guardando PDF...", true);
                    InformesActividades.GeneratePdfReport(this.dgvPreviewSelection, ActualProject._Actividad, saveFileDialog1.FileName);

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        pdf_viewer frm = new pdf_viewer("actividades_mdi_form", saveFileDialog1.FileName);
                        frm.ShowDialog();
                    }

                    WriteStatus($"PDF guardado con exito! < {saveFileDialog1.FileName} >", true);
                }
            }
            catch (Exception ex)
            {
                WriteStatus($"Ha ocurrido un error inesperado! {ex.Message}", false);
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * Generamos excel de la actividad
             * */

            try
            {
                saveFileDialog1.Title = "Selecciona el lugar a guardar el archivo";
                saveFileDialog1.Filter = "Hoja de calcula de Microsoft Excel (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = $"Resumen de Actividad {ActualProject._Actividad.Nombre}";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    WriteStatus("Guardando Excel...", true);
                    InformesActividades.GenerateExcelReport(this.dgvPreviewSelection, ActualProject._Actividad, saveFileDialog1.FileName);

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        Process.Start(saveFileDialog1.FileName);
                    }

                    WriteStatus($"Excel guardado con exito! < {saveFileDialog1.FileName} >", true);
                }
            }
            catch (Exception ex)
            {
                WriteStatus($"Ha ocurrido un error inesperado! {ex.Message}", false);
            }
        }

        private void rtxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            this.ActualProject._Actividad.Descripcion = rtxtDescripcion.Text.Trim();
        }

        private void generarLoteDeImpresionDeRITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * GENERAMOS UN LOTE DE IMPRESION DE TODOS LOS EQUIPOS EN LA LISTA
             * */

        }

        private void desmarcarEquipoComoCompletadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
             * DESMARCAMOS EL EQUIPO COMO COMPLETADO
             * */
            if (MessageBox.Show($"¿Estas seguro que deseas desmarcar como completado el equipo < {selectedMachine.TipoDeEquipo} {selectedMachine.Modelo} {selectedMachine.HOSTNAME} de {selectedMachine.NOMBRE} > de la actividad?", $"{Application.ProductName} - Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Actualizamos en el listado de los equipos del objeto del proyecto
                Inventario4ActViewModel targetObject = this.ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.HASH == selectedMachine.HASH).FirstOrDefault();
                int targetIndex = this.ActualProject._Actividad.ListaEquipos.IndexOf(targetObject);

                Inventario4ActViewModel newObject = targetObject;
                newObject.IsMachineReady = false;   // Desmarcamos la palomita
                newObject.TicketID = "";            // Eliminamos el numero de reporte 
                newObject.PDFRitName = "";          // Eliminamos el nombre del archivo PDF 
                newObject.PDFRitContent = null;     // Eliminamos el contenido del archivo PDF 
                newObject.EvidenciaName = "";       // Eliminamos el nombre del archivo de evidencia
                newObject.EvidenciaContent = null;  // Eliminamos el contenido del archivo de evidencia

                this.ActualProject._Actividad.ListaEquipos[targetIndex] = newObject;

                // Actualizamos la fila del DGV
                DataGridViewRow row = this.dgvPreviewSelection.Rows.Cast<DataGridViewRow>().Where(i => i.Cells[19].Value.ToString() == selectedMachine.HASH.ToString()).FirstOrDefault();
                string oldPdfName = row.Cells[16].Value.ToString();
                row.Cells[0].Value = newObject.IsMachineReady;
                row.Cells[15].Value = newObject.TicketID;   // Ticket ID
                row.Cells[16].Value = newObject.PDFRitName;   // RIT name
                row.Cells[17].Value = newObject.EvidenciaName;  // Nombre de la evidencia

                // Eliminamos el archivo RIT
                DirectoryInfo di = new DirectoryInfo(this.ActualProject.RootPath);
                string projDirName = di.Name.Replace(".actproj", "");

                string TARGET_DIR_PATH = $@"{Application.StartupPath}\Temp\_${projDirName}";

                if (Directory.Exists($@"{TARGET_DIR_PATH}\attachments\"))
                {
                    string TARGET_FILE_PATH = $@"{TARGET_DIR_PATH}\attachments\{oldPdfName}";

                    File.Delete(TARGET_FILE_PATH);
                }
            }
        }

        private void toolStrpBtn_Desmarcar_Click(object sender, EventArgs e)
        {
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.PerformClick();
        }

        private void desmarcarEquipoComoCompletadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.desmarcarEquipoComoCompletadoToolStripMenuItem1.PerformClick();
        }

        private void dgvPreviewSelection_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Obtener la ubicación de la celda que fue clicada
                var hitTestInfo = dgvPreviewSelection.HitTest(e.X, e.Y);

                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    // Seleccionar la celda correspondiente
                    dgvPreviewSelection.CurrentCell = dgvPreviewSelection[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex];
                    dgvPreviewSelection.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex].Selected = true;

                    // Mostrar el ContextMenuStrip
                    contextMenuStrip1.Show(dgvPreviewSelection, new Point(e.X, e.Y));
                }
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            this.cerrarToolStripMenuItem.PerformClick();
        }

        private void EliminarFilasDuplicadas(DataGridView dataGridView)
        {
            HashSet<string> hashSet = new HashSet<string>();
            List<int> filasParaEliminar = new List<int>();
            List<int> HASHES_TO_DELETE = new List<int>();

            this.Cursor = Cursors.WaitCursor;

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                List<string> valoresFila = new List<string>();

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    if (i == 0 || i == 1 || i == 15 || i == 16 || i == 17 || i == 18)
                        continue;

                    valoresFila.Add(fila.Cells[i].Value?.ToString() ?? string.Empty);
                }

                string claveFila = string.Join("|", valoresFila);

                if (hashSet.Contains(claveFila))
                {
                    filasParaEliminar.Add(fila.Index);
                    HASHES_TO_DELETE.Add(Int32.Parse(fila.Cells[18].Value.ToString()));
                }
                else
                {
                    hashSet.Add(claveFila);
                }
            }

            // Eliminar filas duplicadas
            foreach (int index in filasParaEliminar.OrderByDescending(i => i))
            {
                dataGridView.Rows.RemoveAt(index);
            }

            // Actualizamos los valores de los equipos en la lista del proyecto
            #region CODIGO
            foreach (int hash in HASHES_TO_DELETE)
            {
                foreach (Inventario4ActViewModel machine in ActualProject._Actividad.ListaEquipos)
                {
                    if (machine.HASH == hash)
                    {
                        ActualProject._Actividad.ListaEquipos.Remove(machine);
                        break;
                    }
                }
            }
            #endregion

            this.Cursor = Cursors.Default;
        }

        private void eliminarDuplicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
             * ELIMINAMOS LOS ELEMENTOS DUPLICADOS
             * */
            EliminarFilasDuplicadas(dgvPreviewSelection);
        }
    }
}
