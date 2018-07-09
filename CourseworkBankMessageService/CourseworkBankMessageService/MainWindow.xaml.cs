using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.RegularExpressions;

namespace CourseworkBankMessageService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MessagingDatabase md;

        public MainWindow()
        {
            InitializeComponent();
            md = MessagingDatabase.Instance;
            md.fillAbbreviations();

            //set initial visibilty of all these to hidden
            txtMsgID.Visibility = System.Windows.Visibility.Hidden;
            txtMsgText.Visibility = System.Windows.Visibility.Hidden;
            lblMsgID.Visibility = System.Windows.Visibility.Hidden;
            lblSubject.Visibility = System.Windows.Visibility.Hidden;
            txtSubject.Visibility = System.Windows.Visibility.Hidden;
            rdStandard.Visibility = System.Windows.Visibility.Hidden;
            rdIncident.Visibility = System.Windows.Visibility.Hidden;
            btnSave.Visibility = System.Windows.Visibility.Hidden;
            lblIncident.Visibility = System.Windows.Visibility.Hidden;
            cmbIncident.Visibility = System.Windows.Visibility.Hidden;
            lblSortCode.Visibility = System.Windows.Visibility.Hidden;
            txtSortCode.Visibility = System.Windows.Visibility.Hidden;
            btnClear.Visibility = System.Windows.Visibility.Hidden;

            //populate cmbIncident with possible incidents
            cmbIncident.Items.Add("Theft");
            cmbIncident.Items.Add("Staff Attack");
            cmbIncident.Items.Add("ATM Theft");
            cmbIncident.Items.Add("Raid");
            cmbIncident.Items.Add("Customer Attack");
            cmbIncident.Items.Add("Staff Abuse");
            cmbIncident.Items.Add("Bomb Threat");
            cmbIncident.Items.Add("Terrorism");
            cmbIncident.Items.Add("Suspicious Incident");
            cmbIncident.Items.Add("Intelligence");
            cmbIncident.Items.Add("Cash Loss");
        }

        private void btnIndentify_Click(object sender, RoutedEventArgs e)
        {
            //declare variables
            String Sender = txtSender.Text;
            String letter;
            String messageID;
            int Value;

            //if the phone number is entered has 9 digits and is completely numeric
            //then the SMS and tweet Window will open
            if (int.TryParse(txtSender.Text, out Value) && Sender.Length == 9)
            {
                txtMsgID.Visibility = System.Windows.Visibility.Visible;
                txtMsgText.Visibility = System.Windows.Visibility.Visible;
                lblMsgID.Visibility = System.Windows.Visibility.Visible;
                btnSave.Visibility = System.Windows.Visibility.Visible;
                letter = "S";
                Random rnd = new Random();
                int Number = rnd.Next(000000000, 999999999);
                messageID = letter + Number;
                MessageBox.Show("SMS Message: " + messageID);
                txtMsgID.Text = messageID;
            }

            //if the name entered contains "." and "@" then
            //the email window will open
            else if (Sender.Contains("@") && Sender.Contains("."))
            {
                txtMsgID.Visibility = System.Windows.Visibility.Visible;
                txtMsgText.Visibility = System.Windows.Visibility.Visible;
                lblMsgID.Visibility = System.Windows.Visibility.Visible;
                lblSubject.Visibility = System.Windows.Visibility.Visible;
                txtSubject.Visibility = System.Windows.Visibility.Visible;
                rdStandard.Visibility = System.Windows.Visibility.Visible;
                rdIncident.Visibility = System.Windows.Visibility.Visible;
                btnSave.Visibility = System.Windows.Visibility.Visible;
                letter = "E";
                Random rnd = new Random();
                int Number = rnd.Next(000000000, 999999999);
                messageID = letter + Number;
                MessageBox.Show("email: " + messageID);
                txtMsgID.Text = messageID;
            }

            //if the name entered starts with "@" then
            //then the sms and tweet window will open
            else if (Sender.StartsWith("@"))
            {
                txtMsgID.Visibility = System.Windows.Visibility.Visible;
                txtMsgText.Visibility = System.Windows.Visibility.Visible;
                lblMsgID.Visibility = System.Windows.Visibility.Visible;
                btnSave.Visibility = System.Windows.Visibility.Visible;
                letter = "T";
                Random rnd = new Random();
                int Number = rnd.Next(000000000, 999999999);
                messageID = letter + Number;
                MessageBox.Show("tweet: " + messageID);
                txtMsgID.Text = messageID;
            }
            //displays error if txtSender is empty
            else if (string.IsNullOrWhiteSpace(txtSender.Text))
            {
                MessageBox.Show("Input not valid");
            }
            // displays error message if input isnt email, twitter id or phone number
            // or it doesnt meet the requirements of those inputs
            else
            {
                MessageBox.Show("Input format not recognised"); 
            }

        }

        private void rdIncident_Checked(object sender, RoutedEventArgs e)
        {
            // set visiblity of incident combo box and label to visible
            // as well as the sort code label and text box
            lblIncident.Visibility = System.Windows.Visibility.Visible;
            cmbIncident.Visibility = System.Windows.Visibility.Visible;
            lblSortCode.Visibility = System.Windows.Visibility.Visible;
            txtSortCode.Visibility = System.Windows.Visibility.Visible;

            // then generate a random sort code number into the sort code text box
            Random rnd = new Random();
            int beg = rnd.Next(00, 99);
            int mid = rnd.Next(00, 99);
            int end = rnd.Next(00, 99);

            // then fill the subject box with SIR and current date and time
            txtSortCode.Text = beg + "-" + mid + "-" + end;
            txtSubject.Text = "SIR " + DateTime.Now;
        }
        // set visbility of incident label and combo box to hidden 
        // and clear the subject text box
        private void rdStandard_Checked(object sender, RoutedEventArgs e)
        {
            lblIncident.Visibility = System.Windows.Visibility.Hidden;
            cmbIncident.Visibility = System.Windows.Visibility.Hidden;
            txtSubject.Clear();
        }

        //when clicked the button will open the showMessages window
        private void btnShowMessages_Click(object sender, RoutedEventArgs e)
        {
            ShowMessages d = new ShowMessages();
            d.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //setting variable names to text boxes
            string Sender = txtSender.Text;
            string MessageID = txtMsgID.Text;
            string MessageText = txtMsgText.Text;
            string MessageBody;
            string Subject = txtSubject.Text;
            string SortCode = txtSortCode.Text;
            string IncidentNature = cmbIncident.Text;

            //declare value variable as integer
            int Value;
            //if the value entered into txtSender is a phone number then
            if (int.TryParse(txtSender.Text, out Value) && Sender.Length == 9)
            {
                //replace any abbreviations with their longname before adding them to the list
                foreach (TextAbbrevs t in md.Abbreviations)
                {
                    MessageText = Regex.Replace(MessageText, t.ShortName, "<" + t.LongName + ">");
                }

                //Create a message body with a sender and the message text and add the
                //message to the SMS list. Display a text box showing the SMS stored
                MessageBody = "Sender: " + Sender + "\n" + MessageText;
                //input validation to make sure the SMS message is no more than 140 characters
                if (MessageText.Length > 140)
                {
                   MessageBox.Show("SMS Messages have a 140 character limit");
                }
                else
                {
                    md.addSMS(MessageID, MessageBody);
                    MessageBox.Show("SMS Stored");

                    md.SaveToJSON();// saves messages list to JSON file

                    //Makes clear input button visible so user can input another message
                    btnClear.Visibility = System.Windows.Visibility.Visible;
                }
                
            }
            // if the value enetered in txtSender starts with an @ symbol then
            else if (Sender.StartsWith("@"))
            {
                //replace any abbreviations with their longname before adding them to the list
                foreach (TextAbbrevs t in md.Abbreviations)
                {
                    MessageText = Regex.Replace(MessageText, t.ShortName, "<" + t.LongName + ">");
                }

                //finds any hashtag in the message and adds them to the hashtag list
                Regex hashtags = new Regex(@"(?<=#)\w+");
                MatchCollection hashtagmatches = hashtags.Matches(MessageText);

                foreach (Match match in hashtagmatches)
                {
                    md.addHashtags(match.Value);
                }
                
                //finds any mentions in the message and adds them to the mentions list
                Regex mentions = new Regex(@"(\A|\s)@(\w+)");
                MatchCollection mentionMatches = mentions.Matches(MessageText);

                foreach (Match match in mentionMatches)
                {
                    md.addMentions(match.Value);
                }

                //Create a message body with a twitter ID and the message text and add the
                //message to the tweet list. Display a text box showing the tweet stored
                MessageBody = "Sender: " + Sender + "\n" + MessageText;
                //input validation to make sure the Tweet messages are no more than 140 characters
                if (MessageText.Length > 140)
                {
                    MessageBox.Show("Tweets Messages have a 140 character limit");
                }
                else
                {
                    md.addTweet(MessageID, MessageBody);
                    MessageBox.Show("Tweet Stored");

                    md.SaveToJSON();// saves messages list to JSON file
               
                    //Makes clear input button visible so user can input another message
                    btnClear.Visibility = System.Windows.Visibility.Visible;
                }
 
            }
            // if the value entered into txtSender is an email address and incident report is checked then
            else if (Sender.Contains(".") && Sender.Contains("@") && (rdIncident.IsChecked == true))
            {
                // check for any website links, if there is a link add it to the quarinted URLs
                Regex urls = new Regex(@"http[^\s]+");
                MatchCollection urlmatches = urls.Matches(MessageText);

                foreach (Match match in urlmatches)
                {
                    md.addQuarantineURL(match.Value);
                }
                // if a URL is found then replace the text with <URL Quarantined> 
                MessageText = Regex.Replace(MessageText, @"http[^\s]+", "<URL Quarantined>");
                // creates a message body with the  sender name, sort code, nature of incident, subject and the text entered in the message.
                MessageBody = "Sender: " + Sender + "\n" + "Sort Code: " + SortCode + "\n" + "Nature of Incident: " + IncidentNature + "\n" + "Subject: " + Subject + "\n" + MessageText;

                //input validation to make sure the Email messages are no more than 1028 characters
                if (MessageText.Length > 1028)
                {
                    MessageBox.Show("Email Messages have a 1028 character limit");
                }
                else
                {
                    // This is then added to the incident report list
                    md.addIncidentReport(MessageID, MessageBody);
                    // message box displays that a report has been filled
                    MessageBox.Show("Incident report has been filed");
                     Hide();

                    md.SaveToJSON();// saves messages list to JSON file

                    //Makes clear input button visible so user can input another message
                    btnClear.Visibility = System.Windows.Visibility.Visible;
                }

            }
            // if the value entered into txtSender is an email address and standard is checked then
            else if (Sender.Contains(".") && Sender.Contains("@") && (rdStandard.IsChecked == true))
            {
                // check for any website links, if there is a link add it to the quarinted URLs
                Regex urls = new Regex(@"http[^\s]+");
                MatchCollection urlmatches = urls.Matches(MessageText);

                foreach (Match match in urlmatches)
                {
                    md.addQuarantineURL(match.Value);
                }
                // if a URL is found then replace the text with <URL Quarantined> 
                MessageText = Regex.Replace(MessageText, @"http[^\s]+", "<URL Quarantined>");
                // creates a message body with the  sender name, subject and the text entered in the message.
                MessageBody = "Sender: " + Sender + "\n" + "Subject: " + Subject + "\n" + MessageText;

                //input validation to make sure the Email messages are no more than 1028 characters
                if (MessageText.Length > 1028)
                {
                    MessageBox.Show("Email Messages have a 1028 character limit");
                }
                else
                {
                    // This is then added to the email list
                    md.addStandardEmail(MessageID, MessageBody);
                    // message box displays that the email has been stored
                    MessageBox.Show("Email Stored");
                    Hide();
                    md.SaveToJSON();// saves messages list to JSON file

                    //Makes clear input button visible so user can input another message
                    btnClear.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }

        // Sets visibility of lblIncident, cmdIncident, 
        // lblSortCode, txtSortCode and btnClear to hidden
        public new void Hide()
        {
            lblIncident.Visibility = System.Windows.Visibility.Hidden;
            cmbIncident.Visibility = System.Windows.Visibility.Hidden;
            lblSortCode.Visibility = System.Windows.Visibility.Hidden;
            txtSortCode.Visibility = System.Windows.Visibility.Hidden;
        }

        // Clears all text boxes to to allow user to 
        // enter another message to be filtered
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtSender.Clear();
            txtSubject.Clear();
            txtMsgID.Clear();
            txtMsgText.Clear();
            txtSortCode.Clear();

            // hides all the addtional buttons, labels 
            // and text boxes that may have been opened
            rdStandard.Visibility = System.Windows.Visibility.Hidden;
            rdIncident.Visibility = System.Windows.Visibility.Hidden;
            Hide();

        }
       
    }
}
