using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Exemption
    {
        public int Id { get; set; }
        [ForeignKey("WorkerId")]
        [Display(Name = "Numer pracownika")]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        [Display(Name = "Data rozpoczęcia zwolnienia")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zakończenia zwolnienia")]
        public DateTime DateTo { get; set; }
        [Display(Name = "Powód zwolnienia")]
        public string Reason { get; set; }
    }
}
