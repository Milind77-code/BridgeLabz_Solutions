using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class CouponNumber
    {
        public void couponNumber()
        {
            //Created a Random object
            Random r = new Random();
            string couponNo = "";
            int Count = 0;
            int N;
            Console.WriteLine("Enter length of Coupon Number: ");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int ran = r.Next(0, 10);
                Count += 1;
                if (couponNo.Contains(ran.ToString()))
                {
                    i -= 1;
                }
                else
                {
                    couponNo += ran;
                }
                Console.WriteLine("Total Randoms needed:" + Count);
                Console.WriteLine("Coupon Code: " + couponNo);
            }
        }
    }
}
