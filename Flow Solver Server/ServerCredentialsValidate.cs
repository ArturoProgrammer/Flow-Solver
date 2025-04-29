using FlowCommonWorkcore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver_Server
{
    public partial class ServerCredentialsValidate : Form
    {
        public ServerCredentialsValidate()
        {
            InitializeComponent();
        }


        bool CredentialsValid = false;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MultiLanguageManager.CommonMessages.CLOSE_CONFIRMATION.GetText(), MultiLanguageManager.CommonTitles.CONFIRMATION.GetText(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void _ValidateServerConnection()
        {

        }

        private void ServerCredentialsValidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CredentialsValid)
            {
                // En caso de que las credenciales sean validas las guardamos en las propiedades
                Properties.Settings.Default.MY_SQL_USERNAME = this.txtUsername.Text;
                Properties.Settings.Default.MY_SQL_PASSWORD = this.txtPassword.Text;
            }

            Application.Exit();
            Environment.Exit(0);
        }

        bool showingPass = false;
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (!showingPass)
            {
                // Mostramos la contraseña
                this.txtPassword.PasswordChar = '\0';
                showingPass = true;
                this.btnVer.Image = Properties.Resources.hidden_16;
            }
            else
            {
                // Ocultamos la contraseña
                this.txtPassword.PasswordChar = '*';
                showingPass = false;
                this.btnVer.Image = Properties.Resources.view_16;
            }
        }

        private void ServerCredentialsValidate_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = AppDesignPatron.ServerUsername;
            this.txtPassword.Text = AppDesignPatron.ServerPassword;
            this.txtHostname.Text = AppDesignPatron.ServerHostname;
            this.txtUsername.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            // Validamos la conexion con el servidor de las siguientes maneras
            // 1. Conectamos con el servidor para probar su existencia
            bool serverConnection = _ServerConnectionValid();
            bool databaseConnection = false;
            bool repositoryConnection = false;

            if (serverConnection)
            {
                // 2. Conectando a la base de datos para validar su existencia, en caso de que no exista, la creamos
                databaseConnection = _DatabaseConnectionValid();

                // 3. Validando el repositorio de archivos
                repositoryConnection = _RepositoryConnectionValid();
            }

            /* 
             * Anunciamos y evaluamos los resultados
             * */

            if (serverConnection && databaseConnection && repositoryConnection)
            {
                
            }
        }

        bool _RepositoryConnectionValid()
        {
            bool resp = false;

            resp = Directory.Exists(AppDesignPatron.RepoNetworkPath);

            if (!resp)
            {
                /* 
                 * Creamos el repositorio en caso de requerirlo
                 * */
                if (MessageBox.Show(MultiLanguageManager.CommonMessages.DEFAULT_SCHEMA_NOT_EXISTS.GetText(), MultiLanguageManager.CommonTitles.CONFIRMATION.GetText(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sql
                } 
                else
                {

                }
            }

            return resp;
        }

        bool _DatabaseConnectionValid()
        {
            bool resp = false;

            ServerMethods.SqlReadConnection _connection = new ServerMethods.SqlReadConnection(Properties.Settings.Default.DEFAULT_SCHEMA, "");
            resp = _connection.IsDatabaseExists();

            if (!resp)
            {
                /* 
                 * En caso de que no exista la base de datos, la creamos
                 * */

                // Despues de haberla creado, validamos su existencia
                //_DatabaseConnectionValid();
            }

            return resp;
        }

        bool _ServerConnectionValid()
        {
            bool resp = false;

            string connStr = $"Server={this.txtHostname.Text};User ID={this.txtUsername.Text};Password={this.txtPassword.Text};Connection Timeout=5;"; // Solo server, sin DB

            try
            {
                using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connStr))
                {
                    connection.Open();
                    resp = true; // Conexión exitosa
                }
            }
            catch (Exception ex)
            {
                LogSystem.Add(EventIO.IN, EventType.EXCEPTION, Modules.InitializeServer.GetText(), $"{this.Name}.cs", $"Ha ocurrido un error inesperado durante el contacto con el servidor! {ex.Message}\n{ex}");   
                resp = false;
            }

            return resp;
        }
    }
}
