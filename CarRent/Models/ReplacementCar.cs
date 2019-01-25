using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class ReplacementCar
    {
        public int Id { get; set; }
        [ForeignKey("CarModelId")]
        [Display(Name = "Numer modelu")]
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }
        [ForeignKey("GarageId")]
        [Display(Name = "Numer warsztatu")]
        public int GarageId { get; set; }
        public Garage Garage { get; set; }
        public ICollection<Rent> Rents { get; set; }
    }
}
