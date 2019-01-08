using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services.Interfaces
{
    interface ICarService
    {
        Task<IEnumerable<CarModel>> GetAll();
        Task<CarModel> GetCarById(int id);
        Task AddCar(CarModel carModel);
    }
}
