using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string BossName { get; set; }
        public string BossSurname { get; set; }
        public string JobName { get; set; }
        public string GarageName { get; set; }
    }
}
