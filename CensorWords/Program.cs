using System;

namespace CensorWords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] censorWords = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            foreach (var word in censorWords)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}