using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    public partial class select_machine : Form
    {
        internal List<InventarioViewModel> MachinesList = new List<InventarioViewModel>();
        internal rit_mdi_form padre;
        public InventarioViewModel Result;

        /// <summary>
        /// Construcotr del Formulario.
        /// </summary>
        /// <param name="Listado">Objeto listado de los equipos a escoger.</param>
        /// <param name="LegacyForm">Formulario padre heredado.</param>
        public select_machine(rit_mdi_form LegacyForm, List<InventarioViewModel> Listado)
        {
            InitializeComponent();
            MachinesList = Listado;
            padre = LegacyForm;
        }

        private void select_machine_Load(object sender, EventArgs e)
        {
            // Enlistamos los datos recibidos
            int ID_COUNT = 0;
            foreach (InventarioViewModel machine in MachinesList)
            {
                ListViewItem item = new ListViewItem(ID_COUNT.ToString());
                
                item.SubItems.Add(machine.NOMBRE);
                item.SubItems.Add(machine.HOSTNAME);
                item.SubItems.Add(machine.TipoDeEquipo);
                item.SubItems.Add(machine.SN);
                item.SubItems.Add(machine.Marca);
                item.SubItems.Add(machine.Modelo);
                item.SubItems.Add(machine.Departamento);

                listView_Machine.Items.Add(item);
                ID_COUNT++;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            padre.txtTipoDeEquipo.Text = TipoDeEquipo;
            padre.txtMarca.Text = Marca;
            padre.txtModelo.Text = Modelo;
            padre.txtNoDeSerie.Text = NoDeSerie;

            this.Close();
        }


        public string TipoDeEquipo = "";
        public string Marca = "";
        public string Modelo = "";
        public string NoDeSerie = "";
        private void listView_Machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection machine = this.listView_Machine.SelectedItems;
            
            foreach (ListViewItem item in machine)
            {
                TipoDeEquipo = item.SubItems[3].Text;
                NoDeSerie = item.SubItems[4].Text;
                Marca = item.SubItems[5].Text;
                Modelo = item.SubItems[6].Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void select_machine_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                InventarioViewModel obj = new InventarioViewModel();
                obj.TipoDeEquipo = this.TipoDeEquipo;
                obj.Marca = this.Marca;
                obj.Modelo = this.Modelo;
                obj.SN = this.NoDeSerie;

                Result = obj;
            }
            else if (this.DialogResult == DialogResult.Cancel)
            {
                // Ignoramos, dejamos posibilidad por si acaso a futuro
            }
        }

        private void listView_Machine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
