using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class FlipCoin
    {
        public static void getFlipCoin()
        {
            //variable
            int n;
            int head = 0, Tail = 0;

            //Random Object Created
            Random r = new Random();
            Console.WriteLine(" Calculating Flip Coin Percentage ");
            Console.WriteLine("----------------------------------");

            //Taking input
            Console.Write("Enter No. of time To flip a coin :-");
            n = Convert.ToInt32(Console.ReadLine());

            //process
            for (int i = 0; i < n; i++)
            {
                int num = r.Next(1, 10);
                if (num > 5)
                {
                    head++;
                }
                else
                {
                    Tail++;
                }
            }
            Console.WriteLine($"The percentage of Head is : {(double)head * 100 / n}");
            Console.WriteLine($"The percentage of Tail is : {(double)Tail * 100 / n}");
        }

    }
}
