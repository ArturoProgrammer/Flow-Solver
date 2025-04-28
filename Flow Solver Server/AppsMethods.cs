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
    }

    public static class ModulesExtensions
    {
        public static string GetText(this Modules module)
        {
            switch (module)
            {
                case Modules.InitializeServer:
                    return "Server Initialize";
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
    }
}
