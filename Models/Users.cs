using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Medical.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Please enter first name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Last name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter User name")]

        public string UserName{ get; set; }

        [Required(ErrorMessage = "Please enter licence number")]
        public int LicenceNumber { get; set; }

        [Required(ErrorMessage = "Please choose department")]
        public string department { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Please enter hospital name")]
        public string HospitalName { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter first phone number")]

        public int PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        public string status { get; set; }
    }
}