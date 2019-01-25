using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        [ForeignKey("WorkerId")]
        [Display(Name = "Numer pracownika")]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        [Display(Name = "Data rozpoczęcia urlopu")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zakończenia urlopu")]
        public DateTime DateTo { get; set; }
    }
}
