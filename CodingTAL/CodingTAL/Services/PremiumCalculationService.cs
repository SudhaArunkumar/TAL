using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodingTAL.ViewModel;

namespace CodingTAL.Services
{
    public class PremiumCalculationService : IPremiumCalculationService
    {
       
        public double GetSumInsured(HomeViewModel model)
        {
            try
            {
                RatingService rating = new RatingService();

                var ratingFactor = rating.GetRating(model.OccupationName);

                var deathPremium = (model.SumInsured * ratingFactor.RatingFactor * model.Age) / 1000 * 12;

                return deathPremium;


            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}