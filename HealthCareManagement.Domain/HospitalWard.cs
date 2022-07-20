using HealthCareManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
    public class HospitalWard : BaseDomainEntity
    {
        public string WardName { get; set; }
        public string Location { get; set; }
        public string description { get; set; }
        public int HospitalId { get; set; }
    }
}
