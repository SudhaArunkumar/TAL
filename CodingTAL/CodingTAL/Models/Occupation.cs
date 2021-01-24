using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTAL.Models
{
    public class Occupation
    {
        public string Value { get; set; }

        public string OccupationName { get; set; }

        public Occupation(string occupationName, string value)
        {
            OccupationName = occupationName;
            Value = Value;
        }

    }
}