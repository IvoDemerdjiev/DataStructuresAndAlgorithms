namespace FiftyElementsOfSequence
{
    using System;
    using System.Collections.Generic;

    class FiftyElementsOfSequence
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            int n = 2;
            queue.Enqueue(n);

            while (queue.Count <= 50)
            {
                int a = n + 1;
                int b = 2 * n + 1;
                int c = n + 2;
                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);
                n = a;
            }

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }
    }
}
