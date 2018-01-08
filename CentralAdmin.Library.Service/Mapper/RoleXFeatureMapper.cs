using CentralAdmin.Library.Service.Data.Models;
using CentralAdmin.Library.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralAdmin.Library.Service.Mapper
{
    public class RoleXFeatureMapper
    {
        public IList<RoleXFeaturesEntity> Map(RoleXFeatures roleFeatures)
        {
           return roleFeatures.Features?.Select(f => new RoleXFeaturesEntity()
            {
                FeatureId = f.FeatureId,
                RoleId = roleFeatures.RoleId,
                IsActive = f.IsActive
            }).ToList();
        }
    }
}
