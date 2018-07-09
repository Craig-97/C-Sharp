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


namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for ViewRunners.xaml
    /// </summary>
    public partial class ViewRunners : Window
    {
        /// <summary>
        /// the runners database
        /// set to singleton instance in constructor
        /// </summary>
        RunnersDatabase theRunners;

        public ViewRunners()
        {
            InitializeComponent();
            radioJunior.IsChecked = true;
            theRunners = RunnersDatabase.Instance;

            if (!File.Exists("runners.dat"))
            {
                //theRunners.populate();//used for testing
            }
            else
            {

                IFormatter nformatter = new BinaryFormatter();
                Stream nstream = new FileStream("runners.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                theRunners = (RunnersDatabase)nformatter.Deserialize(nstream);
                nstream.Close();


            }
        }

        /// <summary>
        /// this method will list all the junior runners in the display textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListJunior_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theRunners.getJuniorRunners());
        }

        /// <summary>
        /// this method will list all the senior runners in the display textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListSenior_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theRunners.getSeniorRunners());
        }

        /// <summary>
        /// this method will list all the runners in the display textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListAll_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.AppendText(theRunners.getAll());
        }

        /// <summary>
        /// if the radio button is checked then the button
        /// will have "add junior runner" displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioJunior_Checked(object sender, RoutedEventArgs e)
        {
            btnAddRunner.Content = "Add Junior Runner";
        }

        /// <summary>
        /// if the radio button is checked then the button
        /// will have "add senior runner" displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioSenior_Checked(object sender, RoutedEventArgs e)
        {
            btnAddRunner.Content = "Add Senior Runner";
        }

        /// <summary>
        /// Depending on which radio button is selected, the user can enter
        /// their information (shrnumber, name, gender) and then the .addrunner
        /// method will add the runner to the list and throw an exception if
        /// there is any error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRunner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string shrnumber = txtSHRNumber.Text;
                string name = txtName.Text;
                string gender = txtGender.Text;
                if (radioJunior.IsChecked == true)
                {
                    //add junior runner
                    theRunners.addRunner(new JuniorRunner(shrnumber, name, gender));
                }
                else
                {
                    //add senior runner
                    theRunners.addRunner(new SeniorRunner(shrnumber, name, gender));
                }
                MessageBox.Show("Successfully added!");
                txtSHRNumber.Text = "";
                txtName.Text = "";
                txtGender.Text = "";


            }
            catch
            {
                MessageBox.Show("Runner cannot be added");
            }

        }

        /// <summary>
        /// When the window closes the .dat file will be created if 
        /// it doesnt already exist and if it does exist, it will be
        /// overwritten/saved. Then the window will close and open
        /// the homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewRunnersWindow_Closed(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("runners.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, theRunners);

            stream.Close();
            this.Owner.Show();      //go to the main page
        }

        /// <summary>
        /// uses a confirm dialog and prompts the user to ensure they want to clear all entries
        /// if they confirm
        /// all entries are deleted
        /// else
        /// cancel the operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnClear_Click(object sender, RoutedEventArgs e)
        //{
        //    if (MessageBox.Show("Delete all entries?", "Are you sure?", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
        //    {
                
        //        txtDisplay.Text = "All entries deleted";
        //        File.Delete("runners.dat");

        //    }
        //    else
        //    {
        //        txtDisplay.Text = "Deletion of entries cancelled";
        //    }
        //}


    }
}
