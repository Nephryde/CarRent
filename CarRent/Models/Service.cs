using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Service
    {
        public int Id { get; set; }
        [ForeignKey("WorkerId")]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        [ForeignKey("TypeOfServiceId")]
        public int TypeOfServiceId { get; set; }
        public TypeOfService TypesOfService { get; set; }
        [ForeignKey("CustomerCarId")]
        public int CustomerCarId { get; set; }
        public CustomerCar CustomerCar { get; set; }
        public Payment ServiceId { get; set; }
    }
}
