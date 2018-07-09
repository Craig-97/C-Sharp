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
    /// Interaction logic for addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Window
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string strFirst = txtFirstName.Text;
            string strLast = txtLastName.Text;
            string strNumber = txtNumber.Text;
            string strStreet = txtStreet.Text;
            string strTown = txtTown.Text;
            string strPostcode = txtPostcode.Text;
            string strAge = txtAge.Text;
           
            DatabaseBroker broker = new DatabaseBroker();
            broker.insertCustomer(strFirst, strLast, strNumber, strStreet, strTown, strPostcode, strAge);
            MessageBox.Show("Customer successfully added");
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
