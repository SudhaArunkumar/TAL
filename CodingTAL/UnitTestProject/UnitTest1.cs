using System;
using CodingTAL.Services;
using CodingTAL.ViewModel;
using CodingTAL.Controllers;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForPremiumCalculation()
        {
            bool valid = false;

            PremiumCalculationService cal = new PremiumCalculationService();
            HomeViewModel model = new HomeViewModel();
            {
                model.Age = 30;
                model.SumInsured = 500000;
                model.OccupationValue = "Professional";

            };
            var  premiumSumInsured = cal.GetSumInsured(model);

            if (premiumSumInsured < 0)
                valid = true;
         

            Assert.IsTrue(valid, "Successfully Calculated");
        }

        public void TestMethodForPremiumCalculationthrowerror()
        {
            bool valid = false;

            PremiumCalculationService cal = new PremiumCalculationService();
            HomeViewModel model = new HomeViewModel();
            {
                model.Age = 30;
                model.SumInsured = 500000;
                model.OccupationValue = "1.0";

            };
            var premiumSumInsured = cal.GetSumInsured(model);

            if (premiumSumInsured < 0)
                valid = true;


            Assert.IsTrue(valid,  "Error");

        }
    }
}
