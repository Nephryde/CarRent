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
        Task EditWorker(Worker worker);
        int GetGarageId(int id);
        string GetJobName(int? jobId);
        Task<Employment> GetWorkerEmployment(int workerId);
        string GetTypeOfEmploymentName(int employmentTypeId);
        int GetTypeOfEmploymentId(int workerId);
        Task AddWorkerTraining(EmployeeTraining employeeTraining);
        Task<IEnumerable<Job>> GetAllJobs();
        Task<IEnumerable<Worker>> GetOnlyBosses();
        Task<IEnumerable<EmployeeTraining>> GetWorkerAllTrainings(int workerId);
        Task<Course> GetTrainingCourse(int courseId);
        string GetTrainingCourseName(int courseId);
        decimal GetTrainingCourseCost(int courseId);
        int GetTrainingCourseHours(int courseId);
        Task AddEmployment(Employment employment);
        Task<IEnumerable<TypeOfEmployment>> GetAllTypesEmployment();
        Task AddWorkerExemption(Exemption exemption);
        Task AddWorkerVacation(Vacation vacation);
        Task<IEnumerable<Exemption>> GetWorkerAllExemptions(int workerId);
        Task<IEnumerable<Vacation>> GetWorkerAllVacations(int workerId);
        bool CheckIfWorkerOnExemption(int workerId);
        bool CheckIfWorkerOnVacation(int workerId);
        Task<IEnumerable<Course>> GetAllCourses();
    }
}
