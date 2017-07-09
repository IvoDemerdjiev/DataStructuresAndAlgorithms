using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinetions
{
    class Program
    {
        static void Rec(int[] array, int index, int start)
        {
            if (index==-1)
            {
                PrintArray(array);
                return;
            }
            for (int i = start; i <=n; i++)
            {
                array[index] = i;
                Rec(array, index - 1, i);
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
        static int n = 3;
        static int k = 2;
        static int  start= 1;
        static int[] array = new int[k];
        static void Main()
        {
            Rec(array, k-1 , start);
        }
    }
}
