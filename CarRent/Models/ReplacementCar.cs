using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class ReplacementCar
    {
        public int Id { get; set; }
        public CarModel CarModel { get; set; }
        public string RegistrationNumber { get; set; }
        public Garage Garage { get; set; }
        public ICollection<Rent> Rents { get; set; }
    }
}
