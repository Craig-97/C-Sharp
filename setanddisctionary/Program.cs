using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            testGenericList();
            //testSet();
            //testDictionary();//map in java
            //testSortedData();
            //testGenLinkedList();
            Console.ReadLine();
        }

       

        private static void testSortedData()
        {
            List<Student> mylist = new List<Student>();
            mylist.Add(new Student(1, "Fred","Flintstone"));
            mylist.Add(new Student(2, "Barney","Rubble"));
            mylist.Add(new Student(3, "Gill","Flintstone"));
            mylist.Add(new Student(4, "Dino","Rubble"));
            foreach (Student theStudent in mylist)
            {
                Console.WriteLine(theStudent.id + " " + theStudent.fname + " " + theStudent.lname);
            }
            mylist.Sort();
            Console.WriteLine("should now be soreted");
            foreach (Student theStudent in mylist)
            {
                Console.WriteLine(theStudent.id + " " + theStudent.fname);
            }
        }

        private static void testDictionary()
        {
            
		Dictionary<String, int> vehicles = new Dictionary<String, int>();
		
		// Add some vehicles.
		vehicles.Add("BMW", 5);
		vehicles.Add("Mercedes", 3);
		vehicles.Add("Audi", 4);
		vehicles.Add("Ford", 10);
		
		Console.WriteLine("Total vehicles: " + vehicles.Count);
		
		// Iterate over all vehicles.
		foreach (var pair in vehicles)
	    {
	        Console.WriteLine("{0}, {1}",
		    pair.Key,
		    pair.Value);
	    }
		Console.WriteLine();
		
		String searchKey = "BMW";
		if(vehicles.ContainsKey(searchKey))
			Console.WriteLine("Found " + vehicles[searchKey] + " "
					+ searchKey + " cars!\n");
		
		// Clear all values.
		vehicles.Clear();
		
		// Equals to zero.
		Console.WriteLine("After clear operation, Total vehicles: " + vehicles.Count);
	}
        

        private static void testSet()
        {
            HashSet<Student> class1 = new HashSet<Student>();
            HashSet<Student> class2 = new HashSet<Student>();
            Student stud1 = new Student(1, "Fred","Flintstone");
            Student stud2 = new Student(2, "Fred", "Flintstone");
            Student stud3 = new Student(3, "barney", "Flintstone");
            Student stud4 = new Student(4, "Wilma", "Flintstone");
            Student stud5 = new Student(1, "Fred", "Flintstone");
            Student stud6 = new Student(6, "Vera", "Flintstone");

            class1.Add(stud1);
            class1.Add(stud2);
            class1.Add(stud3);
            class1.Add(stud4);
            class1.Add(stud4);

            class2.Add(stud4);
            class2.Add(stud5);
            class2.Add(stud6);

            HashSet<Student> intersection = new HashSet<Student>(class1);
            HashSet<Student> union = new HashSet<Student>(class1);


            intersection.IntersectWith(class2);
            union.UnionWith(class2);
            Console.WriteLine("help");
        }

        private static void testGenericList()
        {
            List<Student> mylist = new List<Student>();
            mylist.Add(new Student(1, "Fred", "Flintstone"));
            mylist.Add(new Student(2, "Barney", "Flintstone"));
            mylist.Add(new Student(3, "Fred", "Rubble"));
            mylist.Add(new Student(4, "Dino", "Flintstone"));
            mylist.Add(new Student(5, "Fred", "Flintstone"));
            mylist.Sort();
           
            // View all of the students. 
            foreach (Student thisStudent in mylist)
            {
                Console.Write(thisStudent.id.ToString().PadRight(5) + " ");
                Console.Write(thisStudent.fname.ToString() + " " + thisStudent.lname.ToString());
                Console.WriteLine();
            }

            // LINQ Query.
            //C# specific
            var subset = from theStudent in mylist
                         where theStudent.fname == "Fred"
                         orderby theStudent.id
                         select theStudent;

            foreach (Student theStudent in subset)
            {
                Console.WriteLine(theStudent.id + " " + theStudent.fname + " " + theStudent.lname);
            }

        }

      

       
       
    }
}
