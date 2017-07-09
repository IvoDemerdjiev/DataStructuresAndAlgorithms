namespace OddCountOfTimes
{
    using System;
    using System.Collections.Generic;

    class OddCountOfTimes
    {
        static void CheckForEven(List<int> sequence)
        {
            int repeat = 0;
            int element = 1;

            do
            {
                repeat++;
                if (sequence[element - 1] != sequence[element] && repeat % 2 != 0)
                {
                    repeat = 0;
                    int number = sequence[element - 1];
                    sequence.RemoveAll(s => s == number);
                    element = 1;
                }
                else
                {
                    element++;
                }
            } while (sequence.Count > element);
        }

        static void Main()
        {
            int[] arr = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> numberSequence = new List<int>(arr);
            List<int> finalSequence = new List<int>();

            numberSequence.Sort();

            CheckForEven(numberSequence);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numberSequence.Count; j++)
                {
                    if (arr[i] == numberSequence[j])
                    {
                        finalSequence.Add(arr[i]);
                        break;
                    }
                }
            }

            Console.Write("{");
            foreach (var i in finalSequence)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine(" }");

        }
    }
}
