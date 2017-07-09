namespace AscendingOrder
{
    using System;
    using System.Collections.Generic;

    class AscendingOrder
    {
        static void Main()
        {
            List<int> numSequence = new List<int>();
            int number = 0;
            bool isNumerical = true;

            do
            {
                isNumerical = int.TryParse(Console.ReadLine(), out number);
                if (isNumerical)
                {
                    numSequence.Add(number);
                }
            }
            while (isNumerical);

            numSequence.Sort();

            for (int i = 0; i < numSequence.Count; i++)
            {
                Console.WriteLine(numSequence[i]);
            }
        }
    }
}
