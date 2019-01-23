using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services
{
    public class GarageService : IGarageService
    {
        private ApplicationDbContext _context;

        public GarageService(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Garage>> GetAllGarages()
        {
            return await _context.Garages.AsNoTracking().ToListAsync();
        }

        public async Task<Garage> GetGarageById(int garageId)
        {
            return await _context.Garages
                .FirstOrDefaultAsync(garage => garage.Id == garageId);
        }

        public string GetGarageName(int garageId)
        {
            return _context.Garages
                .FirstOrDefault(garage => garage.Id == garageId).Name;
        }
    }
}
