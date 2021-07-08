using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class DayOfWeek
    {
        public static void checkday()
        {
            int d, m, y;
            Console.WriteLine("Enter date :");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month Number :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year :");
            y = Convert.ToInt32(Console.ReadLine());
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] Day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("It's " + Day[d0] + " on " + d + " " + month[m - 1] + ", " + y);
        }
    }
}
