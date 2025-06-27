using FlowCommonWorkcore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum EmpleadoStatus
{
    Activo,
    Inactivo,
    Suspendido,
    Despedido,
    Renunciado
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


        [ParamSqlKey("@HASH")]
        [ColumnSqlName("HASH")]
        public string HASH { get; set; }
        [ParamSqlKey("@Nombres")]
        [ColumnSqlName("Nombres")]
        public string Nombres { get; set; }
        [ParamSqlKey("@Apellidos")]
        [ColumnSqlName("Apellidos")]
        public string Apellidos { get; set; }
        [ParamSqlKey("@Edad")]
        [ColumnSqlName("Edad")]
        public int Edad { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public EmpleadoStatus Status { get; set; } = EmpleadoStatus.Activo;
        public DateTime FechaDeNacimiento { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
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
            // Implementar la lógica para obtener un objeto Empleado completo desde la base de datos
            // Utilizar el HASH para identificar al empleado
            throw new NotImplementedException("Metodo GetCompleteObject no implementado.");
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
                        SysUser user = new SysUser()
                        {
                            HASH = reader.GetString(ColumnSqlName.GetValue<SysUser>("HASH")),
                            Username = reader.GetString(ColumnSqlName.GetValue<SysUser>("Username")),
                            Empleado = Empleado.GetCompleteObject(reader.GetString(ColumnSqlName.GetValue<SysUser>("Empleado"))).Object,
                            Password = reader.GetString(ColumnSqlName.GetValue<SysUser>("Password")),
                            CreationDate = reader.GetDateTime(ColumnSqlName.GetValue<SysUser>("CreationDate")),
                            LastAccess = reader.GetDateTime(ColumnSqlName.GetValue<SysUser>("LastAccess")),
                            LastAccessAttemp = reader.GetDateTime(ColumnSqlName.GetValue<SysUser>("LastAccessAttemp")),
                            Privilegies = reader.GetString(ColumnSqlName.GetValue<SysUser>("Privilegies")),
                        };

                        users.Add(user);
                    }

                    _rsp.Success = true;
                    _rsp.Message = "Usuarios obtenidos correctamente.";
                    _rsp.Object = users.ToArray();
                }
                catch (Exception ex)
                {
                    _rsp.Success = false;
                    _rsp.Message = "Error al obtener el usuario: " + ex.Message;
                    _rsp.Object = null;
                    _rsp.Log.Add(ex.ToString());
                }
            }

            return _rsp;
            #endregion
        }

        public Response Save()
        {
            throw new NotImplementedException("Metodo Save no implementado.");
        }
        #endregion
    }
}
