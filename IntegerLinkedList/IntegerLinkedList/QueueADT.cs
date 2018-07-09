using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList 

{
    interface QueueADT
    {
        void join(int value);//adds a value to a queue 
        int leave (); 	//remove and return value from the queue 
        bool isEmpty(); //returns true if the queue is empty 
        int size();	//returns number of items in queue 

    }
}
