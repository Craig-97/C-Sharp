using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileExtensionsStarter
{
    //remember to make class support persistence!!!
    [Serializable]
    public class DefaultProgDatabase
    {

        //TO DO
        //ADD AN ATTRIBUTE TO STORE THE 
        //file extension entries as a key value pair
        //should use an appropriate generic standard collection class
        private static DefaultProgDatabase instance;

        public static DefaultProgDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DefaultProgDatabase();
                }
                return instance;
            }

        }

       private Dictionary<String, String> FileExtension = new Dictionary<String, String>();
       
        /// <summary>
        /// Default constructor
        /// should perform any  intialisation
        /// </summary>
        public DefaultProgDatabase()
        {
            //TO DO 
           FileExtension = new Dictionary<String, String>();
             
        }

        /// <summary>
        /// returns default program corresponding to extension
        /// 
        /// throws exception if not found
        /// </summary>
        /// <param name="extension">extension to find default program</param>
        /// <returns>default program</returns>
        public string findDefaultProgram(string extension)
        {
            string value="";
            //TO DO SHOULD RETURN STRING REPRESENTING
            //DEFAULT PROGRAM FOR EXTENSION
            //or throw exception if not found
            return value;
        }

        /// <summary>
        /// SHOULD DELETE ENTRY CORRESPONDING TO ENTRY
        /// </summary>
        /// <param name="extesnsion">key of entry to delete</param>
        /// <returns>true if deleted or false</returns>
        public bool deleteEntry(string extesnsion)
        {
            
            //TO DO SHOULD DELETE ENTRY CORRESPONDING TO ENTRY
            return false;
        }

        /// <summary>
        /// Should clear all entries
        /// </summary>
        public void clearAll()
        {
            //TO DO
        }

        /// <summary>
        /// SHOULD ADD NEW ENTRY WITH 
        /// KEY AS EXTENSION AND PROGRAM AS VALUE
        /// 
        /// RETURN TRUE IF SUCCESSFUL
        /// RETURN FALSE IF ALREADY ENTRY FOR KEY
        /// </summary>
        /// <param name="extension">extension</param>
        /// <param name="program">defaulty program</param>
        /// <returns></returns>
        public bool addEntry(string extension, string program)
        {
            try
            {
                FileExtension.Add(extension,program);
                return true;
            }
            catch
            {
                return false;
            }         
        }

        /// <summary>
        /// SHOULD return a string list of all the entries
        /// each entry should be on one line
        /// in format shown in test document
        /// </summary>
        /// <returns></returns>
        public string getAll()
        {
            string strout = "";
            //TO DO
            foreach (extension p in FileExtension)
            {
                if (p.GetType() == typeof(Staff))
                    strout = strout + p.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// SHOULD POPULATE WITH SOME ENTRIES
        /// FOR TESTING
        /// </summary>
        public void populate()
        {
            //TO DO
        }
    }
}
