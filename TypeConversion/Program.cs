using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Divident:");
            string dividentStr = Console.ReadLine();
            int divident = 0;

            if (!int.TryParse(dividentStr, out divident))
            {
                Console.WriteLine("Please enter a valid interger!");
                return;
            }
            
            Console.WriteLine("Enter a Divisor:");
            string divisorStr = Console.ReadLine();
            int divisor = 0;

            if (!int.TryParse(divisorStr, out divisor))
            {
                Console.WriteLine("Please enter a valid interger!");
                return;
            }

            if (divisor == 0)
            {
                Console.WriteLine("cannot divide by zero!");
                return;
            }

            Console.WriteLine($"Quotient is {divident / divisor}");
            Console.WriteLine($"Remainder is {divident % divisor}");
        }
    }
}
