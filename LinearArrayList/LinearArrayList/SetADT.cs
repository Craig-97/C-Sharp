using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{

    /// Project Name:       SetADT
    /// Date Started:       11/11/2015
    /// Date Finished:      07/12/2015
    /// Developer :         Craig Baxter
    /// <summary>
    /// Add an object to the set of numbers
    /// Remove objects from the set
    /// Can check the size of the set
    /// Can setup intersection and differences
    /// Can check if list is empty
    /// Can check size of list
    /// </summary>
    interface SetADT
    {
        /// <summary>
        /// Adds an object to the set. 
        /// </summary>
        /// <param name="o">object o</param>
        void add(Object o); 		
        
        /// <summary>
        ///  Removes object o from the set.
        /// </summary>
        /// <param name="o">object o</param>
        void remove(Object o); 
        
        /// <summary>
        /// sets this set to the intersection of itself and s.
        /// </summary>
        /// <param name="s"></param>
        void intersection(SetADT s);
        
        /// <summary>
        ///  sets this set to the difference between itself and s. 
        /// </summary>
        /// <param name="s"></param>
        void difference(SetADT s); 
        
        /// <summary>
        /// returns the number of objects in the set. 
        /// </summary>
        /// <returns>size of set</returns>
        int size(); 		
        
        /// <summary>
        /// returns true if Set is empty, else false. 
        /// </summary>
        /// <returns>true or false depending on list being empty or full</returns>
        bool isEmpty();

    }
}
