using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HillRaceSystem
{
    [Serializable]
    public class RunnersDatabase
    {
  /// <summary>
        /// singleton design pattern
        /// static instance of class Database
        /// </summary>
        private static RunnersDatabase instance;

        /// <summary>
        /// property to return singleton instance
        /// </summary>
        public static RunnersDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RunnersDatabase();
                }
                return instance;
            }

        }
        /// <summary>
        /// use standard List class to store runners
        /// </summary>
        private List<Runners> runners;

       /// <summary>
       /// Create a new, empty runner database.
       /// </summary>
        public RunnersDatabase()
        {
            runners = new List<Runners>();
        }

        public List<Runners> Runners
        {
            get { return runners;}
            set{runners = value;}
        }
 
        /// <summary>
        /// Add a runner to the database.
        /// </summary>
        /// <param name="p">Runners</param>
        public void addRunner(Runners p)
        {
            runners.Add(p);
        }

       /// <summary>
       /// return a string of all runners in Database
       /// </summary>
       /// <returns>string list of runners</returns>
        public string getAll() 
        {
            string strout ="";
            foreach (Runners p in runners)
            {
                strout = strout + p.ToString() + "\n";
            }
            return strout;
            
        } 
        
       /// <summary>
       /// get a string representation of all junior runners
       /// </summary>
       /// <returns>list of all junior runners</returns>
        public String getJuniorRunners()
        {
            string strout = "";
            foreach (Runners p in runners)
            {
                if (p.GetType() == typeof(JuniorRunner))
                    strout = strout + p.ToString() + "\n";
            }
            return strout;
        }

 
        /// <summary>
        /// get a string representation of all senior runners
        /// </summary>
        /// <returns>list of all senior runners</returns>
        public String getSeniorRunners()
        {
            string strout = "";
            foreach (Runners p in runners)
            {
                if (p.GetType() == typeof(SeniorRunner))
                    strout = strout + p.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// for testing purposes
        /// </summary>
        //public void populate()
        //{
        //    addRunner(new SeniorRunner("SCO1001", "Ryan Jones", "Male"));
        //    addRunner(new SeniorRunner("SCO1002", "Sam Capenter", "Male"));
        //    addRunner(new SeniorRunner("SCO1003", "Fred Bawden", "Male"));
        //    addRunner(new JuniorRunner("SCO1004", "Evan Rice", "Male"));
        //    addRunner(new JuniorRunner("SCO1005", "Joe Martinez", "Male"));
        //    addRunner(new JuniorRunner("SCO1006", "Scott Davidson", "Male")); ;
        //}
    }
}
