using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Employment
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public TypeOfEmployment TypeOfEmployment { get; set; }

    }
}
