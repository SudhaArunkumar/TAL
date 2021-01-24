using System;
using System.Collections.Generic;
using CodingTAL.Models;
using System.Linq;
using System.Web;

namespace CodingTAL.Repositories
{
    public static class OccupationRepository
    {

        public static List<Occupation> Occupations = new List<Occupation>() {
                new Occupation("Cleaner", "Light Manual"),
                new Occupation("Doctor", "Professional"),
                new Occupation("Author", "White Collar"),
                new Occupation("Farmer", "Heavy Manual"),
                new Occupation("Mechanic", "Heavy Manual"),
                new Occupation("Florist", "Light Manual")
              
            };
    }
}