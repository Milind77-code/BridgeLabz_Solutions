using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class LeapYear
    {
        public static void getLeapYear()
        {
            //variable
            int n;
            Console.WriteLine("Welcome to Leap Year Program");
            Console.WriteLine("-------------------------------");
            //Taking Input
            Console.Write("Enter a year :- ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1000 || n > 9999)
                Console.WriteLine("Please Enter a Valid Year ");
            else
                Console.WriteLine("Valid Year " + n);
            Boolean leap = false;
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                        leap = true;
                    else
                        leap = false;
                }
                else
                    leap = true;
            }
            else
                leap = false;

            if (leap)
                Console.WriteLine("The Given Year is a Leap Year :- " + n);
            else
                Console.WriteLine("The Given Year is Not a Leap Year :- " + n);
        }
    }
}
