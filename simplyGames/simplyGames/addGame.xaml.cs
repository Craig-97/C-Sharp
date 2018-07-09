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
    /// Interaction logic for addGame.xaml
    /// </summary>
    public partial class addGame : Window
    {
        public addGame()
        {
            InitializeComponent();
            //Populates cmbPlatform with values to be 
            //selected when entering a new game
            cmbPlatform.Items.Add("Xbox One");
            cmbPlatform.Items.Add("Xbox 360");
            cmbPlatform.Items.Add("PlayStation 4");
            cmbPlatform.Items.Add("PlayStation 3");
            cmbPlatform.Items.Add("PlayStation Vita");
            cmbPlatform.Items.Add("Nintendo Wii U");
            cmbPlatform.Items.Add("Nintendo 3DS");

            //Populates cmbPegi with age ratings
            //to be selected when entering a new 
            //game
            cmbPegi.Items.Add("3");
            cmbPegi.Items.Add("7");
            cmbPegi.Items.Add("12");
            cmbPegi.Items.Add("16");
            cmbPegi.Items.Add("18");
            
            //Turns all label text colour to white
            lblName.Foreground = Brushes.White;
            lblGenre.Foreground = Brushes.White;
            lblPegi.Foreground = Brushes.White;
            lblPlatform.Foreground = Brushes.White;
            lblQuantity.Foreground = Brushes.White;
            lblCode.Foreground = Brushes.White;
            lblPrice.Foreground = Brushes.White;
            lblRating.Foreground = Brushes.White;
            lblDesc.Foreground = Brushes.White;

            //Turns all textbox text white and 
            //makes all textboxes transparent
            txtName.Foreground = Brushes.White;
            txtName.Background = Brushes.Transparent;
            txtGenre.Foreground = Brushes.White;
            txtGenre.Background = Brushes.Transparent;
            txtQuantity.Foreground = Brushes.White;
            txtQuantity.Background = Brushes.Transparent;
            txtPrice.Foreground = Brushes.White;
            txtPrice.Background = Brushes.Transparent;
            txtRating.Foreground = Brushes.White;
            txtRating.Background = Brushes.Transparent;
            txtCode.Foreground = Brushes.White;
            txtCode.Background = Brushes.Transparent;
            txtDesc.Foreground = Brushes.White;
            txtDesc.Background = Brushes.Transparent;
        }

        /// <summary>
        /// sets parameters to values entered into the 
        /// textboxes then inserts them in each column
        /// in the database using insert method from 
        /// database class. Throws exception if a textbox
        /// is left empty. When game is added, textboxes clear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string strName = txtName.Text;
            string strPlatform = cmbPlatform.Text.ToString();
            string strGenre = txtGenre.Text;
            string strPrice = txtPrice.Text;
            string strAgeClass = cmbPegi.Text.ToString();
            string strDesc = txtDesc.Text;
            string strRating = txtRating.Text;
            string strQuantity = txtQuantity.Text;
            string strProductCode = txtCode.Text;

            try
            {
                GameDatabase broker = new GameDatabase();
                broker.insertGame(strName, strPlatform, strGenre, strPrice, strAgeClass, strDesc, strRating, strQuantity, strProductCode);
                MessageBox.Show("Game successfully added");
                
                txtName.Clear();
                cmbPlatform.SelectedItem = null;
                txtGenre.Clear();
                txtPrice.Clear();
                cmbPegi.SelectedItem = null;
                txtDesc.Clear();
                txtRating.Clear();
                txtQuantity.Clear();
                txtCode.Clear();
            }
            catch
            {
                MessageBox.Show("Please ensure that all boxes have been filled in and try again.");
            }
        }

        /// <summary>
        /// closes window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }//end of method
    }
}
