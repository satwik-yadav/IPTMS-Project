using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class TreatmentPlan
    {
        [Key]
        [Display(Name= "Plan-Id")]
        public int PlanId { get; set; }

        [Display(Name = "Patient-Id")]
        public int PatientId { get; set; }

        [Display(Name = "Ailment")]
        public string AilmentName { get; set; }

        [Display(Name = "Package")]
        public string PackageName { get; set; }

        [Display(Name = "Test Details")]
        public string TestDetails { get; set; }

        public double Cost { get; set; }

        [Display(Name = "Specialist Name")]
        public string SpecialistName { get; set; }

        [Display(Name = "Treatment Commencement Date")]
        public DateTime TreatmentCommencementDate { get; set; }

        [Display(Name = "Treatment End Date")]
        public DateTime TreatmentEndDate { get; set; }
        
        public string Status { get; set; }
    }
}
