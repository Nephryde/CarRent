using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
