using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Claims;
using DocumentFormat.OpenXml.InkML;
using SpreadsheetLight;
using System.Data;
using Org.BouncyCastle.Asn1.X509;
using System.Runtime.InteropServices;

namespace Flow_Solver.Centro_de_Control
{
    internal class InformesActividades
    {
        class PageEventHelper : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                // Obtener el número de página actual
                int pageNumber = writer.PageNumber;

                // Obtener el número total de páginas
                int totalPages = writer.PageNumber;

                // Crear un objeto Phrase con el texto del pie de página
                Phrase footer = new Phrase($"Página {pageNumber} / {totalPages}");

                // Crear un objeto PdfContentByte para dibujar el pie de página
                PdfContentByte cb = writer.DirectContent;

                // Agregar el texto del pie de página al documento
                ColumnText.ShowTextAligned(cb, Element.ALIGN_CENTER, footer, document.Right / 2, document.Bottom - 30, 0);
            }
        }

        /// <summary>
        /// Generamos el informe de la actividad en PDF
        /// </summary>
        /// <param name="dgv">DataGridView de visualizacion del trabajo actual</param>
        /// <param name="proyecto">Objeto del proyecto actual</param>
        public static void GeneratePdfReport(DataGridView dgv, Actividad proyecto, string outname)
        {
            try
            {
                #region CODIGO DE GENERACION
                var grilla = dgv;

                FileStream fs = new FileStream(outname, FileMode.Create);
                Document doc = new Document(PageSize.LETTER_LANDSCAPE.Rotate(), 2, 2, 7, 5);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                pw.PageEvent = new PageEventHelper();

                /* VALORES PERSONALIZADOS PARA SECCION DE INFORME */
                int TOTAL_EQUIPOS = 0;
                int TOTAL_LAPTOPS = 0;
                int TOTAL_PC = 0;
                int TOTAL_USUARIOS = 0;
                int TOTAL_UPS = 0;
                int TOTAL_IMPRESORAS = 0;
                int TOTAL_MONITORES = 0;
                int TOTAL_OTROS = 0;
                int TOTAL_COMPLETADOS = 0;

                List<string> USUARIOS = new List<string>();

                doc.Open();
                //doc.SetPageSize(iTextSharp.text.PageSize.LETTER_LANDSCAPE);

                // Titulo y autor del documento
                doc.AddTitle($"Resumen de actividad: {proyecto.Nombre}");
                doc.AddAuthor(Properties.Settings.Default.NombreIDC);

                // Fuente del documento
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


                // Encabezado de las columnas
                PdfPTable tblDatos = new PdfPTable(11);
                tblDatos.WidthPercentage = 100;
                tblDatos.SetWidths(new float[] { 3f, 15f, 5f, 9f, 6f, 9f, 8f, 13f, 7f, 9f, 16f});
                PdfPTable tablaGeneral = new PdfPTable(8);
                tablaGeneral.HorizontalAlignment = Element.ALIGN_CENTER;
                PdfPTable tablaEncabezados = new PdfPTable(3);
                tablaEncabezados.WidthPercentage = 75;
                tablaEncabezados.HorizontalAlignment = Element.ALIGN_LEFT;
                tablaEncabezados.SetWidths(new float[] { 25f, 25f, 50f});

                #region ADICION DE CELDAS DE LA TABLA DE IMAGENES
                iTextSharp.text.Image gmxt_logo = iTextSharp.text.Image.GetInstance("gmxt_logo.png");
                iTextSharp.text.Image compusof_logo = iTextSharp.text.Image.GetInstance("compusof transp logo.png");

                gmxt_logo.ScaleToFit(200f, 200f);
                compusof_logo.ScaleToFit(200f, 200f);

                tablaEncabezados.AddCell(gmxt_logo);
                tablaEncabezados.AddCell(compusof_logo);


                Phrase titulo = new Phrase($"Resumen de actividad: {proyecto.Nombre}", new Font(Font.FontFamily.HELVETICA, 14, Font.ITALIC));
                PdfPCell docTittle = new PdfPCell(titulo);
                docTittle.VerticalAlignment = Element.ALIGN_MIDDLE;
                tablaEncabezados.AddCell(docTittle);

                // Establecer el ancho de borde de las celdas a cero
                foreach (PdfPCell cell in tablaEncabezados.Rows[0].GetCells())
                {
                    cell.BorderWidth = 0;
                }
                #endregion

                #region CONFIGURACION DE LAS CELDAS - TABLA DE LISTADO DE ACTIVIDAD
                PdfPCell clNo = new PdfPCell(new Phrase("No.", standardFont));
                clNo.BorderWidth = 0;
                clNo.BorderWidthBottom = 0.75f;

                PdfPCell clNOMBRE = new PdfPCell(new Phrase("Nombre", standardFont));
                clNOMBRE.BorderWidth = 0;
                clNOMBRE.BorderWidthBottom = 0.75f;

                PdfPCell clNUMDEEMPLEADO = new PdfPCell(new Phrase("No. De Emp.", standardFont));
                clNUMDEEMPLEADO.BorderWidth = 0;
                clNUMDEEMPLEADO.BorderWidthBottom = 0.75f;

                PdfPCell clHOSTNAME = new PdfPCell(new Phrase("Hostname", standardFont));
                clHOSTNAME.BorderWidth = 0;
                clHOSTNAME.BorderWidthBottom = 0.75f;

                PdfPCell clTIPODEEQUIPO = new PdfPCell(new Phrase("Tipo de Eq.", standardFont));
                clTIPODEEQUIPO.BorderWidth = 0;
                clTIPODEEQUIPO.BorderWidthBottom = 0.75f;

                PdfPCell clSN = new PdfPCell(new Phrase("Num. De Serie", standardFont));
                clSN.BorderWidth = 0;
                clSN.BorderWidthBottom = 0.75f;

                PdfPCell clMARCA = new PdfPCell(new Phrase("Marca", standardFont));
                clMARCA.BorderWidth = 0;
                clMARCA.BorderWidthBottom = 0.75f;

                PdfPCell clMODELO = new PdfPCell(new Phrase("Modelo", standardFont));
                clMODELO.BorderWidth = 0;
                clMODELO.BorderWidthBottom = 0.75f;

                PdfPCell clTicketID = new PdfPCell(new Phrase("No. Reporte", standardFont));
                clTicketID.BorderWidth = 0;
                clTicketID.BorderWidthBottom = 0.75f;

                PdfPCell clUBICACION = new PdfPCell(new Phrase("Ubicacion", standardFont));
                clUBICACION.BorderWidth = 0;
                clUBICACION.BorderWidthBottom = 0.75f;

                PdfPCell clDEPARTAMENTO = new PdfPCell(new Phrase("Departamento", standardFont));
                clDEPARTAMENTO.BorderWidth = 0;
                clDEPARTAMENTO.BorderWidthBottom = 0.75f;

                PdfPCell clHASH = new PdfPCell(new Phrase("HASH", standardFont));
                clHASH.BorderWidth = 0;
                #endregion

                #region ADICION DE CELDAS A LA TABLA DE DATOS
                tblDatos.AddCell(clNo);
                tblDatos.AddCell(clNOMBRE);
                tblDatos.AddCell(clNUMDEEMPLEADO);
                //tblDatos.AddCell(clEXT);
                //tblDatos.AddCell(clUSER);
                tblDatos.AddCell(clHOSTNAME);
                tblDatos.AddCell(clTIPODEEQUIPO);
                tblDatos.AddCell(clSN);
                tblDatos.AddCell(clMARCA);
                tblDatos.AddCell(clMODELO);
                tblDatos.AddCell(clTicketID);
                tblDatos.AddCell(clUBICACION);
                tblDatos.AddCell(clDEPARTAMENTO);
                #endregion

                #region GUARDADO DE LOS DATOS EN LISTA LOCAL
                List<Inventario4ActViewModel> inventarioList = new List<Inventario4ActViewModel>();

                foreach (DataGridViewRow row in grilla.Rows)
                {
                    Inventario4ActViewModel equipo = new Inventario4ActViewModel();

                    equipo.IsMachineReady = bool.Parse(row.Cells["Completado"].Value.ToString());
                    equipo.Id = Int32.Parse(row.Cells["NoItem"].Value.ToString());
                    equipo.NOMBRE = row.Cells["Nombre"].Value.ToString();
                    if (!USUARIOS.Contains(equipo.NOMBRE))
                    {
                        USUARIOS.Add(equipo.NOMBRE);
                    }
                    equipo.NumDeEmpleado = row.Cells["NumEmpleado"].Value.ToString();
                    equipo.EXT = row.Cells["Ext"].Value.ToString();
                    equipo.USER = row.Cells["RedUser"].Value.ToString();
                    equipo.MAIL = row.Cells["Mail"].Value.ToString();
                    equipo.HOSTNAME = row.Cells["Hostname"].Value.ToString();
                    equipo.TipoDeEquipo = row.Cells["TipoEquipo"].Value.ToString();
                    switch (equipo.TipoDeEquipo.ToUpper())
                    {
                        case "PC":
                            TOTAL_PC++;
                            break;
                        case "LAPTOP":
                            TOTAL_LAPTOPS++;
                            break;
                        case "UPS":
                            TOTAL_UPS++;
                            break;
                        case "IMPRESORA":
                            TOTAL_IMPRESORAS++;
                            break;
                        case "MONITOR":
                            TOTAL_MONITORES++;
                            break;
                        default:
                            TOTAL_OTROS++;
                            break;
                    }
                    equipo.SN = row.Cells["NoSerie"].Value.ToString();
                    equipo.Marca = row.Cells["Marca"].Value.ToString();
                    equipo.Modelo = row.Cells["Modelo"].Value.ToString();
                    equipo.Ubicacion = row.Cells["Ubicacion"].Value.ToString();
                    equipo.Departamento = row.Cells["Departamento"].Value.ToString();
                    equipo.TicketID = row.Cells["TicketID"].Value.ToString();
                    equipo.PDFRitName = row.Cells["PDFRitName"].Value.ToString();
                    equipo.Notas = row.Cells["Notas"].Value.ToString();
                    equipo.HASH = Int32.Parse(row.Cells["HASH"].Value.ToString());

                    inventarioList.Add(equipo);
                    TOTAL_EQUIPOS++;
                }

                TOTAL_USUARIOS = USUARIOS.Count();
                #endregion


                #region ADICION DE LOS DATOS
                foreach (Inventario4ActViewModel equipo in inventarioList)
                {
                    BaseColor BACK_COLOR = equipo.IsMachineReady ? BaseColor.GREEN : BaseColor.WHITE;

                    clNo = new PdfPCell(new Phrase(equipo.Id.ToString(), standardFont));
                    clNo.BorderWidth = 0;
                    clNo.BackgroundColor = BACK_COLOR;

                    clNOMBRE = new PdfPCell(new Phrase(equipo.NOMBRE, standardFont));
                    clNOMBRE.BorderWidth = 0;
                    clNOMBRE.BackgroundColor = BACK_COLOR;

                    clNUMDEEMPLEADO = new PdfPCell(new Phrase(equipo.NumDeEmpleado, standardFont));
                    clNUMDEEMPLEADO.BorderWidth = 0;
                    clNUMDEEMPLEADO.BackgroundColor = BACK_COLOR;

                    clHOSTNAME = new PdfPCell(new Phrase(equipo.HOSTNAME, standardFont));
                    clHOSTNAME.BorderWidth = 0;
                    clHOSTNAME.BackgroundColor = BACK_COLOR;

                    clTIPODEEQUIPO = new PdfPCell(new Phrase(equipo.TipoDeEquipo, standardFont));
                    clTIPODEEQUIPO.BorderWidth = 0;
                    clTIPODEEQUIPO.BackgroundColor = BACK_COLOR;

                    clSN = new PdfPCell(new Phrase(equipo.SN, standardFont));
                    clSN.BorderWidth = 0;
                    clSN.BackgroundColor = BACK_COLOR;

                    clMARCA = new PdfPCell(new Phrase(equipo.Marca, standardFont));
                    clMARCA.BorderWidth = 0;
                    clMARCA.BackgroundColor = BACK_COLOR;

                    clMODELO = new PdfPCell(new Phrase(equipo.Modelo, standardFont));
                    clMODELO.BorderWidth = 0;
                    clMODELO.BackgroundColor = BACK_COLOR;

                    clUBICACION = new PdfPCell(new Phrase(equipo.Ubicacion, standardFont));
                    clUBICACION.BorderWidth = 0;
                    clUBICACION.BackgroundColor = BACK_COLOR;

                    clDEPARTAMENTO = new PdfPCell(new Phrase(equipo.Departamento, standardFont));
                    clDEPARTAMENTO.BorderWidth = 0;
                    clDEPARTAMENTO.BackgroundColor = BACK_COLOR;

                    clTicketID = new PdfPCell(new Phrase(equipo.TicketID, standardFont));
                    clTicketID.BorderWidth = 0;
                    clTicketID.BackgroundColor = BACK_COLOR;

                    clHASH = new PdfPCell(new Phrase(equipo.HASH.ToString(), standardFont));
                    clHASH.BorderWidth = 0;
                    clHASH.BackgroundColor = BACK_COLOR;

                    tblDatos.AddCell(clNo);
                    tblDatos.AddCell(clNOMBRE);
                    tblDatos.AddCell(clNUMDEEMPLEADO);
                    tblDatos.AddCell(clHOSTNAME);
                    tblDatos.AddCell(clTIPODEEQUIPO);
                    tblDatos.AddCell(clSN);
                    tblDatos.AddCell(clMARCA);
                    tblDatos.AddCell(clMODELO);
                    tblDatos.AddCell(clTicketID);
                    tblDatos.AddCell(clUBICACION);
                    tblDatos.AddCell(clDEPARTAMENTO);

                    if (equipo.IsMachineReady)
                    {
                        TOTAL_COMPLETADOS++;
                    }
                }
                #endregion

                /*
                doc.Add(new Phrase(Properties.Settings.Default.NombreIDC + "\n", standardFont));
                doc.Add(new Phrase(Properties.Settings.Default.LocalidadIDC + "\n", standardFont));

                // Fecha actual
                DateTime dt = DateTime.Now;
                string AÑO = dt.Year.ToString();
                string MES = dt.Month.ToString();
                string DIA = dt.Day.ToString();
                doc.Add(new Phrase($"{DIA} / {MES} / {AÑO}", standardFont));*/
                doc.Add(tablaEncabezados);  // ENCABEZADO
                doc.Add(Chunk.NEWLINE);
                #region TABLA DE DATOS GENERAL
                doc.Add(new Phrase("\n"));

                PdfPCell clLaptops = new PdfPCell(new Phrase($"Laptops: {TOTAL_LAPTOPS}", standardFont));
                PdfPCell clPCs = new PdfPCell(new Phrase($"PCs: {TOTAL_PC}", standardFont));
                PdfPCell clImpresoras = new PdfPCell(new Phrase($"Impresoras: {TOTAL_IMPRESORAS}", standardFont));
                PdfPCell clMonitores = new PdfPCell(new Phrase($"Monitores: {TOTAL_MONITORES}", standardFont));
                PdfPCell clUPS = new PdfPCell(new Phrase($"UPS: {TOTAL_UPS}", standardFont));
                PdfPCell clOtros = new PdfPCell(new Phrase($"Otros: {TOTAL_OTROS}", standardFont));
                PdfPCell clTotal = new PdfPCell(new Phrase($"Total: {TOTAL_EQUIPOS}", standardFont));
                PdfPCell clCompletados = new PdfPCell(new Phrase($"Completados: {TOTAL_COMPLETADOS}", standardFont));

                tablaGeneral.AddCell(clLaptops);
                tablaGeneral.AddCell(clPCs);
                tablaGeneral.AddCell(clImpresoras);
                tablaGeneral.AddCell(clMonitores);
                tablaGeneral.AddCell(clUPS);
                tablaGeneral.AddCell(clOtros);
                tablaGeneral.AddCell(clTotal);
                tablaGeneral.AddCell(clCompletados);
                #endregion   
                doc.Add(tablaGeneral);  // DATOS DE RESUMEN
                doc.Add(Chunk.NEWLINE); 


                doc.Add(tblDatos);  // LISTADO

                // Pie de pagina de marca de documento generado por el programa
                Phrase footer = new Phrase("Generado automaticamente por RIT Solver 2024.");
                //footer.


                doc.Close();
                pw.Close();
                fs.Close();
                #endregion
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", $"{Application.ProductName} - Error de generacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GenerateExcelReport(DataGridView dgv, Actividad proyecto, string outname)
        {
            try
            {
                #region CODIGO DE GENERACION
                // Obtener la ruta de la plantilla de Excel
                string plantillaExcel = $@"{Application.StartupPath}\templates\plantilla_actividad_excel.xlsx"; // Ruta de tu plantilla de Excel

                // Verificar si la plantilla de Excel existe
                if (File.Exists(plantillaExcel))
                {
                    // Crear un objeto SLDocument (documento de SpreadsheetLight) utilizando la plantilla de Excel
                    using (SLDocument sl = new SLDocument(plantillaExcel))
                    {
                        sl.SaveAs(outname);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", $"{Application.ProductName} - Error de generacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void MergePDFs(string[] pdfFiles, string outputFilePath)
        {
            using (FileStream stream = new FileStream(outputFilePath, FileMode.Create))
            {
                Document document = new Document();
                PdfCopy pdf = new PdfCopy(document, stream);

                document.Open();

                foreach (string file in pdfFiles)
                {
                    PdfReader reader = new PdfReader(file);
                    pdf.AddDocument(reader);
                    reader.Close();
                }

                pdf.Close();
                document.Close();
            }

            /* Borramos los archivos de las partes que pasamos como parametros */
            foreach (string i in pdfFiles)
            {
                if (File.Exists(i))
                {
                    File.Delete(i);
                }
            }
        }

        /// <summary>
        /// Generar el reporte de resultados de la actividad abierta actualmente
        /// </summary>
        /// <param name="dgv">DataGridView de los elementos enlistados en la actividad</param>
        /// <param name="proyecto">Actividad del proyecto que estamos trabajando</param>
        /// <param name="outname">Nombre de salida del archivo</param>
        public static void GenerateResultReport (DataGridView dgv, Actividad proyecto, string outname)
        {
            try
            {
                DataGridView grilla = dgv;

                // Fuentes del documento
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font partOneFont = new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 18, Font.ITALIC);
                iTextSharp.text.Font subtitleFont = new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 14, Font.BOLD);

                #region CODIGO DE GENERACION - ARCHIVO PT 1
                // Margenes del documento en pulgadas
                /* 
                 * Indices del arreglo de margenes
                 * 0 - Margin Left
                 * 1 - Margin Right
                 * 2 - Margin Top
                 * 3 - Margin Bottom
                 * */
                float[] _DOC_MARGINS = { 8f, 4f, 4f, 4f };

                FileStream P_fs = new FileStream("RESULT_REPORT_PT1.pdf", FileMode.Create);
                Document P_doc = new Document(PageSize.LETTER, Utilities.MillimetersToPoints(_DOC_MARGINS[0]), Utilities.MillimetersToPoints(_DOC_MARGINS[1]), Utilities.MillimetersToPoints(_DOC_MARGINS[2]), Utilities.MillimetersToPoints(_DOC_MARGINS[3]));
                PdfWriter P_pw = PdfWriter.GetInstance(P_doc, P_fs);

                P_doc.Open();

                /* ENCABEZADOS */
                PdfPTable tablaEncabezados = new PdfPTable(3);
                tablaEncabezados.WidthPercentage = 100;
                tablaEncabezados.HorizontalAlignment = Element.ALIGN_LEFT;
                tablaEncabezados.SetWidths(new float[] { 25f, 25f, 50f });

                #region ADICION DE CELDAS DE LA TABLA DE IMAGENES
                iTextSharp.text.Image gmxt_logo = iTextSharp.text.Image.GetInstance("gmxt_logo.png");
                iTextSharp.text.Image compusof_logo = iTextSharp.text.Image.GetInstance("compusof transp logo.png");

                gmxt_logo.ScaleToFit(400f, 400f);
                compusof_logo.ScaleToFit(400f, 400f);

                tablaEncabezados.AddCell(gmxt_logo);
                tablaEncabezados.AddCell(compusof_logo);

                Phrase fecha = new Phrase(DateTime.Now.ToString("D"), standardFont);
                PdfPCell docTittle = new PdfPCell(fecha);
                docTittle.VerticalAlignment = Element.ALIGN_MIDDLE;
                docTittle.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaEncabezados.AddCell(docTittle);

                // Establecer el ancho de borde de las celdas a cero
                foreach (PdfPCell cell in tablaEncabezados.Rows[0].GetCells())
                {
                    cell.BorderWidth = 0;
                }
                #endregion

                P_doc.Add(tablaEncabezados);
                P_doc.Add(Chunk.NEWLINE);
                P_doc.Add(new Phrase("\n"));
                P_doc.Add(new Phrase("\n"));

                Paragraph titulo = new Paragraph($"Informe de Resultados de la Actividad '{proyecto.Nombre}'", titleFont);
                titulo.Alignment = Element.ALIGN_CENTER;

                PdfPTable tablaTitulo = new PdfPTable(1);
                tablaTitulo.WidthPercentage = 80;
                tablaTitulo.HorizontalAlignment = Element.ALIGN_LEFT;
                PdfPCell clTitulo = new PdfPCell(titulo);
                clTitulo.VerticalAlignment = Element.ALIGN_MIDDLE;
                clTitulo .HorizontalAlignment = Element.ALIGN_LEFT;
                clTitulo.BorderWidth = 0;
                tablaTitulo.AddCell(clTitulo);

                P_doc.Add(tablaTitulo);
                P_doc.Add(Chunk.NEWLINE);
                P_doc.Add(new Phrase("\n"));
                P_doc.Add(new Phrase("\n"));

                /* CUERPO DEL DOCUMENTO */
                P_doc.Add(new Phrase("Resumen", subtitleFont));
                Paragraph parrafo_Resumen = new Paragraph($"Durante el período comprendido entre '{proyecto.FechaInicio.ToString("d")}' y '{proyecto.FechaTermino.ToString("d")}', se llevó a cabo una actividad de mantenimiento de equipos de cómputo en la empresa {Properties.Settings.Default.CentroDeServicios}. El objetivo principal de esta actividad fue garantizar el óptimo funcionamiento y rendimiento de los equipos de cómputo utilizados en las diferentes áreas de la empresa.", partOneFont);
                P_doc.Add(parrafo_Resumen);
                P_doc.Add(new Phrase("\n"));

                P_doc.Add(new Phrase("Detalles", subtitleFont));
                Paragraph parrafo_Detalles = new Paragraph($"");
                P_doc.Add(parrafo_Detalles);
                P_doc.Add(new Phrase("\n"));

                P_doc.Add(new Phrase("Descripcion", subtitleFont));
                Paragraph parrafo_Descripcion = new Paragraph(proyecto.Descripcion);
                P_doc.Add(parrafo_Descripcion);
                P_doc.Add(new Phrase("\n"));

                /* FIRMAS DE CONFORMIDAD */


                P_doc.Close();
                P_pw.Close();
                P_fs.Close();
                #endregion

                #region CODIGO DE GENERACION - ARCHIVO PT 2
                FileStream fs = new FileStream("RESULT_REPORT_PT2.pdf", FileMode.Create);
                Document doc = new Document(PageSize.LETTER_LANDSCAPE.Rotate(), 2, 2, 7, 5); ;
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                pw.PageEvent = new PageEventHelper();

                /* VALORES PERSONALIZADOS PARA SECCION DE INFORME */
                int TOTAL_EQUIPOS = 0;
                int TOTAL_LAPTOPS = 0;
                int TOTAL_PC = 0;
                int TOTAL_USUARIOS = 0;
                int TOTAL_UPS = 0;
                int TOTAL_IMPRESORAS = 0;
                int TOTAL_MONITORES = 0;
                int TOTAL_OTROS = 0;
                int TOTAL_COMPLETADOS = 0;

                List<string> USUARIOS = new List<string>();

                doc.Open();

                // Encabezado de las columnas
                PdfPTable tblDatos = new PdfPTable(11);
                tblDatos.WidthPercentage = 100;
                tblDatos.SetWidths(new float[] { 3f, 15f, 5f, 9f, 6f, 9f, 8f, 13f, 7f, 9f, 16f });
                PdfPTable tablaGeneral = new PdfPTable(8);
                tablaGeneral.HorizontalAlignment = Element.ALIGN_CENTER;

                #region CONFIGURACION DE LAS CELDAS - TABLA DE LISTADO DE ACTIVIDAD
                PdfPCell clNo = new PdfPCell(new Phrase("No.", standardFont));
                clNo.BorderWidth = 0;
                clNo.BorderWidthBottom = 0.75f;

                PdfPCell clNOMBRE = new PdfPCell(new Phrase("Nombre", standardFont));
                clNOMBRE.BorderWidth = 0;
                clNOMBRE.BorderWidthBottom = 0.75f;

                PdfPCell clNUMDEEMPLEADO = new PdfPCell(new Phrase("No. De Emp.", standardFont));
                clNUMDEEMPLEADO.BorderWidth = 0;
                clNUMDEEMPLEADO.BorderWidthBottom = 0.75f;

                PdfPCell clHOSTNAME = new PdfPCell(new Phrase("Hostname", standardFont));
                clHOSTNAME.BorderWidth = 0;
                clHOSTNAME.BorderWidthBottom = 0.75f;

                PdfPCell clTIPODEEQUIPO = new PdfPCell(new Phrase("Tipo de Eq.", standardFont));
                clTIPODEEQUIPO.BorderWidth = 0;
                clTIPODEEQUIPO.BorderWidthBottom = 0.75f;

                PdfPCell clSN = new PdfPCell(new Phrase("Num. De Serie", standardFont));
                clSN.BorderWidth = 0;
                clSN.BorderWidthBottom = 0.75f;

                PdfPCell clMARCA = new PdfPCell(new Phrase("Marca", standardFont));
                clMARCA.BorderWidth = 0;
                clMARCA.BorderWidthBottom = 0.75f;

                PdfPCell clMODELO = new PdfPCell(new Phrase("Modelo", standardFont));
                clMODELO.BorderWidth = 0;
                clMODELO.BorderWidthBottom = 0.75f;

                PdfPCell clTicketID = new PdfPCell(new Phrase("No. Reporte", standardFont));
                clTicketID.BorderWidth = 0;
                clTicketID.BorderWidthBottom = 0.75f;

                PdfPCell clUBICACION = new PdfPCell(new Phrase("Ubicacion", standardFont));
                clUBICACION.BorderWidth = 0;
                clUBICACION.BorderWidthBottom = 0.75f;

                PdfPCell clDEPARTAMENTO = new PdfPCell(new Phrase("Departamento", standardFont));
                clDEPARTAMENTO.BorderWidth = 0;
                clDEPARTAMENTO.BorderWidthBottom = 0.75f;

                PdfPCell clHASH = new PdfPCell(new Phrase("HASH", standardFont));
                clHASH.BorderWidth = 0;
                #endregion

                #region ADICION DE CELDAS A LA TABLA DE DATOS
                tblDatos.AddCell(clNo);
                tblDatos.AddCell(clNOMBRE);
                tblDatos.AddCell(clNUMDEEMPLEADO);
                //tblDatos.AddCell(clEXT);
                //tblDatos.AddCell(clUSER);
                tblDatos.AddCell(clHOSTNAME);
                tblDatos.AddCell(clTIPODEEQUIPO);
                tblDatos.AddCell(clSN);
                tblDatos.AddCell(clMARCA);
                tblDatos.AddCell(clMODELO);
                tblDatos.AddCell(clTicketID);
                tblDatos.AddCell(clUBICACION);
                tblDatos.AddCell(clDEPARTAMENTO);
                #endregion

                #region GUARDADO DE LOS DATOS EN LISTA LOCAL
                List<Inventario4ActViewModel> inventarioList = new List<Inventario4ActViewModel>();

                foreach (DataGridViewRow row in grilla.Rows)
                {
                    Inventario4ActViewModel equipo = new Inventario4ActViewModel();

                    equipo.IsMachineReady = bool.Parse(row.Cells["Completado"].Value.ToString());
                    equipo.Id = Int32.Parse(row.Cells["NoItem"].Value.ToString());
                    equipo.NOMBRE = row.Cells["Nombre"].Value.ToString();
                    if (!USUARIOS.Contains(equipo.NOMBRE))
                    {
                        USUARIOS.Add(equipo.NOMBRE);
                    }
                    equipo.NumDeEmpleado = row.Cells["NumEmpleado"].Value.ToString();
                    equipo.EXT = row.Cells["Ext"].Value.ToString();
                    equipo.USER = row.Cells["RedUser"].Value.ToString();
                    equipo.MAIL = row.Cells["Mail"].Value.ToString();
                    equipo.HOSTNAME = row.Cells["Hostname"].Value.ToString();
                    equipo.TipoDeEquipo = row.Cells["TipoEquipo"].Value.ToString();
                    switch (equipo.TipoDeEquipo.ToUpper())
                    {
                        case "PC":
                            TOTAL_PC++;
                            break;
                        case "LAPTOP":
                            TOTAL_LAPTOPS++;
                            break;
                        case "UPS":
                            TOTAL_UPS++;
                            break;
                        case "IMPRESORA":
                            TOTAL_IMPRESORAS++;
                            break;
                        case "MONITOR":
                            TOTAL_MONITORES++;
                            break;
                        default:
                            TOTAL_OTROS++;
                            break;
                    }
                    equipo.SN = row.Cells["NoSerie"].Value.ToString();
                    equipo.Marca = row.Cells["Marca"].Value.ToString();
                    equipo.Modelo = row.Cells["Modelo"].Value.ToString();
                    equipo.Ubicacion = row.Cells["Ubicacion"].Value.ToString();
                    equipo.Departamento = row.Cells["Departamento"].Value.ToString();
                    equipo.TicketID = row.Cells["TicketID"].Value.ToString();
                    equipo.PDFRitName = row.Cells["PDFRitName"].Value.ToString();
                    equipo.Notas = row.Cells["Notas"].Value.ToString();
                    equipo.HASH = Int32.Parse(row.Cells["HASH"].Value.ToString());

                    inventarioList.Add(equipo);
                    TOTAL_EQUIPOS++;
                }

                TOTAL_USUARIOS = USUARIOS.Count();
                #endregion


                #region ADICION DE LOS DATOS
                foreach (Inventario4ActViewModel equipo in inventarioList)
                {
                    BaseColor BACK_COLOR = equipo.IsMachineReady ? BaseColor.GREEN : BaseColor.WHITE;

                    clNo = new PdfPCell(new Phrase(equipo.Id.ToString(), standardFont));
                    clNo.BorderWidth = 0;
                    clNo.BackgroundColor = BACK_COLOR;

                    clNOMBRE = new PdfPCell(new Phrase(equipo.NOMBRE, standardFont));
                    clNOMBRE.BorderWidth = 0;
                    clNOMBRE.BackgroundColor = BACK_COLOR;

                    clNUMDEEMPLEADO = new PdfPCell(new Phrase(equipo.NumDeEmpleado, standardFont));
                    clNUMDEEMPLEADO.BorderWidth = 0;
                    clNUMDEEMPLEADO.BackgroundColor = BACK_COLOR;

                    clHOSTNAME = new PdfPCell(new Phrase(equipo.HOSTNAME, standardFont));
                    clHOSTNAME.BorderWidth = 0;
                    clHOSTNAME.BackgroundColor = BACK_COLOR;

                    clTIPODEEQUIPO = new PdfPCell(new Phrase(equipo.TipoDeEquipo, standardFont));
                    clTIPODEEQUIPO.BorderWidth = 0;
                    clTIPODEEQUIPO.BackgroundColor = BACK_COLOR;

                    clSN = new PdfPCell(new Phrase(equipo.SN, standardFont));
                    clSN.BorderWidth = 0;
                    clSN.BackgroundColor = BACK_COLOR;

                    clMARCA = new PdfPCell(new Phrase(equipo.Marca, standardFont));
                    clMARCA.BorderWidth = 0;
                    clMARCA.BackgroundColor = BACK_COLOR;

                    clMODELO = new PdfPCell(new Phrase(equipo.Modelo, standardFont));
                    clMODELO.BorderWidth = 0;
                    clMODELO.BackgroundColor = BACK_COLOR;

                    clUBICACION = new PdfPCell(new Phrase(equipo.Ubicacion, standardFont));
                    clUBICACION.BorderWidth = 0;
                    clUBICACION.BackgroundColor = BACK_COLOR;

                    clDEPARTAMENTO = new PdfPCell(new Phrase(equipo.Departamento, standardFont));
                    clDEPARTAMENTO.BorderWidth = 0;
                    clDEPARTAMENTO.BackgroundColor = BACK_COLOR;

                    clTicketID = new PdfPCell(new Phrase(equipo.TicketID, standardFont));
                    clTicketID.BorderWidth = 0;
                    clTicketID.BackgroundColor = BACK_COLOR;

                    clHASH = new PdfPCell(new Phrase(equipo.HASH.ToString(), standardFont));
                    clHASH.BorderWidth = 0;
                    clHASH.BackgroundColor = BACK_COLOR;

                    tblDatos.AddCell(clNo);
                    tblDatos.AddCell(clNOMBRE);
                    tblDatos.AddCell(clNUMDEEMPLEADO);
                    tblDatos.AddCell(clHOSTNAME);
                    tblDatos.AddCell(clTIPODEEQUIPO);
                    tblDatos.AddCell(clSN);
                    tblDatos.AddCell(clMARCA);
                    tblDatos.AddCell(clMODELO);
                    tblDatos.AddCell(clTicketID);
                    tblDatos.AddCell(clUBICACION);
                    tblDatos.AddCell(clDEPARTAMENTO);

                    if (equipo.IsMachineReady)
                    {
                        TOTAL_COMPLETADOS++;
                    }
                }
                #endregion

                doc.Add(new Phrase("Equipos registrados en la actividad", new Font(Font.FontFamily.HELVETICA, 14, Font.ITALIC)));
                doc.Add(Chunk.NEWLINE);
                #region TABLA DE DATOS GENERAL
                doc.Add(new Phrase("\n"));

                PdfPCell clLaptops = new PdfPCell(new Phrase($"Laptops: {TOTAL_LAPTOPS}", standardFont));
                PdfPCell clPCs = new PdfPCell(new Phrase($"PCs: {TOTAL_PC}", standardFont));
                PdfPCell clImpresoras = new PdfPCell(new Phrase($"Impresoras: {TOTAL_IMPRESORAS}", standardFont));
                PdfPCell clMonitores = new PdfPCell(new Phrase($"Monitores: {TOTAL_MONITORES}", standardFont));
                PdfPCell clUPS = new PdfPCell(new Phrase($"UPS: {TOTAL_UPS}", standardFont));
                PdfPCell clOtros = new PdfPCell(new Phrase($"Otros: {TOTAL_OTROS}", standardFont));
                PdfPCell clTotal = new PdfPCell(new Phrase($"Total: {TOTAL_EQUIPOS}", standardFont));
                PdfPCell clCompletados = new PdfPCell(new Phrase($"Completados: {TOTAL_COMPLETADOS}", standardFont));

                tablaGeneral.AddCell(clLaptops);
                tablaGeneral.AddCell(clPCs);
                tablaGeneral.AddCell(clImpresoras);
                tablaGeneral.AddCell(clMonitores);
                tablaGeneral.AddCell(clUPS);
                tablaGeneral.AddCell(clOtros);
                tablaGeneral.AddCell(clTotal);
                tablaGeneral.AddCell(clCompletados);
                #endregion   
                doc.Add(tablaGeneral);  // DATOS DE RESUMEN
                doc.Add(Chunk.NEWLINE);

                doc.Add(tblDatos);  // LISTADO

                // Pie de pagina de marca de documento generado por el programa
                Phrase footer = new Phrase("Generado automaticamente por RIT Solver 2024.");
                //footer.


                doc.Close();
                pw.Close();
                fs.Close();
                #endregion

                // UNIMOS LOS ARCHIVOS PDF DE LAS PARTES GENERADAS ANTERIORMENTE
                MergePDFs(new string[] { "RESULT_REPORT_PT1.pdf", "RESULT_REPORT_PT2.pdf" }, outname);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}\n{ex}", $"{Application.ProductName} - Error de generacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
