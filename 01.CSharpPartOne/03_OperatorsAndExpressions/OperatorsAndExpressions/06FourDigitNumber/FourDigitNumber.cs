using System;

/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = 0;
        int secondDigit = 0;
        int thirdDigit = 0;
        int fourthDigit = 0;
        int counter = 1;

        do
        {
            switch (counter)
            {
                case 1:
                    fourthDigit = number % 10;
                    break;
                case 2:
                    thirdDigit = number % 10;
                    break;
                case 3:
                    secondDigit = number % 10;
                    break;
                case 4:
                    firstDigit = number % 10;
                    break;
            }
            number = number / 10;
            counter++;
        } while (counter < 5);

        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

        Console.WriteLine("The sum of the digits is: {0}", sum);
        Console.WriteLine("The revers order is: {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Last digit infront: {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Second and third digit replaced: {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}
