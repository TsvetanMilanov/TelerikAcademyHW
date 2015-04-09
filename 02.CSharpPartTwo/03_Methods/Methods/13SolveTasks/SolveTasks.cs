using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

namespace _13SolveTasks
{
    class SolveTasks
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                PrintMenu();
                choice = int.Parse(Console.ReadLine());

            } while (choice < 1 || choice > 3);

            switch (choice)
            {
                case 1:
                    ReverseDigits();
                    break;
                case 2:
                    CalculateTheAverage();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;
                default:
                    Console.WriteLine("Not vaild choice!");
                    break;
            }


        }

        private static void SolveLinearEquation()
        {
            int a = 0;
            int b = 0;
            do
            {
                Console.Write("Enter the value of a: ");
                a = int.Parse(Console.ReadLine());

            } while (a == 0);

            Console.Write("Enter the value of b: ");
            b = int.Parse(Console.ReadLine());

            decimal result = (decimal)(-b) / a;

            Console.WriteLine("The result is: {0:F3}", result);
        }

        private static void CalculateTheAverage()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }

            decimal average = (decimal)sum / n;

            Console.WriteLine("The average of the sequence is: {0:F3}", average);
        }

        private static void ReverseDigits()
        {
            Console.Write("\nEnter the number: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 0)
            {
                Console.WriteLine("The nuber is negative. Please enter non-negative.");
                Console.Write("Enter the number: ");
                number = int.Parse(Console.ReadLine());
            }

            int reversedNumber = 0;
            int tempNumber = number;
            int currentDigit = 0;

            string digitAsString = "";

            while (tempNumber != 0)
            {
                currentDigit = tempNumber % 10;

                digitAsString += currentDigit;

                tempNumber /= 10;
            }

            reversedNumber = int.Parse(digitAsString);

            Console.WriteLine("The reversed number is: {0}", reversedNumber);

        }

        private static void PrintMenu()
        {
            Console.WriteLine("----------===MENU===----------");
            Console.WriteLine("[1] -> Reverse digits of number.");
            Console.WriteLine("[2] -> Calculate the average of a sequence of integers.");
            Console.WriteLine("[3] -> Solve a linear equation.");
            Console.Write("Enter the number of the option: ");
        }
    }
}
