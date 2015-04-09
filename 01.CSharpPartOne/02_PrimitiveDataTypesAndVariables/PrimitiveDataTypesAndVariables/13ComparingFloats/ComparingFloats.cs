using System;

/*Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature
of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely
to each other than a fixed constant eps.*/

class ComparingFloats
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double eps = 0.000001;

        if(Math.Abs(firstNumber-secondNumber)>eps)
        {
            Console.WriteLine("\nThe numbers are NOT equal! (false)");
        }
        else
        {
            Console.WriteLine("\nThe numbers ARE equal! (true)");
        }

    }
}