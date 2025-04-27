using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace Flow_Solver
{
    /// <summary>
    /// Objeto de una localidad
    /// </summary>
    public class AddressSite 
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Sucursal { get; set; }
        public bool isDefaultDirection { get; set; }
        public string NoDeSucursal { get; set; }
        public string Poblacion { get; set; }
        public string CentroServicios { get; set; }
        public string Estacion { get; set; }

        /// <summary>
        /// Valida la existencia de los directorios principales de las localidades
        /// </summary>
        public static void DirsValidator()
        {
            string ROOT = System.Windows.Forms.Application.StartupPath;

            if (!Directory.Exists($@"{ROOT}\Addresses"))
            {
                Directory.CreateDirectory($@"{ROOT}\Addresses");
            }

            if (!Directory.Exists($@"{ROOT}\Addresses\Localidades"))
            {
                Directory.CreateDirectory($@"{ROOT}\Addresses\Localidades");
            }
        }

        /// <summary>
        /// Guarda o Crea el archivo en caso de no existir de la localidad indicada
        /// </summary>
        public void Save ()
        {
            DirsValidator();
            Dictionary<string, dynamic> direction = new Dictionary<string, dynamic>
            {
                { "nombre", this.Nombre },
                { "direccion", this.Direccion },
                { "sucursal", "" },
                { "isDefaultDir", this.isDefaultDirection.ToString() },
                { "no_de_sucursal", "" },
                { "poblacion", this.Poblacion },
                { "centro_servicios", this.CentroServicios },
                { "estacion", "FXE" }
            };

            string fname = $@"{Estacion}_{Nombre}";
            string finaljson = System.Text.Json.JsonSerializer.Serialize(direction);
            File.WriteAllText($@"{System.Windows.Forms.Application.StartupPath}\Addresses\Localidades\{fname}.json", finaljson);
        }

        /// <summary>
        /// Construye el objeto en base a la direccion del path indicada
        /// </summary>
        /// <returns></returns>
        public static AddressSite Build (string jsonPath)
        {
            AddressSite response = new AddressSite();

            JObject json = JObject.Parse(File.ReadAllText(jsonPath));
            response.Nombre = json["nombre"].ToString();
            response.Direccion = json["direccion"].ToString();
            response.Sucursal = json["sucursal"].ToString();
            response.isDefaultDirection = bool.Parse(json["nombre"].ToString());
            response.NoDeSucursal = json["no_de_sucursal"].ToString();
            response.Poblacion = json["poblacion"].ToString();
            response.CentroServicios = json["centro_servicios"].ToString();
            response.Estacion = json["estacion"].ToString();

            return response;
        }
    }

    internal class AddressesManager
    {
        /// <summary>
        /// Validamos la existencia del archivo json de la direccion default del sistema. En caso de que no exista, la creamos
        /// </summary>
        public static void ValidateDefaultAddressExists()
        {
            string OriginPath = $@"{System.Windows.Forms.Application.StartupPath}\Addresses\Localidades";
            
            if (!File.Exists($@"{OriginPath}\Direccion_default.json"))
            {
                // En caso de que no exista el archivo de la direccion default, lo creamos
                AddressSite site = new AddressSite()
                {
                    Nombre = "Direccion default",
                    Direccion = Properties.Settings.Default.Direccion,
                    Sucursal = "",
                    isDefaultDirection = true,
                    NoDeSucursal = "",
                    Poblacion = Properties.Settings.Default.LocalidadIDC,
                    CentroServicios = Properties.Settings.Default.CentroDeServicios,
                    Estacion = "FXE"
                };

                site.Save();
                Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT = site.Nombre;
            }
        }
    }
}
