using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models.ViewModels
{
    public class WorkerIndexViewModel
    {
        public IEnumerable<ListWorkersViewModel> Workers { get; set; }
        public int GarageId { get; set; }
    }
}
