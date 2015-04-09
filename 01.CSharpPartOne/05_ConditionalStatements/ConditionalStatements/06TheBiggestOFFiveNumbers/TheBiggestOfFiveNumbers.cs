using System;

/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
 */

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("First number:");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Second number:");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Fourth number:");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Fifth number:");
        double fifthNumber = double.Parse(Console.ReadLine());

        bool firstNumberIsBiggest = firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber;

        bool secondNumberIsBiggest = secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber;

        bool thirdNumberIsBiggest = thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber;

        bool fourthNumberIsBiggest = fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber;

        bool fifthNumberIsBiggest = fifthNumber >= firstNumber && fifthNumber >= secondNumber && fifthNumber >= fourthNumber && fifthNumber >= thirdNumber;


        if (firstNumberIsBiggest)
        {
            Console.WriteLine("The biggest number is {0}", firstNumber);
        }
        else if (secondNumberIsBiggest)
        {
            Console.WriteLine("The biggest number is {0}", secondNumber);
        }
        else if (thirdNumberIsBiggest)
        {
            Console.WriteLine("The biggest number is {0}", thirdNumber);
        }
        else if (fourthNumberIsBiggest)
        {
            Console.WriteLine("The biggest number is {0}", fourthNumber);
        }
        else if (fifthNumberIsBiggest)
        {
            Console.WriteLine("The biggest number is {0}", fifthNumber);
        }
    }
}
