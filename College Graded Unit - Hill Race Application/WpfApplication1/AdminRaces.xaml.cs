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

namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for AdminRaces.xaml
    /// </summary>
    public partial class AdminRaces : Window
    {
        private RacesDatabase db;
        private Races race;

        public AdminRaces()
        {
            InitializeComponent();
            updateRaceInfo();
        }


        /// <summary>
        /// uses the getRacesData method from the RacesDatabase
        /// class in order to get the names of the races 
        /// and then populates the cmdViewRaces with the names.
        /// </summary>
        private void updateRaceInfo()
        {
            cmbViewRaces.ItemsSource = null;
            db = new RacesDatabase();
            cmbViewRaces.ItemsSource = db.getRacesData();
        }

        /// <summary>
        /// when item is selected, items information will 
        /// be listed in textboxes allowing it to be updated or deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbViewRaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Races r = (Races)cmbViewRaces.SelectedItem;
            race = r;
            txtRaceName.Text = r.RaceName.ToString();
            txtRaceLocation.Text = r.RaceLocation.ToString();
            txtRaceDistance.Text = r.RaceDistance.ToString();
            txtRaceDate.Text = r.RaceDate.ToString();
            txtJuniorMaleTime.Text = r.JuniorMaleTime.ToString();
            txtJuniorFemaleTime.Text = r.JuniorFemaleTime.ToString();
            txtSeniorMaleTime.Text = r.SeniorMaleTime.ToString();
            txtSeniorFemaleTime.Text = r.SeniorFemaleTime.ToString();
        }

        /// <summary>
        /// populates the textboxes with the related information
        /// to the item selected in the combobox in the AdminRaces 
        /// page so that the information can be edited.
        /// </summary>
        /// <param name="g"></param>
         public AdminRaces(Races r)
        {
            race = r;
            if (race != null)
            {
                txtRaceName.Text = r.RaceName;
                txtRaceLocation.Text = r.RaceLocation;
                txtRaceDistance.Text = r.RaceDistance;
                txtRaceDate.Text = r.RaceDate;
                txtJuniorMaleTime.Text = r.JuniorMaleTime;
                txtJuniorFemaleTime.Text = r.JuniorFemaleTime;
                txtSeniorMaleTime.Text = r.SeniorMaleTime;
                txtSeniorFemaleTime.Text = r.SeniorFemaleTime;
            }
        }

        /// <summary>
        /// When the user enters information into all of the fields
        /// and the add button is clicked, the information is then 
        /// stored into the database, if it cannot complete
        /// an error message is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string strRaceName = txtRaceName.Text;
            string strRaceLocation = txtRaceLocation.Text;
            string strRaceDistance = txtRaceDistance.Text;
            string strRaceDate = txtRaceDate.Text;
            string strJuniorMaleTime = txtJuniorMaleTime.Text;
            string strJuniorFemaleTime = txtJuniorFemaleTime.Text;
            string strSeniorMaleTime = txtSeniorMaleTime.Text;
            string strSeniorFemaleTime = txtSeniorFemaleTime.Text;
           

            try
            {
                RacesDatabase broker = new RacesDatabase();
                broker.insertRaces(strRaceName, strRaceLocation, strRaceDistance, strRaceDate, strJuniorMaleTime, strJuniorFemaleTime, strSeniorMaleTime, strSeniorFemaleTime);
                MessageBox.Show("Race successfully added");

                txtRaceName.Clear();
                txtRaceLocation.Clear();
                txtRaceDistance.Clear();
                txtRaceDate.Clear();
                txtJuniorMaleTime.Clear();
                txtJuniorFemaleTime.Clear();
                txtSeniorMaleTime.Clear();
                txtSeniorFemaleTime.Clear();
          
                updateRaceInfo();
            }
            catch
            {
                MessageBox.Show("Please ensure that all boxes have been filled in and try again.");
            }
        }//end of method

        /// <summary>
        /// asks the user to confirm the deletion and if yes is selected
        /// the database entry will be removed from the connected database 
        /// then the Adminraces window will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("do you wish to delete the selected race?", "Confirm Delete", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    if (race != null)
                    {
                        RacesDatabase d = new RacesDatabase();
                        d.deleteRaces(race);
                        MessageBox.Show("Race Deleted");

                        txtRaceName.Clear();
                        txtRaceLocation.Clear();
                        txtRaceDistance.Clear();
                        txtRaceDate.Clear();
                        txtJuniorMaleTime.Clear();
                        txtJuniorFemaleTime.Clear();
                        txtSeniorMaleTime.Clear();
                        txtSeniorFemaleTime.Clear();

                    }

                }
            }
            catch
            {
                MessageBox.Show("Race Doesn't Exist");
            }
        }

        /// <summary>
        /// updates the information in the connected database by
        /// using the update method from the database class then
        /// window closes once races has been successfully updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (race != null)
                {
                    race.RaceName = txtRaceName.Text;
                    race.RaceLocation = txtRaceLocation.Text;
                    race.RaceDistance = txtRaceDistance.Text;
                    race.RaceDate = txtRaceDate.Text;
                    race.JuniorMaleTime = txtJuniorMaleTime.Text;
                    race.JuniorFemaleTime = txtJuniorFemaleTime.Text;
                    race.SeniorMaleTime = txtSeniorMaleTime.Text;
                    race.SeniorFemaleTime = txtSeniorFemaleTime.Text;

                    RacesDatabase d = new RacesDatabase();
                    d.updateRaces(race);
                    MessageBox.Show("Race Successfully Updated!");

                    txtRaceName.Clear();
                    txtRaceLocation.Clear();
                    txtRaceDistance.Clear();
                    txtRaceDate.Clear();
                    txtJuniorMaleTime.Clear();
                    txtJuniorFemaleTime.Clear();
                    txtSeniorMaleTime.Clear();
                    txtSeniorFemaleTime.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong, Please make sure all boxes are filled in and then try again");
            }

        }//end of method

        /// <summary>
        /// closes window and returns back to the admin selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminRacesWindow_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();      //go to the main page
            this.Close();           //close this window
        }
        
    }
}
