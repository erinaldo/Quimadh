using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios
{
    public partial class Servicios
    {
        /// <summary>
        /// Ejecuta el procedimiento almacenado y devuelve un dataset
        /// con el conjunto de datos obtenidos.
        /// </summary>
        /// <param name="nombre">Nombre del SP</param>
        /// <param name="parametros">Parámetros del SP. En caso de que el parámetro sea nulo, agregar DBNull.Value</param>
        /// <returns></returns>
        public DataSet EjecutarSP(string nombre, Dictionary<string, object> parametros)
        {
            var connectionString = ((IDbConnection)_contexto.Database.Connection).ConnectionString;
            var dataSet = new DataSet();

            List<SqlParameter> parametrosSP = new List<SqlParameter>();

            foreach (KeyValuePair<string, object> parametro in parametros)
            {
                if (parametro.Value == null)
                    parametrosSP.Add(new SqlParameter(parametro.Key, DBNull.Value));
                else
                    parametrosSP.Add(new SqlParameter(parametro.Key, parametro.Value));
            }

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = nombre;
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var parametro in parametrosSP)
                        cmd.Parameters.Add(parametro);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }

            return dataSet;
        }
    }
}
