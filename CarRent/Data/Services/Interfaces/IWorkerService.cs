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
        Task<Worker> GetWorkerById(int? workerId);
        Task AddWorker(Worker newWorker);
        Task DeleteWorkerById(int workerId);
        int GetGarageId(int id);
        string GetJobName(int? jobId);
        Task<Employment> GetWorkerEmployment(int workerId);
        string GetTypeOfEmploymentName(int employmentTypeId);
        int GetTypeOfEmploymentId(int workerId);
        Task AddWorkerTraining(EmployeeTraining employeeTraining);
        Task<IEnumerable<Job>> GetAllJobs();
        Task<IEnumerable<Worker>> GetOnlyBosses();
    }
}
