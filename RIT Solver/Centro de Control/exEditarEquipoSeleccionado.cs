using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver.Centro_de_Control
{
    public partial class exEditarEquipoSeleccionado : Form
    {
        actividades_mdi_form BaseForm;
        Inventario4ActViewModel actualSelected;
        public exEditarEquipoSeleccionado(actividades_mdi_form baseForm, Inventario4ActViewModel Machine)
        {
            InitializeComponent();
            BaseForm = baseForm;
            actualSelected = Machine;
        }

        private void exEditarEquipoSeleccionado_Load(object sender, EventArgs e)
        {
            this.Text = $"{this.Text} - {actualSelected.HOSTNAME}";
        }
    }
}
