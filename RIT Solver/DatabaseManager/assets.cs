using CustomMessageBox;
using FlowCommonWorkcore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Flow_Solver.DatabaseManager
{
    public class DbUtils
    {
        /// <summary>
        /// Validamos la existencia de un objeto en la base de datos segun si encontramos coincidencias
        /// </summary>
        /// <param name="DataBase">Nombre de la base de datos</param>
        /// <param name="Table">Tabla donde estan los datos</param>
        /// <param name="Column">Columna de los datos a buscar</param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool DoesObjectExists(string DataBase, string Table, string Column, string Value)
        {
            AppDesignPatron appPatron = new AppDesignPatron();
            bool isExist = false;

            #region CONEXION
            string servidor = appPatron.DB_SERVER; //Nombre o ip del servidor de MySQL
            string usuario = appPatron.DB_USER; //Usuario de acceso a MySQL
            string password = appPatron.DB_PASSWORD; //Contraseña de actualUser de acceso a MySQL

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = $"Database={DataBase}; Data Source={servidor}; User Id= {usuario}; Password={password}";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            #endregion

            #region BUSQUEDA DE COINCIDENCIAS
            try
            {
                string consulta = $"SELECT * FROM {DataBase}.{Table} WHERE {Column}='{Value}';";
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                int coinc = 0;
                while (reader.Read())
                {
                    coinc++;
                }

                // Revisamos las coincidencias
                if (coinc > 0)
                {
                    isExist = true;
                }
                else if (coinc == 0)
                {
                    isExist = false;
                }
            }
            catch (MySqlException ex)
            {
                //LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, "AppsMethods.cs", $"{ex.Message}\n{ex.ToString()}");
                MessageBox.Show($"Ha ocurrido un error inesperado durante la consulta! {ex.Message}", "AppsMethods - Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.Close();
            }
            #endregion

            return isExist;
        }
    }

    public class ConnectionsData
    {
        #region
        static readonly AppDesignPatron appPatron = new AppDesignPatron();

        /// <summary>
        /// Hostname o IP del servidor
        /// </summary>
        public string ServerHostname { get; private set; } = appPatron.DB_SERVER;
        /// <summary>
        /// Usuario del servidor
        /// </summary>
        public string ServerUser { get; private set; } = appPatron.DB_USER;
        /// <summary>
        /// Contraseña del usuario del servidor
        /// </summary>
        public string ServerPassword { get; private set; } = appPatron.DB_PASSWORD;
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

    public class SqlReadConnection : ConnectionsData, IDisposable
    {
        private bool _disposed = false;

        public SqlReadConnection(string _DataBase, string _Table)
        {
            DataBase = _DataBase;
            Table = _Table;

            ConnectionChain = $"Database={DataBase}; Data Source={ServerHostname}; User Id={ServerUser}; Password={ServerPassword}";
            DataBaseConnection = new MySqlConnection(ConnectionChain);

            if (string.IsNullOrWhiteSpace(ServerHostname) || string.IsNullOrWhiteSpace(ServerUser) || string.IsNullOrWhiteSpace(ServerPassword))
            {
                //erpServerCredentials.EvaluateAuth();
            }
        }

        public MySqlDataReader MakeQuery(string _ColumnsChain, string _QueryParams = "", (string, object)[] _Parameters = null)
        {
            if (!string.IsNullOrEmpty(_QueryParams))
                _QueryParams = $" {_QueryParams}";

            QueryChain = $"SELECT {_ColumnsChain} FROM {DataBase}.{Table}{_QueryParams};".Trim();

            var command = new MySqlCommand(QueryChain, DataBaseConnection);
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

        public void CloseConnection()
        {
            if (DataBaseConnection?.State == System.Data.ConnectionState.Open)
                DataBaseConnection.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Para que no intente llamar al finalizador
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Libera recursos administrados
                    if (DataBaseConnection != null)
                    {
                        if (DataBaseConnection.State == System.Data.ConnectionState.Open)
                            DataBaseConnection.Close();
                        DataBaseConnection.Dispose();
                    }
                }
                // Aquí liberarías recursos no administrados si tuvieras
                _disposed = true;
            }
        }

        ~SqlReadConnection()
        {
            Dispose(false); // En caso de que olviden llamar a Dispose
        }
    }


    /// <summary>
    /// Conexion a la base de datos para la escritura y actualizacion de informacion
    /// 
    /// <br></br>
    /// Falta terminar para poder funcionar e implementar correctamente
    /// </summary>
    public class SqlWriteConnection : ConnectionsData, IDisposable
    {
        private bool _disposed = false;


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
                //erpServerCredentials.EvaluateAuth();
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
        public Response MakeQuery(string _ComparationColumn, string _ComparationValue, string _InsertChain, string _UpdateChain, (string, object)[] _Parameters)
        {
            bool RESP_STATUS = false;
            string RESP_MSG = "";

            string qType = "";

            try
            {
                if (DbUtils.DoesObjectExists(DataBase, Table, _ComparationColumn, _ComparationValue) == true)
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
                //LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, ModuleMandator.Apps_Methods, $"AppsMethods.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}");
                MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", $"Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return new Response(RESP_STATUS, RESP_MSG);
        }

        /// <summary>
        /// Consulta de la cadena para la actualizacion de datos. Si el objeto existe en la tabla indicada, actualiza la informacion proporcionada. No crea un nuevo registro en caso de no existir el objeto en la tabla
        /// </summary>
        /// <param name="_ComparationColumn">Columna donde se buscara el valor correspondiente a comparar</param>
        /// <param name="_ComparationValue">Valorar a comparar en la columna indicada</param>
        /// <param name="_KeyValuesPair">Lista de las claves y valores a actualizar</param>
        /// <param name="_Parameters">Parametros a reemplazar en la cadena de consulta</param>
        /// <returns></returns>
        public Response UpdateQuery(string _ComparationColumn, string _ComparationValue, (string Key, object Value)[] _KeyValuesPair, (string, object)[] _Parameters)
        {
            Response _rsp = new Response(false, "");

            try
            {
                if (DbUtils.DoesObjectExists(DataBase, Table, _ComparationColumn, _ComparationValue) == true)
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

                    _rsp.Success = true;
                    _rsp.Message = $"Actualizacion del objeto ({_ComparationValue}) exitosa!";
                }
                else
                {
                    _rsp.Success = false;
                    _rsp.Message = $"El objeto ({_ComparationValue}) no existe en la base de datos!";
                }
            }
            catch (Exception ex)
            {
                _rsp.Success = false;
                _rsp.Message = $"La actualizacion no se realizo de manera correcta! {ex.Message}\n{ex}";
                //LogSystem.Add(EventIO.OUT, EventType.EXCEPTION, ModuleMandator.Apps_Methods, $"AppsMethods.cs", $"Se ha producido una excepcion inesperado!! {ex.Message}\n{ex}\n{_rsp.GetBuildedLog()}");
                MessageBox.Show($"{ex.Message}\n\nEl programa indica:\n{ex.ToString()}", $"Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return _rsp;
        }

        /// <summary>
        /// Cerramos la conexion con la base de datos correspondiente
        /// </summary>
        public void CloseConnection()
        {
            DataBaseConnection.Close();
        }

        public void Dispose ()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Para que no intente llamar al finalizador
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Libera recursos administrados
                    if (DataBaseConnection != null)
                    {
                        if (DataBaseConnection.State == System.Data.ConnectionState.Open)
                            DataBaseConnection.Close();
                        DataBaseConnection.Dispose();
                    }
                }
                // Aquí liberarías recursos no administrados si tuvieras
                _disposed = true;
            }
        }

        ~SqlWriteConnection()
        {
            Dispose(false); // En caso de que olviden llamar a Dispose
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
