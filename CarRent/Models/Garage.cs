using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public ICollection<ReplacementCar> ReplacementCars { get; set; }
    }
}
