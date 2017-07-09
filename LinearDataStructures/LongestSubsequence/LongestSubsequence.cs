namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    class LongestSubsequence
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 1};
            List<int> numberSequence = new List<int>(arr);
            int len = numberSequence.Count;
            int mostFrequentNumber = 0;
            int repetitionTimes = 1;
            int mostRepetitionTimes = 0;

            for (int i = 1; i < len; i++)
            {
                if (numberSequence[i-1] == numberSequence[i])
                {
                    repetitionTimes++;
                    if (mostRepetitionTimes < repetitionTimes)
                    {
                        mostRepetitionTimes = repetitionTimes;
                        mostFrequentNumber = numberSequence[i];
                    }
                }
                else
                {
                    repetitionTimes = 1;
                }
            }

            List<int> numberSubsequence = new List<int>();

            for (int i = 0; i < mostRepetitionTimes; i++)
            {
                numberSubsequence.Add(mostFrequentNumber);
            }

            Console.Write("{");

            for (int i = 0; i < numberSubsequence.Count-1; i++)
            {
                Console.Write(numberSubsequence[i] + ",");
            }

            Console.WriteLine(mostFrequentNumber + "}");
        }
    }
}
