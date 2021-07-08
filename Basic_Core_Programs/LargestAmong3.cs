using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class LargestAmong3
    {
        public static void getLargestAmong3()
        {
            //Variable
            int num1, num2, num3;

            Console.WriteLine("----Find the largest of three numbers----");
            Console.WriteLine("-----------------------------------------");

            //Taking 3 Inputs
            Console.Write("Enter the 1st number  :- ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :- ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :- ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------------------------");
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three. ");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd Number is the greatest among three. ");
            else
                Console.WriteLine("The 3rd Number is the greatest among three. ");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
