using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerPausesViewModel
    {
        public IEnumerable<WorkerExemptionsViewModel> workerExemptionsViewModel { get; set; }
        public IEnumerable<WorkerVacationsViewModel> workerVacationsViewModel { get; set; }
    }
}
