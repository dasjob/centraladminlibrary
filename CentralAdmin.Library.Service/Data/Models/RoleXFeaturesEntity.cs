using System;
using System.Collections.Generic;
using System.Text;

namespace CentralAdmin.Library.Service.Data.Models
{
    public class RoleXFeaturesEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int FeatureId { get; set; }
        public bool IsActive { get; set; }
    }
}
