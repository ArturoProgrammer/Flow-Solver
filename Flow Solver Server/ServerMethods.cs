using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Solver_Server
{
    public class ServerMethods
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
    }
}
