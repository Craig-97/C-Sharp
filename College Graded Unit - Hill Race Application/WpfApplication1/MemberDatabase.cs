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
    public class MemberDatabase
    {
        /// <summary>
        /// singleton design pattern
        /// static instance of class MemberDatabase
        /// </summary>
        private static MemberDatabase instance;

        /// <summary>
        /// property to return singleton instance
        /// </summary>
        public static MemberDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberDatabase();
                    if (!File.Exists("Members.dat"))
                    {
                        //theMembers.populate();
                    }
                    else
                    {

                        IFormatter nformatter = new BinaryFormatter();
                        Stream nstream = new FileStream("Members.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                        instance = (MemberDatabase)nformatter.Deserialize(nstream);
                        nstream.Close();

                    }
                }
                return instance;
            }

        }

        /// <summary>
        /// creates a list to store people
        /// </summary>
        private List<Member> members;

        public List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }

        /// <summary>
        /// Create a new, empty member database.
        /// </summary>
        public MemberDatabase()
        {
            members = new List<Member>();
        }


        /// <summary>
        /// Add a member to the database.
        /// </summary>
        /// <param name="p">Person</param>
        public void addMember(Member m)
        {
            members.Add(m);
        }

        public void deleteMember(Member m)
        {
            members.Remove(m);
        }

        /// <summary>
        /// return a string of all members in Database
        /// </summary>
        /// <returns>string list of members</returns>
        public string getAll()
        {
            string strout = "";
            foreach (Member m in members)
            {
                strout = strout + m.ToString() + "\n";
            }
            return strout;

        }

        /// <summary>
        /// get a string representation of
        /// every senior member in the list
        /// </summary>
        /// <returns>list of all senior members</returns>
        public String getSeniorMember()
        {
            string strout = "";
            foreach (Member m in members)
            {
                if (m.GetType() == typeof(SeniorMember))
                    strout = strout + m.Name + "\n";
            }
            return strout;
        }


        /// <summary>
        /// get a string representation of 
        /// every junior member in the list
        /// </summary>
        /// <returns>list of all junior members</returns>
        public String getJuniorMember()
        {
            string strout = "";
            foreach (Member m in members)
            {
                if (m.GetType() == typeof(JuniorMember))
                    strout = strout + m.Name + "\n";
            }
            return strout;
        }


        /// <summary>
        /// creates new junior and senior member objects
        /// </summary>
        //public void populate()
        //{
        //    addMember(new JuniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel", "guardian", "relationship"));
        //    addMember(new SeniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel"));
        //    addMember(new JuniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel", "guardian", "relationship"));
        //    addMember(new SeniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel"));
        //    addMember(new JuniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel", "guardian", "relationship"));
        //    addMember(new SeniorMember("shrnumber", "name", "gender", "address", "postcode", "yearofbirth", "phonenumber", "email", "doctor", "doctortel"));
        //}
    }
}

