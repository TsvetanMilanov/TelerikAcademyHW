namespace ProductsSearch
{
    using System;
    using System.Linq;
    using System.Text;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private static OrderedMultiDictionary<int, string> products = new OrderedMultiDictionary<int, string>(true);

        public static void Main()
        {
            StringBuilder consoleResult = new StringBuilder();

            Console.WriteLine("Adding products...");
            for (int i = 0; i < 500000; i++)
            {
                products.Add(RandomDataGenerator.GetRandomNumberInRange(0, 100000), RandomDataGenerator.GetRandomString(1, 5));
            }

            Console.WriteLine("Starting the search test...");
            for (int i = 0; i < 10000; i++)
            {
                int minValue = RandomDataGenerator.GetRandomNumberInRange(0 + i, 5 + i);
                int maxValue = RandomDataGenerator.GetRandomNumberInRange(minValue, minValue + 5 + i);

                consoleResult.AppendLine(string.Format("Results for price between: {0} and {1}", minValue, maxValue));

                products.Range(minValue, true, maxValue, false)
                    .Take(20)
                    .ToList()
                    .ForEach(pair =>
                    {
                        foreach (var item in pair.Value)
                        {
                            consoleResult.AppendLine(string.Format("{0} -> {1}", item, pair.Key));
                        }
                    });
            }

            Console.WriteLine(consoleResult.ToString());
        }
    }
}
