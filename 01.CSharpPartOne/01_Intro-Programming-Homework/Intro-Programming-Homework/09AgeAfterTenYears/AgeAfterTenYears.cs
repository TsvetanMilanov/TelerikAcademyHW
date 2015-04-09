using System;

/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

class CurrentDateAndTime
{
    static void Main(string[] args)
    {
        int currentAge;

        Console.WriteLine("Enter your birthday:");

        String birthdayString = Console.ReadLine();
        DateTime birthday = Convert.ToDateTime(birthdayString);
        DateTime currentDateAndTime = DateTime.Now;

        bool yearIsLesserOrEqual = birthday.Year <= currentDateAndTime.Year;
        bool monthIsLesserOrEqual = birthday.Month <= currentDateAndTime.Month;
        bool dayIsLesserOrEqual = birthday.Day <= currentDateAndTime.Day;
        bool yearIsLesser = birthday.Year < currentDateAndTime.Year;
        bool yearIsBigger = birthday.Year > currentDateAndTime.Year;
        bool monthIsBigger = birthday.Month > currentDateAndTime.Month;
        bool dayIsBigger = birthday.Day > currentDateAndTime.Day;
        bool yearIsEqual = birthday.Year == currentDateAndTime.Year;

        int AgeAfterTenYears;

        if (yearIsLesserOrEqual && monthIsLesserOrEqual && dayIsLesserOrEqual)
        {
            currentAge = currentDateAndTime.Year - birthday.Year;
            Console.WriteLine("Your current age is: {0} years.", currentAge);
            AgeAfterTenYears = currentAge + 10;
            Console.WriteLine("Your age after 10 years will be: {0} years.", AgeAfterTenYears);
        }

        if (yearIsLesser && (monthIsBigger || dayIsBigger))
        {
            currentAge = currentDateAndTime.Year - birthday.Year - 1;
            Console.WriteLine("Your current age is: {0} years.", currentAge);
            AgeAfterTenYears = currentAge + 10;
            Console.WriteLine("Your age after 10 years will be: {0} years.", AgeAfterTenYears);
        }

        if (yearIsBigger|| (yearIsEqual && (monthIsBigger || dayIsBigger)))
        {
            Console.WriteLine("You are not born yet!");
        }

        
    }
}
