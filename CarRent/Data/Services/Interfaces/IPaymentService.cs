using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<Payment> GetAllPayments(int id);
    }
}
