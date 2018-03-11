using System;

namespace SubstringCount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(substring);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(substring, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}