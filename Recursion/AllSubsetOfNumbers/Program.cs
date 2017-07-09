using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSubsetOfNumbers
{
    class Program
    {
        static void Rec(int[] vector, int index, int start, int n)
        {
            if (index == -1)
            {
                if (sum==n)
                {
                    PrintArray(vector);
                    sum *= 0;
                }
                else
                {
                    sum *= 0;
                }
               
                return;
            }
            for (int i = start; i <= numbers.Length - 1; i++)
            {
                vector[index] = i;
                sum += numbers[i];
                Rec(vector, index - 1, i + 1, n);
            }
        }

        private static void PrintArray(int[] vector)
        {
            foreach (var i in vector)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
        static int n = 4;
        static int sum = 0;
        static int[] numbers = { 2, 3, 1, 4 };
        static void Main()
        {
            for (int i = 1; i <= numbers.Length; i++)
            {
                int[] vector = new int[i];
                Rec(vector, i - 1, 0, n);
            }
        }
    }
}
