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
using System.IO;
using Newtonsoft.Json.Linq;

namespace RIT_Solver
{
    public partial class añadir_usuario : Form
    {
        private string ConstructorForm;

        public añadir_usuario(string aConstructorForm)
        {
            InitializeComponent();

            ConstructorForm = aConstructorForm;
        }

        private void SaveProfileMethod ()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (string.IsNullOrEmpty(txtNumeroDeEmpleado.Text) | string.IsNullOrEmpty(txtExtension.Text) | string.IsNullOrEmpty(txtUsuarioRed.Text) | string.IsNullOrEmpty(txtCorreo.Text) | string.IsNullOrEmpty(txtDepartamento.Text))
                {
                    if (RJMessageBox.Show("Existen campos vacios! recuerda que cuantos mas campos llenes, mas datos podra autocompletar el programa. ¿Desea continuar?", "Añadir Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Guardamos los datos
                        inventarios.UserJsonFileMaker(this.txtNombre.Text, this.txtNumeroDeEmpleado.Text, this.txtExtension.Text, this.txtUsuarioRed.Text, this.txtCorreo.Text, this.txtDepartamento.Text, this.cboxLocalidadAsignada.Text);
                        RJMessageBox.Show("Tarjeta de usuario creada con exito!", "Añadir Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    inventarios.UserJsonFileMaker(this.txtNombre.Text, this.txtNumeroDeEmpleado.Text, this.txtExtension.Text, this.txtUsuarioRed.Text, this.txtCorreo.Text, this.txtDepartamento.Text, this.cboxLocalidadAsignada.Text);
                    RJMessageBox.Show("Tarjeta de usuario creada con exito!", "Añadir Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveProfileMethod();
            /** AÑADIR FUNCION DE RECARGA AUTOMATICA DE LA LISTA **/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void añadir_usuario_Load(object sender, EventArgs e)
        {
            #region CARGA DE DIRECCIONES DE LAS LOCALIDADES GUARDADAS
            string LOCALS_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Directory.Exists(LOCALS_PATH))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(LOCALS_PATH);
                    FileInfo[] files = di.GetFiles("*.json");
                    foreach (FileInfo file in files)
                    {
                        JObject json = JObject.Parse(File.ReadAllText(file.FullName));

                        
                        this.cboxLocalidadAsignada.Items.Add(json["poblacion"].ToString());
                        
                    }

                    this.cboxLocalidadAsignada.SelectedIndex = 0;
                    //this.cboxLocalidadDefault.SelectedText = Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT;

                    //this.lblUsuariosCargados.Text = $"{usuariosCount} usuarios cargados con exito!";
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion

            #region CARGAMOS LOS DEPARTAMENTOS
            this.txtDepartamento.AutoCompleteCustomSource = new Departamentos().Lista;
            #endregion
        }

        private void añadir_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            } else if (e.KeyValue == (char)Keys.Enter)
            {
                SaveProfileMethod();
            }
        }


        #region VALIDACIONES DE TEXTBOXES
        string WAR_MSG = "Se recomienda llenar este campo";
        string ERR_MSG = "Debe llenar este campo!";
        private void txtDepartamento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDepartamento.Text))
            {
                warningProvider.SetError(txtDepartamento, WAR_MSG);
            } 
            else
            {
                warningProvider.SetError(txtDepartamento, "");
            }
        }

        private void txtNumeroDeEmpleado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNumeroDeEmpleado.Text))
            {
                warningProvider.SetError(txtNumeroDeEmpleado, WAR_MSG);
            }
            else
            {
                warningProvider.SetError(txtNumeroDeEmpleado, "");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, ERR_MSG);
            }
            else
            {
                errorProvider.SetError(txtNombre, "");
            }
        }

        private void txtExtension_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtExtension.Text))
            {
                warningProvider.SetError(txtExtension, WAR_MSG);
            }
            else
            {
                warningProvider.SetError(txtExtension, "");
            }
        }

        private void txtUsuarioRed_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuarioRed.Text))
            {
                warningProvider.SetError(txtUsuarioRed, WAR_MSG);
            }
            else
            {
                warningProvider.SetError(txtUsuarioRed, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCorreo.Text))
            {
                warningProvider.SetError(txtCorreo, WAR_MSG);
            }
            else
            {
                warningProvider.SetError(txtCorreo, "");
            }
        }

        private void cboxLocalidadAsignada_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboxLocalidadAsignada.Text == "No asignada")
            {
                warningProvider.SetError(cboxLocalidadAsignada, WAR_MSG);
            }
            else
            {
                warningProvider.SetError(cboxLocalidadAsignada, "");
            }
        }
        #endregion
    }
}
