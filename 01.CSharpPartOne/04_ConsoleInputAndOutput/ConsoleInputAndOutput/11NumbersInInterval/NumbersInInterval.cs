using System;

/*Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */
class NumbersInInterval
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        int sequenceStart = Math.Min(a, b);
        int sequenceEnd = Math.Max(a, b);

        int p = 0;

        string[] comment = new string[100];
        string commentString = "";

        for (int i = sequenceStart, j = 0; i <= sequenceEnd; i++)
        {
            if (i % 5 == 0)
            {
                comment[j] = Convert.ToString(i);
                commentString +=comment[j] + " ";
                j++;
                p++;
            }
        }

        Console.WriteLine("p = {0}\ncomments: {1}", p, commentString);
    }
}
