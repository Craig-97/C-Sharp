using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class OxygenMonitor
    {
        private readonly Random rndNo = new Random(DateTime.Now.Millisecond);

        [ContractInvariantMethod]
        // Only validates whether the local variable current enum value is within the valid range -> dosen't check that it is of the right type
        private void Invariant()
        {
            Contract.Invariant(rndNo != null);
        }

        public OxygenState getOxygenLevel()
        {
            OxygenState oxygenState;
            int num = rndNo.Next(2);
            if (num == 1)
            {
                oxygenState = OxygenState.highOxygen;
                Console.WriteLine("Oxygen levels are fine");
            }
            else
            {
                oxygenState = OxygenState.lowOxygen;
                Console.WriteLine("Oxygen levels are low, resurfacing");
            }
            return oxygenState;
        }
    }
}
