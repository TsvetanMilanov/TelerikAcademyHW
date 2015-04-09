using System;

/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

class ThirdDigitIsSeven
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int lastDigit = 0;
        int counter = 1;
        bool isSeven = false;

        do
        {
            int thirdNumber;
            thirdNumber = number % 10;
            lastDigit = number / 10;
            number = number / 10;

            if (counter == 3 && thirdNumber == 7)
            {
                isSeven = true;
            }

            counter++;
        } while (lastDigit != 0 && number != 0);


        if (isSeven == true)
        {
            Console.WriteLine("(True) The third digit IS 7.");
        }
        else
        {
            Console.WriteLine("(False) The third digit IS NOT 7.");
        }
    }
}
