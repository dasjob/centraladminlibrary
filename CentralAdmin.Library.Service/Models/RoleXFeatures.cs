using System;
using System.Collections.Generic;
using System.Text;

namespace CentralAdmin.Library.Service.Models
{
    public class RoleXFeatures
    {
        public int RoleId { get; set; }
        public IList<Featurestatus> Features { get; set; }
    }

    public class Featurestatus
    {
        public int FeatureId { get; set; }
        public bool IsActive { get; set; }
    }
}
