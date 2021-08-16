using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class InsurerDetail
    {
        [Key]
        [Display(Name = "Insurer Name")]
        public string InsurerName { get; set; }

        [Display(Name = "Insurer Package Name")]
        public string InsurerPackageName { get; set; }

        [Display(Name = "Insurance Amount Limit")]
        public int InsuranceAmountLimit { get; set; }

        [Display(Name = "Disbursement Duration")]
        public string DisbursementDuration { get; set; }
    }
}
