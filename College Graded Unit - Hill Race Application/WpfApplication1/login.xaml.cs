using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for loginWindow.xaml
    /// </summary>
    public partial class login : Window
    {
        public BackgroundWorker bw = new BackgroundWorker();

        public login()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }


        /// <summary>
        /// Setting userName to equivalent textbox
        /// setting pass to equivalent password box
        /// if the username and password entered is correct
        /// run the work
        /// else 
        /// display error message "forgot password"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            String userName = txtBxuserName.Text.ToLower();
            string pass = passBxPassword.Password;
            lblfrgtPass.Visibility = Visibility.Hidden;
            lblLoading.Visibility = Visibility.Visible;
            Mouse.OverrideCursor = Cursors.Wait;
            txtBxuserName.IsEnabled = false;
            passBxPassword.IsEnabled = false;
            btnLogin.IsEnabled = false;
            if (userName == "admin" && pass == "adminpass")
            {
                
                if (bw.IsBusy == false)
                {
                    bw.RunWorkerAsync();                
                }

            }
            else
            {                             
                lblLoading.Visibility = Visibility.Hidden;
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Forgot Password ?";
                txtBxuserName.IsEnabled = true;
                txtBxuserName.BorderBrush = Brushes.Red;
                passBxPassword.IsEnabled = true;
                passBxPassword.BorderBrush = Brushes.Red;
                btnLogin.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }
        /// <summary>
        /// whilst the method is running make the application sleep for 3 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Show cancelled if the login is cancelled
        /// Show error if there is an error
        /// else
        /// display login successful and open admin window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Canceled!";                
            }

            else if (!(e.Error == null))
            {
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Error: " + e.Error.Message;                
            }
            else
            {
                lblLoading.Visibility = Visibility.Hidden;
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "LOGIN SUCCESSFUL";
                Mouse.OverrideCursor = null;
                txtBxuserName.IsEnabled = true;
                passBxPassword.IsEnabled = true;
                btnLogin.IsEnabled = true;
                

                AdminWindow window = new AdminWindow();
                window.Owner = this;                    //set owner of AdminWindow page to main page
                this.Hide();
                window.Show();
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        
        private void Window_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        //Styles and font colours
        private void txtBxuserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBxuserName.BorderBrush = Brushes.White;            
        }

        private void passBxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passBxPassword.BorderBrush = Brushes.White;
        }

        /// <summary>
        /// when this button is clicked the window will be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// When the window is closed opened up the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginWindow_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();      
            this.Close();          
        }

      
     
    }
}
