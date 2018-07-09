using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillRaceSystem
{
    public class Races
    {
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public string RaceLocation { get; set; }
        public string RaceDistance { get; set; }
        public string RaceDate { get; set; }
        public string JuniorMaleTime { get; set; }
        public string JuniorFemaleTime { get; set; }
        public string SeniorMaleTime { get; set; }
        public string SeniorFemaleTime { get; set; }
       
        public override string ToString()
        {
            return RaceName;
        }
    }
}
