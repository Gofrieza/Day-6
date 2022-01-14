using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Prime
    {
        public static void Mprime()
        {
            int num, i, ctr = 0;
            Console.WriteLine("Check whether a given number is prime or not");

            Console.WriteLine("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                Console.Write("Number is a prime number: " + num);
            else
                Console.Write("Number is not a prime number: " + num);
        }
    }
}