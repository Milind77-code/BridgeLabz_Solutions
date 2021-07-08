using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class Binary
    {
        public static void DecToBinary(int n)
        {
            Console.WriteLine("Enter number:-");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] binaryNum = new int[num];
            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNum[j]);
            }
        }
    }
}
