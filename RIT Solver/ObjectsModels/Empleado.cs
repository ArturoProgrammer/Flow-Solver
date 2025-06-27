using FlowCommonWorkcore;
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
            // Implementar la lógica para obtener todos los objetos Empleado desde la base de datos
            throw new NotImplementedException("Metodo GetAllObjects no implementado.");
        }

        public Response Save()
        {
            throw new NotImplementedException("Metodo Save no implementado.");
        }
        #endregion
    }
}
