using Flow_Solver_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Solver_Server
{
    public class MultiLanguageManager
    {
        /// <summary>
        /// Lenguajes disponibles actualmente para el programa
        /// </summary>
        public enum Language
        {
            ENGLISH,
            SPANISH,
            NONE,
        }

        /// <summary>
        /// Listado de mensajes comunes
        /// </summary>
        public enum CommonMessages
        {
            /// <summary>
            /// Confirmacion de salida o cierre de una ventana
            /// </summary>
            CLOSE_CONFIRMATION,
            /// <summary>
            /// Indica que no existe la base de datos por defecto del sistema y por lo tanto se creara
            /// </summary>
            DEFAULT_SCHEMA_NOT_EXISTS,
        }

        public enum CommonTitles
        {
            /// <summary>
            /// Titulo de la aplicacion
            /// </summary>
            CLASSIC,
            /// <summary>
            /// Titulo de confirmacion
            /// </summary>
            CONFIRMATION,
        }
    }

    public static class Language
    {
        public static string GetText(this MultiLanguageManager.Language language)
        {
            switch (language)
            {
                case MultiLanguageManager.Language.ENGLISH:
                    return "English";
                case MultiLanguageManager.Language.SPANISH:
                    return "Español";
                default:
                    return "Unknown Language";
            }
        }

        public static MultiLanguageManager.Language Parse(string lang)
        {
            switch (lang)
            {
                case "English":
                    return MultiLanguageManager.Language.ENGLISH;
                case "Español":
                    return MultiLanguageManager.Language.SPANISH;
                default:
                    return MultiLanguageManager.Language.NONE;
            }
        }
    }

    public static class CommonTitles
    {
        public static string GetText(this MultiLanguageManager.CommonTitles title)
        {
            MultiLanguageManager.Language SelectedLang = Language.Parse(Properties.Settings.Default.DEFAULT_INTERFACE_LANGUAGE);
            string F_R_MSG = "";

            if (SelectedLang == MultiLanguageManager.Language.SPANISH)
            {
                switch (title)
                {
                    case MultiLanguageManager.CommonTitles.CLASSIC:
                        F_R_MSG = Application.ProductName;
                        break;
                    case MultiLanguageManager.CommonTitles.CONFIRMATION:
                        F_R_MSG = "Confirmación";
                        break;
                }
            }

            return F_R_MSG;
        }
    }

    public static class CommonMessages
    {
        public static string GetText(this MultiLanguageManager.CommonMessages message)
        {
            MultiLanguageManager.Language SelectedLang = Language.Parse(Properties.Settings.Default.DEFAULT_INTERFACE_LANGUAGE);
            string F_R_MSG = "";

            if (SelectedLang == MultiLanguageManager.Language.SPANISH)
            {
                switch (message)
                {
                    case MultiLanguageManager.CommonMessages.CLOSE_CONFIRMATION:
                        F_R_MSG = "¿Está seguro de que desea cerrar la ventana?";
                        break;
                    case MultiLanguageManager.CommonMessages.DEFAULT_SCHEMA_NOT_EXISTS:
                        F_R_MSG = "La base de datos por defecto del sistema no existe! se creara un nuevo esquema por defecto para continuar. ¿Confirmas la creacion de un nuevo esquema por defecto?";
                        break;
                }
            }

            return F_R_MSG;
        }
    }
}
