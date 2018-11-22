using System;
using System.Collections.Generic;
using System.Text;
using CarRent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Exemption> Exemptions { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<TypeOfEmployment> TypesOfEmployment { get; set; }
        public DbSet<EmployeeTraining> EmployeeTrainings { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Brand> Brandes { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCar> CustomerCars { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<ReplacementCar> ReplacementCars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TypeOfPayment> TypesOfPayment { get; set; }
        public DbSet<TypeOfService> TypesOfService { get; set; }

    }
}
