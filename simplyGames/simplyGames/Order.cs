using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string Customer { get; set; }
        public string Game { get; set; }
        public string Platform { get; set; }
        public Decimal Price { get; set; }
        public int  StaffMember { get; set; }

        public override string ToString()
        {
            return "Order Number: " + OrderNumber + "\n" +
                  "Customer Name: " + Customer + "\n" +
                           "Game: " + Game + "\n" +
                       "Platform: " + Platform + "\n" +
                    "Total Price: " + Price + "\n" +
                   "Staff Member: " + StaffMember + "\n";
        }
    }
}
