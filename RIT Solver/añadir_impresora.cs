using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SpreadsheetLight;
using System.IO;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class añadir_impresora : Form
    {
        private inventarios padre;
        string INVENT_PATH = $@"{Application.StartupPath}\Inventories\IMPRESORAS.xlsx";
        public añadir_impresora(inventarios LegacyForm)
        {
            InitializeComponent();
            padre = LegacyForm;
        }


        

        private void AñadirYGuardarImpresora ()
        {
            if (RJMessageBox.Show("¿Desea añadir esta nueva impresora?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (File.Exists(INVENT_PATH))
                {
                    /*
                    * 1 - SE GUARDA GRILLA ACTUAL COMO EXCEL
                    * 2 - SE GENERA LISTA DE DATOS DE EXCEL
                    * 3 - SE AÑADE NUEVO DATO A LISTA
                    * 4 - SE GRABA LISTA COMO EXCEL
                    * */
                    #region CREACION DE DATOS A GRABAR
                    var grilla = padre.dataGridView1;

                    try
                    {
                        // Paso 1
                        ExcelMake.Make(padre, "IMPRESORAS");

                        // Paso 2
                        SLDocument sl = new SLDocument(INVENT_PATH);
                        List<ImpresorasViewModel> lst = new List<ImpresorasViewModel>();
                        
                        int iRow = 2;
                        
                        while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                        {

                            ImpresorasViewModel oImpresora = new ImpresorasViewModel();

                            oImpresora.Impresora = sl.GetCellValueAsString(iRow, 1);
                            oImpresora.Marca = sl.GetCellValueAsString(iRow, 2);
                            oImpresora.Modelo = sl.GetCellValueAsString(iRow, 3);
                            oImpresora.Ubicacion = sl.GetCellValueAsString(iRow, 4);
                            oImpresora.IP = sl.GetCellValueAsString(iRow, 5);

                            lst.Add(oImpresora);

                            iRow++;
                        }

                        iRow++;
                        // Paso 3
                        ImpresorasViewModel Impresora = new ImpresorasViewModel();

                        Impresora.Impresora = this.txtImpresora.Text;
                        Impresora.Marca = this.txtMarca.Text;
                        Impresora.Modelo = this.txtModelo.Text;
                        Impresora.Ubicacion = this.txtUbicacion.Text;
                        Impresora.IP = this.txtIP.Text;

                        lst.Add(Impresora);
                        grilla.DataSource = lst;

                        // Paso 4
                        ExcelMake.Make(padre, "IMPRESORAS");

                        // Guardamos estado
                        padre.WAS_EDIT_FLAG = false;
                        // Cerramos ventana de dialogo
                        this.Close();
                    } catch (Exception ex)
                    {
                        RJMessageBox.Show(ex.Message, this.Text);
                    }
                    #endregion
                }
            }
        }

        private void modificar_equipo_Load(object sender, EventArgs e)
        {
            /* CARGAMOS LOS VALORES POR DEFECTO */            
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                // Guardamos la impresora nueva
                AñadirYGuardarImpresora();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AñadirYGuardarImpresora();
        }
    }
}
