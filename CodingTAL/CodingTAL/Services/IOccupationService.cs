using CodingTAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTAL.Services
{
    public interface IOccupationService
    {
         List<Occupation> GetOccupation();

        Occupation GetOccupation(string name);

    }
}