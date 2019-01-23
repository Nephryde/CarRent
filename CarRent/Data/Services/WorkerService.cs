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

        public async Task<Worker> GetWorkerById(int workerId)
        {
            return await _context.Workers
                .FirstOrDefaultAsync(worker => worker.Id == workerId);
        }

        public int GetGarageId(int id)
        {
            return _context.Workers
                .FirstOrDefault(worker => worker.Id == id)
                .GarageId;
        }
    }
}
