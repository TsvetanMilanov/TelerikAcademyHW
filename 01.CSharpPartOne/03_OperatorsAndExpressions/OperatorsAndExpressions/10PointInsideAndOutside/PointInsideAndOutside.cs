using System;

class PointInsideAndOutside
{
    static void Main(string[] args)
    {
        decimal xDistanceFromZero = 1M;
        decimal yDistanceFromZero = 1M;
        decimal circleRadius = 1.5M;

        decimal top = 1M;
        decimal left = -1M;
        decimal width = 6M;
        decimal height = 2M;

        Console.Write("Enter the X: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the Y: ");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal sqrtValue = ((x - xDistanceFromZero) * (x - xDistanceFromZero) + ((y - yDistanceFromZero) * (y - yDistanceFromZero)));

        decimal pointDistance = (decimal)Math.Sqrt((double)sqrtValue);

        bool isInsideTheCircle = pointDistance <= (circleRadius);
        bool isOutsideTheRectangle = x > (width - left) || y > (height - top);

        if (isInsideTheCircle == true && isOutsideTheRectangle == true)
        {
            Console.WriteLine("(True) The point x({0}, {1}) is inside the circle and outside the rectangle.", x, y);
        }
        else
        {
            Console.WriteLine("(False) The point x({0}, {1}) is NOT inside the circle and NOT outside the rectangle.", x, y);
        }
    }
}
