using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Medical.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MedicalUse class
    public class MedicalUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Last name")]
        [StringLength(255)]
        public string LastName { get; set; }

        public string UserID { get; set; }



        [Required(ErrorMessage = "Please enter licence number")]
        public int LicenceNumber { get; set; }

        //[Required(ErrorMessage = "Please choose department")]
        //public string Department { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter hospital name")]
        public string HospitalName { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public int PhoneNumber { get; set; }

    }
}
