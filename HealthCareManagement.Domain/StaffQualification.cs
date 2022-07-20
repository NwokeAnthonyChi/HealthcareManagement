using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
    public class StaffQualification : BaseDomailEntity
    {
        [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public string QualificationCode1 { get; set; }
        public string StaffQualificationCode2 { get; set; }
        public int StaffQualificationCode3 { get; set; }
        public DateTime DateObtained { get; set; }
    }
}
