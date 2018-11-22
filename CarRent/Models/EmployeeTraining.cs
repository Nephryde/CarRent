using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class EmployeeTraining
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public Course Course { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
}
