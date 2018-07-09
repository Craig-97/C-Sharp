using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class MyStack : StackADT
    {
        private LinearArrayList mylist;

        public MyStack(int capacity)
        {
            mylist = new LinearArrayList(capacity);
        }

        public void push(int value)
        {
            mylist.addLast(value);
        }

        public int pop()
        {
            return mylist.removeLast();
        }

        public bool isFull()
        {
            return mylist.isFull();
        }
    }
}
