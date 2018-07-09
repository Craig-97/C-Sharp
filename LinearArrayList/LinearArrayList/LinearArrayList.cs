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
    /// Can find max value in list
    /// Can check the capacity of the list
    /// Can check if list is full
    /// Can check if list is empty
    /// Can add and remove last in the last
    /// Can add and remove first in the list
    /// 
    /// Destroy the entire contents of the list
    /// Display the contents of the list
    /// Linear search through the list
    /// Selection sort to sort the list
    /// 
    /// </summary>
    public class LinearArrayList
    {
        private int count; //how many numbers currently stored	
        private int[] values; //array to hold values entered into list

        /// <summary>
        /// LinearArrayList
        /// </summary>
        /// <param name="max"></param>
        public LinearArrayList(int max)
        {
            values = new int[max];
            count = 0;
        }
        /// <summary>
        /// Capacity
        /// gets the length of the array 
        /// and sets capacity = to length of array
        /// </summary>
        public int capacity
        {
            get { return values.Length; }
        }

        /// <summary>
        /// isFull
        /// checks if the list is full
        /// returns true if list is full
        /// if list is not full, false is returned
        /// </summary>
        /// <returns></returns>
        public bool isFull()
        {
            if (count >= values.Length)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks if the list is empty
        /// then returns true if list is empty
        /// otherwise it returns false
        /// </summary>
        public bool isEmpty()
        {
            if (count <= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// addLast
        /// if list is full then exception is thrown
        /// will add the value entered 
        /// into the array at the last index
        /// </summary>
        /// <param name="value"></param>
        public void addLast(int value)
        {
            if (isFull())
                throw new Exception("no more space at the end of the array");
            values[count++] = value;
        }

        /// <summary>
        /// addFirst
        /// if the list is full then throw exception
        /// will add the value entered
        /// into the array at the first index
        /// </summary>
        /// <param name="value"></param>
        public void addFirst(int value)
        {
            if (isFull())
                throw new Exception("no more space in the array");

            for (int i = count; i > 0; i--)
            {
                values[i] = values[i-1];
            }

            values[0] = value;
            count++;
        }

        /// <summary>
        /// removeFirst
        /// if list is not empty, should remove and return first value in the list
        /// Throws exception if list is empty
        /// </summary>
        /// <returns>first value in the list</returns>
        public int removeFirst()
        {
            //if empty
            if (count == 0)
            {
                throw new Exception("List is empty");
            }
            int value = values[0];
            //iterate through every value in the list
            for (int i = 1; i < count; i++)
            {
                //swap down
                values[i - 1] = values[i];
            }
            //decrement count
            count--;
            return value;
        }
        /// <summary>
        /// removeLast
        /// if list is not empty, should remove and return last value in the list
        /// Throws exception if list is empty
        /// </summary>
        /// <returns>last value in the list</returns>
        public int removeLast()
        {
            if (isEmpty())
                throw new Exception("List is Empty");

            count--;
            return values[count];

        }

        /// <summary>
        /// destroy
        /// empties the array so it has no values left
        /// </summary>
        public void destroy()
        {
            values = null;
        }

        /// <summary>
        /// displayUI
        /// If list is empty then throw exception
        /// for each value in the array
        /// display the value on the console
        /// (displays every value in the array)
        /// </summary>
        public void displayUI()
        {
            if (isEmpty())
                throw new Exception("List Is Empty");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int LinearSearch(int value)
        {
            for (int i = 0; i < count; i++)
                if (value == values[i])
                    return i;
            return -1;
        }

        /// <summary>
        /// search
        /// set left to start of array and
        /// right to the end of the array
        /// searches a side of array based on entered value
        /// returns the position of the value if found
        /// if not found return -1
        /// </summary>
        public int Binarysearch(int value)
        {

            int left = 0; //our indices start at 0
            int right = count - 1; //last element

            while (left <= right)
            {
                int pos = (left + right) / 2; //half way through
                if (values[pos] == value)
                {
                    return pos;  //found so exit 
                }
                if (values[pos] < value)
                    left = pos + 1;  //need to search right hand side
                else
                    right = pos - 1; //need to search left hand side
            }

            return -1; //not found

        }

        /// <summary>
        /// sort
        /// 
        /// first finds the minimal value in the list of input data
        /// swaps it with the value in the first position
        /// then repeats this process advancing one position
        /// each time until the entire list is sorted
        /// </summary>
        public int[] Selectionsort()
        {
            int i, j, min, temp;
            for (i = 0; i < values.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < values.Length; j++)
                {
                    if (values[j] < values[min])
                    {
                        min = j;
                    }
                }
                temp = values[i];
                values[i] = values[min];
                values[min] = temp;
            }
            return values;

        }
    }
}
