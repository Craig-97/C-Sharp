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
            //IntegerLinkedList mylist = new IntegerLinkedList();
            //mylist.addFirst(12);
            //mylist.addFirst(6);
            //mylist.addLast(5);
            //mylist.addFirst(68);
            //int valueRemoved = 0;
            //try
            //{
            //    valueRemoved = mylist.removeLast();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("empty" + ex.Message);
            //}

            //Console.WriteLine("Value: " + valueRemoved);
            //mylist.addFirst(12);
            //mylist.removeLast();
            //mylist.removeFirst();       
            //valueRemoved = mylist.removeLast();

            //mylist.DisplayUI();


            //Console.WriteLine("is empty when Empty" + mylist.isEmpty());

            //Console.WriteLine("the number in the list is:" + IntegerLinkedList(start));


            //Console.ReadLine();
            queueDriver();

        }

        static void queueDriver()
        {
            MyLinkedQueue aQueue = new MyLinkedQueue(5);
            Console.WriteLine("testing Queue ");
            Console.WriteLine("testing is empty " + aQueue.isEmpty());
            for (int i = 1; i < 6; i++)
                aQueue.join(i);
            Console.WriteLine("num values in queue: " + aQueue.size());
            aQueue.display();
            Console.WriteLine("removing value " + aQueue.leave());
            Console.WriteLine("value 1 should have been removed");
            aQueue.display();
            Console.ReadLine();
        }

    }
}
