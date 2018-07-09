using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkBankMessageService
{
    public class TextAbbrevs
    {
        /// <summary>
        /// private variables
        /// </summary>
        private String shortName;
        private String longName;

        /// <summary>
        /// constuctor for textAbbrevs
        /// </summary>
        /// <param name="ShortName"></param>
        /// <param name="LongName"></param>
        public TextAbbrevs(String ShortName, String LongName)
        {
            shortName = ShortName;
            longName = LongName;
        }
        /// <summary>
        /// get and set for ShortName
        /// </summary>
        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
        /// <summary>
        /// get and set for LongName
        /// </summary>
        public string LongName
        {
            get { return longName; }
            set { longName = value; }
        }
        /// <summary>
        /// overide string method that returns the message 
        /// "ShortName is short for LongName"  in a string format
        /// </summary>
        /// <returns>ShortName & LongName in a string/returns>
        public override string ToString()
        {
            return ShortName + " " + "is short for " + LongName + "\n";
        }
    }
}