using System;

/*Problem 19.** Spiral Matrix

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
 */

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];


        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        int currentNumber = 1;

        do
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = currentNumber;
                currentNumber++;
            }
            top += 1;

            for (int j = top; j <= bottom; j++)
            {
                matrix[j, right] = currentNumber;
                currentNumber++;
            }
            right -= 1;

            for (int k = right; k >= left; k--)
            {
                matrix[bottom, k] = currentNumber;
                currentNumber++;
            }
            bottom -= 1;

            for (int l = bottom; l >= top; l--)
            {
                matrix[l, left] = currentNumber;
                currentNumber++;
            }
            left += 1;

        } while (currentNumber <= n * n);

        for (int z = 0; z < n; z++)
        {
            for (int x = 0; x < n; x++)
            {
                Console.Write("{0,4}", matrix[z, x]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}