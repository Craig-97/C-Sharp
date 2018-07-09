using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            //usingVariables( ); //commented out so you have a copy!
            simpleReader();
            Console.ReadLine();
        }
        static void usingVariables()
        {
            //Declare some variables
            long value; //declares a variable of the type int
            double dvalue; //declares a variable of the type double

            //now assign some values to the two variables
            value = 134567891234567;
            dvalue = 12.3456789;

            //now display the contents in a console window
            //notice how we send a message (writeLine) to the Console object
            //When you hit the period, the intellisense lists the possible methods

            Console.WriteLine("Variable value contains: " + value);
            Console.WriteLine("Variable dvalue contains: " + dvalue);

            //the next line illustrates an alternative C style output mechanism
            //the advantage is that you can use some formatting options
            //notice how the first floating point variable is formatted to 2 
            //decimal places using :F2
            Console.WriteLine("Variable dvalue formatted {0:F2} and value {1}", dvalue, value); //all on one line!

            //this final line simply stops the console window dissappearing
            //later on you will see how this can be used 
            //read data 

        }

        static void simpleReader()
        {
            //this small program illustrates how to read in 
            //numeric data from standard input (a string of text!)
            //a 32 bit signed integer can store the values
            //-2,147,483,648 to 2,147,483,647
            //but standard input is text - so we need to parse the input
            //this small program illustrates 
            //a simple validation loop
            int ivalue; //an integer variable
            bool valid; //a boolean variable

            Console.WriteLine("please enter a signed integer value");
            do
            {
                try
                {
                    ivalue = int.Parse(Console.ReadLine());
                    Console.WriteLine("value in ivalue is: {0:N}", ivalue);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Unable to convert to a number");
                    Console.WriteLine("Try again - ensure you enter an integer");
                    valid = false;
                }
            } while (valid == false);
            //notice how the two == are used to test for equivalence
            Console.ReadLine();


        } 
    }
}
