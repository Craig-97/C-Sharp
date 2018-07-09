using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    [Serializable]
    public class CustomerDatabase
    {
        /// <summary>
        /// singleton design pattern
        /// static instance of class CustomerDatabase
        /// </summary>
        private static CustomerDatabase instance;

        /// <summary>
        /// property to return singleton instance
        /// </summary>
        public static CustomerDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDatabase();
                }
                return instance;
            }

        }

        /// <summary>
        /// creates a list to store people
        /// </summary>
        private List<Person> persons;

        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

       /// <summary>
       /// Create a new, empty person database.
       /// </summary>
        public CustomerDatabase()
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
       /// get a string representation of
       /// every staff member in the list
       /// </summary>
       /// <returns>list of all staff</returns>
        public String getStaff()
        {
            string strout = "";
            foreach (Person p in persons)
            {
                if (p.GetType() == typeof(Staff))
                    strout = strout + p.Name + "\n";
            }
            return strout;
        }
 
        /// <summary>
        /// get a string representation of 
        /// every customer in the list
        /// </summary>
        /// <returns>list of all custoemrs</returns>
        public String getCustomer()
        {
            string strout = "";
            foreach (Person p in persons)
            {
                if (p.GetType() == typeof(Customer))
                    strout = strout + p.Name + "\n";
            }
            return strout;
        }



        /// <summary>
        /// creates new staff and customer objects
        /// </summary>
        public void populate()
        {
            addPerson(new Staff("pete", 5, "scarba", "Wishaw", "ml27ey", "123456" , "Manager"));
            addPerson(new Customer("mary", 1978, "glasgow road", " glasgow", "ml435h", 1998));
            addPerson(new Staff("Andrew", 10, "main street", "Glasgow", "ml49ty", "1357911", "Sales Assistant"));
            addPerson(new Customer("Kieran", 197, "wall street", "Wishaw", "ml20tf", 1995));
            addPerson(new Staff("Lisa", 45, "argyle", "Wishaw", "ml27ey", "975421", "Sales Assistant"));
            addPerson(new Customer("bill", 13, "young street", " Wishaw", "ml2 0fg", 1989));
        }
    }
}
