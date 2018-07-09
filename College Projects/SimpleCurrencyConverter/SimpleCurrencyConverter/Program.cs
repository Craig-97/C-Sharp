using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //currencyConverter();
            Console.WriteLine(int.MaxValue);
            Console.ReadLine();
        }

        static void currencyConverter()
        {
            double pounds = 0; //a double variable
            bool pvalid; //a boolean variable
            bool rvalid; //a boolean variable
            double rate = 0; //a double varia

            Console.WriteLine("please enter a whole number of pounds");
            do
            {
                try
                {
                    pounds = double.Parse(Console.ReadLine());
                    Console.WriteLine("pounds entered " + pounds);
                    pvalid = true;

                }
                catch
                {
                    Console.WriteLine("Unable to convert to a number");
                    Console.WriteLine("Try again - ensure you enter an integer");
                    pvalid = false;
               
                }
                 
         
            } while (pvalid == false);
              Console.WriteLine("please enter the current exchange rate");

            do
            {

                try
                {
                    rate = double.Parse(Console.ReadLine());
                    Console.WriteLine("exchange rate is " + rate);
                    rvalid = true;

            Console.WriteLine("£" + pounds + " is the equivalent of " + "$" + pounds * rate);

                }

                catch
                {
                         Console.WriteLine("Unable to convert to a number");
                    Console.WriteLine("Try again - ensure you enter a number");
                    rvalid = false;

                }


            } while (rvalid == false);
            Console.ReadLine();

            
        
          }
        

    }
}
