using CentralAdmin.Library.Service.Models;
using CentralAdmin.Library.Service.Services.Implementation;
using CentralAdmin.Library.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CentralAdmin.Library.Web.Controllers
{
    [Route("api/settings")]
    public class RoleXFeaturesManagementController
    {
        private readonly IRoleXFeatureManagementService _roleXFeatureManagementService;
        public RoleXFeaturesManagementController(IRoleXFeatureManagementService roleXFeatureManagementService)
        {
            _roleXFeatureManagementService = roleXFeatureManagementService;
        }

        [HttpPost("managefeaturexroles")]
        public HttpResponseMessage SaveRoleXFeatures([FromBody]RoleXFeatures roleFeatures)
        {
            if(roleFeatures.RoleId==0)
                return new HttpResponseMessage(HttpStatusCode.NotModified);

            if (roleFeatures.Features == null || roleFeatures.Features.Count == 0)
                return new HttpResponseMessage(HttpStatusCode.NotModified);

            _roleXFeatureManagementService.SaveRoleFeatures(roleFeatures);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
