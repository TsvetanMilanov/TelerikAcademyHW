using System;
/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius: ");
        decimal radius = decimal.Parse(Console.ReadLine());

        decimal perimeter = 2.0m * (decimal)(Math.PI) * radius;
        decimal area = (decimal)Math.PI * (decimal)(Math.Pow((double)radius, 2));

        Console.WriteLine("The Perimeter of the circle with radius r = {0} is: {1: 0.00}\nThe Aarea of the circle with radius r = {2} is: {3: 0.00}", radius, perimeter, radius, area);
    }
}
