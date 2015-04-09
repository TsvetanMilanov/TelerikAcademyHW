using System;

/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */

class BeerTime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the time:");
        DateTime time = DateTime.Parse(Console.ReadLine());

        string timeOFDay = time.ToString();

        if (time.Hour >= 3 && time.Hour < 13)
        {
            Console.WriteLine("Non-beer time.");
        }
        else
        {
            Console.WriteLine("Beer time.");
        }
    }
}
