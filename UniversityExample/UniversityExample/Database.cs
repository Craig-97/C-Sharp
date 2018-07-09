using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExample
{
    [Serializable]
    public class Database
    {
        /// <summary>
        /// singleton design pattern
        /// static instance of class Database
        /// </summary>
        private static Database instance;

        /// <summary>
        /// property to return singleton instance
        /// </summary>
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }

        }
        /// <summary>
        /// use standard List class to store persons
        /// </summary>
        private List<Person> persons;

       /// <summary>
       /// Create a new, empty person database.
       /// </summary>
        public Database()
        {
            persons = new List<Person>();
        }
 
        /// <summary>
        /// Add a person to the database.
        /// </summary>
        /// <param name="p">Person</param>
        public void addPerson(Person p)
        {
            persons.Add(p);
        }


       /// <summary>
       /// return a string of all Persons in Database
       /// </summary>
       /// <returns>string list of persons</returns>
        public string getAll() 
        {
            string strout ="";
            foreach (Person p in persons)
            {
                strout = strout + p.ToString() + "\n";
            }
            return strout;
            
        } 
        
       /// <summary>
       /// get a string representation of all staff
       /// </summary>
       /// <returns>list of all staff</returns>
        public String getStaff()
        {
            string strout = "";
            foreach (Person p in persons)
            {
                if (p.GetType() == typeof(Staff))
                    strout = strout + p.ToString() + "\n";
            }
            return strout;
        }

 
        /// <summary>
        /// get a string representation of all students
        /// </summary>
        /// <returns>list of all students</returns>
        public String getStudents()
        {
            string strout = "";
            foreach (Person p in persons)
            {
                if (p.GetType() == typeof(Student))
                    strout = strout + p.ToString() + "\n";
            }
            return strout;
        }



        /// <summary>
        /// for testing purposes
        /// </summary>
        public void populate()
        {
            addPerson(new Staff("peter", 1978, "C123"));
            addPerson(new Student("freda", 1978, "mc1123"));
            addPerson(new Staff("fred", 1977, "C124"));
            addPerson(new Student("geraldine", 1978, "mc1323"));
            addPerson(new Staff("anne", 1968, "C125"));
            addPerson(new Student("mary", 1978, "mc1143"));
        }
    }
}
