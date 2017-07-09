namespace DictionariesHash_TablesSets
{
    using System;
    using System.Collections.Generic;

    internal class NumberOccurrences
    {
        private static readonly int[] arr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        private static void Main()
        {
            IDictionary<int, int> numberOccurrenceMap =
                GetNumberOfOccurrence(arr);
            PrintNumberOccurrenceCount(numberOccurrenceMap);
        }

        private static IDictionary<int, int> GetNumberOfOccurrence(int[] arr)
        {
            IDictionary<int, int> numbers =
                new SortedDictionary<int, int>();

            foreach (int num in arr)
            {
                int count;
                if (!numbers.TryGetValue(num, out count))
                {
                    count = 0;
                }
                numbers[num] = count + 1;
            }

            return numbers;
        }

        private static void PrintNumberOccurrenceCount(
            IDictionary<int, int> numberOccurenceMap)
        {
            foreach (var numbers in numberOccurenceMap)
            {
                Console.WriteLine(
                    "{0} --> {1}",
                     numbers.Key, numbers.Value);
            }
        }
    }
}
