using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Ailment { get; set; }

        [Required]
        [Display(Name = "Treatment Package")]
        public string TreatmentPackageName { get; set; }

        [Required]
        [Display(Name = "Commencement Date")]
        public string CommencementDate { get; set; }
    }
}
