using System;
using System.Collections.Generic;
using System.Linq;

namespace library
{
    public class Fibonacci
    {
        public static List<int> First (int n)
        {
            List<int> FibonacciNumbers = new List<int>();
            FibonacciNumbers.Add(1);
            FibonacciNumbers.Add(2);
            foreach (int index in Enumerable.Range(2, n).ToArray())
            {
                FibonacciNumbers.Add(FibonacciNumbers[index-1]+FibonacciNumbers[index-2]);
            }
            return FibonacciNumbers;

        }
    }
}