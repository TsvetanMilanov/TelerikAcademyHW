namespace ProductsSearch
{
    using System;
    using System.Text;

    public static class RandomDataGenerator
    {
        private static Random random = new Random();
        private static string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static int GetRandomNumberInRange(int minNumber = 0, int maxNumber = int.MaxValue - 1)
        {
            int result = 0;

            result = random.Next(minNumber, maxNumber + 1);

            return result;
        }

        public static string GetRandomString(int minLength = 1, int maxLength = 2000)
        {
            var length = GetRandomNumberInRange(minLength, maxLength);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                result.Append(englishAlphabet[GetRandomNumberInRange(0, englishAlphabet.Length - 1)]);
            }

            return result.ToString();
        }
    }
}
