using System;

/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Enter value for a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter value for h: ");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = ((a + b) / 2) * h;
        Console.WriteLine("The area of trapezoid with a = {0}, b = {1} and h = {2} is: {3}", a, b, h, area);
    }
}
