using  System;
using System.Collections;
using System.Collections.Generic;
using  System.Numerics;
namespace FromBase10ToBaseN
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string[] input = Console.ReadLine().Split(' ');
            int baseNum = Int32.Parse(input[0]);
            BigInteger decNumber = BigInteger.Parse(input[1]);
            while (decNumber>0)
            {
                int rem = (int)(decNumber % baseNum);
                stack.Push(rem);
                decNumber /= baseNum;
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}