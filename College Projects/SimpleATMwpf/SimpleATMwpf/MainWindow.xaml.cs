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
using SimpleBank;

namespace SimpleATMwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bank thebank;
        public MainWindow()
        {
            thebank = Bank.Instance;
            thebank.populate(); 
            InitializeComponent();
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            Customer c = thebank.findCustomer(txtName.Text);
            txtName.Text = "";//reset text box
                if (c == null)
                {
                //no such customer
                MessageBox.Show("Error unknown customer \ncard damaged");
                }
                else
                {
                //create new customer window and link to customer
                CustomerWindow cwindow = new CustomerWindow(c);
                cwindow.Owner = this;
                this.Hide();
                cwindow.Show();
                }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("are you sure you want to shutdown the ATM?", "Simple ATM",
                MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                e.Cancel = true; //cancel event
        }
    }
}
