using System;

/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 * */
class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the a coefficient: ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the b coefficient: ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the c coefficient: ");
        decimal c = decimal.Parse(Console.ReadLine());

        decimal d = b * b - (4 * a * c);

        decimal x1 = 0m;
        decimal x2 = 0m;

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            x1 = -(b / (2 * a));
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = -((b + (decimal)Math.Sqrt((double)d)) / (2 * a));
            x2 = -((b - (decimal)Math.Sqrt((double)d)) / (2 * a));

            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}
