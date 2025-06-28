using CustomMessageBox;
using Flow_Solver.DatabaseManager;
using FlowCommonWorkcore;
using iTextSharp.text.io;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver.ObjectsModels
{
    /// <summary>
    /// Usuario de red del sistema
    /// </summary>
    public class SysUser
    {
        public static readonly string TableName = "server_users";
        public static readonly string ObjectName = "SystemUser";
        public static readonly string ObjectTitle = "Usuario del sistema";
        public static readonly string DataBaseName = "flow_solver";
        public static readonly string ObjectDescription = "Usuario del sistema, empleado de la empresa, con privilegios de acceso al sistema y a los datos de la empresa.";


        /// <summary>
        /// Identificador único del usuario en el sistema
        /// </summary>
        [ParamSqlKey("@HASH")]
        [ColumnSqlName("HASH")]
        public string HASH { get; set; }
        /// <summary>
        /// Nombre de usuario del sistema, utilizado para iniciar sesión
        /// </summary>
        [ParamSqlKey("@Username")]
        [ColumnSqlName("Username")]
        public string Username { get; set; }
        /// <summary>
        /// HASH del empleado al que pertenece este usuario
        /// </summary>
        [ParamSqlKey("@Empleado")]
        [ColumnSqlName("Employee")]
        public Empleado Empleado { get; set; }
        /// <summary>
        /// Contraseña HASHEADA
        /// </summary>
        [ParamSqlKey("@Password")]
        [ColumnSqlName("Password")]
        public string Password { get; set; }
        /// <summary>
        /// Fecha de creacion del usuario
        /// </summary>
        [ParamSqlKey("@CreationDate")]
        [ColumnSqlName("CreationDate")]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Ultimo eso al sistema usando este usuario
        /// </summary>
        [ParamSqlKey("@LastAccess")]
        [ColumnSqlName("LastAccess")]
        public DateTime? LastAccess { get; set; }
        /// <summary>
        /// Intentos de acceso sin exito al sistema usando este usuario
        /// </summary>
        [ParamSqlKey("@LastAccessAttemp")]
        [ColumnSqlName("LastAccessAttemp")]
        public DateTime? LastAccessAttemp { get; set; }
        /// <summary>
        /// Privilegios del usuario en el sistema
        /// </summary>
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
                            LastAccess = reader[ColumnSqlName.GetValue<SysUser>("LastAccess")] != DBNull.Value ? reader.GetDateTime(ColumnSqlName.GetValue<SysUser>("LastAccess")) : null,
                            LastAccessAttemp = reader[ColumnSqlName.GetValue<SysUser>("LastAccessAttemp")] != DBNull.Value ? reader.GetDateTime(ColumnSqlName.GetValue<SysUser>("LastAccessAttemp")) : null,
                            Privilegies = reader.GetString(ColumnSqlName.GetValue<SysUser>("Privilegies")),
                        };
                        _rsp.Log.Add($"Objeto ({user.HASH}) obtenido...");

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


        /// <summary>
        /// Guarda el objeto en la base de datos
        /// </summary>
        /// <param name="RenewPassword">Indica si se requiere cambiar la contraseña</param>
        /// <param name="NewPassword">Nueva contraseña a ingresar en texto plano</param>
        /// <returns></returns>
        public Response Save(bool RenewPassword = false, string NewPassword = "")
        {
            #region CODIGO
            Response _rsp = new Response(false, "Iniciando proceso de guardado...");

            SqlWriteConnection _connection = new SqlWriteConnection(DataBaseName, TableName);
            try
            {
                (string, object)[] parameters = new (string, object)[]
                {
                    ("@HASH", HASH),
                    ("@Username", Username),
                    ("@Empleado", Empleado.HASH),
                    ("@Password", HashearPassword(Password)),
                    ("@CreationDate", CreationDate.ToString("yyyy-MM-dd")),
                    ("@LastAccess", LastAccess.HasValue ? (object)LastAccess.Value.ToString("yyyy-MM-dd") : DBNull.Value),
                    ("@LastAccessAttemp", LastAccessAttemp.HasValue ? (object)LastAccessAttemp.Value.ToString("yyyy-MM-dd") : DBNull.Value),
                    ("@Privilegies", Privilegies),
                };

                string EXTRA_SET_PASSWORD = RenewPassword ? "Password=@Password," : "";

                string UPDATE_QUERY = $@"
UPDATE {DataBaseName}.{TableName} SET
    Username=@Username,
    Empleado=@Empleado,
    {EXTRA_SET_PASSWORD}
    CreationDate=@CreationDate,
    LastAccess=@LastAccess,
    LastAccessAttemp=@LastAccessAttemp,
    Privilegies=@Privilegies
WHERE HASH=@HASH;";
                string INSERT_QUERY = SqlWriteConnection.BuildInsertQuery<SysUser>(this, DataBaseName, TableName);

                var SERV_RESP = _connection.MakeQuery("HASH", HASH, INSERT_QUERY, UPDATE_QUERY, parameters);

                if (SERV_RESP.Success)
                {
                    _rsp.Message = $"Usuario ({HASH}) generado/actualizado con exito!";
                }
                else
                {
                    _rsp.Message = $"Si se completo la ejecucion del metodo, pero ocurrio un error en el guardado del usuario ({HASH}) generado/actualizado!";
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
            finally
            {
                _connection.CloseConnection();  // Cerramos la conexion a la base de datos
            }
            #endregion

            return _rsp;
        }

        /// <summary>
        /// Hashea la contraseña correspondiente ingresada en texto plano
        /// </summary>
        /// <param name="_password"></param>
        /// <returns>Contraseña Hasheada</returns>
        public static string HashearPassword(string _password)
        {
            return BCrypt.Net.BCrypt.HashPassword(_password);
        }

        /// <summary>
        /// Valida que la contraseña ingresada sea correcta
        /// </summary>
        /// <param name="_password">contraseña en texto plano ingresada</param>
        /// <returns></returns>
        public Response ValidateUserPassword(string _password)
        {
            #region CODIGO
            Response _rsp = new Response(false, "Iniciando proceso de validacion...");

            SqlReadConnection _connection = new SqlReadConnection(DataBaseName, TableName);
            MySqlDataReader reader = _connection.MakeQuery("Password", "WHERE (HASH=@U_HASH)", new (string, object)[] { ("@U_HASH", HASH) });

            try
            {
                while (reader.Read())
                {

                    if (BCrypt.Net.BCrypt.Verify(_password, reader.GetString("Password")))
                    {
                        _rsp.Success = true;
                    }
                    else
                    {
                        _rsp.Success = false;
                    }
                }

                _rsp.Message = $"Contraseña de usuario ({HASH}) validada correctamente!";
            }
            catch (MySqlException ex)
            {
                _rsp.Success = false;
                _rsp.Message = $"No se pudo validar correctamente que la contraseña ({HASH}) sea valida!";
                //LogSystem.Add(EventIO.IN, EventType.EXCEPTION, ModuleMandator.Models, $"Models.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}\n{_rsp.GetBuildedLog()}");
                MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _connection.CloseConnection();
            }

            return _rsp;
            #endregion
        }
        #endregion
    }
}
