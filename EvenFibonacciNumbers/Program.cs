using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev = 1;
            int next = 2;
            int temp = 0;
            int sum = 0;

            while (next < 4000000)
            {
                if (next % 2 == 0)
                    sum += next;
                temp = prev + next;
                prev = next;
                next = temp;
            }

            Console.WriteLine("Even value sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
