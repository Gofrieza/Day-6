using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class fibonaci
    {
		public static int FindFibonacci(int n)
		{
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

        static void Main()
		{
			Console.Write(" Input number of terms for the Fibonacci series : ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.Write("The Fibonacci series of  terms is : ", +num);
			for (int i = 0; i < num; i++)
			{
				Console.Write(" ", +FindFibonacci(i));
			}
			Console.ReadKey();
		}
	}
}
