using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Data.Services.Interfaces;
using CarRent.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService _services;

        public ServicesController(IServiceService services) => 
            _services = services;

        public async Task<IActionResult> Index()
        {
            var typeOfServicesModel = await _services.GetAllTypesOfService();

            return View(typeOfServicesModel);
        }
    }
}