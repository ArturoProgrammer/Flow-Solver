using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Solver.MachineProfiles
{
    public class MachineProfile
    {
        string dirPath = $@"{Application.StartupPath}\Inventories\MachineProfiles";
        /// <summary>
        /// Extension por defecto de los archivos de perfiles de equipos
        /// </summary>
        public readonly string Extension = ".machprofile";

        public Usuario UsuarioAsignado { get; set; }
        public InventarioViewModel EquipoPrincipal { get; set; }
        public List<InventarioViewModel> Accesorios { get; set; }
        /// <summary>
        /// Path de la grabadora de eventos del equipo en cuestion
        /// </summary>
        public string EventRecorderPath { get; set; }
        /// <summary>
        /// Objeto del modelo vinculado
        /// </summary>
        public MachineModelSyncItem ModeloVinculado { get; set; }



        public MachineProfile()
        {
            // Nos aseguramos de que exista la carpeta correspondiente
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        /// <summary>
        /// Construimos el objeto correspondiente a la 
        /// </summary>
        /// <param name="_MachineHostname"></param>
        /// <returns></returns>
        public static MachineProfile Build(InventarioViewModel _Machine)
        {
            MachineProfile obj = new MachineProfile();

            // Obtenemos los datos del usuario
            obj.UsuarioAsignado = Usuario.GetFromCard($@"{Application.StartupPath}\UsersCard\{_Machine.NOMBRE}_Profile.card");
            obj.EquipoPrincipal = _Machine;
            obj.Accesorios = new List<InventarioViewModel>();
            obj.EventRecorderPath = $@"{Application.StartupPath}\Inventories\{_Machine.HOSTNAME}{MachineEventsHistorial.FileSuffix}";
            MachineModelSyncItem[] targetModelArray = MachinesModelsSync.Load().Items
                                                                        .Cast<MachineModelSyncItem>()
                                                                        .Where(m => m.NombreComercial.ToLower().Trim() == obj.EquipoPrincipal.Modelo.ToLower().Trim())
                                                                        .ToArray();
            if (targetModelArray.Length > 0)
            {
                obj.ModeloVinculado = targetModelArray[0];
            }
            return obj;
        }
    }
}
