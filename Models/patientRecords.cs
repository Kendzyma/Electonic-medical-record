using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Models
{
    public class patientRecords
    {

        [Key]
        [Required]
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Records { get; set; }
        public string seriousness { get; set; }
        public string Recommendations { get; set; }
    }
}
