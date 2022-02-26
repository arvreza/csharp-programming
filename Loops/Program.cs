using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // from 1 to 100, print the number
            // if the number is multiply by 5 then print hop

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("Hop ");
                }
                else 
                {
                    Console.Write ($"{i} ");
                }
            }
        }
    }
}
