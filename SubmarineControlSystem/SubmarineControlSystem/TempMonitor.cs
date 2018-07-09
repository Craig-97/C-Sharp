using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
     class TempMonitor
    {
        private readonly Random rndNo = new Random(DateTime.Now.Millisecond);

        [ContractInvariantMethod]
         //Only validates whether the local variable current enum value is within the valid range -> dosen't check that it is of the right type
        private void Invariant()
        {
            Contract.Invariant(rndNo != null);

        }

        public TempState getTempLevel()
        {
            TempState tempState;
            int num = rndNo.Next(2);
            if (num == 1)
            {
                tempState = TempState.highTemp;
                Console.WriteLine("Reactor temperature is too high, resurface immediately");
            }
            else
            {
                tempState = TempState.lowTemp;
                Console.WriteLine("Reactor temperature is acceptable");
            }
            return tempState;
        }
    }
}
