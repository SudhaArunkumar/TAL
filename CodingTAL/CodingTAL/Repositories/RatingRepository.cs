using System;
using System.Collections.Generic;
using CodingTAL.Models;
using System.Linq;
using System.Web;

namespace CodingTAL.Repositories
{
    public static class RatingRepository
    {

        public static List<Rating> Ratings = new List<Rating>() {
                new Rating("Professional", 1.0),
                new Rating("White Collar", 1.25),
                new Rating("Light Manual", 1.50),
                new Rating("Heavy Manual", 1.75)
            };
    }
}