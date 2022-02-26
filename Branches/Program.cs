using System;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            // given a number
            //if the number is divisible by three then print Fizz
            //if the number is divisible by five then print Buzz
            //if the number is divisible by five "and" three print FizzBuzz
            //else print the number itself

            // 0 -> FizzBuzz
            // 1 -> 1
            //15 -> FizzBuzz
            //18 -> Fizz
            //25 -> Buzz
            
            int n = 25;

            // p        q       p&&q        P||q
            // T        T       T           T
            // T        F       F           T
            // F        T       F           T
            // F        F       F           F

            if (n%3 == 0 && n%5 == 0) 
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (n%3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n%5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(n);
            }

        }
    }
}
