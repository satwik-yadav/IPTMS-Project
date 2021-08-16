using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPTreatmentManagementPortal.Models
{
    public class PackageDetail
    {

        public int PackageId { get; set; }
 
        public string Ailment { get; set; }

        [Display(Name = "Treatment Package")]
        public string TreatmentPackageName { get; set; }

        [Display(Name = "Test Details")]
        public string TestDetails { get; set; }
        public int Cost { get; set; }

        [Display(Name = "Treatment Duration")]
        public int TreatmentDuration { get; set; }
    }
}
