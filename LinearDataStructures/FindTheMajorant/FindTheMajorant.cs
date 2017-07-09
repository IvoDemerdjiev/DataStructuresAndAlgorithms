namespace FindTheMajorant
{
    using System;
    using System.Collections.Generic;

    class FindTheMajorant
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            List<int> numberSequence = new List<int>(arr);
            int mostFrequentNumber = 0;
            int len = 1;
            int biggestLen = 0;

            numberSequence.Sort();

            for (int i = 1; i < numberSequence.Count; i++)
            {
                if (numberSequence[i-1] == numberSequence[i])
                {
                    len++;
                    if (biggestLen < len)
                    {
                        biggestLen = len;
                        mostFrequentNumber = numberSequence[i];
                    }
                }
                else
                {
                    len = 1;
                }
            }

            int occurs = numberSequence.Count / 2 + 1;
            if (occurs <= biggestLen)
            {
                Console.WriteLine(mostFrequentNumber);
            }
            else
            {
                Console.WriteLine("The majorant does not exist!");
            }
        }
    }
}
