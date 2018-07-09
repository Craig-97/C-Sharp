using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    interface StackADT
    {
        /// <summary>
        /// adds value to top of stack
        /// </summary>
        /// <param name="value">value to add</param>
        void push(int value);
        int pop();
    }
}
