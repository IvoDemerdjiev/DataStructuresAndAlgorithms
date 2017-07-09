using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Perm(int[] per,int k,int n)
        {
            if (k==n)
            {
                PrintArray(per);
                return;
            }
            else
            {
                for (int i = k; i <= n; i++)
                {
                    swap(ref per[k] ,ref per[i]);
                    Perm(per,k + 1,n);
                    swap(ref per[k], ref per[i]);

                }
            }
        }
        private static void PrintArray(int[] per)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write(" " + per[i]);
            }
            Console.WriteLine();
        }
        static  int k= 0;
        static int n = 2;
        static int[] vector = {1,2,3};
        static void Main()
        {
            Perm(vector, k,n);
        }
    }
}
