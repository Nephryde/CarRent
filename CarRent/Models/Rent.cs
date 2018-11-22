using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public ReplacementCar ReplacementCar { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Cost { get; set; }
    }
}
