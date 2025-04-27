using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System.Security.RightsManagement;
using FileProjectManager;
using System.Windows.Diagnostics;
using DocumentFormat.OpenXml.Bibliography;
using System.Web;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.Excel;
using System.Text.Json;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Web.Caching;
using SpreadsheetLight;
using System.Data.OleDb;
using Org.BouncyCastle.Asn1.X509;

namespace Flow_Solver
{
    /// <summary>
    /// Tarjeta de direccion email registrada del sistema
    /// </summary>
    public class EmailCard
    {
        public string EmployeeName { get; set; }
        public string EmployeeDirection { get; set; }

        public EmailCard() { }

        public EmailCard(string Nombre, string Direccion)
        {
            EmployeeName = Nombre;
            EmployeeDirection = Direccion;
        }

        void makeDataJson (string path)
        {
            // Creamos nuestro archivo JSON
            Dictionary<string, string> pairData = new Dictionary<string, string>();

            pairData.Add(EmployeeName, EmployeeDirection);
            string finalJson = System.Text.Json.JsonSerializer.Serialize(pairData);

            File.WriteAllText(path, finalJson);
        }

        /// <summary>
        /// Guardamos la tarjeta de direccion o la creamos en caso de ser necesario
        /// </summary>
        public void Save()
        {
            string targetCardName = $"{EmployeeName.Trim()}.json";
            string targetPath = $@"{Application.StartupPath}\Addresses";

            // Nos aseguramos de que exista el directorio, de no ser asi lo creamos
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            if (File.Exists($@"{targetPath}\{targetCardName}"))
            {
                // Sobreescribimos la direccion si se confirma
                //RJMessageBox.Show("Ya existe esta direccion guardada!");
                
                if (MessageBox.Show($"Ya existe una direccion con este nombre, ¿desea sobreescribir el archivo < {targetCardName} >?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    makeDataJson($@"{targetPath}\{targetCardName}");
                }
            }
            else
            {
                makeDataJson($@"{targetPath}\{targetCardName}");
            }
        }

        /// <summary>
        /// Eliminamos la tarjeta del sistema
        /// </summary>
        public void Delete ()
        {
            string targetCardName = $"{EmployeeName.Trim()}.json";
            string targetPath = $@"{Application.StartupPath}\Addresses";

            if (Directory.Exists(targetPath))
            {
                if (File.Exists($@"{targetPath}\{targetCardName}"))
                {
                    File.Delete($@"{targetPath}\{targetCardName}");
                }
            }
        }
    }

    #region CLASES Y CONTROLADORES DE LOS MODELOS DE EQUIPOS VINCULADOS
    public class MachinesModelsSync
    {
        /// <summary>
        /// Listado de equipos y modelos vinculados de la clase
        /// </summary>
        public List<MachineModelSyncItem> Items { get; set; } = new List<MachineModelSyncItem>();

        public string DataBaseFilePath = "";

        /// <summary>
        /// Cargamos toda la informacion de los equipos vinculados
        /// </summary>
        /// <returns>Objeto construido del archivo especifico</returns>
        public static MachinesModelsSync Load()
        {
            MachinesModelsSync RESPONSE = new MachinesModelsSync();
            try
            {
                #region CODIGO
                string jsonDirectoryPath = $@"{Application.StartupPath}\Inventories";
                string jsonFile = "VinculatedModels.json";

                if (!Directory.Exists(jsonDirectoryPath))
                {
                    Directory.CreateDirectory(jsonDirectoryPath);
                }

                if (File.Exists($@"{jsonDirectoryPath}\{jsonFile}"))
                {
                    RESPONSE.DataBaseFilePath = $@"{jsonDirectoryPath}\{jsonFile}";

                    // En caso de que exista el archivo de vinculacion, lo leemos y mostramos los modelos vinculados
                    JObject jsonA = JObject.Parse(File.ReadAllText($@"{jsonDirectoryPath}\{jsonFile}"));

                    /* 
                     * 
                     * ANTES DE REALIZAR LA LECTURA DE LA INFORMACION PRIMERO VALIDAMOS QUE CONTENGAMOS LA LLAVE
                     * QUE RELACIONA LA IMAGEN DEL PERFIL CON EL MODELO INDICADO.
                     * 
                     * */
                    #region
                    foreach (var i in jsonA)
                    {
                        try
                        {
                            string nombreModelo = i.Key;

                            JObject pharap = JObject.Parse(jsonA[nombreModelo].ToString());
                            if (!pharap.ContainsKey("ProfileImagePath"))
                            {
                                jsonA[nombreModelo]["ProfileImagePath"] = "";   // Añadimos la nueva llave
                            }

                            File.WriteAllText($@"{jsonDirectoryPath}\{jsonFile}", jsonA.ToString(Formatting.Indented));
                        }
                        catch (Exception ex)
                        {
                            CommonMethodsLibrary.OutMessage("IN", "InventarioViewModel.cs", $"OCURRIO UN ERROR INESPERADO DURANTE LA LECTURA DE LOS MODELOS VINCULADOS: {ex.Message}\n{ex}", "ERR");
                        }
                    }
                    #endregion


                    /* 
                     * UNA VEZ VALIDADO, AHORA SI SE PROCEDE A LEER LA INFORMACION
                     * */
                    JObject json = JObject.Parse(File.ReadAllText($@"{jsonDirectoryPath}\{jsonFile}"));
                    foreach (var i in json)
                    {
                        MachineModelSyncItem m = new MachineModelSyncItem();

                        m.NombreClave = i.Key.ToString();

                        JObject modelJson = JObject.Parse(json[m.NombreClave].ToString());
                        m.NombreComercial = modelJson["NombreComercial"].ToString();
                        m.Marca = modelJson["Marca"].ToString();
                        m.Tipo = modelJson["Tipo"].ToString();

                        try
                        {
                            if (modelJson.ContainsKey("Procesador"))
                            {
                                m.Procesador = modelJson["Procesador"].ToString();
                                m.Frecuencia = decimal.Parse(modelJson["Frecuencia"].ToString());
                                m.RAM = int.Parse(modelJson["RAM"].ToString());
                                m.TipoAlmacenamiento = modelJson["TipoAlmacenamiento"].ToString();
                                m.AlmacenamientoHDD = int.Parse(modelJson["AlmacenamientoHDD"].ToString());
                                m.AlmacenamientoSSD = int.Parse(modelJson["AlmacenamientoSSD"].ToString());
                                m.TieneUnidadOptica = bool.Parse(modelJson["TieneUnidadOptica"].ToString());
                                m.ProfileImagePath = modelJson["ProfileImagePath"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            CommonMethodsLibrary.OutMessage("IN", "InventarioViewModel.cs", $"OCURRIO UN ERROR INESPERADO DURANTE LA LECTURA DE LOS MODELOS VINCULADOS: {ex.Message}\n{ex}", "ERR");
                        }
                        RESPONSE.Items.Add(m);
                    }
                }
                #endregion
            } catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("IN", "InventarioViewModel.cs", $"OCURRIO UN ERROR INESPERADO DURANTE LA LECTURA DE LOS MODELOS VINCULADOS: {ex.Message}\n{ex}", "ERR");
                MessageBox.Show($"Ha ocurrido un error inesperado durante la apertura del archivo '{RESPONSE.DataBaseFilePath}'! {ex.Message}\n{ex}", "Error de apertura");
            }

            return RESPONSE;
        }

        /// <summary>
        /// Guardamos los cambios del archivo o lo creamos en caso de ser necesario
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            bool RESPONSE = false;

            CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", "GUARDANDO TABLA DE VINCULACION ACTUALIZDA...", "INF");

            try
            {
                if (Items.Count > 0)
                {
                    #region CODIGO
                    string jsonDirectoryPath = $@"{Application.StartupPath}\Inventories";
                    string jsonFile = "VinculatedModels.json";

                    if (!Directory.Exists(jsonDirectoryPath))
                    {
                        Directory.CreateDirectory(jsonDirectoryPath);
                    }


                    List<string> jcontent = new List<string>();

                    foreach (MachineModelSyncItem i in Items)
                    {
                        string item_Chain = $@"
""{i.NombreClave}"" : {{
    ""NombreComercial"" : ""{i.NombreComercial}"",
    ""Marca"" : ""{i.Marca}"",
    ""Tipo"" : ""{i.Tipo}"",
    ""Procesador"" : ""{i.Procesador}"",
    ""Frecuencia"" : {i.Frecuencia},
    ""RAM"" : {i.RAM},
    ""TipoAlmacenamiento"" : ""{i.TipoAlmacenamiento}"",
    ""AlmacenamientoHDD"" : {i.AlmacenamientoHDD},
    ""AlmacenamientoSSD"" : {i.AlmacenamientoSSD},
    ""TieneUnidadOptica"" : ""{i.TieneUnidadOptica}"",
    ""ProfileImagePath"" : ""{i.ProfileImagePath}""
}}";
                        CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", $"AÑADIENDO A LA TABLA EL ELEMENTO < {i.NombreComercial} : {i.NombreClave} >", "INF");
                        jcontent.Add(item_Chain);
                    }

                    string deadContent = string.Join(",", jcontent);
                    deadContent = deadContent.Insert(0, "{").Insert(deadContent.Length, "}");

                    //string deadContent = JsonConvert.SerializeObject(this);
                    File.WriteAllText($@"{jsonDirectoryPath}\{jsonFile}", deadContent);
                    #endregion

                    RESPONSE = true;
                    CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", "TABLA DE VINCULACION ACTUALIZADA CON EXITO!", "OKA");
                } else
                {
                    // En caso de que exista el archivo, lo eliminamos ya que no hay mas equipos
                    string jsonDirectoryPath = $@"{Application.StartupPath}\Inventories";
                    string jsonFile = "VinculatedModels.json";

                    if (!Directory.Exists(jsonDirectoryPath))
                    {
                        Directory.CreateDirectory(jsonDirectoryPath);
                    }

                    if (File.Exists($@"{jsonDirectoryPath}\{jsonFile}"))
                    {
                        File.Delete($@"{jsonDirectoryPath}\{jsonFile}");
                    }
                }
            }
            catch (Exception ex)
            {
                RESPONSE = false;
            }

            return RESPONSE;
        }
    }

    public class MachineModelSyncItem
    {
        public string NombreClave { get; set; } = "";
        public string NombreComercial { get; set; } = "";
        public string Marca { get; set; } = "";
        public string Tipo { get; set; } = "";

        // Datos tecnicos
        public string Procesador { get; set; } = "";
        public decimal Frecuencia { get; set; } = 0;
        /// <summary>
        /// En Gigabytes
        /// </summary>
        public int RAM { get; set; } = 8;
        public string TipoAlmacenamiento { get; set; } = "SSD";
        /// <summary>
        /// En Gigabytes
        /// </summary>
        public int AlmacenamientoSSD { get; set; } = 128;
        /// <summary>
        /// En Gigabytes
        /// </summary>
        public int AlmacenamientoHDD { get; set; } = 500;
        public bool TieneUnidadOptica { get; set; } = false;

        public string ProfileImagePath { get; set; } = "";
    }
#endregion

    #region CLASES Y CONTROLADORES DEL HISTORIAL DE EVENTO DE LAS MAQUINAS
    public class MachineEventsHistorial
    {
        public static string FileExtension = "historial";
        public static string FileSuffix = $"_EventRecorder.{FileExtension}";

        /// <summary>
        /// Ruta del Historial de Eventos
        /// </summary>
        public string FilePath = "";
        /// <summary>
        /// Eventos del equipo indicado
        /// </summary>
        public List<M_EventItem> Events { get; } = new List<M_EventItem>();
        /// <summary>
        /// Hostname del equipo
        /// </summary>
        public string Hostname { get; set; } = "";


        /// <summary>
        /// Constructor principal del objeto. En caso de existir un archivo en el path indicado, se lee y construye el objeto, de lo contrario solo se asigna el valor de path a la propiedad FilePath
        /// </summary>
        /// <param name="path"></param>
        public MachineEventsHistorial(string path)
        {
            try
            {
                if (!String.IsNullOrEmpty(path) && File.Exists(path))
                {
                    JObject json = JObject.Parse(File.ReadAllText(path));

                    #region PARSEAMOS EL ARCHIVO DE HISTORIAL DEL EQUIPO SELECCIONADO
                    foreach (var ev in json)
                    {
                        M_EventItem obj = new M_EventItem();

                        JObject props = JObject.Parse(ev.Value.ToString());
                        obj.HASH = Int32.Parse(ev.Key.ToString());
                        obj.Title = props["Title"].ToString();
                        obj.Message = props["Message"].ToString();
                        obj.CreationDate = DateTime.Parse(props["CreationDateTime"].ToString());

                        Events.Add(obj);
                    }
                    #endregion
                }

                FilePath = path;
                FileInfo fi = new FileInfo(FilePath);
                Hostname = fi.Name.Replace(MachineEventsHistorial.FileSuffix, "");
            }
            catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("IN", "InventarioViewModel.cs", $"OCURRIO UN ERROR INESPERADO DURANTE LA LECTURA DEL HISTORIAL DE EVENTOS DE LA MAQUINA SELECCIONADA {ex.Message}\n{ex}", "ERR");
            }
        }

        public MachineEventsHistorial() { }

        /// <summary>
        /// Actualiza una grabadora de eventos ya existente en el sistema
        /// </summary>
        /// <param name="RecorderPath"></param>
        /// <param name="_Event"></param>
        public static void UpdateRecorder(string RecorderPath, M_EventItem _Event)
        {
            if (File.Exists(RecorderPath))
            {
                MachineEventsHistorial recorder = new MachineEventsHistorial(RecorderPath);
                recorder.AddEvent(_Event);
                recorder.Save();
            }
        }

        /// <summary>
        /// Añadimos un nuevo evento al historial
        /// </summary>
        public void AddEvent(M_EventItem evento)
        {
            Events.Add(evento);
        }

        /// <summary>
        /// Añadimos un nuevo evento al historial
        /// </summary>
        public void AddEvent(string _Title, string _Message, DateTime _CreationDate, int _HASH)
        {
            Events.Add(new M_EventItem()
            {
                Title = _Title,
                Message = _Message,
                CreationDate = _CreationDate,
                HASH = _HASH
            });
        }

        /// <summary>
        /// Guardamos el archivo actualizado o creamos la grabadora de eventos
        /// </summary>
        public bool Save()
        {
            bool RESPONSE = false;

            CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", $"GUARDANDO GRABADORA DE EVENTOS ACTUALIZDA DEL EQUIPO...", "INF");

            try
            {
                string jsonDirectoryPath = FilePath;

                if (!String.IsNullOrEmpty(jsonDirectoryPath)) 
                {
                    List<string> jcontent = new List<string>();

                    foreach (M_EventItem e in Events)
                    {
                        string item_Chain = $@"
""{e.HASH}"" : {{
    ""Title"" : ""{e.Title}"",
    ""Message"" : ""{e.Message}"",
    ""CreationDateTime"" : ""{e.CreationDate.ToString("g")}"",
}}";
                        CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", $"AÑADIENDO A LA GRABADORA EL EVENTO < {e.HASH} : {e.Title} >", "INF");
                        jcontent.Add(item_Chain);
                    }

                    string deadContent = string.Join(",", jcontent);
                    deadContent = deadContent.Insert(0, "{").Insert(deadContent.Length, "}");

                    File.WriteAllText(jsonDirectoryPath, deadContent);

                    RESPONSE = true;
                    CommonMethodsLibrary.OutMessage("OUT", $"InventarioViewModel.cs", $"GRABADORA DE DATOS < {jsonDirectoryPath} > ACTUALIZADA CON EXITO!", "OKA");
                }
            }
            catch (Exception ex)
            {
                RESPONSE = false;
            }

            return RESPONSE;
        }

        public void MergeHistorials(string[] historialsPaths)
        {
            // Añadimos los eventos del o los historiales que queremos fusionar
            foreach (string path in historialsPaths)
            {
                MachineEventsHistorial historial = new MachineEventsHistorial(path);
                foreach (M_EventItem e in historial.Events)
                {
                    AddEvent(e);
                }
            }

            #region CODIGO DE CLASIFICACION DE EVENTOS
            // Ordenamos la lista
            List<M_EventItem> orderedList = Events.OrderBy(e => e.CreationDate).ToList();

            // Vaciamos la lista
            Events.Clear();

            // Añadimos los eventos en orden de creacion
            foreach (M_EventItem e in orderedList)
            {
                AddEvent(e);
            }
            #endregion

            Save(); // Guardamos el archivo actualizado del historial

            // Eliminamos el/los historiales antiguos que se fusionaron
            foreach (string i in historialsPaths)
            {
                File.Delete(i);
            }
        }

    }

    /// <summary>
    /// Evento registrado de un equipo correspondiente
    /// </summary>
    public class M_EventItem
    {
        public string Title { get; set; } = "Evento Registrado";
        public string Message { get; set; } = " - N/A -";
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int HASH { get; set; } = CommonMethodsLibrary.IdentifierGenerator();


        #region PLANTILLAS DE CREACION RAPIDA DE EVENTOS
        /// <summary>
        /// Template al crear una maquina nueva y añadirla al inventario
        /// </summary>
        public static M_EventItem FromTemplate_NewMachine (string Hostname)
        {
            return new M_EventItem()
            {
                Title = $"Equipo creado y añadido",
                Message = $"Se creo el equipo en el sistema de inventarios con el hostname '{Hostname}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }

        /// <summary>
        /// Template al editar una maquina en el sistema 
        /// </summary>
        public static M_EventItem FromTemplate_UpdatedMachine(string EdittedProp, string NewPropValue)
        {
            return new M_EventItem()
            {
                Title = $"Propiedad '{NewPropValue}' modificada",
                Message = $"Se actualizo la propiedad '{EdittedProp}' con el nuevo valor '{NewPropValue}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }

        /// <summary>
        /// Template al atender un reporte de la maquina en el sistema
        /// </summary>
        public static M_EventItem FromTemplate_AttendedReport(string NoFolio, string FailureName, string TicketID)
        {
            if (string.IsNullOrEmpty(TicketID))
            {
                TicketID = "- N/A -";
            }

            return new M_EventItem()
            {
                Title = $"Reporte atendido para este equipo",
                Message = $"Se atendio un reporte con nombre de falla '{FailureName}' en el RIT con No. de Folio '{NoFolio}'; Ticket correspondiente: '{TicketID}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }

        /// <summary>
        /// Template al comprobar un reporte de la maquina en el sistema
        /// </summary>
        public static M_EventItem FromTemplate_VerifiedReport(string NoFolio, string FailureName, string TicketID)
        {
            return new M_EventItem()
            {
                Title = $"Reporte '{TicketID}' de este equipo comprobado",
                Message = $"Se comprobo el RIT con No. de Folio '{NoFolio}' sobre la falla titulada '{FailureName}' para el reporte '{TicketID}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }

        /// <summary>
        /// Template al reasignar un equipo a otro usuario
        /// </summary>
        public static M_EventItem FromTemplate_ReasignMachine(string Hostname, string OldEmployee, string NewEmployee)
        {
            return new M_EventItem()
            {
                Title = $"Equipo reasignado a otro empleado",
                Message = $"Se reasigno el equipo '{Hostname}' al usuario '{OldEmployee}' anteriormente propiedad de '{NewEmployee}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }

        /// <summary>
        /// Template al generar el resguardo de un equipo
        /// </summary>
        public static M_EventItem FromTemplate_ResguardCardMaked(string ResguardPdfPath, string NewEmployee)
        {
            FileInfo fi = new FileInfo(ResguardPdfPath);

            return new M_EventItem()
            {
                Title = $"Equipo reasignado a otro empleado",
                Message = $"Se genero el resguardo del equipo para el empleado '{NewEmployee}' en la ruta '{fi.FullName}'.",
                CreationDate = DateTime.Now,
                HASH = CommonMethodsLibrary.IdentifierGenerator(),
            };
        }
        #endregion
    }
    #endregion

    [Serializable]
    public class Template : Attribute
    {

    }



    /// <summary>
    /// Tipo de apertura del programa
    /// </summary>
    public enum AppertureType
    {
        NONE,
        BY_RIT_PROJECT_FILE,
        BY_ACTIVITY_PROJECT_FILE,
    }

    #region CLASES Y CONTROLADORES DE LOS INVENTARIOS
    public class InventarioViewModel
    {
        public string NOMBRE { get; set; }
        public string NumDeEmpleado { get; set; }
        public string EXT { get; set; }
        public string USER { get; set; }
        public string MAIL { get; set; }
        public string HOSTNAME { get; set; }
        public string TipoDeEquipo { get; set; }
        public string SN { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ubicacion { get; set; }
        public string Departamento { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaDeFabricacion { get; set; }
        public DateTime FechaDeAsignacion { get; set; }
        

        /// <summary>
        /// Leemos el archivo Excel, buscamos y obtenemos el equipo indicado segun los parametros establecidos
        /// </summary>
        /// <param name="_hostname"></param>
        /// <returns></returns>
        public static InventarioViewModel GetMachineByHostname(string _hostname)
        {
            InventarioViewModel response = null;

            List<InventarioViewModel> machinesList = new List<InventarioViewModel>();

            #region LECTURA DEL EXCEL
            string SheetBook = "USUARIOS Y EQUIPOS";
            string BOOK_PATH = $@"{Application.StartupPath}\Inventories\{SheetBook}.xlsx";

            if (Directory.Exists($@"{Application.StartupPath}\Inventories") && File.Exists($@"{Application.StartupPath}\Inventories\{SheetBook}.xlsx"))
            {
                CommonMethodsLibrary.OutMessage("IN", "InventarioViewModel.cs", $@"CARGANDO ARCHIVO DE INVENTARIO EXISTENTE '{SheetBook}' EN LA RUTA '{BOOK_PATH}'", "inf");

                // Cargamos el archivo que se creo en base al molde con anterioridad
                SLDocument sl = new SLDocument(BOOK_PATH);
                int iRow = 2;

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    InventarioViewModel oUsuario = new InventarioViewModel();

                    oUsuario.NOMBRE = sl.GetCellValueAsString(iRow, 1);
                    oUsuario.NumDeEmpleado = sl.GetCellValueAsString(iRow, 2);
                    oUsuario.EXT = sl.GetCellValueAsString(iRow, 3);
                    oUsuario.USER = sl.GetCellValueAsString(iRow, 4);
                    oUsuario.MAIL = sl.GetCellValueAsString(iRow, 5);
                    oUsuario.HOSTNAME = sl.GetCellValueAsString(iRow, 6);
                    oUsuario.TipoDeEquipo = sl.GetCellValueAsString(iRow, 7);
                    oUsuario.SN = sl.GetCellValueAsString(iRow, 8);
                    oUsuario.Marca = sl.GetCellValueAsString(iRow, 9);
                    oUsuario.Modelo = sl.GetCellValueAsString(iRow, 10);
                    oUsuario.Ubicacion = sl.GetCellValueAsString(iRow, 11);
                    oUsuario.Departamento = sl.GetCellValueAsString(iRow, 12);
                    oUsuario.Comentarios = sl.GetCellValueAsString(iRow, 13);

                    machinesList.Add(oUsuario);
                    iRow++;
                }
                #endregion

                response = machinesList.Cast<InventarioViewModel>()
                    .Where(t => t.TipoDeEquipo.Trim().ToLower() == "laptop" || t.TipoDeEquipo.Trim().ToLower() == "pc")
                    .Where(t => t.HOSTNAME.Trim().ToUpper() == _hostname.Trim().ToUpper())
                    .FirstOrDefault();
            }
            return response;
        }
     }

    public class ImpresorasViewModel
    {
        public string Impresora { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ubicacion { get; set; }
        public string IP { get; set; }
    }

    public class TonersViewModel
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
    }

    public class RefaccionesViewModel
    {
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Ubicacion { get; set; }

        /** PROXIMA REINCORPORACION **/
        //public string Comentario { get; set; }
    }
    #endregion

    public class PuestosViewModel
    {
        public string Puesto { get; set; }
        public string Division { get; set; }
        public string Localidad { get; set; }
        public string DireccionGeneralAdjunta { get; set; }
        public string Direccion { get; set; }
        public string Subdireccion { get; set; }
        public string Gerencia { get; set; }
        public string Jefatura { get; set; }
        public string CentroDeCostos { get; set; }
        public string DenominacionCentroDeCostos { get; set; }
    }

    /// <summary>
    /// Lista de departamentos de la empresa
    /// </summary>
    public class Departamentos
    {
        /// <summary>
        /// Listado de areas disponibles registrados en el archivo de configuracion local
        /// </summary>
        public readonly AutoCompleteStringCollection Lista = new AutoCompleteStringCollection()
        {
            "Proteccion Ferroviaria", "Relaciones Laborales", "Seguridad Ocupacional", "Administracion de Personal",
            "Unidades de Arrastre", "Servicios Generales", "Digital", "Ingenieria Ambiental", "Maquinaria de Via",
            "Fuerza Motriz", "Tesoreria", "Abastecimientos", "TELECOMS", "Transportes", "Mantenimiento Vehicular",
            "Relaciones con el Gobierno", "Auditoria", "Señales y Electricidad", "Infraestructura", "Diseño de Servicio",
            "Servicio al Cliente"
        };

        static string targetPath = $@"{Application.StartupPath}\Inventories\";
        static string targetFilePath = $@"{targetPath}\organization_Areas.json";

        /// <summary>
        /// Carga los datos de los departamentos registrados
        /// </summary>
        public Departamentos()
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            
            if (!File.Exists(targetFilePath))
            {
                SaveJsonCopy(targetFilePath);
            }

            // Cargamos el archivo organization_Areas.json
            JObject json = JObject.Parse(File.ReadAllText(targetFilePath));
            Lista.Clear();
            foreach (var i in json["Areas"])
            {
                Lista.Add(i.ToString());
            }
        }

        public void SaveJsonCopy(string path = null)
        {
            path = path == null ? targetFilePath : path;

            #region
            string[] defaultAreasList = new string[Lista.Count];

            int counter = 0;
            foreach (string i in Lista)
            {
                defaultAreasList[counter] = $@"""{i}""";
                counter++;
            }

            string content = $@"
{{
    ""Areas"" : [
        {String.Join(",", defaultAreasList)}
    ]
}}
".Trim();

            File.WriteAllText(path, content);
            #endregion
        }

        /// <summary>
        /// Añadimos una nueva area al registro de areas de la organizacion en la configuracion local
        /// </summary>
        public void Add(string AreaName)
        {
            string[] defaultAreasList = new string[Lista.Count + 1];

            int counter = 0;
            foreach (string i in Lista)
            {
                defaultAreasList[counter] = $@"""{i}""";
                counter++;
            }
            defaultAreasList[counter] = $@"""{AreaName}""";

            string content = $@"
{{
    ""Areas"" : [
        {String.Join(",", defaultAreasList)}
    ]
}}
".Trim();

            File.WriteAllText(targetFilePath, content);
        }

        /// <summary>
        /// Eliminamos el area indicada del registro de areas de la organizacion en la configuracion local
        /// </summary>
        public void Delete(string AreaName)
        {
            List<string> defaultAreasList = new List<string>();

            foreach (string i in Lista)
            {
                if (i.ToLower().Trim() != AreaName.ToLower().Trim())
                {
                    defaultAreasList.Add($@"""{i}""");
                }
            }

            string content = $@"
{{
    ""Areas"" : [
        {String.Join(",", defaultAreasList)}
    ]
}}
".Trim();

            File.WriteAllText(targetFilePath, content);
        }

        /// <summary>
        /// Importamos un archivo de organizacion externo a la configuracion local
        /// </summary>
        public void ImportConfig (string path)
        {
            // Reemplazamos el archivo
            File.WriteAllText(targetFilePath, File.ReadAllText(path));
        }
    }

    #region CLASES Y CONTROLADORES DEL OBJETO USUARIO
    // Objeto "Usuario"
    public class Usuario
    {
        public string Nombre { get; set; }
        public string NoEmpleado { get; set; }
        public string Extension { get; set; }
        public string Red { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }

        /// <summary>
        /// Crea el bjeto extrayendo los datos de la carta existente
        /// </summary>
        /// <param name="CardPath"></param>
        /// <returns>El objeto construido con los datos pertinentes</returns>
        public static Usuario GetFromCard(string CardPath)
        {
            Usuario user = new Usuario(); // Declaracion de objeto usuario actual seleccionado

            if (File.Exists(CardPath)) {
                string json_card = File.ReadAllText(CardPath);
                JObject json_parsed = JObject.Parse(json_card);

                user.Nombre = json_parsed["nombre"].ToString();
                user.NoEmpleado = json_parsed["no_empleado"].ToString();
                user.Extension = json_parsed["extension"].ToString();
                user.Red = json_parsed["red_user"].ToString();
                user.Email = json_parsed["mail"].ToString();
                user.Departamento = json_parsed["departamento"].ToString();
                user.Localidad = json_parsed["localidad_asignada"].ToString();
            } else
            {
                MessageBox.Show($"El archivo '{CardPath}' no existe en la ruta especificada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return user;
        }
    }
    #endregion

    #region CLASES Y CONTROLADORES DE LOS PROYECTOS RIT
    public class RitJsonProject
    {
        /*
         * Version actual de Json Sintaxis : 1.5
         */

        public static string FileExtension = "ritproj";
        public string FilePath = "";

        /// <summary>
        /// Version de sintaxis del archivo de proyecto
        /// </summary>
        public string FileVersion = "1.5";  // Version por defecto
        /// <summary>
        /// Nombre del proyecto, es decir nombre del archivo JSON
        /// </summary>
        public string NombreProyecto { get; set; }
        /// <summary>
        /// Path del archivo PDF
        /// </summary>
        public string PdfPath { get; set; }
        public string NoFolio { get; set; }
        public string Falla { get; set; } = "";
        public string NoTicket { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NoSerie { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaDeGeneracionReporte { get; set; }
        public string HoraReporte { get; set; }
        public string MinutoReporte { get; set; }
        public string Sucursal { get; set; }
        public string NoSucursal { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string UsuarioFinal {  get; set; }
        public string Departamento {  get; set; }
        public string NoEmpleado { get; set; }
        public string Telefono { get; set; }
        public string CentroServicios { get; set; }
        public string Tecnico { get; set; }
        public bool UsaronRefacciones { get; set; }
        public string RefaccionUtilizada { get; set; }
        public string HoraInicioTraslado { get; set; }
        public string MinutoInicioTraslado { get; set; }
        public string HoraLlegada { get; set; }
        public string MinutoLlegada { get; set; }
        public string HoraRetorno { get; set; }
        public string MinutoRetorno { get; set; }
        public bool ReporteCerrado { get; set; }
        public string CausaPendiente { get; set; }
        public DateTime FechaDeAtencion { get; set; }
        public string HoraTermino { get; set; }
        public string MinutoTermino { get; set; }
        public string HoraComienzo { get; set; }
        public string MinutoComienzo { get; set; }
        public string HoraEspera {  get; set; }
        public string MinutoEspera { get; set; }
        public string[] AccionesRealizadas { get; set; }
        
        public bool IsAlreadyTicketGenerated { get; set; } = false;
        public bool IsRitAlreadyPrinted { get; set; } = false;
        public bool IsRitAlreadySigned { get; set; } = false;
        public bool IsRitAlreadyComprobado { get; set; } = false;
        public int HASH { get; set; } = 000000;
        public string Hostname { get; set; }

        public bool IsProjectSaved { get; set; } = false;

        private static bool parseInt2Bool (int value)
        {
            bool response = false;
            if (value == 1)
            {
                response = true;
            }

            return response;
        }

        private static int parseBool2Int (bool value)
        {
            int response = 0;
            if (value == true)
            {
                response = 1;
            }

            return response;
        }

        /// <summary>
        /// Actualiza las propiedades del objeto en base a lo llenado en el formulario indicado
        /// </summary>
        /// <param name="frm"></param>
        public void FillUpdate(rit_mdi_form frm)
        {
            /*
             * No actualizamos el nombre del proyecto debido a que ya se establece
             * en la llamada del objeto
             */
            //NombreProyecto = frm.
            NoFolio = frm.richTextBoxContadorDeRIT.Text;
            Falla = frm.txtFallaReportada.Text;
            NoTicket = frm.txtNoDeReporteDelCliente.Text;
            TipoEquipo = frm.txtTipoDeEquipo.Text;
            Marca = frm.txtMarca.Text;
            Modelo = frm.txtModelo.Text;
            NoSerie = frm.txtNoDeSerie.Text;
            Cliente = frm.txtCliente.Text;
            FechaDeGeneracionReporte = frm.calendarFecha.SelectionStart;
            HoraReporte = frm.txtHora.Text;
            MinutoReporte = frm.txtMinuto.Text;
            Sucursal = frm.txtSucursal.Text;
            NoSucursal = frm.txtNoDeSucursal.Text;
            Direccion = frm.txtDireccion.Text;
            Poblacion = frm.cboxPoblacion.Text;
            UsuarioFinal = frm.cboxUsuariofinal.Text;
            Departamento = frm.txtDepartamento.Text;
            NoEmpleado = frm.txtNoDeEmpleado.Text;
            Telefono = frm.txtTelefono.Text;
            CentroServicios = frm.txtCentroDeServicios.Text;
            Tecnico = frm.txtTecnico.Text;
            if (frm.rbtnRefaccionesSi.Checked)
            {
                UsaronRefacciones = true;
            } else
            {
                UsaronRefacciones = false;
            }
            RefaccionUtilizada = frm.txtRefaccionesUtilizadas.Text;
            HoraInicioTraslado = frm.txtHoraInicioTraslado.Text;
            MinutoInicioTraslado = frm.txtMinutoInicioTraslado.Text;
            HoraLlegada = frm.txtHoraLlegada.Text;
            MinutoLlegada = frm.txtMinutoLlegada.Text;
            HoraRetorno = frm.txtHoraDeRetorno.Text;
            MinutoRetorno = frm.txtMinutoDeRetorno.Text;
            if (frm.rbtnReporteCerradoSi.Checked)
            {
                ReporteCerrado = true;
            }
            else
            {
                ReporteCerrado = false;
            }
            CausaPendiente = frm.txtCausasDeNoCierre.Text;
            FechaDeAtencion = frm.calendarFechaDeServicio.SelectionStart;
            HoraTermino = frm.txtHoraDeTermino.Text;
            MinutoTermino = frm.txtMinutoDeTermino.Text;
            HoraComienzo = frm.txtHoraDeComienzo.Text;
            MinutoComienzo = frm.txtMinutoDeComienzo.Text;
            HoraEspera = frm.txtHoraDeEspera.Text;
            MinutoEspera = frm.txtMinutoDeEspera.Text;
            AccionesRealizadas = new string[7];
            AccionesRealizadas[0] = frm.txtLinea1.Text;
            AccionesRealizadas[1] = frm.txtLinea2.Text;
            AccionesRealizadas[2] = frm.txtLinea3.Text;
            AccionesRealizadas[3] = frm.txtLinea4.Text;
            AccionesRealizadas[4] = frm.txtLinea5.Text;
            AccionesRealizadas[5] = frm.txtLinea6.Text;
            AccionesRealizadas[6] = frm.txtLinea6.Text;

            IsAlreadyTicketGenerated = frm.IsAlreadyTicketGenerated;
            IsRitAlreadyPrinted = frm.IsRitAlreadyPrinted;
            IsRitAlreadySigned = frm.IsRitAlreadySigned;
            IsRitAlreadyComprobado = frm.IsRitAlreadyComprobado;

            Hostname = frm.txtHostname.Text.Trim();
        }

        /// <summary>
        /// Guarda el objeto actual en formato de proyecto JSON
        /// <br></br>
        /// FileVersion actual: 1.5
        /// </summary>
        /// <param name="ProjectPath">Ruta donde se guardara el archivo (incluyendo la extension *.json)</param>
        public void SaveProject (string ProjectPath)
        {
            try
            {
                Dictionary<string, string> ticketContent = new Dictionary<string, string>();

                #region GUARDADO DE DATOS EN EL DICCIONARIO
                ticketContent.Add("file_ver", FileVersion);
                // Informacion del proyecto
                ticketContent.Add("nombre_proyecto", NombreProyecto);
                //MessageBox.Show(PROJ_PATH);
                ticketContent.Add("path_pdf", PdfPath);

                /** INFORMACION DEL REPORTE **/
                ticketContent.Add("no_folio", NoFolio);
                ticketContent.Add("falla", Falla);
                ticketContent.Add("no_ticket", NoTicket);
                ticketContent.Add("tipo_equipo", TipoEquipo);
                ticketContent.Add("marca", Marca);
                ticketContent.Add("modelo", Modelo);
                ticketContent.Add("no_serie", NoSerie);
                ticketContent.Add("cliente", Cliente);
                ticketContent.Add("hora_reporte", HoraReporte);
                ticketContent.Add("min_reporte", MinutoReporte);
                ticketContent.Add("sucursal", Sucursal);
                ticketContent.Add("no_sucursal", NoSucursal);
                ticketContent.Add("direccion", Direccion);
                ticketContent.Add("poblacion", Poblacion);
                ticketContent.Add("usuario_final", UsuarioFinal);
                ticketContent.Add("departamento", Departamento);
                ticketContent.Add("no_empleado", NoEmpleado);
                ticketContent.Add("telefono", Telefono);
                ticketContent.Add("centro_servicios", CentroServicios);
                ticketContent.Add("tecnico", Tecnico);
                
                // Fecha de reporte
                DateTime inicio = FechaDeGeneracionReporte;

                string dia_reporte = inicio.Day.ToString();
                string mes_reporte = inicio.Month.ToString();
                string año_reporte = inicio.Year.ToString();

                ticketContent.Add("dia_reporte", dia_reporte);
                ticketContent.Add("mes_reporte", mes_reporte);
                ticketContent.Add("ano_reporte", año_reporte);


                /** INFORMACION DEL TRABAJO Y FINALIZACION **/
                ticketContent.Add("refacciones", $"{parseBool2Int(UsaronRefacciones)}");
                ticketContent.Add("refaccion_utilizada", RefaccionUtilizada);

                ticketContent.Add("hora_inicio_traslado", HoraInicioTraslado);
                ticketContent.Add("minuto_inicio_traslado", MinutoInicioTraslado);

                ticketContent.Add("hora_llegada", HoraLlegada);
                ticketContent.Add("minuto_llegada", MinutoLlegada);

                ticketContent.Add("hora_comienzo", HoraComienzo);
                ticketContent.Add("minuto_comienzo", MinutoComienzo);

                ticketContent.Add("hora_termino", HoraTermino);
                ticketContent.Add("minuto_termino", MinutoTermino);

                ticketContent.Add("hora_espera", HoraEspera);
                ticketContent.Add("minuto_espera", MinutoEspera);

                ticketContent.Add("hora_retorno", HoraRetorno);
                ticketContent.Add("minuto_retorno", MinutoRetorno);

                ticketContent.Add("reporte_cerrado", $"{parseBool2Int(ReporteCerrado)}");
                ticketContent.Add("causa_pendiente", CausaPendiente);

                // Fecha de reporte
                DateTime atencion = FechaDeAtencion;

                string dia_atencion = atencion.Day.ToString();
                string mes_atencion = atencion.Month.ToString();
                string año_atencion = atencion.Year.ToString();

                ticketContent.Add("dia_atencion", dia_atencion);
                ticketContent.Add("mes_atencion", mes_atencion);
                ticketContent.Add("ano_atencion", año_atencion);


                /** ACIONES TOMADAS **/
                for (int i = 0; i < 7; i++)
                {
                    ticketContent.Add($"ACCION_LINEA{i + 1}", AccionesRealizadas[i]);
                }

                ticketContent.Add("IsAlreadyTicketGenerated", parseBool2Int(IsAlreadyTicketGenerated).ToString());
                ticketContent.Add("IsRitAlreadyPrinted", parseBool2Int(IsRitAlreadyPrinted).ToString());
                ticketContent.Add("IsRitAlreadySigned", parseBool2Int(IsRitAlreadySigned).ToString());
                ticketContent.Add("IsRitAlreadyComprobado", parseBool2Int(IsRitAlreadyComprobado).ToString());
                ticketContent.Add("HASH", HASH.ToString());
                ticketContent.Add("Hostname", Hostname);
                #endregion

                string finalJson = System.Text.Json.JsonSerializer.Serialize(ticketContent);

                File.WriteAllText($"{ProjectPath}", finalJson);
                IsProjectSaved = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de guardar el archivo < {ProjectPath} >!\n{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Construye el objeto en base a un proyecto seleccionado
        /// </summary>
        /// <param name="ProjectPath">Ruta del archivo de proyecto JSON a cargar</param>
        /// <returns></returns>
        public static RitJsonProject LoadProject(string ProjectPath)
        {
            RitJsonProject project = new RitJsonProject();

            try
            {
                string json_file = File.ReadAllText($@"{ProjectPath}");
                JObject json = JObject.Parse(json_file);

                if (json.ContainsKey("file_ver"))
                {
                    project.FileVersion = json["file_ver"].ToString();
                } else
                {
                    /* 
                     * En caso de que no contenga el indicador, significa que es la version
                     * inicial del proyecto
                     * */
                    project.FileVersion = "1.4";
                }

                // Cargamos el archivo segun la version del proyecto
                switch (project.FileVersion)
                {
                    case "1.4":
                        #region CARGA Y PARSEO DE DATOS
                        project.NombreProyecto = json.ContainsKey("nombre_proyecto") ? json["nombre_proyecto"].ToString() : "";
                        project.PdfPath = json.ContainsKey("path_pdf") ? json["path_pdf"].ToString() : "";
                        project.NoFolio = json["no_folio"].ToString();
                        project.Falla = json["falla"].ToString();
                        project.NoTicket = json["no_ticket"].ToString();
                        project.TipoEquipo = json["tipo_equipo"].ToString();
                        project.Marca = json["marca"].ToString();
                        project.Modelo = json["modelo"].ToString();
                        project.NoSerie = json["no_serie"].ToString();
                        project.Cliente = json["cliente"].ToString();
                        #region PARSEO DE FECHA DE GENERACION DEL REPORTE
                        DateTime generacion_reporte = DateTime.Parse($"{json["dia_reporte"]}/{json["mes_reporte"]}/{json["ano_reporte"]}");
                        #endregion
                        project.HoraReporte = json["hora_reporte"].ToString();
                        project.MinutoReporte = json["min_reporte"].ToString();
                        project.FechaDeGeneracionReporte = generacion_reporte;
                        project.Sucursal = json["sucursal"].ToString();
                        project.NoSucursal = json["no_sucursal"].ToString();
                        project.Direccion = json["direccion"].ToString();
                        project.Poblacion = json["poblacion"].ToString();
                        project.UsuarioFinal = json["usuario_final"].ToString();
                        project.Departamento = json["departamento"].ToString();
                        project.NoEmpleado = json["no_empleado"].ToString();
                        project.Telefono = json["telefono"].ToString();
                        project.CentroServicios = json["centro_servicios"].ToString();
                        project.Tecnico = json["tecnico"].ToString();
                        project.UsaronRefacciones = parseInt2Bool(Int32.Parse(json["refacciones"].ToString()));
                        project.RefaccionUtilizada = json["refaccion_utilizada"].ToString();
                        project.HoraInicioTraslado = json["hora_inicio_traslado"].ToString();
                        project.MinutoInicioTraslado = json["minuto_inicio_traslado"].ToString();
                        #region PARSEO DE FECHA DE ATENCION DEL REPORTE
                        DateTime fechaAtencion = DateTime.Parse($"{json["dia_atencion"]}/{json["mes_atencion"]}/{json["ano_atencion"]}");
                        #endregion
                        project.FechaDeAtencion = fechaAtencion;
                        project.HoraLlegada = json["hora_llegada"].ToString();
                        project.MinutoLlegada = json["minuto_llegada"].ToString();
                        project.HoraComienzo = json["hora_comienzo"].ToString();
                        project.MinutoComienzo = json["minuto_comienzo"].ToString();
                        project.HoraTermino = json["hora_termino"].ToString();
                        project.MinutoTermino = json["minuto_termino"].ToString();
                        project.HoraEspera = json["hora_espera"].ToString();
                        project.MinutoEspera = json["minuto_espera"].ToString();
                        project.HoraRetorno = json["hora_retorno"].ToString();
                        project.MinutoRetorno = json["minuto_retorno"].ToString();
                        project.ReporteCerrado = parseInt2Bool(Int32.Parse(json["reporte_cerrado"].ToString()));
                        project.CausaPendiente = json["causa_pendiente"].ToString();
                        #region PARSEO DE LAS LINEAS DE ACCION DEL REPORTE
                        string[] actionLines = new string[7];
                        for (int i = 0; i < 7; i++)
                        {
                            actionLines[i] = json[$"ACCION_LINEA{i + 1}"].ToString();
                        }
                        #endregion
                        project.AccionesRealizadas = actionLines;
                        #endregion
                        break;
                    case "1.5":
                        #region CARGA Y PARSEO DE DATOS
                        project.NombreProyecto = json.ContainsKey("nombre_proyecto") ? json["nombre_proyecto"].ToString() : "";
                        project.PdfPath = json["path_pdf"].ToString();
                        project.NoFolio = json["no_folio"].ToString();
                        project.Falla = json["falla"].ToString();
                        project.NoTicket = json["no_ticket"].ToString();
                        project.TipoEquipo = json["tipo_equipo"].ToString();
                        project.Marca = json["marca"].ToString();
                        project.Modelo = json["modelo"].ToString();
                        project.NoSerie = json["no_serie"].ToString();
                        project.Cliente = json["cliente"].ToString();
                        #region PARSEO DE FECHA DE GENERACION DEL REPORTE
                        DateTime generacion_reporte_15 = DateTime.Parse($"{json["dia_reporte"]}/{json["mes_reporte"]}/{json["ano_reporte"]}");
                        #endregion
                        project.HoraReporte = json["hora_reporte"].ToString();
                        project.MinutoReporte = json["min_reporte"].ToString();
                        project.FechaDeGeneracionReporte = generacion_reporte_15;
                        project.Sucursal = json["sucursal"].ToString();
                        project.NoSucursal = json["no_sucursal"].ToString();
                        project.Direccion = json["direccion"].ToString();
                        project.Poblacion = json["poblacion"].ToString();
                        project.UsuarioFinal = json["usuario_final"].ToString();
                        project.Departamento = json["departamento"].ToString();
                        project.NoEmpleado = json["no_empleado"].ToString();
                        project.Telefono = json["telefono"].ToString();
                        project.CentroServicios = json["centro_servicios"].ToString();
                        project.Tecnico = json["tecnico"].ToString();
                        project.UsaronRefacciones = parseInt2Bool(Int32.Parse(json["refacciones"].ToString()));
                        project.RefaccionUtilizada = json["refaccion_utilizada"].ToString();
                        project.HoraInicioTraslado = json["hora_inicio_traslado"].ToString();
                        project.MinutoInicioTraslado = json["minuto_inicio_traslado"].ToString();
                        #region PARSEO DE FECHA DE ATENCION DEL REPORTE
                        DateTime fechaAtencion_15 = DateTime.Parse($"{json["dia_atencion"]}/{json["mes_atencion"]}/{json["ano_atencion"]}");
                        #endregion
                        project.FechaDeAtencion = fechaAtencion_15;
                        project.HoraLlegada = json["hora_llegada"].ToString();
                        project.MinutoLlegada = json["minuto_llegada"].ToString();
                        project.HoraComienzo = json["hora_comienzo"].ToString();
                        project.MinutoComienzo = json["minuto_comienzo"].ToString();
                        project.HoraTermino = json["hora_termino"].ToString();
                        project.MinutoTermino = json["minuto_termino"].ToString();
                        project.HoraEspera = json["hora_espera"].ToString();
                        project.MinutoEspera = json["minuto_espera"].ToString();
                        project.HoraRetorno = json["hora_retorno"].ToString();
                        project.MinutoRetorno = json["minuto_retorno"].ToString();
                        project.ReporteCerrado = parseInt2Bool(Int32.Parse(json["reporte_cerrado"].ToString()));
                        project.CausaPendiente = json["causa_pendiente"].ToString();
                        #region PARSEO DE LAS LINEAS DE ACCION DEL REPORTE
                        string[] actionLines_15 = new string[7];
                        for (int i = 0; i < 7; i++)
                        {
                            actionLines_15[i] = json[$"ACCION_LINEA{i + 1}"].ToString();
                        }
                        #endregion
                        project.AccionesRealizadas = actionLines_15;

                        try
                        {
                            project.IsAlreadyTicketGenerated = parseInt2Bool(Int32.Parse(json["IsAlreadyTicketGenerated"].ToString()));
                            project.IsRitAlreadyPrinted = parseInt2Bool(Int32.Parse(json["IsRitAlreadyPrinted"].ToString()));
                            project.IsRitAlreadySigned = parseInt2Bool(Int32.Parse(json["IsRitAlreadySigned"].ToString()));
                            project.IsRitAlreadyComprobado = parseInt2Bool(Int32.Parse(json["IsRitAlreadyComprobado"].ToString()));
                        } catch (Exception ex) 
                        {
                            project.IsAlreadyTicketGenerated = false;
                            project.IsAlreadyTicketGenerated = false;
                            project.IsAlreadyTicketGenerated = false;
                            project.IsAlreadyTicketGenerated = false;
                        }

                        if (json.ContainsKey("HASH"))
                        {
                            project.HASH = Int32.Parse(json["HASH"].ToString());
                        } else
                        {
                            project.HASH = CommonMethodsLibrary.IdentifierGenerator();
                        }

                        if (json.ContainsKey("Hostname"))
                        {
                            project.Hostname = json["Hostname"].ToString();
                        }
                        #endregion
                        break;
                }

                project.FilePath = ProjectPath;
                project.IsProjectSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de cargar el archivo!\n{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return project;
        }
    }
    #endregion

    public enum InventoryClass
    {
        UsuariosYEquipos,
        Refacciones,
        Toners,
        Impresoras,
    }

    #region CLASES Y CONTROLADORES DE LAS ACTIVIDADES
    public class Actividad
    {
        public string Nombre { get; set; }
        public InventoryClass InventarioSeleccionado { get; set; }
        public List<Inventario4ActViewModel> ListaEquipos { get; set; }
        public List<ImpresorasViewModel> ListaImpresoras { get; set; }
        public List<RefaccionesViewModel> ListaRefacciones { get; set; }
        public List<TonersViewModel> ListaToners { get; set; }
        public string Descripcion { get; set; }
        public string PasosARealizar { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public int EquiposTotales { get; set; }
        public int EquiposProgresados { get; set; }
        public int HASH { get; set; }
    }

    public class Inventario4ActViewModel : InventarioViewModel
    {
        /// <summary>
        /// Indicador de si el equipo fue completado o no
        /// </summary>
        public bool IsMachineReady { get; set; }
        /// <summary>
        /// Numero de elemento en la lista
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ID del ticket en SAS GMXT
        /// </summary>
        public string TicketID { get; set; }
        /// <summary>
        /// Nombre del archivo RIT PDF correspondiente al equipo incluyendo la extension .pdf
        /// </summary>
        public string PDFRitName { get; set; }
        /// <summary>
        /// Contenido Byte del PDF correspondiente al equipo
        /// </summary>
        public byte[] PDFRitContent { get; set; }
        /// <summary>
        /// Nombre del archivo de evidencia correspondiente al equipo en la actividad incluyendo la extension correspondiente
        /// </summary>
        public string EvidenciaName { get; set; }
        /// <summary>
        /// Contenido Byte del archivo de evidncia correspondiente al equipo
        /// </summary>
        public byte[] EvidenciaContent { get; set; }
        /// <summary>
        /// Notas de la actividad relacionadas al equipo
        /// </summary>
        public string Notas {  get; set; }
        public int HASH { get; set; }


        public static Inventario4ActViewModel ParseFromBaseModel(InventarioViewModel Machine)
        {
            Inventario4ActViewModel objTranslate = new Inventario4ActViewModel();
            objTranslate.NOMBRE = Machine.NOMBRE;
            objTranslate.NumDeEmpleado = Machine.NumDeEmpleado;
            objTranslate.EXT = Machine.EXT;
            objTranslate.USER = Machine.USER;
            objTranslate.MAIL = Machine.MAIL;
            objTranslate.HOSTNAME = Machine.HOSTNAME;
            objTranslate.TipoDeEquipo = Machine.TipoDeEquipo;
            objTranslate.SN = Machine.SN;
            objTranslate.Marca = Machine.Marca;
            objTranslate.Modelo = Machine.Modelo;
            objTranslate.Ubicacion = Machine.Ubicacion;
            objTranslate.Departamento = Machine.Departamento;
            objTranslate.Comentarios = Machine.Comentarios;

            return objTranslate;
        }
    }
    #endregion

    #region CLASES Y CONTROLADORES DE LAS LISTAS TO DO
    public class ToDoList
    {
        public string Title { get; set; } = "Nueva lista de Pendientes";
        public List<ToDoListItem> Items { get; set; } = new List<ToDoListItem>();
        public string Description { get; set; } = "";
        public string FilePath { get; set; } = "";
        public int HASH { get; set; } = CommonMethodsLibrary.IdentifierGenerator();

        /// <summary>
        /// Construye el objeto apartir del archivo de proyecto de listado
        /// </summary>
        /// <param name="path">ruta del archivo del proyecto</param>
        /// <returns></returns>
        public static ToDoList BuildObject(string path)
        {
            ToDoList RESPONSE = new ToDoList();

            try
            {
                JObject json = JObject.Parse(File.ReadAllText(path));

                RESPONSE.Title = json["Title"].ToString();
                foreach (var i in json["Items"])
                {
                    JObject j_item = JObject.Parse(i.ToString());

                    ToDoListItem item = new ToDoListItem();
                    item.ID = Int32.Parse(j_item["ID"].ToString());
                    item.Title = j_item["Title"].ToString();
                    item.Message = j_item["Message"].ToString();
                    item.Notes = j_item["Notes"].ToString();
                    item.Finished = bool.Parse(j_item["Finished"].ToString());

                    RESPONSE.Items.Add(item);
                }
                RESPONSE.Description = json["Description"].ToString();
                RESPONSE.FilePath = path;
                RESPONSE.HASH = Int32.Parse(json["HASH"].ToString());
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado en la lectura del JSON y creacion del objeto! {ex.Message}\n{ex}", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return RESPONSE;
        }

        /// <summary>
        /// Guarda el objeto en su archivo de proyecto correspondiente. Si no esta creado en la ruta especificada, lo guarda
        /// </summary>
        public void Save()
        {
            try
            {
                string content = JsonConvert.SerializeObject(this);
                File.WriteAllText(FilePath, content);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado durante el guardado del archivo! {ex.Message}\n\n{ex}");
            }
        }
    }

    public class ToDoListItem
    {
        public int ID { get; set; } = 1;
        public string Title { get; set; } = "Pendiente por hacer";
        public string Message { get; set; } = "";
        public string Notes { get; set; } = "";
        public bool Finished { get; set; } = false;
    }
    #endregion

    #region CLASES Y CONTROLADORES DE EL TRACKEO DE GUIAS
    public class TrackWayBillsFile
    {
        public static string extension = "trackfile";
        public List<WayBillData> WayBills { get; set; } = new List<WayBillData>();
        public string FilePath { get; set; } = "";
        
        public TrackWayBillsFile()
        {
            FilePath = $@"{Application.StartupPath}\Inventories\WayBillNumbers_TrackFile.{extension}";
        }

        public TrackWayBillsFile(string path)
        {
            FilePath = path;
            JObject json = JObject.Parse(File.ReadAllText(path));

            foreach (var i in json["WayBills"])
            {
                JObject data = JObject.Parse(i.ToString());

                WayBillData w = new WayBillData()
                {
                    Titulo = data["Titulo"].ToString(),
                    WayBill = data["WayBill"].ToString(),
                    Descripcion = data["Descripcion"].ToString(),
                    Recibida = bool.Parse(data["Recibida"].ToString())
                };

                if (Enum.TryParse(data["Paqueteria"].ToString(), true, out Paqueteria paq))
                {
                    w.Paqueteria = paq;
                } else
                {
                    w.Paqueteria = Paqueteria.NONE;
                }

                WayBills.Add(w);
            }
        }

        public void Save()
        {
            try
            {
                string content = JsonConvert.SerializeObject(this);
                File.WriteAllText(FilePath, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado durante el guardado del archivo! {ex.Message}\n\n{ex}");
            }
        }
    }

    public enum Paqueteria
    {
        NONE,
        DHL,
        FEDEX,
        PAQUETEXPRESS
    }

    public class WayBillData
    {
        public string Titulo { get; set; } = "";
        public string WayBill { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public Paqueteria Paqueteria { get; set; } = Paqueteria.NONE;
        public bool Recibida { get; set; } = false;
    }
    #endregion

    #region CLASES Y CONTROLADORES DE LOS TAGS DE INFORMACION
    public class InfoTag
    {
        public string Tag { get; set; } = "";
        public string Value { get; set; } = "";
    }

    public class TagsInformativos
    {
        public static List<InfoTag> Lista = new List<InfoTag>()
        {
            new InfoTag()
            {
                Tag = "",
                Value = ""
            },

        };
    }
    #endregion

    #region CLASES Y CONTROLADORES DEL ARCHIVO DE ESTADISTICAS MENSUALES
    public class MensualStadistics
    {
        public string FilePath = "";
        public List<AnualData> Registro { get; set; }

        public static string CapitalizarPrimeraLetra(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
                return palabra;

            // Convierte la primera letra a mayúscula y concatena el resto de la palabra
            return char.ToUpper(palabra[0]) + palabra.Substring(1);
        }

        /// <summary>
        /// Construimos el archivo de estadisticas, y en caso de no existir, creamos un objeto nuevo
        /// </summary>
        /// <returns></returns>
        public static MensualStadistics Get()
        {
            MensualStadistics RESPONSE = new MensualStadistics();

            string target_dir = $@"{Application.StartupPath}\Inventories";
            string targetPath = $@"{target_dir}\MonthlyStatics.json";
            RESPONSE.FilePath = targetPath;

            if (!Directory.Exists(target_dir))
            {
                Directory.CreateDirectory(target_dir);
            }

            if (!File.Exists(targetPath))
            {
                // En caso de que no exista, creamos un objeto nuevo
                List<AnualData> das = new List<AnualData>();

                das.Add(new AnualData()
                {
                    YearData = new Dictionary<int, List<MonthlyData>>()
                    {
                        { Int32.Parse(DateTime.Now.Year.ToString()), new List<MonthlyData>()
                            {
                                new MonthlyData()
                                {
                                    Mes = CapitalizarPrimeraLetra(DateTime.Now.ToString("MMMM")),
                                    DataReports = new List<ReportStData>()
                                }
                            }
                        }
                    }
                });

                RESPONSE.Registro = das;
                RESPONSE.Save();
            }
            else
            {
                try
                {
                    // En caso de que si exista, leemos el archivo
                    string json = File.ReadAllText(targetPath);
                    MensualStadistics obj = JsonConvert.DeserializeObject<MensualStadistics>(json);
                    RESPONSE = obj;
                    RESPONSE.FilePath = targetPath;
                } catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            return RESPONSE;
        }

        public class AnualData
        {
            public Dictionary<int, List<MonthlyData>> YearData { get; set; }
        }

        public class MonthlyData
        {
            public string Mes { get; set; }
            public List<ReportStData> DataReports { get; set; }
        }

        public class ReportStData
        {
            public string FallaReportada { get; set; }
            public string NoDeFolio { get; set; }
            public string NoDeReporte { get; set; }
            /// <summary>
            /// Reporte impreso
            /// </summary>
            public bool IsPrinted { get; set; }
            /// <summary>
            /// Reporte firmado
            /// </summary>
            public bool IsSigned { get; set; }
            /// <summary>
            /// Generado en SAS
            /// </summary>
            public bool IsGenerated { get; set; }
            /// <summary>
            /// Reporte comprobado en Forms
            /// </summary>
            public bool IsProved { get; set; }
            public int HASH {  get; set; }
        }

        /// <summary>
        /// Guardamos el objeto en el archivo correspondiente
        /// </summary>
        public void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this);
                //MessageBox.Show(json);
                File.WriteAllText(this.FilePath, json);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado con el guardado del objeto! {ex.Message}\n{ex}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualizamos o añadimos la informacion de las estadisticas mensuales de un reporte
        /// </summary>
        /// <param name="_Year">Año del reporte</param>
        /// <param name="_Month">Mes del reporte</param>
        /// <param name="_HASH">Identificador HASH del reporte</param>
        /// <param name="_Data">Informacion del Reporte a actualizar/añadir segun sea el caso</param>
        public static void UpdateMonthData(int _Year, string _Month, int _HASH, ReportStData _Data)
        {
            MensualStadistics actual_stats = MensualStadistics.Get();

            bool yearExist = false;
            foreach (AnualData i in actual_stats.Registro)
            {
                foreach (int i_year in i.YearData.Keys)
                {
                    // Comprobamos que sea el año indicado
                    if (i_year == _Year)
                    {
                        yearExist = true;

                        bool monthExist = false;
                        foreach (MonthlyData i_month in i.YearData[i_year])
                        {
                            // Comprobamos que sea del mes indicado
                            if (i_month.Mes.ToLower() == _Month.ToLower())
                            {
                                monthExist = true;
                                ReportStData targetReport = null;

                                int index = 0;
                                // Comprobamos que sea el reporte indicado
                                foreach (ReportStData report in i_month.DataReports)
                                {
                                    if (report.HASH == _HASH)
                                    {         
                                        targetReport = report;
                                        break;
                                    }
                                    index++;
                                }

                                
                                if (targetReport == null)
                                {
                                    // En caso de que no exista el reporte registrado en el archivo DB,
                                    // lo ingresamos y actualizamos el archivo
                                    i_month.DataReports.Add(_Data);
                                }
                                else
                                {
                                    // En caso de que si exista el reporte registrado en el archivo DB,
                                    // actualizamos la informacion y posteriormente el archivo

                                    i_month.DataReports[index] = _Data;
                                }
                            }
                        }

                        // En caso de que el mes requerido no exista en el registro de la DB, 
                        // Lo creamos y ademas tambien añadimos los valores de data
                        if (!monthExist)
                        {
                            MonthlyData mes = new MonthlyData()
                            {
                                Mes = CapitalizarPrimeraLetra(_Month)
                            };
                            mes.DataReports = new List<ReportStData>() { _Data };
                            i.YearData[i_year].Add(mes);
                        }
                    }
                }
            }

            if (!yearExist)
            {
                actual_stats.Registro.Add(new AnualData()
                {
                    YearData = new Dictionary<int, List<MonthlyData>>()
                        {
                            { _Year , new List<MonthlyData>()
                                {
                                    new MonthlyData()
                                    {
                                        Mes = CapitalizarPrimeraLetra(_Month),
                                        DataReports = new List<ReportStData>() { _Data }
                                    }
                                }
                            }
                        }
                });
            }

            actual_stats.Save();
        }
    }
    #endregion
}
