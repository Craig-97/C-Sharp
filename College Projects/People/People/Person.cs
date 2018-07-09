using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        //instance variables
        Address address;
        string name;
        int yearOfBirth;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
               name = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
        }

        public override string ToString()
        {
            string strout;
            strout = name + " " + yearOfBirth + "\n" + address.Street + "\n" + address.Town + "\n" + address.Postcode;
            return strout;
        }

        public void setAddress(string strst, string strtwn, string
      strpc)
        {
            address.Street = strst;
            address.Town = strtwn;
            address.Postcode = strpc;
        }

        public Person()
        {
            address = new Address();
            setAddress("unkown", "unknown", "unknown");
            YearOfBirth = 0;
            Name = "no name";
        }

        public Person(String strn)
        {
            address = new Address();
            setAddress("unkown", "unknown", "unknown");
            YearOfBirth = 0;
            Name = strn;
              
        }

        public Person(String strn, int yr)
        {
            address = new Address();
            setAddress("unkown", "unknown", "unknown");
            YearOfBirth = yr;
            Name = strn;
             
        }

        public Person(String strn, string strst, string strtwn, string
        strpc, int yr)
        {
            address = new Address();
            setAddress(strst, strtwn, strpc);
            YearOfBirth = yr;
            Name = strn;
  
        }


    }
}
