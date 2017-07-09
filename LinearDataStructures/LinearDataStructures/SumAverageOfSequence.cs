namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    class SumAverageOfSequence
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

            int len = numSequence.Count;
            int sum = 0;

            for (int i = 0; i < len; i++)
            {
                sum += numSequence[i];
            }

            double average = 0;

            average = ((double)sum / numSequence.Count);

            Console.WriteLine(sum);
            Console.WriteLine(average);

        }

    }
}
