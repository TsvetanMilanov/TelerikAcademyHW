using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */

namespace _16DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            string dateFormat = "d.MM.yyyy";

            string firstDateAsString = "27.02.2006";

            DateTime firstDate = new DateTime();

            DateTime.TryParseExact(firstDateAsString, dateFormat, enUS, System.Globalization.DateTimeStyles.None, out firstDate);


            string secondDateAsString = "3.03.2006";

            DateTime secondDate = new DateTime();

            DateTime.TryParseExact(secondDateAsString, dateFormat, enUS, System.Globalization.DateTimeStyles.None, out secondDate);

            var result = secondDate - firstDate;

            int days = result.Days;

            Console.WriteLine("Distance: {0} days.", days);
        }
    }
}
