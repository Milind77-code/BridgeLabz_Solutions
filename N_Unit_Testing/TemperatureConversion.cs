using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class TemperatureConversion
    {
        public static void Conversion()
        {
            double fahrenheit, celsius;
            Console.Write("Eneter a Temp in celcius  :-  ");
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius    :- " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit :- " + fahrenheit);
            Console.WriteLine("--------------------------------");
            Console.Write("Eneter a Temp in Fahrenheit :- ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit :- " + Fahrenheit);

            celsius = (Fahrenheit * 9) / 5 + 32;
            Console.WriteLine("celsius    :- " + celsius);

        }
    }
}
