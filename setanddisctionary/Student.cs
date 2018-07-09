using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// really simple Student class
    /// </summary>
    public class Student : IComparable<Student>
    {
        public int id {get; set;}
        public string fname { get; set; }
        public string lname { get; set; }
        public int CompareTo(Student other)
        {

            int compare = this.lname.CompareTo(other.lname);
            if (compare == 0)
            {
                compare = this.fname.CompareTo(other.fname);
                if (compare ==0)
                    compare = this.id.CompareTo(other.id);
            }
                
            return compare;
        }

        public Student(int n,string f,string l)
        {
            id = n;
            fname = f;
            lname = l;
        }

        public override string ToString()
        {
            string strout = "ID: " + id + " " + fname + " " + lname;
            return strout;
        }

        
    }
}
