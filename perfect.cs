﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class perfect
    {
        public static void Mnot()
        {
            int n, i, sum;
            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0} ", +i);
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}",+sum);
            if (sum == n)
                Console.WriteLine("So, the number is perfect.");
            else
                Console.WriteLine("So, the number is not perfect.");
            Console.WriteLine("");
        }
    }
}
