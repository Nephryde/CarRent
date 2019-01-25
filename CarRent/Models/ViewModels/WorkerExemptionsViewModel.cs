using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerExemptionsViewModel
    {
        public string ExemptionReason { get; set; }
        public DateTime ExemptionDateFrom { get; set; }
        public DateTime ExemptionDateTo { get; set; }
    }
}
