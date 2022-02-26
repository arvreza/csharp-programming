using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.ForEach(InitArray(0), Console.WriteLine);
        }

        static int[] BiggerSum(int[] input1, int[] input2)
        {
            int input1Sum = input1[0] + input1[1];
            int input2Sum = input2[0] + input2[1];

            return input1Sum > input2Sum ? input1 : input2;
        }

        static int[] Reverse(int[] input)
        {
            if (input.Length != 3)
            {
                Console.WriteLine($"The size must be 3. The input array size is {input.Length}");
                return new int[0]; 
            }

            int[] output = new int[3];
            output[0] = input[2];
            output[1] = input[1];
            output[2] = input[0];

            return output;
        }

        static int[] InitArray(int n)
        {
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                output[i] = i;
            }

            return output;
        }        
    }
}
