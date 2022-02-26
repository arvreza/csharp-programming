using System;

namespace ValueTypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point1 is a value type and its value is (1, 1)
            MutablePoint point1 = new MutablePoint(1, 1);

            // Point2 is a value type and its value is (1, 1)
            MutablePoint point2 = point1;
            
            point2.Y = 200;

            Console.WriteLine($"{nameof(point1)} is {point1}");
            Console.WriteLine($"{nameof(point2)} is {point2}");

            PrintEnglishName(Season.Bahar);
            PrintEnglishName(Season.Tabestan);
            PrintEnglishName(Season.Paeez);
            PrintEnglishName(Season.Zemestan);

            int seasonNumber = 2;
            Season season = (Season)seasonNumber - 1;

            Console.WriteLine(season);

            (string, double) pi = ("PI", 3.14);
            Console.WriteLine($"The value of {pi.Item1} is {pi.Item2}");

            var t = 
                (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25, 26);

            Console.WriteLine(t.Item26);

            MutablePoint? nullPoint = null;
        
            Console.WriteLine(nullPoint);
        }

        static void PrintEnglishName(Season season)
        {
            switch (season)
            {
                case Season.Bahar:
                    Console.WriteLine("Spring");
                    break;
                case Season.Tabestan:
                    Console.WriteLine("Summer");
                    break;
                case Season.Paeez:
                    Console.WriteLine("Fall");
                    break;
                case Season.Zemestan:
                    Console.WriteLine("Winter");
                    break;
            }
        }
    }
}
