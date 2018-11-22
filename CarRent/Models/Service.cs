using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Service
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public TypeOfService TypesOfService { get; set; }
        public CustomerCar CustomerCar { get; set; }
        public Payment ServiceId { get; set; }
    }
}
