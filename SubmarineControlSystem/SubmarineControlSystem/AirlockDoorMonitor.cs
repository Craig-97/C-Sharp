using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class AirlockDoorMonitor
    {
        private readonly Random rndNo = new Random(DateTime.Now.Millisecond);

        [ContractInvariantMethod]
        // Only validates whether the local variable current enum value is within the valid range -> dosen't check that it is of the right type
        private void Invariant()
        {
            Contract.Invariant(rndNo != null);
        }

        public AirlockDoorState getDoorState()
        {
            AirlockDoorState doorState;
            int num = rndNo.Next(2);
            if (num == 1 || num == 2)
            {
                doorState = AirlockDoorState.oneClosed;
                Console.WriteLine("1 or more airlock door is closed, submarine can start");
            }
            else
            {
                doorState = AirlockDoorState.noneClosed; ;
                Console.WriteLine("No airlock doors are closed, submarine can't start");
            }
            return doorState;
        }
    }
}
