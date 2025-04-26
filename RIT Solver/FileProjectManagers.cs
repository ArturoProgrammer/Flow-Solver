using DocumentFormat.OpenXml.Presentation;
using Microsoft.Vbe.Interop;
using Newtonsoft.Json;
using RIT_Solver;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.IO.Compression;
using System.Windows.Forms;
using System.IO.Packaging;
using iTextSharp.text.pdf.codec;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Xml.Serialization.Configuration;
using Newtonsoft.Json.Linq;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices.ComTypes;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Windows.Media.Converters;
using CefSharp.DevTools.IO;

namespace FileProjectManager
{
    /// <summary>
    /// Clase definicion del objeto Proyecto de RIT
    /// </summary>
    public class RitProj
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OriginPath">Ruta absoluta del origen de la carpeta de proyecto que se comprimira</param>
        /// <param name="DestinyPath">Ruta absoluta del destino donde se guardara el archivo</param>
        public static void Compress(string OriginPath, string DestinyPath)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DestinyPath">Ruta absoluta del destino donde se guardara el archivo</param>
        /// <returns></returns>
        public RitProj Decompress(string DestinyPath)
        {
            RitProj response = new RitProj();



            return response;
        }
    }

    /// <summary>
    /// Clase definicion del objeto Proyecto de Actividad
    /// </summary>
    public partial class ActProj
    {
        public const string _FileExtension = ".actproj";

        public Actividad _Actividad { get; set; }
        /// <summary>
        /// Ruta path actual del archivo de proyecto
        /// </summary>
        internal string RootPath = "";
        /// <summary>
        /// Ruta de la carpeta temporal del proyecto
        /// </summary>
        internal string TemporalRootPath = "";
        /// <summary>
        /// Configuracion del proyecto RIT para la generacion de todos los RITs correspondientes al proyecto
        /// </summary>
        public RitJsonProject PlantillaRIT { get; set; }
        public int HASH { get; set; }


        public ActProj (Actividad act, int hash)
        {
            _Actividad = act;
            HASH = hash;
        }

        public ActProj()
        {
            // Por definir constructor vacio
        }

        /// <summary>
        /// Creamos y guardamos todo el proyecto o actualizamos en caso de existir
        /// </summary>
        public void SaveProject()
        {
            string PROJECT_PATH = CreateFiles();        // Creamos el contenido del proyecto
            Compress(PROJECT_PATH, RootPath);   // Comprimimos el archivo
        }

        /// <summary>
        /// Crea los directorios de la actividad correspondiente
        /// </summary>
        /// <returns>Retorna el directorio raiz en el que se crearon los archivos a comprimir</returns>
        private string CreateFiles ()
        {
            string ROOT_PATH = $@"{System.Windows.Forms.Application.StartupPath}\Projects\_${_Actividad.Nombre}";

            try
            {
                if (!Directory.Exists(ROOT_PATH))
                {
                    Directory.CreateDirectory(ROOT_PATH);
                }

                // 1. Creamos el archivo JSON de la configuracion
                #region CODIGO
                Dictionary<string, object> jsonConfig = new Dictionary<string, object>
                {
                    { "FileVersion", 1.5 },
                    { "FileType", "Activity Project" },
                    { "FileExtension", _FileExtension },
                    { "MimeType", "application/zip" },
                    { "FileHASH", HASH },
                };
                string jConfig = JsonConvert.SerializeObject(jsonConfig);
                File.WriteAllText($@"{ROOT_PATH}\config.json", jConfig);
                #endregion

                // 2. Creamos el archivo JSON de las propiedades del objeto
                #region CODIGO
                Dictionary<string, string> jsonProps = new Dictionary<string, string>
                {
                    { "Nombre", _Actividad.Nombre },
                    { "InventarioSeleccionado", _Actividad.InventarioSeleccionado.ToString() },
                    { "Descripcion", _Actividad.Descripcion },
                    { "PasosARealizar", _Actividad.PasosARealizar },
                    { "FechaInicio", _Actividad.FechaInicio.ToString("d") },
                    { "FechaVencimiento", _Actividad.FechaTermino.ToString("d") },
                    { "EquiposTotales", _Actividad.EquiposTotales.ToString() },
                    { "EquiposProgresados", _Actividad.EquiposProgresados.ToString() },
                    { "HASH", _Actividad.HASH.ToString() },
                };
                string jProps = JsonConvert.SerializeObject(jsonProps);
                File.WriteAllText($@"{ROOT_PATH}\properties.json", jProps);
                #endregion

                // 3. Creamos el excel .xlsx de equipos enlistados
                #region CODIGO
                Directory.CreateDirectory($@"{ROOT_PATH}\content\");    // Creamos la carpeta contenedora
                SLDocument doc = new SLDocument();

                int iR = 1;
                foreach (Inventario4ActViewModel i in _Actividad.ListaEquipos)
                {
                    doc.SetCellValue(iR, 1, i.IsMachineReady.ToString());
                    doc.SetCellValue(iR, 2, iR);
                    doc.SetCellValue(iR, 3, i.NOMBRE);
                    doc.SetCellValue(iR, 4, i.NumDeEmpleado);
                    doc.SetCellValue(iR, 5, i.EXT);
                    doc.SetCellValue(iR, 6, i.USER);
                    doc.SetCellValue(iR, 7, i.MAIL);
                    doc.SetCellValue(iR, 8, i.HOSTNAME);
                    doc.SetCellValue(iR, 9, i.TipoDeEquipo);
                    doc.SetCellValue(iR, 10, i.SN);
                    doc.SetCellValue(iR, 11, i.Marca);
                    doc.SetCellValue(iR, 12, i.Modelo);
                    doc.SetCellValue(iR, 13, i.Ubicacion);
                    doc.SetCellValue(iR, 14, i.Departamento);
                    doc.SetCellValue(iR, 15, i.Comentarios);
                    doc.SetCellValue(iR, 16, i.TicketID);
                    doc.SetCellValue(iR, 17, i.PDFRitName);
                    doc.SetCellValue(iR, 18, i.EvidenciaName);
                    doc.SetCellValue(iR, 19, i.Notas);
                    doc.SetCellValue(iR, 20, i.HASH);

                    iR++;
                }
                doc.SaveAs($@"{ROOT_PATH}\content\grid_content.xlsx");   // Guardamos en la carpeta contenedora
                #endregion

                // 4. Creamos el directorio de los RITs y almacencamos los rits guardados / [attachments]
                #region CODIGO
                Directory.CreateDirectory($@"{ROOT_PATH}\attachments\");    // Creamos la carpeta contenedora

                foreach (Inventario4ActViewModel i in _Actividad.ListaEquipos)
                {
                    if (i.PDFRitContent != null && i.PDFRitContent.Length > 0)
                    {
                        File.WriteAllBytes($@"{ROOT_PATH}\attachments\{i.PDFRitName}", i.PDFRitContent);
                    }
                    if (i.EvidenciaContent != null && i.EvidenciaContent.Length > 0)
                    {
                        File.WriteAllBytes($@"{ROOT_PATH}\attachments\{i.EvidenciaName}", i.EvidenciaContent);
                    }
                }
                #endregion

                // 5. Creamos el directorio de archivos "assets"
                #region CODIGO
                string assetsPath = $@"{ROOT_PATH}\assets\";

                Directory.CreateDirectory(assetsPath);
                string[] accionesRealizadas = new string[7];
                string[] preAcciones = _Actividad.PasosARealizar.Split('\n');

                int counter = 0;
                foreach (string accion in preAcciones)
                {
                    accionesRealizadas[counter] = accion;
                    counter++;
                }

                // Guardamos en la carpeta el archivo de proyecto del RIT
                RitJsonProject RIT_PROJ = new RitJsonProject()
                {
                    // Llenamos las propiedades
                    NombreProyecto = "Plantilla RIT por defecto",
                    PdfPath = "",

                    NoFolio = "",
                    Falla = PlantillaRIT != null ? PlantillaRIT.Falla : _Actividad.Nombre,
                    NoTicket = "", // LO INGRESARA EL USUARIO
                    TipoEquipo = "",
                    Marca = "",
                    Modelo = "",
                    NoSerie = "",   // LO INGRESA EL USUARIO
                    Cliente = RIT_Solver.Properties.Settings.Default.Cliente,
                    HoraReporte = "",
                    MinutoReporte = "",
                    Sucursal = "",
                    NoSucursal = "",
                    Direccion = RIT_Solver.Properties.Settings.Default.Direccion,
                    Poblacion = RIT_Solver.Properties.Settings.Default.LocalidadIDC,
                    UsuarioFinal = "",  // LO INGRESA EL USUARIO
                    Departamento = "",  // LO INGRESA EL USUARIO
                    NoEmpleado = "",    // LO INGRESA EL USUARIO
                    Telefono = "",      // LO INGRESA EL USUARIO
                    CentroServicios = RIT_Solver.Properties.Settings.Default.CentroDeServicios,
                    Tecnico = RIT_Solver.Properties.Settings.Default.NombreIDC,
                    FechaDeGeneracionReporte = DateTime.Now,

                    UsaronRefacciones = false,
                    RefaccionUtilizada = "",

                    HoraInicioTraslado = "",
                    MinutoInicioTraslado = "",
                    HoraLlegada = "",
                    MinutoLlegada = "",
                    HoraComienzo = "",
                    MinutoComienzo = "",
                    HoraTermino = "",
                    MinutoEspera = "",
                    HoraRetorno = "",
                    MinutoRetorno = "",

                    ReporteCerrado = true,
                    CausaPendiente = "",

                    FechaDeAtencion = DateTime.Now,

                    // Creamos las lineas de las acciones personalizadas
                    AccionesRealizadas = accionesRealizadas
                };
                RIT_PROJ.SaveProject($@"{assetsPath}\Plantilla RIT por defecto.json");
                #endregion
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show($"Ha ocurrido un error inesperado a la hora de crear el archivo de proyecto! {ex.Message}", $"{System.Windows.Forms.Application.ProductName} - Error de creacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return ROOT_PATH;
        }

        /// <summary>
        /// Comprime la actividad y crea el archivo especifico .actproj
        /// </summary>
        /// <param name="OriginPath">Ruta absoluta del origen de la carpeta de proyecto que se comprimira</param>
        /// <param name="DestinyPath">Ruta absoluta del destino donde se guardara el archivo</param>
        private static void Compress(string OriginPath, string DestinyPath)
        {
            // Comprimimos el origen y lo enviamosal destino
            if (File.Exists(DestinyPath))
            {
                File.Delete(DestinyPath);
            }

            ZipFile.CreateFromDirectory(OriginPath, DestinyPath);

            // Eliminamos el origen de datos
            Directory.Delete(OriginPath, true);
        }

        /// <summary>
        /// Descomprime la actividad correspondiente y genera el objeto correspondiente en base a los datos obtenidos
        /// </summary>
        /// <param name="OriginPath">Ruta absoluta del destino donde se guardara el archivo</param>
        /// <returns></returns>
        public static (bool OperationStatus, ActProj Project) Decompress(string OriginPath)
        {
            Tuple<bool, ActProj> response = null;
            ActProj dead_Response = new ActProj();

            try
            {
                /* 
                 * Descomprimimos los archivos en la ruta temporal 
                 * */
                #region DESCOMPRIMIMOS EL ARCHIVO DE PROYECTO
                // 1. Validamos la existencia del directorio de temporales en la ruta
                string TEMP_PATH = $@"{System.Windows.Forms.Application.StartupPath}\Temp";
                if (!Directory.Exists(TEMP_PATH))
                {
                    DirectoryInfo temp = Directory.CreateDirectory(TEMP_PATH);
                    temp.Attributes = FileAttributes.Hidden;
                }

                // 2. Validamos que no exista la carpeta con el mismo nombre
                FileInfo fi = new FileInfo(OriginPath);
                string PROJ_PATH = $@"{TEMP_PATH}\_${fi.Name.Replace(ActProj._FileExtension, "")}";
                //System.Windows.Forms.MessageBox.Show(PROJ_PATH);

                if (Directory.Exists(PROJ_PATH))
                {
                    Directory.Delete(PROJ_PATH, true);
                }

                Directory.CreateDirectory(PROJ_PATH);

                string PROJECT_EXTRACTION_DIR_NAME_PATH = $@"{TEMP_PATH}\{fi.Name.Replace(ActProj._FileExtension, "")}";

                if (Directory.Exists(PROJECT_EXTRACTION_DIR_NAME_PATH))
                {
                    Directory.Delete(PROJECT_EXTRACTION_DIR_NAME_PATH, true);
                }

                // 4. Descomprimimos el archivo de proyecto
                ZipFile.ExtractToDirectory(OriginPath, PROJECT_EXTRACTION_DIR_NAME_PATH);

                // 3. Creamos el directorio especificado del proyecto
                #region MOVEMOS LOS ARCHIVOS
                // Mover archivos del directorio de origen al directorio de destino
                string[] files = Directory.GetFiles(PROJECT_EXTRACTION_DIR_NAME_PATH);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(PROJ_PATH, fileName);
                    File.Move(file, destFile);
                }
                #endregion

                #region MOVEMOS LOS DIRECTORIOS
                // Mover subdirectorios del directorio de origen al directorio de destino
                string[] directories = Directory.GetDirectories(PROJECT_EXTRACTION_DIR_NAME_PATH);
                foreach (string directory in directories)
                {
                    string directoryName = Path.GetFileName(directory);
                    string destDirectory = Path.Combine(PROJ_PATH, directoryName);
                    Directory.Move(directory, destDirectory);
                }
                #endregion

                Directory.Delete(PROJECT_EXTRACTION_DIR_NAME_PATH, true);
                #endregion

                #region PARSEAMOS LA ACTIVIDAD SEGUN LOS ARCHIVOS
                Actividad act = new Actividad();
                JObject jsonProperties = JObject.Parse(File.ReadAllText($@"{PROJ_PATH}\properties.json"));

                act.Nombre = jsonProperties["Nombre"].ToString();
                act.InventarioSeleccionado = CommonMethodsLibrary.ParseInventoryClass(jsonProperties["InventarioSeleccionado"].ToString());
                act.Descripcion = jsonProperties["Descripcion"].ToString();
                act.PasosARealizar = jsonProperties["PasosARealizar"].ToString();
                act.FechaInicio = DateTime.Parse(jsonProperties["FechaInicio"].ToString());
                act.FechaTermino = DateTime.Parse(jsonProperties["FechaVencimiento"].ToString());
                #region PARSEAMOS LOS EQUIPOS SELECCIONADOS DE LA ACTIVIDAD
                SLDocument sl = new SLDocument($@"{PROJ_PATH}\content\grid_content.xlsx");
                List<Inventario4ActViewModel> machinesSelected = new List<Inventario4ActViewModel>();

                int iRow = 1;
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    Inventario4ActViewModel obj = new Inventario4ActViewModel();

                    obj.IsMachineReady = bool.Parse(sl.GetCellValueAsString(iRow, 1));
                    obj.Id = sl.GetCellValueAsInt32(iRow, 2);
                    obj.NOMBRE = sl.GetCellValueAsString(iRow, 3);
                    obj.NumDeEmpleado = sl.GetCellValueAsString(iRow, 4);
                    obj.EXT = sl.GetCellValueAsString(iRow, 5);
                    obj.USER = sl.GetCellValueAsString(iRow, 6);
                    obj.MAIL = sl.GetCellValueAsString(iRow, 7);
                    obj.HOSTNAME = sl.GetCellValueAsString(iRow, 8);
                    obj.TipoDeEquipo = sl.GetCellValueAsString(iRow, 9);
                    obj.SN = sl.GetCellValueAsString(iRow, 10);
                    obj.Marca = sl.GetCellValueAsString(iRow, 11);
                    obj.Modelo = sl.GetCellValueAsString(iRow, 12);
                    obj.Ubicacion = sl.GetCellValueAsString(iRow, 13);
                    obj.Departamento = sl.GetCellValueAsString(iRow, 14);
                    obj.Comentarios = sl.GetCellValueAsString(iRow, 15);
                    obj.TicketID = sl.GetCellValueAsString(iRow, 16);
                    obj.PDFRitName = sl.GetCellValueAsString(iRow, 17);
                    #region BUSCAMOS Y CARGAMOS EL RIT PDF EN CASO DE QUE EL EQUIPO LO TENGA
                    if (!String.IsNullOrEmpty(obj.PDFRitName.Trim()))
                    {
                        // Buscamos el archivo
                        string TARGET_PDF_RIT_ROOT = $@"{PROJ_PATH}\attachments\{obj.PDFRitName}";
                        if (File.Exists(TARGET_PDF_RIT_ROOT))
                        {
                            // En caso de existir lo cargamos
                            obj.PDFRitContent = File.ReadAllBytes(TARGET_PDF_RIT_ROOT);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"No se ha encontrado el archivo RIT < {TARGET_PDF_RIT_ROOT} > correspondiente al equipo < {obj.HOSTNAME.Trim()} > cargado en el proyecto!!", $"{System.Windows.Forms.Application.ProductName} - Archivo inexistente en proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    #endregion
                    obj.EvidenciaName = sl.GetCellValueAsString(iRow, 18);
                    #region BUSCAMOS Y CARGAMOS LA EVIDENCIA EN CASO DE QUE EL EQUIPO LO TENGA
                    if (!String.IsNullOrEmpty(obj.EvidenciaName.Trim()))
                    {
                        // Buscamos el archivo
                        string TARGET_EVIDENCE_ROOT = $@"{PROJ_PATH}\attachments\{obj.EvidenciaName}";
                        if (File.Exists(TARGET_EVIDENCE_ROOT))
                        {
                            // En caso de existir lo cargamos
                            obj.EvidenciaContent = File.ReadAllBytes(TARGET_EVIDENCE_ROOT);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"No se ha encontrado el archivo RIT < {TARGET_EVIDENCE_ROOT} > correspondiente al equipo < {obj.HOSTNAME.Trim()} > cargado en el proyecto!!", $"{System.Windows.Forms.Application.ProductName} - Archivo inexistente en proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    #endregion
                    obj.Notas = sl.GetCellValueAsString(iRow, 19);
                    obj.HASH = sl.GetCellValueAsInt32(iRow, 20);

                    machinesSelected.Add(obj);
                    iRow++;
                }
                #endregion
                act.ListaEquipos = machinesSelected;
                act.EquiposTotales = Int32.Parse(jsonProperties["EquiposTotales"].ToString());
                act.EquiposProgresados = Int32.Parse(jsonProperties["EquiposProgresados"].ToString());
                act.HASH = Int32.Parse(jsonProperties["HASH"].ToString());
                #endregion
                dead_Response._Actividad = act;
                dead_Response.RootPath = OriginPath;
                #region PARSEAMOS LOS DATOS DEL ARCHIVO DE CONFIGURACION
                JObject jsonConfig = JObject.Parse(File.ReadAllText($@"{PROJ_PATH}\config.json"));
                int FileHASH = Int32.Parse(jsonConfig["FileHASH"].ToString());
                #endregion
                dead_Response.TemporalRootPath = PROJ_PATH;
                dead_Response.PlantillaRIT = RitJsonProject.LoadProject($@"{PROJ_PATH}\assets\Plantilla RIT por defecto.json");
                dead_Response.HASH = FileHASH;

                response = new Tuple<bool, ActProj>(true, dead_Response);
            } catch (Exception ex)
            {
                response = new Tuple<bool, ActProj>(true, dead_Response);
                System.Windows.Forms.MessageBox.Show($"Ha ocurrido un error inesperado a la hora de abrir el archivo de proyecto! {ex.Message}\n\n{ex}", $"{System.Windows.Forms.Application.ProductName} - Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (response.Item1, response.Item2);
        }
    }
}
