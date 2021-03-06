﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class EmployeeTraining
    {
        public int Id { get; set; }
        [Display(Name = "Numer pracownika")]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        [Display(Name = "Szkolenie")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [Display(Name = "Data rozpoczęcia szkolenia")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Data zakończenia szkolenia")]
        public DateTime DateTo { get; set; }

    }
}
