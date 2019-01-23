using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Kod Pocztowy")]
        public string PostCode { get; set; }        
        [ForeignKey("BossId")]
        public Worker Boss { get; set; }
        [Display(Name = "Kierownik")]
        public int? BossId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        [Display(Name = "Stanowisko")]
        public int? JobId { get; set; }
        [ForeignKey("GarageId")]
        public Garage Garage { get; set; }
        [Display(Name = "Warsztat")]
        public int GarageId { get; set; }
        public ICollection<Exemption> Exemptions { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; }

        
    }
}
