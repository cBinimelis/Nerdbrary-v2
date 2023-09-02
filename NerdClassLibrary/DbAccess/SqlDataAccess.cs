using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace NerdClassLibrary.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        /// <summary>
        /// Conexión a la base de datos para obtener la información utilizando un procedimiento almacenado.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="storedProcedure">Parámetro del procedimiento almacenado que se utilizará al realizar la llamada</param>
        /// <param name="parameters">parametros en el caso de que se requieraa un ID en específico para un procedimiento almacenado</param>
        /// <param name="connectionId">String de conexión alojado en el archivo 'appsettings.json'</param>
        /// <returns>Devuelve un IEnumerable con toda la información solicitada para poder poblar el campos requeridos</returns>
        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedProcedure,
            U parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(
            string storedProcedure,
            T parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
