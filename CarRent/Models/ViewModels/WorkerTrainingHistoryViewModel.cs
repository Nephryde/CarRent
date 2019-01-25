using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerTrainingHistoryViewModel
    {
        [Display(Name = "Data rozpoczęcia szkolenia")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zakończenia szkolenia")]
        public DateTime DateTo { get; set; }
        [Display(Name = "Nazwa szkolenia")]
        public string TrainingName { get; set; }
        [Display(Name = "Cena szkolenia")]
        public decimal Cost { get; set; }
        [Display(Name = "Ilość godzin szkolenia")]
        public int NumberOfHours { get; set; }
    }
}
