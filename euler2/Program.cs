using System;
using System.Collections.Generic;
using library;
using System.Linq;

namespace euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Fibs = Fibonacci.NoGreaterThan(4000000);
            List<int> result = new List<int>();
            foreach (int number in Fibs)
            {
                if (!Tests.IsOdd(number))
                {
                    result.Add(number);
                }
            }
            int sum = result.Sum();
            Console.Write($"The sum of all even Fibonacci numbers less than 4 million is {sum}");
        }
    }
}
