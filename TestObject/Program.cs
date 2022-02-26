using System;

namespace TestObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 1, Y = 2};

            Point p2 = new Point();
            p2.X = 1;
            p2.Y = 2;

            Point p3 = p1;

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());

            Console.WriteLine($"{p1.GetHashCode()}");
            Console.WriteLine($"{p2.GetHashCode()}");
            Console.WriteLine($"{p3.GetHashCode()}");
        }
    }
}
