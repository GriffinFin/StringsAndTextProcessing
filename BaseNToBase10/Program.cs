using System;
using System.Numerics;
namespace BaseNToBase10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            ulong decNum = 0;
            int baseNum = Int32.Parse(input[0]);
            long pow = input[1].Length - 1;
            foreach (char digit in input[1])
            {
                decNum += (ulong) ((int) (char.GetNumericValue(digit)) * Math.Pow(baseNum, pow));
                pow--;
            }

            Console.WriteLine(decNum);
        }
    }
}