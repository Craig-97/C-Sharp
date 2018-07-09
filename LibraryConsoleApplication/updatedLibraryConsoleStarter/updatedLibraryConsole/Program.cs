using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace SimpleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //unitTestMember();
            //unitTestLibraryMembers();
            testStock();
        }

        static void unitTestMember()
        {
            //create 2 new members
            Member mem1 = new Member("Fred", "Winlock street", "Wishaw", "ML2ABC", 1923, 10);
            Member mem2 = new Member();
            Console.WriteLine("testing ToString method");
            Console.WriteLine("Expected Output: ID: 10\tFred");
            Console.WriteLine("Actual   Output: " + mem1);
            Console.WriteLine("Expected Output: ID: 0\tno name");
            Console.WriteLine("Actual   Output: " + mem2);
            Console.WriteLine();
            Console.WriteLine("Testing inherited properties to check base attributes");
            Console.WriteLine("expected output ");
            Console.WriteLine("Name: Fred");
            Console.WriteLine("Year: 1923");
            Console.WriteLine("Address: Winlock Street\nWishaw\nML2ABC");
            Console.WriteLine("Actual output ");
            Console.WriteLine("Name: " + mem1.Name);
            Console.WriteLine("Year: " + mem1.Year);
            Console.WriteLine("Address: " + mem1.Address);

            Console.ReadLine();
        }

        static void unitTestLibraryMembers()
        {
            Library theLibrary = new Library();
            theLibrary.addMember("Fred", 1923, "Winlock street", "Wishaw", "ML2ABC");
            theLibrary.addMember("Barney", 1925, "Barnaby street", "Wishaw", "ML1ABC");
            theLibrary.addMember("Wilma", 1926, "Winlock street", "Wishaw", "ML2ABC");
            theLibrary.addMember("Thelma", 1927, "Barnaby street", "Wishaw", "ML1ABC");

            Console.WriteLine("testing getMembers - should have 4 members");
            Console.WriteLine("1: Fred\n2: Barney\n3: Wilma\n4: Thelma");
            Console.WriteLine("Actual output");
            Console.WriteLine(theLibrary.getMembers());

            Console.ReadLine();
        }

        static void testStock()
        {
            Stock stock1 = new Stock(2, "book");
            Stock stock2 = new Stock(3, "book2");
            Console.WriteLine(stock1.ToString() + "\n");
            Console.WriteLine(stock2.ToString() + "\n");
            Console.ReadLine();

        }
    }
}
