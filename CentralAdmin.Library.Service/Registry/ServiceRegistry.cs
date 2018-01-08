using CentralAdmin.Library.Service.Data;
using CentralAdmin.Library.Service.Data.Interfaces;
using CentralAdmin.Library.Service.Data.Repositories;
using CentralAdmin.Library.Service.Services.Implementation;
using CentralAdmin.Library.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralAdmin.Library.Service.Registry
{
    public class ServiceRegistry : StructureMap.Registry
    {


        public ServiceRegistry()
        {
            ForSingletonOf<IConnectionFactory>().Use<ConnectionFactory>();
            For<IRoleXFeatureManagementRepository>().Use<RoleXFeatureManagementRepository>();
            For<IRoleXFeatureManagementService>().Use<RoleXFeatureManagementService>();
        }
    }
}
