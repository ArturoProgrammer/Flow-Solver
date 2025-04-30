using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowCommonWorkcore;

namespace Flow_Solver_Server
{
    public partial class ServerMethods
    {
        /// <summary>
        /// Crea todas las tablas de la base de datos
        /// </summary>
        private static void CreateDatabase()
        {
            LogSystem.Add(EventIO.OUT, EventType.INFORMATION, Modules.InitializeServer.GetText(), "InitializeServer.cs", $"Iniciando la creacion de las tablas por defecto en las bases de datos...");
            LogSystem.Add(EventIO.OUT, EventType.INFORMATION, Modules.InitializeServer.GetText(), "InitializeServer.cs", $"Creando tabla de usuarios...");

            #region TABLA DE USUARIOS
            string defaultUsername = "Root";
            string defaultPassword = "1111";

            // creamos la tabla
            #endregion
        }

        private static void LoadDefaultConfiguration()
        {
            // Load server configuratio on the database
            Console.WriteLine("Loading configuration...");
        }

        private static void CreateRepoFiles()
        {
            // Create the repository files
            Console.WriteLine("Creating repository files...");
        }
    }
}
