using System;

/*Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

class FloatOrDouble
{
    static void Main(string[] args)
    {
        float firstVariable = 12.345f;
        float secondVariable = 3456.091f;
        double thirdVariable = 34.567839023;
        double fourthVariable = 8923.1234857;

        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
        Console.WriteLine(thirdVariable);
        Console.WriteLine(fourthVariable);
    }
}
