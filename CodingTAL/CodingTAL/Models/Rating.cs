using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTAL.Models
{
    public class Rating
    {
        public string RatingValue { get; set; }

        public double RatingFactor { get; set; }

        public Rating (string ratingValue, double ratingFactor)
        {
            RatingValue = ratingValue;
            RatingFactor = ratingFactor;
        }
    }
}