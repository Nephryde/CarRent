using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class RentCarViewModel
    {
        [Display(Name = "Klient")]
        public int CustomerId { get; set; }
        [Display(Name = "Samochód zastępczy")]
        public int ReplacementCarId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
