using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAllServices();
        Task<IEnumerable<TypeOfService>> GetAllTypesOfService();
        Task<IEnumerable<Payment>> GetAllPayments();
        Task AddService(Service service);
        Task AddCustomer(Customer customer);
        Task AddPayment(Payment payment);
        Task AddCustomerCar(CustomerCar customerCar);
        Task AddCarModel(CarModel carModel);
        Task<IEnumerable<TypeOfPayment>> GetAllTypesOfPayment();
        Task<IEnumerable<Brand>> GetAllBrands();
        Task<IEnumerable<Worker>> GetAllWorkers();
        Task AddRent(Rent rent);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<IEnumerable<ReplacementCar>> GetAllReplacementCars();
    }
}
