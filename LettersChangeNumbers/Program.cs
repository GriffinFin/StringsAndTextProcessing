using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var s in input)
            {
                char[] letters = new[] {s[0], s[s.Length - 1]};
                Match m = Regex.Match(s, @"([A-Za-z])(\d+)([A-Za-z])");
                double num = double.Parse(m.Groups[2].ToString());
                if (char.IsLower(letters[0]))
                {
                    double pos = letters[0] - 96;
                    sum += num * pos;
                }
                else
                {
                    int pos = (int) letters[0] - 64;
                    sum += num / pos;
                }

                if (char.IsLower(letters[1]))
                {
                    int pos = (int) letters[1] - 96;
                    sum += pos;
                }
                else
                {
                    int pos = (int) letters[1] - 64;
                    sum -= pos;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}