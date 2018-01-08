using CentralAdmin.Library.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralAdmin.Library.Service.Services.Interfaces
{
    public interface IRoleXFeatureManagementService
    {
        bool SaveRoleFeatures(RoleXFeatures roleFeatures);
    }
}
