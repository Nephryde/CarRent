using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Data.Services.Interfaces;
using CarRent.Models;
using CarRent.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    public class WorkerController : Controller
    {
        private readonly IWorkerService _workerService;
        private readonly IGarageService _garageService;

        public WorkerController(
            IWorkerService workerService,
            IGarageService garageService)
        {
            _workerService = workerService;
            _garageService = garageService;
        }            

        public async Task<IActionResult> Index()
        {
            var workerModel = await _workerService.GetAllWorkers();

            var listingResult = workerModel
                .Select(result => new ListWorkersViewModel
                {
                    Id = result.Id,
                    Name = result.Name,
                    Surname = result.Surname,
                    GarageId = _workerService.GetGarageId(result.Id),
                    GarageName = _garageService.GetGarageName(_workerService.GetGarageId(result.Id))
                });

            return View(listingResult);
        }

        [HttpGet]
        public async Task<IActionResult> AddWorker()
        {
            IEnumerable<Garage> garageEnum;
            IEnumerable<Job> jobEnum;
            IEnumerable<Worker> workerEnum;

            garageEnum = await _garageService.GetAllGarages();
            List<Garage> garageList = garageEnum.ToList();
            ViewBag.ListOfGarages = garageList;

            jobEnum = await _workerService.GetAllJobs();
            List<Job> jobList = jobEnum.ToList();
            ViewBag.ListOfJobs = jobList;

            workerEnum = await _workerService.GetOnlyBosses();
            List<Worker> workerList = workerEnum.ToList();
            List<Boss> bossList = new List<Boss>();

            foreach (var item in workerList)
                bossList.Add(new Boss { Id = item.Id, FullName = item.Name + " " + item.Surname });

            ViewBag.ListOfBosses = bossList;         

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorker(Worker worker)
        {            
            await _workerService.AddWorker(worker);

            return View("~Views/Manage/Index.cshtml");
        }

        public async Task<IActionResult> WorkerDetails(int workerId)
        {
            var workerModel = await _workerService.GetWorkerById(workerId);
            var bossModel = await _workerService.GetWorkerById(workerModel.BossId);
            var employmentModel = await _workerService.GetWorkerEmployment(workerId);

            var workerDetailsListingResult = new WorkerDetailsViewModel()
            {
                Id = workerModel.Id,
                Name = workerModel.Name,
                Surname = workerModel.Surname,
                Address = workerModel.Address,
                City = workerModel.City,
                PostalCode = workerModel.PostCode,
                PhoneNumber = workerModel.PhoneNumber,
                BossName = bossModel.Name,
                BossSurname = bossModel.Surname,
                JobName = _workerService.GetJobName(workerModel.JobId),
                GarageName = _garageService.GetGarageName(workerModel.GarageId)
            };

            var workerEmplomentDetailsListingResult = new WorkerEmploymentViewModel()
            {
                Salary = employmentModel.Salary,
                Bonus = employmentModel.Bonus,
                DateFrom = employmentModel.DateFrom,
                DateTo = employmentModel.DateTo,
                TypeOfEmploymentName = _workerService.GetTypeOfEmploymentName(_workerService.GetTypeOfEmploymentId(workerModel.Id))
            };

            var model = new WorkerDetailsMainViewModel()
            {
                workerDetailsViewModel = workerDetailsListingResult,
                workerEmploymentViewModel = workerEmplomentDetailsListingResult
            };

            return View(model);
        }

        public async Task<IActionResult> WorkerEmploymentDetails(int workerId)
        {
            var employmentModel = await _workerService.GetWorkerEmployment(workerId);

            var listingResult = new WorkerEmploymentViewModel()
            {
                Salary = employmentModel.Salary,
                Bonus = employmentModel.Bonus,
                DateFrom = employmentModel.DateFrom,
                DateTo = employmentModel.DateTo,
                TypeOfEmploymentName = _workerService.GetTypeOfEmploymentName(employmentModel.Id)
            };

            return View(nameof(WorkerDetails), listingResult);
        }

        [HttpGet]
        public IActionResult AddWorkerTraining(int workerId)
        {
            ViewData["workerId"] = workerId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkerTraining(EmployeeTraining employeeTraining)
        {
            await _workerService.AddWorkerTraining(employeeTraining);

            return View(nameof(Index));
        }

    }
}