using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    [Serializable]
    public abstract partial class Person
    {
        /// <summary>
        /// name of person
        /// </summary>
        private String name;
        /// <summary>
        /// adress house number
        /// </summary>
        private int housenumber;
        /// <summary>
        /// address street
        /// </summary>
        private String street;
        /// <summary>
        /// town of residence
        /// </summary>
        private String town;
        /// <summary>
        /// area postcode
        /// </summary>
        private String postcode;

        /// <summary>
        /// constructor creates a new person
        /// with name, housenumber, street,
        /// town and postcode
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="housenumber">housenumber</param>
        /// <param name="street">street</param>
        /// <param name="town">town</param>
        /// <param name="postcode">postcode</param>
        public Person(String name, int housenumber, String street, String town, String postcode)
        {
            this.name = name;
            this.housenumber = housenumber;
            this.street = street;
            this.town = town;
            this.postcode = postcode;
        }

        /// <summary>
        /// gets and sets name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// gets and sets housenumber
        /// </summary>
        public int HouseNumber
        {
            get { return housenumber; }
            set { housenumber = value; }
        }

        /// <summary>
        /// gets and sets street
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// gets and sets town
        /// </summary>
        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        /// <summary>
        /// gets and sets postcode
        /// </summary>
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        /// <summary>
        /// overriden to string
        /// </summary>
        /// <returns>string representation of a Person</returns>
        public override string ToString()
        {
            return name + "\n";
                   //housenumber + " " + street + "\n" +
                   //town + "\n" +
                   //postcode + "\n";
        }
    }
}
