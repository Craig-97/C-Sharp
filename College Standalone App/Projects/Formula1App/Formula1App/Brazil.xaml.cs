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
    /// Interaction logic for Brazil.xaml
    /// </summary>
    public partial class Brazil : Window
    {
        public Brazil()
        {
            //declaring variables
            string Date1, Date2, Date3, DateQ, DateR;
            string Start1, Start2, Start3, StartQ, StartR;

            InitializeComponent();

            Date1 = "13th Nov"; txtDate1.Text = Date1;
            Date2 = "13th Nov"; txtDate2.Text = Date2;
            Date3 = "14th Nov"; txtDate3.Text = Date3;
            DateQ = "14th Nov"; txtDateQ.Text = DateQ;
            DateR = "15th Nov"; txtDateR.Text = DateR;

            Start1 = "12:00"; txtStart1.Text = Start1;
            Start2 = "16:00"; txtStart2.Text = Start2;
            Start3 = "13:00"; txtStart3.Text = Start3;
            StartQ = "16:00"; txtStartQ.Text = StartQ;
            StartR = "16:00"; txtStartR.Text = StartR;
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
