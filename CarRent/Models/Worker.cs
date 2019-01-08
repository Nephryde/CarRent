using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public Worker Boss { get; set; }
        public Job Job { get; set; }
        public Garage Garage { get; set; }
        public ICollection<Exemption> Exemptions { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; }

    }
}
