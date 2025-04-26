using DocumentFormat.OpenXml.Math;
using SpreadsheetLight;
using System.Management.Automation;

namespace RIT_Commands_Lets
{
    [Cmdlet(assets.CmdLetVerb, "Inventory")]
    public class Inventory_GetMachinData : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GetMachine { get; set; }

        [Parameter]
        public SwitchParameter Model { get; set; }

        [Parameter]
        public SwitchParameter SerialNumber { get; set; }

        [Parameter]
        public SwitchParameter Username { get; set; }


        protected override void ProcessRecord()
        {
            // ruta del archivo excel de inventarios
            string path = $@"{assets.GetRegeditValue("InstallationPath")}\Inventories\USUARIOS Y EQUIPOS.xlsx";

            if (!File.Exists(path))
            {
                WriteError(new ErrorRecord(
                    new FileNotFoundException("No se encontro el archivo de inventario."),
                    "FileNotFound",
                    ErrorCategory.ResourceUnavailable,
                    path));
                return;
            }

            using (var doc = new SLDocument(path))
            {
                int row = 2;
                bool found = false;

                while (!String.IsNullOrWhiteSpace(doc.GetCellValueAsString(row, 6)))
                {
                    string hostname = doc.GetCellValueAsString(row, 6);
                    if (hostname.Equals(GetMachine, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;

                        string model = doc.GetCellValueAsString(row, 10);
                        string serial = doc.GetCellValueAsString(row, 8);
                        string user = doc.GetCellValueAsString(row, 1);

                        if (!Model.IsPresent && !SerialNumber.IsPresent && !Username.IsPresent)
                        {
                            WriteObject($"Usuario: {user}, Serie: {serial}, Modelo: {user}");
                        }
                        else
                        {
                            if (Model.IsPresent)
                            {
                                WriteObject($"Modelo: {model}");
                            }
                            if (SerialNumber.IsPresent)
                            {
                                WriteObject($"Serie: {serial}");
                            }
                            if (Username.IsPresent)
                            {
                                WriteObject($"Usuario: {user}");
                            }
                        }

                        break;
                    }

                    row++;
                }

                if (!found)
                {
                    WriteWarning($"No se encontro informacion para la maquina '{GetMachine}'");
                }
            }

            base.ProcessRecord();
        }
    }
}
