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

namespace FileExtensionsProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DefaultProgDatabase dbentries;

        public MainWindow()
        {
            InitializeComponent();
            //creates the instance dbentries
            dbentries = DefaultProgDatabase.Instance;


            if (!File.Exists("FileExtensions.dat"))
            {
                dbentries.populate(); //used in testing
            }
            else
            {
                IFormatter nformatter = new BinaryFormatter();
                Stream nstream = new FileStream("FileExtensions.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                dbentries = (DefaultProgDatabase)nformatter.Deserialize(nstream);
                nstream.Close();
            }
           
        }

        /// <summary>
        /// Clears the text display box 
        /// Displays the entire list of all entries that are stored within the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListAll_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Clear();
            textDisplay.AppendText(dbentries.getAll());
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete all entries?", "Are you sure?", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                textDisplay.Text = "All entries deleted";
                dbentries.clearAll();
            }
            else
            {
                textDisplay.Text = "Deletion of entries cancelled";
            }
        }
        /// <summary>
        /// Adds entry unless
        /// the entry is already stored within the database
        /// if this is the case, display appropiate error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEntry_Click(object sender, RoutedEventArgs e)
        {
            string exten = txtExtension.Text;
            string prog = txtProgram.Text; 
            bool result = dbentries.addEntry(exten,prog);

            if (result == true)
            {
                txtExtension.Clear();
                txtProgram.Clear();
                textDisplay.Text = "The file extension " + exten + " has been successfully added with " + prog;
            }
            else
            {
                txtExtension.Clear();
                txtProgram.Clear();
                textDisplay.Text = "The file extension " + exten + " already exists";
            }

        }

        /// <summary>
        /// if the entry matching the exntesion in txtDelExtension
        /// entry is deleted and all the text boxes are cleared
        /// otherwise display an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
   
            textDisplay.Clear();
            string extension = txtDelExtension.Text;

            if (dbentries.findDefaultProgram(extension) == "Not Found")
            {
                textDisplay.Text = "No entry with key " + extension + " to remove.";
            }
            else
            {
                dbentries.deleteEntry(extension);
                textDisplay.Text = "Entry with key " + extension + " removed.";

            }

            txtDelExtension.Clear();
        }

        /// <summary>
        /// Clears the contents of txtDisplay
        /// if the entry exists matching extension within the text box
        /// then entry should be displayed to the user
        /// otherwise display an error message telling them its not found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindDefault_Click(object sender, RoutedEventArgs e)
        {

            textDisplay.Clear();
            string extension = txtFindDefault.Text;
            if(dbentries.findDefaultProgram(extension) == "Not Found") 
            {
                textDisplay.Text = "No entry with key " + extension + " exists.";
            }
            else
            {
                textDisplay.Text = " Extension " + extension + " opens with " + dbentries.findDefaultProgram(extension);
            }

            txtFindDefault.Clear();

        }

        /// <summary>
        /// When the window is closed
        /// write the newly entered extensions to the list
        /// stored on the file "FileExtensions.dat"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("FileExtensions.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, dbentries);

            stream.Close();
        }

    }
}
