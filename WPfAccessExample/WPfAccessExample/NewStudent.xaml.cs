﻿using System;
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
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string strFirst = txtFirst.Text;
            string strLast = txtLast.Text;
            //could add validation!!!
            DBBroker broker = new DBBroker();
            broker.insert(strFirst, strLast);
            this.Close();
        }
    }
}
