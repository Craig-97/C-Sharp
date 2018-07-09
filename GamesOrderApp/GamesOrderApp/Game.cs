using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOrderApp
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int AgeRating { get; set; }

        public override string ToString()
        {
            return Name;// +" " + Genre + " " + Description + " " + Price + " " + AgeRating;
        }
    }
}
