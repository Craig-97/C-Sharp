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
using System.Windows.Shapes;

namespace Formula1App
{
    /// <summary>
    /// Interaction logic for USA.xaml
    /// </summary>
    public partial class USA : Window
    {
        public USA()
        {
            //declaring variables
            string Date1, Date2, Date3, DateQ, DateR;
            string Start1, Start2, Start3, StartQ, StartR;

            InitializeComponent();

            Date1 = "23rd Oct"; txtDate1.Text = Date1;
            Date2 = "23rd Oct"; txtDate2.Text = Date2;
            Date3 = "24th Oct"; txtDate3.Text = Date3;
            DateQ = "24th Oct"; txtDateQ.Text = DateQ;
            DateR = "25th Oct"; txtDateR.Text = DateR;

            Start1 = "16:00"; txtStart1.Text = Start1;
            Start2 = "20:00"; txtStart2.Text = Start2;
            Start3 = "16:00"; txtStart3.Text = Start3;
            StartQ = "19:00"; txtStartQ.Text = StartQ;
            StartR = "19:00"; txtStartR.Text = StartR;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();      //go to the main page
            this.Close();           //close this window
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back to the home page?", "Return to Home Page", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;         //cancel the action
            }
        }
    }
}
