using System;

/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * */
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 0;

        string[] sequence = new string[100];
        sequence[0] = "0";
        sequence[1] = "1";

        for (int i = 0; i < n; i++)
        {
            currentNumber = Convert.ToInt32(sequence[i]) + Convert.ToInt32(sequence[i + 1]);
            sequence[i + 2] = Convert.ToString(currentNumber);

            if (i < n - 1)
            {
                Console.Write("{0}, ", sequence[i]);
            }
            if (i == n - 1)
            {
                Console.WriteLine("{0}", sequence[i]);
            }
        }
    }
}
