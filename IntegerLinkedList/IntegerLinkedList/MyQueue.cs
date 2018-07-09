using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// Project Name:       MyQueue
    /// Date Started:       11/11/2015
    /// Date Finished:      07/12/2015
    /// Developer :         Craig Baxter
    /// <summary>
    /// Can check the capacity of the queue
    /// Can join the queue
    /// Can leave the queue
    /// Can check if queue is empty
    /// Can check the size of the queue
    /// Can display the queue
    /// </summary>
    class MyLinkedQueue : QueueADT
    {

        private IntegerLinkedList myList;

        public MyLinkedQueue(int capacity)
        {
            myList = new IntegerLinkedList();
        }
        public void join(int value)
        {
            myList.addLast(value);
        }

        public int leave()
        {
            return myList.removeFirst();
        }

        public bool isEmpty()
        {
            return myList.isEmpty();
        }

        public int size()
        {
            return myList.Capacity;
        }

        //public bool isFull()
        //{
        //    return myList.isFull();
        //}

        public void display()
        {
            myList.displayUI();
        }
    }
}