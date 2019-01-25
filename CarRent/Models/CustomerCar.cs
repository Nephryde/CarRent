using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class CustomerCar
    {
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        [Display(Name = "Numer klienta")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("CarModelId")]
        [Display(Name = "Numer modelu")]
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
