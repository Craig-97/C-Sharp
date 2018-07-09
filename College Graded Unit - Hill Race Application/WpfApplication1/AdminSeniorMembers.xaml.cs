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
    /// Interaction logic for SeniorJuniorMembers.xaml
    /// </summary>
    public partial class AdminSeniorMembers : Window
    {
       
        MemberDatabase db;

        SeniorMember m;
        

        public AdminSeniorMembers()
        {
            InitializeComponent();
            //db = MemberDatabase.Instance; 
            //db.populate();                //used to test if combo box was being populated
            db = MemberDatabase.Instance;
            updatecmbSMember();
        }

        /// <summary>
        /// This method grabs the Senior member list
        /// and populates the combo box with it
        /// </summary>
        public void updatecmbSMember()
        {
            db = MemberDatabase.Instance;

            foreach (Member m in db.Members)
            {

                if (m.GetType() == typeof(SeniorMember))
                {
                    cmbSMember.Items.Add(m);
                }

            }
        }

        /// <summary>
        /// when item is selected, items information will 
        /// be listed in textboxes allowing it to be updated or deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m = (SeniorMember)cmbSMember.SelectedItem;
            txtSSHRNumber.Text = m.SHRNumber.ToString();
            txtSName.Text = m.Name.ToString();
            txtSYearOfBirth.Text = m.YearofBirth.ToString();
            txtSGender.Text = m.Gender.ToString();
            txtSPhoneNumber.Text = m.PhoneNumber.ToString();
            txtSEmail.Text = m.Email.ToString();
            txtSAddress.Text = m.Address.ToString();
            txtSPostcode.Text = m.Postcode.ToString();
            txtSDoctor.Text = m.Doctor.ToString();
            txtSDoctorTel.Text = m.DoctorTel.ToString();
           
        }

        /// <summary>
        /// Messagebox prompts the user if they are sure they want to delete the member
        /// if they click ok the selected member from the combo box will be removed 
        /// from the members list. A messagebox will display whether or not
        /// this has been successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("do you wish to delete the selected member?", "Confirm Delete", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                 
                    m = (SeniorMember)cmbSMember.SelectedItem;
                    db.deleteMember(m);
                    MessageBox.Show("Senior Member successfully deleted!");


                    this.Close();
                    Owner.Show();
                    
                }
            }

            catch
            {
                MessageBox.Show("Member cannot be deleted!");
            }

        }

        /// <summary>
        /// When the user enters information into all of the fields
        /// and the add button is clicked, the information is then 
        /// stored into the database, if it cannot complete
        /// an error message is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string shrnumber = txtSSHRNumber.Text;
                string name = txtSName.Text;
                string gender = txtSGender.Text;
                string address = txtSAddress.Text;
                string postcode = txtSPostcode.Text;
                string yearofbirth = txtSYearOfBirth.Text;
                string phonenumber = txtSPhoneNumber.Text;
                string email = txtSEmail.Text;
                string doctor = txtSDoctor.Text;
                string doctortel = txtSDoctorTel.Text;

                //add senior member
                db.addMember(new SeniorMember(shrnumber, name, gender, address, postcode, yearofbirth, phonenumber, email, doctor, doctortel));
                
                MessageBox.Show("Senior Member successfully added!");

                this.Close();
                Owner.Show();
                
            }
            catch
            {
                MessageBox.Show("Member cannot be added, make sure all fields are filled in!");
            }

        }

        /// <summary>
        /// if the combo box is null then do nothing
        /// else set each text box to the list equivalent
        /// when the window closes this will be saved and updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (m == null)
            {

            }
            else
            {
                m.shrnumber = txtSSHRNumber.Text;
                m.name = txtSName.Text;
                m.gender = txtSGender.Text;
                m.address = txtSAddress.Text;
                m.postcode = txtSPostcode.Text;
                m.yearofbirth = txtSYearOfBirth.Text;
                m.phonenumber = txtSPhoneNumber.Text;
                m.email = txtSEmail.Text;
                m.doctor = txtSDoctor.Text;
                m.doctortel = txtSDoctorTel.Text;

                MessageBox.Show("Member successfully updated!");
            }


            this.Close();
            Owner.Show();
        }

        /// <summary>
        /// When window closes the members are saved to a .dat file named 
        /// SeniorMembers.dat so it can be retrieved next time the 
        /// application is launched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminSeniorMembersWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Members.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, db);

            stream.Close();
            this.Owner.Show();      //go to the main page

        }

    }
}
