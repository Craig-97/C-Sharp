using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class KeyTorpedo
    {
        private KeyTorpedoState keyState = KeyTorpedoState.keyOut;
        private readonly Random rndNo = new Random(DateTime.Now.Millisecond);

        [ContractInvariantMethod]
        private void Invariant()
        {
            Contract.Invariant(rndNo != null);
            Contract.Invariant(Enum.IsDefined(typeof(KeyTorpedoState), keyState));
        }

        public KeyTorpedoState getKeyState()
        {
            int num = rndNo.Next(2);
            if (num == 1)
            {
                keyState = KeyTorpedoState.keyOut;
                Console.WriteLine("Key is withdrawn, torpedos unable to fire ");
            }
            else
            {
                keyState = KeyTorpedoState.keyIn;
                Console.WriteLine("Key is inserted, torpedos ready to fire");
            }
            return keyState;
        }
    }
}
