using System;

/*Problem 14.* Current Date and Time

Create a console application that prints the current date and time. Find out how in Internet.*/

class CurrentDateAndTime
{
    static void Main(string[] args)
    {
        DateTime currentDateAndTime = DateTime.Now;
        Console.WriteLine("The current date and time is: {0}", currentDateAndTime);
    }
}
