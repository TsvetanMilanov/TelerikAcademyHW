using System;

/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        bool isNotDividable = number % 5 != 0 || number % 7 != 0 || number == 0;
        bool result;

        if (isNotDividable)
        {
            result = false;
        }
        else
        {
            result = true;
        }

        if (result == true)
        {
            Console.WriteLine("(True) The number {0} CAN be divided by 5 and 7 without remainder.", number);
        }
        else
        {
            Console.WriteLine("(False) The number {0} CAN NOT be divided by 5 and 7 without remainder.", number);
        }
    }
}
