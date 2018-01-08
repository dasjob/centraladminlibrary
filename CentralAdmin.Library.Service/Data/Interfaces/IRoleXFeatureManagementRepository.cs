using CentralAdmin.Library.Service.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralAdmin.Library.Service.Data.Interfaces
{
    public interface IRoleXFeatureManagementRepository
    {
        bool SaveRoleFeatures(IList<RoleXFeaturesEntity> entity);
    }
}
