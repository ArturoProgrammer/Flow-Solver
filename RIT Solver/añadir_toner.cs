using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using SpreadsheetLight;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class añadir_toner : Form
    {

        string INVENT_PATH = $@"{Application.StartupPath}\Inventories\TONERS.xlsx";
        private inventarios padre;
        public añadir_toner(inventarios LegacyForm)
        {
            InitializeComponent();
            padre = LegacyForm;
        }

        private void GuardarToner ()
        {
            if (RJMessageBox.Show("¿Desea añadir este nuevo toner?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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
                        ExcelMake.Make(padre, "TONERS");

                        // Paso 2
                        SLDocument sl = new SLDocument(INVENT_PATH);
                        List<TonersViewModel> lst = new List<TonersViewModel>();

                        int iRow = 2;

                        while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                        {
                            TonersViewModel oToner = new TonersViewModel();

                            oToner.Modelo = sl.GetCellValueAsString(iRow, 1);
                            oToner.Marca = sl.GetCellValueAsString(iRow, 2);
                            oToner.Descripcion = sl.GetCellValueAsString(iRow, 3);
                            oToner.Cantidad = sl.GetCellValueAsString(iRow, 4);

                            lst.Add(oToner);

                            iRow++;
                        }

                        iRow++;
                        // Paso 3
                        TonersViewModel Toner = new TonersViewModel();

                        Toner.Modelo = this.txtModelo.Text;
                        Toner.Marca = this.txtMarca.Text;
                        Toner.Descripcion = this.txtDescripcion.Text;
                        Toner.Cantidad = this.numericCantidadToner.Text;

                        lst.Add(Toner);
                        grilla.DataSource = lst;

                        // Paso 4
                        ExcelMake.Make(padre, "TONERS");

                        // Guardamos estado
                        padre.WAS_EDIT_FLAG = false;
                        // Cerramos ventana de dialogo
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show(ex.Message, this.Text);
                    }
                    #endregion
                }
            }
        }

        private void añadir_toner_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarToner();
        }

        private void numericCantidadToner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                // Guardamos el nuevo toner
                GuardarToner();
            }
        }

        string ERR_MSG = "Debes llenar el campo!";
        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, ERR_MSG);
            } else
            {
                errorProvider1.SetError(txtModelo, "");

            }
        }

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(txtMarca, "");

            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");

            }
        }

        private void numericCantidadToner_Validating(object sender, CancelEventArgs e)
        {
            if (numericCantidadToner.Value < 1)
            {
                errorProvider1.SetError(numericCantidadToner, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(numericCantidadToner, "");

            }
        }
    }
}
