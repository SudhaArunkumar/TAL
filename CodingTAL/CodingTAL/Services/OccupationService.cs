using System;
using System.Collections.Generic;
using CodingTAL.Repositories;
using CodingTAL.Models;
using System.Linq;
using System.Web;

namespace CodingTAL.Services
{
    public class OccupationService : IOccupationService
    {

        public List<Occupation> GetOccupation()
        {
            return OccupationRepository.Occupations;
        }

        public  Occupation GetOccupation(string name)
            {
                return OccupationRepository.Occupations.FirstOrDefault(occupation => occupation.OccupationName == name);
            }

    }
}