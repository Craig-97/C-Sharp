using System;

namespace SubmarineControlSystem
{
    public class Program
    { 

        static void Main(string[] args)
        {
            //max depth is set to 100
            const int maxDepth = 100;
            SubControlSystem s = new SubControlSystem(maxDepth);
            //run 100 times to show varying outcomes
            for (int i = 0; i < 100; ++i)
            {
                if (i < 100)
                {
                    s.operate();
                }
            }
            Console.ReadLine();
        }
    }
}
