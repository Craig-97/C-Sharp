using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkBankMessageService
{
    public class SMS : Message
    {
        /// <summary>
        /// creates a new sms object
        /// </summary>
        /// <param name="MessageHeading"></param>
        /// <param name="MessageBody"></param>
        public SMS(String MessageHeading, String MessageBody)
            : base(MessageHeading, MessageBody)
        {
        }

        /// <summary>
        /// overide string method that returns the base 
        /// in a string format
        /// </summary>
        /// <returns>base as string</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}