using System;

namespace ToUnicode
{
    internal class Program
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
        
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char symbol in input)
            {
                Console.Write(GetEscapeSequence(symbol));
            }
        }
    }
}