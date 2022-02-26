using System;
using System.Collections.Generic;

namespace CompositionTest
{
    /*
    create a list that every time we add a value to the list we add a counter
    and we expose the counter as a property to the caller. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            InstrumentedList list = new InstrumentedList();
            list.Add("Reza");
            list.RemoveAt(0);
            list.Add("Ramin");

            Console.WriteLine($"Number of times that the Add is called is {list.AddCounter}");
            Console.WriteLine($"List size is {list.Count}");
            Console.WriteLine($"First value is {list[0]}");
        }
    }
}
