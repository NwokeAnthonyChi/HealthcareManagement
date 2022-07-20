using HealthCareManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
   public class StaffWardAssigned : BaseDomainEntity
    {
        public int StaffId { get; set; }
        public int WardId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
