using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;

namespace CentralAdmin.Library.Service.Data
{
    public interface IConnectionFactory
    {
        MySqlConnection CreateOpenConnection();
    }
}
