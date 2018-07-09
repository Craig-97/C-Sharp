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

namespace SimplyGames
{
    /// <summary>
    /// Interaction logic for OrderForm.xaml
    /// </summary>
    public partial class OrderForm : Window
    {
        private GameDatabase gd;
        private CustomerDatabase cd;

        public OrderForm()
        {
            InitializeComponent();          
            updateCmbGame();
            updateCmbCustomer();
            updateCmbStaff();
        }

        /// <summary>
        /// populates cmbGame with the 
        /// title of each game that 
        /// is stored in the database
        /// </summary>
        public void updateCmbGame()
        {
            cmbGame.ItemsSource = null;
            gd = new GameDatabase();
            cmbGame.ItemsSource = gd.getGameData();
        }

        /// <summary>
        /// Populates cmbCustomer with each
        /// customer stored in the list 
        /// </summary>
        public void updateCmbCustomer()
        {
            cd = CustomerDatabase.Instance;

            foreach (Person p in cd.Persons)
            {

                if (p.GetType() == typeof(Customer))
                {
                    cmbCustomer.Items.Add(p);
                }

            }
        }

        /// <summary>
        /// Populates cmbStaff with each
        /// member of staff stored in the 
        /// list
        /// </summary>
        public void updateCmbStaff()
        {
            cd = CustomerDatabase.Instance;

            foreach (Person p in cd.Persons)
            {

                if (p.GetType() == typeof(Staff))
                {
                    cmbStaff.Items.Add(p);
                }              
              
            }
        }

        private void btnPlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int orderNumber = rnd.Next(10000000, 99999999); // creates a 8 digit random no.
            string OrderNumber = orderNumber.ToString();
            string Customer = cmbCustomer.Text;
            string game = cmbGame.Text;
            string Platform = txtPlatform.Text;
            string Price = txtPrice.Text;
            string staff = cmbStaff.Text;

            //try
            //{
                GameDatabase db = new GameDatabase();
                db.insertOrder(OrderNumber, Customer, game, Platform, Price, staff);
                MessageBox.Show("Order Success");
            //}
            //catch
            //{
            //    MessageBox.Show("Failed");
            //}
 
        }

        private void cmbGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game g = (Game)cmbGame.SelectedItem;
            txtPlatform.Text = g.Platform;
            txtPrice.Text = g.Price.ToString();
        }
    }
}
