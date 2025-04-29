using FlowCommonWorkcore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Solver_Server
{
    /// <summary>
    /// Funciones utilitarias
    /// </summary>
    public class UtilityFunctions
    {
        /// <summary>
        /// Validamos la existencia de un objeto en la base de datos segun si encontramos coincidencias
        /// </summary>
        /// <param name="DataBase">Nombre de la base de datos</param>
        /// <param name="Table">Tabla donde estan los datos</param>
        /// <param name="Column">Columna de los datos a buscar</param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool DoesObjectExists(string DataBase, string Table, string Column, string Value)
        {
            AppDesignPatron appPatron = new AppDesignPatron();
            bool isExist = false;

            #region CONEXION
            string servidor = AppDesignPatron.ServerHostname;
            string usuario = AppDesignPatron.ServerUsername;
            string password = AppDesignPatron.ServerPassword;

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + DataBase + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            #endregion

            #region BUSQUEDA DE COINCIDENCIAS
            try
            {
                string consulta = $"SELECT * FROM {DataBase}.{Table} WHERE {Column}='{Value}';";
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                int coinc = 0;
                while (reader.Read())
                {
                    coinc++;
                }

                // Revisamos las coincidencias
                if (coinc > 0)
                {
                    isExist = true;
                }
                else if (coinc == 0)
                {
                    isExist = false;
                }
            }
            catch (MySqlException ex)
            {
                LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, Modules.UtilityFunctions.GetText(), "AppsMethods.cs", $"{ex.Message}\n{ex.ToString()}");
                MessageBox.Show($"Ha ocurrido un error inesperado durante la consulta! {ex.Message}", "AppsMethods - Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.Close();
            }
            #endregion

            return isExist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataBase"></param>
        /// <param name="Table"></param>
        /// <returns></returns>
        public static bool DoesTableExist(string DataBase, string Table)
        {
            #region CONEXION
            string servidor = AppDesignPatron.ServerHostname;
            string usuario = AppDesignPatron.ServerUsername;
            string password = AppDesignPatron.ServerPassword;

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + DataBase + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            #endregion 

            try
            {
                // Consulta para verificar si la tabla existe en el esquema de la base de datos
                string query = @"SELECT COUNT(*) 
                         FROM INFORMATION_SCHEMA.TABLES 
                         WHERE TABLE_SCHEMA = @baseDatos 
                         AND TABLE_NAME = @tabla;";
                // Abrir la conexión
                conexionBD.Open();

                using (MySqlCommand comando = new MySqlCommand(query, conexionBD))
                {
                    // Parámetros para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@baseDatos", DataBase);
                    comando.Parameters.AddWithValue("@tabla", Table);

                    // Ejecutar la consulta y obtener el resultado
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    // Si el resultado es mayor que 0, la tabla existe
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }

    public enum LabelTags
    {
        APP_NAME,
    }

    /// <summary>
    /// Modulos de la aplicacion
    /// </summary>
    public enum Modules
    {
        InitializeServer,
        ServerObjectController,
        UtilityFunctions,
    }

    public static class ModulesExtensions
    {
        public static string GetText(this Modules module)
        {
            switch (module)
            {
                case Modules.InitializeServer:
                    return "Server Initialize";
                case Modules.ServerObjectController:
                    return "Server Object Controller";
                case Modules.UtilityFunctions:
                    return "Utility Functions";
                default:
                    return "- [ Unknown Module ] -";
            }
        }
    }

    #region CLASES DE INVOCACIONES
    /// <summary>
    /// Validador de credenciales del servidor
    /// </summary>
    public class ServerCredentialsBox
    {
        public static DialogResult Show()
        {
            return new ServerCredentialsValidate().ShowDialog();
        }
    }
    #endregion

    public partial class AppDesignPatron
    {
        /// <summary>
        /// Hostname del servidor MySQL y el repositorio de archivos
        /// </summary>
        public static string ServerHostname { get; set; } = Properties.Settings.Default.MY_SQL_HOSTNAME;
        /// <summary>
        /// Usuario del servidor MySQL
        /// </summary>
        public static string ServerUsername { get; set; } = Properties.Settings.Default.MY_SQL_USERNAME;
        /// <summary>
        /// Contraseña del usuario del servidor MySQL
        /// </summary>
        public static string ServerPassword { get; set; } = Properties.Settings.Default.MY_SQL_PASSWORD;
        /// <summary>
        /// Base de datos destino del sistema.
        /// <br></br>
        /// Por defecto: flow_solver
        /// </summary>
        public static string ServerDataBase { get; set; } = Properties.Settings.Default.DEFAULT_SCHEMA;
        /// <summary>
        /// Ruta de red del repositorio de archivos
        /// </summary>
        public static string RepoNetworkPath { get; set; } = $@"\\{ServerHostname}\flow_solver_rep";
        public static string DefaultSchema { get; set; } = "flow_solver";
    }
}
