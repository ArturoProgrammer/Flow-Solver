using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CefSharp;
using Microsoft.VisualBasic;
using RIT_Solver.Centro_de_Control;

namespace RIT_Solver
{
    public partial class waybill_tracking : Form
    {
        tabla_seguimiento_guias_mdi_form BaseForm = null;
        Paqueteria paqueteria;
        string trackid;

        public waybill_tracking(Paqueteria Parcel)
        {
            // Sobrecarga normal
            InitializeComponent();
            paqueteria = Parcel;
        }

        public waybill_tracking(tabla_seguimiento_guias_mdi_form LegacyForm, Paqueteria Parcel, string WaybillNumber)
        {
            // Sobrecarga con guia ingresada como parametro
            InitializeComponent();
            paqueteria = Parcel;
            trackid = WaybillNumber;
            //webTrackingSystem.Url = new Uri(WaybillNumber);
            BaseForm = LegacyForm;
            BaseForm.toolStrpBtnCerrarVisor.Enabled = true;
        }

        private void waybill_tracking_Load(object sender, EventArgs e)
        {
            this.toolWebLink.Text = "";

            if (string.IsNullOrEmpty(trackid))
            {
                string WaybillNumber = Interaction.InputBox("Ingresa el numero de guia a rastrear: ", "Seguimiento de paquete");

                if (!string.IsNullOrEmpty(WaybillNumber))
                {
                    {
                        TrackWayBillBumber(WaybillNumber);
                    }
                }
                else
                {
                    // En caso de cancelar la adicion de numero de guia, cerramos
                    this.Close();
                }
            }
            else
            {
                TrackWayBillBumber(trackid);
            }
        }

        private void TrackWayBillBumber(string WaybillNumber)
        {
            // Si se ingreso un numero de guia, ejecutamos
            this.Text += $" - {paqueteria} ID: {WaybillNumber}";

            switch (paqueteria)
            {
                case Paqueteria.DHL:
                    string URL_D = $@"https://www.dhl.com/mx-es/home/tracking/tracking-express.html?submit=1&tracking-id={WaybillNumber}";
                    webTrackingSystem.LoadUrl((URL_D));
                    this.toolWebLink.Text = URL_D;
                    break;
                case Paqueteria.PAQUETEXPRESS:
                    string URL_P = $@"https://www.paquetexpress.com.mx/en/rastreo/{WaybillNumber}";
                    webTrackingSystem.LoadUrl((URL_P));
                    this.toolWebLink.Text = URL_P;
                    break;
                case Paqueteria.FEDEX:
                    string URL_F = $@"https://www.fedex.com/fedextrack/?trknbr={WaybillNumber}";
                    webTrackingSystem.LoadUrl((URL_F));
                    this.toolWebLink.Text = URL_F;
                    break;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolWebReload_Click(object sender, EventArgs e)
        {
            if (webTrackingSystem.IsBrowserInitialized == true)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE RECARGO LA URL DE 'webTrackingSystem'", "OKA");

                // Arreglar
                this.webTrackingSystem.Reload();
            }
        }

        private void waybill_tracking_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (BaseForm != null)
            {
                BaseForm.toolStrpBtnCerrarVisor.Enabled = false;
            }
        }
    }
    
}
