using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariationsWithRep
{
    class Program
    {
        static void Recursion(int[] array, int index)
        {
            if (index==-1)
            {
                PrintArray(array);
                return;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    Recursion(array, index - 1);
                }
            }
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(" " + array[i]); 
            }
            Console.WriteLine();
        }
        static  int k = 2;
        static  int n = 3;
        static int[] array = new int[k];
        static void Main()
        {
            Recursion(array, k-1);
        }
    }
}
