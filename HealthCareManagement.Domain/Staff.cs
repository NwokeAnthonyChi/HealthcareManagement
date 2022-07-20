using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
    public class Staff : BaseDomailEntity
    {
        public int HospitalId { get; set; }
        public string StaffCategoryCode { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public String StaffFirstName { get; set; } = string.Empty;
        public string StaffMiddleName { get; set; } = string.Empty;
        public string StaffLastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public string StaffAddress { get; set; } = string.Empty;
        public string StaffPhoneNumber { get; set; } = string.Empty;
        public string StaffEmail { get; set; } = string.Empty;

    }
}
