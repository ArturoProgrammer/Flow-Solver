using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomMessageBox;


namespace Flow_Solver
{
    public partial class project_selector_form : Form
    {
        List<string> ChildFormsList = new List<string>();
        ProjectSelectorSenders Constructor = ProjectSelectorSenders.NONE;

        public enum ProjectSelectorSenders
        {
            NONE,
            MAKE_TICKET,
            SOLVE_FORM_TICKET,
            REQUEST_SPARE_PARTS,
            SOLVE_SAS_TICKET,
        }

        internal main Padre_Main;                               // Llenados de Form
        internal solicitar_refaccion Padre_SolicitarRefaccion;  // Solicitudes de refacciones

        public project_selector_form(main LegacyForm, ProjectSelectorSenders Sender)
        {
            // Sobrecarga de inicializacion normal
            InitializeComponent();

            Padre_Main = LegacyForm;
            Constructor = Sender;
        }

        void _LoadRitsMethod()
        {
            this.cboxChildsForms.Items.Clear();
            this.cboxChildsForms.Text = "";

            // Cargamos todos los formularios MDI de proyectos activos
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "rit_mdi_form")
                {
                    if (this.chckboxSoloNoComprobados.Checked)
                    {
                        rit_mdi_form rit = (rit_mdi_form)form;

                        if (rit.IsRitAlreadyComprobado == false)
                        {
                            this.cboxChildsForms.Items.Add(form.Text);
                        }
                    }
                    else
                    {
                        this.cboxChildsForms.Items.Add(form.Text);
                    }
                }
            }
        }

        private void project_selector_form_Load(object sender, EventArgs e)
        {
            _LoadRitsMethod();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerramos el form
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Constructor)
            {
                case ProjectSelectorSenders.NONE:
                    /*
                     * Ignoramos
                     */
                    break;
                case ProjectSelectorSenders.MAKE_TICKET:
                    #region SELECIONAMOS EL REPORTE PARA CREAR EL TICKET EN SAS
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "rit_mdi_form" & form.Text == this.cboxChildsForms.Text)
                        {
                            rit_mdi_form frm2 = (rit_mdi_form)form;

                            // Abrimos primero el Formulario de datos previos

                            SAS_Methods.MakeReportSAS(frm2);
                        }
                    }
                    #endregion
                    break;
                case ProjectSelectorSenders.SOLVE_FORM_TICKET:
                    #region SELECCIONAMOS REPORTE PARA LLENAR LA PAGINA DE FORMS
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "rit_mdi_form" & form.Text == this.cboxChildsForms.Text)
                        {
                            rit_mdi_form frm3 = (rit_mdi_form)form;
                            //MessageBox.Show($"DIA: {frm.dia_reporte:D2} \nMES: {frm.mes_reporte:D2} \nAÑO: {frm.año_reporte}");

                            Forms_Methods.FillCompusofForms(frm3.cboxUsuariofinal.Text, frm3.txtNoDeEmpleado.Text, frm3.txtNoDeReporteDelCliente.Text, frm3.txtTecnico.Text, frm3.cboxPoblacion.Text, $"{frm3.mes_reporte:D2}", $"{frm3.dia_reporte:D2}", frm3.año_reporte);
                            frm3.IsRitAlreadyComprobado = true;
                            frm3.linklblRitComprobado.Text = frm3.IsRitAlreadyComprobado.ToString();
                            frm3.UpdateNodeColorByProgress();

                            // Informamos a la grabadora de eventos
                            string targetPath = $@"{Application.StartupPath}\Inventories\{frm3.txtHostname.Text}{MachineEventsHistorial.FileSuffix}";
                            MachineEventsHistorial rec = new MachineEventsHistorial(targetPath);
                            rec.AddEvent(M_EventItem.FromTemplate_VerifiedReport(frm3.richTextBoxContadorDeRIT.Text, frm3.txtFallaReportada.Text, frm3.txtNoDeReporteDelCliente.Text));
                            rec.Save();
                        }
                    }
                    #endregion
                    break;
                case ProjectSelectorSenders.REQUEST_SPARE_PARTS:
                    #region SELECCIONAR REPORTE PARA SOLICITUD DE REFACCION
                    rit_mdi_form frm_mdi = new rit_mdi_form(Padre_Main);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "rit_mdi_form" & form.Text == this.cboxChildsForms.Text)
                        {
                            frm_mdi = (rit_mdi_form)form;
                        }
                    }

                    solicitar_refaccion frm = new solicitar_refaccion(frm_mdi);
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
                        frm.txtNoDeReporte.Text = frm_mdi.txtNoDeReporteDelCliente.Text;
                        frm.txtProyecto.Text = Properties.Settings.Default.ProyectoIDC;
                        frm.txtLocalidad.Text = frm_mdi.cboxPoblacion.Text;
                        frm.txtNombreDeUsuario.Text = frm_mdi.cboxUsuariofinal.Text;
                        frm.txtDepartamento.Text = frm_mdi.txtDepartamento.Text;
                        frm.txtTelefono.Text = frm_mdi.txtTelefono.Text;
                        frm.txtMarca.Text = frm_mdi.txtMarca.Text;
                        frm.txtModelo.Text = frm_mdi.txtModelo.Text;
                        frm.txtSolicitante.Text = frm_mdi.txtTecnico.Text;
                        frm.txtDescripcion.Text = frm_mdi.txtRefaccionesUtilizadas.Text;

                        // Abrimos la instancia para enviar correo
                        frm.Show();
                    }
                    #endregion
                    break;
                case ProjectSelectorSenders.SOLVE_SAS_TICKET:
                    #region SELECCIONAMOS REPORTE PARA PONER LA RESOLUCION DEL REPORTE EN SAS
                    
                    #endregion
                    break;
            }

            // Cerramos despues de hacer la accion seleccionada
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chckboxSoloNoComprobados_CheckedChanged(object sender, EventArgs e)
        {
            _LoadRitsMethod();
        }
    }
}
