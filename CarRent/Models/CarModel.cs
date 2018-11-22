using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<ReplacementCar> ReplacementCars { get; set; }
        public ICollection<CustomerCar> CustomerCars { get; set; }
    }
}
