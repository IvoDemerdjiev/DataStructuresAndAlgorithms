using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void NestedLoops(int[] array, int index)
        {
            if (index==-1)
            {
                PrintLoop(array);
                return;
            }
            else
            {
                for (int i = 1; i <=k ; i++)
                {
                    array[index] = i;
                    NestedLoops(array, index - 1);
                }
            }
        }

        private static void PrintLoop(int[] array)
        {
            for (int i = 0; i <n; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
        static int n =int.Parse(Console.ReadLine());
        static int k = n;
        static int[] array = new int[n];
        static void Main()
        {
            NestedLoops(array, n-1);
        }
    }
}
