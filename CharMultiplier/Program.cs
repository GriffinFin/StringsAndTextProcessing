using System;

namespace CharMultiplier
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < Math.Min(input[0].Length, input[1].Length); i++)
            {
                sum += input[1][i] * input[0][i];                
            }

            if (input[0].Length> input[1].Length)
            {
                for (int i = input[1].Length; i < input[0].Length; i++)
                {
                    sum += input[0][i];
                }
            }
            else if(input[1].Length > input[0].Length)
            {
                for (int i = input[0].Length; i < input[1].Length; i++)
                {
                    sum += input[1][i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}