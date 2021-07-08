using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class MonthlyPayment
    {
        public static void Payment()
        {
            double P, R, Y;
            Console.WriteLine("Enter loan Amount:");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a year :");
            Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Intrest Rate:");
            R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payments = (P * r) / (1 - Math.Pow(1 + r, -n));
            double interest = payments * n - P;

            Console.WriteLine("Monthly payment is: " + payments);
            Console.WriteLine("Intrest rate is: " + interest);
        }
    }
}
