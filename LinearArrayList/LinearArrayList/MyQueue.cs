using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
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
    public class MyQueue : QueueADT
    {
        private LinearArrayList mylist;

        /// <summary>
        /// Sets the size of the array
        /// using capacity as the value
        /// to be entered by user
        /// </summary>
        /// <param name="capacity"></param>
         public MyQueue(int capacity)
        {
            mylist = new LinearArrayList(capacity);
        }

        /// <summary>
        /// uses mylist addlast to
        /// add a value or "join" the list
        /// </summary>
        /// <param name="value"></param>
        public void join(int value)
        {
            mylist.addLast(value);
        }

        /// <summary>
        /// uses mylist remove last to
        /// remove a value or "leave" the list
        /// </summary>
        /// <returns></returns>
        public int leave()
        {
           return mylist.removeFirst();
        }

        /// <summary>
        /// uses mylist isEmpty to
        /// check and see if the list is empty
        /// will return true if empty and
        /// false if not empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return mylist.isEmpty();
        }

        /// <summary>
        /// returns the size of the list/array
        /// using the capacity method.
        /// </summary>
        /// <returns></returns>
        public int size()
        {
            return mylist.capacity;
        }

        /// <summary>
        /// Displays the queue of items 
        /// </summary>
        public void display()
        {
            mylist.displayUI();
        }
    }
}
