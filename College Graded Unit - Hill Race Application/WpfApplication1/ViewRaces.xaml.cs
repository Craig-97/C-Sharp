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
    /// Interaction logic for ViewRaces.xaml
    /// </summary>
    public partial class ViewRaces : Window
    {
        private RacesDatabase db;

        public ViewRaces()
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
        /// closes the window and returns back to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewRacesWindow_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();      //go to the main page
            this.Close();           //close this window
        }

        /// <summary>
        /// when item is selected a window will open 
        /// with the items information listed in the
        /// textboxes allowing it to viewed by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbViewRaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Races r = (Races)cmbViewRaces.SelectedItem;
            txtRaceName.Text = r.RaceName.ToString();
            txtRaceLocation.Text = r.RaceLocation.ToString();
            txtRaceDistance.Text = r.RaceDistance.ToString();
            txtRaceDate.Text = r.RaceDate.ToString();
            txtJuniorMaleTime.Text = r.JuniorMaleTime.ToString();
            txtJuniorFemaleTime.Text = r.JuniorFemaleTime.ToString();
            txtSeniorMaleTime.Text = r.SeniorMaleTime.ToString();
            txtSeniorFemaleTime.Text = r.SeniorFemaleTime.ToString();
        }
    }
}
