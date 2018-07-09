using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    [Serializable]
    public class Customer: Person
    {
          /// <summary>
        /// the year that the customer was born
        /// </summary>
        private int yearofbirth;

        /// <summary>
        /// creates a default Customer object
        /// </summary>
        public Customer()
            : base("(unknown name)", 0000, "(unknown street)", "(unknown town)", "(unknown postcode)")
        {
            yearofbirth= 0000;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Customers Name</param>
        /// <param name="housenumber"></param>
        /// <param name="street"></param>
        /// <param name="town"></param>
        /// <param name="postcode"></param>
        /// <param name="year"></param>
        public Customer(String name, int housenumber, String street, String town, String postcode, int year)
            : base(name, housenumber, street, town, postcode)
        {
            yearofbirth = year;
        }

        /// <summary>
        /// get set property for year of birth
        /// </summary>
        public int YearOfBirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }

        /// <summary>
        /// Return a string representation of this object.
        /// </summary>
        /// <returns>string representation of a Customer</returns>
        public override string ToString()
        {
            return base.ToString();// +
            //       "Year of Birth: " + yearofbirth + "\n";
        }
    }
}
