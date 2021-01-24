using System;
using System.Collections.Generic;
using CodingTAL.Models;
using System.Linq;
using System.Web;

namespace CodingTAL.Services
{
    public interface IRatingService
    {
        List<Rating> GetRating();
        Rating GetRating(string name);
    }
}