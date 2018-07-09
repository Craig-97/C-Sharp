using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    /// Project Name:       QueueADT
    /// Date Started:       11/11/2015
    /// Date Finished:      07/12/2015
    /// Developer :         Craig Baxter
    /// <summary>
    /// This interface is for a queue system
    /// allows for the queue to be joined
    /// allows for the queue to be left
    /// can find the size of the queue
    /// can check if the queue is empty
    /// </summary>
    interface QueueADT
    {
        /// <summary>
        /// adds a value to a queue 
        /// </summary>
        /// <param name="value">value</param>
        void join(int value);
        
        /// <summary>
        /// remove and return value from the queue 
        /// </summary>
        /// <returns>returns value removed from queue</returns>
        int leave (); 
        
        /// <summary>
        /// returns true if the queue is empty 
        /// </summary>
        /// <returns>true if queue is empty, false if not</returns>
        bool isEmpty();
        
        /// <summary>
        /// returns number of items in queue 
        /// </summary>
        /// <returns>size of queue</returns>
        int size();	

    }
}
