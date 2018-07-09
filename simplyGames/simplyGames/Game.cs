using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    public class Game
    {
        public int GameID{ get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public Decimal Price { get; set; }
        public int AgeClassification { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
