using System;
using System.Collections.Generic;

namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 30;
            Console.WriteLine($"Fibonacci series till {size} is:");

            List<int> fibSeries = GenerateFibNumbers(size);
            
            foreach (int item in fibSeries)
            {
                Console.WriteLine(item);
            }
            
        }

        /*
            Fibonacci Series
            1, 1, 2, 3, 5, 8, 13, 21, ...
        */
        static List<int> GenerateFibNumbers(int size)
        {
            List<int> fib = new List<int> {1 , 1};

            while(fib.Count < size)
            {
                int prev1 = fib[fib.Count - 1];
                int prev2 = fib[fib.Count - 2];

                fib.Add(prev1 + prev2);
            }

            return fib;
        }
    }
}
