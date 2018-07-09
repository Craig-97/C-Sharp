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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HillRaceSystem
{
    /// <summary>
    /// Interaction logic for AdminJuniorMembers.xaml
    /// </summary>
    public partial class AdminJuniorMembers : Window
    {

        MemberDatabase db;

        JuniorMember m;

        public AdminJuniorMembers()
        {
            
            InitializeComponent();
            db = MemberDatabase.Instance;
            updatecmbJMember();
        }

        /// <summary>
        /// Gets the Junior member list and populates the combo box
        /// with the list
        /// </summary>
        public void updatecmbJMember()
        {
            db = MemberDatabase.Instance;

            foreach (Member m in db.Members)
            {

                if (m.GetType() == typeof(JuniorMember))
                {
                    cmbJMember.Items.Add(m);
                }

            }
        }

        /// <summary>
        /// when item is selected, items information will 
        /// be listed in textboxes allowing it to be updated or deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbJMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m = (JuniorMember)cmbJMember.SelectedItem;
            txtJSHRNumber.Text = m.SHRNumber.ToString();
            txtJName.Text = m.Name.ToString();
            txtJYearOfBirth.Text = m.YearofBirth.ToString();
            txtJGender.Text = m.Gender.ToString();
            txtJPhoneNumber.Text = m.PhoneNumber.ToString();
            txtJEmail.Text = m.Email.ToString();
            txtJAddress.Text = m.Address.ToString();
            txtJPostcode.Text = m.Postcode.ToString();
            txtJDoctor.Text = m.Doctor.ToString();
            txtJDoctorTel.Text = m.DoctorTel.ToString();
            txtGuardian.Text = m.Guardian.ToString();
            txtRelationship.Text = m.Relationship.ToString();
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
                string shrnumber = txtJSHRNumber.Text;
                string name = txtJName.Text;
                string gender = txtJGender.Text;
                string address = txtJAddress.Text;
                string postcode = txtJPostcode.Text;
                string yearofbirth = txtJYearOfBirth.Text;
                string phonenumber = txtJPhoneNumber.Text;
                string email = txtJEmail.Text;
                string doctor = txtJDoctor.Text;
                string doctortel = txtJDoctorTel.Text;
                string guardian = txtGuardian.Text;
                string relationship = txtRelationship.Text;

                //add junior member
                db.addMember(new JuniorMember(shrnumber, name, gender, address, postcode, yearofbirth, phonenumber, email, doctor, doctortel, guardian, relationship));

                MessageBox.Show("Junior Member successfully added!");

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
                m.shrnumber = txtJSHRNumber.Text;
                m.name = txtJName.Text;
                m.gender = txtJGender.Text;
                m.address = txtJAddress.Text;
                m.postcode = txtJPostcode.Text;
                m.yearofbirth = txtJYearOfBirth.Text;
                m.phonenumber = txtJPhoneNumber.Text;
                m.email = txtJEmail.Text;
                m.doctor = txtJDoctor.Text;
                m.doctortel = txtJDoctorTel.Text;
                m.guardian = txtGuardian.Text;
                m.relationship = txtRelationship.Text;

                MessageBox.Show("Member successfully updated!");
            }


            this.Close();
            Owner.Show();
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

                    m = (JuniorMember)cmbJMember.SelectedItem;
                    db.deleteMember(m);
                    MessageBox.Show("Junior Member successfully deleted!");


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
        /// closes the window and will show the previous window on exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminJuniorMembersWindow_Closed(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Members.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, db);

            this.Owner.Show();      //go to the main page
            this.Close();           //close this window
        }

      
    }
}
