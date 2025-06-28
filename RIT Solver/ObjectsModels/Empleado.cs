using Flow_Solver.DatabaseManager;
using FlowCommonWorkcore;
using Markdig.Extensions.Yaml;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public enum EmpleadoStatus
{
    Activo,
    Inactivo,
    Suspendido,
    Despedido,
    Renunciado
}

public static class EmpleadoStatusExtensions
{
    public static string GetText(this EmpleadoStatus status)
    {
        return status switch
        {
            EmpleadoStatus.Activo => "Activo",
            EmpleadoStatus.Inactivo => "Inactivo",
            EmpleadoStatus.Suspendido => "Suspendido",
            EmpleadoStatus.Despedido => "Despedido",
            EmpleadoStatus.Renunciado => "Renunciado",
            _ => "Desconocido"
        };
    }

    public static EmpleadoStatus Parse(string text)
    {
        return text switch
        {
            "Activo" => EmpleadoStatus.Activo,
            "Inactivo" => EmpleadoStatus.Inactivo,
            "Suspendido" => EmpleadoStatus.Suspendido,
            "Despedido" => EmpleadoStatus.Despedido,
            "Renunciado" => EmpleadoStatus.Renunciado,
            _ => throw new ArgumentException("Estado desconocido: " + text)
        };
    }
}



namespace Flow_Solver.ObjectsModels
{
    public class Empleado
    {
        public static readonly string TableName = "empleados";
        public static readonly string ObjectName = "Empleado";
        public static readonly string ObjectTitle = "Empleado de la compañia";
        public static readonly string DataBaseName = "flow_solver";
        public static readonly string ObjectDescription = "Empleado trabajador de la compañia";

        /// <summary>
        /// Identificador único del empleado
        /// </summary>
        [ParamSqlKey("@HASH")]
        [ColumnSqlName("HASH")]
        public string HASH { get; set; }
        /// <summary>
        /// Nombres del empleado
        /// </summary>
        [ParamSqlKey("@Nombres")]
        [ColumnSqlName("Nombres")]
        public string Nombres { get; set; }
        /// <summary>
        /// Apellidos del empleado
        /// </summary>
        [ParamSqlKey("@Apellidos")]
        [ColumnSqlName("Apellidos")]
        public string Apellidos { get; set; }
        /// <summary>
        /// Edad del empleado
        /// </summary>
        [ParamSqlKey("@Edad")]
        [ColumnSqlName("Edad")]
        public int Edad { get; set; }
        /// <summary>
        /// Fecha de ingreso del empleado a la empresa
        /// </summary>
        [ParamSqlKey("@FechaDeIngreso")]
        [ColumnSqlName("FechaIngreso")]
        public DateTime FechaDeIngreso { get; set; }
        /// <summary>
        /// Fecha de salida del empleado de la empresa (si aplica)
        /// </summary>
        /// <remarks>Devolvera null en caso de que el usuario aun siga laborando</remarks>
        [ParamSqlKey("@FechaDeSalida")]
        [ColumnSqlName("FechaSalida")]
        public DateTime? FechaDeSalida { get; set; }
        /// <summary>
        /// Estatus actual del empelado en la empresa
        /// </summary>
        [ParamSqlKey("@Status")]
        [ColumnSqlName("EstatusActual")]
        public EmpleadoStatus Status { get; set; } = EmpleadoStatus.Activo;
        /// <summary>
        /// Fecha de nacimiento del empleado
        /// </summary>
        [ParamSqlKey("@FechaNacimiento")]
        [ColumnSqlName("FechaDeNacimiento")]
        public DateTime FechaDeNacimiento { get; set; }
        /// <summary>
        /// Puesto del empleado en la empresa
        /// </summary>
        [ParamSqlKey("@Puesto")]
        [ColumnSqlName("Puesto")]
        public string Puesto { get; set; }
        /// <summary>
        /// Departamento de la empresa al que pertenece
        /// </summary>
        [ParamSqlKey("@Departamento")]
        [ColumnSqlName("Departamento")]
        public string Departamento { get; set; }
        /// <summary>
        /// Salario del empleado que recibe cada periodo de pago 
        /// </summary>
        [ParamSqlKey("@Salario")]
        [ColumnSqlName("Salario")]
        public decimal Salario { get; set; }
        /// <summary>
        /// Direccion de correo electrónico del empleado
        /// </summary>
        [ParamSqlKey("@Email")]
        [ColumnSqlName("Email")]
        public string Email { get; set; }
        /// <summary>
        /// Telefono de contacto del empleado
        /// </summary>
        [ParamSqlKey("@Telefono")]
        [ColumnSqlName("Telefono")]
        public string Telefono { get; set; }
        /// <summary>
        /// Domicilio particular del empleado, donde reside
        /// </summary>
        [ParamSqlKey("@Direccion")]
        [ColumnSqlName("Domicilio")]
        public string Direccion { get; set; }

        #region METODOS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_HASH"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Response<Empleado> GetCompleteObject(string _HASH)
        {
            #region CODIGO
            AppDesignPatron appPatron = new AppDesignPatron();
            Empleado emp = new Empleado();
            Response<Empleado> _rsp = new Response<Empleado>(false, "Iniciando proceso de obtendion de datos...", emp);

            using (SqlReadConnection _connection = new SqlReadConnection(DataBaseName, TableName))
            {
                MySqlDataReader reader = _connection.MakeQuery("*");

                try
                {
                    while (reader.Read())
                    {
                        emp = new Empleado();
                        emp.HASH = reader.GetString(ColumnSqlName.GetValue<Empleado>("HASH"));
                        _rsp.Log.Add($"HASH obtenido...");
                        emp.Nombres = reader.GetString(ColumnSqlName.GetValue<Empleado>("Nombres"));
                        _rsp.Log.Add($"Nombres obtenido...");
                        emp.Apellidos = reader.GetString(ColumnSqlName.GetValue<Empleado>("Apellidos"));
                        _rsp.Log.Add($"Apellidos obtenido...");
                        emp.Edad = reader.GetInt32(ColumnSqlName.GetValue<Empleado>("Edad"));
                        _rsp.Log.Add($"Edad obtenido...");
                        emp.FechaDeIngreso = reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeIngreso"));
                        _rsp.Log.Add($"Fecha de Ingreso obtenido...");
                        emp.FechaDeSalida = reader[ColumnSqlName.GetValue<Empleado>("FechaDeSalida")] != DBNull.Value ? reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeSalida")) : null;
                        _rsp.Log.Add($"Fecha de Salida obtenido...");
                        emp.Status = EmpleadoStatusExtensions.Parse(reader.GetString(ColumnSqlName.GetValue<Empleado>("Status")));
                        _rsp.Log.Add($"Estatus actual obtenido...");
                        emp.FechaDeNacimiento = reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeNacimiento"));
                        _rsp.Log.Add($"Fecha de Nacimiento obtenido...");
                        emp.Puesto = reader.GetString(ColumnSqlName.GetValue<Empleado>("Puesto"));
                        _rsp.Log.Add($"Puesto obtenido...");
                        emp.Departamento = reader.GetString(ColumnSqlName.GetValue<Empleado>("Departamento"));
                        _rsp.Log.Add($"Departamento obtenido...");
                        emp.Salario = reader.GetDecimal(ColumnSqlName.GetValue<Empleado>("Salario"));
                        _rsp.Log.Add($"Salario obtenido...");
                        emp.Email = reader.GetString(ColumnSqlName.GetValue<Empleado>("Email"));
                        _rsp.Log.Add($"Email obtenido...");
                        emp.Telefono = reader.GetString(ColumnSqlName.GetValue<Empleado>("Telefono"));
                        _rsp.Log.Add($"Telefono obtenido...");
                        emp.Direccion = reader.GetString(ColumnSqlName.GetValue<Empleado>("Direccion"));
                        _rsp.Log.Add($"Domicilio obtenido...");
                    }

                    _rsp.Success = true;
                    _rsp.Message = "Usuario obtenido y construido correctamente!";
                    _rsp.Object = emp;
                }
                catch (Exception ex)
                {
                    _rsp.Success = false;
                    _rsp.Message = ex.Message;
                    _rsp.Object = null;
                    _rsp.Log.Add(ex.ToString());
                }
            }

            return _rsp;
            #endregion
        }

        public static Response<Empleado[]> GetAll()
        {
            #region CODIGO
            AppDesignPatron appPatron = new AppDesignPatron();
            List<Empleado> emps = new List<Empleado>();
            Response<Empleado[]> _rsp = new Response<Empleado[]>(false, "Iniciando proceso de obtendion de datos...", emps.ToArray());

            using (SqlReadConnection _connection = new SqlReadConnection(DataBaseName, TableName))
            {
                MySqlDataReader reader = _connection.MakeQuery("*");

                try
                {
                    while (reader.Read())
                    {
                        Empleado emp = new Empleado()
                        {
                            HASH = reader.GetString(ColumnSqlName.GetValue<Empleado>("HASH")),
                            Nombres = reader.GetString(ColumnSqlName.GetValue<Empleado>("Nombres")),
                            Apellidos = reader.GetString(ColumnSqlName.GetValue<Empleado>("Apellidos")),
                            Edad = reader.GetInt32(ColumnSqlName.GetValue<Empleado>("Edad")),
                            FechaDeIngreso = reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeIngreso")),
                            FechaDeSalida = reader[ColumnSqlName.GetValue<Empleado>("FechaDeSalida")] != DBNull.Value ? reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeSalida")) : null,
                            Status = EmpleadoStatusExtensions.Parse(reader.GetString(ColumnSqlName.GetValue<Empleado>("Status"))),
                            FechaDeNacimiento = reader.GetDateTime(ColumnSqlName.GetValue<Empleado>("FechaDeNacimiento")),
                            Puesto = reader.GetString(ColumnSqlName.GetValue<Empleado>("Puesto")),
                            Departamento = reader.GetString(ColumnSqlName.GetValue<Empleado>("Departamento")),
                            Salario = reader.GetDecimal(ColumnSqlName.GetValue<Empleado>("Salario")),
                            Email = reader.GetString(ColumnSqlName.GetValue<Empleado>("Email")),
                            Telefono = reader.GetString(ColumnSqlName.GetValue<Empleado>("Telefono")),
                            Direccion = reader.GetString(ColumnSqlName.GetValue<Empleado>("Direccion"))
                        };
                        _rsp.Log.Add($"Empleado ({emp.HASH}) construido correctamente...");
                        emps.Add(emp);
                    }

                    _rsp.Success = true;
                    _rsp.Message = "Usuarios obtenidos correctamente!";
                    _rsp.Object = emps.ToArray();
                }
                catch (Exception ex)
                {
                    _rsp.Success = false;
                    _rsp.Message = ex.Message;
                    _rsp.Object = null;
                    _rsp.Log.Add(ex.ToString());
                }
            }

            return _rsp;
            #endregion
        }


        public Response Save()
        {
            #region CODIGO
            Response _rsp = new Response(false, "Iniciando proceso de guardado...");

            using (SqlWriteConnection _connection = new SqlWriteConnection(DataBaseName, TableName))
            {
                try
                {
                    (string, object)[] parameters = new (string, object)[]
                    {
                    ("@HASH", HASH),
                    ("@Nombres", Nombres),
                    ("@Apellidos", Apellidos),
                    ("@Edad", Edad),
                    ("@FechaDeIngreso", FechaDeIngreso),
                    ("@FechaDeSalida", FechaDeSalida.HasValue ? (object)FechaDeSalida.Value.ToString("yyyy-MM-dd") : DBNull.Value),
                    ("@Status", Status.GetText()),
                    ("@FechaNacimiento", FechaDeNacimiento),
                    ("@Puesto", Puesto),
                    ("@Departamento", Departamento),
                    ("@Salario", Salario),
                    ("@Email", Email),
                    ("@Telefono", Telefono),
                    ("@Direccion", Direccion)
                    };

                    string UPDATE_QUERY = SqlWriteConnection.BuildUpdateQuery<Empleado>(this, DataBaseName, TableName);
                    string INSERT_QUERY = SqlWriteConnection.BuildInsertQuery<Empleado>(this, DataBaseName, TableName);

                    var SERV_RESP = _connection.MakeQuery("HASH", HASH, INSERT_QUERY, UPDATE_QUERY, parameters);

                    if (SERV_RESP.Success)
                    {
                        _rsp.Message = $"Objeto ({HASH}) generado/actualizado con exito!";
                    }
                    else
                    {
                        _rsp.Message = $"Si se completo la ejecucion del metodo, pero ocurrio un error en el guardado del objeto ({HASH}) generado/actualizado!";
                        _rsp.Log.Add($"{SERV_RESP.GetBuildedLog()}");
                    }

                    _rsp.Success = SERV_RESP.Success;
                }
                catch (Exception ex)
                {
                    _rsp.Success = false;
                    _rsp.Message = $"Error al guardar el usuario: {ex.Message}";
                    //LogSystem.Add(EventIO.IN, EventType.EXCEPTION, ModuleMandator.Models, $"Models.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}\n{_rsp.GetBuildedLog()}");
                    MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return _rsp;
            #endregion
        }
        #endregion
    }
}
