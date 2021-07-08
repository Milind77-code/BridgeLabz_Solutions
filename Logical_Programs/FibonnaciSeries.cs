using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
	class FibonnaciSeries
	{
		public static int FindFibonacci(int n)
		{

			//variables
			int p = 0;
			int q = 1;
			for (int i = 0; i < n; i++)
			{
				int temp = p;
				p = q;
				q = temp + q;
			}
			return p;

		}

		public void printNumber()
		{
			Console.WriteLine("          The Fibonacci numbers for a n numbers of series              ");
			Console.WriteLine("-----------------------------------------------------------------------");

			Console.Write("Enter number of terms for the Fibonacci series :-  ");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("The Fibonacci series of {0} terms is :- ", n1);
			for (int i = 0; i < n1; i++)
			{
				Console.Write("{0} ", FindFibonacci(i));
			}
		}

	}
}
