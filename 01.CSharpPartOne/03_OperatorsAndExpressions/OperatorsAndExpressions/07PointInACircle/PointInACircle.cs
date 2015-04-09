using System;

/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/

class PointInACircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the X: ");
        decimal x = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the Y: ");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal sqrtValue = (x * x) + (y * y);

        decimal pointDistance = (decimal)Math.Sqrt((double)sqrtValue);

        int circleRadius = 2;

        bool isInsideTheCircle = pointDistance <= circleRadius;

        if (isInsideTheCircle == true)
        {
            Console.WriteLine("(True) The point is INSIDE the circle.");
        }
        else
        {
            Console.WriteLine("(False) The point is OUTSIDE the circle.");
        }
    }
}
