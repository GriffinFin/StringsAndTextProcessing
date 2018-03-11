using System;

namespace ShakeItOff
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            bool canShake = true;           
            while (canShake)
            {
                int len = pattern.Length;
                if (len == 0)
                {
                    break;
                }
                int a = input.IndexOf(pattern);
                int b = input.LastIndexOf(pattern);
                if (a == -1 || b == -1)
                {
                    canShake = false;
                }
                else
                {
                    input = input.Remove(b, len);
                    input = input.Remove(a, len);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(len / 2, 1);
                    if (pattern.Length == 0)
                    {
                        canShake = false;
                        break;
                    }
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}