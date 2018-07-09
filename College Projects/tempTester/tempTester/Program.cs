using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please enter a temprature");
            //double t = double.Parse(Console.ReadLine());
            Temperature mytemp1 = new Temperature(2730, 'C');
            Temperature mytemp2 = new Temperature(2730, 'C');

            try
            {
                mytemp1.Celcius = 2730;
                mytemp1.setTemp(12, 'c');
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }

            Console.WriteLine("mytemp1 " + mytemp1.getstrCelcius());
            Console.WriteLine("mytemp2 " + mytemp1.getstrFarhenheit());
            Console.WriteLine("mytemp3 " + mytemp1.getstrKelvin());
            Console.WriteLine("Temprature Entered " + mytemp1.Celcius); 
            Console.ReadLine();
        }
    }
}
