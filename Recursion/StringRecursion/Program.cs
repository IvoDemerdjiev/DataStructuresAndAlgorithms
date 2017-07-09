using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRecursion
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
            for (int i = start; i <= words.Length-1; i++)
            {
                vector[index] = i;
                Rec(vector, index - 1, i+1);
            }
        }

        private static void PrintArray(int[] vector)
        {
            foreach (var i in vector)
            {
                Console.Write("{0} ",words[i]);
            }
            Console.WriteLine();
        }
        static int k = 2;
        static string[] words = {"test", "rock", "fun"};
        static void Main()
        {
                int[] vector = new int[k];
                Rec(vector, k - 1, 0);
        }
    }
}
