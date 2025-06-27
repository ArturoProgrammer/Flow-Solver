using Flow_Solver.DatabaseManager;
using FlowCommonWorkcore;
using iTextSharp.text.io;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Solver.ObjectsModels
{
    /// <summary>
    /// Usuario de red del sistema
    /// </summary>
    public class SysUser
    {
        public static readonly string TableName = "serv_users";
        public static readonly string ObjectName = "SystemUser";
        public static readonly string ObjectTitle = "Usuario del sistema";
        public static readonly string DataBaseName = "flow_solver";
        public static readonly string ObjectDescription = "Usuario del sistema, empleado de la empresa, con privilegios de acceso al sistema y a los datos de la empresa.";



        [ParamSqlKey("@HASH")]
        [ColumnSqlName("HASH")]
        public string HASH { get; set; }
        [ParamSqlKey("@Username")]
        [ColumnSqlName("Username")]
        public string Username { get; set; }
        [ParamSqlKey("@Empleado")]
        [ColumnSqlName("Employee")]
        public Empleado Empleado { get; set; }
        /// <summary>
        /// Contraseña HASHEADA
        /// </summary>
        [ParamSqlKey("@Password")]
        [ColumnSqlName("Password")]
        public string Password { get; set; }
        [ParamSqlKey("@CreationDate")]
        [ColumnSqlName("CreationDate")]
        public DateTime CreationDate { get; set; }
        [ParamSqlKey("@LastAccess")]
        [ColumnSqlName("LastAccess")]
        public DateTime LastAccess { get; set; }
        [ParamSqlKey("@LastAccessAttemp")]
        [ColumnSqlName("LastAccessAttemp")]
        public DateTime LastAccessAttemp { get; set; }
        [ParamSqlKey("@Privilegies")]
        [ColumnSqlName("Privilegies")]
        public string Privilegies { get; set; } = "USER"; // USER, ADMIN, SUPERADMIN

        #region METODOS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_HASH"></param>
        /// <returns></returns>
        public static Response<SysUser> GetCompleteObject(string _HASH)
        {
            #region CODIGO
            AppDesignPatron appPatron = new AppDesignPatron();
            SysUser user = new SysUser();
            Response<SysUser> _rsp = new Response<SysUser>(false, "Iniciando proceso de obtendion de datos...", user);

            using (SqlReadConnection _connection = new SqlReadConnection(DataBaseName, TableName))
            {
                MySqlDataReader reader = _connection.MakeQuery("*");

                try
                {
                    while (reader.Read())
                    {
                        user = new SysUser()
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
                    }

                    _rsp.Success = true;
                    _rsp.Message = "Usuarios obtenidos correctamente.";
                    _rsp.Object = user;
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

        /// <summary>
        /// Obtenemos todos los usuarios del sistema
        /// </summary>
        /// <returns></returns>
        public static Response<SysUser[]> GetAll()
        {
            #region CODIGO
            AppDesignPatron appPatron = new AppDesignPatron();
            List<SysUser> users = new List<SysUser>();
            Response<SysUser[]> _rsp = new Response<SysUser[]>(false, "Iniciando proceso de obtendion de datos...", users.ToArray());

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
        #endregion
    }
}
