using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {',', ' ', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in input)
            {
                char[] rev_char = word.ToCharArray();
                Array.Reverse(rev_char);
                if (word == new string(rev_char))
                {
                    palindromes.Add(word);
                }
            }

            var sorted = palindromes.OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}