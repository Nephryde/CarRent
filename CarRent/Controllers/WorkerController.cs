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
            IEnumerable<TypeOfEmployment> employmentTypeEnum;

            garageEnum = await _garageService.GetAllGarages();
            List<Garage> garageList = garageEnum.ToList();
            ViewBag.ListOfGarages = garageList;

            jobEnum = await _workerService.GetAllJobs();
            List<Job> jobList = jobEnum.ToList();
            ViewBag.ListOfJobs = jobList;

            workerEnum = await _workerService.GetOnlyBosses();
            List<Worker> workerList = workerEnum.ToList();
            List<Boss> bossList = new List<Boss>();

            employmentTypeEnum = await _workerService.GetAllTypesEmployment();
            List<TypeOfEmployment> employmentList = employmentTypeEnum.ToList();
            ViewBag.ListOfEmployments = employmentList;

            foreach (var item in workerList)
                bossList.Add(new Boss { Id = item.Id, FullName = item.Name + " " + item.Surname });

            ViewBag.ListOfBosses = bossList;         

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorker(AddingNewWorkerViewModel addingNewWorkerViewModel)
        {
            var worker = new Worker
            {
                Name = addingNewWorkerViewModel.Name,
                Surname = addingNewWorkerViewModel.Surname,
                PhoneNumber = addingNewWorkerViewModel.PhoneNumber,
                City = addingNewWorkerViewModel.City,
                Address = addingNewWorkerViewModel.Address,
                PostCode = addingNewWorkerViewModel.PostCode,
                BossId = addingNewWorkerViewModel.BossId,
                JobId = addingNewWorkerViewModel.JobId,
                GarageId = addingNewWorkerViewModel.GarageId
            };

            var employment = new Employment
            {               
                Salary = addingNewWorkerViewModel.Salary,
                Bonus = addingNewWorkerViewModel.Bonus,
                DateFrom = addingNewWorkerViewModel.DateFrom,
                DateTo = addingNewWorkerViewModel.DateTo,
                TypeOfEmploymentId = addingNewWorkerViewModel.TypeOfEmploymentId
            };

            await _workerService.AddWorker(worker);
            employment.WorkerId = worker.Id;
            await _workerService.AddEmployment(employment);
            ViewBag.WorkerId = worker;

            return RedirectToAction("Index", "Worker");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteWorker(int workerId)
        {
            await _workerService.DeleteWorkerById(workerId);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditWorker(int workerId)
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

            var worker = await _workerService.GetWorkerById(workerId);

            return View(worker);
        }

        [HttpPost]
        public async Task<IActionResult> EditWorker(Worker worker)
        {
            await _workerService.EditWorker(worker);

            return RedirectToAction("Index");
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
        public async Task<IActionResult> AddWorkerTraining(int workerId)
        {
            IEnumerable<Course> courseEnum;

            courseEnum = await _workerService.GetAllCourses();
            List<Course> courseList = courseEnum.ToList();
            ViewBag.ListOfCourses = courseList;

            ViewData["workerId"] = workerId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkerTraining(EmployeeTraining employeeTraining)
        {
            await _workerService.AddWorkerTraining(employeeTraining);

            return View(nameof(Index));
        }

        public async Task<IActionResult> WorkerTrainingHistory(int workerId)
        {
            var employeeTrainingModel = await _workerService.GetWorkerAllTrainings(workerId);

            var employeeTrainingHistoryResult = employeeTrainingModel
                .Select(result => new WorkerTrainingHistoryViewModel
                {
                    DateFrom = result.DateFrom,
                    DateTo = result.DateTo,
                    Cost = _workerService.GetTrainingCourseCost(result.CourseId),
                    TrainingName =_workerService.GetTrainingCourseName(result.CourseId),
                    NumberOfHours = _workerService.GetTrainingCourseHours(result.CourseId)
                });

            return View(employeeTrainingHistoryResult);
        }

        [HttpGet]
        public IActionResult AddWorkerExemption(int workerId)
        {
            ViewData["workerId"] = workerId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkerExemption(Exemption exemption)
        {
            await _workerService.AddWorkerExemption(exemption);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddWorkerVacation(int workerId)
        {
            ViewData["workerId"] = workerId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkerVacation(Vacation vacation)
        {
            await _workerService.AddWorkerVacation(vacation);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> WorkerPausesHistory(int workerId)
        {
            var employeeExemptionsModel = await _workerService.GetWorkerAllExemptions(workerId);
            var employeeVacationsModel = await _workerService.GetWorkerAllVacations(workerId);

            var employeeExemptionsListingResult = employeeExemptionsModel
                .Select(result => new WorkerExemptionsViewModel
                {
                    ExemptionReason = result.Reason,
                    ExemptionDateFrom = result.DateFrom,
                    ExemptionDateTo = result.DateTo
                });

            var employeeVacationsListingResult = employeeVacationsModel
                .Select(result => new WorkerVacationsViewModel
                {
                    VacationDateFrom = result.DateFrom,
                    VacationDateTo = result.DateTo,
                    TotalDays = (result.DateTo - result.DateFrom).TotalDays
                });

            var model = new WorkerPausesViewModel()
            {
                workerExemptionsViewModel = employeeExemptionsListingResult,
                workerVacationsViewModel = employeeVacationsListingResult
            };

            return View(model);
        }
    }
}