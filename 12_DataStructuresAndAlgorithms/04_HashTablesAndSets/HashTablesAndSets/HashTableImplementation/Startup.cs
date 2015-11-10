namespace HashTableImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";

            var table = new HashTable<string, int>();

            for (int i = 0; i < 800; i++)
            {
                table.Add(letters[i % (letters.Length - 1)].ToString() + i, i);
            }

            Console.WriteLine("Element with key \"f498\" has value: {0}", table.Find("f498"));
            Console.WriteLine("Count: {0}", table.Count);
            table.Remove("f498");
            Console.WriteLine("Element with key \"f498\" after it has been removed has value: {0}", table.Find("f498"));
            Console.WriteLine("Count after removing 1 item: {0}", table.Count);
            Console.WriteLine("Element at table[\"W715\"] has value: {0}", table["W715"]);
            table["W715"] = 7;
            Console.WriteLine("Element at table[\"W715\"] after it's value has been changed has value: {0}", table["W715"]);

            Console.WriteLine("Keys:");
            Console.WriteLine(string.Join(", ", table.Keys));

            foreach (var pair in table)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
