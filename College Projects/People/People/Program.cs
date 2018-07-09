using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            //By calling another static method
            //it is easier to code a series of test programs
            TestAddress();
            TestPerson();
        }

        static void TestAddress()
        {
            Address anaddress = new Address();
            Console.WriteLine("Empty anaddress contains " + anaddress);
            //now use the public properties
            anaddress.Street = "100 bedrock street";
            anaddress.Town = "Bedrock";
            anaddress.Postcode = "BB1 FF12";
            //Use ToString to display address
            Console.WriteLine("using ToString to display address");
            Console.WriteLine(anaddress);
            //now use properties to display constituent parts
            Console.WriteLine("using properties to display address");
            Console.WriteLine("Street: " + anaddress.Street);
            Console.WriteLine("Town: " + anaddress.Town);
            Console.WriteLine("postcode: " + anaddress.Postcode);

            Console.WriteLine("\npress return to continue");
            Console.ReadLine();
        }

        static void TestPerson()
        {
            Person p1 = new Person();
            Person p2 = new Person("Peter");
            Person p3 = new Person("Wilma", 1978);
            Person p4 = new Person("Fred", "100 bedrock st", "Bedrock",
           "BB1 2FF", 1912);

            Console.WriteLine("P1: " + p1 + "\n");
            Console.WriteLine("p2: " + p2 + "\n");
            Console.WriteLine("P3: " + p3 + "\n");
            Console.WriteLine("P4: " + p4 + "\n");

            Console.ReadLine();
        }


    }
}
