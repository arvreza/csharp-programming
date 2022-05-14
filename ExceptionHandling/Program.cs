using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte age;
                if (!byte.TryParse(args[0], out age))
                {
                    Console.WriteLine("Please add a valid number!");
                    return;
                }
                
                Console.WriteLine ($"Your age is {age}");
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"I failed to execute the program. {ex.Message}");
            }
        }
    }
}
