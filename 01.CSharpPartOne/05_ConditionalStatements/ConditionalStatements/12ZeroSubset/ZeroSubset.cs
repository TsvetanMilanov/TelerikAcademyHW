using System;

/*Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
 */

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("-----------------------------------");

        int[] numbers = { a, b, c, d, e };

        bool thereIsNoSubset = true;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (numbers[i] + numbers[j] == 0)
                {
                    thereIsNoSubset = false;
                    Console.WriteLine("{0} + {1}", numbers[i], numbers[j]);
                }
            }
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j || i + 1 == j)
                {
                    continue;
                }
                if (numbers[i] + numbers[i+1] + numbers[j] == 0)
                {
                    thereIsNoSubset = false;
                    Console.WriteLine("{0} + {1} + {2}", numbers[i], numbers[i + 1], numbers[j]);
                }
            }
        }

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j || i + 1 == j || i + 2 == j)
                {
                    continue;
                }
                if (numbers[i] + numbers[i + 1] + numbers[i + 2] + numbers[j] == 0)
                {
                    thereIsNoSubset = false;
                    Console.WriteLine("{0} + {1} + {2} + {3}", numbers[i], numbers[i + 1], numbers[i + 2], numbers[j]);
                }
            }
        }

        for (int i = 0; i < numbers.Length - 3; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == j || i + 1 == j || i + 2 == j || i+3 == j)
                {
                    continue;
                }
                if (numbers[i] + numbers[i + 1] + numbers[i + 2] + numbers[i + 3] + numbers[j] == 0)
                {
                    thereIsNoSubset = false;
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4}", numbers[i], numbers[i + 1], numbers[i + 2], numbers[i + 3], numbers[j]);
                }
            }
        }

        if (thereIsNoSubset)
        {
            Console.WriteLine("There is no zero subset.");
        }
    }
}
