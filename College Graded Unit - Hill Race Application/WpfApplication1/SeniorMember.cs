using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HillRaceSystem
{
    [Serializable]
    public class SeniorMember : Member
      {
       
        /// create a default JuniorMember object
        /// </summary>
        public SeniorMember()
            : base("(unknown shrnumber)","(unknown name)","(unknown gender)","(unknown address)","(unknown postcode)","(unknown yearofbirth)","(unknown phonenumber)","(unknown email)","(unknown doctor)","(unknown doctortel)")
        {
        }

   /// <summary>
   /// Creates a senior member with a shrnumber, name, gender and
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
        public SeniorMember(String shrnumber, String name, String gender, String address, String postcode, String yearofbirth, String phonenumber, String email, String doctor, String doctortel)
            : base(shrnumber, name, gender, address, postcode, yearofbirth, phonenumber,email,doctor,doctortel)
        {
        }
       
        /// <summary>
        /// Return a string representation of this object.
        /// </summary>
        /// <returns>string representation of a SeniorMember</returns>
        public override string ToString()
        {
            return base.ToString();
                   
        }

    }
}

