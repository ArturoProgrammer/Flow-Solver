using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Messaging;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Management.Automation;

namespace RIT_Solver
{
    public class PowershellModuleInstaller
    {
        /// <summary>
        /// Instala el modulo de PowerShell en la carpeta de módulos del usuario
        /// </summary>
        /// <param name="dllSourcePath"></param>
        public static void LoadModule(string dllSourcePath)
        {
            string moduleName = "RitSolver";
            string userModulePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"WindowsPowerShell\Modules", moduleName);

            string dllDestPath = Path.Combine(userModulePath, $"{moduleName}.PowerShell.dll");
            string psd1Path = Path.Combine(userModulePath, $"{moduleName}.psd1");
            string profilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                @"WindowsPowerShell\Microsoft.PowerShell_profile.ps1");

            // Crear carpeta del módulo si no existe
            if (!Directory.Exists(userModulePath))
                Directory.CreateDirectory(userModulePath);

            // Copiar el DLL si no existe o si es distinto
            if (!File.Exists(dllDestPath) || File.ReadAllBytes(dllSourcePath).Length != File.ReadAllBytes(dllDestPath).Length)
                File.Copy(dllSourcePath, dllDestPath, true);

            // Crear manifiesto con PowerShell
            if (!File.Exists(psd1Path))
            {
                using (PowerShell ps = PowerShell.Create())
                {
                    ps.AddCommand("New-ModuleManifest")
                      .AddParameter("Path", psd1Path)
                      .AddParameter("RootModule", $"{moduleName}.PowerShell.dll")
                      .AddParameter("ModuleVersion", "1.0.0")
                      .AddParameter("Author", "IDC Arturo Venegas")
                      .AddParameter("CompanyName", "Adare Sys")
                      .AddParameter("Description", "Cmdlets personalizados para RIT Solver")
                      .AddParameter("CmdletsToExport", new[] { "RitSolver-Inventory" });

                    ps.Invoke();
                }
            }

            // Añadir Import-Module al perfil si no existe
            if (!File.Exists(profilePath))
                File.WriteAllText(profilePath, "");

            string[] lines = File.ReadAllLines(profilePath);
            if (!lines.Any(l => l.Contains("Import-Module RitSolver")))
            {
                File.AppendAllLines(profilePath, new[] { "Import-Module RitSolver" });
            }
        }
    }


    public class WindowsRegisterUpdater
    {
        /// <summary>
        /// Instala la entrada de registro indicada
        /// </summary>
        /// <param name="Path"></param>
        public static void LoadEntry(string Path)
        {
            try
            {
                if (File.Exists(Path))
                {
                    Process regeditProcess = Process.Start("regedit.exe", $"/s {Path}");
                    regeditProcess.WaitForExit();

                    File.Delete(Path);  // Eliminamos el archivo para no dejar rastro

                    FileInfo fi = new FileInfo(Path);
                    CommonMethodsLibrary.OutMessage("IN", "WindowsRegisterUpdater.cs", $"Se cargo en registro la entrada '{fi.Name}' de manera exitosa!", "OKA");
                }
                else
                {
                    CommonMethodsLibrary.OutMessage("IN", "WindowsRegisterUpdater.cs", $"No se encontro el archivo de registro {Path} para cargarse!", "WAR");
                    MessageBox.Show($"El archivo especificado no existe! {Path}", $"{Application.ProductName} - Archivo inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error inesperado a la hora de cargar el reigstro! El programa dice: {ex.Message}", $"{Application.ProductName} - Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public enum RegIcon
        {
            Historial_IconFile,
            Activity_IconFile,
            Profile_IconFile,
            MainApp_IconFile,
            ToDoList_IconFile,
            TrackWayBill_IconFile,
            RitProject_IconFile
        }


        public static void _ValidateIconsOrCreate(RegIcon _icon)
        {
            switch (_icon)
            {
                case RegIcon.Historial_IconFile:
                    string path_h = $@"{Application.StartupPath}\historial_icon.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.historial_icon;
                        using (FileStream fs = new FileStream(path_h, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_h}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.Activity_IconFile:
                    string path_a = $@"{Application.StartupPath}\activity_file_icon.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.activity_file_icon;
                        using (FileStream fs = new FileStream(path_a, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_a}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.Profile_IconFile:
                    string path_p = $@"{Application.StartupPath}\profile_file.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.profile_file;
                        using (FileStream fs = new FileStream(path_p, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_p}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.ToDoList_IconFile:
                    string path_t = $@"{Application.StartupPath}\to_do_list.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.to_do_list;
                        using (FileStream fs = new FileStream(path_t, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_t}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.TrackWayBill_IconFile:
                    string path_w = $@"{Application.StartupPath}\trackwaybillfile.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.trackwaybillfile;
                        using (FileStream fs = new FileStream(path_w, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_w}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.RitProject_IconFile:
                    string path_r = $@"{Application.StartupPath}\rit_project_file.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.rit_project_file;
                        using (FileStream fs = new FileStream(path_r, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_r}'...", "INF");
                        }
                    }
                    break;
                case RegIcon.MainApp_IconFile:
                    string path_logo = $@"{Application.StartupPath}\RIT_Solver.ico";
                    if (true)
                    {
                        System.Drawing.Icon icon = Properties.Resources.RIT_Solver;
                        using (FileStream fs = new FileStream(path_logo, FileMode.Create, FileAccess.Write))
                        {
                            icon.Save(fs);
                            CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Se ha creado el icono '{path_logo}'...", "INF");
                        }
                    }
                    break;
            }
        }


        /// <summary>
        /// Entrada de registro relacionada a los datos de version y actualizacion del software
        /// </summary>
        public class ApplicationDataUpdate
        {
            /// <summary>
            /// Genera la entrada de registro (*.reg)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                WindowsRegisterUpdater._ValidateIconsOrCreate(RegIcon.MainApp_IconFile);

                string REG_PATH = $"SoftwareRegUpdater.reg";

                string content = $@"Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\RIT Solver]
""DisplayName""=""{Application.ProductName}""
""UninstallString""=""{Application.StartupPath}\Universal Uninstaller.exe""
""DisplayVersion""=""{Properties.Settings.Default.SYS_VERSION}""
""Publisher""=""IDC Arturo Venegas""
""NoModify""=dword:00000001
""NoRepair""=dword:00000001
""InstallDate""=""{DateTime.Now.ToString("yyyy MM dd").Replace(" ", "")}""
""MajorVersion""=dword:00000001
""MinorVersion""=dword:00000001
""VersionMajor""=dword:00000001
""VersionMinor""=dword:00000001
""EstimatedSize""=dword:0058000
""DisplayIcon""=""{Application.StartupPath}\RIT_Solver.ico""
""InstallationPath""=""{Application.StartupPath}""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro de detalles del software creada con exito!", "OKA");
                return REG_PATH;
            }
        }

        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro de los archivos de extension .actproj del software
        /// </summary>
        public class ApplicationFile_ActProj
        {
            /// <summary>
            /// Genera la entrada de registro (*.reg)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.Activity_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "actproj";
                string extDescription = "Proyecto de Actividad de RIT Solver";
                string extName = "ActProj";
                string extInfoTip = "Actividad de RIT Solver";
                string nombreClaseArchivo = "rit_actproj";  // Nombre de la clase de archivo


                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";


                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "activity_file_icon.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell\open]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell\open\command]
@=""{key_value}""

[HKEY_CLASSES_ROOT\{nombreClaseArchivo}\shell\AbrirCon{nombreAplicacion}]
@=""Abrir con {nombreAplicacion}""

[HKEY_CLASSES_ROOT\{nombreClaseArchivo}\shell\AbrirCon{nombreAplicacion}\command]
@=""{key_value}""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }

        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro de los archivos de extension .card del software
        /// </summary>
        public class ApplicationFile_Card
        {
            /// <summary>
            /// Genera la entrada de registro (*.reg)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.Profile_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "card";
                string extDescription = "Tarjeta de usuario de RIT Solver";
                string extName = "Card";
                string extInfoTip = extDescription;
                string nombreClaseArchivo = "rit_card";  // Nombre de la clase de archivo


                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";


                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "profile_file.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }

        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro de los archivos de extension .historial del software
        /// </summary>
        public class ApplicationFile_EventHistorial
        {
            /// <summary>
            /// Genera la entrada de registro (*.historial)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.Historial_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "historial";
                string extDescription = "Historial de Eventos";
                string extName = "Historial";
                string extInfoTip = extDescription;
                string nombreClaseArchivo = "rit_historial";  // Nombre de la clase de archivo


                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";


                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "historial_icon.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }

        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro de los archivos de extension .todolist del software
        /// </summary>
        public class ApplicationFile_ToDoList
        {
            /// <summary>
            /// Genera la entrada de registro (*.historial)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.ToDoList_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "todolist";
                string extDescription = "Listado de Pendientes";
                string extName = "To Do List";
                string extInfoTip = extDescription;
                string nombreClaseArchivo = "rit_historial";  // Nombre de la clase de archivo


                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";


                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "to_do_list.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }


        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro del archivo de extension .trackfile del software
        /// </summary>
        public class ApplicationFile_TrackFile
        {
            /// <summary>
            /// Genera la entrada de registro (*.historial)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.TrackWayBill_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "trackfile";
                string extDescription = "Listado de Guias";
                string extName = "Track Waybill List";
                string extInfoTip = extDescription;
                string nombreClaseArchivo = "rit_historial";  // Nombre de la clase de archivo

                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";

                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "trackwaybillfile.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }



        /// <summary>
        /// Entrada de registro relacionada a la configuracion del registro de los archivos de extension .actproj del software
        /// </summary>
        public class ApplicationFile_RitProj
        {
            /// <summary>
            /// Genera la entrada de registro (*.reg)
            /// </summary>
            /// <returns>La ruta del archivo</returns>
            public static string Make()
            {
                _ValidateIconsOrCreate(RegIcon.RitProject_IconFile);

                /*
                 * Datos del archivo
                 * */
                string ext = "ritproj";
                string extDescription = "Proyecto de Reporte de Intervencion Tecnica de RIT Solver";
                string extName = "RitProj";
                string extInfoTip = "Formulario de Reporte de Intervencion Tecnica de RIT Solver";
                string nombreClaseArchivo = "rit_actproj";  // Nombre de la clase de archivo


                // Ruta donde se guardará el archivo .reg
                string REG_PATH = $"SoftwareExtension_{ext}.reg";


                /* 
                 * Ruta de la aplicación
                 * */
                string a = @"\";
                string nombreAplicacion = Application.ProductName;
                string rutaAplicacion = Application.ExecutablePath.Replace(@"\", @"\\");
                string abd = $"{a}\"{rutaAplicacion.Trim()}{a}\"";
                string param = $"{a}\"%1{a}\"";
                string key_value = $"{abd} {param}";

                // Ruta del icono
                string path = Path.Combine(Application.StartupPath, "rit_project_file.ico").Replace(@"\", @"\\");
                string iconpath = $"{a}\"{path.Trim()}{a}\"";

                //MessageBox.Show(iconpath);

                // Crear el contenido del archivo .reg
                string content = $@"Windows Registry Editor Version 5.00
[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\.{ext}\OpenWithProgids]
@=""{extDescription}""
""{extName}.{ext}""=""""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}]
@=""{extDescription}""
""FriendlyTypeName""=""{extDescription}""
""InfoTip""=""{extInfoTip}""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\DefaultIcon]
@=""{iconpath},0""

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell\open]

[HKEY_LOCAL_MACHINE\SOFTWARE\Classes\{extName}.{ext}\shell\open\command]
@=""{key_value}""

[HKEY_CLASSES_ROOT\{nombreClaseArchivo}\shell\AbrirCon{nombreAplicacion}]
@=""Abrir con {nombreAplicacion}""

[HKEY_CLASSES_ROOT\{nombreClaseArchivo}\shell\AbrirCon{nombreAplicacion}\command]
@=""{key_value}""
";
                File.WriteAllText(REG_PATH, content);

                CommonMethodsLibrary.OutMessage("OUT", "WindowsRegisterUpdater.cs", $"Entrada de registro para extension '*.{ext} - {extName}' en la clase del registro '{nombreClaseArchivo}' creada con exito!", "OKA");
                return REG_PATH;
            }
        }
    }
}
