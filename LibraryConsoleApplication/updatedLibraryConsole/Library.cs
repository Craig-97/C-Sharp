using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace SimpleLibrary
{
    [Serializable]
    public class Library
    {
        /// <summary>
        /// Singleton object
        /// </summary>
        private static Library library;
        /// <summary>
        /// Instance property returns the singleton instance
        /// </summary>
        public static Library Instance
        {
            get
            {
                if (library == null)
                    library = new Library();
                return library;
            }
        }

        //public Members
        //{
        //get {}
        //}

        /// <summary>
        /// Instance variables
        /// </summary>
        private List<Member> members;
        
        public Library()
        {
            members = new List<Member>();
            
        }

        public void addMember(string nm, int yr, string St, string Twn, string strpc)
        {
            int id = members.Count + 1;
            Member m = new Member(nm, St, Twn, strpc, yr, id);
            members.Add(m);
        }

        public string getMembers()
        {
            string strout = "";
            foreach (Member m in members)
            {
                strout = strout + m.ToString() + "\n";
            }
            return strout;
                            
        }
    }

}

       
       
    

