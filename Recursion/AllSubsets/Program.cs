using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSubsets
{
    class Program
    {
        static void Rec(int[] vector, int index, int start)
        {
            if (index == -1)
            {
                PrintArray(vector);
                return;
            }
            for (int i = start; i <= words.Length - 1; i++)
            {
                vector[index] = i;
                Rec(vector, index - 1, i + 1);
            }
        }

        private static void PrintArray(int[] vector)
        {
            Console.Write("(");
            foreach (var i in vector)
            {
                Console.Write("{0},", words[i]);
            }
            Console.WriteLine(")");
        }
        static int k = 3;
        static string[] words = { "test", "rock", "fun" };
        static void Main()
        {
            for (int i = 1; i <= k; i++)
            {
                int[] vector = new int[i];
                Rec(vector, i - 1, 0);
            }
        }
    }
}
