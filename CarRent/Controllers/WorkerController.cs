using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Data.Services.Interfaces;
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


    }
}