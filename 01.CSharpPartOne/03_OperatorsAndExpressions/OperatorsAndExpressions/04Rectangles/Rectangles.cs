using System;

/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the rectangle: ");
        decimal rectangleWidth = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle: ");
        decimal rectangleHeight = decimal.Parse(Console.ReadLine());

        decimal rectanglePerimeter = (2 * rectangleHeight) + (2 * rectangleWidth);
        decimal rectangleArea = rectangleHeight * rectangleWidth;

        Console.WriteLine("The perimeter of the rectangle is : {0}", rectanglePerimeter);
        Console.WriteLine("The area of the rectangle is: {0}", rectangleArea);
    }
}
