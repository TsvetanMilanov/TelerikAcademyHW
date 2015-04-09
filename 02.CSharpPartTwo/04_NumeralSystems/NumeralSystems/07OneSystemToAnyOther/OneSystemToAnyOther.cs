using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

namespace _07OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static string numbers = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string inputNumber = Console.ReadLine();
            inputNumber = inputNumber.ToUpper();

            Console.WriteLine("Enter the base numeral system:");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the head numeral system:");
            int d = int.Parse(Console.ReadLine());

            int decimalRepresentation = ConvertToDecimal(inputNumber, s);

            string finalResult = ConvertToHeadNumeralSystem(decimalRepresentation, d);

            Console.WriteLine("\nThe number [{0}]({1}) = [{2}]({3}).", inputNumber, s, finalResult, d);

        }

        private static string ConvertToHeadNumeralSystem(int decimalRepresentation, int d)
        {
            string result = "";
            int temp = decimalRepresentation;

            while (temp != 0)
            {
                char symbol = numbers[(temp % d)];

                result += symbol;

                temp /= d;
            }

            string finalResult = "";

            for (int i = 0, j = result.Length - 1; i < result.Length; i++, j--)
            {
                finalResult += result[j];
            }

            return finalResult;
        }

        private static int ConvertToDecimal(string inputNumber, int s)
        {
            int result = 0;
            int currentNumber = 0;
            int currentPow = 0;

            for (int i = inputNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                currentNumber = numbers.IndexOf(inputNumber[i]);
                currentPow = (int)Math.Pow(s, j);
                result = result + (currentNumber * currentPow);
            }

            return result;
        }


    }
}
