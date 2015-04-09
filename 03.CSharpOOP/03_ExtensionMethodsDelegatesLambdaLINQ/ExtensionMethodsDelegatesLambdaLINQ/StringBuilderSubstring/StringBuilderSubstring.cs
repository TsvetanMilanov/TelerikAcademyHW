namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public class StringBuilderSubstring
    {
        public static void Main(string[] args)
        {
            /// Automatic test:

            /// StringBuilder test = new StringBuilder("0123456789");

            /// StringBuilder result = test.Substring(2, 5);

            /// Console.WriteLine("The test StringBuilder is: {0}\nThe result StringBuilder from index 2 with length 5 is: {1} ", test.ToString(), result.ToString());

            Console.Write("Enter the StringBuilder: ");
            StringBuilder test = new StringBuilder(Console.ReadLine()); 

            Console.Write("Enter the start index: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());

            StringBuilder result = test.Substring(index, length);

            Console.WriteLine("The test StringBuilder is: {0}\nThe result StringBuilder from index {1} with length {2} is: {3} ", test.ToString(), index, length, result.ToString());
        }
    }
}
