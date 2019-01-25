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

        public async Task AddService(Service service)
        {
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }

        public async Task AddPayment(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }

        public async Task AddCustomerCar(CustomerCar customerCar)
        {
            await _context.CustomerCars.AddAsync(customerCar);
            await _context.SaveChangesAsync();
        }

        public async Task AddCarModel(CarModel carModel)
        {
            await _context.CarModels.AddAsync(carModel);
            await _context.SaveChangesAsync();
        }

        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TypeOfPayment>> GetAllTypesOfPayment()
        {
            return await _context.TypesOfPayment
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Brand>> GetAllBrands()
        {
            return await _context.Brandes
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers()
        {
            return await _context.Workers
                .AsNoTracking().ToListAsync();
        }

        public async Task AddRent(Rent rent)
        {
            await _context.Rents.AddAsync(rent);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customers
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ReplacementCar>> GetAllReplacementCars()
        {
            return await _context.ReplacementCars
                .AsNoTracking().ToListAsync();
        }

    }
}
