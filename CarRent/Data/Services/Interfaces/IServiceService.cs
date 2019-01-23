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
    }
}
