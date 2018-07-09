using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class SubControlDashboard
    {
        public SubControlState lowOxygenLight { get; set; } = SubControlState.off;
        public SubControlState NoOxygen { get; set; } = SubControlState.off;
        public SubControlState subStartLight { get; set; } = SubControlState.off;
        public SubControlState temperature { get; set; } = SubControlState.off;
        public SubControlState depth { get; set; } = SubControlState.off;
        public SubControlState radar { get; set; } = SubControlState.off;

        private void Invariant()
        {
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), lowOxygenLight));
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), subStartLight));
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), temperature));
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), NoOxygen));
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), depth));
            Contract.Invariant(Enum.IsDefined(typeof(SubControlState), radar));

        }

        public void lowOxygenLightOn()
        {
            Contract.Ensures(lowOxygenLight == SubControlState.on);
            lowOxygenLight = SubControlState.on;
            Console.WriteLine("Low oxygen light is now on");
        }

        public void lowOxygenLightOff()
        {
           Contract.Ensures(lowOxygenLight == SubControlState.off);
            lowOxygenLight = SubControlState.off;
            Console.WriteLine("Low oxygen light is now off");
        }

        public void noOxygen()
        {
            Contract.Ensures(NoOxygen == SubControlState.on);
            NoOxygen = SubControlState.on;
            Console.WriteLine("No more oxygen, must resurface");
        }

        public void subStartlightOn()
        {
            Contract.Ensures(subStartLight == SubControlState.on);
            subStartLight = SubControlState.on;
            Console.WriteLine("Enough airlock doors are closed, submarine able to start");
        }

        public void subStartLightOff()
        {
            Contract.Ensures(subStartLight == SubControlState.off);
            subStartLight = SubControlState.off;
            Console.WriteLine("No airlock doors are shut, submarine can't start");
        }

        public void tempTooHigh()
        {
            Contract.Ensures(temperature == SubControlState.on);
            temperature =SubControlState.on;
            Console.WriteLine("Reactor temperature too high, resurface now");
        }

        public void tempOk()
        {
            Contract.Ensures(temperature == SubControlState.off);
            temperature = SubControlState.off;
            Console.WriteLine("Reactor Temperature is currently fine");
        }

        public void maxDepth()
        {
            Contract.Ensures(depth == SubControlState.on);
            depth = SubControlState.on;
            Console.WriteLine("Depth too low, reduce ballast tanks");
        }

        public void DepthOK()
        {
            Contract.Ensures(depth == SubControlState.off);
            depth = SubControlState.off;
            Console.WriteLine("Depth is acceptable");
        }

        public void radarDetection()
        {
            Contract.Ensures(radar == SubControlState.on);
            radar = SubControlState.on;
            Console.WriteLine("There is another submarine on the radar, take action");
        }

        public void radarNoDetection()
        {
            Contract.Ensures(radar == SubControlState.off);
            radar = SubControlState.off;
            Console.WriteLine("There are no submarines on the radar");
        }
    }
}
