using System;

/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 * */

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());

        bool aIsInRange = a >= 0 && a <= 500;
        if (!aIsInRange)
        {
            Console.WriteLine("The number a is not between 0 and 500!");
            Environment.Exit(1);
        }
        Console.Write("Enter value for b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter value for c: ");
        float c = float.Parse(Console.ReadLine());

        string aToBinary = Convert.ToString(Convert.ToInt32(Convert.ToString(a), 10), 2).PadLeft(10, '0');

        Console.WriteLine("{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, aToBinary, b, c);
    }
}
