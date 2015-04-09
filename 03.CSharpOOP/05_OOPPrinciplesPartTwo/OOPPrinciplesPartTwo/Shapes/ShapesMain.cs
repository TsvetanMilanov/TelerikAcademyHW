namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapesMain
    {
        public static void Main(string[] args)
        {
            Shape[] arrayOfShapes = new Shape[]
                                                {
                                                    new Rectangle(4, 3),
                                                    new Square(5),
                                                    new Triangle(3, 7)
                                                };

            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine("The surface of {0} is: {1:F1} cm2.", shape.GetType().ToString().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries)[1], shape.CalculateSurface());
            }
        }
    }
}
