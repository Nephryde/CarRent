using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }        
        [ForeignKey("BossId")]
        public Worker Boss { get; set; }
        public int? BossId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public int? JobId { get; set; }
        [ForeignKey("GarageId")]
        public Garage Garage { get; set; }
        public int GarageId { get; set; }
        public ICollection<Exemption> Exemptions { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; }

        
    }
}
