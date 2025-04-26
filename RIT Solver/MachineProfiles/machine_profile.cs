using FileProjectManager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver.MachineProfiles
{
    public partial class machine_profile : Form
    {
        MachineProfile actualMachine;
        private MachineEventsHistorial Historial;


        public machine_profile(MachineProfile _SelectedProfileMachine)
        {
            InitializeComponent();
            actualMachine = _SelectedProfileMachine;
            _LoadAllDataProfile();
        }

        private void machine_profile_Load(object sender, EventArgs e)
        {

        }

        void _LoadAllDataProfile ()
        {
            try
            {
                Historial = new MachineEventsHistorial(actualMachine.EventRecorderPath);

                _LoadUserProfile();         // Cargamos los datos del perfil del usuario
                _LoadTechnichalsDetails();  // Cargamos los Detalles Tecnicos
                _LoadAttendedReports();     // Cargamos los Reportes Atendidos
                _LoadHistorialEventos();    // Cargamos Historial de Eventos

                this.Text = $@"Perfil del Equipo - {actualMachine.EquipoPrincipal.HOSTNAME}";

                // Cargamos la imagen de perfil por defecto

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _LoadHistorialEventos()
        {
            this.lblTitulo.Text = "";
            this.rtxtMensaje.Text = "";
            this.lblHASH.Text = "";
            this.lblCreacion.Text = "";

            #region CARGAMOS LOS VALORES DE VISUALIZACION
            foreach (M_EventItem ev in Historial.Events)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ev.Title;
                item.ImageIndex = 0;
                item.StateImageIndex = 0;
                item.Tag = ev;
                item.Group = this.lviewHistorialDeEventos.Groups.Cast<ListViewGroup>().FirstOrDefault();

                this.lviewHistorialDeEventos.Items.Add(item);
            }
            #endregion
        }

        void _LoadAttendedReports()
        {
            this.bgworkerLoadReportes.RunWorkerAsync();
        }

        void _LoadTechnichalsDetails ()
        {
            // Buscamos en el listado de modelos vinculados un equipo con este mismo nombre de modelo
            if (actualMachine.ModeloVinculado != null)
            {
                // Cargamos los valores tecnicos requeridos
                if (!String.IsNullOrEmpty(actualMachine.ModeloVinculado.ProfileImagePath))
                {
                    this.pboxImageModel.BackgroundImage = new Bitmap($@"{Application.StartupPath}\Inventories\MachineProfiles\{actualMachine.ModeloVinculado.ProfileImagePath}");
                }
                this.lblProcesador.Text = $"{actualMachine.ModeloVinculado.Procesador} @ {actualMachine.ModeloVinculado.Frecuencia} GHz";
                this.lblMemoria.Text = $"{actualMachine.ModeloVinculado.RAM} GB";
                this.lblAlmacenamientoSSD.Text = $"{actualMachine.ModeloVinculado.AlmacenamientoSSD} GB";
                this.lblAlmacenamientoHDD.Text = $"{actualMachine.ModeloVinculado.AlmacenamientoHDD} GB";
            }
        }

        void _LoadUserProfile ()
        {
            this.lblNombreModelo.Text = actualMachine.EquipoPrincipal.Modelo;
            this.lblMarca.Text = actualMachine.EquipoPrincipal.Marca;
            this.lblFechaDeFabricacion.Text = actualMachine.EquipoPrincipal.FechaDeFabricacion != null ? actualMachine.EquipoPrincipal.FechaDeFabricacion.ToString("dd / MMMM / yyyy") : "-";
            this.lblFechaAsignacion.Text = actualMachine.EquipoPrincipal.FechaDeAsignacion != null ? actualMachine.EquipoPrincipal.FechaDeAsignacion.ToString("dd / MMMM / yyyy") : "-";

            this.linklblNombre.Text = actualMachine.UsuarioAsignado.Nombre;
            this.lblNoEmp.Text = actualMachine.UsuarioAsignado.NoEmpleado;
            this.lblExtension.Text = actualMachine.UsuarioAsignado.Extension;
            this.lblCorreo.Text = actualMachine.UsuarioAsignado.Email;
            this.lblLocalidad.Text = actualMachine.UsuarioAsignado.Localidad;
            this.lblUsuarioDeRed.Text = actualMachine.UsuarioAsignado.Red;
            this.lblDepartamento.Text = actualMachine.UsuarioAsignado.Departamento;
        }

        private void linklblNombre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* 
             * Abrimos la tarjeta del usuario correspondiente
             * */
            lista_usuarios frm = new lista_usuarios(this.linklblNombre.Text);
            frm.ShowDialog();
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Selecciona una imagen de perfil del modelo...";
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.Filter = "Archivos de Imagenes (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp| Todos los Archivos (*.*)|*.*";
                this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                this.openFileDialog1.Multiselect = false;
                this.openFileDialog1.RestoreDirectory = true;

                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    new MachineProfiles.MachineProfile();   // Inicializamos el constructor para que valide la existencia de los direcotios correspondientes
                    File.WriteAllBytes($@"{Application.StartupPath}\Inventories\MachineProfiles\{fi.Name}", File.ReadAllBytes(openFileDialog1.FileName));
                    this.pboxImageModel.BackgroundImage = new Bitmap($@"{Application.StartupPath}\Inventories\MachineProfiles\{fi.Name}");

                    /*
                     * FALTA AÑADIR QUE SE ACTUALICEN LOS DATOS EN EL REGISTRO DE MODELOS VINCULADOS
                     */
                    MachinesModelsSync syncModels = MachinesModelsSync.Load();
                    foreach (MachineModelSyncItem i in syncModels.Items)
                    {
                        if (i.NombreComercial == actualMachine.ModeloVinculado.NombreComercial)
                        {
                            i.ProfileImagePath = fi.Name;
                            break;
                        }
                    }
                    syncModels.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        M_EventItem actualEventSelected = null;
        private void lviewHistorialDeEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lviewHistorialDeEventos.SelectedItems.Count == 1)
                {
                    actualEventSelected = (M_EventItem)this.lviewHistorialDeEventos.SelectedItems[0].Tag;
                }

                if (actualEventSelected != null)
                {
                    // MOSTRAMOS LOS DATOS EN PANTALLA
                    this.lblTitulo.Text = actualEventSelected.Title;
                    this.rtxtMensaje.Text = actualEventSelected.Message;
                    this.lblHASH.Text = actualEventSelected.HASH.ToString();
                    this.lblCreacion.Text = actualEventSelected.CreationDate.ToString("f");
                }
                else
                {
                    this.lblTitulo.Text = "";
                    this.rtxtMensaje.Text = "";
                    this.lblHASH.Text = "";
                    this.lblCreacion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado! {ex.Message}\n\n{ex}", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        List<RitJsonProject> attendedRits = new List<RitJsonProject>();

        private void bgworkerLoadReportes_DoWork(object sender, DoWorkEventArgs e)
        {
            /* 
             * PROCESO DE ESCANEADO Y REVISION DE TODOS LOS REPORTES
             * 
             * - EXAMINAMOS TODOS LOS AÑOS REGISTRADOS EN LA CARPETA RITs DEL SISTEMA
             * - EXAMINAMOS MES CON MES LA EXISTENCIA DE REPORTES EN LOS QUE CONTENTGAN 
             *   EN LA LLAVE "usuario_final" EL NOMBRE DEL USUARIO DEL EQUIPO ASIGNADO
             * */
            List<string> projectsPaths = new List<string>();

            string path = $@"{Properties.Settings.Default.RITFormPathDestiny}\RITs";
            #region EXAMINAMOS LOS ARCHIVOS Y LOS ENLISTAMOS
            // Carpetas de años
            foreach (DirectoryInfo i in new DirectoryInfo(path).GetDirectories())
            {
                string[] ignoredDirs = new string[] { "resguados" };
                if (!ignoredDirs.Contains(i.Name))
                {
                    // Carpetas de Meses
                    foreach (DirectoryInfo j in new DirectoryInfo(i.FullName).GetDirectories())
                    {
                        // Archivos de proyectos de cada mes
                        foreach (FileInfo k in new DirectoryInfo(j.FullName).GetFiles())
                        {
                            string[] availableExtensions = new string[] { ".ritproj", ".json" };
                            if (availableExtensions.Contains(k.Extension.ToLower().Trim()))
                            {
                                projectsPaths.Add(k.FullName);
                            }
                        }
                    }
                }
            }
            #endregion
            #region EXAMINAMOS EL CONTENIDO Y FILTRAMOS LOS CONINCIDENTES
            foreach (string i in projectsPaths)
            {
                JObject json = JObject.Parse(File.ReadAllText(i));

                if (json.ContainsKey("usuario_final") == true)
                {
                    if (json["usuario_final"].ToString() == actualMachine.UsuarioAsignado.Nombre)
                    {
                        attendedRits.Add(RitJsonProject.LoadProject(i));
                    }
                }
            }
            #endregion
            #region CARGAMOS LA VISUALIZACION DE LOS OBJETOS CORRESPONDIENTES
            int counter = 1;
            foreach (RitJsonProject i in attendedRits)
            {
                ListViewItem obj = new ListViewItem()
                {
                    Text = counter.ToString(),
                    Tag = i.FilePath,
                    ImageIndex = 1,
                    StateImageIndex = 1
                };
                obj.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
                {
                    // Falla reportada
                    new ListViewItem.ListViewSubItem()
                    {
                        Text = i.Falla
                    },  // No. Folio
                    new ListViewItem.ListViewSubItem()
                    {
                        Text = i.NoFolio
                    },  // No. de Ticket
                    new ListViewItem.ListViewSubItem()
                    {
                        Text = i.NoTicket
                    },  // Fecha de Atencion
                    new ListViewItem.ListViewSubItem()
                    {
                        Text = i.FechaDeAtencion.ToString("d")
                    },  // Path
                    new ListViewItem.ListViewSubItem()
                    {
                        Text = i.FilePath
                    }
                });
                this.lviewReportesAtendidos.Items.Add(obj);
                counter++;
            }
            #endregion
        }

        private void bgworkerLoadReportes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
