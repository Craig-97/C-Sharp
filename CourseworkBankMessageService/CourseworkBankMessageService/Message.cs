using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkBankMessageService
{
    public class Message
    {
        /// <summary>
        /// private variables
        /// </summary>
        private String messageHeading;
        private String messageBody;

        /// <summary>
        /// constuctor for message
        /// </summary>
        /// <param name="MessageHeading"></param>
        /// <param name="MessageBody"></param>
        public Message(String MessageHeading, String MessageBody)
        {
            messageHeading = MessageHeading;
            messageBody = MessageBody;
        }

        /// <summary>
        /// get and set for messageHeader
        /// </summary>
        public string MessageHeading
        {
            get { return messageHeading; }
            set { messageHeading = value; }
        }

        /// <summary>
        /// get and set for messageBody
        /// </summary>
        public string MessageBody
        {
            get { return messageBody; }
            set { messageBody = value; }
        }

        /// <summary>
        /// overide string method that returns the message 
        /// heading and body in a string format
        /// </summary>
        /// <returns>message body and heading as string</returns>
        public override string ToString()
        {
            return MessageHeading + "\n"
                + MessageBody + "\n";
        }
    }
}
