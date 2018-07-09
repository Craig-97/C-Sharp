using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillRaceSystem
{
    [Serializable]
    public class JuniorMember : Member
    {
        /// <summary>
        /// junior members guardian
        /// </summary>
        public string guardian;

        /// <summary>
        /// relationship with guardian
        /// </summary>
        public string relationship;


        /// <summary>
        /// create a default JuniorMember object
        /// </summary>
        public JuniorMember()
            : base("(unknown shrnumber)","(unknown name)","(unknown gender)","(unknown address)","(unknown postcode)","(unknown yearofbirth)","(unknown phonenumber)","(unknown email)","(unknown doctor)","(unknown doctortel)")
        {

            guardian = "(unknown Guardian)";
            relationship = "(unknown Relationship)";
        }

   /// <summary>
   /// Creates a junior member with a shrnumber, name, gender and
   /// other essential information needed for the signup form
   /// </summary>
   /// <param name="shrnumber">shrnumber</param>
   /// <param name="name">name</param>
   /// <param name="gender">gender</param>
   /// <param name="address">address</param>
   /// <param name="postcode">postcode</param>
   /// <param name="yearofbirth">yearofbirth</param>
   /// <param name="phonenumber">phonenumber</param>
   /// <param name="email">email</param>
   /// <param name="doctor">doctor</param>
   /// <param name="doctortel">doctortel</param>
   /// <param name="jguardian">jguardian</param>
   /// <param name="jrelationship">jrelationship</param>
        public JuniorMember(String shrnumber, String name, String gender, String address, String postcode, String yearofbirth, String phonenumber, String email, String doctor, String doctortel, String jguardian, String jrelationship)
            : base(shrnumber, name, gender, address, postcode, yearofbirth, phonenumber,email,doctor,doctortel)
        {
            guardian = jguardian;
            relationship = jrelationship;
        }

        /// <summary>
        /// get set property for members guardian
        /// </summary>
        public string Guardian
        {
            get { return guardian; }
            set { guardian = value; }
        }

        /// <summary>
        /// get set property for the relationship of the members guardian
        /// </summary>
        public string Relationship
        {
            get { return relationship; }
            set { relationship = value; }
        }

        /// <summary>
        /// Return a string representation of this object.
        /// </summary>
        /// <returns>string representation of a JuniorMember</returns>
        public override string ToString()
        {
            return base.ToString();
                   
        }

    }
}
