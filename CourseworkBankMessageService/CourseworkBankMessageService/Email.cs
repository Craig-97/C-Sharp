using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkBankMessageService
{
    public class Email : Message
    {
        /// <summary>
        /// public variables
        /// </summary>
        public String subject;

        /// <summary>
        /// constuctor for emails
        /// </summary>
        /// <param name="MessageHeader"></param>
        /// <param name="MessageBody"></param>
        public Email(String MessageHeader, String MessageBody)
            : base(MessageHeader, MessageBody)
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