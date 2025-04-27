using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Flow_Solver
{
    public class BackupConfiguration
    {
        /// <summary>
        ///     Vista del modelo del objeto de configuracion
        /// 
        ///     Se declaran las propiedades a usar en las configuraciones
        /// </summary>

        /* Inventarios */
        public bool MachinesInventory_Make { get; set; }
        public bool PrintersInventory_Make { get; set; }
        public bool TonersInventory_Make { get; set; }
        public bool SparePartsInventory_Make { get; set; }

        /* Inventarios varios */
        public bool CurrentsEmailDirections_Make { get; set; }
        public bool SaveLocations_Make { get; set; }
        public bool UsersInventory_Make { get; set; }

        /* Configuracion del sistema */
        public bool EmailIDC_Save { get; set; }
        public bool PasswordRED_Save { get; set; }
        public bool NameIDC_Save { get; set; }
        public bool LocationIDC_Save { get; set; }
        public bool ProjectIDC_Save { get; set; }
        public bool Client_Save { get; set; }
        public bool DefaultLocationDirection_Save { get; set; }
        public bool CenterOfServiceIDCDefault_Save { get; set; }
        public bool EmailSupportLeader_Save { get; set; }
        public bool NameSupportLeader_Save { get; set; }
        public bool RedUserIDC_Save { get; set; }
        public bool EmailTonerDistrib_Save { get; set; }
        public bool ThemeSelection_Save { get; set; }
        public bool UpdatesDetection_Save { get; set; }
        public bool BETAUpdatesDetection_Save { get; set; }
        public bool ResguardPDFMake_Save { get; set; }
        public bool OpenInventoryOnMaximize_Save { get; set; }
        public bool ActualRITCounter_Save { get; set; }
        public bool MakeEmptyProjectOnOpen_Save { get; set; }
        public bool DefaultLocationSelected_Save { get; set; }
    }
}
