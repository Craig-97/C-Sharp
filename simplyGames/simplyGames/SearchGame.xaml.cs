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
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace SimplyGames
{
    /// <summary>
    /// Interaction logic for SearchGame.xaml
    /// </summary>
    public partial class SearchGame : Window
    {

        public SearchGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a database connection
        /// and retrieves all data from the 
        /// selected table. Also displays 
        /// all retrieved data in Grid1
        /// </summary>
        private void ViewAllGames()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from [Game]";
            cmd.Connection = con;
            OleDbDataReader rd = cmd.ExecuteReader();
            Grid1.ItemsSource = rd;

        }//end of method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchName_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter what you are searching for the press the appropriate button");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select Name,Platform,Genre,Price,AgeClassification,ProductCode,Quantity from [Game] where Name like '" + txtName.Text.ToString() + "%'";
                cmd.Connection = con;
                OleDbDataReader rd = cmd.ExecuteReader();
                Grid1.ItemsSource = rd;
           }

        }//end of method

        private void searchCode_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter what you are searching for the press the appropriate button");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select Name,Platform,Genre,Price,AgeClassification,ProductCode,Quantity from [Game] where ProductCode like '" + txtName.Text.ToString() + "%'";
                cmd.Connection = con;
                OleDbDataReader rd = cmd.ExecuteReader();
                Grid1.ItemsSource = rd;
            }

        }

        private void btnViewAll_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select Name,Platform,Genre,Price,AgeClassification,ProductCode,Quantity from [Game]";
            cmd.Connection = con;
            OleDbDataReader rd = cmd.ExecuteReader();
            Grid1.ItemsSource = rd;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void searchGenre_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter what you are searching for the press the appropriate button");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select Name,Platform,Genre,Price,AgeClassification,ProductCode,Quantity from [Game] where Genre like '" + txtName.Text.ToString() + "%'";
                cmd.Connection = con;
                OleDbDataReader rd = cmd.ExecuteReader();
                Grid1.ItemsSource = rd;
            }
        }//end of method     
    }
}
