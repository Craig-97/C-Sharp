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

namespace FileExtensionsStarter
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
            //create  dbentries 
            //should then read in entries from file or use populate
            //you might want to use populate before adding persistence
        }

        private void btnListAll_Click(object sender, RoutedEventArgs e)
        {
            //SHOULD DISOPLAY ALL ENTRIES IN dbentries
            //look at expected format in test document
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //should use a confirm dialog to ensure user wants to clear all entries
            //if confiormed
            // delete all entries
            //else
            //  cancel
        }

        private void btnAddEntry_Click(object sender, RoutedEventArgs e)
        {
            //should either add entry or display appropriate error message
            //look at  test documentation
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //if entry exists matchinmg extension in text box txtDelExtension
            //entry should be deleted and all text boxes cleared
            //else display appropriate error message
            //look at test documentation
        }

        private void btnFindDefault_Click(object sender, RoutedEventArgs e)
        {
            //clear contants of txtDisplay
            //if entry exists matchinmg extension in text box 
            //entry should be displayed in txtDisplay 
            //else display appropriate error message
            //look at test documentation
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //should write dbentries to data file
        }




    }
}
