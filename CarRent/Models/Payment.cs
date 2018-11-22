using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime Date { get; set; }
        public TypeOfPayment TypesOfPayment { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } 
       
    }
}
