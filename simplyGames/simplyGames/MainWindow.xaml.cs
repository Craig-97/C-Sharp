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

namespace SimplyGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerDatabase cd;

        public MainWindow()
        {
            InitializeComponent();
            cd = CustomerDatabase.Instance;
            cd.populate();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            SearchGame search = new SearchGame();
            search.Show();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            staffLogin login = new staffLogin();
            login.Show();
        }


       
    }
}
