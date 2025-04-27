using FileProjectManager;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver.Centro_de_Control
{
    public partial class equipo_completado : Form
    {
        private Inventario4ActViewModel actualSelected;
        private actividades_mdi_form BaseForm;

        public equipo_completado(actividades_mdi_form LegacyForm, Inventario4ActViewModel machine)
        {
            InitializeComponent();
            actualSelected = machine;
            BaseForm = LegacyForm;
        }

        private void equipo_completado_Load(object sender, EventArgs e)
        {
            this.chckboxEquipoCompletado.Checked = true;

            this.msktxtNoTicket.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            /* 
             * Realizamos las modificaciones pertinentes
             * */
            // Actualizamos en el listado de los equipos del objeto del proyecto
            Inventario4ActViewModel targetObject = BaseForm.ActualProject._Actividad.ListaEquipos.Cast<Inventario4ActViewModel>().Where(i => i.HASH == actualSelected.HASH).FirstOrDefault();
            int targetIndex = BaseForm.ActualProject._Actividad.ListaEquipos.IndexOf(targetObject);

            Inventario4ActViewModel newObject = targetObject;
            newObject.IsMachineReady = this.chckboxEquipoCompletado.Checked;
            newObject.TicketID = this.msktxtNoTicket.Text;
            if (File.Exists(this.txtRITPath.Text))
            {
                FileInfo fi = new FileInfo(this.txtRITPath.Text);

                newObject.PDFRitName = fi.Name;
                newObject.PDFRitContent = File.ReadAllBytes(txtRITPath.Text);
            }

            BaseForm.ActualProject._Actividad.ListaEquipos[targetIndex] = newObject;

            // Actualizamos la fila del DGV
            DataGridViewRow row = BaseForm.dgvPreviewSelection.Rows.Cast<DataGridViewRow>().Where(i => i.Cells[19].Value.ToString() == actualSelected.HASH.ToString()).FirstOrDefault();
            row.Cells[0].Value = newObject.IsMachineReady;
            row.Cells[15].Value = newObject.TicketID;   // Ticket ID
            row.Cells[16].Value = newObject.PDFRitName;   // RIT name

            DirectoryInfo di = new DirectoryInfo(BaseForm.ActualProject.RootPath);
            string projDirName = di.Name.Replace(ActProj._FileExtension, "");

            string TARGET_DIR_PATH = $@"{Application.StartupPath}\Temp\_${projDirName}";

            // Agregamos el archivo PDF del RIT al directorio temporal del proyecto
            if (Directory.Exists($@"{TARGET_DIR_PATH}\attachments\"))
            {
                string TARGET_PDF_FILE_PATH = $@"{TARGET_DIR_PATH}\attachments\{newObject.PDFRitName}";

                File.WriteAllBytes(TARGET_PDF_FILE_PATH, newObject.PDFRitContent);
            }

            // Agregamos el archivo de evidencia al directorio temporal del proyecto
            if (Directory.Exists($@"{TARGET_DIR_PATH}\attachments\"))
            {
                if (newObject.EvidenciaContent != null)

                {
                    string TARGET_EVIDENCIA_FILE_PATH = $@"{TARGET_DIR_PATH}\attachments\{newObject.EvidenciaContent}";

                    File.WriteAllBytes(TARGET_EVIDENCIA_FILE_PATH, newObject.EvidenciaContent);
                }
            }

            // Cerramos
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExaminarRIT_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Title = "Cargar RIT Seleccionado";
                openFileDialog1.Filter = "Archivos PDF (*.pdf) | *.pdf";
                openFileDialog1.Multiselect = false;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txtRITPath.Text = openFileDialog1.FileName;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminarEvidncia_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Title = "Cargar Archivo de Evidencia Seleccionada";
                openFileDialog1.Filter = "Archivos de Imagen (*.png, *.jpg, *.bmp) | *.png;*.jpg;*.bmp | Todos los Archivos (*.*) | *.*";
                openFileDialog1.Multiselect = false;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txtEvidenciaPath.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
