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
using System.Data;
using System.Data.OleDb;


namespace GamesOrderApp
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        private DatabaseBroker db;

        public Order()
        {
            InitializeComponent();
            updateCustomers();
            updateGames();

        }

        private Game game;
        public Order(Game g)
        {
            game = g;
            InitializeComponent();
            if (game!=null)
            {
                txtPrice.Text = g.Name.ToString(); ;
            }
        }

        /// <summary>
        /// populates cmbCustomer with
        /// customers from the table
        /// in the connected database
        /// </summary>
        private void updateCustomers()
        {
            cmbCustomer.ItemsSource = null;
            db = new DatabaseBroker();
            cmbCustomer.ItemsSource = db.getData();
        }

        /// <summary>
        /// populates cmbGames with
        /// games from the table
        /// in the connected database
        /// </summary>
        private void updateGames()
        {
            cmbGames.ItemsSource = null;
            db = new DatabaseBroker();
            cmbGames.ItemsSource = db.getGameData();
        }

        private void cmbGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game g = (Game)cmbGames.SelectedItem;
            txtPrice.Text = g.Price.ToString();
            txtAgeRating.Text = g.AgeRating.ToString();
            txtDescription.Text = g.Description;
            txtGenre.Text = g.Genre;
            
        }
    }
}

 