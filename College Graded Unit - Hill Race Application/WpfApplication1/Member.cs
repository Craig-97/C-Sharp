using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillRaceSystem
{
    [Serializable]
    public abstract class Member
    {
        /// <summary>
        /// shrnumber for the member
        /// </summary>
        public String shrnumber;
        /// <summary>
        /// name of the person
        /// </summary>
        public String name;
        /// <summary>
        /// gender of member
        /// </summary>
        public String gender;
        /// <summary>
        /// address of residence
        /// </summary>
        public String address;
        /// <summary>
        /// area postcode
        /// </summary>
        public String postcode;
        /// <summary>
        /// year of birth
        /// </summary>
        public String yearofbirth;
        /// <summary>
        /// members phone number
        /// </summary>
        public String phonenumber;
        /// <summary>
        /// members email address
        /// </summary>
        public String email;
        /// <summary>
        /// the doctors name
        /// </summary>
        public String doctor;
        /// <summary>
        /// the doctors telephone number
        /// </summary>
        public String doctortel;


        /// <summary>
        /// Constructor creates a new member with their
        /// shr number, name, gender, address and other 
        /// essential information
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
        public Member(String shrnumber, String name, String gender, String address, String postcode, String yearofbirth, String phonenumber, String email, String doctor, String doctortel)
        {
            this.shrnumber = shrnumber;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.postcode = postcode;
            this.yearofbirth = yearofbirth;
            this.phonenumber = phonenumber;
            this.email = email;
            this.doctor = doctor;
            this.doctortel = doctortel;
        }

        /// <summary>
        /// gets and sets SHRNumber
        /// </summary>
        public string SHRNumber
        {
            get { return shrnumber; }
            set { shrnumber = value; }
        }

        /// <summary>
        /// gets and sets name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// gets and sets gender
        /// </summary>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// gets and sets address
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// gets and sets postcode
        /// </summary>
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        /// <summary>
        /// gets and sets yearofbirth
        /// </summary>
        public string YearofBirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }

        /// <summary>
        /// gets and sets phonenumber
        /// </summary>
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        /// <summary>
        /// gets and sets email
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// gets and sets doctor
        /// </summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }

        /// <summary>
        /// gets and sets doctortel
        /// </summary>
        public string DoctorTel
        {
            get { return doctortel; }
            set { doctortel = value; }
        }

        /// <summary>
        /// overriden to string
        /// </summary>
        /// <returns>string representation of a Person</returns>
        public override string ToString()
        {
            return //shrnumber + "\n" +
                   name + "\n";
                   //gender + "\n" +
                   //address + "\n" +
                   //postcode + "\n" +
                   //yearofbirth + "\n" +
                   //phonenumber + "\n" +
                   //email + "\n" +
                   //doctor + "\n" +
                   //doctortel + "\n";
        }
    }
}
