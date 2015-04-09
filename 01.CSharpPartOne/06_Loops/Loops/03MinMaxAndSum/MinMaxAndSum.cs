using System;

/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */

class MinMaxAndSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        decimal average = 0.0m;

        int number = 0;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                min = number;
                max = number;
            }

            sum += number;

            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
        }
        average = sum / (decimal)n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, average);
    }
}
