using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

namespace _04TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            decimal areaBySideAndAltitude = FindAreaBySideAndAltitude();
            Console.WriteLine("The area of the triangle by given side and an altitude to it is : {0}", areaBySideAndAltitude);

            decimal areaByThreeSides = FindAreaByThreeSides();
            Console.WriteLine("The area of the triangle by given three sides is : {0}", areaByThreeSides);

            decimal areaByTwoSidesAndAngle = FindAreaByTwoSidesAndAngle();
            Console.WriteLine("The area of the triangle by given two sides and an angle between them is : {0}", areaByTwoSidesAndAngle);
        }

        private static decimal FindAreaByTwoSidesAndAngle()
        {
            decimal area = 0;

            Console.Write("Enter the size of side a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of side b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the angle: ");
            int angle = int.Parse(Console.ReadLine());

            double angleInRadians = angle * (Math.PI / 180);

            double sinOfAngle = Math.Sin(angleInRadians);

            area = (decimal)(a * b * sinOfAngle) / 2;

            return area;
        }

        private static decimal FindAreaByThreeSides()
        {
            decimal area = 0;

            Console.Write("Enter the size of side a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of side b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of side c: ");
            int c = int.Parse(Console.ReadLine());

            int p = a + b + c;

            area = (decimal)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        private static decimal FindAreaBySideAndAltitude()
        {
            decimal area = 0;

            Console.Write("Enter the size of the side: ");
            int sizeOfSide = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the altitude: ");
            int altitude = int.Parse(Console.ReadLine());

            area = (sizeOfSide * altitude) / 2;

            return area;
        }
    }
}
