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

namespace WPfAccessExample
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        
        private Student stud;
        public EditWindow(Student s)
        {
            stud = s;
            InitializeComponent();
            if (stud!=null)
            { 
            txtFirst.Text= s.FirstName;
            txtLast.Text = s.LastName;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (stud != null)
            {
                stud.LastName = txtLast.Text;
                stud.FirstName = txtFirst.Text;
                DBBroker broker = new DBBroker();
                broker.update(stud);
            }
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        { 
            if (stud!=null)
            { 
            DBBroker broker = new DBBroker();
            broker.delete(stud);
            }
            Close();
        }

    }
}
