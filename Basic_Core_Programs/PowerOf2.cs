using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class PowerOf2
    {
        public static void getPowerOf2()
        {
            //variable
            int pow;

            Console.WriteLine("---------Power of 2--------");
            Console.WriteLine("---------------------------");
            //Taking Input
            Console.Write("Enter the number (2 and 32) :- ");
            pow = Convert.ToInt32(Console.ReadLine());
            //Process
            int val = 1;
            if (pow < 32)
            {
                for (int i = 1; i <= pow; i++)
                {
                    val = val * 2;
                    Console.WriteLine(val);
                }
            }
            else
            {
                Console.WriteLine("Enter the correct input");
            }
        }

    }
}
