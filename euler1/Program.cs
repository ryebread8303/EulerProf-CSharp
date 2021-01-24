using System;
using System.Collections.Generic;
using library;
using System.Linq;
namespace euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            List<int> multiplesOfFive = new List<int>();
            List<int> multiplesOfThree = new List<int>();
            List<int> allmultiples = new List<int>();
            multiplesOfFive = Multiples.of(5,10);
            multiplesOfThree=Multiples.of(3,10);
            allmultiples = multiplesOfFive.Union(multiplesOfThree).Distinct().ToList();
            sum = allmultiples.Sum();
            Console.WriteLine($"The sum of all multiples of three or five less than 10 is {sum}");
            multiplesOfFive = Multiples.of(5,1000);
            multiplesOfThree=Multiples.of(3,1000);
            allmultiples = multiplesOfFive.Union(multiplesOfThree).Distinct().ToList();
            sum = allmultiples.Sum();
            Console.WriteLine($"The sum of all multiples of three or five less than 1000 is {sum}");
        }
    }
}
