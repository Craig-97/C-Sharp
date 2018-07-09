using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillRaceSystem
{
    [Serializable]
    public abstract class Runners
    {
        private String shrnumber;
        /// <summary>
        /// name of runner
        /// </summary>
        private String name;
        /// <summary>
        /// gender of runner
        /// </summary>
        private String gender;


        /// <summary>
        /// Constructor
        /// create a new Runner with shr number, name and gender
        /// </summary>
        /// <param name="shrnumber">shrnumber</param>
        /// <param name="name">name</param>
        /// <param name="gender">gender</param>
        public Runners(String shrnumber, String name, String gender)
        {
            this.shrnumber = shrnumber;
            this.name = name;
            this.gender = gender;
        }

        /// <summary>
        /// set and get shrnumber
        /// </summary>
        public string SHRNumber
        {
            get { return shrnumber; }
            set { shrnumber = value; }
        }

        /// <summary>
        /// set and get name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// get and set year of birth
        /// </summary>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// overriden to string
        /// </summary>
        /// <returns>string representation of a Person</returns>
        public override string ToString()
        {
            return "SHR Number: " + shrnumber + "\n" +
                   "Name: " + name + "\n" +
                   "Gender: " + gender + "\n";
        }
    }
}
