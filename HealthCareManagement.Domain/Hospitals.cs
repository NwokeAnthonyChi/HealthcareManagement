using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Domain
{
    public class Hospitals
    {

        [Required(ErrorMessage = "The title is required"), MaxLength(100, ErrorMessage = "Hospital name cannot exceed 100 characters")]
        public string HospitalName { get; set; } = string.Empty;
        public string HospitalAddrees { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
