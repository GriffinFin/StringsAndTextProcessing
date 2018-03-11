using System;
using System.Linq;

namespace Reverse_String
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(string.Join("", input));
        }
    }
}