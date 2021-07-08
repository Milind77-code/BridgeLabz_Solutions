using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---------Welcome to Logical Programs--------->");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Select one Option Between (1 - 10)");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" 01:- Fibonnaci Series \n 02:- Perfect Number \n 03:- Prime Number \n 04:- Reversre Number \n 05:- Coupon Number \n 06:- Stop-Watch");
            Console.WriteLine("-----------------------------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonnaciSeries fibonnaci = new FibonnaciSeries();
                    fibonnaci.printNumber();
                    break;

                case 2:
                    PerfectNumber number = new PerfectNumber();
                    number.perfectNumber();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.getPrimeNumber();
                    break;

                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.reverseNumber();
                    break;

                case 5:
                    CouponNumber coupon = new CouponNumber();
                    coupon.couponNumber();
                    break;

                case 6:
                    StopWatch.StopMain();
                    break;

                default:
                    Console.WriteLine("Choose a number between 1 to 10");
                    break;

            }
        }

    }
}
