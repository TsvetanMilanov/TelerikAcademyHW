using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second
and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

namespace _17DateTimeInBulgarian
{
    class DateTimeInBulgarian
    {
        static void Main(string[] args)
        {
            string format = "d.MM.yyyy HH:mm:ss";

            CultureInfo bgBG = new CultureInfo("bg-BG");

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Enter the date in format d.MM.yyyy HH:mm:ss");
            string dateAsString = Console.ReadLine();

            DateTime date = new DateTime();
            DateTime.TryParseExact(dateAsString, format, bgBG, DateTimeStyles.None, out date);

            date.GetDateTimeFormats(bgBG);

            int hoursToAdd = 6;
            int minutesToAdd = 30;

            date = date.AddHours(hoursToAdd);
            date = date.AddMinutes(minutesToAdd);
            Dictionary<string, string> daysOfWeek = new Dictionary<string, string>();

            daysOfWeek["Monday"] = "Понеделник";
            daysOfWeek["Tuesday"] = "Вторник";
            daysOfWeek["Wednesday"] = "Сряда";
            daysOfWeek["Thursday"] = "Четвъртък";
            daysOfWeek["Friday"] = "Петък";
            daysOfWeek["Saturday"] = "Събота";
            daysOfWeek["Sunday"] = "Неделя";

            Console.WriteLine("{0} {1}", date.ToString(format, bgBG), daysOfWeek[date.DayOfWeek.ToString()]);
        }
    }
}
