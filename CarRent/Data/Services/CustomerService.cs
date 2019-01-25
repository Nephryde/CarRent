using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services
{
    public class CustomerService : ICustomerService
    {
        private ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context) => _context = context;

        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers
                .AsNoTracking().ToListAsync();
        }
    }
}
