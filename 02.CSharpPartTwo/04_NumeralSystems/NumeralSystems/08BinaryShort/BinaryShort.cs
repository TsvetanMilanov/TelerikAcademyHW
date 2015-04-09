using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

namespace _08BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            int maxNum = short.MaxValue;
            int inputNumber = 0;

            Console.WriteLine("Enter the number:");
            do
            {
                inputNumber = int.Parse(Console.ReadLine());

            } while (inputNumber > maxNum);

            bool isNegative = false;

            if (inputNumber < 0)
            {
                isNegative = true;
                inputNumber += maxNum;
            }

            string result = "";

            while (inputNumber != 0)
            {
                result += (inputNumber % 2);

                inputNumber /= 2;
            }

            if (isNegative)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }
            Console.WriteLine(result);
        }
    }
}
