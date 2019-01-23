using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerEmploymentViewModel
    {
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string TypeOfEmploymentName { get; set; }
    }
}
