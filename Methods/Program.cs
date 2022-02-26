using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello("Arvin");
            Hello("Roham");

            Console.WriteLine($"Area of circle with radius 2 is {CircleArea(2.0)}");
            Console.WriteLine($"Area of circle with radius 22 is {CircleArea(22.0)}");
            Console.WriteLine($"Area of circle with radius 10 is {CircleArea(10.0)}");
        }

        static void Hello(string name) 
        {
            Console.WriteLine($"Hello {name}!");
        }

        static double CircleArea(double radius) 
        {
            return Math.PI * radius * radius;
        }

    }
}
