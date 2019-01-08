using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services
{
    public class CarService : ICarService
    {
        private ApplicationDbContext _context;

        public CarService(ApplicationDbContext context) => _context = context;

        public async Task AddCar(CarModel carModel)
        {
            await _context.AddAsync(carModel);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarModel>> GetAll()
        {
            return await _context.CarModels.AsNoTracking().ToListAsync();
        }

        public async Task<CarModel> GetCarById(int id)
        {
            return await _context.CarModels
                .FirstOrDefaultAsync(car => car.Id == id);
        }
    }
}
