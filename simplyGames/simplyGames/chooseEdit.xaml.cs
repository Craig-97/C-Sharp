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
    /// Interaction logic for chooseEdit.xaml
    /// </summary>
    public partial class chooseEdit : Window
    {
        private GameDatabase db;

        public chooseEdit()
        {
            InitializeComponent();
            UpdateCmbEdit();
            lblEdit.Foreground = Brushes.White;
            btnCancel.Foreground = Brushes.White;
            btnCancel.Background = Brushes.Transparent;

        }

        /// <summary>
        /// uses the getGameData method from the database
        /// class in order to get the names of the products 
        /// and then populate the cmbEdit with the names.
        /// </summary>
        public void UpdateCmbEdit()
        {
            //cmbEdit.ItemsSource = null;
            db = new GameDatabase();
            cmbEdit.ItemsSource = db.getGameData();
        }

        /// <summary>
        /// closes this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// when item is selected a window will open 
        /// with the items information listed in 
        /// textboxes allowing it to be updated or deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game g = (Game)cmbEdit.SelectedItem;
            if (g != null)
            {
                editGame edit = new editGame(g);
                edit.ShowDialog();
            }
            this.Close();
        }
    }
}
