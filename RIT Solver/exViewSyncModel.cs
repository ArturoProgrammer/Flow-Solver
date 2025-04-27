using FuzzyString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class exViewSyncModel : Form
    {
        public enum StartOption
        {
            CREATE,
            READ,
            UPDATE,
            DELETE,
        }

        public MachineModelSyncItem RESPONSE = new MachineModelSyncItem();

        public exViewSyncModel(StartOption LegacyStartOption)
        {
            InitializeComponent();

            switch (LegacyStartOption)
            {
                case StartOption.CREATE:
                    this.Text = "Creacion de un Nuevo Objeto";
                    break;
            }
        }

        public exViewSyncModel(StartOption LegacyStartOption, string CodeNameModel)
        {
            InitializeComponent();

            switch (LegacyStartOption)
            {
                case StartOption.CREATE:
                    this.Text = "Creacion de un Nuevo Objeto";
                    this.txtNombreClave.Text = CodeNameModel;
                    break;
            }
        }

        public exViewSyncModel(MachineModelSyncItem LegacyMachineModel, StartOption LegacyStartOption)
        {
            InitializeComponent();


            switch (LegacyStartOption)
            {
                case StartOption.CREATE:
                    this.Text = "Creacion de un Nuevo Objeto";
                    break;
                case StartOption.READ:
                    this.Text = "Visualizacion del Objeto";

                    this.txtNombreClave.Text = LegacyMachineModel.NombreClave;
                    this.txtNombreComercial.Text = LegacyMachineModel.NombreComercial;
                    this.txtMarca.Text = LegacyMachineModel.Marca;
                    this.cboxTipo.Text = LegacyMachineModel.Tipo;
                    this.txtProcesador.Text = LegacyMachineModel.Procesador;
                    this.txtFrecuenciaProcesador.Text = LegacyMachineModel.Frecuencia.ToString();
                    this.numericRam.Value = LegacyMachineModel.RAM;
                    this.cboxAlmacenamientoTipo.Text = LegacyMachineModel.TipoAlmacenamiento;
                    this.numericHDD.Value = LegacyMachineModel.AlmacenamientoHDD;
                    this.numericSSD.Value = LegacyMachineModel.AlmacenamientoSSD;
                    this.chckboxUnidadOptica.Checked = LegacyMachineModel.TieneUnidadOptica;
                    this.txtPathImagen.Text = LegacyMachineModel.ProfileImagePath;

                    this.txtNombreClave.Enabled = false;
                    this.txtNombreComercial.Enabled = false;
                    this.txtMarca.Enabled = false;
                    this.cboxTipo.Enabled = false;

                    this.txtProcesador.Enabled = false;
                    this.txtFrecuenciaProcesador.Enabled = false;
                    this.numericRam.Enabled = false;
                    this.cboxAlmacenamientoTipo.Enabled = false;
                    this.numericHDD.Enabled = false;
                    this.numericSSD.Enabled = false;
                    this.chckboxUnidadOptica.Enabled = false;

                    this.btnGuardar.Enabled = false;
                    break;
                case StartOption.UPDATE:
                    this.Text = "Edicion del Objeto";

                    this.txtNombreClave.Text = LegacyMachineModel.NombreClave;
                    this.txtNombreComercial.Text = LegacyMachineModel.NombreComercial;
                    this.txtMarca.Text = LegacyMachineModel.Marca;
                    this.cboxTipo.Text = LegacyMachineModel.Tipo;
                    this.txtProcesador.Text = LegacyMachineModel.Procesador;
                    this.txtFrecuenciaProcesador.Text = LegacyMachineModel.Frecuencia.ToString();
                    this.numericRam.Value = LegacyMachineModel.RAM;
                    this.cboxAlmacenamientoTipo.Text = LegacyMachineModel.TipoAlmacenamiento;
                    this.numericHDD.Value = LegacyMachineModel.AlmacenamientoHDD;
                    this.numericSSD.Value = LegacyMachineModel.AlmacenamientoSSD;
                    this.chckboxUnidadOptica.Checked = LegacyMachineModel.TieneUnidadOptica;
                    this.txtPathImagen.Text = LegacyMachineModel.ProfileImagePath;
                    break;
                case StartOption.DELETE:
                    break;
            }
        }

        private void exViewSyncModel_Load(object sender, EventArgs e)
        {

        }

        bool IsAnswered = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_MultiValidator(0) && _MultiValidator(1) && _MultiValidator(2) && _MultiValidator(3) && _MultiValidator(4) && _MultiValidator(5) && _MultiValidator(6) && _MultiValidator(7) && _MultiValidator(8) && _MultiValidator(9)) 
                {
                    // Guardamos el elemento
                    MachineModelSyncItem m = new MachineModelSyncItem();
                    m.NombreClave = txtNombreClave.Text.Trim();
                    m.NombreComercial = txtNombreComercial.Text.Trim();
                    m.Marca = txtMarca.Text.Trim();
                    m.Tipo = cboxTipo.Text;

                    m.Procesador = txtProcesador.Text.Trim();
                    m.Frecuencia = decimal.Parse(txtFrecuenciaProcesador.Text);
                    m.RAM = Int32.Parse(numericRam.Value.ToString());
                    m.TipoAlmacenamiento = cboxAlmacenamientoTipo.Text;
                    m.AlmacenamientoSSD = (int)numericSSD.Value;
                    m.AlmacenamientoHDD = (int)numericHDD.Value;
                    m.TieneUnidadOptica = chckboxUnidadOptica.Checked;

                    FileInfo fi = new FileInfo(this.txtPathImagen.Text);
                    m.ProfileImagePath = fi.Name;

                    RESPONSE = m;
                    IsAnswered = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                IsAnswered = false;
            }
        }

        private void exViewSyncModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAnswered)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        bool _MultiValidator(int index)
        {
            bool _response = false;
            Control ctrl = new Control();


            switch (index)
            {
                case 0:
                    ctrl = txtNombreClave;
                    break;
                case 1:
                    ctrl = txtNombreComercial;
                    break;
                case 2:
                    ctrl = txtMarca;
                    break;
                case 3:
                    ctrl = cboxTipo;
                    break;
                case 4:
                    ctrl = txtProcesador;
                    break;
                case 5:
                    ctrl = LABELFRECUENCIA;
                    break;
                case 6:
                    ctrl = numericRam;
                    break;
                case 7:
                    ctrl = cboxAlmacenamientoTipo;
                    break;
                case 8:
                    ctrl = numericHDD;
                    break;
                case 9:
                    ctrl = numericSSD;
                    break;
            }

            if (String.IsNullOrEmpty(ctrl.Text.Trim()))
            {
                this.errorProvider.SetError(ctrl, "No debes dejar este campo vacio!");
                _response = false;
            }
            else
            {
                this.errorProvider.SetError(ctrl, "");
                _response = true;
            }

            return _response;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsAnswered = false;
            this.Close();
        }

        private void cboxAlmacenamientoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAlmacenamientoTipo.Text == "Ambos")
            {
                this.numericHDD.Enabled = true;
                this.numericSSD.Enabled = true;
            }
            else if (cboxAlmacenamientoTipo.Text == "HDD")
            {
                this.numericHDD.Enabled = true;
                this.numericSSD.Enabled = false;
            }
            else if (cboxAlmacenamientoTipo.Text == "SSD")
            {
                this.numericSSD.Enabled = true;
                this.numericHDD.Enabled = false;
            }
        }

        private void txtNombreClave_Enter(object sender, EventArgs e)
        {
            _MultiValidator(0);
        }

        private void txtNombreComercial_Enter(object sender, EventArgs e)
        {
            _MultiValidator(1);
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            _MultiValidator(2);
        }

        private void cboxTipo_Enter(object sender, EventArgs e)
        {
            _MultiValidator(3);
        }

        private void txtNombreClave_TextChanged(object sender, EventArgs e)
        {
            _MultiValidator(0);
        }

        private void txtNombreComercial_TextChanged(object sender, EventArgs e)
        {
            _MultiValidator(1);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            _MultiValidator(2);
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _MultiValidator(3);
        }

        private void txtNombreClave_Leave(object sender, EventArgs e)
        {
            _MultiValidator(0);
        }

        private void txtNombreComercial_Leave(object sender, EventArgs e)
        {
            _MultiValidator(1);
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            _MultiValidator(2);
        }

        private void cboxTipo_Leave(object sender, EventArgs e)
        {
            _MultiValidator(3);
        }

        private void txtProcesador_TextChanged(object sender, EventArgs e)
        {
            _MultiValidator(4);
        }

        private void txtFrecuenciaProcesador_TextChanged(object sender, EventArgs e)
        {
            _MultiValidator(5);
        }

        private void numericRam_ValueChanged(object sender, EventArgs e)
        {
            _MultiValidator(6);
        }

        private void numericHDD_ValueChanged(object sender, EventArgs e)
        {
            _MultiValidator(8);
        }

        private void numericSSD_ValueChanged(object sender, EventArgs e)
        {
            _MultiValidator(9);
        }

        private void txtProcesador_Enter(object sender, EventArgs e)
        {
            _MultiValidator(4);
        }

        private void txtFrecuenciaProcesador_Enter(object sender, EventArgs e)
        {
            _MultiValidator(5);
        }

        private void txtProcesador_Leave(object sender, EventArgs e)
        {
            _MultiValidator(4);
        }

        private void txtFrecuenciaProcesador_Leave(object sender, EventArgs e)
        {
            _MultiValidator(5);
        }
        
        private void btnExaminarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Selecciona una imagen de perfil del modelo...";
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.Filter = "Archivos de Imagenes (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp| Todos los Archivos (*.*)|*.*";
                this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                this.openFileDialog1.Multiselect = false;
                this.openFileDialog1.RestoreDirectory = true;

                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txtPathImagen.Text = this.openFileDialog1.FileName;
                    FileInfo fi = new FileInfo(txtPathImagen.Text);
                    new MachineProfiles.MachineProfile();   // Inicializamos el constructor para que valide la existencia de los direcotios correspondientes
                    File.WriteAllBytes($@"{Application.StartupPath}\Inventories\MachineProfiles\{fi.Name}", File.ReadAllBytes(this.txtPathImagen.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
