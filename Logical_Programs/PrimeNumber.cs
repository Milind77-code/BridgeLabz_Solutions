using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PrimeNumber
    {

        public void getPrimeNumber()
        {
            int num, i, ctr, stno, enno;


            Console.WriteLine(" Find the prime numbers within a range of numbers  ");
            Console.WriteLine("---------------------------------------------------");


            Console.Write("Enter starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }
    }
}
