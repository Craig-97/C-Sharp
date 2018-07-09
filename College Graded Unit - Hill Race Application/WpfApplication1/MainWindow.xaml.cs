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

namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/scottishhillracing");
        }

        private void btnStrava_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.strava.com/clubs/scottish-hill-racing-39973");
        }

        private void btnTwitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/scothillracing");
        }

        private void btnRSS_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://feeds.feedburner.com/ScottishHillRacingNews?format=html");
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            login window = new login();
            window.Owner = this;                    //set owner of login page to main page
            this.Hide();
            window.Show();
            
        }

        private void btnRaces_Click(object sender, RoutedEventArgs e)
        {
            ViewRaces window = new ViewRaces();
            window.Owner = this;                    //set owner of ViewRaces page to main page
            this.Hide();
            window.Show();
        }

        private void btnRunners_Click(object sender, RoutedEventArgs e)
        {
            ViewRunners window = new ViewRunners();
            window.Owner = this;                    //set owner of ViewRunners page to main page
            this.Hide();
            window.Show();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            About window = new About();
            window.Owner = this;                    //set owner of About page to main page
            this.Hide();
            window.Show();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

             if (MessageBox.Show("Are you sure you want to exit?", "Exit the application", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;         //cancel the action
            }
        }


    }
}
