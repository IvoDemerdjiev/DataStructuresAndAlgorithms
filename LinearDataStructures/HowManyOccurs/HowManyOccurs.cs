namespace HowManyOccurs
{
    using System;
    using System.Collections.Generic;

    class HowManyOccurs
    {
        static void Main()
        {
            int[] baseArr = new int[1001];
            int[] arr= new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 1001)
                {
                    int index = arr[i];
                    baseArr[index]++;
                }
            }

            for (int i = 0; i < baseArr.Length; i++)
            {
                if (baseArr[i] != 0)
                {
                    Console.WriteLine(i + " --> " + baseArr[i] + " times");
                }
            }
        }
    }
}
