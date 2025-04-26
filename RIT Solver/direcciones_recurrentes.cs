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

using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Microsoft.VisualBasic;

using CustomMessageBox;


namespace RIT_Solver
{
    public partial class Form1 : Form
    {
        string toText = "";
        private solicitar_refaccion padre;
        public Form1(string aConstructor, solicitar_refaccion LegacyForm)
        {
            InitializeComponent();
            toText = aConstructor;
            padre = LegacyForm;
        }


        private void CrearDireccion(string Nombre, string Direccion)
        {
            try
            {
                string path = Application.StartupPath + @"\Addresses\";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (File.Exists($@"{path}\{Nombre}.json"))
                {
                    RJMessageBox.Show("Ya existe esta direccion guardada!");
                }
                else
                {
                    // Creamos nuestro archivo JSON
                    Dictionary<string, string> pairData = new Dictionary<string, string>();

                    pairData.Add(Nombre, Direccion);
                    string finalJson = System.Text.Json.JsonSerializer.Serialize(pairData);

                    File.WriteAllText($@"{path}\{Nombre.Trim()}.json", finalJson);

                    this.listDirecciones.Items.Add(Nombre);
                }
            } catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BorrarDireccion (string aNombre)
        {
            try
            {
                string path = $@"{Application.StartupPath}\Addresses\{aNombre}.json";

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                listDirecciones.Items.Remove(aNombre);

                RJMessageBox.Show($"Se ha borrado con exito el contacto de {aNombre}", "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Direcciones recurrentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AñadirDireccion ()
        {
            // NOTA: Añade la direccion seleccionada al formulario
        }

        private void LoadEmailsDirections()
        {
            // Carga las direcciones de correo existentes en el directorio de direcciones
            DirectoryInfo di = new DirectoryInfo($@"{Application.StartupPath}\Addresses\");
            FileInfo[] files = di.GetFiles("*.json");
            foreach (FileInfo file in files)
            {
                int s_len = file.Name.Length;
                this.listDirecciones.Items.Add(file.Name.Remove(s_len - 5, 5));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listDirecciones.Items.Add("Andrea Yuritze Tello Rodriguez");
            if (!Directory.Exists($@"{Application.StartupPath}\Addresses\"))
            {
                Directory.CreateDirectory($@"{Application.StartupPath}\Addresses\");
                LoadEmailsDirections();
            } else
            {
                LoadEmailsDirections();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aNombre = Interaction.InputBox("Nombre de la persona:", "Datos");
            string aCorreo = Interaction.InputBox("Correo electronico:", "Datos");

            if (!string.IsNullOrEmpty(aNombre) & !string.IsNullOrEmpty(aCorreo))
            {
                CrearDireccion(aNombre, aCorreo);
                RJMessageBox.Show("¡Correo añadido a la libreta!", "Lbreta de Direcciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            BorrarDireccion(this.listDirecciones.SelectedItem.ToString());
        }

        private void listDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RJMessageBox.Show(this.listDirecciones.SelectedItem.ToString());
        }

        private void btnAñadirDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                string dir_path = $@"{Application.StartupPath}\Addresses\";
                string name = $"{this.listDirecciones.SelectedItem.ToString()}";

                if (File.Exists($@"{dir_path}\{name}.json"))
                {
                    string json_file = File.ReadAllText($@"{dir_path}\{name}.json");
                    JObject json_parsed = JObject.Parse(json_file);

                    //solicitar_refaccion frm = new solicitar_refaccion();

                    switch (toText)
                    {
                        case "To":
                            if (string.IsNullOrEmpty(padre.txtEmailDestino.Text.Trim()))
                            {
                                padre.txtEmailDestino.Text = $"{json_parsed[name].ToString()}";
                            } else
                            {
                                padre.txtEmailDestino.Text = $"{padre.txtEmailDestino.Text.Trim()}; {json_parsed[name].ToString()}";
                            }
                                //frm.txtEmailDestino.Text.Append($"; {json_parsed[name].ToString()}");
                            break;

                        case "CC":
                            if (string.IsNullOrEmpty(padre.txtEmailCC.Text.Trim()))
                            {
                                padre.txtEmailCC.Text = $"{json_parsed[name].ToString()}";
                            } else
                            {
                                padre.txtEmailCC.Text = $"{padre.txtEmailCC.Text.Trim()}; {json_parsed[name].ToString()}";
                            }
                            break;
                    }

                }
            } catch (Exception ex) 
            {
                RJMessageBox.Show(ex.Message);
            }
        }

        private void listDirecciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string dir_path = $@"{Application.StartupPath}\Addresses\";
                string name = $"{this.listDirecciones.SelectedItem.ToString()}";

                if (File.Exists($@"{dir_path}\{name}.json"))
                {
                    string json_file = File.ReadAllText($@"{dir_path}\{name}.json");
                    JObject json_parsed = JObject.Parse(json_file);

                    //solicitar_refaccion frm = new solicitar_refaccion();

                    switch (toText)
                    {
                        case "To":
                            if (string.IsNullOrEmpty(padre.txtEmailDestino.Text.Trim()))
                            {
                                padre.txtEmailDestino.Text = $"{json_parsed[name].ToString()}";
                            }
                            else
                            {
                                padre.txtEmailDestino.Text = $"{padre.txtEmailDestino.Text.Trim()}; {json_parsed[name].ToString()}";
                            }
                            //frm.txtEmailDestino.Text.Append($"; {json_parsed[name].ToString()}");
                            break;

                        case "CC":
                            if (string.IsNullOrEmpty(padre.txtEmailCC.Text.Trim()))
                            {
                                padre.txtEmailCC.Text = $"{json_parsed[name].ToString()}";
                            }
                            else
                            {
                                padre.txtEmailCC.Text = $"{padre.txtEmailCC.Text.Trim()}; {json_parsed[name].ToString()}";
                            }
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                // Cerramos el programa
                this.Close();
            }
        }
    }
}
