namespace EachWordInText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordInText
    {
        private static void Main(string[] args)
        {
            var text = FileInfo();
            IDictionary<string, int> wordOccurrenceMap =
                  GetWordOccurrenceMap(text);
            PrintWordOccurrenceCount(wordOccurrenceMap);
        }

        private static string FileInfo()
        {
            var text = File.ReadAllText(@"E:\C#\Tree\DictionariesHash-TablesSets\EachWordInText\Text.txt").ToLower();

            return text;
        }

        private static IDictionary<string, int> GetWordOccurrenceMap(
          string text)
        {

            var tokens =
                  text.Split(' ', '.', ',', '–', '?', '!');

            IDictionary<string, int> words =
                  new SortedDictionary<string, int>();

            foreach (var word in tokens)
            {
                if (string.IsNullOrEmpty(word.Trim()))
                {
                    continue;
                }

                int count;
                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
            return words;
        }

        private static void PrintWordOccurrenceCount(
           IDictionary<string, int> wordOccuranceMap)
        {
            var sorted = wordOccuranceMap.OrderBy(p => p.Value);

            foreach (KeyValuePair<string, int> wordEntry
                  in sorted)
            {
                Console.WriteLine(
                      "Word '{0}' occurs {1} time(s) in the text",
                      wordEntry.Key, wordEntry.Value);
            }

            Console.ReadKey();
        }
    }
}
