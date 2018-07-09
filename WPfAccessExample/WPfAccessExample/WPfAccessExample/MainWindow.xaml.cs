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

namespace WPfAccessExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DBBroker db;
        
        public MainWindow()
        {
            
            InitializeComponent();
            
            updateCombo();
        }

        private void updateCombo()
        {
            cmbStudents.ItemsSource = null;
            db = new DBBroker();
            cmbStudents.ItemsSource = db.getData();
            
        }

       

        private void cmbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student s = (Student)cmbStudents.SelectedItem;
            if (s!=null)
            { 
            EditWindow ewin = new EditWindow(s);
            ewin.ShowDialog();
            updateCombo();
            }
            
        }

        private void btnNewStudent_Click(object sender, RoutedEventArgs e)
        {
            NewStudent nwin = new NewStudent();
            nwin.ShowDialog();
            updateCombo();
        }
    }
}
