using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class AddingNewWorkerViewModel
    {
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
        [Display(Name = "Kierownik")]
        public int? BossId { get; set; }
        [Display(Name = "Stanowisko")]
        public int? JobId { get; set; }
        [Display(Name = "Warsztat")]
        public int GarageId { get; set; }
        [Display(Name = "Wynagrodzenie")]
        public decimal Salary { get; set; }
        [Display(Name = "Premia")]
        public decimal Bonus { get; set; }
        [Display(Name = "Data zatrudnienia")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zakończenia współpracy")]
        public DateTime DateTo { get; set; }
        [Display(Name = "Rodzaj zatrudnienia")]
        public int TypeOfEmploymentId { get; set; }
    }
}
