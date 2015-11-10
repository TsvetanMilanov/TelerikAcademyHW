namespace BiDictionary
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            BiDictionary<int, string, int> biDictionary = new BiDictionary<int, string, int>();

            AddRandomValues(biDictionary);

            var firstSearchResult = biDictionary.Find(3);
            var secondSearchResult = biDictionary.Find("Key #" + 2);
            var thirdResult = biDictionary.Find(2, "Key #" + 2);

            PrintResults(firstSearchResult);
            PrintResults(secondSearchResult);
            PrintResults(thirdResult);
        }

        private static void AddRandomValues(BiDictionary<int, string, int> biDictionary)
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    biDictionary.Add(i, i);
                }
                else if (i % 3 == 1)
                {
                    biDictionary.Add("Key #" + i, i);
                }
                else
                {
                    biDictionary.Add(i, "Key #" + i, i);
                }
            }
        }

        private static void PrintResults<T>(List<T> results)
        {
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
