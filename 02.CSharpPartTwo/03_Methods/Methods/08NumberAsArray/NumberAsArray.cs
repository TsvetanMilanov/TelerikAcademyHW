using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

namespace _08NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            //For console input:
            //Console.WriteLine("Enter the size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] firstNumber = InitArray(size);
            //int[] secondNumber = InitArray(size);

            int[] firstNumber = { 3, 3, 3, 3, 3, 3, 3 };

            int[] secondNumber = { 4, 4, 4, 4, 4, 4, 4 };

            PrintArray(firstNumber);
            PrintArray(secondNumber);

            int[] sum = FindSum(firstNumber, secondNumber);

            string result = string.Join("", sum);

            Console.WriteLine("The sum is:\n{0}", result);

        }

        private static int[] FindSum(int[] firstNumber, int[] secondNumber)
        {
            //Finds the sum of the two numbers.

            int sumSize = firstNumber.GetLength(0);

            int[] sum = new int[sumSize];

            int currentNumber = 0;

            int toBeAdded = 0;

            for (int i = sumSize - 1; i >= 0; i--)
            {
                currentNumber = firstNumber[i] + secondNumber[i] + toBeAdded;

                //If the sum of the current positions is bigger than 9 add the rest to the next position.
                toBeAdded = GetNumberToBeAdded(currentNumber);

                if (i > 0)
                {
                    sum[i] = currentNumber % 10;
                }
                else
                {
                    sum[i] = currentNumber;
                }


            }

            return sum;
        }

        private static int GetNumberToBeAdded(int currentNumber)
        {
            //Finds the number which needs to be added to the next position.

            int numberToBeAdded = 0;

            string numberAsString = Convert.ToString(currentNumber);

            string addedNumber = "";

            for (int i = 0; i < numberAsString.Length - 1; i++)
            {
                addedNumber += (char)numberAsString[i];
            }
            if (addedNumber != "")
            {
                numberToBeAdded = Convert.ToInt32(addedNumber);
            }
            else
            {
                numberToBeAdded = 0;
            }

            return numberToBeAdded;
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine("The array is:\n");

            string result = string.Join(", ", numbers);

            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static int[] InitArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return array;
        }
    }
}