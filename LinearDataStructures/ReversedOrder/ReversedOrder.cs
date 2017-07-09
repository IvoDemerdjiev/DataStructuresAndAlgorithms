namespace ReversedOrder
{
    using System;
    using System.Collections.Generic;

    class ReversedOrder
    {
        static void Main()
        {
            Stack<int> inputNumbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                inputNumbers.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();

            while (inputNumbers.Count > 0)
            {
                int num = inputNumbers.Pop();
                Console.WriteLine(num);
            }
        }
    }
}
