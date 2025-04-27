using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Flow_Solver
{
    internal class SAS_Methods
    {
        /* FUNCION TERMINADA */
        public static void EnterAccessSAS ()
        {
            /* FUNCION PARA ACCEDER A SAS DE GMXT
             * EJECUCION VIA MACRO
             */
            string user = Properties.Settings.Default.UsuarioDeRedIDC;
            string password = Properties.Settings.Default.EmailPasswordIDC;

            // INGRESAMOS NUESTRO USUARIO
            //SendKeys.Send("{TAB}");
            StringToKey(Properties.Settings.Default.UsuarioDeRedIDC);
            //SetWebInputs("username", user);


            // INGRESAMOS LA CONTRASEÑA
            SendKeys.Send("{TAB}");
            StringToKey(Properties.Settings.Default.EmailPasswordIDC);
            //SetWebInputs("password", password);

            // INGRESAMOS EL DOMINIO
            SendKeys.Send("{TAB}");
            if (Properties.Settings.Default.Cliente == "Ferromex (FXE)")
            {
                // FXE.GFM.NET
                StringToKey("FXE");
                SendKeys.Send("{ENTER}");
            }
            else if (Properties.Settings.Default.Cliente == "Ferrosur (FSRR)")
            {
                // FSRR.GFM.NET
                StringToKey("FSRR");
                SendKeys.Send("{ENTER}");
            }

            // MARCAMOS QUE NOS RECUERDE
            SendKeys.Send("{TAB}");
            SendKeys.Send("{ENTER}");

            // ACCEDEMOS
            //SendKeys.Send("{TAB}");
            //SendKeys.Send("{ENTER}");
        }


        /* FUNCION TERMINADA */
        public static void StringToKey(string Text)
        {
            /* Ingresa una cadena manualmente haciendo uso del teclado */
            for (int i = 0; i < Text.Length; i++)
            {
                char c = Text[i];
                SendKeys.Send($"{c.ToString()}");
            }
        }

        public static string TagScript (string Text)
        {
            string tags_script = $"<div style='font-size: 13px; font-weight: 400; color: rgb(51, 51, 51); font-family: Roboto, arial; font-style: normal; letter-spacing: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; background-color: rgb(255, 255, 255)'><b>{Text}<br></b></div>";
            return tags_script;
        }

        public static int counter = 0;

        public static void MakeReportSAS(rit_mdi_form ReportForm)
        {
            // 1. Validamos que contamos con todos los datos requeridos
            
            // Nombre del usuario
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            // Empresa
            StringToKey("FERROMEX");
            SendKeys.Send("{TAB}");
            // Ubicacion
            StringToKey("Hermosillo");
            SendKeys.Send("{TAB}");
            // Sitio
            StringToKey("Hermosillo");
            Thread.Sleep(7000);
            SendKeys.Send("{TAB}");

            // Telefono o contacto Celular
        }

        /* FUNCION EN PROCESO */
        public static void FillResolution (List<string> aAccionesTomadas, string aMarca, string aModelo, string aSerie, string aFalla)
        {
            if (counter < 1)
            {
                StringToKey("Nombre de la aplicación/módulo/servicio atendido: ");
                SendKeys.Send("{ENTER}");
                StringToKey($"Falla encontrada: {aFalla}");
                SendKeys.Send("{ENTER}");
                StringToKey("Personas afectadas: ");
                SendKeys.Send("{ENTER}");
                StringToKey($"FOLIO: {Properties.Settings.Default.NoDeReporte}");
                SendKeys.Send("{ENTER}");
                StringToKey("Solucion: ");
                SendKeys.Send("{ENTER}");

                foreach (string accion in aAccionesTomadas)
                {
                    StringToKey($"* {accion}");
                    SendKeys.Send("{ENTER}");
                }

                StringToKey($"Ing: {Properties.Settings.Default.NombreIDC}");
                SendKeys.Send("{ENTER}");
                StringToKey($"Marca/Modelo/Serie: {aMarca} / {aModelo} / {aSerie}");
                
                counter++;
            }
        }
    }

    internal class Forms_Methods
    {
        /* FUNCION TERMINADA */
        public static void FillCompusofForms (string aUsuarioFinal, string aNoDeEmpleado, string aNoDeReporte, string aTecnico, string aPoblacion, string aMes, string aDia, string aAño)
        {
            /* SE CONDUCE A PRIMER TEXTBOX */
            //SendKeys.Send("{TAB}");
            //SendKeys.Send("{TAB}");
            //SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            //MessageBox.Show("Poniendo usuario y numero de empleado");
            SAS_Methods.StringToKey(aUsuarioFinal + " / " + aNoDeEmpleado);

            /* SE CONDUCE A SEGUNDO TEXTBOX */
            SendKeys.Send("{TAB}");
            //MessageBox.Show("Poniendo numero de reporte");
            SAS_Methods.StringToKey(aNoDeReporte);

            /* SE CONDUCE A TERCER TEXTBOX (FECHA - SE CONDUCE A FORMA ESPECIAL)  */
            SendKeys.Send("{TAB}");

            //MessageBox.Show(WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE);

            //MessageBox.Show("Poniendo fecha de reporte");
            switch (WebCEFSharp_Config.Default.CEFDATA_DEFAULT_LANGUAGE)
            {
                case "en-US":
                    SendKeys.Send($"{aMes}/{aDia}/{aAño}");
                    break;
                case "es":
                    // Escritura OK
                    SendKeys.Send($"{aDia}/{aMes}/{aAño}");
                    break;
                case "en-GB":
                    SAS_Methods.StringToKey($"{aDia}/{aMes}/{aAño}");
                    break;
                case "es-419":
                    SAS_Methods.StringToKey($"{aDia}/{aMes}/{aAño}");
                    break;
            }

            /* SE CONDUCE PRIMERA EVALUACION */
            SendKeys.Send("{TAB}");
            for (int i = 0; i <= 5; i++)
            {
                SendKeys.Send("{RIGHT}");
            }

            /* SE CONDUCE SEGUNDA EVALUACION */
            SendKeys.Send("{TAB}");
            for (int i = 0; i <= 5; i++)
            {
                SendKeys.Send("{RIGHT}");
            }

            /* SE CONDUCE TERCERA EVALUACION */
            SendKeys.Send("{TAB}");
            for (int i = 0; i <= 5; i++)
            {
                SendKeys.Send("{RIGHT}");
            }

            /* SE CONDUCE CUARTA EVALUACION */
            SendKeys.Send("{TAB}");
            for (int i = 0; i <= 5; i++)
            {
                SendKeys.Send("{RIGHT}");
            }

            /* SE CONDUCE A CALIFICACION */
            SendKeys.Send("{TAB}");
            for (int i = 0; i <= 9; i++)
            {
                SendKeys.Send("{RIGHT}");
            }

            /* SE CONDUCE A NOMBRE DEL IDC */
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            SendKeys.Send(aTecnico + " / " + aPoblacion);

            //MessageBox.Show($"{aDia} / {aMes} / {aAño}");
        }
    }
}
