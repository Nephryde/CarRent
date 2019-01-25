using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class AddingNewServiceViewModel
    {
        [Display(Name = "Rodzaj usługi")]
        public int TypeOfServiceId { get; set; }
        [Display(Name = "Przypisz pracownika")]
        public int WorkerId { get; set; }
        [Display(Name = "Numer rejestracyjny pojazdu klienta")]
        public string CustomerCarRegNumber { get; set; }

        [Display(Name = "Imię klienta")]
        public string CustomerName { get; set; }
        [Display(Name = "Nazwisko klienta")]
        public string CustomerSurname { get; set; }
        [Display(Name = "Adres klienta")]
        public string CustomerAddress { get; set; }
        [Display(Name = "Telefon klienta")]
        public string CustomerPhone { get; set; }
        [Display(Name = "Miasto klienta")]
        public string CustomerCity { get; set; }
        [Display(Name = "Kod pocztowy klienta")]
        public string CustomerPostalCode { get; set; }

        [Display(Name = "Marka samochodu")]
        public int BrandId { get; set; }

        [Display(Name = "Model samochodu")]
        public string CarModelName { get; set; }
        [Display(Name = "Rocznik samochodu")]
        public int CarModelYear { get; set; }

        [Display(Name = "Numer konta bankowego")]
        public string BankAccountNumber { get; set; }
        [Display(Name = "Data płatności")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Rodzaj płatności")]
        public int TypeOfPaymentId { get; set; }
    }
}
