using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

using SpreadsheetLight;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;



namespace Flow_Solver
{
    internal class ExcelPDFConverter
    {
        private static inventarios padre;

        public static void Initialize(inventarios Legacyform)
        {
            padre = Legacyform;
        }

        public static string MakePDFOfUsuariosYEquipos()
        {
            string PATH_RESPONSE = $@"{Application.StartupPath}\USUARIOS-Y-EQUIPOS_ToPrint.pdf";

            var grilla = padre.dataGridView1;

            FileStream fs = new FileStream(PATH_RESPONSE, FileMode.Create);
            Document doc = new Document(PageSize.LETTER.Rotate(), 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            /* VALORES PERSONALIZADOS PARA SECCION DE INFORME */
            int TOTAL_EQUIPOS = 0;
            int TOTAL_LAPTOPS = 0;
            int TOTAL_PC = 0;
            int TOTAL_USUARIOS = 0;
            int TOTAL_UPS = 0;
            int TOTAL_IMPRESORAS = 0;
            int TOTAL_MONITORES = 0;
            int TOTAL_OTROS = 0;

            List<string> USUARIOS = new List<string>();


            doc.Open();
            //doc.SetPageSize(iTextSharp.text.PageSize.LETTER_LANDSCAPE);

            // Titulo y autor del documento
            doc.AddTitle(padre.txtInventarioActual.Text);
            doc.AddAuthor(Properties.Settings.Default.NombreIDC);

            // Fuente del documento
            iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            

            // Encabezado de las columnas
            PdfPTable tblDatos = new PdfPTable(12);
            tblDatos.WidthPercentage = 100;
            PdfPTable tablaGeneral = new PdfPTable(1);
            tablaGeneral.WidthPercentage = 15;
            tablaGeneral.HorizontalAlignment = Element.ALIGN_RIGHT;

            #region CONFIGURACION DE LAS CELDAS
            // Configurando el titulo de las columnas
            PdfPCell clNOMBRE = new PdfPCell(new Phrase("Nombre", standardFont));
            clNOMBRE.BorderWidth = 0;
            clNOMBRE.BorderWidthBottom = 0.75f;

            PdfPCell clNUMDEEMPLEADO = new PdfPCell(new Phrase("No. De Emp.", standardFont));
            clNUMDEEMPLEADO.BorderWidth = 0;
            clNUMDEEMPLEADO.BorderWidthBottom = 0.75f;

            PdfPCell clEXT = new PdfPCell(new Phrase("Ext.", standardFont));
            clEXT.BorderWidth = 0;
            clEXT.BorderWidthBottom = 0.75f;

            PdfPCell clUSER = new PdfPCell(new Phrase("User", standardFont));
            clUSER.BorderWidth = 0;
            clUSER.BorderWidthBottom = 0.75f;

            PdfPCell clMAIL = new PdfPCell(new Phrase("Mail", standardFont));
            clMAIL.BorderWidth = 0;
            clMAIL.BorderWidthBottom = 0.75f;

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

            PdfPCell clUBICACION= new PdfPCell(new Phrase("Ubicacion", standardFont));
            clUBICACION.BorderWidth = 0;
            clUBICACION.BorderWidthBottom = 0.75f;

            PdfPCell clDEPARTAMENTO = new PdfPCell(new Phrase("Departamento", standardFont));
            clDEPARTAMENTO.BorderWidth = 0;
            clDEPARTAMENTO.BorderWidthBottom = 0.75f;

            
            PdfPCell clCOMENTARIOS = new PdfPCell(new Phrase("Comentarios", standardFont));
            clCOMENTARIOS.BorderWidth = 0;
            clCOMENTARIOS.BorderWidthBottom = 0.75f;
            #endregion

            #region ADICION DE CELDAS A LA TABLA
            tblDatos.AddCell(clNOMBRE);
            tblDatos.AddCell(clNUMDEEMPLEADO);
            tblDatos.AddCell(clEXT);
            tblDatos.AddCell(clUSER);
            tblDatos.AddCell(clMAIL);
            tblDatos.AddCell(clHOSTNAME);
            tblDatos.AddCell(clTIPODEEQUIPO);
            tblDatos.AddCell(clSN);
            tblDatos.AddCell(clMARCA);
            tblDatos.AddCell(clMODELO);
            tblDatos.AddCell(clUBICACION);
            tblDatos.AddCell(clDEPARTAMENTO);
            //tblDatos.AddCell(clCOMENTARIOS);
            #endregion

            #region GUARDADO DE LOS DATOS EN LISTA LOCAL
            List<InventarioViewModel> inventarioList = new List<InventarioViewModel>();

            foreach (DataGridViewRow row in grilla.Rows)
            {
                InventarioViewModel equipo = new InventarioViewModel();

                equipo.NOMBRE = row.Cells[0].Value.ToString();
                if (!USUARIOS.Contains(equipo.NOMBRE))
                {
                    USUARIOS.Add(equipo.NOMBRE);
                }
                equipo.NumDeEmpleado = row.Cells[1].Value.ToString();
                equipo.EXT = row.Cells[2].Value.ToString();
                equipo.USER = row.Cells[3].Value.ToString();
                equipo.MAIL = row.Cells[4].Value.ToString();
                equipo.HOSTNAME = row.Cells[5].Value.ToString();
                equipo.TipoDeEquipo = row.Cells[6].Value.ToString();
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
                equipo.SN = row.Cells[7].Value.ToString();
                equipo.Marca = row.Cells[8].Value.ToString();
                equipo.Modelo = row.Cells[9].Value.ToString();
                equipo.Ubicacion = row.Cells[10].Value.ToString();
                equipo.Departamento = row.Cells[11].Value.ToString();
                //equipo.Comentarios = row.Cells[12].Value.ToString();

                inventarioList.Add(equipo);
                TOTAL_EQUIPOS++;
            }

            TOTAL_USUARIOS = USUARIOS.Count();
            #endregion

            #region ADICION DE LOS DATOS
            foreach (InventarioViewModel equipo in inventarioList)
            {
                clNOMBRE = new PdfPCell(new Phrase(equipo.NOMBRE, standardFont));
                clNOMBRE.BorderWidth = 0;

                clNUMDEEMPLEADO = new PdfPCell(new Phrase(equipo.NumDeEmpleado, standardFont));
                clNUMDEEMPLEADO.BorderWidth = 0;

                clEXT = new PdfPCell(new Phrase(equipo.EXT, standardFont));
                clEXT.BorderWidth = 0;

                clUSER = new PdfPCell(new Phrase(equipo.USER, standardFont));
                clUSER.BorderWidth = 0;

                clMAIL = new PdfPCell(new Phrase(equipo.MAIL, standardFont));
                clMAIL.BorderWidth = 0;

                clHOSTNAME = new PdfPCell(new Phrase(equipo.HOSTNAME, standardFont));
                clHOSTNAME.BorderWidth = 0;

                clTIPODEEQUIPO = new PdfPCell(new Phrase(equipo.TipoDeEquipo, standardFont));
                clTIPODEEQUIPO.BorderWidth = 0;

                clSN = new PdfPCell(new Phrase(equipo.SN, standardFont));
                clSN.BorderWidth = 0;

                clMARCA = new PdfPCell(new Phrase(equipo.Marca, standardFont));
                clMARCA.BorderWidth = 0;

                clMODELO = new PdfPCell(new Phrase(equipo.Modelo, standardFont));
                clMODELO.BorderWidth = 0;

                clUBICACION = new PdfPCell(new Phrase(equipo.Ubicacion, standardFont));
                clUBICACION.BorderWidth = 0;

                clDEPARTAMENTO = new PdfPCell(new Phrase(equipo.Departamento, standardFont));
                clDEPARTAMENTO.BorderWidth = 0;

                clCOMENTARIOS = new PdfPCell(new Phrase(equipo.Comentarios, standardFont));
                clCOMENTARIOS.BorderWidth = 0;

                tblDatos.AddCell(clNOMBRE);
                tblDatos.AddCell(clNUMDEEMPLEADO);
                tblDatos.AddCell(clEXT);
                tblDatos.AddCell(clUSER);
                tblDatos.AddCell(clMAIL);
                tblDatos.AddCell(clHOSTNAME);
                tblDatos.AddCell(clTIPODEEQUIPO);
                tblDatos.AddCell(clSN);
                tblDatos.AddCell(clMARCA);
                tblDatos.AddCell(clMODELO);
                tblDatos.AddCell(clUBICACION);
                tblDatos.AddCell(clDEPARTAMENTO);
                //tblDatos.AddCell(clCOMENTARIOS);
            }
            #endregion

            // Encabezado del documento
            doc.Add(new Paragraph(padre.txtInventarioActual.Text));
            /*
            doc.Add(new Phrase(Properties.Settings.Default.NombreIDC + "\n", standardFont));
            doc.Add(new Phrase(Properties.Settings.Default.LocalidadIDC + "\n", standardFont));

            // Fecha actual
            DateTime dt = DateTime.Now;
            string AÑO = dt.Year.ToString();
            string MES = dt.Month.ToString();
            string DIA = dt.Day.ToString();
            doc.Add(new Phrase($"{DIA} / {MES} / {AÑO}", standardFont));*/

            #region AÑADIMOS VALORES DE INFORMO
            // Adicion de encabezados de titulo
            string INFORME = $"Total de equipos: {TOTAL_EQUIPOS}\n" +
                $"Total de usuarios: {TOTAL_USUARIOS}\n" +
                $"Laptops: {TOTAL_LAPTOPS}\n" +
                $"PC's: {TOTAL_PC}\n" +
                $"Impresoras: {TOTAL_IMPRESORAS}\n" +
                $"Monitores: {TOTAL_MONITORES}\n" +
                $"UPS: {TOTAL_UPS}\n" +
                $"Otros: {TOTAL_OTROS}\n";
            /*
            PdfPCell clINVENTARIO_ACTUAL = new PdfPCell(new Paragraph(padre.txtInventarioActual.Text, standardFont));
            clINVENTARIO_ACTUAL.BorderWidth = 0;
            clINVENTARIO_ACTUAL.BorderWidthBottom = 0.75f;
            tablaGeneral.AddCell(clINVENTARIO_ACTUAL);
            */

            PdfPCell clDATOS = new PdfPCell(new Paragraph(INFORME, standardFont));
            clDATOS.BorderWidth = 0;
            clDATOS.BorderWidthBottom = 0.75f;
            tablaGeneral.AddCell(clDATOS);
            #endregion
            doc.Add(tablaGeneral);
            doc.Add(Chunk.NEWLINE);

            
            doc.Add(tblDatos);      // Añadimos la tabla al PDF

            doc.Close();
            pw.Close();

            return PATH_RESPONSE;
        }


        public static string MakePDFOfImpresoras()
        {
            string PATH_RESPONSE = $@"{Application.StartupPath}\IMPRESORAS_ToPrint.pdf";

            var grilla = padre.dataGridView1;

            FileStream fs = new FileStream(PATH_RESPONSE, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);


            doc.Open();

            // Titulo y autor del documento
            doc.AddTitle(padre.txtInventarioActual.Text);
            doc.AddAuthor(Properties.Settings.Default.NombreIDC);

            // Fuente del documento
            iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Encabezado del documento
            doc.Add(new Paragraph(padre.txtInventarioActual.Text));
            doc.Add(Chunk.NEWLINE);


            // Encabezado de las columnas
            PdfPTable tblDatos = new PdfPTable(5);
            tblDatos.WidthPercentage = 100;


            #region CONFIGURACION DE LAS CELDAS
            // Configurando el titulo de las columnas
            PdfPCell clIMPRESORA = new PdfPCell(new Phrase("Impresora", standardFont));
            clIMPRESORA.BorderWidth = 0;
            clIMPRESORA.BorderWidthBottom = 0.75f;

            PdfPCell clMARCA = new PdfPCell(new Phrase("Marca", standardFont));
            clMARCA.BorderWidth = 0;
            clMARCA.BorderWidthBottom = 0.75f;

            PdfPCell clMODELO = new PdfPCell(new Phrase("Modelo", standardFont));
            clMODELO.BorderWidth = 0;
            clMODELO.BorderWidthBottom = 0.75f;

            PdfPCell clUBICACION = new PdfPCell(new Phrase("Ubicacion", standardFont));
            clUBICACION.BorderWidth = 0;
            clUBICACION.BorderWidthBottom = 0.75f;

            PdfPCell clIP = new PdfPCell(new Phrase("IP", standardFont));
            clIP.BorderWidth = 0;
            clIP.BorderWidthBottom = 0.75f;
            #endregion

            #region ADICION DE CELDAS A LA TABLA
            tblDatos.AddCell(clIMPRESORA);
            tblDatos.AddCell(clMARCA);
            tblDatos.AddCell(clMODELO);
            tblDatos.AddCell(clUBICACION);
            tblDatos.AddCell(clIP);
            //tblDatos.AddCell(clCOMENTARIOS);
            #endregion

            #region GUARDADO DE LOS DATOS EN LISTA LOCAL
            List<ImpresorasViewModel> inventarioList = new List<ImpresorasViewModel>();

            foreach (DataGridViewRow row in grilla.Rows)
            {
                ImpresorasViewModel impresora = new ImpresorasViewModel();

                impresora.Impresora = row.Cells[0].Value.ToString();
                impresora.Marca = row.Cells[1].Value.ToString();
                impresora.Modelo = row.Cells[2].Value.ToString();
                impresora.Ubicacion = row.Cells[3].Value.ToString();
                impresora.IP = row.Cells[4].Value.ToString();

                inventarioList.Add(impresora);
            }
            #endregion

            #region ADICION DE LOS DATOS
            foreach (ImpresorasViewModel impresora in inventarioList)
            {
                clIMPRESORA = new PdfPCell(new Phrase(impresora.Impresora, standardFont));
                clIMPRESORA.BorderWidth = 0;

                clMARCA = new PdfPCell(new Phrase(impresora.Marca, standardFont));
                clMARCA.BorderWidth = 0;

                clMODELO = new PdfPCell(new Phrase(impresora.Modelo, standardFont));
                clMODELO.BorderWidth = 0;

                clUBICACION = new PdfPCell(new Phrase(impresora.Ubicacion, standardFont));
                clUBICACION.BorderWidth = 0;

                clIP = new PdfPCell(new Phrase(impresora.IP, standardFont));
                clIP.BorderWidth = 0;

                tblDatos.AddCell(clIMPRESORA);
                tblDatos.AddCell(clMARCA);
                tblDatos.AddCell(clMODELO);
                tblDatos.AddCell(clUBICACION);
                tblDatos.AddCell(clIP);
            }
            #endregion

            doc.Add(tblDatos); // Añadimos la tabla al PDF

            doc.Close();
            pw.Close();

            return PATH_RESPONSE;
        }
    }
}
