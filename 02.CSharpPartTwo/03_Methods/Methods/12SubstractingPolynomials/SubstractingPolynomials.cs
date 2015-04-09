﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SubstractingPolynomials
{
    class SubstractingPolynomials
    {
        static void Main(string[] args)
        {
            //For console input:
            //Console.WriteLine("Enter the size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] firstNumber = InitArray(size);
            //int[] secondNumber = InitArray(size);

            int[] firstNumber = { 3, 3, 3, 3, 3, 3, 3 };

            int[] secondNumber = { 4, -3, 4, 11, 4, -5, 4 };

            Console.WriteLine("The first polynom is:");
            PrintPolynom(firstNumber);


            Console.WriteLine("\nThe second polynom is:");
            PrintPolynom(secondNumber);

            int[] sum = FindSum(firstNumber, secondNumber);
            int[] difference = FindDifference(firstNumber, secondNumber);
            int[] product = FindProduct(firstNumber, secondNumber);

            Console.WriteLine("\nThe sum is:");
            PrintPolynom(sum);
            Console.WriteLine("\nThe difference is:");
            PrintPolynom(difference);
            Console.WriteLine("\nThe product is:");
            PrintPolynom(product);
            Console.WriteLine();
        }

        private static int[] FindSum(int[] firstNumber, int[] secondNumber)
        {
            //Finds the sum of the two numbers.

            int sumSize = firstNumber.GetLength(0);

            int[] sum = new int[sumSize];

            int currentNumber = 0;

            for (int i = sumSize - 1; i >= 0; i--)
            {
                currentNumber = firstNumber[i] + secondNumber[i];

                sum[i] = currentNumber;
            }

            return sum;
        }

        private static int[] FindDifference(int[] firstNumber, int[] secondNumber)
        {
            //Finds the difference of the two numbers.

            int sumSize = firstNumber.GetLength(0);

            int[] result = new int[sumSize];

            int currentNumber = 0;

            for (int i = sumSize - 1; i >= 0; i--)
            {
                currentNumber = firstNumber[i] - secondNumber[i];

                result[i] = currentNumber;
            }

            return result;
        }

        private static int[] FindProduct(int[] firstNumber, int[] secondNumber)
        {
            //Finds the product of the two numbers.

            int sumSize = firstNumber.GetLength(0);

            int[] result = new int[sumSize];

            int currentNumber = 0;

            for (int i = sumSize - 1; i >= 0; i--)
            {
                currentNumber = firstNumber[i] * secondNumber[i];

                result[i] = currentNumber;
            }

            return result;
        }

        private static void PrintPolynom(int[] numbers)
        {
            for (int i = 0, j = numbers.GetLength(0) - 1; i < numbers.GetLength(0); i++, j--)
            {
                if (i == 0)
                {
                    Console.Write("{0}x^{1} ", numbers[i], j);
                    continue;
                }
                if (numbers[i] > 0)
                {
                    Console.Write("+ {0}x^{1} ", numbers[i], j);
                }
                else if (numbers[i] < 0)
                {
                    Console.Write("{0}x^{1} ", numbers[i], j);
                }
                else
                {
                    continue;
                }
            }

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
