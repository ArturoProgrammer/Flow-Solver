using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TableScriptExtractor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Extractor de Script de Tabla MySQL ===\n");

            Console.Write("Servidor (host): ");
            var host = Console.ReadLine();

            Console.Write("Puerto (default 3306): ");
            var portInput = Console.ReadLine();
            var port = string.IsNullOrWhiteSpace(portInput) ? 3306 : int.Parse(portInput);

            Console.Write("Usuario: ");
            var user = Console.ReadLine();

            Console.Write("Contraseña: ");
            var password = ReadPassword();

            Console.Write("Base de datos: ");
            var database = Console.ReadLine();

            Console.Write("Tabla: ");
            var table = Console.ReadLine();

            var connectionString = new MySqlConnectionStringBuilder
            {
                Server = host,
                Port = (uint)port,
                UserID = user,
                Password = password,
                Database = database,
                SslMode = MySqlSslMode.None // Puedes ajustar según tu infraestructura.
            }.ConnectionString;

            try
            {
                using var connection = new MySqlConnection(connectionString);
                await connection.OpenAsync();

                var query = $"SHOW CREATE TABLE `{table}`;";
                using var cmd = new MySqlCommand(query, connection);

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    var createTableScript = reader.GetString(1);

                    Console.WriteLine("\n=== Script de Creación ===\n");
                    Console.WriteLine(createTableScript);
                }
                else
                {
                    Console.WriteLine("No se encontró la tabla especificada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para leer contraseña de manera oculta
        static string ReadPassword()
        {
            var password = string.Empty;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[0..^1];
                    int pos = Console.CursorLeft;
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;
        }
    }
}
