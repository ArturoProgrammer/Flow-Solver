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
            string USER_TABLE_TEMPLATE = $@"CREATE TABLE `server_users` (
  `HASH` varchar(12) NOT NULL,
  `Username` varchar(45) NOT NULL COMMENT 'Nombre de usuario',
  `Employee` varchar(6) NOT NULL COMMENT 'Numero de empleado del empleado asignado a este usuario',
  `Password` varchar(45) NOT NULL COMMENT 'Contraseña del usuario hasheada',
  `CreationDate` datetime NOT NULL,
  `LastAccess` datetime DEFAULT NULL,
  `LastAccessAttemp` datetime DEFAULT NULL,
  `Privileges` varchar(45) NOT NULL COMMENT 'Nivel de privilegios del usuario',
  PRIMARY KEY (`HASH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            ServerMethods.SqlWriteConnection _connection = new ServerMethods.SqlWriteConnection(AppDesignPatron.DefaultSchema, "server_users");
            _connection.CreateTable(USER_TABLE_TEMPLATE);
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
