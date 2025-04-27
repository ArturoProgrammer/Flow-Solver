using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;
using SpreadsheetLight;

using CustomMessageBox;

namespace Flow_Solver
{
    internal class Filter
    {
        private static dynamic padre;

        /// <summary>
        /// Inicializa la clase constructora para poder operar los metodos de la clase.
        /// </summary>
        /// <param name="LegacyForm">Formulario padre</param>
        public static void Initialize(search_on_inventory LegacyForm)
        {
            // Carga los datos filtrados al datagrid
            padre = LegacyForm;
            padre.dataGridView1.DataSource = null;

        }

        public static void Initialize(inventarios LegacyForm)
        {
            // Carga los datos filtrados al datagrid
            padre = LegacyForm;
            padre.dataGridView1.DataSource = null;

        }


        /// <summary>
        /// Metodo de busqueda en el inventario de 'Usuarios y Equipos'. Despliega los resultados en el DataGridView indicado.
        /// </summary>
        /// <param name="aDatoBuscar">Dato en el que se basara la busqueda y filtrado.</param>
        /// <param name="aDondeBuscar">Columna en la que se encuentra el dato que quiere filtrar.</param>
        /// <returns>Lista de clase 'InventarioViewModel' con los resultados del filtrado del inventario.</returns>
        public static List<InventarioViewModel> UsuariosYEquipos_Filtro(string aDatoBuscar, string aDondeBuscar, bool aCoincidirCeldaCompleta, bool aIgnorarMayusculasMinusculas, DataGridView EmulatedDGV)
        {
            List<InventarioViewModel> lst = new List<InventarioViewModel>();

            var grilla = EmulatedDGV;
            int DATO_ENCONTRADO = 0;

            try
            {
                int iRow = 2;
                SLDocument sl = new SLDocument($@"{Application.StartupPath}\Inventories\USUARIOS Y EQUIPOS.xlsx");

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    InventarioViewModel equipo = new InventarioViewModel();

                    equipo.NOMBRE = sl.GetCellValueAsString(iRow, 1);
                    equipo.NumDeEmpleado = sl.GetCellValueAsString(iRow, 2);
                    equipo.EXT = sl.GetCellValueAsString(iRow, 3);
                    equipo.USER = sl.GetCellValueAsString(iRow, 4);
                    equipo.MAIL = sl.GetCellValueAsString(iRow, 5);
                    equipo.HOSTNAME = sl.GetCellValueAsString(iRow, 6);
                    equipo.TipoDeEquipo = sl.GetCellValueAsString(iRow, 7);
                    equipo.SN = sl.GetCellValueAsString(iRow, 8);
                    equipo.Marca = sl.GetCellValueAsString(iRow, 9);
                    equipo.Modelo = sl.GetCellValueAsString(iRow, 10);
                    equipo.Ubicacion = sl.GetCellValueAsString(iRow, 11);
                    equipo.Departamento = sl.GetCellValueAsString(iRow, 12);
                    equipo.Comentarios = sl.GetCellValueAsString(iRow, 13);

                    string VALOR_ANALIZANDO = grilla.Rows[iRow - 2].Cells[aDondeBuscar].Value.ToString();
                    if (aIgnorarMayusculasMinusculas)
                    {
                        aDatoBuscar = aDatoBuscar.ToLower();
                        VALOR_ANALIZANDO = VALOR_ANALIZANDO.ToLower();
                    }

                    if (aCoincidirCeldaCompleta)
                    {
                        if (aDatoBuscar == VALOR_ANALIZANDO)
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(equipo);
                        }
                    }
                    else
                    {
                        if (Regex.IsMatch(VALOR_ANALIZANDO, @aDatoBuscar))
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(equipo);
                        }
                    }
                    iRow++;
                }


                if (DATO_ENCONTRADO == 0)
                {
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                } else
                {
                    Console.WriteLine("MULTIPLES COINCIDENCIAS ENCONTRADAS");
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                    //padre.dataGridView1.DataSource = lst;
                }

                if (padre != null)
                {
                    padre.UpdateJob(true);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.ToString(), "Error");
                try
                {
                    padre.UpdateJob(false);
                }
                catch (Exception ex2) { }
            }
            return lst;
        }


        /// <summary>
        /// Metodo de busqueda en el inventario de 'Impresoras'. Despliega los resultados en el DataGridView indicado.
        /// </summary>
        /// <param name="aDatoBuscar">Dato en el que se basara la busqueda y filtrado.</param>
        /// <param name="aDondeBuscar">Columna en la que se encuentra el dato que quiere filtrar.</param>
        /// <returns>Lista de clase 'ImpresorasViewModel' con los resultados del filtrado del inventario.</returns>
        public static List<ImpresorasViewModel> Impresoras_Filtro (string aDatoBuscar, string aDondeBuscar, bool aCoincidirCeldaCompleta, bool aIgnorarMayusculasMinusculas, DataGridView EmulatedDGV)
        {
            List<ImpresorasViewModel> lst = new List<ImpresorasViewModel>();

            /** CODEAR APARTIR DE AQUI **/

            var grilla = EmulatedDGV;
            int DATO_ENCONTRADO = 0;

            try
            {
                int iRow = 2;
                SLDocument sl = new SLDocument($@"{Application.StartupPath}\Inventories\IMPRESORAS.xlsx");

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    ImpresorasViewModel equipo = new ImpresorasViewModel();

                    equipo.Impresora = sl.GetCellValueAsString(iRow, 1);
                    equipo.Marca = sl.GetCellValueAsString(iRow, 2);
                    equipo.Modelo = sl.GetCellValueAsString(iRow, 3);
                    equipo.Ubicacion = sl.GetCellValueAsString(iRow, 4);
                    equipo.IP = sl.GetCellValueAsString(iRow, 5);

                    string VALOR_ANALIZANDO = grilla.Rows[iRow - 2].Cells[aDondeBuscar].Value.ToString();
                    if (aIgnorarMayusculasMinusculas)
                    {
                        aDatoBuscar = aDatoBuscar.ToLower();
                        VALOR_ANALIZANDO = VALOR_ANALIZANDO.ToLower();
                    }

                    if (aCoincidirCeldaCompleta)
                    {
                        if (aDatoBuscar == VALOR_ANALIZANDO)
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(equipo);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{VALOR_ANALIZANDO} //// {aDatoBuscar}");
                        if (Regex.IsMatch(VALOR_ANALIZANDO, @aDatoBuscar))
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(equipo);
                        }
                    }
                    iRow++;
                }


                if (DATO_ENCONTRADO == 0)
                {
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                }
                else
                {
                    Console.WriteLine("MULTIPLES COINCIDENCIAS ENCONTRADAS");
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                    //padre.dataGridView1.DataSource = lst;
                }

                if (padre != null)
                {
                    padre.UpdateJob(true);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.ToString(), "Error");
                try
                {
                    padre.UpdateJob(false);
                }
                catch { }
            }


            return lst;
        }


        /// <summary>
        /// Metodo de busqueda en el inventario de 'Toners'. Despliega los resultados en el DataGridView indicado.
        /// </summary>
        /// <param name="aDatoBuscar">Dato en el que se basara la busqueda y filtrado.</param>
        /// <param name="aDondeBuscar">Columna en la que se encuentra el dato que quiere filtrar.</param>
        /// <returns>Lista de clase 'TonersViewModel' con los resultados del filtrado del inventario.</returns>
        public static List<TonersViewModel> Toners_Filtro(string aDatoBuscar, string aDondeBuscar, bool aCoincidirCeldaCompleta, bool aIgnorarMayusculasMinusculas, DataGridView EmulatedDGV)
        {
            List<TonersViewModel> lst = new List<TonersViewModel>();

            /** CODEAR APARTIR DE AQUI **/
            var grilla = EmulatedDGV;
            int DATO_ENCONTRADO = 0;

            Console.WriteLine($"SE BUSCARA: {aDatoBuscar} // EN: {aDondeBuscar}");

            try
            {
                int iRow = 2;
                int i = 0;
                SLDocument sl = new SLDocument($@"{Application.StartupPath}\Inventories\TONERS.xlsx");

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    TonersViewModel oToner = new TonersViewModel();

                    Console.WriteLine($"CARGADO UN DATO {i}");
                    i++;

                    oToner.Modelo = sl.GetCellValueAsString(iRow, 1);
                    oToner.Marca = sl.GetCellValueAsString(iRow, 2);
                    oToner.Descripcion = sl.GetCellValueAsString(iRow, 3);
                    oToner.Cantidad = sl.GetCellValueAsString(iRow, 4);

                    Console.WriteLine("DATOS CARGADOS");

                    string VALOR_ANALIZANDO = grilla.Rows[iRow - 2].Cells[aDondeBuscar].Value.ToString();
                    Console.WriteLine("ASIGNACION DE VALOR A ANALIZAR");

                    if (aIgnorarMayusculasMinusculas)
                    {
                        aDatoBuscar = aDatoBuscar.ToLower();
                        VALOR_ANALIZANDO = VALOR_ANALIZANDO.ToLower();
                    }

                    if (aCoincidirCeldaCompleta)
                    {
                        if (aDatoBuscar == VALOR_ANALIZANDO)
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(oToner);
                        }
                    }
                    else
                    {
                        if (Regex.IsMatch(VALOR_ANALIZANDO, @aDatoBuscar))
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(oToner);
                        }
                    }
                    iRow++;
                }


                if (DATO_ENCONTRADO == 0)
                {
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                }
                else
                {
                    Console.WriteLine("MULTIPLES COINCIDENCIAS ENCONTRADAS");
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                    //padre.dataGridView1.DataSource = lst;
                }

                if (padre != null)
                {
                    padre.UpdateJob(true);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.ToString(), "Error");
                try
                {
                    padre.UpdateJob(true);
                } catch { }
            }

            return lst;
        }


        /// <summary>
        /// Metodo de busqueda en el inventario de 'Refacciones'. Despliega los resultados en el DataGridView indicado.
        /// </summary>
        /// <param name="aDatoBuscar">Dato en el que se basara la busqueda y filtrado.</param>
        /// <param name="aDondeBuscar">Columna en la que se encuentra el dato que quiere filtrar.</param>
        /// <returns>Lista de clase 'RefaccionesViewModel' con los resultados del filtrado del inventario.</returns>
        public static List<RefaccionesViewModel> Refacciones_Filtro(string aDatoBuscar, string aDondeBuscar, bool aCoincidirCeldaCompleta, bool aIgnorarMayusculasMinusculas, DataGridView EmulatedDGV)
        {
            List<RefaccionesViewModel> lst = new List<RefaccionesViewModel>();

            /** CODEAR APARTIR DE AQUI **/
            var grilla = EmulatedDGV;
            int DATO_ENCONTRADO = 0;

            try
            {
                int iRow = 2;
                SLDocument sl = new SLDocument($@"{Application.StartupPath}\Inventories\REFACCIONES.xlsx");

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    RefaccionesViewModel oRefaccion = new RefaccionesViewModel();

                    oRefaccion.Marca = sl.GetCellValueAsString(iRow, 1);
                    oRefaccion.Descripcion = sl.GetCellValueAsString(iRow, 2);
                    oRefaccion.Modelo = sl.GetCellValueAsString(iRow, 3);
                    oRefaccion.Serie = sl.GetCellValueAsString(iRow, 4);
                    oRefaccion.Ubicacion = sl.GetCellValueAsString(iRow, 5);

                    string VALOR_ANALIZANDO = grilla.Rows[iRow - 2].Cells[aDondeBuscar].Value.ToString();
                    if (aIgnorarMayusculasMinusculas)
                    {
                        aDatoBuscar = aDatoBuscar.ToLower();
                        VALOR_ANALIZANDO = VALOR_ANALIZANDO.ToLower();
                    }

                    
                    if (aCoincidirCeldaCompleta)
                    {
                        if (aDatoBuscar == VALOR_ANALIZANDO)
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(oRefaccion);
                        }
                    } else
                    {
                        if (Regex.IsMatch(VALOR_ANALIZANDO, @aDatoBuscar))
                        {
                            DATO_ENCONTRADO++;
                            lst.Add(oRefaccion);
                        }
                    }
                    iRow++;
                }


                if (DATO_ENCONTRADO == 0)
                {
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                }
                else
                {
                    Console.WriteLine("MULTIPLES COINCIDENCIAS ENCONTRADAS");
                    if (padre != null)
                    {
                        padre.UpdateResultsFound(DATO_ENCONTRADO);
                    }
                    //padre.dataGridView1.DataSource = lst;
                }

                if (padre != null)
                {
                    padre.UpdateJob(true);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.ToString(), "Error");
                try
                {
                    padre.UpdateJob(true);
                }
                catch { }
            }

            return lst;
        }
    }
}
