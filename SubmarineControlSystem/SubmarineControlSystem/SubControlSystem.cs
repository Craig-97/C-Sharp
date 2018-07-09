using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    public class SubControlSystem
    {
        private readonly Controller controller;
        private readonly KeyTorpedo tKey;
        private readonly OxygenMonitor oMonitor;
        private readonly TempMonitor tMonitor;
        private readonly AirlockDoorMonitor dMonitor;
        private readonly RadarMonitor rMonitor;
        private readonly DepthMonitor depthMonitor;


        public SubControlSystem(int maxDepth)
        {
            Contract.Requires(maxDepth> 0);
            tKey= new KeyTorpedo();
            oMonitor = new OxygenMonitor();
            tMonitor = new TempMonitor();
            dMonitor= new AirlockDoorMonitor();
            rMonitor = new RadarMonitor();
            depthMonitor = new DepthMonitor(maxDepth);
            controller = new Controller(tKey, oMonitor, tMonitor, dMonitor, rMonitor, depthMonitor, maxDepth);
        }

        // Invariant
        [ContractInvariantMethod]
        private void Invariant()
        {
           // This is to help the CC check.  Ensure components aren't null
            Contract.Invariant(tKey != null);
            Contract.Invariant(oMonitor != null);
            Contract.Invariant(tMonitor != null);
            Contract.Invariant(dMonitor != null);
            Contract.Invariant(rMonitor != null);
            Contract.Invariant(depthMonitor != null);
        }

        public void operate()
        {
            Console.WriteLine("\n");
            controller.operateRandom();
        }
    }
}
