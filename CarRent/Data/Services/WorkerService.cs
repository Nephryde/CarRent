using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data.Services
{
    public class WorkerService : IWorkerService
    {
        private ApplicationDbContext _context;

        public WorkerService(ApplicationDbContext context) => _context = context;

        public async Task AddWorker(Worker newWorker)
        {
            await _context.Workers.AddAsync(newWorker);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWorkerById(int workerId)
        {
            Worker worker = await GetWorkerById(workerId);
            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers()
        {
            return await _context.Workers.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Worker>> GetOnlyBosses()
        {
            return await _context.Workers.Where(x => x.JobId == 2 || x.JobId == 1).ToListAsync();
        }

        public async Task<Worker> GetWorkerById(int workerId)
        {
            return await _context.Workers
                .FirstOrDefaultAsync(worker => worker.Id == workerId);
        }

        public async Task<Worker> GetWorkerById(int? workerId)
        {
            return await _context.Workers
                .FirstOrDefaultAsync(worker => worker.Id == workerId);
        }

        public async Task<Employment> GetWorkerEmployment(int workerId)
        {
            return await _context.Employments
                .FirstOrDefaultAsync(worker => worker.WorkerId == workerId);
        }

        public int GetTypeOfEmploymentId(int workerId)
        {
            return _context.Employments
                .FirstOrDefault(worker => worker.WorkerId == workerId)
                .TypeOfEmploymentId;
        }

        public string GetTypeOfEmploymentName(int employmentTypeId)
        {
            return _context.TypesOfEmployment
                .FirstOrDefault(type => type.Id == employmentTypeId)
                .Name;
        }

        public int GetGarageId(int id)
        {
            return _context.Workers
                .FirstOrDefault(worker => worker.Id == id)
                .GarageId;
        }

        public string GetJobName(int? jobId)
        {
            return _context.Jobs
                .FirstOrDefault(job => job.Id == jobId)
                .JobName;
        }

        public async Task AddWorkerTraining(EmployeeTraining employeeTraining)
        {
            await _context.EmployeeTrainings.AddAsync(employeeTraining);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Job>> GetAllJobs()
        {
            return await _context.Jobs.AsNoTracking().ToListAsync();
        }
    }
}
