namespace Methods
{
    using System;

    public class Methods
    {
        private enum NumberFormats
        {
            FixedPoint,
            Percent,
            RoundTrip
        }

        private static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("Invalid side sizes. The biggest side's size must be less than the sum of the other two!");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter *
                                    (halfPerimeter - a) *
                                    (halfPerimeter - b) *
                                    (halfPerimeter - c));

            return area;
        }

        private static string ConvertNumberToDigit(int number)
        {
            string digit = string.Empty;

            switch (number)
            {
                case 0:
                    digit = "zero";
                    break;
                case 1:
                    digit = "one";
                    break;
                case 2:
                    digit = "two";
                    break;
                case 3:
                    digit = "three";
                    break;
                case 4:
                    digit = "four";
                    break;
                case 5:
                    digit = "five";
                    break;
                case 6:
                    digit = "six";
                    break;
                case 7:
                    digit = "seven";
                    break;
                case 8:
                    digit = "eight";
                    break;
                case 9:
                    digit = "nine";
                    break;
                default:
                    throw new ArgumentException("Invalid number!");
            }

            return digit;
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The elements array must not be empty or null!");
            }

            int maxElement = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                int currentElement = elements[i];

                if (maxElement < currentElement)
                {
                    maxElement = currentElement;
                }
            }

            return maxElement;
        }

        private static void PrintAsNumber(object number, NumberFormats format)
        {
            if (format == NumberFormats.FixedPoint)
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == NumberFormats.Percent)
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == NumberFormats.RoundTrip)
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        private static DistanceWithType CalcDistance(double x1, double y1, double x2, double y2)
        {
            bool isHorizontal = (y1 == y2);
            bool isVertical = (x1 == x2);

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            DistanceWithType distanceWithType = new DistanceWithType(distance, isHorizontal, isVertical);

            return distanceWithType;
        }

        private static void Main()
        {
            double triangleArea = CalcTriangleArea(3, 4, 5);
            Console.WriteLine("The triangle area is: {0}", triangleArea);

            int number = 5;
            string digit = ConvertNumberToDigit(number);
            Console.WriteLine("The number {0} is -> {1}", number, digit);

            int[] arrayOfNumbers = new int[] { 5, -1, 3, 2, 14, 2, 3 };
            int maxNumber = FindMax(arrayOfNumbers);
            Console.WriteLine("The max element in [{0}] is: {1}", string.Join(", ", arrayOfNumbers), maxNumber);

            Console.WriteLine("\n----- Formatted numbers -----");
            PrintAsNumber(1.3, NumberFormats.FixedPoint);
            PrintAsNumber(0.75, NumberFormats.Percent);
            PrintAsNumber(2.30, NumberFormats.RoundTrip);
            Console.WriteLine("-----------------------------\n");

            DistanceWithType distanceWithType = CalcDistance(3, -1, 3, 2.5);
            bool isHorizontal = distanceWithType.IsHorizontal;
            bool isVertical = distanceWithType.IsVertical;
            double distance = distanceWithType.Distance;

            Console.WriteLine("The distance is: {0}", distance);
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            bool peterIsOlderThanStella = peter.IsOlderThan(stella);

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peterIsOlderThanStella);
        }
    }
}
