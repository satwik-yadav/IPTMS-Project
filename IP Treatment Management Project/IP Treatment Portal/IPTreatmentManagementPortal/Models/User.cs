using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class User
    {
       
        [Required(ErrorMessage = "Username cannot be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; }
    }
}
