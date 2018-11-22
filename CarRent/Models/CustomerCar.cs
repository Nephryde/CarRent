using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class CustomerCar
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public CarModel CarModel { get; set; }
        public string RegistrationNumber { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
