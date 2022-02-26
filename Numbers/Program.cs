using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadratic formula
            // ax^2 + bx + c = 0
            // x1 = (-b + sqrt(b^2-4*a*c))/ 2 * a
            // x2 = (-b - sqrt(b^2-4*a*c))/ 2 * a

            //3x^2 -2x - 8 = 0
            //x^2 +4x - 19 = 0
            //2321x^2 + 423x - 190 = 0

            double a = Math.Sqrt(4);
            Console.WriteLine(a);

            //area of circle A = pi * r^2
            //area of circle with r = 4
            //area of circle with r = 24
            Console.WriteLine(Math.PI);
        }
    }
}
