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
            foreach (int index in Enumerable.Range(2, n-2).ToArray())
            {
                FibonacciNumbers.Add(FibonacciNumbers[index-1]+FibonacciNumbers[index-2]);
            }
            return FibonacciNumbers;

        }

        public static List<int> NoGreaterThan (int maximum)
        {
            List<int> FibonacciNumbers = new List<int>();
            FibonacciNumbers.Add(1);
            FibonacciNumbers.Add(2);
            int index = 2;
            int nextFib = 3;
            while (nextFib < maximum)
            {
            FibonacciNumbers.Add(nextFib);
            index += 1;
            nextFib = FibonacciNumbers[index-1]+FibonacciNumbers[index-2];
                
            }

            return FibonacciNumbers;

        }
    }
}