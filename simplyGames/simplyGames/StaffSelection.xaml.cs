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
    /// Interaction logic for StaffSelection.xaml
    /// </summary>
    public partial class StaffSelection : Window
    {
        public StaffSelection()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, RoutedEventArgs e)
        {
            addGame add = new addGame();
            add.Show();
        }

        private void btnSearchGame_Click(object sender, RoutedEventArgs e)
        {
            SearchGame search = new SearchGame();
            search.Show();
        }

        private void btnEditGame_Click(object sender, RoutedEventArgs e)
        {
            chooseEdit edit = new chooseEdit();
            edit.Show();
        }

        private void btnPlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
        }
    }
}
