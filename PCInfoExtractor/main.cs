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
using System.Management;
using System.Diagnostics;

using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PCInfoExtractor
{
    public partial class main : Form
    {

        bool EXTRACT_SN = true;
        bool EXTRACT_HOST = true;
        bool EXTRACT_MODEL = true;
        bool EXTRACT_MARCA = true;

        string NUMERO_DE_SERIE = "";
        string HOSTNAME = "";
        string MARCA = "";
        string MODELO = "";
        string TIPO_DE_EQUIPO = "";

        // Añadir estos datos al JSON
        int CANTIDAD_DE_RAM = 0;
        string MODELO_PROCESADOR = "";
        string VELOCIDAD_PROCESADOR = "";


        // BANDERA DE BACKGROUNDWORKER ACTIVO ACTUALMENTE
        bool BGW_ACTIVE = false;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.cboxFormatoSalida.SelectedIndex = 0;
            this.txtDirectorioSalida.Text = String.Empty;

            checkedListBox1.Items.Add("Hostname", EXTRACT_HOST);
            checkedListBox1.Items.Add("Numero de Serie", EXTRACT_SN);
            checkedListBox1.Items.Add("Marca", EXTRACT_MARCA);
            checkedListBox1.Items.Add("Modelo", EXTRACT_MODEL);

            this.txtIdentificador.Text = "Equipo 1";

            this.chckboxExtraerInfoYGuardar.Checked = true;

            this.cboxTipoDeEquipo.SelectedIndex = 1;

            this.txtNombreSalida.Text = this.txtIdentificador.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExtraerInfo_Click(object sender, EventArgs e)
        {
            this.btnExtraerInfo.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            this.backgroundWorker1.RunWorkerAsync();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtDirectorioSalida.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {
            this.txtNombreSalida.Text = this.txtIdentificador.Text;
        }

        private void chckboxExtraerInfoYGuardar_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreSalida.Enabled = chckboxExtraerInfoYGuardar.Checked;
            this.txtDirectorioSalida.Enabled = chckboxExtraerInfoYGuardar.Checked;
            this.btnExaminar.Enabled = chckboxExtraerInfoYGuardar.Checked;
            this.cboxFormatoSalida.Enabled = chckboxExtraerInfoYGuardar.Checked;
        }

        private void btnAbrirDirectorio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start($@"{this.txtDirectorioSalida.Text}");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // PROCESO DE EXTRACCION DE INFORMACION DEL PC

            if (!BGW_ACTIVE)
            {
                if (!String.IsNullOrEmpty(this.txtDirectorioSalida.Text))
                {
                    BGW_ACTIVE = true;
                    this.btnExtraerInfo.Enabled = false;
                    this.Cursor = Cursors.WaitCursor;

                    #region CODIGO
                    richTextBox1.Text = "";
                    progressBar1.Value = 0;


                    TIPO_DE_EQUIPO = this.cboxTipoDeEquipo.Text;
                    progressBar1.PerformStep();

                    #region PROCESO DE EXTRACCION DE DATOS
                    foreach (object itemChecked in checkedListBox1.CheckedItems)
                    {
                        Console.WriteLine(itemChecked.ToString());

                        if (itemChecked.ToString() == "Hostname")
                        {
                            // EXTRAEMOS LOS DATOS DEL HOSTNAME
                            richTextBox1.Text += "HOSTNAME: " + Environment.MachineName + Environment.NewLine;

                            HOSTNAME = Environment.MachineName;
                            progressBar1.PerformStep();
                        }
                        else if (itemChecked.ToString() == "Numero de Serie")
                        {
                            //EXTRAEMOS EL NUMERO DE SERIE DEL EQUIPO
                            #region OBTENEMOS EL NUMERO DE SERIE DEL EQUIPO
                            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic bios get serialnumber");
                            procStartInfo.RedirectStandardOutput = true;
                            procStartInfo.UseShellExecute = false;
                            procStartInfo.CreateNoWindow = true;

                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.StartInfo = procStartInfo;
                            proc.Start();

                            string result = proc.StandardOutput.ReadToEnd();
                            #endregion

                            result = result.Remove(0, 14);
                            NUMERO_DE_SERIE = result.Trim();

                            richTextBox1.Text += "NUMERO DE SERIE: " + result.Trim() + Environment.NewLine;
                            progressBar1.PerformStep();

                        }
                        else if (itemChecked.ToString() == "Marca")
                        {
                            //EXTRAEMOS LA MARCA DEL EQUIPO
                            #region OBTENEMOS EL NUMERO DE SERIE DEL EQUIPO
                            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic csproduct get vendor");
                            procStartInfo.RedirectStandardOutput = true;
                            procStartInfo.UseShellExecute = false;
                            procStartInfo.CreateNoWindow = true;

                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.StartInfo = procStartInfo;
                            proc.Start();

                            string result = proc.StandardOutput.ReadToEnd();
                            #endregion

                            result = result.Remove(0, 11);
                            if (Regex.IsMatch(result, @"Hewlett-Packard"))
                            {
                                // Si es una HP
                                MARCA = "HP";
                            }
                            else if (Regex.IsMatch(result, @"LENOVO"))
                            {
                                // Si es una Lenovo
                                MARCA = "Lenovo";
                            }
                            else if (Regex.IsMatch(result, @"Dell Inc."))
                            {
                                // Si es una Dell Inc.
                                MARCA = "Dell";
                            }

                            richTextBox1.Text += "MARCA: " + MARCA + Environment.NewLine;
                            progressBar1.PerformStep();

                        }
                        else if (itemChecked.ToString() == "Modelo")
                        {
                            //EXTRAEMOS EL MODELO DEL EQUIPO
                            #region OBTENEMOS EL NUMERO DE SERIE DEL EQUIPO
                            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic csproduct get name");
                            procStartInfo.RedirectStandardOutput = true;
                            procStartInfo.UseShellExecute = false;
                            procStartInfo.CreateNoWindow = true;

                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.StartInfo = procStartInfo;
                            proc.Start();

                            string result = proc.StandardOutput.ReadToEnd();
                            #endregion

                            result = result.Remove(0, 15);
                            MODELO = result.Trim();

                            richTextBox1.Text += "MODELO: " + result + Environment.NewLine;
                            progressBar1.PerformStep();
                        }
                    }

                    /* EXTRACCION DE DATOS OBLIGATORIOS */

                    /** RAM **/
                    // Cantidad
                    try
                    {
                        #region OBTENEMOS LA CANTIDAD DE RAM DEL EQUIPO
                        System.Diagnostics.ProcessStartInfo getRAMCapacity = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic memorychip get capacity");
                        getRAMCapacity.RedirectStandardOutput = true;
                        getRAMCapacity.UseShellExecute = false;
                        getRAMCapacity.CreateNoWindow = true;

                        System.Diagnostics.Process RAM_proc = new System.Diagnostics.Process();
                        RAM_proc.StartInfo = getRAMCapacity;
                        RAM_proc.Start();

                        string RAM_result = RAM_proc.StandardOutput.ReadToEnd();
                        #endregion

                        string ram_chips = RAM_result.Replace("Capacity", String.Empty).Trim();

                        long RAM_CAPACITY = 0;
                        foreach (string line in ram_chips.Split('\n'))
                        {
                            RAM_CAPACITY += Int64.Parse(line.Trim());
                        }

                        CANTIDAD_DE_RAM = (int)(RAM_CAPACITY / 1024 / 1024 / 1024);
                        richTextBox1.Text += "RAM INSTALADA: " + CANTIDAD_DE_RAM + " Gb" + Environment.NewLine;

                        progressBar1.PerformStep();


                        // Modelo del procesador
                        #region OBTENEMOS LA CANTIDAD DE RAM DEL EQUIPO
                        System.Diagnostics.ProcessStartInfo getCPUModel = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic cpu get name");
                        getCPUModel.RedirectStandardOutput = true;
                        getCPUModel.UseShellExecute = false;
                        getCPUModel.CreateNoWindow = true;

                        System.Diagnostics.Process CPU_proc = new System.Diagnostics.Process();
                        CPU_proc.StartInfo = getCPUModel;
                        CPU_proc.Start();

                        string CPU_result = CPU_proc.StandardOutput.ReadToEnd();
                        #endregion

                        string CPU_MODEL = CPU_result.Replace("Name", string.Empty);
                        CPU_MODEL = CPU_MODEL.Remove(CPU_MODEL.IndexOf("CPU")).Trim();
                        MODELO_PROCESADOR = CPU_MODEL;
                        richTextBox1.Text += "MODELO DEL CPU: " + MODELO_PROCESADOR + Environment.NewLine;

                        progressBar1.PerformStep();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ha ocurrido un error. {ex.Message}{Environment.NewLine + Environment.NewLine}{ex.ToString()}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    // Velocidad del procesador
                    #region OBTENEMOS LA CANTIDAD DE RAM DEL EQUIPO
                    System.Diagnostics.ProcessStartInfo getCPUspeed = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + "wmic cpu get maxclockspeed");
                    getCPUspeed.RedirectStandardOutput = true;
                    getCPUspeed.UseShellExecute = false;
                    getCPUspeed.CreateNoWindow = true;

                    System.Diagnostics.Process CPU_speed = new System.Diagnostics.Process();
                    CPU_speed.StartInfo = getCPUspeed;
                    CPU_speed.Start();

                    string SPEED_result = CPU_speed.StandardOutput.ReadToEnd();
                    #endregion

                    string CPU_SPEED = SPEED_result.Replace("MaxClockSpeed", string.Empty);
                    decimal vci = Int32.Parse(CPU_SPEED);
                    CPU_SPEED = (vci / 1000).ToString();
                    VELOCIDAD_PROCESADOR = CPU_SPEED.Trim();
                    richTextBox1.Text += "VELOCIDAD DEL CPU: " + VELOCIDAD_PROCESADOR + " GHz" + Environment.NewLine;

                    progressBar1.PerformStep();
                    #endregion


                    if (string.IsNullOrEmpty(this.txtUbicacion.Text)) { richTextBox1.Text += "UBICACION: -" + Environment.NewLine; } else { richTextBox1.Text += "UBICACION: " + this.txtUbicacion.Text + Environment.NewLine; }
                    if (string.IsNullOrEmpty(this.txtUsuarioAsignado.Text)) { richTextBox1.Text += "USUARIO ASIGNADO: -" + Environment.NewLine; } else { richTextBox1.Text += "USUARIO ASIGNADO: " + this.txtUsuarioAsignado.Text + Environment.NewLine; }

                    richTextBox1.Text += "TIPO DE EQUIPO: " + TIPO_DE_EQUIPO + Environment.NewLine;
                    progressBar1.PerformStep();

                    /** Guardamos los datos en archivo JSON si son requeridos **/
                    if (this.chckboxExtraerInfoYGuardar.Checked)
                    {
                        if (!string.IsNullOrEmpty(this.txtNombreSalida.Text))
                        {
                            #region CODIGO
                            if (this.cboxFormatoSalida.Text == "JSON")
                            {
                                // ESCRIBIMOS ARCHIVO DE SALIDA EN JSON
                                string usersJson_path = this.txtUbicacion.Text;
                                Dictionary<string, string> dict = new Dictionary<string, string>();

                                dict.Add("HOSTNAME", HOSTNAME);
                                dict.Add("SERIAL_NUMBER", NUMERO_DE_SERIE);
                                dict.Add("TIPO_DE_EQUIPO", TIPO_DE_EQUIPO);
                                dict.Add("MARCA", MARCA);
                                dict.Add("MODELO", MODELO);
                                dict.Add("UBICACION", txtUbicacion.Text);
                                dict.Add("USUARIO_ASIGNADO", txtUsuarioAsignado.Text);
                                dict.Add("CANTIDAD_DE_RAM", CANTIDAD_DE_RAM.ToString());
                                dict.Add("MODELO_DEL_PROCESADOR", MODELO_PROCESADOR);
                                dict.Add("VELOCIDAD_DEL_PROCESADOR", VELOCIDAD_PROCESADOR);


                                string finalJson = System.Text.Json.JsonSerializer.Serialize(dict);
                                File.WriteAllText($@"{this.txtDirectorioSalida.Text}\{this.txtNombreSalida.Text}.json", finalJson);
                            }
                            else if (this.cboxFormatoSalida.Text == "Texto")
                            {
                                // ESCRIBIMOS ARCHIVO DE SALIDA EN TEXTO
                                StreamWriter sw = new StreamWriter($@"{this.txtDirectorioSalida.Text}\{this.txtNombreSalida.Text}.txt");
                                sw.WriteLine($"HOSTNAME: {HOSTNAME}" + Environment.NewLine +
                                            $"SERIAL_NUMBER: {NUMERO_DE_SERIE}" + Environment.NewLine +
                                            $"TIPO_DE_EQUIPO: {TIPO_DE_EQUIPO}" + Environment.NewLine +
                                            $"MARCA: {MARCA}" + Environment.NewLine +
                                            $"MODELO: {MODELO}" + Environment.NewLine +
                                            $"UBICACION: {txtUbicacion.Text}" + Environment.NewLine +
                                            $"CANTIDAD DE RAM: {CANTIDAD_DE_RAM}" + Environment.NewLine +
                                            $"MODELO DEL PROCESADOR: {MODELO_PROCESADOR}" + Environment.NewLine +
                                            $"VELOCIDAD DEL PROCESADOR: {VELOCIDAD_PROCESADOR}" + Environment.NewLine +
                                            $"USUARIO_ASIGNADO: {txtUsuarioAsignado.Text}" + Environment.NewLine);
                                sw.Close();
                            }
                            #endregion

                            MessageBox.Show("¡Informacion recopilada con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Debe asignar un nombre de salida al archivo!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // MENSAJE INDICADOR DE PROCESO FINALIZADO
                    #endregion
                }
                else
                {
                    MessageBox.Show("Debes llenar el directorio de salida!", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGW_ACTIVE = false;
            this.btnExtraerInfo.Enabled = true;
            this.Cursor = Cursors.Default;
        }
    }
}
