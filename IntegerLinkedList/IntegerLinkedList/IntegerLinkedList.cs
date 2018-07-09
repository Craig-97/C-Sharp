using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// Project Name:       IntegerLinkedList
    /// Date Started:       11/11/2015
    /// Date Finished:      07/12/2015
    /// Developer :         Craig Baxter
    /// 
    /// Constructors
    /// (displayUI, isEmpty,addFirst,
    /// addLast, addLastR(recursive), public Node, addLastR(Node n)).
    /// 
    /// These two will throw an exception if the list is empty
    /// (removeFirst, removeLast).
    /// 
    /// There will be a private class named Node
    /// </summary>
    class IntegerLinkedList
    {
        /// <summary>
        /// start of linked list
        /// uses private class Node 
        /// </summary>
        private class Node
        {
            public int value { get; set; } // data in node
            public Node next { get; set; } // points to the next node in list

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="v"></param>
            public Node(int v)
            {
                value = v;
                next = null;
            }

            /// <summary>
            /// recursive method of add last
            /// </summary>
            /// <param name="n"></param>
            public void addLastR(Node n)
            {
                if (this.next == null)
                    this.next = n;
                else
                    this.next.addLastR(n);
            }


            internal void addLastR(int value)
            {
                throw new NotImplementedException();
            }
        }
        private int count; 	//how many numbers currently stored
        private Node start; // points to the start of the list
        private int size;

        /// <summary>
        /// IntegerLinkedList Class
        /// contains the created objects which 
        /// interact with the Linked List
        /// </summary>
        public IntegerLinkedList()
        {
            count = 0;
            start = null;
            size = 0;
        }
        /// <summary>
        /// created Object determines if the 
        /// list is empty so the program knows if
        /// an exception should be thrown
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            //return (start == null);
            if (start == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// This method creates a new node and 
        /// adds it to the beginning of the list
        /// </summary>
        /// <param name="value"></param>
        public void addFirst(int value)
        {
            Node n = new Node(value);//Creation of New Node.
            if (isEmpty())
            {
                start = n;
            }
            else
            {
                n.next = start; //new Link ---> old Start
                start = n; //Start ---> new Node
            }
            count++;
        }

        /// <summary>
        /// recursive method of add last
        /// </summary>
        /// <param name="value"></param>
        public void addLastR(int value)
        {
            Node n = new Node(value);
            if (start == null)
                start = n;
            else
                start.addLastR(value);
        }

        /// <summary>
        /// This method creates a new node and
        /// adds it to the end of the list
        /// </summary>
        /// <param name="value"></param>

        public void addLast(int value)
        {
            Node n = new Node(value);//Creation of New Node.
            n.value = value;
            if (isEmpty())
            {
                start = n;
            }
            else
            {
                Node prev = start;
                while (prev.next != null) // if the number of nodes does not equal 0 create new node at the last postion
                    prev = prev.next; //new Link ---> old end
                prev.next = n;//end --->new start



            }


            count++;
        }
        /// <summary>
        /// Removes the first node in the linked list
        /// </summary>
        /// <returns></returns>
        public int removeFirst()
        {
            int value;

            if (isEmpty())
                throw new Exception("List Is Empty");

            value = start.value;
            start = start.next;
            count--;
            return value;
        }
        /// <summary>
        /// Removes the Last node from the linked list
        /// but will throw an exception if the list is empty
        /// </summary>
        /// <returns></returns>
        public int removeLast()
        {
            int v = 0;

            if (isEmpty())
                throw new Exception("List Is Empty ");

            if (count == 1)
            {
                v = start.value;
                count--;
                start = null;

            }
            else
            {
                Node prev = start;
                Node current = start;
                while (current.next != null)
                {
                    prev = current;
                    current = current.next;
                }
                v = current.value;
                prev.next = null;
                count--;
            }

            return v;

        }

        public int Capacity { get { return size; } }
        /// <summary>
        /// displays the values of the node that have 
        /// been added to the linked list
        /// </summary>
        public void displayUI()
        {
            if (isEmpty())
            {
                Console.WriteLine("Empty list: " + start);
            }
            else
            {
                Console.Write("The Numbers in the linked list are: ");
                Node current = start;
                while (current != null)
                {
                    Console.Write(current.value + " ");
                    current = current.next;
                }
                Console.WriteLine("\nNumber of Entries: " + count);
            }
        }
    }
}// end of class
