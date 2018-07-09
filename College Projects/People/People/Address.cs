using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Address
    {
        //instance variables
        string street;
        string town;
        string postcode;

        /****************************
       * Public Properties
       * **************************/
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string Town
        {
            get
            {
                return town;
            }
            set
            {
                town = value;
            }

        }
        public string Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }

        public override string ToString()
        {
            string strout;
            strout = Street + "\n" + Town + "\n" + Postcode + "\n";
            return strout;
        }


    }

}
