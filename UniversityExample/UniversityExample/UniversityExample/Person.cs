using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExample
{
    /// <summary>
    /// very basic Person class adapted from 
    /// Michael Kolling's demo BlueJ project
    /// </summary>
    [Serializable]
    public abstract class Person
    {
        /// <summary>
        /// name of person
        /// </summary>
        private String name;
        /// <summary>
        /// year of birth
        /// </summary>
        private int yearOfBirth;


       
        /// <summary>
        /// Constructor
        /// create a new Person with name and yearof birth
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="yearOfBirth">year of birth</param>
        public Person(String name, int yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }

        /// <summary>
        /// set and get name
        /// </summary>
        public string Name
        {
            get {return name;}
            set { name = value;}
        }

        /// <summary>
        /// get and set year of birth
        /// </summary>
        public int YOB
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }



        /// <summary>
        /// overriden to string
        /// </summary>
        /// <returns>string representation of a Person</returns>
        public override string ToString()
        {
            return "Name: " + name + "\n" +
                   "Year of birth: " + yearOfBirth + "\n";
        }
    }
}
