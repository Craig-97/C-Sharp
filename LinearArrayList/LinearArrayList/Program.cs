using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
          
            queueDriver();
            Console.ReadLine();
        }

        static void queueDriver ( ) 
        {
            MyQueue aQueue = new MyQueue(6);
            Console.WriteLine("testing Queue");
            Console.WriteLine("testing is empty " + aQueue.isEmpty());
            for (int i = 1; i < 6; i++)
                aQueue.join(i);
            Console.WriteLine("num values in queue: " + aQueue.size());
            aQueue.display();
            Console.WriteLine("removing value " + aQueue.leave());
            Console.WriteLine("value 1 should have been removed");
            aQueue.display(); 

        }

       

    }
}