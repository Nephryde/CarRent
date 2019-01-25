using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("TypeOfPaymentId")]
        public int TypeOfPaymentId { get; set; }
        public TypeOfPayment TypesOfPayment { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } 
       
    }
}
