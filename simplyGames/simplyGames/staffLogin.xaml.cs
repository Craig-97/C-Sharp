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
    /// Interaction logic for staffLogin.xaml
    /// </summary>
    public partial class staffLogin : Window
    {

        private CustomerDatabase cd;

        public staffLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            cd = CustomerDatabase.Instance;

            foreach (Person p in cd.Persons)
            {
                if (p.GetType() == typeof(Staff))
                {
                    Staff s = (Staff)p;
                    if (s.StaffID == txtUserName.Text)
                    {
                        MessageBox.Show("Login Successful");
                        StaffSelection select = new StaffSelection();
                        select.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username");
                    }
                }
            }

        }
    }
}
