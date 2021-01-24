using System;
using System.Collections.Generic;
using CodingTAL.Models;
using CodingTAL.Services;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CodingTAL.ViewModel
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age Required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Date of Birth Required")]
        public DateTime DOB { get; set; }
        public List<SelectListItem> Occupations { get; set; }
        public string OccupationName { get; set; }
        public string OccupationValue { get; set; }
        [Required(ErrorMessage = "Sum Insured Required")]
        public int SumInsured { get; set; }

     }
}