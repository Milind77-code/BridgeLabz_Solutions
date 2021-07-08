using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------Welcome to N_Unit_Testing_Programs---------->");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Select a Number betwwen (1 - 7)");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(" 01:- Vending Machine \n 02:- Day Of Week \n 03:- Temperature Conversion \n 04:- Monthly Payment \n 05:- Sqrt \n 06:- Binary \n 07:- Binary Swap Nibble");
            Console.WriteLine("--------------------------------------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Amount transaction:-");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    VendingMachine.countCurrency(amt);
                    break;

                case 2:
                    DayOfWeek.checkday();
                    break;

                case 3:
                    TemperatureConversion.Conversion();
                    break;

                case 4:
                    MonthlyPayment.Payment();
                    break;

                case 5:
                    Sqrt.Root();
                    break;

                case 6:
                    Console.WriteLine("Enter number:-");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Binary.DecToBinary(num);
                    break;

                case 7:
                    BinarySwapNibble.SwapNibble(6);
                    break;

                default:
                    Console.WriteLine("Choose a Number between 1 to 7");
                    break;

            }
        }
    }
}
