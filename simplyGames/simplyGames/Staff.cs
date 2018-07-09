using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyGames
{
    [Serializable]
    public class Staff : Person
    {
        /// <summary>
        /// staff ID number
        /// </summary>
        private string staffID;

        /// <summary>
        /// type of job
        /// </summary>
        private string jobType;


        /// <summary>
        /// create a default Staff object
        /// </summary>
        public Staff()
            : base("(unknown name)", 0000, "(unknown street)", "(unknown town)", "(unknown postcode)")
        {

            staffID = "(unknown staffID)";
            jobType = "(unknown jobType)";
        }

        /// <summary>
        /// Create a staff member with given name, year of birth and room number
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="yearOfBirth">year of birth</param>
        /// <param name="roomNumber">room number</param>
        public Staff(String name, int housenumber, String street, String town, String postcode, String ID, String type)
            : base(name, housenumber, street, town, postcode)
        {
            staffID = ID;
            jobType = type;
        }

        /// <summary>
        /// get set property for date joined
        /// </summary>
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        /// <summary>
        /// get set property for job type
        /// </summary>
        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }

        /// <summary>
        /// Return a string representation of this object.
        /// </summary>
        /// <returns>string representation of a Staff</returns>
        public override string ToString()
        {
            return base.ToString() +
                   jobType + "\n" +
                   "Staff Number: " + staffID + "\n";
        }
    }
}
