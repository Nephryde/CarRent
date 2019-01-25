using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        [ForeignKey("BrandId")]
        [Display(Name = "Numer marki")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [Display(Name = "Nazwa modelu")]
        public string Name { get; set; }
        [Display(Name = "Rocznik")]
        public int Year { get; set; }
        public ICollection<ReplacementCar> ReplacementCars { get; set; }
        public ICollection<CustomerCar> CustomerCars { get; set; }
    }
}
