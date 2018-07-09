using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using People;

namespace SimpleLibrary
{
    /// <summary>
    /// Member encapsulates library members
    /// 
    /// extends People.Person class
    /// </summary>
    
    [Serializable]
    public class Member : Person
    {
        private int ID;

        public Member()
            : base()
        {
            ID = 0;
        }

        public Member(String strn, string strst, string strtwn, string strpc, int yr, int mid): base (strn, strst, strtwn, strpc, yr)
        {
            Member mem = new Member();
            string Name = strn;
            string Address = strst + "\n" + strtwn + "\n" + strpc;
            int Year = yr;
            ID = mid;
        }

        //operations 
        public override string ToString()
        {
            string strout;
            strout = ID + " " + Name;
            return strout;
        }
    }



}
