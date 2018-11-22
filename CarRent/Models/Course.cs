using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int NumberOfHours { get; set; }
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; }
    }
}
