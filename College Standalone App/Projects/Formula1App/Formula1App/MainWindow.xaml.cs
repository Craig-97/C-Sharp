using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace Formula1App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DateTime endDate;
        private DispatcherTimer timer;
        DateTime dateNow = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();

            if (dateNow < (DateTime.Parse("15/03/2015 05:00:00AM"))) //Australia
            {
                endDate = DateTime.Parse("15/03/2015 05:00:00 AM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Australia, Albert Park");
            }
            else if (dateNow < (DateTime.Parse("29/03/2015 08:00:00AM"))) //Malaysia
            {
                endDate = DateTime.Parse("29/03/2015 08:00:00 AM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Malaysia, Sepang");
            }
            else if (dateNow < DateTime.Parse("12/04/2015 07:00:00 AM")) //China
            {
                endDate = DateTime.Parse("12/04/2015 07:00:00 AM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At China, Shanghai");
            }
            else if (dateNow < DateTime.Parse("19/04/2015 16:00:00 PM")) //Bahrain
            {
                endDate = DateTime.Parse("19/04/2015 16:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Bahrain, Sahkir");
            }
            else if (dateNow < DateTime.Parse("10/05/2015 13:00:00 PM")) //Spain
            {
                endDate = DateTime.Parse("10/05/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Spain, Catalunya");
            }
            else if (dateNow < DateTime.Parse("24/05/2015 13:00:00 PM")) //Monaco
            {
                endDate = DateTime.Parse("24/05/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Monaco, Monte-Carlo");
            }
            else if (dateNow < DateTime.Parse("07/06/2015 19:00:00 PM")) //Canada
            {
                endDate = DateTime.Parse("07/06/2015 19:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Canada, Montreal");
            }
            else if (dateNow < DateTime.Parse("21/06/2015 13:00:00 PM")) //Austria
            {
                endDate = DateTime.Parse("21/06/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Austria, Spielberg");
            }
            else if (dateNow < DateTime.Parse("05/07/2015 13:00:00 PM")) //Britain
            {
                endDate = DateTime.Parse("05/07/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Britain, Silverstone");
            }
            else if (dateNow < DateTime.Parse("26/07/2015 13:00:00 PM")) //Hungary
            {
                endDate = DateTime.Parse("26/07/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Hungary, Budapest");
            }
            else if (dateNow < DateTime.Parse("23/08/2015 13:00:00 PM")) //Belguim
            {
                endDate = DateTime.Parse("23/08/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Belguim, Spa");
            }
            else if (dateNow < DateTime.Parse("06/09/2015 13:00:00 PM")) //Italy
            {
                endDate = DateTime.Parse("06/09/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Italy, Monza");
            }
            else if (dateNow < DateTime.Parse("20/09/2015 13:00:00 PM")) //Singapore
            {
                endDate = DateTime.Parse("20/09/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Singapore, Marina Bay");
            }
            else if (dateNow < DateTime.Parse("27/09/2015 06:00:00 AM")) //Japan
            {
                endDate = DateTime.Parse("27/09/2015 06:00:00 AM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Japan, Suzuka");
            }
            else if (dateNow < DateTime.Parse("11/10/2015 12:00:00 PM")) //Russia
            {
                endDate = DateTime.Parse("11/10/2015 12:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Russia, Sochi");
            }
            else if (dateNow < DateTime.Parse("25/10/2015 19:00:00 PM")) //USA
            {
                endDate = DateTime.Parse("25/10/2015 19:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At United States, Austin");
            }
            else if (dateNow < DateTime.Parse("01/11/2015 19:00:00 PM")) //Mexico
            {
                endDate = DateTime.Parse("01/11/2015 19:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Mexico, Mexico City");
            }
            else if (dateNow < DateTime.Parse("15/11/2015 16:00:00 PM")) //Brazil
            {
                endDate = DateTime.Parse("15/11/2015 16:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Brazil, Sao Paulo");
            }
            else if (dateNow < DateTime.Parse("29/11/2015 13:00:00 PM")) //Abu Dhabi
            {
                endDate = DateTime.Parse("29/11/2015 13:00:00 PM"); //Date and time of next grand prix
                timer = new DispatcherTimer();
                timer.Tick += CountDown;
                timer.Interval = TimeSpan.FromSeconds(1); //refresh every second
                timer.Start(); //start the countdown timer
                txtGrandPrix.Text = ("At Abu Dhabi, Yas Marina");
            }
        }

        private void CountDown(object sender, EventArgs e)
        {
            var remainingTime = endDate.Subtract(DateTime.Now);

            txtCount.Text = string.Format("{0}Days, {1}Hours, {2}Minutes, {3}Seconds" + "", remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds);

        }

        private void btnAustralia_Click(object sender, RoutedEventArgs e)
        {
            Australia aWindow = new Australia();   //create window for Australia page
            aWindow.Owner = this;                  //set owner of Australia page to main page
            this.Hide();                             //hide the main page
            aWindow.Show();                          //shows Australia as normal window
        }

        private void btnMalaysia_Click(object sender, RoutedEventArgs e)
        {
            Malaysia mWindow = new Malaysia();     //create window for Malaysia page
            mWindow.Owner = this;                  //set owner of Malaysia page to main page
            this.Hide();                             //hide the main page
            mWindow.Show();                          //shows Malaysia as normal window
        }

        private void btnChina_Click(object sender, RoutedEventArgs e)
        {
            China cWindow = new China();           //create window for China page
            cWindow.Owner = this;                  //set owner of China page to main page
            this.Hide();                             //hide the main page
            cWindow.Show();                          //shows China as normal window
        }

        private void btnBahrain_Click(object sender, RoutedEventArgs e)
        {
            Bahrain bWindow = new Bahrain();       //create window for Bahrain page
            bWindow.Owner = this;                  //set owner of Bahrain page to main page
            this.Hide();                             //hide the main page
            bWindow.Show();                          //shows Bahrain as normal window
        }

        private void btnSpain_Click(object sender, RoutedEventArgs e)
        {
            Spain sWindow = new Spain();           //create window for Spain page
            sWindow.Owner = this;                  //set owner of Spain page to main page
            this.Hide();                             //hide the main page
            sWindow.Show();                          //shows Spain as normal window
        }

        private void btnMonaco_Click(object sender, RoutedEventArgs e)
        {
            Monaco moWindow = new Monaco(); //create window for Monaco page
            moWindow.Owner = this;                  //set owner of Monaco page to main page
            this.Hide();                             //hide the main page
            moWindow.Show();                          //shows Monaco as normal window
        }

        private void btnCanada_Click(object sender, RoutedEventArgs e)
        {
            Canada caWindow = new Canada();         //create window for Canada page
            caWindow.Owner = this;                  //set owner of Canada page to main page
            this.Hide();                             //hide the main page
            caWindow.Show();                          //shows Canada as normal window
        }

        private void btnAustria_Click(object sender, RoutedEventArgs e)
        {
            Austria auWindow = new Austria();       //create window for Austria page
            auWindow.Owner = this;                  //set owner of Austria page to main page
            this.Hide();                             //hide the main page
            auWindow.Show();                          //shows Austria as normal window
        }

        private void btnBritain_Click(object sender, RoutedEventArgs e)
        {
            Britain brWindow = new Britain();       //create window for Britain page
            brWindow.Owner = this;                  //set owner of Britain page to main page
            this.Hide();                             //hide the main page
            brWindow.Show();                          //shows Britain as normal window
        }

        private void btnGermany_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The German Grand Prix has been cancelled!");
        }

        private void btnHungary_Click(object sender, RoutedEventArgs e)
        {
            Hungary hWindow = new Hungary();       //create window for Hungary page
            hWindow.Owner = this;                  //set owner of Hungary page to main page
            this.Hide();                             //hide the main page
            hWindow.Show();                          //shows Hungary as normal window
        }

        private void btnBelgium_Click(object sender, RoutedEventArgs e)
        {
            Belgium beWindow = new Belgium();       //create window for Belgium page
            beWindow.Owner = this;                  //set owner of Belgium page to main page
            this.Hide();                             //hide the main page
            beWindow.Show();                          //shows Belgium as normal window
        }

        private void btnItaly_Click(object sender, RoutedEventArgs e)
        {
            Italy iWindow = new Italy();           //create window for Italy page
            iWindow.Owner = this;                  //set owner of Italy page to main page
            this.Hide();                             //hide the main page
            iWindow.Show();                          //shows Italy as normal window
        }

        private void btnSingapore_Click(object sender, RoutedEventArgs e)
        {
            Singapore sWindow = new Singapore();   //create window for Singapore page
            sWindow.Owner = this;                  //set owner of Singapore page to main page
            this.Hide();                             //hide the main page
            sWindow.Show();                          //shows Singapore as normal window
        }

        private void btnJapan_Click(object sender, RoutedEventArgs e)
        {
            Japan jWindow = new Japan();           //create window for Japan page
            jWindow.Owner = this;                  //set owner of Japan page to main page
            this.Hide();                             //hide the main page
            jWindow.Show();                          //shows Japan as normal window
        }

        private void btnRussia_Click(object sender, RoutedEventArgs e)
        {
            Russia rWindow = new Russia();         //create window for Russia page
            rWindow.Owner = this;                  //set owner of Russia page to main page
            this.Hide();                             //hide the main page
            rWindow.Show();                          //shows Russia as normal window
        }

        private void btnUSA_Click(object sender, RoutedEventArgs e)
        {
            USA uWindow = new USA();               //create window for USA page
            uWindow.Owner = this;                  //set owner of USA page to main page
            this.Hide();                             //hide the main page
            uWindow.Show();                          //shows USA as normal window
        }

        private void btnMexico_Click(object sender, RoutedEventArgs e)
        {
            Mexico meWindow = new Mexico();         //create window for Mexico page
            meWindow.Owner = this;                  //set owner of Mexico page to main page
            this.Hide();                             //hide the main page
            meWindow.Show();                          //shows Mexico as normal window
        }

        private void btnBrazil_Click(object sender, RoutedEventArgs e)
        {
            Brazil braWindow = new Brazil();         //create window for Brazil page
            braWindow.Owner = this;                  //set owner of Brazil page to main page
            this.Hide();                             //hide the main page
            braWindow.Show();                          //shows Brazil as normal window
        }

        private void btnAbuDhabi_Click(object sender, RoutedEventArgs e)
        {
            AbuDhabi abWindow = new AbuDhabi();     //create window for Abu Dhabi page
            abWindow.Owner = this;                  //set owner of Abu Dhabi page to main page
            this.Hide();                             //hide the main page
            abWindow.Show();                         //shows Abu Dhabi as normal window
        }

    }
}
