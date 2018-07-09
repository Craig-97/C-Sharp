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

namespace GamesOrderApp
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

        private void btnNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            addCustomer customer = new addCustomer();
            customer.Show();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            addGame game = new addGame();
            game.Show();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
        }
    }
}
