using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using SpreadsheetLight;

using CustomMessageBox;


namespace Flow_Solver
{
    public class ExcelMake
    {
        private static inventarios padre;
        private static string INVENTORY_PATH = $@"{Application.StartupPath}\Inventories\";


        public static void Make(inventarios LegacyForm, string aInventory)
        {
            #region METODO PARA LA CREACION DE EXCELS DE INVENTARIOS SEGUN MOLDE
            padre = LegacyForm;

            // Validamos la existencia del directorio de inventarios
            if (!Directory.Exists(INVENTORY_PATH))
            {
                Directory.CreateDirectory(INVENTORY_PATH);
            }

            CommonMethodsLibrary.OutMessage("out", "InventoriesMakers.cs", $"CREANDO INVENTARIO '{aInventory}' EN RUTA '{INVENTORY_PATH}'", "INF");

            var grilla = padre.dataGridView1;

            if (aInventory == "USUARIOS Y EQUIPOS")
            {
                #region METODO DE GENERACION

                /* INVENTARIO DE USUARIOS Y EQUIPOS */
                SLDocument nsl = new SLDocument();
                try
                {

                    int iC = 1;
                    foreach (DataGridViewColumn column in grilla.Columns)
                    {
                        nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                        iC++;
                    }

                    int iR = 2;
                    foreach (DataGridViewRow row in grilla.Rows)
                    {
                        nsl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        nsl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        nsl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        nsl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        nsl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                        nsl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                        nsl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                        nsl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                        nsl.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                        nsl.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                        nsl.SetCellValue(iR, 11, row.Cells[10].Value.ToString());
                        nsl.SetCellValue(iR, 12, row.Cells[11].Value.ToString());
                        nsl.SetCellValue(iR, 13, row.Cells[12].Value != null ? row.Cells[12].Value.ToString() : ""); // Comentarios
                        nsl.SetCellValue(iR, 14, row.Cells[13].Value != null ? row.Cells[13].Value.ToString() : ""); // Fecha de Fabricacion
                        nsl.SetCellValue(iR, 15, row.Cells[14].Value != null ? row.Cells[14].Value.ToString() : ""); // Fecha de Asignacion con el usuario actual

                        iR++;
                    }
                    nsl.SaveAs($@"{INVENTORY_PATH}\USUARIOS Y EQUIPOS.xlsx");
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString(), "Guardado de archivo de Usuarios y equipos");
                }
                #endregion
            }
            else if (aInventory == "IMPRESORAS")
            {
                #region METODO DE GENERACION
                try
                {
                    SLDocument nsl = new SLDocument();
                    int iC = 1;
                    foreach (DataGridViewColumn column in grilla.Columns)
                    {
                        nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                        iC++;
                    }

                    int iR = 2;
                    foreach (DataGridViewRow row in grilla.Rows)
                    {
                        nsl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        nsl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        nsl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        nsl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        nsl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                        iR++;
                    }

                    nsl.SaveAs($@"{INVENTORY_PATH}\IMPRESORAS.xlsx");
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString(), "Guardado de archivo de Impresoras");
                }
                #endregion
            }
            else if (aInventory == "TONERS")
            {
                #region METODO DE GENERACION
                try
                {
                    SLDocument nsl = new SLDocument();
                    int iC = 1;
                    foreach (DataGridViewColumn column in grilla.Columns)
                    {
                        nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                        iC++;
                    }

                    int iR = 2;
                    foreach (DataGridViewRow row in grilla.Rows)
                    {
                        nsl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        nsl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        nsl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        nsl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        iR++;
                    }

                    nsl.SaveAs($@"{INVENTORY_PATH}\TONERS.xlsx");
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString(), "Guardado de archivo de Toners");
                }
                #endregion
            }
            else if (aInventory == "REFACCIONES")
            {
                #region METODO DE GENERACION
                try
                {
                    SLDocument nsl = new SLDocument();
                    int iC = 1;
                    foreach (DataGridViewColumn column in grilla.Columns)
                    {
                        nsl.SetCellValue(1, iC, column.HeaderText.ToString());
                        iC++;
                    }

                    int iR = 2;
                    foreach (DataGridViewRow row in grilla.Rows)
                    {
                        nsl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        nsl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        nsl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        nsl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        nsl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                        //nsl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                        iR++;
                    }

                    nsl.SaveAs($@"{INVENTORY_PATH}\REFACCIONES.xlsx");
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.ToString(), "Guardado de archivo de Refacciones");
                }
                #endregion
            }
            #endregion
        }
            

        private static añadir_equipo PadreInventarios;
        public static bool ValidateMachineExistence(añadir_equipo aLegacyForm, DataGridView aGrilla ,string aTipoDeEquipo, string aHostname, string aNumeroDeSerie)
        {
            #region METODO PARA VALIDAR EXISTENCIA DE UN EQUIPO EN EL INVENTARIO ANTES DE AGREGAR
            bool PASS_TO_ADD = false;
            int COINCIDENCIAS_NUM = 0;
            List<string> COINCIDENCIAS_SERIE = new List<string>();
            List<string> COINCIDENCIAS_HOSTNAME = new List<string>();


            PadreInventarios = aLegacyForm;


            foreach (DataGridViewRow row in aGrilla.Rows)
            {
                string HOSTNAME = row.Cells[5].Value.ToString();
                string TIPODEEQUIPO = row.Cells[6].Value.ToString();
                string NUMERODESERIE = row.Cells[7].Value.ToString();

                //Console.WriteLine($"{TIPODEEQUIPO} / {HOSTNAME} / {NUMERODESERIE}");
                
                // Validamos que no se encuentre replicado el hostname del equipo
                if (aHostname.ToLower() == HOSTNAME.ToLower())
                {
                    if (TIPODEEQUIPO.ToUpper() == aTipoDeEquipo.ToUpper())
                    {
                        //Console.WriteLine($"{aTipoDeEquipo} - {TIPODEEQUIPO}");
                        COINCIDENCIAS_NUM++;
                        COINCIDENCIAS_HOSTNAME.Add(HOSTNAME);
                    } else
                    {
                        //Console.WriteLine("============ SIN REPETICIONES ============");
                    }
                }

                // Validamos que no se encuentre replicado el numero de serie del equipo
                if (aNumeroDeSerie.ToLower() == NUMERODESERIE.ToLower())
                {
                    COINCIDENCIAS_NUM++;
                    COINCIDENCIAS_SERIE.Add(NUMERODESERIE);
                }
            }

            if (COINCIDENCIAS_NUM != 0)
            {
                PASS_TO_ADD = false;

                StringBuilder ErrorMessage = new StringBuilder();
                ErrorMessage.Append($"Imposible agregar. Existen coincidencias para el equipo que se intenta agregar en el inventario actual para el mismo tipo ({aTipoDeEquipo})." + Environment.NewLine);

                int SERIE_COINC_LENGHT = 0;
                foreach (string i in COINCIDENCIAS_SERIE) {
                    SERIE_COINC_LENGHT++;
                }

                int HOSTNAME_COINC_LENGHT = 0;
                foreach (string i in COINCIDENCIAS_HOSTNAME)
                {
                    HOSTNAME_COINC_LENGHT++;
                }

                if (HOSTNAME_COINC_LENGHT >= 1)
                {
                    ErrorMessage.Append(Environment.NewLine + "Coincide con los siguientes HOSTNAME's: ");
                    foreach (string host in COINCIDENCIAS_HOSTNAME)
                    {
                        ErrorMessage.Append(host + $" ");
                    }
                }

                if (SERIE_COINC_LENGHT >= 1)
                {   
                    ErrorMessage.Append(Environment.NewLine + "Coincide con los siguientes numeros de serie: ");
                    foreach (string serie in COINCIDENCIAS_SERIE)
                    {
                        ErrorMessage.Append(serie + " ");
                    }
                }

                RJMessageBox.Show(ErrorMessage.ToString(), PadreInventarios.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                PASS_TO_ADD = true;
            }

            // RETORNAMOS EL VALOR QUE EL METODO HAYA RESUELTO
            return PASS_TO_ADD;
            #endregion
        }
    }
}
