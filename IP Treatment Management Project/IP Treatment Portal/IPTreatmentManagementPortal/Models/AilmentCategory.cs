using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPTreatmentManagementPortal.Models
{
    public class AilmentCategory
    {
        [Key]
        public string Ailment { get; set; }
    }
}
