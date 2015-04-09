using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

namespace _02EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number: ");
            int end = int.Parse(Console.ReadLine());

            try
            {
                ReadNumber(start, end);
            }
            catch (Exception exception)
            {
                Console.WriteLine("The input data is incorrect. [{0}]", exception.Message);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            int[] a = new int[10];
            int min = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("a[{0}] = ", i);
                    a[i] = int.Parse(Console.ReadLine());
                    if (a[i] < start || a[i] > end)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    if (i == 0)
                    {
                        min = a[i];
                    }
                    else
                    {
                        if (min >= a[i])
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            min = a[i];
                        }
                    }

                }
                catch (ArgumentNullException argumentNullException)
                {
                    throw argumentNullException;
                }
                catch (FormatException formatException)
                {
                    throw formatException;
                }
                catch (OverflowException overflowException)
                {
                    throw overflowException;
                }
            }
        }
    }
}
