using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOrderApp
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public int Age{ get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;// +" " + Street + " " + Town + " " + Postcode;
        }
    }
}
