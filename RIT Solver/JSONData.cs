using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using System.Text.Json;
using System.Text.Json.Serialization;




namespace Flow_Solver
{

    class Manipulation
    {
        public static string fileJSONPath { get; set; }

        public static string loadProfile(string aKey)
        {
            /* Obtiene un valor asociado a una llave */
            string fall_val = "";

            return fall_val;
        }

        // FUNCION LISTA
        public static void saveProfile(string aProfileName, Dictionary<string, string> aProfileData)
        {
            /* Establece un valor asociado a una llave */
            string path = Application.StartupPath + @"\Profiles\";

            //RJMessageBox.Show(aProfileName + Environment.NewLine + Environment.NewLine + aProfileData.Values.ToString());
            string miJson = JsonSerializer.Serialize(aProfileData);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(path + $"{aProfileName}.json", miJson);
        }
    }
}