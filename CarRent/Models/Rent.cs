using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Rent
    {
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        [Display(Name = "Dla klienta:")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("CustomerId")]
        [Display(Name = "Numer samochodu zastępczego")]
        public int ReplacementCarId { get; set; }
        public ReplacementCar ReplacementCar { get; set; }
        [Display(Name = "Data wypożyczenia")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zwrócenia")]
        public DateTime DateTo { get; set; }
    }
}
