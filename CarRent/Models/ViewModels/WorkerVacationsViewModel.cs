using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerVacationsViewModel
    {
        public DateTime VacationDateFrom { get; set; }
        public DateTime VacationDateTo { get; set; }
        public double TotalDays { get; set; }
    }
}
