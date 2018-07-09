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
    /// Interaction logic for editGame.xaml
    /// </summary>
    public partial class editGame : Window
    {
        private Game game;

        public editGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// populates the textboxes with the related information
        /// to the item selected in the combobox in the chooseEdit 
        /// page so that the information can be edited.
        /// </summary>
        /// <param name="g"></param>
        public editGame(Game g)
        {
            game = g;
            InitializeComponent();
            if (game != null)
            {
                txtName.Text = g.Name;
                txtPlatform.Text = g.Platform;
                txtGenre.Text = g.Genre;
                txtPrice.Text = g.Price.ToString();
                txtPegi.Text = g.AgeClassification.ToString();
                txtDesc.Text = g.Description;
                txtRating.Text = g.Rating.ToString();
                txtQuantity.Text = g.Quantity.ToString();
                txtCode.Text = g.ProductCode;
            }
        }

        /// <summary>
        /// updates the information in the connected database by
        /// using the update method from the database class then
        /// window closes once game has been successfully updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (game != null)
                {
                    game.Name = txtName.Text;
                    game.Platform = txtPlatform.Text;
                    game.Genre = txtGenre.Text;
                    game.Price = Convert.ToDecimal(txtPrice.Text);
                    game.AgeClassification = Convert.ToInt32(txtPegi.Text);
                    game.Description = txtDesc.Text;
                    game.Rating = Convert.ToInt32(txtRating.Text);
                    game.Quantity = Convert.ToInt32(txtQuantity.Text);
                    game.ProductCode = txtCode.Text;

                    GameDatabase d = new GameDatabase();
                    d.updateGame(game);
                    MessageBox.Show("Game Successfully Updated!");
                }
                Close();
                chooseEdit choose = new chooseEdit();
                choose.Show();

            }
            catch
            {
                MessageBox.Show("Something went wrong, Please make sure all boxes are filled in and then try again");
            }
        }//end of method

        /// <summary>
        /// prompts the user to confirm deletion and if yes clicked
        /// the entry will be deleted from the connected database and
        /// the editGame window will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("do you wish to delete the selected game?", "Confirm Delete", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    if (game != null)
                    {
                        GameDatabase d = new GameDatabase();
                        d.deleteGame(game);
                        MessageBox.Show("Game Deleted");
                    }
                    Close();
                    chooseEdit choose = new chooseEdit();
                    choose.Show();
                }
            }
            catch
            {
                MessageBox.Show("Item Doesn't Exist");
            }

        }//end of method
    }
}
