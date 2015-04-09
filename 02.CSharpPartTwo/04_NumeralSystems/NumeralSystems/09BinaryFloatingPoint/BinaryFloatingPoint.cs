using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9.* Binary floating-point

Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
 */

namespace _09BinaryFloatingPoint
{
    class BinaryFloatingPoint
    {
        static void Main(string[] args)
        {
            bool signIsMinus = false;

            Console.Write("Enter number: ");
            float inputNumber = float.Parse(Console.ReadLine());

            string numberAsString = inputNumber.ToString();

            var splittedNumber = numberAsString.TrimStart('-').Split('.');

            string wholePart = Convert.ToString(Convert.ToInt32(splittedNumber[0]), 2);

            string mantissaAsNumber = string.Concat("0.", "");

            mantissaAsNumber += splittedNumber[1];
            float floatMantissa = Convert.ToSingle(mantissaAsNumber);

            int sign = 0;
            string exponent = string.Empty;
            string mantissa = string.Empty;

            if (numberAsString[0] == '-')
            {
                signIsMinus = true;
                sign = 1;
            }

            int counter = 0;
            float temp = Math.Abs(inputNumber);

            while (temp > 2)
            {
                temp /= 2;
                counter++;
            }

            exponent = Convert.ToString(counter + 127, 2);

            float mantissaTemp = temp -1;

            string numberToAddToMantissa = string.Empty;

            int currentSize = 0;

            while (currentSize < 23)
            {
                mantissaTemp *= 2;

                numberToAddToMantissa = ((int)mantissaTemp).ToString();

                mantissa += numberToAddToMantissa;

                if (numberToAddToMantissa == "1")
                {
                    mantissaTemp = GetFraction(mantissaTemp);
                }
                currentSize++;
            }

            Console.WriteLine("Sign: {0}\nExponent: {1}\nMantissa: {2}", sign, exponent, mantissa);

        }

        private static float GetFraction(float mantissaTemp)
        {
            float result = 0;

            result = mantissaTemp - 1;

            return result;
        }
    }
}
