using HealthCareManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
    public class StaffJobTitle : BaseDomainEntity
    {
        [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public string JobTitle { get; set; } = string.Empty;
       public string JobDescription { get; set; } = string.Empty;
        public string JobTitleCode { get; set; } = string.Empty;
        public DateTime From { get; set; }
        public DateTime To { get; set; }


    }
}
