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

namespace GamesOrderApp
{
    /// <summary>
    /// Interaction logic for addGame.xaml
    /// </summary>
    public partial class addGame : Window
    {
        public addGame()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddGame_Click(object sender, RoutedEventArgs e)
        {
            string strName = txtGameName.Text;
            string strGenre = txtGenre.Text;
            string strDesc = txtDesc.Text;
            string strPrice = txtPrice.Text;
            string strAgeRating = txtRating.Text;

            DatabaseBroker broker = new DatabaseBroker();
            broker.insertGame(strName, strGenre, strDesc, strPrice, strAgeRating);
            MessageBox.Show("Game successfully added");
            this.Close();
        }
    }
}
