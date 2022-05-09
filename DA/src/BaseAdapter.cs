using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace DigiVisio2030.DA
{
    public class BaseAdapter
    {
        private readonly IConfiguration _configuration;
        private readonly string _connection;
        public BaseAdapter(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = _configuration.GetConnectionString("PostgresqlDB");
        }
        public IDbConnection OpenConnection()
        {
            var conn = new NpgsqlConnection(_connection);
            conn.Open();
            return conn;
        }
    }
}
