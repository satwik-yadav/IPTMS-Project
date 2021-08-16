using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class InitiateClaim
    {

        [Key]
        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }

        [Display(Name = "Ailment")]
        [Required]
        public string Ailment { get; set; }

        [Display(Name = "Treatment Package Name")]
        [Required]
        public string TreatmentPackageName { get; set; }

        [Display(Name = "Insurer Name")]
        [Required]
        public string InsurerName { get; set; }

        [Display(Name = "Total Insurance Cost")]
        [Required]
        public int TotalInsuranceCost { get; set; }
    }
}
