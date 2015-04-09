using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
 */

namespace _03DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is: {0}", DateTime.Now.DayOfWeek);
        }
    }
}
