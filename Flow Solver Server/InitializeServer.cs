using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowCommonWorkcore;

namespace Flow_Solver_Server
{
    public class InitializeServer
    {
        /// <summary>
        /// Crea todo lo correspondiente en el servidor; la base de datos, los repositorios de archivos, las tablas en las bases de datos, etc.
        /// </summary>
        public static void Initialize()
        {
            // Initialize the server
            LogSystem.Add(EventIO.OUT, EventType.INFORMATION, Modules.InitializeServer.GetText(), "InitializeServer.cs", "Inicializando el servidor...");

            // Create the database if it doesn't exist
            CreateDatabase();

            // Load configuration
            LoadDefaultConfiguration();

            // Create repository files
            CreateRepoFiles();

            LogSystem.Add(EventIO.OUT, EventType.OKAY, Modules.InitializeServer.GetText(), "InitializeServer.cs", "Servidor incializado con exito!");
        }

        private static void CreateDatabase()
        {
            // Create the database if it doesn't exist
            Console.WriteLine("Creating database...");
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
