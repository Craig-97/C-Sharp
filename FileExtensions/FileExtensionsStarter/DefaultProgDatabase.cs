using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileExtensionsProgram
{
   
    [Serializable]
    public class DefaultProgDatabase
    {

        
        /// <summary>
        //Adds an attribute to store the 
        //file extension entries as a key value pair
        //uses an appropriate generic standard collection class
        /// </summary>
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

            String searchKey = extension;
            try
            {
               if (FileExtension.ContainsKey(searchKey))
                return FileExtension[searchKey];
            }
               catch (Exception ex)
            {
                return ex.ToString();
            }
            
            return "Not Found";
        }

        /// <summary>
        /// Deletes the file extension is response to the data entered
        /// </summary>
        /// <param name="extesnsion">key of entry to delete</param>
        /// <returns>true if deleted or false</returns>
        public bool deleteEntry(string extension)
        {
            try
            {
                FileExtension.Remove(extension);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        /// <summary>
        /// Should clear all entries
        /// </summary>
        public void clearAll()
        {
            FileExtension.Clear();
        }

        /// <summary>
        /// Adds new entry with
        /// Key as extension and program as value 
        /// 
        /// Returns true if it is successful
        /// Returns false if already entry for the key
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
        /// returns a string list of all the entries
        /// each entry should be on one line
        /// in format shown in test document
        /// </summary>
        /// <returns></returns>
        public string getAll()
        {
            string strout = "";
            foreach (var pair in FileExtension)
            {
               strout = (strout + "File extension " + pair.Key + " opens with " + pair.Value + "\n");
            }
            return strout;
        }

        /// <summary>
        /// Populates the list with some entries 
        /// for testing purposes
        /// </summary>
        public void populate()
        {
            FileExtension.Add(".txt", "Notepad");
            FileExtension.Add(".html", "Firefox");
            FileExtension.Add(".doc", "Winword");

        }
    }
}
