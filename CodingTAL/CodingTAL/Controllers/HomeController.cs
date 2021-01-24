using System;
using System.Collections.Generic;
using CodingTAL.Services;
using CodingTAL.ViewModel;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using CodingTAL.Models;

namespace CodingTAL.Controllers
{
    public class HomeController : Controller
    {
        readonly IOccupationService _occupation;
        readonly IPremiumCalculationService _calService;

        public HomeController(IOccupationService occupationService, IPremiumCalculationService calService)
        {
            this._occupation = occupationService;
            this._calService = calService;  
        }
        public ActionResult Index()
        {

           
            HomeViewModel model = new HomeViewModel();
            model.Occupations = _occupation.GetOccupation().Select(x =>
                                  new SelectListItem()
                                  {
                                       Text = x.OccupationName.ToString(),
                                      Value = x.Value.ToString()

                                  }).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {           
            var value = _calService.GetSumInsured(model);
            return View(model);
           
        }


    }
}