using CentralAdmin.Library.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CentralAdmin.Library.Service.Models;
using CentralAdmin.Library.Service.Data.Interfaces;
using CentralAdmin.Library.Service.Data.Repositories;
using CentralAdmin.Library.Service.Mapper;

namespace CentralAdmin.Library.Service.Services.Implementation
{
    public class RoleXFeatureManagementService : IRoleXFeatureManagementService
    {
        private readonly IRoleXFeatureManagementRepository _roleXFeatureManagementRepository;
        public RoleXFeatureManagementService(IRoleXFeatureManagementRepository roleXFeatureManagementRepository)
        {
            _roleXFeatureManagementRepository = roleXFeatureManagementRepository;
        }
        public bool SaveRoleFeatures(RoleXFeatures roleFeatures)
        {
            if (!ValidateSaveRequest(roleFeatures))
                return false;

           return _roleXFeatureManagementRepository.SaveRoleFeatures(new RoleXFeatureMapper().Map(roleFeatures));
        }
        private bool ValidateSaveRequest(RoleXFeatures roleFeatures)
        {
            if (roleFeatures.RoleId == 0)
                return false;

            if (roleFeatures.Features == null || roleFeatures.Features.Count == 0)
                return false;

            return true;
        }
    }
}
