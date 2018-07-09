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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAddWindow_Click(object sender, RoutedEventArgs e)
        {
            addGame add = new addGame();
            add.Show();
        }

        private void btnEditWindow_Click(object sender, RoutedEventArgs e)
        {
            chooseEdit choose = new chooseEdit();
            choose.Show();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchGame search = new SearchGame();
            search.Show();
        }
    }
}
