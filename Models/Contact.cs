using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team2.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstNameContact { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastNameContact { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string EmailContact { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public string PhoneContact { get; set; }
    }
}
