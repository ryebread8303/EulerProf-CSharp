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
            List<int> result = Fibonacci.First(10);
            foreach (int value in result)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
