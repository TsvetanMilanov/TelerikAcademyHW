using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

namespace _05WorkDays
{
    class WorkDays
    {
       static DateTime[] listOfHolidays = { new DateTime(2015, 02, 23), new DateTime(2015, 02, 24), new DateTime(2015, 02, 26), new DateTime(2015, 02, 27) };

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            Console.Write("Enter the end date YYYY.MM.DD: ");
            var endDate = DateTime.Parse(Console.ReadLine());

            int workDaysCounter = CountWorkDays(endDate);

            Console.Write("The count of the workdays between {0:dd.m.yyyy} and {1:dd.m.yyyy} is: {2}\n", DateTime.Now, endDate, workDaysCounter);
        }

        private static int CountWorkDays(DateTime endDate)
        {
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            int workDaysCounter = 0;
            var daysCount = (endDate - startDate).Days;

            for (int i = 0; i < daysCount; i++)
            {
                currentDate = startDate.AddDays(i);

                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday && !(listOfHolidays.Contains(currentDate)))
                {
                    workDaysCounter++;
                }
            }

            return workDaysCounter;
        }
    }
}
