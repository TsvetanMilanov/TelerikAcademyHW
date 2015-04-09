using System;

/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        

        Console.WriteLine("The greater number is: {0}", Math.Max(firstNumber, secondNumber));
    }
}
