using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Logical_Programs
{
    class StopWatch
    {
        public static void StopMain()
        {
            int N;

            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("---Stop Watch Program---");
            Console.WriteLine("------------------------");
            Console.Write("Press 1 to start :- ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N == 1)
            {
                // Begin timing.
                stopwatch.Start();
            }
            Console.Write("Press 2 to Stop :- ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N == 2)
            {
                // Stop timing.
                stopwatch.Stop();
            }

            // Write result.
            Console.WriteLine("Time elapsed :- {0}", stopwatch.Elapsed);
        }
    }
}
