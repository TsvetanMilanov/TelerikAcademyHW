using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
 */

namespace _01LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int inputYear = int.Parse(Console.ReadLine());

            bool isLeapYear = DateTime.IsLeapYear(inputYear);

            Console.WriteLine("The year {0}, id leap: {1}", inputYear, isLeapYear);
        }
    }
}
