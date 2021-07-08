using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--------Welcome to Basic_Core_Programs-------->");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Choose your option  (1 - 10)");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" 01:- Flip Coin \n 02:- Leap Year \n 03:- Power Of 2 \n 04:- Harmonic Numbers \n 05:- Prime Factor \n 06:- Quotient Remainder \n 07:- Swap Numbers \n 08:- Even Odd \n 09:- Vowel Consonants \n 10:- Largest Among 3   ");
            Console.WriteLine("------------------------------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin.getFlipCoin();
                    break;

                case 2:
                    LeapYear.getLeapYear();
                    break;
                case 3:

                    PowerOf2.getPowerOf2();
                    break;

                case 4:
                    Harmonic_Numbers.getHarmonicNumber();
                    break;

                case 5:
                    PrimeFactor.getPrimeFactor();
                    break;

                case 6:
                    QuotientRemainder.getQuotientRemainder();
                    break;

                case 7:
                    SwapNumbers.getSwapNumber();
                    break;
                case 8:
                    EvenOdd.getEvenOdd();
                    break;

                case 9:
                    VowelConsonants.getVowelConsonents();
                    break;

                case 10:
                    LargestAmong3.getLargestAmong3();
                    break;

                default:
                    Console.WriteLine("Choose a number between 1 to 10");
                    break;
            }
        }
    }
}
