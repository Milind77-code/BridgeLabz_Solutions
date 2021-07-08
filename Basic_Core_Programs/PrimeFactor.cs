using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class PrimeFactor
    {
        public static void getPrimeFactor()
        {
            //Variables
            int a, b;
            //Taking Input
            Console.WriteLine("--Program To Find Prime Factors Of A Number--");
            Console.WriteLine("--------------------------------------------");
            Console.Write(" Enter a Number :- ");
            a = int.Parse(Console.ReadLine());
            //Logic For Printing prime factors of a
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of Number :- " + a);
                }
            }
        }
    }
}
