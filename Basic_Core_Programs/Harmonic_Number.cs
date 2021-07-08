using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class Harmonic_Numbers
    {
        public static void getHarmonicNumber()
        {
            //variable
            int N;
            double i, h = 0;

            Console.WriteLine("Calculate the Harmonic series and their sum");
            Console.WriteLine("-------------------------------------------");

            //Taking input
            Console.Write("Enter a Number :- ");
            N = Convert.ToInt32(Console.ReadLine());

            //Process
            for (i = 1; i <= N; i++)
            {
                Console.Write("1/{0} + ", i);
                h = h + 1 / i;
            }
            Console.WriteLine("Sum of HArmonic no is :- " + h);
        }
    }
}
