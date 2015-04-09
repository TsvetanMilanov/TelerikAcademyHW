using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
 */

namespace _19DatesFromText
{
    class DatesFromText
    {
        static void Main(string[] args)
        {
            string inputString = "Some dates 22.02.2015, 11.11.1995, 09.01.1993 to test the problem.";

            string format = "dd.MM.yyyy";

            char[] separators = { ' ', ',', '!', '?' };
            string[] splittedString = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> dates = new List<string>();

            DateTime date = new DateTime();

            foreach (var item in splittedString)
            {
                if (DateTime.TryParseExact(item, format, new CultureInfo("en-CA"), System.Globalization.DateTimeStyles.None, out date))
                {
                    dates.Add(item);
                }
            }

            Console.WriteLine(string.Join("\n", dates));
        }
    }
}
