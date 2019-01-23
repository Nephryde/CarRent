using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services.Interfaces
{
    public interface IGarageService
    {
        Task<Garage> GetGarageById(int garageId);
        Task<IEnumerable<Garage>> GetAllGarages();
        string GetGarageName(int garageId);
    }
}
