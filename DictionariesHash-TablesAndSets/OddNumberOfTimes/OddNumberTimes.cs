using System.Collections.Generic;
using System.Linq;

namespace OddNumberOfTimes
{
    using System;

    internal class OddNumberTimes
    {
        private static readonly int[] arr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };

        private static void Main(string[] args)
        {
            IDictionary<int, int> AllNumOccuarrences =
                GetNumberOfOccurrence(arr);

            var evenElements = EvenElementsKeys(AllNumOccuarrences);
            EvenElementsRemoved(evenElements,arr);
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

        private static List<int> EvenElementsKeys(
           IDictionary<int, int> numberOccurenceMap)
        {
            var OddNum = new List<int>();

            foreach (var number in numberOccurenceMap)
            {
                if (number.Value % 2 != 0)
                {
                    OddNum.Add(number.Key);
                }
            }
            return OddNum;
        }

        private static void EvenElementsRemoved(List<int> list,int[] arr)
        {
            foreach (var num in list)
            {
                arr = arr.Where(val => val != num).ToArray();
            }

            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length-1)
                {
                    Console.Write(arr[i] + ",");
                }
                else if(i == arr.Length-1)
                {
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine("}");
        }

    }
}
