using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Options;
using CentralAdmin.Library.Service.Configurations;

namespace CentralAdmin.Library.Service.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly ConnectionStrings _connectionStrings;
        public ConnectionFactory(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }
        public MySqlConnection CreateOpenConnection()
        {
            MySqlConnection conn = new MySqlConnection(_connectionStrings.AdminConnection);
            conn.Open();
            return conn;
        }
    }
}
