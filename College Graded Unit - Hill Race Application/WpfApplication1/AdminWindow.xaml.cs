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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        RunnersDatabase theRunners;

        public AdminWindow()
        {
            InitializeComponent();
            theRunners = RunnersDatabase.Instance;
        }

        /// <summary>
        /// Opens the AdminRaces page
        /// and hides the current page until the AdminRaces page is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaces_Click(object sender, RoutedEventArgs e)
        {
            AdminRaces window = new AdminRaces();
            window.Owner = this;                    //set owner of ViewRaces page to main page
            this.Hide();
            window.Show();
        }

        /// <summary>
        /// Opens the AdminJuniorMembers page
        /// and hides the current page until the AdminJuniorMembers page is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJuniorMember_Click(object sender, RoutedEventArgs e)
        {
            AdminJuniorMembers window = new AdminJuniorMembers();
            window.Owner = this;                    //set owner of ViewRaces page to main page
            this.Hide();
            window.Show();
        }

        /// <summary>
        /// Opens the AdminSeniorMembers page
        /// and hides the current page until the AdminSeniorMembers page is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeniorMember_Click(object sender, RoutedEventArgs e)
        {
            AdminSeniorMembers window = new AdminSeniorMembers();
            window.Owner = this;                    //set owner of ViewRaces page to main page
            this.Hide();
            window.Show();
        }

        /// <summary>
        /// Links to the next race signups - ViewRunners page
        /// this will clear the next race signup/runners list
        /// the application will then close to make sure all changes take
        /// affect without causing issues to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearRunners_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                theRunners.Runners.Clear();
                MessageBox.Show("The Next Race signups were succesfully cleared - The application will now close");
                Application.Current.Shutdown();

            }
            catch
            {
                MessageBox.Show("The Next Race signups could not be cleared");
            }
        }

        /// <summary>
        /// This will save to the runners.dat file on exit
        /// as well as show the previous page when the current
        /// window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminWindow1_Closed(object sender, EventArgs e)
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("runners.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, theRunners);

            this.Owner.Show();      //go to the main page
            this.Close();           //close this window
        }
    }
}
