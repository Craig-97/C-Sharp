using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class RadarMonitor
    {
        private readonly Random rndNo = new Random(DateTime.Now.Millisecond);

        [ContractInvariantMethod]
        //Only validates whether the local variable current enum value is within the valid range -> dosen't check that it is of the right type
        private void Invariant()
        {
            Contract.Invariant(rndNo != null);

        }

        public RadarState getRadarLevel()
        {
            RadarState radarState;
            int num = rndNo.Next(2);
            if (num == 1)
            {
                radarState = RadarState.yesDetection;
                Console.WriteLine("There is another submarine within proximity radar");
            }
            else
            {
                radarState = RadarState.noDetection;
                Console.WriteLine("There are no submarines within proximity radar");
            }
            return radarState;
        }
    }
}
