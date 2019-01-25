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
    public class ServicesController : Controller
    {
        private readonly IServiceService _services;

        public ServicesController(IServiceService services) => 
            _services = services;

        public async Task<IActionResult> ListServices()
        {
            var typeOfServicesModel = await _services.GetAllTypesOfService();

            return View(typeOfServicesModel);
        }

        [HttpGet]
        public async Task<IActionResult> AddService()
        {
            IEnumerable<TypeOfPayment> typeOfPaymentEnum;
            IEnumerable<Brand> brandsEnum;
            IEnumerable<TypeOfService> typesOfServiceEnum;
            IEnumerable<Worker> workersEnum;

            typeOfPaymentEnum = await _services.GetAllTypesOfPayment();
            List<TypeOfPayment> typeOfPaymentList = typeOfPaymentEnum.ToList();
            ViewBag.ListOfTypesOfPayment = typeOfPaymentList;

            brandsEnum = await _services.GetAllBrands();
            List<Brand> brandsList = brandsEnum.ToList();
            ViewBag.ListOfBrands = brandsList;

            typesOfServiceEnum = await _services.GetAllTypesOfService();
            List<TypeOfService> typeOfServiceList = typesOfServiceEnum.ToList();
            ViewBag.ListOfTypesOfService = typeOfServiceList;

            workersEnum = await _services.GetAllWorkers();
            List<Worker> workerList = workersEnum.ToList();
            ViewBag.ListOfWorkers = workerList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(AddingNewServiceViewModel addingNewServiceViewModel)
        {
            var service = new Service
            {
                WorkerId = addingNewServiceViewModel.WorkerId,
                TypeOfServiceId = addingNewServiceViewModel.TypeOfServiceId
            };

            var customerCar = new CustomerCar
            {
                RegistrationNumber = addingNewServiceViewModel.CustomerCarRegNumber
            };

            var customer = new Customer
            {
                FirstName = addingNewServiceViewModel.CustomerName,
                Surname = addingNewServiceViewModel.CustomerSurname,
                Address = addingNewServiceViewModel.CustomerAddress,
                PhoneNumber = addingNewServiceViewModel.CustomerPhone,
                City = addingNewServiceViewModel.CustomerCity,
                PostCode = addingNewServiceViewModel.CustomerPostalCode
            };

            var carModel = new CarModel
            {
                BrandId = addingNewServiceViewModel.BrandId,
                Name = addingNewServiceViewModel.CarModelName,
                Year = addingNewServiceViewModel.CarModelYear
            };

            var payment = new Payment
            {
                BankAccountNumber = addingNewServiceViewModel.BankAccountNumber,
                Date = addingNewServiceViewModel.PaymentDate,
                TypeOfPaymentId = addingNewServiceViewModel.TypeOfPaymentId
            };

            await _services.AddCustomer(customer);
            await _services.AddCarModel(carModel);
            customerCar.CustomerId = customer.Id;
            customerCar.CarModelId = carModel.Id;
            await _services.AddCustomerCar(customerCar);
            service.CustomerCarId = customerCar.Id;
            await _services.AddService(service);
            payment.ServiceId = service.Id;
            await _services.AddPayment(payment);

            return RedirectToAction("Index", "Manage");
        }

        [HttpGet]
        public async Task<IActionResult> RentCar()
        {
            IEnumerable<Customer> customersEnum;
            IEnumerable<ReplacementCar> replacementCarsEnum;

            customersEnum = await _services.GetCustomers();
            List<Customer> customerList = customersEnum.ToList();
            ViewBag.ListOfCustomers = customerList;

            replacementCarsEnum = await _services.GetAllReplacementCars();
            List<ReplacementCar> replacementCarsList = replacementCarsEnum.ToList();
            ViewBag.ListOfReplacementCars = replacementCarsList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RentCar(Rent rent)
        {
            await _services.AddRent(rent);

            return RedirectToAction("Index", "Manage");
        }
    }
}