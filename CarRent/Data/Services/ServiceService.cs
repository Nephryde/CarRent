using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services
{
    public class ServiceService : IServiceService
    {
        private ApplicationDbContext _context;

        public ServiceService(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _context.Services.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TypeOfService>> GetAllTypesOfService()
        {
            return await _context.TypesOfService.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            return await _context.Payments.AsNoTracking().ToListAsync();
        }


    }
}
