using System;

/*Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
 */

class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number between 0 and 999:");
        double number = double.Parse(Console.ReadLine());

        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        string[] decimals = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string[] tenToTwenty = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        string[] hundreds = { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };

        if ((number < 0) || (number > 999) || ((number % 1) != 0))
        {
            Console.WriteLine("Enter correct number.");
            Environment.Exit(1);
        }

        string numberString = "";

        int firstDigit = (int)number % 10;
        int secondDigit = (int)(number % 100) / 10;
        int thirdDigit = (int)number / 100;

        if (thirdDigit != 0)
        {
            if (secondDigit != 0)
            {
                numberString += hundreds[thirdDigit - 1] + " and";
            }
            else
            {
                numberString += hundreds[thirdDigit - 1];
            }


        }
        if (secondDigit != 0)
        {
            if (secondDigit == 1 && firstDigit != 0)
            {
                numberString += " " + tenToTwenty[firstDigit - 1];
                Console.WriteLine(numberString);
                Environment.Exit(1);
            }
            else
            {
                numberString += " " + decimals[secondDigit - 1];
            }
        }
        if (firstDigit != 0)
        {
            if (secondDigit == 0)
            {
                numberString += " and " + digits[firstDigit];
            }
            else
            {
                numberString += " " + digits[firstDigit];
            }
        }
        Console.WriteLine(numberString);
    }
}
