namespace StudentsSystem.DataImporter
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

        public static DateTime GetRandomDate(DateTime? minDate = null, DateTime? maxDate = null)
        {
            minDate = minDate ?? new DateTime(1990, 1, 1, 0, 0, 1);
            maxDate = maxDate ?? new DateTime(2050, 12, 28, 23, 59, 59);

            int year = GetRandomNumberInRange(minDate.Value.Year, maxDate.Value.Year);
            int month = GetRandomNumberInRange(minDate.Value.Month, maxDate.Value.Month);
            int day = GetRandomNumberInRange(minDate.Value.Day, maxDate.Value.Day);
            int hour = GetRandomNumberInRange(minDate.Value.Hour, maxDate.Value.Hour);
            int minute = GetRandomNumberInRange(minDate.Value.Minute, maxDate.Value.Minute);
            int second = GetRandomNumberInRange(minDate.Value.Second, maxDate.Value.Second);

            if (month == 2 && day > 28)
            {
                day = 28;
            }

            DateTime result = new DateTime(year, month, day, hour, minute, second);

            return result;
        }
    }
}
