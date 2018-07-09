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
    /// Interaction logic for People.xaml
    /// </summary>
    public partial class People : Window
    {
        CustomerDatabase database;

        public People()
        {
            InitializeComponent();
            database = CustomerDatabase.Instance;
            database.populate();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(database.getAll());
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(database.getCustomer());
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(database.getStaff());
        }
    }
}
