namespace RemovesNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    class RemovesNegativeNumbers
    {
        static void Main()
        {
            int[] arr = new int[] { 19, -10, 12, -6, -3, 34, -2, 5 };
            List<int> numberSequence = new List<int>();
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] >= 0)
                {
                    numberSequence.Add(arr[i]);
                }
            }

            foreach (var number in numberSequence)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
