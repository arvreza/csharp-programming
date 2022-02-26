using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Reza";
            p.LastName = "Arbabi";
            p.DOB = new DateTime(1972, 1, 1);

            Console.WriteLine($"Name is {p.GetName()}, and age is {p.GetAge()}");
        }
    }
}
