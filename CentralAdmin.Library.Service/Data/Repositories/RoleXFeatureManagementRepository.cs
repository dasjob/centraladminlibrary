using CentralAdmin.Library.Service.Configurations;
using CentralAdmin.Library.Service.Data.Interfaces;
using CentralAdmin.Library.Service.Data.Models;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralAdmin.Library.Service.Data.Repositories
{
    public class RoleXFeatureManagementRepository: IRoleXFeatureManagementRepository
    {
        private readonly MySqlConnection _connection;
        private readonly IConnectionFactory _connectionFactory;
        private readonly string roleFeatureInsertQuery = @"insert into adminlibrary.rolesxfeatures(RoleId,FeatureId,IsActive) values('{0}','{1}','{2}');";
        public RoleXFeatureManagementRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            _connection=_connectionFactory.CreateOpenConnection();
        }
        public bool SaveRoleFeatures(IList<RoleXFeaturesEntity> entity)
        {
            if (entity == null || entity.Count == 0)
                return false;
            entity.ToList().ForEach(rf =>
            {
                string query = string.Format(roleFeatureInsertQuery, rf.RoleId, rf.FeatureId, rf.IsActive?1:0);
                InsertRoleFeature(query);
            });
            
            return true;
        }

        private void InsertRoleFeature(string query)
        {
            using (var cmd = new MySqlCommand(query, _connection))
            {
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            
        }
    }
}
