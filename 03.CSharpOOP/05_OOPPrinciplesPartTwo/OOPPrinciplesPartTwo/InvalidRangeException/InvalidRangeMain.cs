namespace InvalidRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InvalidRangeMain
    {
        public static void Main(string[] args)
        {
            int integerStart = 0;
            int integerEnd = 7;

            try
            {
                Console.WriteLine("Enter integer number:");
                int integerInput = int.Parse(Console.ReadLine());

                if (integerInput < integerStart || integerInput > integerEnd)
                {
                    throw new InvalidRangeException<int>(integerStart, integerEnd, "The integer number is out of range.");
                }
            }
            catch (InvalidRangeException<int> intException)
            {
                Console.Write(intException.Message);
                Console.WriteLine("[{0} , {1}]", intException.Start, intException.End);
            }

            DateTime startDate = new DateTime(2015, 1, 1);

            DateTime endDate = DateTime.Now;

            try
            {
                Console.WriteLine("Enter date in format YYYY.MM.DD:");
                DateTime dateInput = DateTime.Parse(Console.ReadLine());

                if (dateInput < startDate || dateInput > endDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate, "The integer number is out of range.");
                }
            }
            catch (InvalidRangeException<DateTime> dateTimeException)
            {
                Console.Write(dateTimeException.Message);
                Console.WriteLine("[{0} , {1}]", dateTimeException.Start, dateTimeException.End);
            }
        }
    }
}
