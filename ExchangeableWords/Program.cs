using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeableWords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<char> used = new List<char>();
            if (input[0].Length == input[1].Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    if (!used.Contains(input[0][i]))
                    {
                        input[1] = input[1].Replace(input[1][i], input[0][i]);
                        used.Add(input[0][i]);
                    }
                }

                if (input[0]==input[1])
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }                
            }
            else
            {
                List<char> dis1 = input[0].Distinct().ToList();
                List<char> dis2 = input[1].Distinct().ToList();
                if (dis1.Count == dis2.Count)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}