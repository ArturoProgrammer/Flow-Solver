using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RIT_Commands_Lets
{
    public class assets
    {
        /// <summary>
        /// Nombre del verbo del comando
        /// </summary>
        public const string CmdLetVerb = "Rit";

        public static string GetRegeditValue(string Key, string Path= @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\RIT Solver", bool isLocalMachine = true)
        {
            RegistryKey baseKey = isLocalMachine ? Registry.LocalMachine : Registry.CurrentUser;

            try
            {
                using (RegistryKey key = baseKey.OpenSubKey(Path))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(Key);
                        return value?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        return $"La clave '{Path}' no fue encontrada.";
                    }
                }
            } catch (Exception ex)
            {
                throw new Exception($"Error al obtener el valor de registro: {ex.Message}");
            }
        }
    }
}
