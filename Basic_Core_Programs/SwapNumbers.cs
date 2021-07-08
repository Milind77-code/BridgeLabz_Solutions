using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class SwapNumbers
    {
        public static void getSwapNumber()
        {
            //variable
            int n1, n2;
            Console.WriteLine("-------Swap Two Numbers-------");
            Console.WriteLine("------------------------------");
            //Taking 2 input numbers
            Console.Write("Enter the First Number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            n2 = int.Parse(Console.ReadLine());
            //Process
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("------------------------------");
            Console.WriteLine("--------After Swapping--------");
            Console.WriteLine(" First Number : " + n1);
            Console.WriteLine(" Second Number : " + n2);

        }
    }
}
