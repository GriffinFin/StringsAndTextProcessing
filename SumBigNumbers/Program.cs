using System;
using System.CodeDom.Compiler;
using System.Linq;

namespace SumBigNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] input1 = Console.ReadLine().ToCharArray();
            char[] input2 = Console.ReadLine().ToCharArray();
            input1.Reverse();
            input2.Reverse();
            double rem = 0;
            string sum = "";
            for (int i = 0; i < Math.Max(input1.Length, input2.Length); i++)
            {
                double a = 0;
                double b = 0;
                try
                {
                    a = char.GetNumericValue(input1[i]);
                }
                catch (Exception e)
                {
                }

                try
                {
                    b = char.GetNumericValue(input2[i]);
                }
                catch (Exception e)
                {
                }
                double curr = a + b + rem;
                if (curr>9)
                {
                    rem = curr - 9;
                    curr -= 10;
                }

                sum += curr;
            }

            sum += rem;
            char[] answer = sum.ToCharArray();
            answer.Reverse();
            Console.WriteLine(string.Join("", answer));

        }
    }
}