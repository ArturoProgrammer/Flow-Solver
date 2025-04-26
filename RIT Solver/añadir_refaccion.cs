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
    public partial class añadir_refaccion : Form
    {
        private inventarios padre;
        string INVENT_PATH = $@"{Application.StartupPath}\Inventories\REFACCIONES.xlsx";

        public añadir_refaccion(inventarios LegacyForm)
        {
            InitializeComponent();
            padre = LegacyForm;
        }

        private void GuardarNuevaRefaccion()
        {
            if (RJMessageBox.Show("¿Desea añadir esta nueva refaccion?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                        ExcelMake.Make(padre, "REFACCIONES");

                        // Paso 2
                        SLDocument sl = new SLDocument(INVENT_PATH);
                        List<RefaccionesViewModel> lst = new List<RefaccionesViewModel>();

                        int iRow = 2;

                        while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                        {
                            RefaccionesViewModel oRefaccion = new RefaccionesViewModel();

                            oRefaccion.Marca = sl.GetCellValueAsString(iRow, 1);
                            oRefaccion.Descripcion = sl.GetCellValueAsString(iRow, 2);
                            oRefaccion.Modelo = sl.GetCellValueAsString(iRow, 3);
                            oRefaccion.Serie = sl.GetCellValueAsString(iRow, 4);
                            oRefaccion.Ubicacion = sl.GetCellValueAsString(iRow, 5);
                            //oRefaccion.Comentario = sl.GetCellValueAsString(iRow, 6);

                            lst.Add(oRefaccion);

                            iRow++;
                        }

                        iRow++;
                        // Paso 3
                        RefaccionesViewModel Refaccion = new RefaccionesViewModel();

                        Refaccion.Marca = this.txtMarca.Text;
                        Refaccion.Descripcion = this.txtDescripcion.Text;
                        Refaccion.Modelo = this.txtModelo.Text;
                        Refaccion.Serie = this.txtSerie.Text;
                        Refaccion.Ubicacion = this.txtUbicacion.Text;
                        //Refaccion.Comentario = this.txtComentario.Text;

                        lst.Add(Refaccion);
                        grilla.DataSource = lst;

                        // Paso 4
                        ExcelMake.Make(padre, "REFACCIONES");

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

        private void añadir_refaccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevaRefaccion();
        }

        string ERR_MSG = "Debes llenar este campo!";

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, ERR_MSG);
            } else
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

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(txtModelo, "");
            }
        }

        private void txtSerie_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSerie.Text))
            {
                errorProvider1.SetError(txtSerie, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(txtSerie, "");
            }
        }

        private void txtUbicacion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUbicacion.Text))
            {
                errorProvider1.SetError(txtUbicacion, ERR_MSG);
            }
            else
            {
                errorProvider1.SetError(txtUbicacion, "");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
