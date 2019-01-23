using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services.Interfaces
{
    public interface IWorkerService
    {
        Task<IEnumerable<Worker>> GetAllWorkers();
        Task<Worker> GetWorkerById(int workerId);
        Task AddWorker(Worker newWorker);
        Task DeleteWorkerById(int workerId);
        int GetGarageId(int id);
    }
}
