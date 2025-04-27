using Microsoft.Office.Core;
using Org.BouncyCastle.Crypto.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    internal static class Program
    {
        static string mutexName = $"{Application.ProductName}_MainProgram";
        static main _MainAppThread;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool createdNew;
            Mutex mutex = new Mutex(true, mutexName, out createdNew);

            // Verifica si se creó un nuevo mutex o si ya existe otro en ejecución
            if (!createdNew)
            {
                //
                // En caso de que no sea la primera instancia, envía el archivo al pipe
                //
                if (args.Length > 0)
                {
                    //SendFileToExistingInstance(args);

                    #region CODIGO
                    string[] filePath = args;

                    List<string> ritProjs = new List<string>();
                    List<string> actProjs = new List<string>();

                    foreach (string file in filePath)
                    {
                        FileInfo fi = new FileInfo(file);

                        switch (fi.Extension)
                        {
                            case ".actproj":
                                actProjs.Add(file);
                                break;
                            case ".ritproj":
                                ritProjs.Add(file);
                                break;
                        }
                    }

                    // Invoca el método para abrir el archivo en el formulario principal
                    //_MainAppThread?.Invoke((Action)(() => _MainAppThread.OpenFileByRit(ritProjs.ToArray())));
                    // Invoca el método para abrir el archivo en el formulario principal
                    //main.Instance?.Invoke((Action)(() => main.Instance.OpenFileByAct(actProjs.ToArray())));

                    //MessageBox.Show("aqui 1");
                    _MainAppThread.OpenFileByRit(ritProjs.ToArray());
                    //MessageBox.Show("aqui 2");
                    _MainAppThread.OpenFileByAct(actProjs.ToArray());
                    #endregion
                }
                else
                {
                    // Ya hay otra instancia en ejecución, por lo que terminamos esta
                    MessageBox.Show("Ya existe una instancia actual en ejecucion, no puedes abrir otra!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else 
            {
                //
                // En caso de que sea la primera instancia, envía el archivo al pipe y genera la instancia
                //
                bool isNormalInitialize = true;

                #region CLASIFICAMOS LOS VALORES DE LOS ARCHIVOS
                List<Tuple<AppertureType, string>> filesData = new List<Tuple<AppertureType, string>>();
                if (args.Length > 0)
                {
                    isNormalInitialize = false;

                    // Clasificamos las listas
                    foreach (string path in args)
                    {
                        FileInfo fi = new FileInfo(path);
                        AppertureType apperture = AppertureType.NONE;

                        switch (fi.Extension)
                        {
                            case ".json":
                                apperture = AppertureType.BY_RIT_PROJECT_FILE;
                                break;
                            case ".ritproj":
                                apperture = AppertureType.BY_RIT_PROJECT_FILE;
                                break;
                            case ".actproj":
                                apperture = AppertureType.BY_ACTIVITY_PROJECT_FILE;
                                break;
                        }

                        //MessageBox.Show($"{apperture}, {fi.FullName}");
                        filesData.Add(new Tuple<AppertureType, string>(apperture, fi.FullName));
                    }
                }
                #endregion

                // Esta es la primera instancia, escucha los mensajes de los pipes
                //Task.Run(() => ListenForFile());

                // Iniciamos la aplicacion
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (isNormalInitialize)
                {
                    // En caso que sea una iniciacion normal
                    _MainAppThread = new main();
                    Application.Run(_MainAppThread);
                } else
                {
                    // En caso de que hayamos iniciado segun la apertura de un archivo
                    _MainAppThread = new main(filesData);
                    Application.Run(_MainAppThread);
                }
            }
            try
            {
                mutex.ReleaseMutex();   // Liberamos el mutex una vez terminada la aplicacion
                CommonMethodsLibrary.OutMessage("out", "Program.cs", $"Mutex de la aplicacion liberado con exito!", "INF");
            }
            catch (Exception e)
            {
                CommonMethodsLibrary.OutMessage("out", "Program.cs", $"Ocurrio un error inesperado al liberar el Mutex de la aplicacion! {e.Message}", "ERR");
            }

            Environment.Exit(0);
            Application.Exit();
        }


        private static void ListenForFile()
        {
            var server = new NamedPipeServerStream(mutexName);
            server.WaitForConnection();

            using (var reader = new StreamReader(server))
            {
                string[] filePath = reader.ReadLine().Split(' ');

                MessageBox.Show(filePath.Length.ToString());

                List<string> ritProjs = new List<string>();
                List<string> actProjs = new List<string>();

                foreach (string file in filePath)
                {
                    FileInfo fi = new FileInfo(file);
                    MessageBox.Show(fi.Extension);

                    switch (fi.Extension)
                    {
                        case ".actproj":
                            actProjs.Add(file);
                            break;
                        case ".ritroj":
                            ritProjs.Add(file);
                            break;
                    }
                }

                /*
                // Invoca el método para abrir el archivo en el formulario principal
                main.Instance?.Invoke((Action)(() => main.Instance.OpenFileByRit(ritProjs.ToArray())));
                // Invoca el método para abrir el archivo en el formulario principal
                main.Instance?.Invoke((Action)(() => main.Instance.OpenFileByAct(actProjs.ToArray())));
                */

                _MainAppThread.OpenFileByAct(actProjs.ToArray());
                _MainAppThread.OpenFileByRit(ritProjs.ToArray());

                reader.Close();
            }
        }

        private static void SendFileToExistingInstance(string[] filePaths)
        {
            /*
            using (var client = new NamedPipeClientStream(mutexName))
            {
                client.Connect();
                using (var writer = new StreamWriter(client))
                {
                    foreach (string file in filePaths)
                    {                        
                        writer.WriteLine(file);
                    }

                    writer.Close();
                }
            }
            */

            //ListenForFile();
        }
    }
}
