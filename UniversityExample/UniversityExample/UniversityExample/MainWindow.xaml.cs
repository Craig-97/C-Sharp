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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace UniversityExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// the university database
        /// set to singleton instance in constructor
        /// </summary>
        Database theUniversity;

        /// <summary>
        /// creates window and sets uinersity to singleton instance
        /// populates for testing
        /// </summary>
        public MainWindow()
        {
            
            InitializeComponent();
            radioStaff.IsChecked = true;
            theUniversity = Database.Instance;

            if (!File.Exists("uni.dat"))
            {
                theUniversity.populate();//used for testing
            }
            else
            {

                IFormatter nformatter = new BinaryFormatter();
                Stream nstream = new FileStream("uni.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                theUniversity = (Database)nformatter.Deserialize(nstream);
                nstream.Close();


            }

            
        }

        private void btnListStaff_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theUniversity.getStaff());
        }




        private void btnListAll_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theUniversity.getAll());
        }

        private void btnListStudents_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theUniversity.getStudents());
        }










        private void radioStaff_Checked(object sender, RoutedEventArgs e)
        {
            lblOther.Content = "Room";         
                btnAddPerson.Content = "Add Staff";
        }

        private void radioStudent_Checked(object sender, RoutedEventArgs e)
        {
            lblOther.Content = "ID";
            btnAddPerson.Content = "Add Student";
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int yob = int.Parse(txtYear.Text);
                string oth = txtOther.Text;
                if (radioStaff.IsChecked == true)
                {
                    //add staff
                    theUniversity.addPerson(new Staff(name, yob, oth));
                }
                else
                {
                    //add student
                    theUniversity.addPerson(new Student(name, yob, oth));
                }
                MessageBox.Show("added!!!");
                txtName.Text = "";
                txtOther.Text = "";
                txtYear.Text = "";


            }
            catch
            {
                MessageBox.Show("something wrong!!!");
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("uni.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, theUniversity);

                stream.Close();


        }

        
    }
}
