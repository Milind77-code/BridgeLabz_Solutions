using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class EvenOdd
    {
        public static void getEvenOdd()
        {
            //variables
            int num, rem;
            Console.WriteLine("----Check whether a number is even or odd----");
            Console.WriteLine("---------------------------------------------");

            //Taking Input
            Console.Write("Enter a Number :- ");
            num = Convert.ToInt32(Console.ReadLine());

            //Computing Remainder
            rem = num % 2;

            if (rem == 0)
                Console.WriteLine("{0} is an even Number", num);
            else
                Console.WriteLine("{0} is an odd Number", num);
        }
    }
}
