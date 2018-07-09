using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace CourseworkBankMessageService
{
    /// <summary>
    /// Interaction logic for ShowMessages.xaml
    /// </summary>
    public partial class ShowMessages : Window
    {
        MessagingDatabase md;

        public ShowMessages()
        {
            InitializeComponent();
            md = MessagingDatabase.Instance;
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the SMS messages in the messages list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSMS_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getAllSMSmessages());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the abbreviations messages in the abbreviations list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbbreviations_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.displayAbbrevs());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the tweets messages in the tweets list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTweet_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getAllTweets());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the standard email messages in the emails list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStandard_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getStandardEmails());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the Incident reports in the emails list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncident_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getIncidentReports());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the messages in the messages list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getAllMessages());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the Quaratined URLs from the quarntined urls list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnURL_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getQuarantinedURLs());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the hashtags from the hashtags list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHashtags_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getAllHashtags());
        }

        /// <summary>
        /// clears txtDisplay and populates txtDisplay with
        /// The all the mentions from the mentions list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMentions_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(md.getAllMentions());
        }

        /// <summary>
        /// reads from the messages text file and displays each line
        /// of the text file with all the sender information and message text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadFromFile_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear(); // clears txtDisplay
            string[] fileContents;

            try
            {
                fileContents = File.ReadAllLines(@"E:/University/Messages.txt");

                foreach (string line in fileContents)
                {
                    txtDisplay.Text = txtDisplay.Text + " " + line + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

