namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestStringMain
    {
        public static void Main(string[] args)
        {
            string[] stringArray = { "12345", "123", "1234567", "1234", "12456" };

            var longestString = from item in stringArray
                                where item.Length == stringArray.Max(x => x.Length)
                                select item;

            Console.WriteLine("The longest string is: {0}", string.Join(string.Empty, longestString));
        }
    }
}
