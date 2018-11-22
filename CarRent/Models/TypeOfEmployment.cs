using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class TypeOfEmployment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employment> Employments{ get; set; }
    }
}
