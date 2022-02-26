using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String doost1 = "Arvin";
            String doost2 = "Roham";

            //Method 
            Console.WriteLine("Hello {0} and {1}", doost1.ToUpper(), doost2.ToLower());

            String value = "اهل کاشانم";
            Console.WriteLine(value.Contains("کاشان"));
            Console.WriteLine(value.Contains("tehran"));
        }
    }
}
