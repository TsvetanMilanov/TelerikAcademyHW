namespace NumberOccurrences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var array = new[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var occurrences = new Dictionary<double, int>();

            foreach (var number in array)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number] += 1;
                }
                else
                {
                    occurrences[number] = 1;
                }
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
