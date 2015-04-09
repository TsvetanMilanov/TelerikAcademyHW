using System;

/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? firstVariable = null;
        double? secondVariable = null;

        Console.WriteLine("!{0}!", firstVariable);
        Console.WriteLine("!{0}!", secondVariable);

        Console.WriteLine("!{0}!", firstVariable + null);
        Console.WriteLine("!{0}!", secondVariable + 5);
    }
}