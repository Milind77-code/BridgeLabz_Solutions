using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
	public class QuotientRemainder
	{
		public static void getQuotientRemainder()
		{
			//Variables
			int x, y, q, r;
			Console.WriteLine("----Program to compute Quotient and Remainder----");
			Console.WriteLine("-------------------------------------------------");
			//Taking two numbers input
			Console.Write("Enter first number :-  ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second number :- ");
			y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("-------------------------------------------------");
			//Process
			q = x / y; //For Quotient
			r = x % y; //For Remainder

			//Display
			Console.WriteLine("Quotient is  :-  " + q);
			Console.WriteLine("Remainder is :-  " + r);

		}
	}
}
