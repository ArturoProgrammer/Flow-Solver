using FlowCommonWorkcore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Solver_Server
{
    public partial class ServerMethods
    {
        public class ConnectionsData
        {
            static Properties.Settings _oDef = Properties.Settings.Default;

            #region
            /// <summary>
            /// Hostname o IP del servidor
            /// </summary>
            public string ServerHostname { get; private set; } = _oDef.MY_SQL_HOSTNAME;
            /// <summary>
            /// Usuario del servidor
            /// </summary>
            public string ServerUser { get; private set; } = _oDef.MY_SQL_USERNAME;
            /// <summary>
            /// Contraseña del usuario del servidor
            /// </summary>
            public string ServerPassword { get; private set; } = _oDef.MY_SQL_PASSWORD;
            /// <summary>
            /// Tabla destino del servidor
            /// </summary>
            public string Table { get; internal set; }
            /// <summary>
            /// Base de Datos destino del servidor
            /// </summary>
            public string DataBase { get; internal set; }
            /// <summary>
            /// Cadena de Conexion a la base de datos
            /// </summary>
            public string ConnectionChain { get; internal set; }
            /// <summary>
            /// Cadena de Consulta a la base de datos
            /// </summary>
            public string QueryChain { get; internal set; }

            public MySqlConnection DataBaseConnection { get; internal set; }
            #endregion
        }

        /// <summary>
        /// Conexion a la base de datos para la lectura y obtencion de informacion
        /// </summary>
        public class SqlReadConnection : ConnectionsData
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="_DataBase">Nombre de la base de datos destino</param>
            /// <param name="_Table">Nombre de la tabla de la base de datos destino</param>
            public SqlReadConnection(string _DataBase, string _Table)
            {
                DataBase = _DataBase;
                Table = _Table;

                ConnectionChain = $"Database={DataBase}; Data Source={ServerHostname}; User Id={ServerUser}; Password={ServerPassword}";
                DataBaseConnection = new MySqlConnection(ConnectionChain);

                //erpMessageBox.Show($"Server -> {ServerHostname}\nUser Id -> {ServerUser}\nPassword -> {ServerPassword}");
                // Lanzamos el cuadro de conexion y credenciales del servidor
                if (String.IsNullOrEmpty(ServerHostname.Trim()) || String.IsNullOrEmpty(ServerUser.Trim()) || String.IsNullOrEmpty(ServerPassword.Trim()))
                {
                    ServerCredentialsBox.Show();
                }
            }

            /// <summary>
            /// Consulta la cadena de la lectura correspondiente. NO OLVIDAR AÑADIR LA EJECUCION DE LA FUNCION "CloseConnection()" una vez realizada la lectura de los datos para evitar errores de consultas y en ejecucion en tiempo real del programa
            /// </summary>
            /// <param name="_ColumnsChain">Parametro de las columnas e informacion a obtener de la base de datos</param>
            /// <param name="_QueryParams">Cadena de parametros opcionales como WHERE</param>
            /// <returns>Objeto Reader para manipular los datos leidos</returns>
            public MySqlDataReader MakeQuery(string _ColumnsChain, string _QueryParams = "", (string, object)[] _Parameters = null)
            {
                if (!String.IsNullOrEmpty(_QueryParams))
                    _QueryParams = $" {_QueryParams}";  // Añadimos un espacio por estetica en la funcion solo en caso de que se hayan añadido parametros de busqueda

                QueryChain = $"SELECT {_ColumnsChain} FROM {DataBase}.{Table}{_QueryParams};".Trim();

                MySqlCommand command = new MySqlCommand(QueryChain);
                command.Connection = DataBaseConnection;
                if (_Parameters != null)
                {
                    foreach (var (llave, valor) in _Parameters)
                    {
                        command.Parameters.AddWithValue(llave, valor);
                    }
                }
                DataBaseConnection.Open();

                return command.ExecuteReader();
            }

            /// <summary>
            /// Validamos la existencia la base de datos usada actualmente en el servidor
            /// </summary>
            /// <returns>True en caso de existir y False en caso contrario</returns>
            public bool IsDatabaseExists()
            {
                using (var connection = DataBaseConnection)
                {
                    connection.Open();

                    string query = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @databaseName";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@databaseName", DataBase);

                        using (var reader = command.ExecuteReader())
                        {
                            return reader.HasRows; // Si hay filas, la DB existe
                        }
                    }
                }
            }

            /// <summary>
            /// Cerramos la conexion con la base de datos correspondiente
            /// </summary>
            public void CloseConnection()
            {
                DataBaseConnection.Close();
            }
        }

        /// <summary>
        /// Conexion a la base de datos para la escritura y actualizacion de informacion
        /// 
        /// <br></br>
        /// Falta terminar para poder funcionar e implementar correctamente
        /// </summary>
        public class SqlWriteConnection : ConnectionsData
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="_DataBase">Nombre de la base de datos destino</param>
            /// <param name="_Table">Nombre de la tabla de la base de datos destino</param>
            public SqlWriteConnection(string _DataBase, string _Table)
            {
                DataBase = _DataBase;
                Table = _Table;

                ConnectionChain = $"Database={DataBase}; Data Source={ServerHostname}; User Id={ServerUser}; Password={ServerPassword}";
                DataBaseConnection = new MySqlConnection(ConnectionChain);

                // Lanzamos el cuadro de conexion y credenciales del servidor
                if (String.IsNullOrEmpty(ServerHostname.Trim()) || String.IsNullOrEmpty(ServerUser.Trim()) || String.IsNullOrEmpty(ServerPassword.Trim()))
                {
                    ServerCredentialsBox.Show();
                }
            }

            /// <summary>
            /// Consulta la cadena de la adicion o actualizacion correspondiente segun la comparacion de un valor en una columna. Si el valor en la columna ya existe, actualiza la informacion proporcionada, de lo contrario, añade un nuevo registro a la tabla indicada
            /// </summary>
            /// <param name="_InsertChain">Cadena de consulta para insertar nuevos datos</param>
            /// <param name="_UpdateChain">Cadena de consulta para actualizar datos existentes</param>
            /// <param name="_Parameters">Array de parametros de la consulta</param>
            /// <param name="_ComparationValue">Valor de la columna comparativa con el que se evaluara la existencia del objeto en la tabla indicada</param>
            /// <param name="_ComparationColumn">Columna en la que se buscara el valor a comparar</param>
            /// <param name="_Parameters">Parametros a reemplazar en la cadena de consulta</param>
            /// <returns>Objeto Reader para manipular los datos leidos</returns>
            public (bool OperationResult, string OperationMessage) MakeQuery(string _ComparationColumn, string _ComparationValue, string _InsertChain, string _UpdateChain, (string, object)[] _Parameters)
            {
                bool RESP_STATUS = false;
                string RESP_MSG = "";

                string qType = "";

                try
                {
                    if (UtilityFunctions.DoesObjectExists(DataBase, Table, _ComparationColumn, _ComparationValue) == true)
                    {
                        // Aqui se ejecuta el codigo correspondiente a la actualizacion de un objeto ya existente
                        QueryChain = _UpdateChain;
                        qType = "Adicion";
                    }
                    else
                    {
                        // Aqui se ejecuta el codigo correspondiente a la adicion de un objeto a la base de datos
                        QueryChain = _InsertChain;
                        qType = "Actualizacion";
                    }

                    DataBaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(QueryChain, DataBaseConnection);
                    foreach (var (llave, valor) in _Parameters)
                    {
                        cmd.Parameters.AddWithValue(llave, valor);
                    }
                    cmd.ExecuteNonQuery();

                    RESP_STATUS = true;
                    RESP_MSG = $"{qType} del objeto exitosa!";
                }
                catch (Exception ex)
                {
                    RESP_STATUS = false;
                    RESP_MSG = $"La {qType} no se realizo de manera correcta! {ex.Message}\n{ex}";
                    LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, Modules.ServerObjectController.GetText(), $"AppsMethods.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}");
                    MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", $"Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }

                return (RESP_STATUS, RESP_MSG);
            }

            /// <summary>
            /// Consulta de la cadena para la actualizacion de datos. Si el objeto existe en la tabla indicada, actualiza la informacion proporcionada. No crea un nuevo registro en caso de no existir el objeto en la tabla
            /// </summary>
            /// <param name="_ComparationColumn">Columna donde se buscara el valor correspondiente a comparar</param>
            /// <param name="_ComparationValue">Valorar a comparar en la columna indicada</param>
            /// <param name="_KeyValuesPair">Lista de las claves y valores a actualizar</param>
            /// <param name="_Parameters">Parametros a reemplazar en la cadena de consulta</param>
            /// <returns></returns>
            public (bool OperationResult, string OperationMessage) UpdateQuery(string _ComparationColumn, string _ComparationValue, (string Key, object Value)[] _KeyValuesPair, (string, object)[] _Parameters)
            {
                bool RESP_STATUS = false;
                string RESP_MSG = "";

                try
                {
                    if (UtilityFunctions.DoesObjectExists(DataBase, Table, _ComparationColumn, _ComparationValue) == true)
                    {
                        List<string> cols_string = new List<string>();
                        foreach ((string Key, object Value) i in _KeyValuesPair)
                        {
                            cols_string.Add($"{i.Key}={i.Value}");
                        }

                        string query = $"UPDATE {DataBase}.{Table} SET {String.Join(',', cols_string)} WHERE ({_ComparationColumn}='{_ComparationValue}');".Trim();
                        QueryChain = query;     // Establecemos cual es la cadena de consulta a ejecutar

                        DataBaseConnection.Open();
                        MySqlCommand cmd = new MySqlCommand(QueryChain, DataBaseConnection);
                        foreach (var (llave, valor) in _Parameters)
                        {
                            cmd.Parameters.AddWithValue(llave, valor);
                        }
                        cmd.ExecuteNonQuery();

                        RESP_STATUS = true;
                        RESP_MSG = $"Actualizacion del objeto ({_ComparationValue}) exitosa!";
                    }
                    else
                    {
                        RESP_STATUS = false;
                        RESP_MSG = $"El objeto ({_ComparationValue}) no existe en la base de datos!";
                    }
                }
                catch (Exception ex)
                {
                    RESP_STATUS = false;
                    RESP_MSG = $"La actualizacion no se realizo de manera correcta! {ex.Message}\n{ex}";
                    LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, Modules.ServerObjectController.GetText(), $"AppsMethods.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}");
                    MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", $"Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }

                return (RESP_STATUS, RESP_MSG);
            }

            /// <summary>
            /// Crea un nuevo esquema en la base de datos
            /// </summary>
            /// <param name="_SchemaName">Nombre de esquema a crear</param>
            /// <returns></returns>
            public static (bool OperationResult, string OperationMessage) CreateSchema (string _SchemaName, string _ServerHostname, string _ServerUsername, string _ServerPassword)
            {
                bool RESP_STATUS = false;
                string RESP_MSG = "";

                string connectionString = $"Server={_ServerHostname};Uid={_ServerUsername};Pwd={_ServerPassword};";

                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string createDbQuery = $"CREATE DATABASE IF NOT EXISTS `{_ServerHostname}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;";

                        using (var command = new MySqlCommand(createDbQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    // Realizamos la creacion del resto de las tablas correspondientes al esquema
                    CreateDatabase();
                }
                catch (Exception ex)
                {
                    LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, Modules.ServerObjectController.GetText(), "ServerMethods.cs", $"{}");
                }

                return (RESP_STATUS, RESP_MSG);
            }

            /// <summary>
            /// Cerramos la conexion con la base de datos correspondiente
            /// </summary>
            public void CloseConnection()
            {
                DataBaseConnection.Close();
            }


            /// <summary>
            /// Crea la cadena de consulta para la insercion de un objeto en la base de datos
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="_obj"></param>
            /// <param name="database"></param>
            /// <param name="table"></param>
            /// <returns></returns>
            public static string BuildInsertQuery<T>(T _obj, string database, string table)
            {
                PropertyInfo[] OBJ_PROPS = _obj.GetType().GetProperties();
                List<string> contentKeys = new List<string>();
                List<string> contentParams = new List<string>();

                foreach (PropertyInfo i in OBJ_PROPS)
                {
                    string ColumnName = ColumnSqlName.GetValue<T>(i.Name); // Nombre de la columna en la tabla
                    string ParamName = ParamSqlKey.GetValue<T>(i.Name);    // Llave del parametro

                    contentKeys.Add($"\t{ColumnName}");
                    contentParams.Add($"\t{ParamName}");
                }

                return $"INSERT INTO {database}.{table} (\n{String.Join(",\n", contentKeys)}\n) VALUES (\n{String.Join(",\n", contentParams)}\n);";
            }

            /// <summary>
            /// Crea la cadena de consulta para la actualizacion de un objeto en la base de datos
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="_obj"></param>
            /// <param name="database"></param>
            /// <param name="table"></param>
            /// <param name="conditional">Por defecto realiza la validacion de coincidencia de HASHES</param>
            /// <returns></returns>
            public static string BuildUpdateQuery<T>(T _obj, string database, string table, string conditional = "HASH=@HASH")
            {
                PropertyInfo[] OBJ_PROPS = _obj.GetType().GetProperties();
                List<string> contentKeysParam = new List<string>();

                foreach (PropertyInfo i in OBJ_PROPS)
                {
                    string ColumnName = ColumnSqlName.GetValue<T>(i.Name); // Nombre de la columna en la tabla
                    string ParamName = ParamSqlKey.GetValue<T>(i.Name);    // Llave del parametro

                    contentKeysParam.Add($"\t{ColumnName}={ParamName}");
                }

                return $"UPDATE {database}.{table} SET\n{String.Join(",\n", contentKeysParam)}\nWHERE ({conditional});";
            }
        }
    }
}
