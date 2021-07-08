using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    public class ReverseNumber
    {
        public void reverseNumber()
        {
            int num, r, sum = 0, t;


            Console.WriteLine("  Display the number in reverse order  ");
            Console.WriteLine("---------------------------------------");



            Console.Write("Enter a number:- ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}
