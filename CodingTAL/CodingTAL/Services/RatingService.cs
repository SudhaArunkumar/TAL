using System;
using System.Collections.Generic;
using CodingTAL.Repositories;
using CodingTAL.Models;
using System.Linq;
using System.Web;

namespace CodingTAL.Services
{
    public class RatingService: IRatingService
    {
        public List<Rating> GetRating()
        {
            return RatingRepository.Ratings;
        }

        public Rating GetRating(string name)
        {
            return RatingRepository.Ratings.FirstOrDefault(rating => rating.RatingValue == name);
        }
    }
}