using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace CourseworkBankMessageService
{
    public class MessagingDatabase
    {
        private static MessagingDatabase instance;

        /// <summary>
        /// property to return singleton instance
        /// </summary>
        public static MessagingDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessagingDatabase();
                }
                return instance;
            }
        }

        /// <summary>
        /// private lists
        /// </summary>
        private List<TextAbbrevs> abbreviations;

        private List<String> urls;

        private List<String> hashtags;

        private List<String> mentions;

        private List<Message> messages;

        /// <summary>
        /// public lists
        /// </summary>
        public List<TextAbbrevs> Abbreviations
        {
            get { return abbreviations; }
        }

        public List<String> URLs
        {
            get { return urls; }
        }

        public List<String> Hashtags
        {
            get { return hashtags; }
        }

        public List<String> Mentions
        {
            get { return mentions; }
        }

        public List<Message> Messages
        {
            get { return messages; }
        }

        /// <summary>
        /// Creates a new, empty message database.
        /// </summary>
        public MessagingDatabase()
        {
            messages = new List<Message>();
            abbreviations = new List<TextAbbrevs>();
            urls = new List<String>();
            hashtags = new List<String>();
            mentions = new List<String>();

        }

        /// <summary>
        /// adds a new abbreviation to the 
        /// abbrevation list
        /// </summary>
        /// <param name="Abbreviation"></param>
        /// <param name="LongName"></param>
        public void addAbbrevs(String Abbreviation, String LongName)
        {
            TextAbbrevs abrev = new TextAbbrevs(Abbreviation, LongName);
            abbreviations.Add(abrev);
        }

        /// <summary>
        /// adds new tweets to 
        /// the message list
        /// </summary>
        /// <param name="MessageID"></param>
        /// <param name="Sender"></param>
        /// <param name="MessageText"></param>
        public void addTweet(String MessageHeading, String MessageBody)
        {
            Tweet t = new Tweet(MessageHeading, MessageBody);
            messages.Add(t);
        }

        /// <summary>
        /// adds new sms messages 
        /// the the message list
        /// </summary>
        /// <param name="MessageID"></param>
        /// <param name="Sender"></param>
        /// <param name="MessageText"></param>
        public void addSMS(String MessageHeading, String MessageBody)
        {
            SMS s = new SMS(MessageHeading, MessageBody);
            messages.Add(s);
        }


        /// <summary>
        /// adds a new standard email
        /// to the messages list
        /// </summary>
        /// <param name="MessageHeading"></param>
        /// <param name="MessageBody"></param>
        public void addStandardEmail(String MessageHeading, String MessageBody)
        {
            StandardEmail e = new StandardEmail(MessageHeading, MessageBody);
            messages.Add(e);
        }

        /// <summary>
        /// adds a new incident report
        /// to the messages list
        /// </summary>
        /// <param name="MessageHeader"></param>
        /// <param name="MessageBody"></param>
        public void addIncidentReport(String MessageHeading, String MessageBody)
        {
            IncidentReport r = new IncidentReport(MessageHeading, MessageBody);
            messages.Add(r);
        }

        /// <summary>
        /// adds a url to the quarantined list
        /// </summary>
        /// <param name="url"></param>
        public void addQuarantineURL(string url)
        {
            URLs.Add(url);
        }

        /// <summary>
        /// adds a hashtag to the hashtag list
        /// </summary>
        /// <param name="url"></param>
        public void addHashtags(string tag)
        {
            Hashtags.Add(tag);
        }
        /// <summary>
        /// adds a mention to the mentions list
        /// </summary>
        /// <param name="mention"></param>
        public void addMentions(string mention)
        {
            Mentions.Add(mention);
        }

        /// <summary>
        /// gets every message in the messages list
        /// and returns them as a string
        /// </summary>
        /// <returns>strout</returns>
        public string getAllMessages()
        {
            string strout = "";
            foreach (Message m in messages)
            {
                strout = strout + m.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// returns all Quarantined URLs
        /// from the message list
        /// </summary>
        /// <returns>strout</returns>
        public string getQuarantinedURLs()
        {
            string strout = "";
            foreach (var u in URLs)
            {
                strout = strout + u.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// returns all hashtags 
        /// from the hashtag list 
        /// as well as the number of times
        /// they appear in the list
        /// </summary>
        /// <returns>strout</returns>
        public string getAllHashtags()
        {
            string strout = "";
            var q = Hashtags.GroupBy(x => x)
            .Select(g => new {Value = g.Key, Count = g.Count()})
            .OrderByDescending(x => x.Count);
            foreach (var h in q)
            {
                strout = strout + ("Hashtag: " + h.Value + " Mentions: " + h.Count + "\n");
            }
            return strout;
        }

        /// <summary>
        /// returns all mentions 
        /// from the mentions list 
        /// as well as the number of times
        /// they appear in the list
        /// </summary>
        /// <returns>strout</returns>
        public string getAllMentions()
        {
            string strout = "";
            var q = Mentions.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);
            foreach (var m in q)
            {
                strout = strout + ("Mentions: " + m.Value + " Times mentioned: " + m.Count + "\n");
            }
            return strout;
        }
        /// <summary>
        /// returns all sms messages 
        /// in the message list
        /// </summary>
        /// <returns>strout</returns>
        public string getAllSMSmessages()
        {
            string strout = "";
            foreach (Message m in messages)
            {
                if (m.GetType() == typeof(SMS))
                    strout = strout + m.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// returns all tweets in
        /// the message list
        /// </summary>
        /// <returns>strout</returns>
        public string getAllTweets()
        {
            string strout = "";
            foreach (Message m in messages)
            {
                if (m.GetType() == typeof(Tweet))
                    strout = strout + m.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// returns all standard emails
        /// </summary>
        /// <returns>strout</returns>
        public string getStandardEmails()
        {
            string strout = "";
            foreach (Message m in messages)
            {
                if (m.GetType() == typeof(StandardEmail))
                    strout = strout + m.ToString() + "\n";
            }
            return strout;
        }

        /// <summary>
        /// returns all incident reports
        /// </summary>
        /// <returns>strout</returns>
        public string getIncidentReports()
        {
            string strout = "";
            foreach (Message m in messages)
            {
                if (m.GetType() == typeof(IncidentReport))
                    strout = strout + m.ToString() + "\n";
            }
            return strout;
        }


        /// <summary>
        /// reads the textwords.csv file and 
        /// then adds each entry into the 
        /// abbreviations list 
        /// </summary>
        public void fillAbbreviations()
        {
            using (var reader = new StreamReader("E:/University/Year 3/Software Engineering/Coursework/CourseworkBankMessageService/CourseworkBankMessageService/textwords.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var breaks = reader.ReadLine().Split(',');
                    string shortName = breaks[0];
                    string longName = breaks[1];
                    addAbbrevs(shortName, longName);
                }
            }
        }

        /// <summary>
        /// displays abbreviations for testing purposes
        /// </summary>
        /// <returns></returns>
        public string displayAbbrevs()
        {
            string strout = "";
            foreach (TextAbbrevs t in abbreviations)
            {
                if (t.GetType() == typeof(TextAbbrevs))
                    strout = strout + t.ToString();
            }
            return strout;
        }

        /// <summary>
        /// coverts the messages list to JSON
        /// and saves it to a JSON file with correct formatting
        /// </summary>
        public void SaveToJSON()
        {
            string json = JsonConvert.SerializeObject(messages, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"E:/University/JSONmessages.json", json);
        }
    }
}
