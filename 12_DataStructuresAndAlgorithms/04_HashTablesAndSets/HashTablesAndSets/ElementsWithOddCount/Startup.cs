namespace ElementsWithOddCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = new[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var occurrences = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word] += 1;
                }
                else
                {
                    occurrences[word] = 1;
                }
            }

            var keys = occurrences.Keys.ToList();

            foreach (var key in keys)
            {
                if (occurrences[key] % 2 == 0)
                {
                    occurrences.Remove(key);
                }
            }

            Console.WriteLine(string.Join(", ", occurrences.Keys));
        }
    }
}
